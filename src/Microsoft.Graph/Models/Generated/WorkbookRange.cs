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
    /// The type Workbook Range.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookRange : Entity
    {
    
        /// <summary>
        /// Gets or sets address.
        /// Represents the range reference in A1-style. Address value will contain the Sheet reference (e.g. Sheet1!A1:B4). Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address", Required = Newtonsoft.Json.Required.Default)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or sets address local.
        /// Represents range reference for the specified range in the language of the user. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addressLocal", Required = Newtonsoft.Json.Required.Default)]
        public string AddressLocal { get; set; }
    
        /// <summary>
        /// Gets or sets cell count.
        /// Number of cells in the range. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CellCount { get; set; }
    
        /// <summary>
        /// Gets or sets column count.
        /// Represents the total number of columns in the range. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columnCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ColumnCount { get; set; }
    
        /// <summary>
        /// Gets or sets column hidden.
        /// Represents if all columns of the current range are hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columnHidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? ColumnHidden { get; set; }
    
        /// <summary>
        /// Gets or sets column index.
        /// Represents the column number of the first cell in the range. Zero-indexed. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columnIndex", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ColumnIndex { get; set; }
    
        /// <summary>
        /// Gets or sets formulas.
        /// Represents the formula in A1-style notation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formulas", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Formulas { get; set; }
    
        /// <summary>
        /// Gets or sets formulas local.
        /// Represents the formula in A1-style notation, in the user's language and number-formatting locale.  For example, the English '=SUM(A1, 1.5)' formula would become '=SUMME(A1; 1,5)' in German.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formulasLocal", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken FormulasLocal { get; set; }
    
        /// <summary>
        /// Gets or sets formulas r1c1.
        /// Represents the formula in R1C1-style notation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formulasR1C1", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken FormulasR1C1 { get; set; }
    
        /// <summary>
        /// Gets or sets hidden.
        /// Represents if all cells of the current range are hidden. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? Hidden { get; set; }
    
        /// <summary>
        /// Gets or sets number format.
        /// Represents Excel's number format code for the given cell.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "numberFormat", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken NumberFormat { get; set; }
    
        /// <summary>
        /// Gets or sets row count.
        /// Returns the total number of rows in the range. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rowCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RowCount { get; set; }
    
        /// <summary>
        /// Gets or sets row hidden.
        /// Represents if all rows of the current range are hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rowHidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? RowHidden { get; set; }
    
        /// <summary>
        /// Gets or sets row index.
        /// Returns the row number of the first cell in the range. Zero-indexed. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rowIndex", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RowIndex { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// Text values of the specified range. The Text value will not depend on the cell width. The # sign substitution that happens in Excel UI will not affect the text value returned by the API. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Text { get; set; }
    
        /// <summary>
        /// Gets or sets value types.
        /// Represents the type of data of each cell. The possible values are: Unknown, Empty, String, Integer, Double, Boolean, Error. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueTypes", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken ValueTypes { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// Represents the raw values of the specified range. The data returned could be of type string, number, or a boolean. Cell that contain an error will return the error string.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "values", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Values { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Returns a format object, encapsulating the range's font, fill, borders, alignment, and other properties. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "format", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookRangeFormat Format { get; set; }
    
        /// <summary>
        /// Gets or sets sort.
        /// The worksheet containing the current range. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sort", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookRangeSort Sort { get; set; }
    
        /// <summary>
        /// Gets or sets worksheet.
        /// The worksheet containing the current range. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "worksheet", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookWorksheet Worksheet { get; set; }
    
    }
}

