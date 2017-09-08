using Microsoft.EntityFrameworkCore;

namespace ScrumCentral.Models
{
    public class PokerSessionContext : DbContext
    {
        public PokerSessionContext (DbContextOptions<PokerSessionContext> options)
            : base(options)
        {
            
        }

        public DbSet<ScrumCentral.Models.PokerSession> PokerSession { get; set; }
    }
}