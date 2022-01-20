using Microsoft.EntityFrameworkCore;
using PartyInvites.Models;

namespace PartyInvites.Data
{
    public class ResponseContext: DbContext
    {
        public DbSet<GuestResponse> GuestResponses { get; set; }
        public ResponseContext(DbContextOptions<ResponseContext> options)
        : base(options)
        {
            
        }     
    }
}
