namespace TheRainyCoders.Commonplace.Data
{
    using System;

    /// <summary>
    ///     Interface to describe a object with a unique id, a name and a detailed description, they are only readable.
    /// </summary>
    public interface IReadonlyDescribe
    {
        /// <summary>
        ///     Gets the description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        ///     Gets the id.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        public string Name { get; }
    }
}
