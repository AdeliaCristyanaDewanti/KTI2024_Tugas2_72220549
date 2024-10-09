using Microsoft.AspNetCore.Mvc;
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Registration(User model)
        {
            if (ModelState.IsValid)
            {
                // Logika untuk menambahkan user baru ke database
                // Contoh: simpan model ke database
                
                ViewBag.Message = "Registration successful!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Registration failed. Please check the form for errors.";
            }

            // Kembalikan ke view dengan model jika ada error
            return View("Register", model);
        }
    }
}
