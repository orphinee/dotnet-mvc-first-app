using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Contoh validasi sederhana (belum pakai database)
            if (username == "admin" && password == "123")
            {
                // redirect ke Dashboard setelah login sukses
                return RedirectToAction("Index", "Dashboard");
            }

            // kalau login gagal
            ViewBag.Error = "Username atau password salah!";
            return View("Index");
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
