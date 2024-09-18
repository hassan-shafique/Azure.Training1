namespace Azure.Training1.Entities.Base
{
    /// <summary>
    /// Represents a base entity with common properties.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public long Id { get; set; } // Unique identifier for each entity.

        /// <summary>
        /// Gets or sets a value indicating whether the entity is active.
        /// </summary>
        public bool IsActive { get; set; } // Indicates if the entity is currently active.

        /// <summary>
        /// Gets or sets the timestamp when the entity was created, in Unix time format.
        /// </summary>
        public long CreatedAt { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds(); // Default to current Unix time.

        /// <summary>
        /// Gets or sets the timestamp when the entity was last updated, in Unix time format.
        /// </summary>
        public long UpdatedAt { get; set; }
    }
}
