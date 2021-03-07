using Marquitos.AspNetCore.Metadata.Models;

namespace Marquitos.AspNetCore.Metadata
{
    /// <summary>
    /// Metadata 
    /// </summary>
    public static class Metadata
    {
        /// <summary>
        /// The virtual path that middleware listens
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Meta information
        /// </summary>
        public static MetaInfo Information { get; set; }
    }
}
