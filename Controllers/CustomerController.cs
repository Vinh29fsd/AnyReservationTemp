using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AnyReservationTemp.Data;
using AnyReservationTemp.Domain;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AnyReservationTemp.Controllers
{
    [Authorize(Roles = "Staff")] // ⬅ Only allows staff members
    public class CustomerController : Controller
    {
        private readonly UserManager<Customer> _userManager;
        private readonly AnyReservationTempContext _context;

        public CustomerController(UserManager<Customer> userManager, AnyReservationTempContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> UpgradeToMember(int customerId)
        {
            var customer = await _userManager.FindByIdAsync(customerId.ToString());
            if (customer != null)
            {
                var member = new Member { CustomerId = customer.Id, MembershipLevel = "Basic" };
                _context.Member.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction("UserList");
            }
            return NotFound();
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = new List<Customer>();
            return View(customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
