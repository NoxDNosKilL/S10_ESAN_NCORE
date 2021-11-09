using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S10_ESAN_NETCORE.Domain.Core.DTOs;
using S10_ESAN_NETCORE.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static S10_ESAN_NETCORE.Domain.Core.DTOs.ProductDTO;

namespace S10_ESAN_NCORE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        [Route("Getproducts")]
        public async Task<IActionResult> Getproduct()
        {
            var products = await _productRepository.GetProducts();
            var productsList = new List<ProductPriceDTO>(); 
            foreach (var item in products)
            {
                var productPriceDTO = new ProductPriceDTO() 
                {
                    Id = item.Id,
                    ProductName = item.ProductName,
                    //SupplierId = item.SupplierId,
                    UnitPrice = item.UnitPrice,
                    //Package = item.Package,
                    //IsDiscontinued = item.IsDiscontinued
                };
                productsList.Add(productPriceDTO);
            }
            return Ok(productsList);
        }

    }
}
