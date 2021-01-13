using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETMVCCORE.Models;
using ASP.NETMVCCORE.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETMVCCORE.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private IUserRepository userRepository;

        public AdminController (IUserRepository userRepository,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userRepository = userRepository;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public ViewResult Index()
        {
            var allUsers = userRepository.GetAllUsers();
            return View(allUsers);
        }

        public ViewResult Details(int? id)
        {
            User user = userRepository.GetUsers(id.Value);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("404NotFound", id.Value);
            }
            ViewUserDetailsViewModel userDetailsVM = new ViewUserDetailsViewModel()
            {
                User = user,
                Title = "User Details"
            };
            return View(userDetailsVM);
        }

        //Add User get request
        [HttpGet]
        public ViewResult AddorEdit(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                User user = userRepository.GetUsers(id);
                AddEditUserViewModel editUserViewModel = new AddEditUserViewModel()
                {
                    ID = user.ID,
                    Name = user.Name,
                    DOB = user.DOB,
                    Gender = user.Gender,
                    Email = user.Email,
                    MobileNo = user.MobileNo,
                    Address = user.Address,
                    PostCode = user.PostCode,
                    LocationOfWork = user.LocationOfWork,
                    Biography = user.Biography,
                    KeyWordsForSkill = user.KeyWordsForSkill,
                    Category = user.Category

                };
                return View(editUserViewModel);
            }
        }

        //Add User POST request
        [HttpPost]
        public IActionResult AddorEdit(AddEditUserViewModel addUserModel)
        {
            if (ModelState.IsValid)
            {
                if (addUserModel.ID == 0)
                {
                    User user = new User()
                    {
                        Name = addUserModel.Name,
                        DOB = addUserModel.DOB,
                        Gender = addUserModel.Gender,
                        Email = addUserModel.Email,
                        MobileNo = addUserModel.MobileNo,
                        Address = addUserModel.Address,
                        PostCode = addUserModel.PostCode,
                        LocationOfWork = addUserModel.LocationOfWork,
                        Biography = addUserModel.Biography,
                        KeyWordsForSkill = addUserModel.KeyWordsForSkill,
                        Category = addUserModel.Category
                    };
                    userRepository.Add(user);
                    return RedirectToAction("Details", new { id = user.ID });
                }
                else
                {
                    User user = userRepository.GetUsers(addUserModel.ID);
                    user.Name = addUserModel.Name;
                    user.DOB = addUserModel.DOB;
                    user.Gender = addUserModel.Gender;
                    user.Email = addUserModel.Email;
                    user.MobileNo = addUserModel.MobileNo;
                    user.Address = addUserModel.Address;
                    user.PostCode = addUserModel.PostCode;
                    user.LocationOfWork = addUserModel.LocationOfWork;

                    user.Biography = addUserModel.Biography;
                    user.KeyWordsForSkill = addUserModel.KeyWordsForSkill;

                    user.Category = addUserModel.Category;
                    userRepository.Update(user);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        //Delete Users function
        public IActionResult Delete(int ID)
        {
            var user = userRepository.GetUsers(ID);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with = {ID} could not be found.";
                return View("NotFound");
            }
            else 
            {
                var result = userRepository.Delete(ID);
                return RedirectToAction("Index");
            }
        }



        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        /**************ADMINS CAN ADD OTHER ADMINS*****************/

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AdminRegisterViewModel adminModel)
        {
            if (ModelState.IsValid)
            {
                var newAdminUser = new IdentityUser { UserName = adminModel.Email, Email = adminModel.Email };
                var result = await userManager.CreateAsync(newAdminUser, adminModel.Password);
                if (result.Succeeded)
                {
                    //await signInManager.SignInAsync(newAdminUser, isPersistent: false);
                    //return RedirectToAction("Index", "Home");
                    return Redirect("Index");
                }

                foreach (var errorDesc in result.Errors)
                {
                    ModelState.AddModelError("", errorDesc.Description);
                }
            }
            return View(adminModel);
        }



        /***************THE BELOW FUNCTIONALITIES CAN BE ACCESSED BY A  NORMAL USER SUCH AS LOGGING IN AS AN ADMIN ETC THEREFORE ALLOWING ANONYMOUS ACCESS TO IT*****************/
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AdminLoginViewModel adminModel)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(adminModel.Email, adminModel.Password, adminModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }
                ModelState.AddModelError(string.Empty, "Login Attempt Failed");
            }
            return View(adminModel);
        }

    }
}