using Microsoft.AspNetCore.Mvc;
using Validation.Models;

namespace Validation.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View(ClientFactory.GetFactory.CLients);
        }
        public IActionResult Create()
        {
            return View(new Client());
        }
        [HttpPost]
        public IActionResult Create(Client client)
        {
            if(!ModelState.IsValid) 
            return View(client);
            ClientFactory.GetFactory.CLients.Add(client);
            return RedirectToAction("Index");
        }
    }

}
