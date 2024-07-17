/// <summary>
/// Represents an order in the Northwind database.
/// </summary>
public class Order
{
    /// <summary>
    /// Gets or sets the order ID.
    /// </summary>
    public int OrderID { get; set; }

    /// <summary>
    /// Gets or sets the customer ID.
    /// </summary>
    public string CustomerID { get; set; }

    /// <summary>
    /// Gets or sets the order date.
    /// </summary>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// Gets or sets the ship name.
    /// </summary>
    public string ShipName { get; set; }

    /// <summary>
    /// Gets or sets the ship address.
    /// </summary>
    public string ShipAddress { get; set; }
}