namespace DotNetTechnicalDocumentation.Models;

/// <summary>
/// Represents a product in the application.
/// </summary>
public class Product
{
    /// <summary>
    /// Gets or sets the unique product identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the product name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product price.
    /// </summary>
    public decimal Price { get; set; }
}