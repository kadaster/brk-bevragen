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
    /// StukHal
    /// </summary>
    [DataContract]
    public partial class StukHal :  IEquatable<StukHal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StukHal" /> class.
        /// </summary>
        /// <param name="identificatie">identificatie.</param>
        /// <param name="deelEnNummer">deelEnNummer.</param>
        /// <param name="domein">Het domein waartoe de identificatie behoort. .</param>
        /// <param name="toelichtingBewaarder">Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. .</param>
        /// <param name="stukdeelIdentificaties">stukdeelIdentificaties.</param>
        /// <param name="bewaardersVerklaring">Correctie in de openbare registers door de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. .</param>
        /// <param name="indicatieTekeningBijgevoegd">Geeft aan dat er een tekening van het appartement als bijlage bij het stuk aanwezig is. .</param>
        /// <param name="aard">aard.</param>
        /// <param name="status">status.</param>
        /// <param name="equivalentieVerklaarder">equivalentieVerklaarder.</param>
        /// <param name="kadasterverzoeken">kadasterverzoeken.</param>
        /// <param name="links">links.</param>
        /// <param name="embedded">embedded.</param>
        public StukHal(string identificatie = default(string), DeelEnNummer deelEnNummer = default(DeelEnNummer), string domein = default(string), string toelichtingBewaarder = default(string), List<string> stukdeelIdentificaties = default(List<string>), string bewaardersVerklaring = default(string), bool indicatieTekeningBijgevoegd = default(bool), Waardelijst aard = default(Waardelijst), Waardelijst status = default(Waardelijst), EquivalentieVerklaarder equivalentieVerklaarder = default(EquivalentieVerklaarder), List<Kadasterverzoek> kadasterverzoeken = default(List<Kadasterverzoek>), StukLinks links = default(StukLinks), StukEmbedded embedded = default(StukEmbedded))
        {
            this.Identificatie = identificatie;
            this.DeelEnNummer = deelEnNummer;
            this.Domein = domein;
            this.ToelichtingBewaarder = toelichtingBewaarder;
            this.StukdeelIdentificaties = stukdeelIdentificaties;
            this.BewaardersVerklaring = bewaardersVerklaring;
            this.IndicatieTekeningBijgevoegd = indicatieTekeningBijgevoegd;
            this.Aard = aard;
            this.Status = status;
            this.EquivalentieVerklaarder = equivalentieVerklaarder;
            this.Kadasterverzoeken = kadasterverzoeken;
            this.Links = links;
            this.Embedded = embedded;
        }

        /// <summary>
        /// Gets or Sets Identificatie
        /// </summary>
        [DataMember(Name="identificatie", EmitDefaultValue=false)]
        public string Identificatie { get; set; }

        /// <summary>
        /// Gets or Sets DeelEnNummer
        /// </summary>
        [DataMember(Name="deelEnNummer", EmitDefaultValue=false)]
        public DeelEnNummer DeelEnNummer { get; set; }

        /// <summary>
        /// Het domein waartoe de identificatie behoort. 
        /// </summary>
        /// <value>Het domein waartoe de identificatie behoort. </value>
        [DataMember(Name="domein", EmitDefaultValue=false)]
        public string Domein { get; set; }

        /// <summary>
        /// Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. 
        /// </summary>
        /// <value>Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. </value>
        [DataMember(Name="toelichtingBewaarder", EmitDefaultValue=false)]
        public string ToelichtingBewaarder { get; set; }

        /// <summary>
        /// Gets or Sets StukdeelIdentificaties
        /// </summary>
        [DataMember(Name="stukdeelIdentificaties", EmitDefaultValue=false)]
        public List<string> StukdeelIdentificaties { get; set; }

        /// <summary>
        /// Correctie in de openbare registers door de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. 
        /// </summary>
        /// <value>Correctie in de openbare registers door de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. </value>
        [DataMember(Name="bewaardersVerklaring", EmitDefaultValue=false)]
        public string BewaardersVerklaring { get; set; }

        /// <summary>
        /// Geeft aan dat er een tekening van het appartement als bijlage bij het stuk aanwezig is. 
        /// </summary>
        /// <value>Geeft aan dat er een tekening van het appartement als bijlage bij het stuk aanwezig is. </value>
        [DataMember(Name="indicatieTekeningBijgevoegd", EmitDefaultValue=false)]
        public bool IndicatieTekeningBijgevoegd { get; set; }

        /// <summary>
        /// Gets or Sets Aard
        /// </summary>
        [DataMember(Name="aard", EmitDefaultValue=false)]
        public Waardelijst Aard { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public Waardelijst Status { get; set; }

        /// <summary>
        /// Gets or Sets EquivalentieVerklaarder
        /// </summary>
        [DataMember(Name="equivalentieVerklaarder", EmitDefaultValue=false)]
        public EquivalentieVerklaarder EquivalentieVerklaarder { get; set; }

        /// <summary>
        /// Gets or Sets Kadasterverzoeken
        /// </summary>
        [DataMember(Name="kadasterverzoeken", EmitDefaultValue=false)]
        public List<Kadasterverzoek> Kadasterverzoeken { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public StukLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public StukEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StukHal {\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  DeelEnNummer: ").Append(DeelEnNummer).Append("\n");
            sb.Append("  Domein: ").Append(Domein).Append("\n");
            sb.Append("  ToelichtingBewaarder: ").Append(ToelichtingBewaarder).Append("\n");
            sb.Append("  StukdeelIdentificaties: ").Append(StukdeelIdentificaties).Append("\n");
            sb.Append("  BewaardersVerklaring: ").Append(BewaardersVerklaring).Append("\n");
            sb.Append("  IndicatieTekeningBijgevoegd: ").Append(IndicatieTekeningBijgevoegd).Append("\n");
            sb.Append("  Aard: ").Append(Aard).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EquivalentieVerklaarder: ").Append(EquivalentieVerklaarder).Append("\n");
            sb.Append("  Kadasterverzoeken: ").Append(Kadasterverzoeken).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
            return this.Equals(input as StukHal);
        }

        /// <summary>
        /// Returns true if StukHal instances are equal
        /// </summary>
        /// <param name="input">Instance of StukHal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StukHal input)
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
                    this.DeelEnNummer == input.DeelEnNummer ||
                    (this.DeelEnNummer != null &&
                    this.DeelEnNummer.Equals(input.DeelEnNummer))
                ) && 
                (
                    this.Domein == input.Domein ||
                    (this.Domein != null &&
                    this.Domein.Equals(input.Domein))
                ) && 
                (
                    this.ToelichtingBewaarder == input.ToelichtingBewaarder ||
                    (this.ToelichtingBewaarder != null &&
                    this.ToelichtingBewaarder.Equals(input.ToelichtingBewaarder))
                ) && 
                (
                    this.StukdeelIdentificaties == input.StukdeelIdentificaties ||
                    this.StukdeelIdentificaties != null &&
                    input.StukdeelIdentificaties != null &&
                    this.StukdeelIdentificaties.SequenceEqual(input.StukdeelIdentificaties)
                ) && 
                (
                    this.BewaardersVerklaring == input.BewaardersVerklaring ||
                    (this.BewaardersVerklaring != null &&
                    this.BewaardersVerklaring.Equals(input.BewaardersVerklaring))
                ) && 
                (
                    this.IndicatieTekeningBijgevoegd == input.IndicatieTekeningBijgevoegd ||
                    (this.IndicatieTekeningBijgevoegd != null &&
                    this.IndicatieTekeningBijgevoegd.Equals(input.IndicatieTekeningBijgevoegd))
                ) && 
                (
                    this.Aard == input.Aard ||
                    (this.Aard != null &&
                    this.Aard.Equals(input.Aard))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EquivalentieVerklaarder == input.EquivalentieVerklaarder ||
                    (this.EquivalentieVerklaarder != null &&
                    this.EquivalentieVerklaarder.Equals(input.EquivalentieVerklaarder))
                ) && 
                (
                    this.Kadasterverzoeken == input.Kadasterverzoeken ||
                    this.Kadasterverzoeken != null &&
                    input.Kadasterverzoeken != null &&
                    this.Kadasterverzoeken.SequenceEqual(input.Kadasterverzoeken)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Embedded == input.Embedded ||
                    (this.Embedded != null &&
                    this.Embedded.Equals(input.Embedded))
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
                if (this.DeelEnNummer != null)
                    hashCode = hashCode * 59 + this.DeelEnNummer.GetHashCode();
                if (this.Domein != null)
                    hashCode = hashCode * 59 + this.Domein.GetHashCode();
                if (this.ToelichtingBewaarder != null)
                    hashCode = hashCode * 59 + this.ToelichtingBewaarder.GetHashCode();
                if (this.StukdeelIdentificaties != null)
                    hashCode = hashCode * 59 + this.StukdeelIdentificaties.GetHashCode();
                if (this.BewaardersVerklaring != null)
                    hashCode = hashCode * 59 + this.BewaardersVerklaring.GetHashCode();
                if (this.IndicatieTekeningBijgevoegd != null)
                    hashCode = hashCode * 59 + this.IndicatieTekeningBijgevoegd.GetHashCode();
                if (this.Aard != null)
                    hashCode = hashCode * 59 + this.Aard.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EquivalentieVerklaarder != null)
                    hashCode = hashCode * 59 + this.EquivalentieVerklaarder.GetHashCode();
                if (this.Kadasterverzoeken != null)
                    hashCode = hashCode * 59 + this.Kadasterverzoeken.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Embedded != null)
                    hashCode = hashCode * 59 + this.Embedded.GetHashCode();
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
