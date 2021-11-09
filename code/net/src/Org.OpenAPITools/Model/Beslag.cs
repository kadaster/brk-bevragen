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
    /// Tijdelijke maatregel opgelegd door een partij waardoor de zakelijk gerechtigde niets met de kadastraal onroerende zaak kan doen.  Waardelijst in deze component : - [omschrijvingBetrokkenRecht](http://www.kadaster.nl/schemas/waardelijsten/BetrokkenRecht/) en [aard](http://www.kadaster.nl/schemas/waardelijsten/AardBeslag/) 
    /// </summary>
    [DataContract]
    public partial class Beslag :  IEquatable<Beslag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beslag" /> class.
        /// </summary>
        /// <param name="identificatie">identificatie.</param>
        /// <param name="domein">Het domein waartoe de identificatie behoort. .</param>
        /// <param name="aandeelInBetrokkenRecht">aandeelInBetrokkenRecht.</param>
        /// <param name="gedeeltelijkeBezwaringOudObject">Indicatie of het object waarop beslag is gelegd gedeeltelijk uit een inmiddels vervallen object bestaat. .</param>
        /// <param name="omschrijvingBetrokkenRecht">omschrijvingBetrokkenRecht.</param>
        /// <param name="toelichtingBewaarder">Toelichtende tekst van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. .</param>
        /// <param name="aard">aard.</param>
        /// <param name="aantekeningen">aantekeningen.</param>
        /// <param name="beslagleggers">beslagleggers.</param>
        /// <param name="bedragVordering">bedragVordering.</param>
        /// <param name="stukIdentificaties">Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. .</param>
        /// <param name="isGebaseerdOpStukdeelIdentificatie">De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop dit beslag is gebaseerd. .</param>
        /// <param name="isVermeldInStukdeelIdentificaties">De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin dit beslag is vermeld .</param>
        public Beslag(string identificatie = default(string), string domein = default(string), TypeBreuk aandeelInBetrokkenRecht = default(TypeBreuk), bool gedeeltelijkeBezwaringOudObject = default(bool), Waardelijst omschrijvingBetrokkenRecht = default(Waardelijst), string toelichtingBewaarder = default(string), Waardelijst aard = default(Waardelijst), List<AantekeningBasis> aantekeningen = default(List<AantekeningBasis>), List<PersoonBeperkt> beslagleggers = default(List<PersoonBeperkt>), Bedrag bedragVordering = default(Bedrag), List<string> stukIdentificaties = default(List<string>), string isGebaseerdOpStukdeelIdentificatie = default(string), List<string> isVermeldInStukdeelIdentificaties = default(List<string>))
        {
            this.Identificatie = identificatie;
            this.Domein = domein;
            this.AandeelInBetrokkenRecht = aandeelInBetrokkenRecht;
            this.GedeeltelijkeBezwaringOudObject = gedeeltelijkeBezwaringOudObject;
            this.OmschrijvingBetrokkenRecht = omschrijvingBetrokkenRecht;
            this.ToelichtingBewaarder = toelichtingBewaarder;
            this.Aard = aard;
            this.Aantekeningen = aantekeningen;
            this.Beslagleggers = beslagleggers;
            this.BedragVordering = bedragVordering;
            this.StukIdentificaties = stukIdentificaties;
            this.IsGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
            this.IsVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
        }

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
        /// Gets or Sets AandeelInBetrokkenRecht
        /// </summary>
        [DataMember(Name="aandeelInBetrokkenRecht", EmitDefaultValue=false)]
        public TypeBreuk AandeelInBetrokkenRecht { get; set; }

        /// <summary>
        /// Indicatie of het object waarop beslag is gelegd gedeeltelijk uit een inmiddels vervallen object bestaat. 
        /// </summary>
        /// <value>Indicatie of het object waarop beslag is gelegd gedeeltelijk uit een inmiddels vervallen object bestaat. </value>
        [DataMember(Name="gedeeltelijkeBezwaringOudObject", EmitDefaultValue=false)]
        public bool GedeeltelijkeBezwaringOudObject { get; set; }

        /// <summary>
        /// Gets or Sets OmschrijvingBetrokkenRecht
        /// </summary>
        [DataMember(Name="omschrijvingBetrokkenRecht", EmitDefaultValue=false)]
        public Waardelijst OmschrijvingBetrokkenRecht { get; set; }

        /// <summary>
        /// Toelichtende tekst van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. 
        /// </summary>
        /// <value>Toelichtende tekst van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. </value>
        [DataMember(Name="toelichtingBewaarder", EmitDefaultValue=false)]
        public string ToelichtingBewaarder { get; set; }

        /// <summary>
        /// Gets or Sets Aard
        /// </summary>
        [DataMember(Name="aard", EmitDefaultValue=false)]
        public Waardelijst Aard { get; set; }

        /// <summary>
        /// Gets or Sets Aantekeningen
        /// </summary>
        [DataMember(Name="aantekeningen", EmitDefaultValue=false)]
        public List<AantekeningBasis> Aantekeningen { get; set; }

        /// <summary>
        /// Gets or Sets Beslagleggers
        /// </summary>
        [DataMember(Name="beslagleggers", EmitDefaultValue=false)]
        public List<PersoonBeperkt> Beslagleggers { get; set; }

        /// <summary>
        /// Gets or Sets BedragVordering
        /// </summary>
        [DataMember(Name="bedragVordering", EmitDefaultValue=false)]
        public Bedrag BedragVordering { get; set; }

        /// <summary>
        /// Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. 
        /// </summary>
        /// <value>Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. </value>
        [DataMember(Name="stukIdentificaties", EmitDefaultValue=false)]
        public List<string> StukIdentificaties { get; set; }

        /// <summary>
        /// De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop dit beslag is gebaseerd. 
        /// </summary>
        /// <value>De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop dit beslag is gebaseerd. </value>
        [DataMember(Name="isGebaseerdOpStukdeelIdentificatie", EmitDefaultValue=false)]
        public string IsGebaseerdOpStukdeelIdentificatie { get; set; }

        /// <summary>
        /// De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin dit beslag is vermeld 
        /// </summary>
        /// <value>De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin dit beslag is vermeld </value>
        [DataMember(Name="isVermeldInStukdeelIdentificaties", EmitDefaultValue=false)]
        public List<string> IsVermeldInStukdeelIdentificaties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Beslag {\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  Domein: ").Append(Domein).Append("\n");
            sb.Append("  AandeelInBetrokkenRecht: ").Append(AandeelInBetrokkenRecht).Append("\n");
            sb.Append("  GedeeltelijkeBezwaringOudObject: ").Append(GedeeltelijkeBezwaringOudObject).Append("\n");
            sb.Append("  OmschrijvingBetrokkenRecht: ").Append(OmschrijvingBetrokkenRecht).Append("\n");
            sb.Append("  ToelichtingBewaarder: ").Append(ToelichtingBewaarder).Append("\n");
            sb.Append("  Aard: ").Append(Aard).Append("\n");
            sb.Append("  Aantekeningen: ").Append(Aantekeningen).Append("\n");
            sb.Append("  Beslagleggers: ").Append(Beslagleggers).Append("\n");
            sb.Append("  BedragVordering: ").Append(BedragVordering).Append("\n");
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
            return this.Equals(input as Beslag);
        }

        /// <summary>
        /// Returns true if Beslag instances are equal
        /// </summary>
        /// <param name="input">Instance of Beslag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Beslag input)
        {
            if (input == null)
                return false;

            return 
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
                    this.AandeelInBetrokkenRecht == input.AandeelInBetrokkenRecht ||
                    (this.AandeelInBetrokkenRecht != null &&
                    this.AandeelInBetrokkenRecht.Equals(input.AandeelInBetrokkenRecht))
                ) && 
                (
                    this.GedeeltelijkeBezwaringOudObject == input.GedeeltelijkeBezwaringOudObject ||
                    (this.GedeeltelijkeBezwaringOudObject != null &&
                    this.GedeeltelijkeBezwaringOudObject.Equals(input.GedeeltelijkeBezwaringOudObject))
                ) && 
                (
                    this.OmschrijvingBetrokkenRecht == input.OmschrijvingBetrokkenRecht ||
                    (this.OmschrijvingBetrokkenRecht != null &&
                    this.OmschrijvingBetrokkenRecht.Equals(input.OmschrijvingBetrokkenRecht))
                ) && 
                (
                    this.ToelichtingBewaarder == input.ToelichtingBewaarder ||
                    (this.ToelichtingBewaarder != null &&
                    this.ToelichtingBewaarder.Equals(input.ToelichtingBewaarder))
                ) && 
                (
                    this.Aard == input.Aard ||
                    (this.Aard != null &&
                    this.Aard.Equals(input.Aard))
                ) && 
                (
                    this.Aantekeningen == input.Aantekeningen ||
                    this.Aantekeningen != null &&
                    input.Aantekeningen != null &&
                    this.Aantekeningen.SequenceEqual(input.Aantekeningen)
                ) && 
                (
                    this.Beslagleggers == input.Beslagleggers ||
                    this.Beslagleggers != null &&
                    input.Beslagleggers != null &&
                    this.Beslagleggers.SequenceEqual(input.Beslagleggers)
                ) && 
                (
                    this.BedragVordering == input.BedragVordering ||
                    (this.BedragVordering != null &&
                    this.BedragVordering.Equals(input.BedragVordering))
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
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.Domein != null)
                    hashCode = hashCode * 59 + this.Domein.GetHashCode();
                if (this.AandeelInBetrokkenRecht != null)
                    hashCode = hashCode * 59 + this.AandeelInBetrokkenRecht.GetHashCode();
                if (this.GedeeltelijkeBezwaringOudObject != null)
                    hashCode = hashCode * 59 + this.GedeeltelijkeBezwaringOudObject.GetHashCode();
                if (this.OmschrijvingBetrokkenRecht != null)
                    hashCode = hashCode * 59 + this.OmschrijvingBetrokkenRecht.GetHashCode();
                if (this.ToelichtingBewaarder != null)
                    hashCode = hashCode * 59 + this.ToelichtingBewaarder.GetHashCode();
                if (this.Aard != null)
                    hashCode = hashCode * 59 + this.Aard.GetHashCode();
                if (this.Aantekeningen != null)
                    hashCode = hashCode * 59 + this.Aantekeningen.GetHashCode();
                if (this.Beslagleggers != null)
                    hashCode = hashCode * 59 + this.Beslagleggers.GetHashCode();
                if (this.BedragVordering != null)
                    hashCode = hashCode * 59 + this.BedragVordering.GetHashCode();
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
