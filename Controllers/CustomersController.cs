using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers;

public class CustomersController : Controller
{
    private readonly ILogger<CustomersController> _logger;

    List<Customer> customers = new List<Customer> {
            new Customer { Id = 1, Name = "Customer 01" },
            new Customer { Id = 2, Name = "Customer 02" },
            new Customer { Id = 3, Name = "Customer 03" }
        };

    public CustomersController(ILogger<CustomersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        var viewModel = new CustomersViewModel {
            Customers = customers
        };
        return View(viewModel);
    }

    public IActionResult Details(int Id)
    {
        var customer = customers.Where(i => Id == i.Id).FirstOrDefault();
        var viewModel = new CustomerDetailsViewModel {
            Customer = customer
        };
        return View(viewModel);
    }
}
