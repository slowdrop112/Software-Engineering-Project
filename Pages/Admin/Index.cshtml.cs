using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Uniflow.Pages.Admin
{
    // Acces doar pentru utilizatorii cu rolul "Admin"
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // Lista de useri pe care o vom afisa in pagina
        public List<UserViewModel> Users { get; set; } = new List<UserViewModel>();

        public async Task OnGetAsync()
        {
            // Luam toti userii din baza de date
            var allUsers = await _userManager.Users.ToListAsync();

            foreach (var user in allUsers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                Users.Add(new UserViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    Roles = string.Join(", ", roles)
                });
            }
        }

        // O clasa mica ajutatoare doar pentru afisare
        public class UserViewModel
        {
            public string Id { get; set; }
            public string Email { get; set; }
            public string Roles { get; set; }
        }
    }
}


