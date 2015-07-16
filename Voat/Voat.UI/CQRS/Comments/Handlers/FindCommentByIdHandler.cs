using MediatR;
using Voat.CQRS.Comments.Queries;
using Voat.Models;

namespace Voat.CQRS.Comments.Handlers
{
    public class FindCommentByIdHandler : IRequestHandler<FindCommentById, Comment>
    {
        private readonly voatEntities _Db;

        public FindCommentByIdHandler(voatEntities db)
        {
            _Db = db;
        }

        public Comment Handle(FindCommentById message)
        {
            return _Db.Comments.Find(message.CommentId);
        }
    }
}