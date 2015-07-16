using System.Data.Entity;
using Voat.Models;

namespace Voat.Persistence
{
    public interface IVoatDbContext
    {
        DbSet<Badge> Badges { get; }
        DbSet<Userbadge> Userbadges { get; }
        DbSet<Promotedsubmission> Promotedsubmissions { get; }
        DbSet<Userpreference> Userpreferences { get; }
        DbSet<Moderatorinvitation> Moderatorinvitations { get; }
        DbSet<Banneddomain> Banneddomains { get; }
        DbSet<Privatemessage> Privatemessages { get; }
        DbSet<Commentreplynotification> Commentreplynotifications { get; }
        DbSet<Banneduser> Bannedusers { get; }
        DbSet<Subscription> Subscriptions { get; }
        DbSet<Postreplynotification> Postreplynotifications { get; }
        DbSet<Sessiontracker> Sessiontrackers { get; }
        DbSet<Commentvotingtracker> Commentvotingtrackers { get; }
        DbSet<Survey> Surveys { get; }
        DbSet<Comment> Comments { get; }
        DbSet<Commentsavingtracker> Commentsavingtrackers { get; }
        DbSet<Message> Messages { get; }
        DbSet<Viewstatistic> Viewstatistics { get; }
        DbSet<Votingtracker> Votingtrackers { get; }
        DbSet<Subverse> Subverses { get; }
        DbSet<Stickiedsubmission> Stickiedsubmissions { get; }
        DbSet<Usersetdefinition> Usersetdefinitions { get; }
        DbSet<SubmissionRemovalLog> SubmissionRemovalLogs { get; }
        DbSet<SubverseBan> SubverseBans { get; }
        DbSet<Savingtracker> Savingtrackers { get; }
        DbSet<Userset> Usersets { get; }
        DbSet<Usersetsubscription> Usersetsubscriptions { get; }
        DbSet<Defaultsubverse> Defaultsubverses { get; }
        DbSet<SubverseAdmin> SubverseAdmins { get; }
        DbSet<Subverseflairsetting> Subverseflairsettings { get; }
        DbSet<Featuredsub> Featuredsubs { get; }
        DbSet<UserBlockedSubverse> UserBlockedSubverses { get; }
    }
}
