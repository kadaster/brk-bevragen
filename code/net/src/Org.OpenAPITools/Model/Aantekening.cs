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
    /// Aantekening
    /// </summary>
    [DataContract]
    public partial class Aantekening :  IEquatable<Aantekening>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Aantekening" /> class.
        /// </summary>
        /// <param name="aard">aard.</param>
        /// <param name="omschrijving">omschrijving.</param>
        /// <param name="betreftGedeelteVanPerceel">betreftGedeelteVanPerceel.</param>
        /// <param name="identificatie">identificatie.</param>
        /// <param name="domein">Het domein waartoe de identificatie behoort. .</param>
        /// <param name="einddatum">einddatum.</param>
        /// <param name="einddatumRecht">einddatumRecht.</param>
        /// <param name="stukIdentificaties">Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. .</param>
        /// <param name="isGebaseerdOpStukdeelIdentificatie">De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze aantekening is gebaseerd. .</param>
        /// <param name="isVermeldInStukdeelIdentificaties">De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze aantekening is vermeld .</param>
        public Aantekening(Waardelijst aard = default(Waardelijst), string omschrijving = default(string), bool betreftGedeelteVanPerceel = default(bool), string identificatie = default(string), string domein = default(string), DateTime einddatum = default(DateTime), DateTime einddatumRecht = default(DateTime), List<string> stukIdentificaties = default(List<string>), string isGebaseerdOpStukdeelIdentificatie = default(string), List<string> isVermeldInStukdeelIdentificaties = default(List<string>))
        {
            this.Aard = aard;
            this.Omschrijving = omschrijving;
            this.BetreftGedeelteVanPerceel = betreftGedeelteVanPerceel;
            this.Identificatie = identificatie;
            this.Domein = domein;
            this.Einddatum = einddatum;
            this.EinddatumRecht = einddatumRecht;
            this.StukIdentificaties = stukIdentificaties;
            this.IsGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
            this.IsVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
        }

        /// <summary>
        /// Gets or Sets Aard
        /// </summary>
        [DataMember(Name="aard", EmitDefaultValue=false)]
        public Waardelijst Aard { get; set; }

        /// <summary>
        /// Gets or Sets Omschrijving
        /// </summary>
        [DataMember(Name="omschrijving", EmitDefaultValue=false)]
        public string Omschrijving { get; set; }

        /// <summary>
        /// Gets or Sets BetreftGedeelteVanPerceel
        /// </summary>
        [DataMember(Name="betreftGedeelteVanPerceel", EmitDefaultValue=false)]
        [Obsolete]
        public bool BetreftGedeelteVanPerceel { get; set; }

        /// <summary>
        /// Gets or Sets Identificatie
        /// </summary>
        [DataMember(Name="identificatie", EmitDefaultValue=false)]
        public string Identificatie { get; set; }

        /// <summary>
        /// Het domein waartoe de identificatie behoort. 
        /// </summary>
        /// <value>Het domein waartoe de identificatie behoort. </value>
        [DataMember(Name="domein", EmitDefaultValue=false)]
        public string Domein { get; set; }

        /// <summary>
        /// Gets or Sets Einddatum
        /// </summary>
        [DataMember(Name="einddatum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Einddatum { get; set; }

        /// <summary>
        /// Gets or Sets EinddatumRecht
        /// </summary>
        [DataMember(Name="einddatumRecht", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EinddatumRecht { get; set; }

        /// <summary>
        /// Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. 
        /// </summary>
        /// <value>Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. </value>
        [DataMember(Name="stukIdentificaties", EmitDefaultValue=false)]
        public List<string> StukIdentificaties { get; set; }

        /// <summary>
        /// De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze aantekening is gebaseerd. 
        /// </summary>
        /// <value>De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze aantekening is gebaseerd. </value>
        [DataMember(Name="isGebaseerdOpStukdeelIdentificatie", EmitDefaultValue=false)]
        public string IsGebaseerdOpStukdeelIdentificatie { get; set; }

        /// <summary>
        /// De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze aantekening is vermeld 
        /// </summary>
        /// <value>De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze aantekening is vermeld </value>
        [DataMember(Name="isVermeldInStukdeelIdentificaties", EmitDefaultValue=false)]
        public List<string> IsVermeldInStukdeelIdentificaties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Aantekening {\n");
            sb.Append("  Aard: ").Append(Aard).Append("\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
            sb.Append("  BetreftGedeelteVanPerceel: ").Append(BetreftGedeelteVanPerceel).Append("\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  Domein: ").Append(Domein).Append("\n");
            sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
            sb.Append("  EinddatumRecht: ").Append(EinddatumRecht).Append("\n");
            sb.Append("  StukIdentificaties: ").Append(StukIdentificaties).Append("\n");
            sb.Append("  IsGebaseerdOpStukdeelIdentificatie: ").Append(IsGebaseerdOpStukdeelIdentificatie).Append("\n");
            sb.Append("  IsVermeldInStukdeelIdentificaties: ").Append(IsVermeldInStukdeelIdentificaties).Append("\n");
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
            return this.Equals(input as Aantekening);
        }

        /// <summary>
        /// Returns true if Aantekening instances are equal
        /// </summary>
        /// <param name="input">Instance of Aantekening to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Aantekening input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aard == input.Aard ||
                    (this.Aard != null &&
                    this.Aard.Equals(input.Aard))
                ) && 
                (
                    this.Omschrijving == input.Omschrijving ||
                    (this.Omschrijving != null &&
                    this.Omschrijving.Equals(input.Omschrijving))
                ) && 
                (
                    this.BetreftGedeelteVanPerceel == input.BetreftGedeelteVanPerceel ||
                    (this.BetreftGedeelteVanPerceel != null &&
                    this.BetreftGedeelteVanPerceel.Equals(input.BetreftGedeelteVanPerceel))
                ) && 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.Domein == input.Domein ||
                    (this.Domein != null &&
                    this.Domein.Equals(input.Domein))
                ) && 
                (
                    this.Einddatum == input.Einddatum ||
                    (this.Einddatum != null &&
                    this.Einddatum.Equals(input.Einddatum))
                ) && 
                (
                    this.EinddatumRecht == input.EinddatumRecht ||
                    (this.EinddatumRecht != null &&
                    this.EinddatumRecht.Equals(input.EinddatumRecht))
                ) && 
                (
                    this.StukIdentificaties == input.StukIdentificaties ||
                    this.StukIdentificaties != null &&
                    input.StukIdentificaties != null &&
                    this.StukIdentificaties.SequenceEqual(input.StukIdentificaties)
                ) && 
                (
                    this.IsGebaseerdOpStukdeelIdentificatie == input.IsGebaseerdOpStukdeelIdentificatie ||
                    (this.IsGebaseerdOpStukdeelIdentificatie != null &&
                    this.IsGebaseerdOpStukdeelIdentificatie.Equals(input.IsGebaseerdOpStukdeelIdentificatie))
                ) && 
                (
                    this.IsVermeldInStukdeelIdentificaties == input.IsVermeldInStukdeelIdentificaties ||
                    this.IsVermeldInStukdeelIdentificaties != null &&
                    input.IsVermeldInStukdeelIdentificaties != null &&
                    this.IsVermeldInStukdeelIdentificaties.SequenceEqual(input.IsVermeldInStukdeelIdentificaties)
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
                if (this.Aard != null)
                    hashCode = hashCode * 59 + this.Aard.GetHashCode();
                if (this.Omschrijving != null)
                    hashCode = hashCode * 59 + this.Omschrijving.GetHashCode();
                if (this.BetreftGedeelteVanPerceel != null)
                    hashCode = hashCode * 59 + this.BetreftGedeelteVanPerceel.GetHashCode();
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.Domein != null)
                    hashCode = hashCode * 59 + this.Domein.GetHashCode();
                if (this.Einddatum != null)
                    hashCode = hashCode * 59 + this.Einddatum.GetHashCode();
                if (this.EinddatumRecht != null)
                    hashCode = hashCode * 59 + this.EinddatumRecht.GetHashCode();
                if (this.StukIdentificaties != null)
                    hashCode = hashCode * 59 + this.StukIdentificaties.GetHashCode();
                if (this.IsGebaseerdOpStukdeelIdentificatie != null)
                    hashCode = hashCode * 59 + this.IsGebaseerdOpStukdeelIdentificatie.GetHashCode();
                if (this.IsVermeldInStukdeelIdentificaties != null)
                    hashCode = hashCode * 59 + this.IsVermeldInStukdeelIdentificaties.GetHashCode();
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
