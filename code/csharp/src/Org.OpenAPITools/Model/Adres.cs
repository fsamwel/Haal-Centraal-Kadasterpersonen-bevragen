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
    /// Waardelijst in deze component : [land](http://www.kadaster.nl/schemas/waardelijsten/BRPLand/)
    /// </summary>
    [DataContract]
    public partial class Adres :  IEquatable<Adres>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adres" /> class.
        /// </summary>
        /// <param name="nummeraanduidingIdentificatie">identificatie van het adres in het geval dit adres in BAG geregistreerd is..</param>
        /// <param name="huisnummer">URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummer.</param>
        /// <param name="huisletter">URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisletter.</param>
        /// <param name="huisnummertoevoeging">URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummertoevoeging.</param>
        /// <param name="straat">straat.</param>
        /// <param name="postcode">postcode.</param>
        /// <param name="woonplaats">woonplaats.</param>
        /// <param name="adresregel1">Het eerste deel van een adres is een combinatie van de straat en huisnummer..</param>
        /// <param name="adresregel2">Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode.</param>
        /// <param name="adresregel3">Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland.</param>
        /// <param name="land">land.</param>
        public Adres(string nummeraanduidingIdentificatie = default(string), int huisnummer = default(int), string huisletter = default(string), string huisnummertoevoeging = default(string), string straat = default(string), string postcode = default(string), string woonplaats = default(string), string adresregel1 = default(string), string adresregel2 = default(string), string adresregel3 = default(string), Waardelijst land = default(Waardelijst))
        {
            this.NummeraanduidingIdentificatie = nummeraanduidingIdentificatie;
            this.Huisnummer = huisnummer;
            this.Huisletter = huisletter;
            this.Huisnummertoevoeging = huisnummertoevoeging;
            this.Straat = straat;
            this.Postcode = postcode;
            this.Woonplaats = woonplaats;
            this.Adresregel1 = adresregel1;
            this.Adresregel2 = adresregel2;
            this.Adresregel3 = adresregel3;
            this.Land = land;
        }
        
        /// <summary>
        /// identificatie van het adres in het geval dit adres in BAG geregistreerd is.
        /// </summary>
        /// <value>identificatie van het adres in het geval dit adres in BAG geregistreerd is.</value>
        [DataMember(Name="nummeraanduidingIdentificatie", EmitDefaultValue=false)]
        public string NummeraanduidingIdentificatie { get; set; }

        /// <summary>
        /// URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummer
        /// </summary>
        /// <value>URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummer</value>
        [DataMember(Name="huisnummer", EmitDefaultValue=false)]
        public int Huisnummer { get; set; }

        /// <summary>
        /// URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisletter
        /// </summary>
        /// <value>URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisletter</value>
        [DataMember(Name="huisletter", EmitDefaultValue=false)]
        public string Huisletter { get; set; }

        /// <summary>
        /// URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummertoevoeging
        /// </summary>
        /// <value>URI https://bag.basisregistraties.overheid.nl/doc/begrip/Huisnummertoevoeging</value>
        [DataMember(Name="huisnummertoevoeging", EmitDefaultValue=false)]
        public string Huisnummertoevoeging { get; set; }

        /// <summary>
        /// Gets or Sets Straat
        /// </summary>
        [DataMember(Name="straat", EmitDefaultValue=false)]
        public string Straat { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets Woonplaats
        /// </summary>
        [DataMember(Name="woonplaats", EmitDefaultValue=false)]
        public string Woonplaats { get; set; }

        /// <summary>
        /// Het eerste deel van een adres is een combinatie van de straat en huisnummer.
        /// </summary>
        /// <value>Het eerste deel van een adres is een combinatie van de straat en huisnummer.</value>
        [DataMember(Name="adresregel1", EmitDefaultValue=false)]
        public string Adresregel1 { get; set; }

        /// <summary>
        /// Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode
        /// </summary>
        /// <value>Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode</value>
        [DataMember(Name="adresregel2", EmitDefaultValue=false)]
        public string Adresregel2 { get; set; }

        /// <summary>
        /// Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland
        /// </summary>
        /// <value>Het derde deel van een adres is optioneel een of meer geografische gebieden van het adres in het buitenland</value>
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
            sb.Append("class Adres {\n");
            sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
            sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
            sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
            sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
            sb.Append("  Straat: ").Append(Straat).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Adres);
        }

        /// <summary>
        /// Returns true if Adres instances are equal
        /// </summary>
        /// <param name="input">Instance of Adres to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Adres input)
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
                    this.Huisnummer == input.Huisnummer ||
                    (this.Huisnummer != null &&
                    this.Huisnummer.Equals(input.Huisnummer))
                ) && 
                (
                    this.Huisletter == input.Huisletter ||
                    (this.Huisletter != null &&
                    this.Huisletter.Equals(input.Huisletter))
                ) && 
                (
                    this.Huisnummertoevoeging == input.Huisnummertoevoeging ||
                    (this.Huisnummertoevoeging != null &&
                    this.Huisnummertoevoeging.Equals(input.Huisnummertoevoeging))
                ) && 
                (
                    this.Straat == input.Straat ||
                    (this.Straat != null &&
                    this.Straat.Equals(input.Straat))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Woonplaats == input.Woonplaats ||
                    (this.Woonplaats != null &&
                    this.Woonplaats.Equals(input.Woonplaats))
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
                if (this.Huisnummer != null)
                    hashCode = hashCode * 59 + this.Huisnummer.GetHashCode();
                if (this.Huisletter != null)
                    hashCode = hashCode * 59 + this.Huisletter.GetHashCode();
                if (this.Huisnummertoevoeging != null)
                    hashCode = hashCode * 59 + this.Huisnummertoevoeging.GetHashCode();
                if (this.Straat != null)
                    hashCode = hashCode * 59 + this.Straat.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Woonplaats != null)
                    hashCode = hashCode * 59 + this.Woonplaats.GetHashCode();
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
