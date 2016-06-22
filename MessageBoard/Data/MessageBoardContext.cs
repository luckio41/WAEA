using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MessageBoard.Data
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}