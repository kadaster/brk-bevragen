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
    /// Oppervlakte   Waardelijst in deze component :   [soortGrootte](http://www.kadaster.nl/schemas/waardelijsten/SoortGrootte/) 
    /// </summary>
    [DataContract]
    public partial class TypeOppervlak :  IEquatable<TypeOppervlak>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeOppervlak" /> class.
        /// </summary>
        /// <param name="soortGrootte">soortGrootte.</param>
        /// <param name="waarde">Oppervlak grootte, in vierkante meters .</param>
        public TypeOppervlak(Waardelijst soortGrootte = default(Waardelijst), int waarde = default(int))
        {
            this.SoortGrootte = soortGrootte;
            this.Waarde = waarde;
        }

        /// <summary>
        /// Gets or Sets SoortGrootte
        /// </summary>
        [DataMember(Name="soortGrootte", EmitDefaultValue=false)]
        public Waardelijst SoortGrootte { get; set; }

        /// <summary>
        /// Oppervlak grootte, in vierkante meters 
        /// </summary>
        /// <value>Oppervlak grootte, in vierkante meters </value>
        [DataMember(Name="waarde", EmitDefaultValue=false)]
        public int Waarde { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypeOppervlak {\n");
            sb.Append("  SoortGrootte: ").Append(SoortGrootte).Append("\n");
            sb.Append("  Waarde: ").Append(Waarde).Append("\n");
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
            return this.Equals(input as TypeOppervlak);
        }

        /// <summary>
        /// Returns true if TypeOppervlak instances are equal
        /// </summary>
        /// <param name="input">Instance of TypeOppervlak to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypeOppervlak input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SoortGrootte == input.SoortGrootte ||
                    (this.SoortGrootte != null &&
                    this.SoortGrootte.Equals(input.SoortGrootte))
                ) && 
                (
                    this.Waarde == input.Waarde ||
                    (this.Waarde != null &&
                    this.Waarde.Equals(input.Waarde))
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
                if (this.SoortGrootte != null)
                    hashCode = hashCode * 59 + this.SoortGrootte.GetHashCode();
                if (this.Waarde != null)
                    hashCode = hashCode * 59 + this.Waarde.GetHashCode();
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
