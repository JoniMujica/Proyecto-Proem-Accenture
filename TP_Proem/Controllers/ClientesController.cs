using Microsoft.AspNetCore.Mvc;
using TP_Proem.Models;

namespace TP_Proem.Controllers
{
    public class ClientesController : Controller
    {
        public DataContext context { get; set; }
        public ClientesController(DataContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public IActionResult Guardar(Cliente cliente)
        {
            context.Add(cliente);
            context.SaveChanges();
            return Redirect("Index");
        }
        public IActionResult Crear()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }
        public IActionResult Index()
        {
            return View(context.Clientes.ToList());
        }
    }
}
