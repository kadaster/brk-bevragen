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
    /// KadasterPersoonLinks
    /// </summary>
    [DataContract]
    public partial class KadasterPersoonLinks :  IEquatable<KadasterPersoonLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KadasterPersoonLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="woonadres">woonadres.</param>
        /// <param name="postadres">postadres.</param>
        /// <param name="kadastraalOnroerendeZaken">kadastraalOnroerendeZaken.</param>
        /// <param name="zakelijkGerechtigden">zakelijkGerechtigden.</param>
        public KadasterPersoonLinks(HalLink self = default(HalLink), HalLink woonadres = default(HalLink), HalLink postadres = default(HalLink), List<HalLink> kadastraalOnroerendeZaken = default(List<HalLink>), List<HalLink> zakelijkGerechtigden = default(List<HalLink>))
        {
            this.Self = self;
            this.Woonadres = woonadres;
            this.Postadres = postadres;
            this.KadastraalOnroerendeZaken = kadastraalOnroerendeZaken;
            this.ZakelijkGerechtigden = zakelijkGerechtigden;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public HalLink Self { get; set; }

        /// <summary>
        /// Gets or Sets Woonadres
        /// </summary>
        [DataMember(Name="woonadres", EmitDefaultValue=false)]
        public HalLink Woonadres { get; set; }

        /// <summary>
        /// Gets or Sets Postadres
        /// </summary>
        [DataMember(Name="postadres", EmitDefaultValue=false)]
        public HalLink Postadres { get; set; }

        /// <summary>
        /// Gets or Sets KadastraalOnroerendeZaken
        /// </summary>
        [DataMember(Name="kadastraalOnroerendeZaken", EmitDefaultValue=false)]
        public List<HalLink> KadastraalOnroerendeZaken { get; set; }

        /// <summary>
        /// Gets or Sets ZakelijkGerechtigden
        /// </summary>
        [DataMember(Name="zakelijkGerechtigden", EmitDefaultValue=false)]
        public List<HalLink> ZakelijkGerechtigden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KadasterPersoonLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Woonadres: ").Append(Woonadres).Append("\n");
            sb.Append("  Postadres: ").Append(Postadres).Append("\n");
            sb.Append("  KadastraalOnroerendeZaken: ").Append(KadastraalOnroerendeZaken).Append("\n");
            sb.Append("  ZakelijkGerechtigden: ").Append(ZakelijkGerechtigden).Append("\n");
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
            return this.Equals(input as KadasterPersoonLinks);
        }

        /// <summary>
        /// Returns true if KadasterPersoonLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of KadasterPersoonLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KadasterPersoonLinks input)
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
                    this.Woonadres == input.Woonadres ||
                    (this.Woonadres != null &&
                    this.Woonadres.Equals(input.Woonadres))
                ) && 
                (
                    this.Postadres == input.Postadres ||
                    (this.Postadres != null &&
                    this.Postadres.Equals(input.Postadres))
                ) && 
                (
                    this.KadastraalOnroerendeZaken == input.KadastraalOnroerendeZaken ||
                    this.KadastraalOnroerendeZaken != null &&
                    input.KadastraalOnroerendeZaken != null &&
                    this.KadastraalOnroerendeZaken.SequenceEqual(input.KadastraalOnroerendeZaken)
                ) && 
                (
                    this.ZakelijkGerechtigden == input.ZakelijkGerechtigden ||
                    this.ZakelijkGerechtigden != null &&
                    input.ZakelijkGerechtigden != null &&
                    this.ZakelijkGerechtigden.SequenceEqual(input.ZakelijkGerechtigden)
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
                if (this.Woonadres != null)
                    hashCode = hashCode * 59 + this.Woonadres.GetHashCode();
                if (this.Postadres != null)
                    hashCode = hashCode * 59 + this.Postadres.GetHashCode();
                if (this.KadastraalOnroerendeZaken != null)
                    hashCode = hashCode * 59 + this.KadastraalOnroerendeZaken.GetHashCode();
                if (this.ZakelijkGerechtigden != null)
                    hashCode = hashCode * 59 + this.ZakelijkGerechtigden.GetHashCode();
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
