using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;

        public ProductsController(StoreContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts(){
            var Products=context.Products.ToList();
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id) => context.Products.Find(id);
    }
}