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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AppartementsrechtFiliatie
    /// </summary>
    [DataContract(Name = "AppartementsrechtFiliatie")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AppartementsrechtFiliatie), "appartementsrecht")]
    [JsonSubtypes.KnownSubType(typeof(PerceelFiliatie), "perceel")]
    public partial class AppartementsrechtFiliatie : KadastraalOnroerendeZaakFiliatie, IEquatable<AppartementsrechtFiliatie>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppartementsrechtFiliatie" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppartementsrechtFiliatie() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppartementsrechtFiliatie" /> class.
        /// </summary>
        /// <param name="indicatieSluimerend">indicatieSluimerend.</param>
        /// <param name="identificatie">De identificatie van de Kadastraal Onroerende Zaak. .</param>
        /// <param name="type">type (required) (default to &quot;AppartementsrechtFiliatie&quot;).</param>
        public AppartementsrechtFiliatie(bool indicatieSluimerend = default(bool), string identificatie = default(string), TypeKadastraalOnroerendeZaakEnum type = "AppartementsrechtFiliatie") : base(identificatie, type)
        {
            this.IndicatieSluimerend = indicatieSluimerend;
        }

        /// <summary>
        /// Gets or Sets IndicatieSluimerend
        /// </summary>
        [DataMember(Name = "indicatieSluimerend", EmitDefaultValue = true)]
        public bool IndicatieSluimerend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppartementsrechtFiliatie {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  IndicatieSluimerend: ").Append(IndicatieSluimerend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as AppartementsrechtFiliatie);
        }

        /// <summary>
        /// Returns true if AppartementsrechtFiliatie instances are equal
        /// </summary>
        /// <param name="input">Instance of AppartementsrechtFiliatie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppartementsrechtFiliatie input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.IndicatieSluimerend == input.IndicatieSluimerend ||
                    this.IndicatieSluimerend.Equals(input.IndicatieSluimerend)
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
                int hashCode = base.GetHashCode();
                hashCode = hashCode * 59 + this.IndicatieSluimerend.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
