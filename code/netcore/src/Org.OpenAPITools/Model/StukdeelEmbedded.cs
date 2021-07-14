/*
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// StukdeelEmbedded
    /// </summary>
    [DataContract(Name = "StukdeelEmbedded")]
    public partial class StukdeelEmbedded : IEquatable<StukdeelEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StukdeelEmbedded" /> class.
        /// </summary>
        /// <param name="stuk">stuk.</param>
        public StukdeelEmbedded(StukHalBasis stuk = default(StukHalBasis))
        {
            this.Stuk = stuk;
        }

        /// <summary>
        /// Gets or Sets Stuk
        /// </summary>
        [DataMember(Name = "stuk", EmitDefaultValue = false)]
        public StukHalBasis Stuk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StukdeelEmbedded {\n");
            sb.Append("  Stuk: ").Append(Stuk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StukdeelEmbedded);
        }

        /// <summary>
        /// Returns true if StukdeelEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of StukdeelEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StukdeelEmbedded input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stuk == input.Stuk ||
                    (this.Stuk != null &&
                    this.Stuk.Equals(input.Stuk))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Stuk != null)
                    hashCode = hashCode * 59 + this.Stuk.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
