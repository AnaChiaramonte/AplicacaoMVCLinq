using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController1 : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public IActionResult GetClientes()
        {

            Cliente c1 = new Cliente(1, "Alice", "alice@gmail.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(2, "Ana clara", "anaClara@gmail.com", "99162-3389", new DateOnly(2007, 5, 20));
            Cliente c3 = new Cliente(3, "Ana Geremias", "anaJulia@gmail.com", "98807-8439", new DateOnly(2007, 1, 3));
            Cliente c4 = new Cliente(4, "Livia solla", "L&L@gmail.com", "988381891", new DateOnly(2006, 7, 12));
            Cliente c5 = new Cliente(5, "Beatriz Silva", "BiaSilva@gmail.com", "97962-3367", new DateOnly(2000, 5, 20));

            List<Cliente> listCliente = new List<Cliente>();
            listCliente.Add(c1);
            listCliente.Add(c2);
            listCliente.Add(c3);
            listCliente.Add(c4);
            listCliente.Add(c5);
            return View(listCliente);
        }
    }
}
