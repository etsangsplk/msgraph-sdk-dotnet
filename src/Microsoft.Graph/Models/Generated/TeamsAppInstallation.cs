// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Teams App Installation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamsAppInstallation : Entity
    {
    
        /// <summary>
        /// Gets or sets teams app.
        /// The app that is installed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsApp", Required = Newtonsoft.Json.Required.Default)]
        public TeamsApp TeamsApp { get; set; }
    
        /// <summary>
        /// Gets or sets teams app definition.
        /// The details of this version of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsAppDefinition", Required = Newtonsoft.Json.Required.Default)]
        public TeamsAppDefinition TeamsAppDefinition { get; set; }
    
    }
}

