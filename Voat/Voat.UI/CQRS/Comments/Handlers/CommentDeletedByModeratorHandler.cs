using MediatR;
using Voat.CQRS.Comments.Events;

namespace Voat.CQRS.Comments.Handlers
{
    public class CommentDeletedByModeratorHandler : INotificationHandler<CommentDeletedByModerator>
    {
        public void Handle(CommentDeletedByModerator notification)
        {
            var deletedBy = notification.DeletedBy.Name;
            var deletedOn = notification.DeletedOn;
            var comment = notification.Comment;
            var subverse = comment.Message.Subverse;

            Utils.MesssagingUtility.SendPrivateMessage(
                "Voat",
                notification.Comment.Name,
                "Your comment has been deleted by a moderator",
                string.Format("Your [comment(/v/{0}/comments/{1}/{2} has been deleted by: /u/{3} on: {4}\n" +
                    "Original comment content was:\n---\n{5}",
                    subverse, comment.MessageId, comment.Id, deletedBy, deletedOn, comment.CommentContent)

            );
        }
    }
}
