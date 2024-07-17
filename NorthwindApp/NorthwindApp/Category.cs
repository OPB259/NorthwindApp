/// <summary>
/// Represents a category in the Northwind database.
/// </summary>
public class Category
{
    /// <summary>
    /// Gets or sets the category ID.
    /// </summary>
    public int CategoryID { get; set; }

    /// <summary>
    /// Gets or sets the category name.
    /// </summary>
    public string CategoryName { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the picture.
    /// </summary>
    public byte[] Picture { get; set; }
}