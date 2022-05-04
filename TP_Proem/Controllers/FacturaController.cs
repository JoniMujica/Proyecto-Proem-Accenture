using Microsoft.AspNetCore.Mvc;
using TP_Proem.Models;

namespace TP_Proem.Controllers
{
    public class FacturaController : Controller
    {
        public readonly DataContext context;
        public FacCli FacCli;
        public FacturaController(DataContext context)
        {
            this.context = context;
            FacCli = new FacCli();
        }
        [HttpPost]
        public IActionResult Guardar(FacCli fac)
        {
            fac.Factura.Cliente = FacCli.Factura.Cliente;
            fac.Factura.ClienteId = fac.Factura.ClienteId;
            if (fac.Factura.Id == 0)
            {

            }
            //context.Facturas.Add(factura).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            //context.SaveChanges();
            return Redirect("Index");
        }
        public IActionResult Crear(int id)
        {
            FacCli.Factura.Cliente = context.Clientes.Find(id);
            FacCli.Factura.ClienteId = id;
            return View(FacCli);
        }

        public IActionResult Index(int Id)
        {

            ViewBag.Cliente = context.Clientes.Find(Id);

            return View(context.Facturas.Where((p) => p.Id == Id).ToList());
        }
    }
}
