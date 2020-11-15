namespace TheRainyCoders.Commonplace.Extensions
{
    using System;
    using System.Diagnostics;
    using System.Reflection;

    /// <summary>
    ///     Extension methods for <see cref="object" />.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        ///     Get assembly file version of an object.
        /// </summary>
        /// <param name="instance">
        ///     The instance.
        /// </param>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        ///     Is thrown, when <see cref="instance" /> is null.
        /// </exception>
        public static string? GetAssemblyFileVersionOfObject(this object instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            var type = instance.GetType();

            var assembly = Assembly.GetAssembly(type);
            if (assembly == null)
            {
                throw new InvalidOperationException($"Can't get assembly of type '{type}'.");
            }

            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }

        /// <summary>
        ///     Get assembly informational version of  an object.
        /// </summary>
        /// <param name="instance">
        ///     The instance.
        /// </param>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public static string GetAssemblyInformationalVersionOfObject(this object instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            var type = instance.GetType();

            var assembly = Assembly.GetAssembly(type);
            if (assembly == null)
            {
                throw new InvalidOperationException($"Can't get assembly of type '{type}'.");
            }

            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            if (attribute == null)
            {
                throw new InvalidOperationException(
                    $"Can't get attribute '{nameof(AssemblyInformationalVersionAttribute)}' from assembly '{assembly.Location}'.");
            }

            return attribute.InformationalVersion;
        }
    }
}
