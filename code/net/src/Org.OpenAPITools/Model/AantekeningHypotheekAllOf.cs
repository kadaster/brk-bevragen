/*
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.3.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AantekeningHypotheekAllOf
    /// </summary>
    [DataContract]
    public partial class AantekeningHypotheekAllOf :  IEquatable<AantekeningHypotheekAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AantekeningHypotheekAllOf" /> class.
        /// </summary>
        /// <param name="betreftGedeelteVanPerceel">betreftGedeelteVanPerceel.</param>
        public AantekeningHypotheekAllOf(bool betreftGedeelteVanPerceel = default(bool))
        {
            this.BetreftGedeelteVanPerceel = betreftGedeelteVanPerceel;
        }

        /// <summary>
        /// Gets or Sets BetreftGedeelteVanPerceel
        /// </summary>
        [DataMember(Name="betreftGedeelteVanPerceel", EmitDefaultValue=false)]
        public bool BetreftGedeelteVanPerceel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AantekeningHypotheekAllOf {\n");
            sb.Append("  BetreftGedeelteVanPerceel: ").Append(BetreftGedeelteVanPerceel).Append("\n");
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
            return this.Equals(input as AantekeningHypotheekAllOf);
        }

        /// <summary>
        /// Returns true if AantekeningHypotheekAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of AantekeningHypotheekAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AantekeningHypotheekAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BetreftGedeelteVanPerceel == input.BetreftGedeelteVanPerceel ||
                    (this.BetreftGedeelteVanPerceel != null &&
                    this.BetreftGedeelteVanPerceel.Equals(input.BetreftGedeelteVanPerceel))
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
                if (this.BetreftGedeelteVanPerceel != null)
                    hashCode = hashCode * 59 + this.BetreftGedeelteVanPerceel.GetHashCode();
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