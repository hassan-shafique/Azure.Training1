using Azure.Training1.Entities.Base;

namespace Azure.Training1.Entities
{
    /// <summary>
    /// Represents a product with its details.
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name { get; set; } = string.Empty; // Default value set to an empty string.

        /// <summary>
        /// Gets or sets a description of the product.
        /// </summary>
        public string Description { get; set; } = string.Empty; // Default value set to an empty string.

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public double Price { get; set; } // Price is a double to accommodate decimal values.
    }
}
