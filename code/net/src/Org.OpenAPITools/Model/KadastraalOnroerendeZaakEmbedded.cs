/*
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.4.0
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
    /// KadastraalOnroerendeZaakEmbedded
    /// </summary>
    [DataContract]
    public partial class KadastraalOnroerendeZaakEmbedded :  IEquatable<KadastraalOnroerendeZaakEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KadastraalOnroerendeZaakEmbedded" /> class.
        /// </summary>
        /// <param name="zakelijkGerechtigden">zakelijkGerechtigden.</param>
        /// <param name="privaatrechtelijkeBeperkingen">privaatrechtelijkeBeperkingen.</param>
        public KadastraalOnroerendeZaakEmbedded(List<ZakelijkGerechtigdeHal> zakelijkGerechtigden = default(List<ZakelijkGerechtigdeHal>), List<PrivaatrechtelijkeBeperkingHal> privaatrechtelijkeBeperkingen = default(List<PrivaatrechtelijkeBeperkingHal>))
        {
            this.ZakelijkGerechtigden = zakelijkGerechtigden;
            this.PrivaatrechtelijkeBeperkingen = privaatrechtelijkeBeperkingen;
        }

        /// <summary>
        /// Gets or Sets ZakelijkGerechtigden
        /// </summary>
        [DataMember(Name="zakelijkGerechtigden", EmitDefaultValue=false)]
        public List<ZakelijkGerechtigdeHal> ZakelijkGerechtigden { get; set; }

        /// <summary>
        /// Gets or Sets PrivaatrechtelijkeBeperkingen
        /// </summary>
        [DataMember(Name="privaatrechtelijkeBeperkingen", EmitDefaultValue=false)]
        public List<PrivaatrechtelijkeBeperkingHal> PrivaatrechtelijkeBeperkingen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KadastraalOnroerendeZaakEmbedded {\n");
            sb.Append("  ZakelijkGerechtigden: ").Append(ZakelijkGerechtigden).Append("\n");
            sb.Append("  PrivaatrechtelijkeBeperkingen: ").Append(PrivaatrechtelijkeBeperkingen).Append("\n");
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
            return this.Equals(input as KadastraalOnroerendeZaakEmbedded);
        }

        /// <summary>
        /// Returns true if KadastraalOnroerendeZaakEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of KadastraalOnroerendeZaakEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KadastraalOnroerendeZaakEmbedded input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZakelijkGerechtigden == input.ZakelijkGerechtigden ||
                    this.ZakelijkGerechtigden != null &&
                    input.ZakelijkGerechtigden != null &&
                    this.ZakelijkGerechtigden.SequenceEqual(input.ZakelijkGerechtigden)
                ) && 
                (
                    this.PrivaatrechtelijkeBeperkingen == input.PrivaatrechtelijkeBeperkingen ||
                    this.PrivaatrechtelijkeBeperkingen != null &&
                    input.PrivaatrechtelijkeBeperkingen != null &&
                    this.PrivaatrechtelijkeBeperkingen.SequenceEqual(input.PrivaatrechtelijkeBeperkingen)
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
                if (this.ZakelijkGerechtigden != null)
                    hashCode = hashCode * 59 + this.ZakelijkGerechtigden.GetHashCode();
                if (this.PrivaatrechtelijkeBeperkingen != null)
                    hashCode = hashCode * 59 + this.PrivaatrechtelijkeBeperkingen.GetHashCode();
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
