using Microsoft.AspNetCore.Mvc;
using SistemaVendasUdemy.Models;

namespace SistemaVendasUdemy.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Name = "Eletronics" });
            list.Add(new Departamento { Id = 2, Name = "Fashion" });

            return View((list));
        }
    }
}
