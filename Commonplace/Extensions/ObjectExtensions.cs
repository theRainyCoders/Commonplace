namespace TheRainyCoders.Commonplace.Extensions
{
    using System.Diagnostics;
    using System.Reflection;

    public static class ObjectExtensions
    {
        public static string GetAssemblyFileVersion(this object instance)
        {
            var assembly = Assembly.GetAssembly(instance.GetType());

            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }

        public static string GetAssemblyInformationalVersion(this object instance)
        {
            var attribute = Assembly.GetAssembly(instance.GetType())
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            return attribute.InformationalVersion;
        }
    }
}