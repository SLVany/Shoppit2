using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace Shoppit.Pages
{
    public class RegistrarModel : PageModel
    {
        public void OnGet(string username, string password)
        {
            registrarUser(username, password);
        }

        private void registrarUser(string username, string password)
        {
            
        }
    }
}
