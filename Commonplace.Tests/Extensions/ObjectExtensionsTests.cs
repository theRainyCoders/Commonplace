namespace TheRainyCoders.Commonplace.Tests.Extensions
{
    using FluentAssertions;

    using TheRainyCoders.Commonplace.Extensions;

    using Xunit;

    /// <summary>
    ///     Unit tests class <see cref="ObjectExtensions" />.
    /// </summary>
    public class ObjectExtensionsTests
    {
        /// <summary>
        ///     Test that <see cref="ObjectExtensions.GetAssemblyFileVersionOfObject" /> returns the file version of the assembly,
        ///     where the class for creation is located.
        /// </summary>
        [Fact]
        public void GetAssemblyFileVersionOfObject_UsedInternalObject_ReturnsVersionOfTestAssembly()
        {
            var instance = new InternalClass();
            var version = instance.GetAssemblyFileVersionOfObject();

            version.Should().Be("1.0.0.0", "Current version of the test assembly is expected.");
        }

        /// <summary>
        ///     Test that <see cref="ObjectExtensions.GetAssemblyInformationalVersionOfObject" /> returns the informational version
        ///     of the assembly,
        ///     where the class for creation is located.
        /// </summary>
        [Fact]
        public void
            GetAssemblyInformationalVersionOfObject_UsedInternalObject_ReturnsInformationalVersionOfTestAssembly()
        {
            var instance = new InternalClass();
            var version = instance.GetAssemblyInformationalVersionOfObject();

            version.Should().Be("1.0.0", "Current version of the test assembly is expected.");
        }

        /// <summary>
        ///     Type only used for test purposes.
        /// </summary>
        private class InternalClass
        {
        }
    }
}
