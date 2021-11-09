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
    /// KadastraalOnroerendeZaakHal
    /// </summary>
    [DataContract]
    public partial class KadastraalOnroerendeZaakHal :  IEquatable<KadastraalOnroerendeZaakHal>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeKadastraalOnroerendeZaakEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KadastraalOnroerendeZaakHal" /> class.
        /// </summary>
        /// <param name="identificatie">identificatie.</param>
        /// <param name="domein">Het domein waartoe de identificatie behoort. .</param>
        /// <param name="indicatieVervallen">Vervallen objecten zijn opvraagbaar met de stand van zaken direct voordat het object vervallen is verklaard. Deze informatie is nodig om de filiatie-\&quot;boom\&quot; af te kunnen lopen en inzicht te krijgen in betrokken appartementsrechten en grondpercelen. .</param>
        /// <param name="begrenzingPerceel">begrenzingPerceel.</param>
        /// <param name="perceelnummerRotatie">Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen. .</param>
        /// <param name="plaatscoordinaten">plaatscoordinaten.</param>
        /// <param name="koopsom">koopsom.</param>
        /// <param name="toelichtingBewaarder">Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. .</param>
        /// <param name="type">type.</param>
        /// <param name="aardCultuurBebouwd">aardCultuurBebouwd.</param>
        /// <param name="aardCultuurOnbebouwd">aardCultuurOnbebouwd.</param>
        /// <param name="kadastraleAanduiding">kadastraleAanduiding.</param>
        /// <param name="kadastraleGrootte">kadastraleGrootte.</param>
        /// <param name="perceelnummerVerschuiving">perceelnummerVerschuiving.</param>
        /// <param name="adressen">Alle binnenlandse adressen gekoppeld aan deze kadastraal onroerende zaak .</param>
        /// <param name="zakelijkGerechtigdeIdentificaties">Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastraal onroerende zaak .</param>
        /// <param name="privaatrechtelijkeBeperkingIdentificaties">Alle privaatrechtelijkebeperkingen die rusten op deze kadastraal onroerende zaak .</param>
        /// <param name="hypotheekIdentificaties">Alle hypotheken die rusten op deze kadastraal onroerende zaak .</param>
        /// <param name="beslagIdentificaties">Alle beslagen die rusten op deze kadastraal onroerende zaak .</param>
        /// <param name="isOvergegaanIn">isOvergegaanIn.</param>
        /// <param name="isOntstaanUit">isOntstaanUit.</param>
        /// <param name="bijbehorendeGrondpercelen">De grondpercelen die bij deze Kadastraal Onroerende Zaak (appartementsrecht) hoort .</param>
        /// <param name="bijbehorendeAppartementsrechten">De actuele appartementsrechten die bij deze KadastraalOnroerende Zaak (grondperceel) horen .</param>
        /// <param name="isVermeldInStukdeelIdentificaties">isVermeldInStukdeelIdentificaties.</param>
        /// <param name="stukIdentificaties">Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. .</param>
        /// <param name="links">links.</param>
        /// <param name="embedded">embedded.</param>
        public KadastraalOnroerendeZaakHal(string identificatie = default(string), string domein = default(string), bool indicatieVervallen = default(bool), PolygonGeoJSON begrenzingPerceel = default(PolygonGeoJSON), decimal perceelnummerRotatie = default(decimal), PointGeoJSON plaatscoordinaten = default(PointGeoJSON), TypeKoopsom koopsom = default(TypeKoopsom), string toelichtingBewaarder = default(string), TypeKadastraalOnroerendeZaakEnum? type = default(TypeKadastraalOnroerendeZaakEnum?), Waardelijst aardCultuurBebouwd = default(Waardelijst), Waardelijst aardCultuurOnbebouwd = default(Waardelijst), string kadastraleAanduiding = default(string), TypeOppervlak kadastraleGrootte = default(TypeOppervlak), TypePerceelnummerVerschuiving perceelnummerVerschuiving = default(TypePerceelnummerVerschuiving), List<LocatieKadastraalObject> adressen = default(List<LocatieKadastraalObject>), List<string> zakelijkGerechtigdeIdentificaties = default(List<string>), List<string> privaatrechtelijkeBeperkingIdentificaties = default(List<string>), List<string> hypotheekIdentificaties = default(List<string>), List<string> beslagIdentificaties = default(List<string>), Filiatie isOvergegaanIn = default(Filiatie), Filiatie isOntstaanUit = default(Filiatie), List<PerceelBasis> bijbehorendeGrondpercelen = default(List<PerceelBasis>), List<AppartementsrechtBasis> bijbehorendeAppartementsrechten = default(List<AppartementsrechtBasis>), List<string> isVermeldInStukdeelIdentificaties = default(List<string>), List<string> stukIdentificaties = default(List<string>), KadastraalOnroerendeZaakLinks links = default(KadastraalOnroerendeZaakLinks), KadastraalOnroerendeZaakEmbedded embedded = default(KadastraalOnroerendeZaakEmbedded))
        {
            this.Identificatie = identificatie;
            this.Domein = domein;
            this.IndicatieVervallen = indicatieVervallen;
            this.BegrenzingPerceel = begrenzingPerceel;
            this.PerceelnummerRotatie = perceelnummerRotatie;
            this.Plaatscoordinaten = plaatscoordinaten;
            this.Koopsom = koopsom;
            this.ToelichtingBewaarder = toelichtingBewaarder;
            this.Type = type;
            this.AardCultuurBebouwd = aardCultuurBebouwd;
            this.AardCultuurOnbebouwd = aardCultuurOnbebouwd;
            this.KadastraleAanduiding = kadastraleAanduiding;
            this.KadastraleGrootte = kadastraleGrootte;
            this.PerceelnummerVerschuiving = perceelnummerVerschuiving;
            this.Adressen = adressen;
            this.ZakelijkGerechtigdeIdentificaties = zakelijkGerechtigdeIdentificaties;
            this.PrivaatrechtelijkeBeperkingIdentificaties = privaatrechtelijkeBeperkingIdentificaties;
            this.HypotheekIdentificaties = hypotheekIdentificaties;
            this.BeslagIdentificaties = beslagIdentificaties;
            this.IsOvergegaanIn = isOvergegaanIn;
            this.IsOntstaanUit = isOntstaanUit;
            this.BijbehorendeGrondpercelen = bijbehorendeGrondpercelen;
            this.BijbehorendeAppartementsrechten = bijbehorendeAppartementsrechten;
            this.IsVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
            this.StukIdentificaties = stukIdentificaties;
            this.Links = links;
            this.Embedded = embedded;
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
        /// Vervallen objecten zijn opvraagbaar met de stand van zaken direct voordat het object vervallen is verklaard. Deze informatie is nodig om de filiatie-\&quot;boom\&quot; af te kunnen lopen en inzicht te krijgen in betrokken appartementsrechten en grondpercelen. 
        /// </summary>
        /// <value>Vervallen objecten zijn opvraagbaar met de stand van zaken direct voordat het object vervallen is verklaard. Deze informatie is nodig om de filiatie-\&quot;boom\&quot; af te kunnen lopen en inzicht te krijgen in betrokken appartementsrechten en grondpercelen. </value>
        [DataMember(Name="indicatieVervallen", EmitDefaultValue=false)]
        public bool IndicatieVervallen { get; set; }

        /// <summary>
        /// Gets or Sets BegrenzingPerceel
        /// </summary>
        [DataMember(Name="begrenzingPerceel", EmitDefaultValue=false)]
        public PolygonGeoJSON BegrenzingPerceel { get; set; }

        /// <summary>
        /// Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen. 
        /// </summary>
        /// <value>Rotatie van het perceelnummer ten behoeve van visualisatie op de kaart. Perceelnummers worden bijvoorbeeld gekanteld om in een smal perceel te passen. </value>
        [DataMember(Name="perceelnummerRotatie", EmitDefaultValue=false)]
        public decimal PerceelnummerRotatie { get; set; }

        /// <summary>
        /// Gets or Sets Plaatscoordinaten
        /// </summary>
        [DataMember(Name="plaatscoordinaten", EmitDefaultValue=false)]
        public PointGeoJSON Plaatscoordinaten { get; set; }

        /// <summary>
        /// Gets or Sets Koopsom
        /// </summary>
        [DataMember(Name="koopsom", EmitDefaultValue=false)]
        public TypeKoopsom Koopsom { get; set; }

        /// <summary>
        /// Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. 
        /// </summary>
        /// <value>Toelichtende tekst bij een onroerende zaak van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. </value>
        [DataMember(Name="toelichtingBewaarder", EmitDefaultValue=false)]
        public string ToelichtingBewaarder { get; set; }


        /// <summary>
        /// Gets or Sets AardCultuurBebouwd
        /// </summary>
        [DataMember(Name="aardCultuurBebouwd", EmitDefaultValue=false)]
        public Waardelijst AardCultuurBebouwd { get; set; }

        /// <summary>
        /// Gets or Sets AardCultuurOnbebouwd
        /// </summary>
        [DataMember(Name="aardCultuurOnbebouwd", EmitDefaultValue=false)]
        public Waardelijst AardCultuurOnbebouwd { get; set; }

        /// <summary>
        /// Gets or Sets KadastraleAanduiding
        /// </summary>
        [DataMember(Name="kadastraleAanduiding", EmitDefaultValue=false)]
        public string KadastraleAanduiding { get; set; }

        /// <summary>
        /// Gets or Sets KadastraleGrootte
        /// </summary>
        [DataMember(Name="kadastraleGrootte", EmitDefaultValue=false)]
        public TypeOppervlak KadastraleGrootte { get; set; }

        /// <summary>
        /// Gets or Sets PerceelnummerVerschuiving
        /// </summary>
        [DataMember(Name="perceelnummerVerschuiving", EmitDefaultValue=false)]
        public TypePerceelnummerVerschuiving PerceelnummerVerschuiving { get; set; }

        /// <summary>
        /// Alle binnenlandse adressen gekoppeld aan deze kadastraal onroerende zaak 
        /// </summary>
        /// <value>Alle binnenlandse adressen gekoppeld aan deze kadastraal onroerende zaak </value>
        [DataMember(Name="adressen", EmitDefaultValue=false)]
        public List<LocatieKadastraalObject> Adressen { get; set; }

        /// <summary>
        /// Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastraal onroerende zaak 
        /// </summary>
        /// <value>Alle personen en rechtspersonen die een zakelijk recht hebben op deze kadastraal onroerende zaak </value>
        [DataMember(Name="zakelijkGerechtigdeIdentificaties", EmitDefaultValue=false)]
        public List<string> ZakelijkGerechtigdeIdentificaties { get; set; }

        /// <summary>
        /// Alle privaatrechtelijkebeperkingen die rusten op deze kadastraal onroerende zaak 
        /// </summary>
        /// <value>Alle privaatrechtelijkebeperkingen die rusten op deze kadastraal onroerende zaak </value>
        [DataMember(Name="privaatrechtelijkeBeperkingIdentificaties", EmitDefaultValue=false)]
        public List<string> PrivaatrechtelijkeBeperkingIdentificaties { get; set; }

        /// <summary>
        /// Alle hypotheken die rusten op deze kadastraal onroerende zaak 
        /// </summary>
        /// <value>Alle hypotheken die rusten op deze kadastraal onroerende zaak </value>
        [DataMember(Name="hypotheekIdentificaties", EmitDefaultValue=false)]
        public List<string> HypotheekIdentificaties { get; set; }

        /// <summary>
        /// Alle beslagen die rusten op deze kadastraal onroerende zaak 
        /// </summary>
        /// <value>Alle beslagen die rusten op deze kadastraal onroerende zaak </value>
        [DataMember(Name="beslagIdentificaties", EmitDefaultValue=false)]
        public List<string> BeslagIdentificaties { get; set; }

        /// <summary>
        /// Gets or Sets IsOvergegaanIn
        /// </summary>
        [DataMember(Name="isOvergegaanIn", EmitDefaultValue=false)]
        public Filiatie IsOvergegaanIn { get; set; }

        /// <summary>
        /// Gets or Sets IsOntstaanUit
        /// </summary>
        [DataMember(Name="isOntstaanUit", EmitDefaultValue=false)]
        public Filiatie IsOntstaanUit { get; set; }

        /// <summary>
        /// De grondpercelen die bij deze Kadastraal Onroerende Zaak (appartementsrecht) hoort 
        /// </summary>
        /// <value>De grondpercelen die bij deze Kadastraal Onroerende Zaak (appartementsrecht) hoort </value>
        [DataMember(Name="bijbehorendeGrondpercelen", EmitDefaultValue=false)]
        public List<PerceelBasis> BijbehorendeGrondpercelen { get; set; }

        /// <summary>
        /// De actuele appartementsrechten die bij deze KadastraalOnroerende Zaak (grondperceel) horen 
        /// </summary>
        /// <value>De actuele appartementsrechten die bij deze KadastraalOnroerende Zaak (grondperceel) horen </value>
        [DataMember(Name="bijbehorendeAppartementsrechten", EmitDefaultValue=false)]
        public List<AppartementsrechtBasis> BijbehorendeAppartementsrechten { get; set; }

        /// <summary>
        /// Gets or Sets IsVermeldInStukdeelIdentificaties
        /// </summary>
        [DataMember(Name="isVermeldInStukdeelIdentificaties", EmitDefaultValue=false)]
        public List<string> IsVermeldInStukdeelIdentificaties { get; set; }

        /// <summary>
        /// Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. 
        /// </summary>
        /// <value>Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. </value>
        [DataMember(Name="stukIdentificaties", EmitDefaultValue=false)]
        public List<string> StukIdentificaties { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public KadastraalOnroerendeZaakLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public KadastraalOnroerendeZaakEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KadastraalOnroerendeZaakHal {\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  Domein: ").Append(Domein).Append("\n");
            sb.Append("  IndicatieVervallen: ").Append(IndicatieVervallen).Append("\n");
            sb.Append("  BegrenzingPerceel: ").Append(BegrenzingPerceel).Append("\n");
            sb.Append("  PerceelnummerRotatie: ").Append(PerceelnummerRotatie).Append("\n");
            sb.Append("  Plaatscoordinaten: ").Append(Plaatscoordinaten).Append("\n");
            sb.Append("  Koopsom: ").Append(Koopsom).Append("\n");
            sb.Append("  ToelichtingBewaarder: ").Append(ToelichtingBewaarder).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AardCultuurBebouwd: ").Append(AardCultuurBebouwd).Append("\n");
            sb.Append("  AardCultuurOnbebouwd: ").Append(AardCultuurOnbebouwd).Append("\n");
            sb.Append("  KadastraleAanduiding: ").Append(KadastraleAanduiding).Append("\n");
            sb.Append("  KadastraleGrootte: ").Append(KadastraleGrootte).Append("\n");
            sb.Append("  PerceelnummerVerschuiving: ").Append(PerceelnummerVerschuiving).Append("\n");
            sb.Append("  Adressen: ").Append(Adressen).Append("\n");
            sb.Append("  ZakelijkGerechtigdeIdentificaties: ").Append(ZakelijkGerechtigdeIdentificaties).Append("\n");
            sb.Append("  PrivaatrechtelijkeBeperkingIdentificaties: ").Append(PrivaatrechtelijkeBeperkingIdentificaties).Append("\n");
            sb.Append("  HypotheekIdentificaties: ").Append(HypotheekIdentificaties).Append("\n");
            sb.Append("  BeslagIdentificaties: ").Append(BeslagIdentificaties).Append("\n");
            sb.Append("  IsOvergegaanIn: ").Append(IsOvergegaanIn).Append("\n");
            sb.Append("  IsOntstaanUit: ").Append(IsOntstaanUit).Append("\n");
            sb.Append("  BijbehorendeGrondpercelen: ").Append(BijbehorendeGrondpercelen).Append("\n");
            sb.Append("  BijbehorendeAppartementsrechten: ").Append(BijbehorendeAppartementsrechten).Append("\n");
            sb.Append("  IsVermeldInStukdeelIdentificaties: ").Append(IsVermeldInStukdeelIdentificaties).Append("\n");
            sb.Append("  StukIdentificaties: ").Append(StukIdentificaties).Append("\n");
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
            return this.Equals(input as KadastraalOnroerendeZaakHal);
        }

        /// <summary>
        /// Returns true if KadastraalOnroerendeZaakHal instances are equal
        /// </summary>
        /// <param name="input">Instance of KadastraalOnroerendeZaakHal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KadastraalOnroerendeZaakHal input)
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
                    this.IndicatieVervallen == input.IndicatieVervallen ||
                    (this.IndicatieVervallen != null &&
                    this.IndicatieVervallen.Equals(input.IndicatieVervallen))
                ) && 
                (
                    this.BegrenzingPerceel == input.BegrenzingPerceel ||
                    (this.BegrenzingPerceel != null &&
                    this.BegrenzingPerceel.Equals(input.BegrenzingPerceel))
                ) && 
                (
                    this.PerceelnummerRotatie == input.PerceelnummerRotatie ||
                    (this.PerceelnummerRotatie != null &&
                    this.PerceelnummerRotatie.Equals(input.PerceelnummerRotatie))
                ) && 
                (
                    this.Plaatscoordinaten == input.Plaatscoordinaten ||
                    (this.Plaatscoordinaten != null &&
                    this.Plaatscoordinaten.Equals(input.Plaatscoordinaten))
                ) && 
                (
                    this.Koopsom == input.Koopsom ||
                    (this.Koopsom != null &&
                    this.Koopsom.Equals(input.Koopsom))
                ) && 
                (
                    this.ToelichtingBewaarder == input.ToelichtingBewaarder ||
                    (this.ToelichtingBewaarder != null &&
                    this.ToelichtingBewaarder.Equals(input.ToelichtingBewaarder))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AardCultuurBebouwd == input.AardCultuurBebouwd ||
                    (this.AardCultuurBebouwd != null &&
                    this.AardCultuurBebouwd.Equals(input.AardCultuurBebouwd))
                ) && 
                (
                    this.AardCultuurOnbebouwd == input.AardCultuurOnbebouwd ||
                    (this.AardCultuurOnbebouwd != null &&
                    this.AardCultuurOnbebouwd.Equals(input.AardCultuurOnbebouwd))
                ) && 
                (
                    this.KadastraleAanduiding == input.KadastraleAanduiding ||
                    (this.KadastraleAanduiding != null &&
                    this.KadastraleAanduiding.Equals(input.KadastraleAanduiding))
                ) && 
                (
                    this.KadastraleGrootte == input.KadastraleGrootte ||
                    (this.KadastraleGrootte != null &&
                    this.KadastraleGrootte.Equals(input.KadastraleGrootte))
                ) && 
                (
                    this.PerceelnummerVerschuiving == input.PerceelnummerVerschuiving ||
                    (this.PerceelnummerVerschuiving != null &&
                    this.PerceelnummerVerschuiving.Equals(input.PerceelnummerVerschuiving))
                ) && 
                (
                    this.Adressen == input.Adressen ||
                    this.Adressen != null &&
                    input.Adressen != null &&
                    this.Adressen.SequenceEqual(input.Adressen)
                ) && 
                (
                    this.ZakelijkGerechtigdeIdentificaties == input.ZakelijkGerechtigdeIdentificaties ||
                    this.ZakelijkGerechtigdeIdentificaties != null &&
                    input.ZakelijkGerechtigdeIdentificaties != null &&
                    this.ZakelijkGerechtigdeIdentificaties.SequenceEqual(input.ZakelijkGerechtigdeIdentificaties)
                ) && 
                (
                    this.PrivaatrechtelijkeBeperkingIdentificaties == input.PrivaatrechtelijkeBeperkingIdentificaties ||
                    this.PrivaatrechtelijkeBeperkingIdentificaties != null &&
                    input.PrivaatrechtelijkeBeperkingIdentificaties != null &&
                    this.PrivaatrechtelijkeBeperkingIdentificaties.SequenceEqual(input.PrivaatrechtelijkeBeperkingIdentificaties)
                ) && 
                (
                    this.HypotheekIdentificaties == input.HypotheekIdentificaties ||
                    this.HypotheekIdentificaties != null &&
                    input.HypotheekIdentificaties != null &&
                    this.HypotheekIdentificaties.SequenceEqual(input.HypotheekIdentificaties)
                ) && 
                (
                    this.BeslagIdentificaties == input.BeslagIdentificaties ||
                    this.BeslagIdentificaties != null &&
                    input.BeslagIdentificaties != null &&
                    this.BeslagIdentificaties.SequenceEqual(input.BeslagIdentificaties)
                ) && 
                (
                    this.IsOvergegaanIn == input.IsOvergegaanIn ||
                    (this.IsOvergegaanIn != null &&
                    this.IsOvergegaanIn.Equals(input.IsOvergegaanIn))
                ) && 
                (
                    this.IsOntstaanUit == input.IsOntstaanUit ||
                    (this.IsOntstaanUit != null &&
                    this.IsOntstaanUit.Equals(input.IsOntstaanUit))
                ) && 
                (
                    this.BijbehorendeGrondpercelen == input.BijbehorendeGrondpercelen ||
                    this.BijbehorendeGrondpercelen != null &&
                    input.BijbehorendeGrondpercelen != null &&
                    this.BijbehorendeGrondpercelen.SequenceEqual(input.BijbehorendeGrondpercelen)
                ) && 
                (
                    this.BijbehorendeAppartementsrechten == input.BijbehorendeAppartementsrechten ||
                    this.BijbehorendeAppartementsrechten != null &&
                    input.BijbehorendeAppartementsrechten != null &&
                    this.BijbehorendeAppartementsrechten.SequenceEqual(input.BijbehorendeAppartementsrechten)
                ) && 
                (
                    this.IsVermeldInStukdeelIdentificaties == input.IsVermeldInStukdeelIdentificaties ||
                    this.IsVermeldInStukdeelIdentificaties != null &&
                    input.IsVermeldInStukdeelIdentificaties != null &&
                    this.IsVermeldInStukdeelIdentificaties.SequenceEqual(input.IsVermeldInStukdeelIdentificaties)
                ) && 
                (
                    this.StukIdentificaties == input.StukIdentificaties ||
                    this.StukIdentificaties != null &&
                    input.StukIdentificaties != null &&
                    this.StukIdentificaties.SequenceEqual(input.StukIdentificaties)
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
                if (this.Domein != null)
                    hashCode = hashCode * 59 + this.Domein.GetHashCode();
                if (this.IndicatieVervallen != null)
                    hashCode = hashCode * 59 + this.IndicatieVervallen.GetHashCode();
                if (this.BegrenzingPerceel != null)
                    hashCode = hashCode * 59 + this.BegrenzingPerceel.GetHashCode();
                if (this.PerceelnummerRotatie != null)
                    hashCode = hashCode * 59 + this.PerceelnummerRotatie.GetHashCode();
                if (this.Plaatscoordinaten != null)
                    hashCode = hashCode * 59 + this.Plaatscoordinaten.GetHashCode();
                if (this.Koopsom != null)
                    hashCode = hashCode * 59 + this.Koopsom.GetHashCode();
                if (this.ToelichtingBewaarder != null)
                    hashCode = hashCode * 59 + this.ToelichtingBewaarder.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AardCultuurBebouwd != null)
                    hashCode = hashCode * 59 + this.AardCultuurBebouwd.GetHashCode();
                if (this.AardCultuurOnbebouwd != null)
                    hashCode = hashCode * 59 + this.AardCultuurOnbebouwd.GetHashCode();
                if (this.KadastraleAanduiding != null)
                    hashCode = hashCode * 59 + this.KadastraleAanduiding.GetHashCode();
                if (this.KadastraleGrootte != null)
                    hashCode = hashCode * 59 + this.KadastraleGrootte.GetHashCode();
                if (this.PerceelnummerVerschuiving != null)
                    hashCode = hashCode * 59 + this.PerceelnummerVerschuiving.GetHashCode();
                if (this.Adressen != null)
                    hashCode = hashCode * 59 + this.Adressen.GetHashCode();
                if (this.ZakelijkGerechtigdeIdentificaties != null)
                    hashCode = hashCode * 59 + this.ZakelijkGerechtigdeIdentificaties.GetHashCode();
                if (this.PrivaatrechtelijkeBeperkingIdentificaties != null)
                    hashCode = hashCode * 59 + this.PrivaatrechtelijkeBeperkingIdentificaties.GetHashCode();
                if (this.HypotheekIdentificaties != null)
                    hashCode = hashCode * 59 + this.HypotheekIdentificaties.GetHashCode();
                if (this.BeslagIdentificaties != null)
                    hashCode = hashCode * 59 + this.BeslagIdentificaties.GetHashCode();
                if (this.IsOvergegaanIn != null)
                    hashCode = hashCode * 59 + this.IsOvergegaanIn.GetHashCode();
                if (this.IsOntstaanUit != null)
                    hashCode = hashCode * 59 + this.IsOntstaanUit.GetHashCode();
                if (this.BijbehorendeGrondpercelen != null)
                    hashCode = hashCode * 59 + this.BijbehorendeGrondpercelen.GetHashCode();
                if (this.BijbehorendeAppartementsrechten != null)
                    hashCode = hashCode * 59 + this.BijbehorendeAppartementsrechten.GetHashCode();
                if (this.IsVermeldInStukdeelIdentificaties != null)
                    hashCode = hashCode * 59 + this.IsVermeldInStukdeelIdentificaties.GetHashCode();
                if (this.StukIdentificaties != null)
                    hashCode = hashCode * 59 + this.StukIdentificaties.GetHashCode();
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


            // PerceelnummerRotatie (decimal) maximum
            if(this.PerceelnummerRotatie > (decimal)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerceelnummerRotatie, must be a value less than or equal to 999.", new [] { "PerceelnummerRotatie" });
            }

            yield break;
        }
    }

}
