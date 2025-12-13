using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Uniflow.Data
{
    // Moștenim din IdentityDbContext pentru a avea tabelele de useri (Identity)
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Aici vom adauga tabelele pentru Cursuri, Notite, etc. in sprinturile viitoare
    }
}
