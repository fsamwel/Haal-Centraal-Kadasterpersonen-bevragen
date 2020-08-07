/* 
 * Kadaster - BRK-Kadasterpersonen-Bevragen API
 *
 * Deze API verstrekt informatie over bij het kadaster registreerde personen die (als het goed is) niet zijn geregistreerd in het Handelsregister of de Basisregistratie Personen (inclusief de Registratie Niet Ingezetenen). Het gaat meestal over personen die in het buitenland verblijven of organisaties die in het buitenland gevestigd zijn, en een zakelijk recht hebben op een kadastraal onroerende zaak. Personen in de basisregistratie kadaster worden niet geactualiseerd. De API verstrekt gegevens van personen op het moment van vestiging van het zakelijk recht.
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// Partnerschap is een groep gegevens over de huwelijkse- of partnerschapstatus van een persoon.
    /// </summary>
    [DataContract]
    public partial class HeeftPartnerschap :  IEquatable<HeeftPartnerschap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeeftPartnerschap" /> class.
        /// </summary>
        /// <param name="datumOntbinding">datumOntbinding.</param>
        /// <param name="datumSluiting">datumSluiting.</param>
        /// <param name="naam">naam.</param>
        public HeeftPartnerschap(DatumOnvolledig datumOntbinding = default(DatumOnvolledig), DatumOnvolledig datumSluiting = default(DatumOnvolledig), Naam naam = default(Naam))
        {
            this.DatumOntbinding = datumOntbinding;
            this.DatumSluiting = datumSluiting;
            this.Naam = naam;
        }
        
        /// <summary>
        /// Gets or Sets DatumOntbinding
        /// </summary>
        [DataMember(Name="datumOntbinding", EmitDefaultValue=false)]
        public DatumOnvolledig DatumOntbinding { get; set; }

        /// <summary>
        /// Gets or Sets DatumSluiting
        /// </summary>
        [DataMember(Name="datumSluiting", EmitDefaultValue=false)]
        public DatumOnvolledig DatumSluiting { get; set; }

        /// <summary>
        /// Gets or Sets Naam
        /// </summary>
        [DataMember(Name="naam", EmitDefaultValue=false)]
        public Naam Naam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeeftPartnerschap {\n");
            sb.Append("  DatumOntbinding: ").Append(DatumOntbinding).Append("\n");
            sb.Append("  DatumSluiting: ").Append(DatumSluiting).Append("\n");
            sb.Append("  Naam: ").Append(Naam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HeeftPartnerschap);
        }

        /// <summary>
        /// Returns true if HeeftPartnerschap instances are equal
        /// </summary>
        /// <param name="input">Instance of HeeftPartnerschap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HeeftPartnerschap input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatumOntbinding == input.DatumOntbinding ||
                    (this.DatumOntbinding != null &&
                    this.DatumOntbinding.Equals(input.DatumOntbinding))
                ) && 
                (
                    this.DatumSluiting == input.DatumSluiting ||
                    (this.DatumSluiting != null &&
                    this.DatumSluiting.Equals(input.DatumSluiting))
                ) && 
                (
                    this.Naam == input.Naam ||
                    (this.Naam != null &&
                    this.Naam.Equals(input.Naam))
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
                if (this.DatumOntbinding != null)
                    hashCode = hashCode * 59 + this.DatumOntbinding.GetHashCode();
                if (this.DatumSluiting != null)
                    hashCode = hashCode * 59 + this.DatumSluiting.GetHashCode();
                if (this.Naam != null)
                    hashCode = hashCode * 59 + this.Naam.GetHashCode();
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
