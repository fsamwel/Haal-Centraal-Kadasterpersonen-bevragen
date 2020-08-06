/* 
 * Kadaster - BRK-Kadasterpersonen-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van informatie over bij het Kadaster geregistreerde natuurlijk personen en niet-natuurlijk personen.
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
    /// Een bij het kadaster geregistreerde natuurlijke persoon die niet in de basisregistratie personen (BRP) is ingeschreven. Kadasternatuurlijkpersonen worden niet geactualiseerd.  Waardelijst in deze component : [beschikkingsbevoegdheid](http://www.kadaster.nl/schemas/waardelijsten/Beschikkingsbevoegdheid/) en [landWaarnaarVertrokken](http://www.kadaster.nl/schemas/waardelijsten/BRPLand/)
    /// </summary>
    [DataContract]
    public partial class KadasterNatuurlijkPersoonAllOf :  IEquatable<KadasterNatuurlijkPersoonAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KadasterNatuurlijkPersoonAllOf" /> class.
        /// </summary>
        /// <param name="geheimhoudingPersoonsgegevens">Aanduiding die aangeeft dat gegevens van een persoon wel of niet verstrekt mogen worden..</param>
        /// <param name="landWaarnaarVertrokken">landWaarnaarVertrokken.</param>
        /// <param name="geslachtsaanduiding">geslachtsaanduiding.</param>
        /// <param name="heeftPartnerschap">heeftPartnerschap.</param>
        /// <param name="naam">naam.</param>
        /// <param name="geboorte">geboorte.</param>
        /// <param name="overlijden">overlijden.</param>
        public KadasterNatuurlijkPersoonAllOf(bool geheimhoudingPersoonsgegevens = default(bool), Waardelijst landWaarnaarVertrokken = default(Waardelijst), GeslachtEnum geslachtsaanduiding = default(GeslachtEnum), List<HeeftPartnerschap> heeftPartnerschap = default(List<HeeftPartnerschap>), Naam naam = default(Naam), Geboorte geboorte = default(Geboorte), Overlijden overlijden = default(Overlijden))
        {
            this.GeheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
            this.LandWaarnaarVertrokken = landWaarnaarVertrokken;
            this.Geslachtsaanduiding = geslachtsaanduiding;
            this.HeeftPartnerschap = heeftPartnerschap;
            this.Naam = naam;
            this.Geboorte = geboorte;
            this.Overlijden = overlijden;
        }
        
        /// <summary>
        /// Aanduiding die aangeeft dat gegevens van een persoon wel of niet verstrekt mogen worden.
        /// </summary>
        /// <value>Aanduiding die aangeeft dat gegevens van een persoon wel of niet verstrekt mogen worden.</value>
        [DataMember(Name="geheimhoudingPersoonsgegevens", EmitDefaultValue=false)]
        public bool GeheimhoudingPersoonsgegevens { get; set; }

        /// <summary>
        /// Gets or Sets LandWaarnaarVertrokken
        /// </summary>
        [DataMember(Name="landWaarnaarVertrokken", EmitDefaultValue=false)]
        public Waardelijst LandWaarnaarVertrokken { get; set; }

        /// <summary>
        /// Gets or Sets Geslachtsaanduiding
        /// </summary>
        [DataMember(Name="geslachtsaanduiding", EmitDefaultValue=false)]
        public GeslachtEnum Geslachtsaanduiding { get; set; }

        /// <summary>
        /// Gets or Sets HeeftPartnerschap
        /// </summary>
        [DataMember(Name="heeftPartnerschap", EmitDefaultValue=false)]
        public List<HeeftPartnerschap> HeeftPartnerschap { get; set; }

        /// <summary>
        /// Gets or Sets Naam
        /// </summary>
        [DataMember(Name="naam", EmitDefaultValue=false)]
        public Naam Naam { get; set; }

        /// <summary>
        /// Gets or Sets Geboorte
        /// </summary>
        [DataMember(Name="geboorte", EmitDefaultValue=false)]
        public Geboorte Geboorte { get; set; }

        /// <summary>
        /// Gets or Sets Overlijden
        /// </summary>
        [DataMember(Name="overlijden", EmitDefaultValue=false)]
        public Overlijden Overlijden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KadasterNatuurlijkPersoonAllOf {\n");
            sb.Append("  GeheimhoudingPersoonsgegevens: ").Append(GeheimhoudingPersoonsgegevens).Append("\n");
            sb.Append("  LandWaarnaarVertrokken: ").Append(LandWaarnaarVertrokken).Append("\n");
            sb.Append("  Geslachtsaanduiding: ").Append(Geslachtsaanduiding).Append("\n");
            sb.Append("  HeeftPartnerschap: ").Append(HeeftPartnerschap).Append("\n");
            sb.Append("  Naam: ").Append(Naam).Append("\n");
            sb.Append("  Geboorte: ").Append(Geboorte).Append("\n");
            sb.Append("  Overlijden: ").Append(Overlijden).Append("\n");
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
            return this.Equals(input as KadasterNatuurlijkPersoonAllOf);
        }

        /// <summary>
        /// Returns true if KadasterNatuurlijkPersoonAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of KadasterNatuurlijkPersoonAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KadasterNatuurlijkPersoonAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GeheimhoudingPersoonsgegevens == input.GeheimhoudingPersoonsgegevens ||
                    this.GeheimhoudingPersoonsgegevens.Equals(input.GeheimhoudingPersoonsgegevens)
                ) && 
                (
                    this.LandWaarnaarVertrokken == input.LandWaarnaarVertrokken ||
                    (this.LandWaarnaarVertrokken != null &&
                    this.LandWaarnaarVertrokken.Equals(input.LandWaarnaarVertrokken))
                ) && 
                (
                    this.Geslachtsaanduiding == input.Geslachtsaanduiding ||
                    (this.Geslachtsaanduiding != null &&
                    this.Geslachtsaanduiding.Equals(input.Geslachtsaanduiding))
                ) && 
                (
                    this.HeeftPartnerschap == input.HeeftPartnerschap ||
                    this.HeeftPartnerschap != null &&
                    input.HeeftPartnerschap != null &&
                    this.HeeftPartnerschap.SequenceEqual(input.HeeftPartnerschap)
                ) && 
                (
                    this.Naam == input.Naam ||
                    (this.Naam != null &&
                    this.Naam.Equals(input.Naam))
                ) && 
                (
                    this.Geboorte == input.Geboorte ||
                    (this.Geboorte != null &&
                    this.Geboorte.Equals(input.Geboorte))
                ) && 
                (
                    this.Overlijden == input.Overlijden ||
                    (this.Overlijden != null &&
                    this.Overlijden.Equals(input.Overlijden))
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
                hashCode = hashCode * 59 + this.GeheimhoudingPersoonsgegevens.GetHashCode();
                if (this.LandWaarnaarVertrokken != null)
                    hashCode = hashCode * 59 + this.LandWaarnaarVertrokken.GetHashCode();
                if (this.Geslachtsaanduiding != null)
                    hashCode = hashCode * 59 + this.Geslachtsaanduiding.GetHashCode();
                if (this.HeeftPartnerschap != null)
                    hashCode = hashCode * 59 + this.HeeftPartnerschap.GetHashCode();
                if (this.Naam != null)
                    hashCode = hashCode * 59 + this.Naam.GetHashCode();
                if (this.Geboorte != null)
                    hashCode = hashCode * 59 + this.Geboorte.GetHashCode();
                if (this.Overlijden != null)
                    hashCode = hashCode * 59 + this.Overlijden.GetHashCode();
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
