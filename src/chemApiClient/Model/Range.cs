/* 
 * chemadvisor.io api
 *
 * REST api to access ChemADVISOR maintained substance and regulatory data.
 *
 * OpenAPI spec version: 0.9.6 beta
 * Contact: support@chemadvisor.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace chemApiClient.Model
{
    /// <summary>
    /// Range
    /// </summary>
    [DataContract]
    public partial class Range : BaseDataType,  IEquatable<Range>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Range() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        /// <param name="DataType">DataType (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Prompt">Prompt (required).</param>
        /// <param name="Value">Value (required).</param>
        /// <param name="LowerOp">LowerOp (required).</param>
        /// <param name="LowerVal">LowerVal (required).</param>
        /// <param name="UpperOp">UpperOp (required).</param>
        /// <param name="UpperVal">UpperVal (required).</param>
        /// <param name="Unit">Unit (required).</param>
        /// <param name="UnitType">UnitType (required).</param>
        public Range(string DataType = null, string Name = null, string Prompt = null, string Value = null, string LowerOp = null, double? LowerVal = null, string UpperOp = null, double? UpperVal = null, string Unit = null, string UnitType = null)
        {
            // to ensure "DataType" is required (not null)
            if (DataType == null)
            {
                throw new InvalidDataException("DataType is a required property for Range and cannot be null");
            }
            else
            {
                this.DataType = DataType;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Range and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Prompt" is required (not null)
            if (Prompt == null)
            {
                throw new InvalidDataException("Prompt is a required property for Range and cannot be null");
            }
            else
            {
                this.Prompt = Prompt;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for Range and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            // to ensure "LowerOp" is required (not null)
            if (LowerOp == null)
            {
                throw new InvalidDataException("LowerOp is a required property for Range and cannot be null");
            }
            else
            {
                this.LowerOp = LowerOp;
            }
            // to ensure "LowerVal" is required (not null)
            if (LowerVal == null)
            {
                throw new InvalidDataException("LowerVal is a required property for Range and cannot be null");
            }
            else
            {
                this.LowerVal = LowerVal;
            }
            // to ensure "UpperOp" is required (not null)
            if (UpperOp == null)
            {
                throw new InvalidDataException("UpperOp is a required property for Range and cannot be null");
            }
            else
            {
                this.UpperOp = UpperOp;
            }
            // to ensure "UpperVal" is required (not null)
            if (UpperVal == null)
            {
                throw new InvalidDataException("UpperVal is a required property for Range and cannot be null");
            }
            else
            {
                this.UpperVal = UpperVal;
            }
            // to ensure "Unit" is required (not null)
            if (Unit == null)
            {
                throw new InvalidDataException("Unit is a required property for Range and cannot be null");
            }
            else
            {
                this.Unit = Unit;
            }
            // to ensure "UnitType" is required (not null)
            if (UnitType == null)
            {
                throw new InvalidDataException("UnitType is a required property for Range and cannot be null");
            }
            else
            {
                this.UnitType = UnitType;
            }
        }
        
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="data_type", EmitDefaultValue=false)]
        public string DataType { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Gets or Sets LowerOp
        /// </summary>
        [DataMember(Name="lower_op", EmitDefaultValue=false)]
        public string LowerOp { get; set; }
        /// <summary>
        /// Gets or Sets LowerVal
        /// </summary>
        [DataMember(Name="lower_val", EmitDefaultValue=false)]
        public double? LowerVal { get; set; }
        /// <summary>
        /// Gets or Sets UpperOp
        /// </summary>
        [DataMember(Name="upper_op", EmitDefaultValue=false)]
        public string UpperOp { get; set; }
        /// <summary>
        /// Gets or Sets UpperVal
        /// </summary>
        [DataMember(Name="upper_val", EmitDefaultValue=false)]
        public double? UpperVal { get; set; }
        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }
        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unit_type", EmitDefaultValue=false)]
        public string UnitType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Range {\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  LowerOp: ").Append(LowerOp).Append("\n");
            sb.Append("  LowerVal: ").Append(LowerVal).Append("\n");
            sb.Append("  UpperOp: ").Append(UpperOp).Append("\n");
            sb.Append("  UpperVal: ").Append(UpperVal).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Range);
        }

        /// <summary>
        /// Returns true if Range instances are equal
        /// </summary>
        /// <param name="other">Instance of Range to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Range other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataType == other.DataType ||
                    this.DataType != null &&
                    this.DataType.Equals(other.DataType)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.LowerOp == other.LowerOp ||
                    this.LowerOp != null &&
                    this.LowerOp.Equals(other.LowerOp)
                ) && 
                (
                    this.LowerVal == other.LowerVal ||
                    this.LowerVal != null &&
                    this.LowerVal.Equals(other.LowerVal)
                ) && 
                (
                    this.UpperOp == other.UpperOp ||
                    this.UpperOp != null &&
                    this.UpperOp.Equals(other.UpperOp)
                ) && 
                (
                    this.UpperVal == other.UpperVal ||
                    this.UpperVal != null &&
                    this.UpperVal.Equals(other.UpperVal)
                ) && 
                (
                    this.Unit == other.Unit ||
                    this.Unit != null &&
                    this.Unit.Equals(other.Unit)
                ) && 
                (
                    this.UnitType == other.UnitType ||
                    this.UnitType != null &&
                    this.UnitType.Equals(other.UnitType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DataType != null)
                    hash = hash * 59 + this.DataType.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.LowerOp != null)
                    hash = hash * 59 + this.LowerOp.GetHashCode();
                if (this.LowerVal != null)
                    hash = hash * 59 + this.LowerVal.GetHashCode();
                if (this.UpperOp != null)
                    hash = hash * 59 + this.UpperOp.GetHashCode();
                if (this.UpperVal != null)
                    hash = hash * 59 + this.UpperVal.GetHashCode();
                if (this.Unit != null)
                    hash = hash * 59 + this.Unit.GetHashCode();
                if (this.UnitType != null)
                    hash = hash * 59 + this.UnitType.GetHashCode();
                return hash;
            }
        }
    }

}
