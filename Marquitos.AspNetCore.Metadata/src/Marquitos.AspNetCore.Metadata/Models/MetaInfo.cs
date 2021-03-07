using System;

namespace Marquitos.AspNetCore.Metadata.Models
{
    /// <summary>
    /// Meta Info
    /// </summary>
    public class MetaInfo
    {
        /// <summary>
        /// Assembly name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Running Environment
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// Started On
        /// </summary>
        public DateTimeOffset StartedOn { get; set; }

        /// <summary>
        /// Assembly version
        /// </summary>
        public VersionInfo Version { get; set; }
    }
}
