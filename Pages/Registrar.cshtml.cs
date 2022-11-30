using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace Shoppit.Pages
{
    public class RegistrarModel : PageModel
    {
        public string msg;
        public void OnGet(string username, string password)
        {
            registrarUser(username, password);
        }

        private void registrarUser(string username, string password)
        {
            using (MySqlConnection c = new MySqlConnection("Server=localhost;Database=shoppit;Uid=root;Password="))
            {
                MySqlCommand cmd = new MySqlCommand();
                c.Open();
                cmd.Connection = c;
                cmd.CommandText = $"INSERT INTO users(username, password) VALUES('{username}','{password}')";
                
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //ViewData["Mensaje"] = "Si existe el usuario";
                        Response.Redirect("Index");
                    }
                    else
                    {
                        //ViewData["Mensaje"] = "Error no se encontro el usuario";
                        msg = "Error en el nombre o contraseña";
                    }
                }
            }

        }
    }
}
