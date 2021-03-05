using Microsoft.AspNetCore.Mvc;
using ProductExampleEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductExampleEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _context.Product.ToList();
            return Ok(_context.Product.ToList());
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] Product product)
        {
          await _context.AddAsync(product);

            _context.SaveChanges();

            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Product product)
        {
             _context.Update(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);

            return Ok(await _context.SaveChangesAsync());
        }
    }
}
