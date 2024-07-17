/// <summary>
/// Represents a product in the Northwind database.
/// </summary>
public class Product
{
    /// <summary>
    /// Gets or sets the product ID.
    /// </summary>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the product name.
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// Gets or sets the supplier ID.
    /// </summary>
    public int SupplierID { get; set; }

    /// <summary>
    /// Gets or sets the category ID.
    /// </summary>
    public int CategoryID { get; set; }

    /// <summary>
    /// Gets or sets the quantity per unit.
    /// </summary>
    public string QuantityPerUnit { get; set; }

    /// <summary>
    /// Gets or sets the unit price.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the units in stock.
    /// </summary>
    public int UnitsInStock { get; set; }

    /// <summary>
    /// Gets or sets the units on order.
    /// </summary>
    public int UnitsOnOrder { get; set; }

    /// <summary>
    /// Gets or sets the reorder level.
    /// </summary>
    public int ReorderLevel { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the product is discontinued.
    /// </summary>
    public bool Discontinued { get; set; }
}