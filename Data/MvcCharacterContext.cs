using MvcCharacter.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcCharacter.Data
{
    public class MvcCharacterContext : DbContext
    {
        public MvcCharacterContext (DbContextOptions<MvcCharacterContext> options) : base(options)
        {
        }

        public DbSet<Character> Character { get; set; }
    }
}
