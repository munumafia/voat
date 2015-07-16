using MediatR;
using Voat.CQRS.Comments.Commands;
using Voat.CQRS.Comments.Events;
using Voat.CQRS.Comments.Queries;
using Voat.Models;

namespace Voat.CQRS.Comments.Handlers
{
    public class DeleteCommentHandler : IRequestHandler<DeleteComment, bool>
    {
        private readonly voatEntities _Db;
        private readonly IMediator _Mediator;

        public DeleteCommentHandler(voatEntities db, IMediator mediator)
        {
            _Db = db;
            _Mediator = mediator;
        }

        public bool Handle(DeleteComment message)
        {
            var comment = _Mediator.Send(new FindCommentById { CommentId = message.CommentId });

            if (comment == null) return false;

            comment.Name = "deleted";
            var subverse = comment.Message.Subverse;

            if (comment.Name == message.DeletedBy.Name)
            {
                comment.CommentContent = string.Format("deleted by author at {0}", message.DeletedOn);
                _Db.SaveChanges();
                return true;
            }

            var isAdmin = Utils.User.IsUserSubverseAdmin(message.DeletedBy.Name, subverse);
            var isModerator = Utils.User.IsUserSubverseModerator(message.DeletedBy.Name, subverse);

            if (!isAdmin || !isModerator) return false;

            _Mediator.Send(new AddRemovalLog
            {
                Comment = comment,
                DeletedBy = message.DeletedBy,
                DeletedOn = message.DeletedOn,
                ReasonForRemoval = message.ReasonForDeletion
            });

            _Mediator.Publish(new CommentDeletedByModerator
            {
                Comment = comment,
                DeletedBy = message.DeletedBy,
                DeletedOn = message.DeletedOn
            });

            return true;
        }
    }
}