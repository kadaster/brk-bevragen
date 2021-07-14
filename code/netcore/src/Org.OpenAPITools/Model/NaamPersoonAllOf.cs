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
    /// Gegevens over de naam van de persoon 
    /// </summary>
    [DataContract(Name = "NaamPersoon_allOf")]
    public partial class NaamPersoonAllOf : IEquatable<NaamPersoonAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NaamPersoonAllOf" /> class.
        /// </summary>
        /// <param name="aanschrijfwijze">De aanschrijfwijze wordt gebruikt als eerste regel in de adressering op een envelop, of links bovenaan een brief, direct boven het adres. .</param>
        /// <param name="aanhef">De aanhef wordt gebruikt bovenaan een brief .</param>
        /// <param name="gebruikInLopendeTekst">De gebruikInLopendeTekst wordt gebruikt om de persoon aan te duiden binnen een zin in een tekst .</param>
        public NaamPersoonAllOf(string aanschrijfwijze = default(string), string aanhef = default(string), string gebruikInLopendeTekst = default(string))
        {
            this.Aanschrijfwijze = aanschrijfwijze;
            this.Aanhef = aanhef;
            this.GebruikInLopendeTekst = gebruikInLopendeTekst;
        }

        /// <summary>
        /// De aanschrijfwijze wordt gebruikt als eerste regel in de adressering op een envelop, of links bovenaan een brief, direct boven het adres. 
        /// </summary>
        /// <value>De aanschrijfwijze wordt gebruikt als eerste regel in de adressering op een envelop, of links bovenaan een brief, direct boven het adres. </value>
        [DataMember(Name = "aanschrijfwijze", EmitDefaultValue = false)]
        public string Aanschrijfwijze { get; set; }

        /// <summary>
        /// De aanhef wordt gebruikt bovenaan een brief 
        /// </summary>
        /// <value>De aanhef wordt gebruikt bovenaan een brief </value>
        [DataMember(Name = "aanhef", EmitDefaultValue = false)]
        public string Aanhef { get; set; }

        /// <summary>
        /// De gebruikInLopendeTekst wordt gebruikt om de persoon aan te duiden binnen een zin in een tekst 
        /// </summary>
        /// <value>De gebruikInLopendeTekst wordt gebruikt om de persoon aan te duiden binnen een zin in een tekst </value>
        [DataMember(Name = "gebruikInLopendeTekst", EmitDefaultValue = false)]
        public string GebruikInLopendeTekst { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NaamPersoonAllOf {\n");
            sb.Append("  Aanschrijfwijze: ").Append(Aanschrijfwijze).Append("\n");
            sb.Append("  Aanhef: ").Append(Aanhef).Append("\n");
            sb.Append("  GebruikInLopendeTekst: ").Append(GebruikInLopendeTekst).Append("\n");
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
            return this.Equals(input as NaamPersoonAllOf);
        }

        /// <summary>
        /// Returns true if NaamPersoonAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of NaamPersoonAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NaamPersoonAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aanschrijfwijze == input.Aanschrijfwijze ||
                    (this.Aanschrijfwijze != null &&
                    this.Aanschrijfwijze.Equals(input.Aanschrijfwijze))
                ) && 
                (
                    this.Aanhef == input.Aanhef ||
                    (this.Aanhef != null &&
                    this.Aanhef.Equals(input.Aanhef))
                ) && 
                (
                    this.GebruikInLopendeTekst == input.GebruikInLopendeTekst ||
                    (this.GebruikInLopendeTekst != null &&
                    this.GebruikInLopendeTekst.Equals(input.GebruikInLopendeTekst))
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
                if (this.Aanschrijfwijze != null)
                    hashCode = hashCode * 59 + this.Aanschrijfwijze.GetHashCode();
                if (this.Aanhef != null)
                    hashCode = hashCode * 59 + this.Aanhef.GetHashCode();
                if (this.GebruikInLopendeTekst != null)
                    hashCode = hashCode * 59 + this.GebruikInLopendeTekst.GetHashCode();
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
