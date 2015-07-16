using MediatR;
using Voat.Models;

namespace Voat.CQRS.Comments.Queries
{
    public class FindCommentById : IRequest<Comment>
    {
        public int CommentId { get; set; }
    }
}