using MediatR;
using Voat.CQRS.Comments.Commands;
using Voat.Models;

namespace Voat.CQRS.Comments.Handlers
{
    public class AddRemovalLogHandler : IRequestHandler<AddRemovalLog, bool>
    {
        private readonly voatEntities _Db;

        public AddRemovalLogHandler(voatEntities db)
        {
            _Db = db;
        }

        public bool Handle(AddRemovalLog message)
        {
            _Db.CommentRemovalLogs.Add(new CommentRemovalLog
            {
                CommentId = message.Comment.Id,
                Moderator = message.DeletedBy.Name,
                ReasonForRemoval = message.ReasonForRemoval,
                RemovalTimestamp = message.DeletedOn
            });

            _Db.SaveChanges();

            return true;
        }
    }
}
