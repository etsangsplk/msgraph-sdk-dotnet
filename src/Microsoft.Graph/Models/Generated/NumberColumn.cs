// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type NumberColumn.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class NumberColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberColumn"/> class.
        /// </summary>
        public NumberColumn()
        {
            this.ODataType = "microsoft.graph.numberColumn";
        }

        /// <summary>
        /// Gets or sets decimalPlaces.
        /// How many decimal places to display. See below for information about the possible values.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "decimalPlaces", Required = Newtonsoft.Json.Required.Default)]
        public string DecimalPlaces { get; set; }
    
        /// <summary>
        /// Gets or sets displayAs.
        /// How the value should be presented in the UX. Must be one of number or percentage. If unspecified, treated as number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayAs", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayAs { get; set; }
    
        /// <summary>
        /// Gets or sets maximum.
        /// The maximum permitted value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximum", Required = Newtonsoft.Json.Required.Default)]
        public double? Maximum { get; set; }
    
        /// <summary>
        /// Gets or sets minimum.
        /// The minimum permitted value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimum", Required = Newtonsoft.Json.Required.Default)]
        public double? Minimum { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
