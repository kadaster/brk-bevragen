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
    /// AdresUitgebreidAllOf
    /// </summary>
    [DataContract]
    public partial class AdresUitgebreidAllOf :  IEquatable<AdresUitgebreidAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdresUitgebreidAllOf" /> class.
        /// </summary>
        /// <param name="nummeraanduidingIdentificatie">Identificatie van het adres in het geval dit adres in BAG geregistreerd is. .</param>
        /// <param name="adresregel1">Het eerste deel van een adres is een combinatie van de straat en huisnummer. .</param>
        /// <param name="adresregel2">Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode. .</param>
        /// <param name="adresregel3">Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland. .</param>
        /// <param name="land">land.</param>
        public AdresUitgebreidAllOf(string nummeraanduidingIdentificatie = default(string), string adresregel1 = default(string), string adresregel2 = default(string), string adresregel3 = default(string), Waardelijst land = default(Waardelijst))
        {
            this.NummeraanduidingIdentificatie = nummeraanduidingIdentificatie;
            this.Adresregel1 = adresregel1;
            this.Adresregel2 = adresregel2;
            this.Adresregel3 = adresregel3;
            this.Land = land;
        }

        /// <summary>
        /// Identificatie van het adres in het geval dit adres in BAG geregistreerd is. 
        /// </summary>
        /// <value>Identificatie van het adres in het geval dit adres in BAG geregistreerd is. </value>
        [DataMember(Name="nummeraanduidingIdentificatie", EmitDefaultValue=false)]
        public string NummeraanduidingIdentificatie { get; set; }

        /// <summary>
        /// Het eerste deel van een adres is een combinatie van de straat en huisnummer. 
        /// </summary>
        /// <value>Het eerste deel van een adres is een combinatie van de straat en huisnummer. </value>
        [DataMember(Name="adresregel1", EmitDefaultValue=false)]
        public string Adresregel1 { get; set; }

        /// <summary>
        /// Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode. 
        /// </summary>
        /// <value>Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode. </value>
        [DataMember(Name="adresregel2", EmitDefaultValue=false)]
        public string Adresregel2 { get; set; }

        /// <summary>
        /// Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland. 
        /// </summary>
        /// <value>Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland. </value>
        [DataMember(Name="adresregel3", EmitDefaultValue=false)]
        public string Adresregel3 { get; set; }

        /// <summary>
        /// Gets or Sets Land
        /// </summary>
        [DataMember(Name="land", EmitDefaultValue=false)]
        public Waardelijst Land { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdresUitgebreidAllOf {\n");
            sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
            sb.Append("  Adresregel1: ").Append(Adresregel1).Append("\n");
            sb.Append("  Adresregel2: ").Append(Adresregel2).Append("\n");
            sb.Append("  Adresregel3: ").Append(Adresregel3).Append("\n");
            sb.Append("  Land: ").Append(Land).Append("\n");
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
            return this.Equals(input as AdresUitgebreidAllOf);
        }

        /// <summary>
        /// Returns true if AdresUitgebreidAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of AdresUitgebreidAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdresUitgebreidAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NummeraanduidingIdentificatie == input.NummeraanduidingIdentificatie ||
                    (this.NummeraanduidingIdentificatie != null &&
                    this.NummeraanduidingIdentificatie.Equals(input.NummeraanduidingIdentificatie))
                ) && 
                (
                    this.Adresregel1 == input.Adresregel1 ||
                    (this.Adresregel1 != null &&
                    this.Adresregel1.Equals(input.Adresregel1))
                ) && 
                (
                    this.Adresregel2 == input.Adresregel2 ||
                    (this.Adresregel2 != null &&
                    this.Adresregel2.Equals(input.Adresregel2))
                ) && 
                (
                    this.Adresregel3 == input.Adresregel3 ||
                    (this.Adresregel3 != null &&
                    this.Adresregel3.Equals(input.Adresregel3))
                ) && 
                (
                    this.Land == input.Land ||
                    (this.Land != null &&
                    this.Land.Equals(input.Land))
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
                if (this.NummeraanduidingIdentificatie != null)
                    hashCode = hashCode * 59 + this.NummeraanduidingIdentificatie.GetHashCode();
                if (this.Adresregel1 != null)
                    hashCode = hashCode * 59 + this.Adresregel1.GetHashCode();
                if (this.Adresregel2 != null)
                    hashCode = hashCode * 59 + this.Adresregel2.GetHashCode();
                if (this.Adresregel3 != null)
                    hashCode = hashCode * 59 + this.Adresregel3.GetHashCode();
                if (this.Land != null)
                    hashCode = hashCode * 59 + this.Land.GetHashCode();
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
