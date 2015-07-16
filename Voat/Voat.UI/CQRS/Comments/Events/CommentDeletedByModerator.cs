using System;
using System.Security.Principal;
using MediatR;
using Voat.Models;

namespace Voat.CQRS.Comments.Events
{
    public class CommentDeletedByModerator : INotification
    {
        public Comment Comment { get; set; }
        public IIdentity DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
