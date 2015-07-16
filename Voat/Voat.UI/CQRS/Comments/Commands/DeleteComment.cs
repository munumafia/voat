using System;
using System.Security.Principal;
using MediatR;

namespace Voat.CQRS.Comments.Commands
{
    public class DeleteComment : IRequest<bool>
    {
        public int CommentId { get; set; }
        public DateTime DeletedOn { get; set; }
        public IIdentity DeletedBy { get; set; }
        public string ReasonForDeletion { get; set; }
    }
}