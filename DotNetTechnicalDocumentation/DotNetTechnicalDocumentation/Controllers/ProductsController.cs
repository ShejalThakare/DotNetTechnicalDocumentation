using DotNetTechnicalDocumentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTechnicalDocumentation.Controllers;

/// <summary>
/// Provides endpoints for retrieving product information.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products =
    [
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 55000
        },
        new Product
        {
            Id = 2,
            Name = "Keyboard",
            Price = 1500
        },
        new Product
        {
            Id = 3,
            Name = "Mouse",
            Price = 800
        }
    ];

    /// <summary>
    /// Retrieves all available products.
    /// </summary>
    /// <returns>A list of products.</returns>
    [HttpGet]
    public ActionResult<List<Product>> GetProducts()
    {
        return Ok(Products);
    }

    /// <summary>
    /// Retrieves a product by its identifier.
    /// </summary>
    /// <param name="id">The product identifier.</param>
    /// <returns>The product or a 404 response.</returns>
    [HttpGet("{id:int}")]
    public ActionResult<Product> GetProductById(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return NotFound(new
            {
                message = "Product not found."
            });
        }

        return Ok(product);
    }
}