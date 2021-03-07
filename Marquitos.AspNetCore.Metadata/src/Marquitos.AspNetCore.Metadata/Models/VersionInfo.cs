namespace Marquitos.AspNetCore.Metadata.Models
{
    /// <summary>
    /// Assembly Version Info
    /// </summary>
    public class VersionInfo
    {
        /// <summary>
        /// Assembly Major version
        /// </summary>
        public int Major { get; set; }

        /// <summary>
        /// Assembly Minor version
        /// </summary>
        public int Minor { get; set; }

        /// <summary>
        /// Assembly Patch version
        /// </summary>
        public int Patch { get; set; }

        /// <summary>
        /// Assembly Revision version
        /// </summary>
        public int Revision { get; set; }

        /// <summary>
        /// Assembly Product version
        /// </summary>
        public string ProductVersion { get; set; }
    }
}
