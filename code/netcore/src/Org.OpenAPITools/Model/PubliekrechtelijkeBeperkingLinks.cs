/*
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.4.0
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
    /// PubliekrechtelijkeBeperkingLinks
    /// </summary>
    [DataContract(Name = "PubliekrechtelijkeBeperkingLinks")]
    public partial class PubliekrechtelijkeBeperkingLinks : IEquatable<PubliekrechtelijkeBeperkingLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PubliekrechtelijkeBeperkingLinks" /> class.
        /// </summary>
        /// <param name="bevoegdGezag">bevoegdGezag.</param>
        /// <param name="stukken">stukken.</param>
        /// <param name="stukdelen">stukdelen.</param>
        public PubliekrechtelijkeBeperkingLinks(HalLink bevoegdGezag = default(HalLink), List<HalLink> stukken = default(List<HalLink>), List<HalLink> stukdelen = default(List<HalLink>))
        {
            this.BevoegdGezag = bevoegdGezag;
            this.Stukken = stukken;
            this.Stukdelen = stukdelen;
        }

        /// <summary>
        /// Gets or Sets BevoegdGezag
        /// </summary>
        [DataMember(Name = "bevoegdGezag", EmitDefaultValue = false)]
        public HalLink BevoegdGezag { get; set; }

        /// <summary>
        /// Gets or Sets Stukken
        /// </summary>
        [DataMember(Name = "stukken", EmitDefaultValue = false)]
        public List<HalLink> Stukken { get; set; }

        /// <summary>
        /// Gets or Sets Stukdelen
        /// </summary>
        [DataMember(Name = "stukdelen", EmitDefaultValue = false)]
        public List<HalLink> Stukdelen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PubliekrechtelijkeBeperkingLinks {\n");
            sb.Append("  BevoegdGezag: ").Append(BevoegdGezag).Append("\n");
            sb.Append("  Stukken: ").Append(Stukken).Append("\n");
            sb.Append("  Stukdelen: ").Append(Stukdelen).Append("\n");
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
            return this.Equals(input as PubliekrechtelijkeBeperkingLinks);
        }

        /// <summary>
        /// Returns true if PubliekrechtelijkeBeperkingLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of PubliekrechtelijkeBeperkingLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PubliekrechtelijkeBeperkingLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BevoegdGezag == input.BevoegdGezag ||
                    (this.BevoegdGezag != null &&
                    this.BevoegdGezag.Equals(input.BevoegdGezag))
                ) && 
                (
                    this.Stukken == input.Stukken ||
                    this.Stukken != null &&
                    input.Stukken != null &&
                    this.Stukken.SequenceEqual(input.Stukken)
                ) && 
                (
                    this.Stukdelen == input.Stukdelen ||
                    this.Stukdelen != null &&
                    input.Stukdelen != null &&
                    this.Stukdelen.SequenceEqual(input.Stukdelen)
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
                if (this.BevoegdGezag != null)
                    hashCode = hashCode * 59 + this.BevoegdGezag.GetHashCode();
                if (this.Stukken != null)
                    hashCode = hashCode * 59 + this.Stukken.GetHashCode();
                if (this.Stukdelen != null)
                    hashCode = hashCode * 59 + this.Stukdelen.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
