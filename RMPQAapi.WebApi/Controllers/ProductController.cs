using Microsoft.AspNetCore.Mvc;
using RMPQAapi.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMPQAapi.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        /// <summary>
        /// Gets all products in database
        /// </summary>
        /// <returns>All products</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllByUserId() =>
             Ok(await productService.GetProducts());


    }
}
