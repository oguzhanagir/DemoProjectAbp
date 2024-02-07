using DemoProject.Debugging;

namespace DemoProject
{
    public class DemoProjectConsts
    {
        public const string LocalizationSourceName = "DemoProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b1c755c0d2ef4d86bde9e8cc0fc41a00";
    }
}
