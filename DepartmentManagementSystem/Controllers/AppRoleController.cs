using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;


namespace DepartmentManagementSystem.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AppRoleController:Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public AppRoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }


        //List of all the roles created by  User
        public IActionResult Index()
        {
            var role = _roleManager.Roles;
            return View(role);
        }

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole model)
        {
            if (!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }
            return RedirectToAction("Index");
        }
    }
}
