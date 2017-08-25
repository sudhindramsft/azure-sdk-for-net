// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The device patch.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DevicePatch
    {
        /// <summary>
        /// Initializes a new instance of the DevicePatch class.
        /// </summary>
        public DevicePatch()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DevicePatch class.
        /// </summary>
        /// <param name="deviceDescription">Short description given for the
        /// device</param>
        public DevicePatch(string deviceDescription = default(string))
        {
            DeviceDescription = deviceDescription;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets short description given for the device
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceDescription")]
        public string DeviceDescription { get; set; }

    }
}