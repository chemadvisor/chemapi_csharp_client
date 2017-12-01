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
    /// Releases
    /// </summary>
    [DataContract]
    public partial class Releases :  IEquatable<Releases>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Releases" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Releases() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Releases" /> class.
        /// </summary>
        /// <param name="Release">A collection of release objects (required).</param>
        /// <param name="Links">Links.</param>
        public Releases(List<Release> Release = null, Links Links = null)
        {
            // to ensure "Release" is required (not null)
            if (Release == null)
            {
                throw new InvalidDataException("Release is a required property for Releases and cannot be null");
            }
            else
            {
                this.Release = Release;
            }
            this.Links = Links;
        }
        
        /// <summary>
        /// A collection of release objects
        /// </summary>
        /// <value>A collection of release objects</value>
        [DataMember(Name="release", EmitDefaultValue=false)]
        public List<Release> Release { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Links Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Releases {\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(obj as Releases);
        }

        /// <summary>
        /// Returns true if Releases instances are equal
        /// </summary>
        /// <param name="other">Instance of Releases to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Releases other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Release == other.Release ||
                    this.Release != null &&
                    this.Release.SequenceEqual(other.Release)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.Release != null)
                    hash = hash * 59 + this.Release.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }
    }

}