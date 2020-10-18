namespace TheRainyCoders.Commonplace.Data
{
    using System;

    /// <summary>
    ///     Interface to describe a object with a unique id, a name and a detailed description.
    /// </summary>
    public interface IDescribe : IReadonlyDescribe
    {
        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public new string Description { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public new Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public new string Name { get; set; }
    }
}