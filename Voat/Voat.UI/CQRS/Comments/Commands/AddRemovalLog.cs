using System;
using System.Security.Principal;
using MediatR;
using Voat.Models;

namespace Voat.CQRS.Comments.Commands
{
    public class AddRemovalLog : IRequest<bool>
    {
        public Comment Comment { get; set; }
        public IIdentity DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public string ReasonForRemoval { get; set; }
    }
}
