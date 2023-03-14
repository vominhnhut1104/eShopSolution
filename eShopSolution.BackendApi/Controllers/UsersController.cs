using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
