using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyShopProject.Models;

namespace MyShopProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigins")]

    public class OrderController : ControllerBase
    {
        private readonly ShopDbContext _dbContext;

        public OrderController(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public void Get()
        {

        }

        [HttpPost]
        public IActionResult AddCustomer(string fullName, string email, string address)//, [FromBody] string products
        {
            try 
            {
                Orders order = new Orders();
                order.FullName = fullName;
                order.Email = email;
                order.Address = address;
                //order.Products = products;

                //_dbContext.Orders.Add(order);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch(Exception e) 
            {
                return BadRequest(e.Message);
            }



        }
    }
}
