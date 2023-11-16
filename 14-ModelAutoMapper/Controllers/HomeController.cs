using _14_ModelAutoMapper.Models;
using _14_ModelAutoMapper.Models.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _14_ModelAutoMapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployee()
        {
            var employee = new Employee
            {
                EmployeeId = 1,
                FirstName = "Fatih",
                LastName = "Alkan",
                Department = "IT"
            };

            var employeeDTO = _mapper.Map<Employee, EmployeeDTO>(employee);

            return Content($"İşçi Adı: {employeeDTO.FullName} Bölüm: {employeeDTO.Department}");
        }

        public IActionResult GetOrder()
        {
            var order = new Order
            {
                Id = 1,
                OrderDate = DateTime.Now,
                Customer = new Customer
                {
                    Id = 2,
                    Name = "Fatih Alkan"
                }
            };

            var orderDto = _mapper.Map<OrderDto>(order);

            string content = $"OrderDto Id: {orderDto.Id} OrderDto OrderDate: {orderDto.OrderDate} OrderDto Customer Id: {orderDto.Customer.Id} OrderDto Customer Name: {orderDto.Customer.Name}";

            return Content(content);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}