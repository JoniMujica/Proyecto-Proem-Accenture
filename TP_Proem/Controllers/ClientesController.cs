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
        public IActionResult Index()
        {
            return View(context.Clientes.ToList());
        }
    }
}
