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
    /// StukdeelLinks
    /// </summary>
    [DataContract(Name = "StukdeelLinks")]
    public partial class StukdeelLinks : IEquatable<StukdeelLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StukdeelLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="stuk">stuk.</param>
        public StukdeelLinks(HalLink self = default(HalLink), HalLink stuk = default(HalLink))
        {
            this.Self = self;
            this.Stuk = stuk;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public HalLink Self { get; set; }

        /// <summary>
        /// Gets or Sets Stuk
        /// </summary>
        [DataMember(Name = "stuk", EmitDefaultValue = false)]
        public HalLink Stuk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StukdeelLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return this.Equals(input as StukdeelLinks);
        }

        /// <summary>
        /// Returns true if StukdeelLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of StukdeelLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StukdeelLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
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