﻿using System.Runtime.Serialization;

namespace Altinn.Authorizationadmin.Core.Models
{
    public class AuthorizationRequestResource
    {
        /// <summary>
        ///  Gets or sets The ServiceCode that request need 
        /// </summary>
        public string? ServiceCode { get; set; }

        /// <summary>
        ///  Gets or sets The ServiceEditionCode that request need 
        /// </summary>

        public int ServiceEditionCode { get; set; }

        /// <summary>
        ///  Gets or sets The AltinnAppId that request need 
        /// </summary>
        public string? AltinnAppId { get; set; }

        /// <summary>
        ///  Gets or sets The OperationType that request need 
        /// </summary>
        public List<string>? Operations { get; set; }

        /// <summary>
        ///  Gets or sets The Metadata that request need 
        /// </summary>
        public Dictionary<string, string>? Metadata { get; set; }
    }
}