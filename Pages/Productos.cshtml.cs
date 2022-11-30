using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace Shoppit.Pages
{
    public class ProductosModel : PageModel
    {
        public List<Producto> productos = new List<Producto>();
        public void OnGet()
        {
            listaProductos();
        }

        public void listaProductos()
        {
            using (MySqlConnection c = new MySqlConnection("Server=localhost;Database=shoppit;Uid=root;Password="))
            {
                MySqlCommand cmd = new MySqlCommand();
                c.Open();
                cmd.Connection = c;
                cmd.CommandText = "SELECT * FROM productos";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto()
                        {
                            id_producto = reader.GetInt32("id_producto"),
                            nombre = reader.GetString("nombre"),
                            precio = reader.GetFloat("precio"),
                            cantidad = reader.GetInt32("cantidad"),
                        });
                    }
                }
            }
        }
    }
}
