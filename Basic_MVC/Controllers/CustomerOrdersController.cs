using Basic_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek müşteri ve siparişler oluşturma
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ajda",
                LastName = "Pekkan",
                Email = "ajda.pekkan@gmail.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 3000.00m, Quantity = 1 },
                new Order { Id = 2, ProductName = "Mouse", Price = 150.00m, Quantity = 2 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
