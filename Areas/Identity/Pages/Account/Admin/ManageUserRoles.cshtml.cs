using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Platform_Services_Portal.Areas.Identity.Pages.Account.Admin
{
    [Authorize(Roles = "Admin")]
    public class ManageUserRolesModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
