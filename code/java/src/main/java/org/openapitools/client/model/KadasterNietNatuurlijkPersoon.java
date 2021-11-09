/*
 * Kadaster - BRK-Bevragen API
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.4.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.AdresUitgebreid;
import org.openapitools.client.model.KadasterNietNatuurlijkPersoonAllOf;
import org.openapitools.client.model.KadasterPersoon;
import org.openapitools.client.model.Postadres;
import org.openapitools.client.model.Waardelijst;

/**
 * KadasterNietNatuurlijkPersoon
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-09T17:37:32.228183Z[Etc/UTC]")
public class KadasterNietNatuurlijkPersoon {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_OMSCHRIJVING = "omschrijving";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING)
  private String omschrijving;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_INDICATIE_NIET_TOONBARE_DIAKRIET = "indicatieNietToonbareDiakriet";
  @SerializedName(SERIALIZED_NAME_INDICATIE_NIET_TOONBARE_DIAKRIET)
  private Boolean indicatieNietToonbareDiakriet;

  public static final String SERIALIZED_NAME_BESCHIKKINGSBEVOEGDHEID = "beschikkingsbevoegdheid";
  @SerializedName(SERIALIZED_NAME_BESCHIKKINGSBEVOEGDHEID)
  private Waardelijst beschikkingsbevoegdheid;

  public static final String SERIALIZED_NAME_WOONADRES = "woonadres";
  @SerializedName(SERIALIZED_NAME_WOONADRES)
  private AdresUitgebreid woonadres;

  public static final String SERIALIZED_NAME_POSTADRES = "postadres";
  @SerializedName(SERIALIZED_NAME_POSTADRES)
  private Postadres postadres;

  public static final String SERIALIZED_NAME_KADASTRAAL_ONROERENDE_ZAAK_IDENTIFICATIES = "kadastraalOnroerendeZaakIdentificaties";
  @SerializedName(SERIALIZED_NAME_KADASTRAAL_ONROERENDE_ZAAK_IDENTIFICATIES)
  private List<String> kadastraalOnroerendeZaakIdentificaties = null;

  public static final String SERIALIZED_NAME_STATUTAIRE_NAAM = "statutaireNaam";
  @SerializedName(SERIALIZED_NAME_STATUTAIRE_NAAM)
  private String statutaireNaam;

  public static final String SERIALIZED_NAME_STATUTAIRE_ZETEL = "statutaireZetel";
  @SerializedName(SERIALIZED_NAME_STATUTAIRE_ZETEL)
  private String statutaireZetel;

  public static final String SERIALIZED_NAME_RECHTSVORM = "rechtsvorm";
  @SerializedName(SERIALIZED_NAME_RECHTSVORM)
  private Waardelijst rechtsvorm;

  public static final String SERIALIZED_NAME_KVK_NUMMER = "kvkNummer";
  @SerializedName(SERIALIZED_NAME_KVK_NUMMER)
  private String kvkNummer;

  public static final String SERIALIZED_NAME_RSIN = "rsin";
  @SerializedName(SERIALIZED_NAME_RSIN)
  private String rsin;


  public KadasterNietNatuurlijkPersoon identificatie(String identificatie) {
    
    this.identificatie = identificatie;
    return this;
  }

   /**
   * Unieke identificatie voor de persoon. Voor een Kadasterpersoon is dit de identificatie zoals die door het Kadaster is vastgesteld. Voor een ingeschreven natuurlijk persoon is dit het burgerservicenummer. Voor een ingeschreven niet-natuurlijk persoon is dit het RSIN. Of de waarde in identificatie een burgerservicenummer, een RSIN of een kadasterpersoonidentificatie is kan worden afgeleid uit het type persoon. 
   * @return identificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Unieke identificatie voor de persoon. Voor een Kadasterpersoon is dit de identificatie zoals die door het Kadaster is vastgesteld. Voor een ingeschreven natuurlijk persoon is dit het burgerservicenummer. Voor een ingeschreven niet-natuurlijk persoon is dit het RSIN. Of de waarde in identificatie een burgerservicenummer, een RSIN of een kadasterpersoonidentificatie is kan worden afgeleid uit het type persoon. ")

  public String getIdentificatie() {
    return identificatie;
  }


  public void setIdentificatie(String identificatie) {
    this.identificatie = identificatie;
  }


  public KadasterNietNatuurlijkPersoon omschrijving(String omschrijving) {
    
    this.omschrijving = omschrijving;
    return this;
  }

   /**
   * Voor mensen leesbare, herkenbare en identificerende omschrijving van de persoon (met bijvoorbeeld de naam). 
   * @return omschrijving
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Voor mensen leesbare, herkenbare en identificerende omschrijving van de persoon (met bijvoorbeeld de naam). ")

  public String getOmschrijving() {
    return omschrijving;
  }


  public void setOmschrijving(String omschrijving) {
    this.omschrijving = omschrijving;
  }


  public KadasterNietNatuurlijkPersoon domein(String domein) {
    
    this.domein = domein;
    return this;
  }

   /**
   * Het domein waartoe de identificatie behoort. 
   * @return domein
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Het domein waartoe de identificatie behoort. ")

  public String getDomein() {
    return domein;
  }


  public void setDomein(String domein) {
    this.domein = domein;
  }


  public KadasterNietNatuurlijkPersoon indicatieNietToonbareDiakriet(Boolean indicatieNietToonbareDiakriet) {
    
    this.indicatieNietToonbareDiakriet = indicatieNietToonbareDiakriet;
    return this;
  }

   /**
   * Get indicatieNietToonbareDiakriet
   * @return indicatieNietToonbareDiakriet
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIndicatieNietToonbareDiakriet() {
    return indicatieNietToonbareDiakriet;
  }


  public void setIndicatieNietToonbareDiakriet(Boolean indicatieNietToonbareDiakriet) {
    this.indicatieNietToonbareDiakriet = indicatieNietToonbareDiakriet;
  }


  public KadasterNietNatuurlijkPersoon beschikkingsbevoegdheid(Waardelijst beschikkingsbevoegdheid) {
    
    this.beschikkingsbevoegdheid = beschikkingsbevoegdheid;
    return this;
  }

   /**
   * Get beschikkingsbevoegdheid
   * @return beschikkingsbevoegdheid
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getBeschikkingsbevoegdheid() {
    return beschikkingsbevoegdheid;
  }


  public void setBeschikkingsbevoegdheid(Waardelijst beschikkingsbevoegdheid) {
    this.beschikkingsbevoegdheid = beschikkingsbevoegdheid;
  }


  public KadasterNietNatuurlijkPersoon woonadres(AdresUitgebreid woonadres) {
    
    this.woonadres = woonadres;
    return this;
  }

   /**
   * Get woonadres
   * @return woonadres
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public AdresUitgebreid getWoonadres() {
    return woonadres;
  }


  public void setWoonadres(AdresUitgebreid woonadres) {
    this.woonadres = woonadres;
  }


  public KadasterNietNatuurlijkPersoon postadres(Postadres postadres) {
    
    this.postadres = postadres;
    return this;
  }

   /**
   * Get postadres
   * @return postadres
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Postadres getPostadres() {
    return postadres;
  }


  public void setPostadres(Postadres postadres) {
    this.postadres = postadres;
  }


  public KadasterNietNatuurlijkPersoon kadastraalOnroerendeZaakIdentificaties(List<String> kadastraalOnroerendeZaakIdentificaties) {
    
    this.kadastraalOnroerendeZaakIdentificaties = kadastraalOnroerendeZaakIdentificaties;
    return this;
  }

  public KadasterNietNatuurlijkPersoon addKadastraalOnroerendeZaakIdentificatiesItem(String kadastraalOnroerendeZaakIdentificatiesItem) {
    if (this.kadastraalOnroerendeZaakIdentificaties == null) {
      this.kadastraalOnroerendeZaakIdentificaties = new ArrayList<>();
    }
    this.kadastraalOnroerendeZaakIdentificaties.add(kadastraalOnroerendeZaakIdentificatiesItem);
    return this;
  }

   /**
   * Get kadastraalOnroerendeZaakIdentificaties
   * @return kadastraalOnroerendeZaakIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getKadastraalOnroerendeZaakIdentificaties() {
    return kadastraalOnroerendeZaakIdentificaties;
  }


  public void setKadastraalOnroerendeZaakIdentificaties(List<String> kadastraalOnroerendeZaakIdentificaties) {
    this.kadastraalOnroerendeZaakIdentificaties = kadastraalOnroerendeZaakIdentificaties;
  }


  public KadasterNietNatuurlijkPersoon statutaireNaam(String statutaireNaam) {
    
    this.statutaireNaam = statutaireNaam;
    return this;
  }

   /**
   * Get statutaireNaam
   * @return statutaireNaam
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getStatutaireNaam() {
    return statutaireNaam;
  }


  public void setStatutaireNaam(String statutaireNaam) {
    this.statutaireNaam = statutaireNaam;
  }


  public KadasterNietNatuurlijkPersoon statutaireZetel(String statutaireZetel) {
    
    this.statutaireZetel = statutaireZetel;
    return this;
  }

   /**
   * Get statutaireZetel
   * @return statutaireZetel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getStatutaireZetel() {
    return statutaireZetel;
  }


  public void setStatutaireZetel(String statutaireZetel) {
    this.statutaireZetel = statutaireZetel;
  }


  public KadasterNietNatuurlijkPersoon rechtsvorm(Waardelijst rechtsvorm) {
    
    this.rechtsvorm = rechtsvorm;
    return this;
  }

   /**
   * Get rechtsvorm
   * @return rechtsvorm
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getRechtsvorm() {
    return rechtsvorm;
  }


  public void setRechtsvorm(Waardelijst rechtsvorm) {
    this.rechtsvorm = rechtsvorm;
  }


  public KadasterNietNatuurlijkPersoon kvkNummer(String kvkNummer) {
    
    this.kvkNummer = kvkNummer;
    return this;
  }

   /**
   * Get kvkNummer
   * @return kvkNummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getKvkNummer() {
    return kvkNummer;
  }


  public void setKvkNummer(String kvkNummer) {
    this.kvkNummer = kvkNummer;
  }


  public KadasterNietNatuurlijkPersoon rsin(String rsin) {
    
    this.rsin = rsin;
    return this;
  }

   /**
   * Get rsin
   * @return rsin
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getRsin() {
    return rsin;
  }


  public void setRsin(String rsin) {
    this.rsin = rsin;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    KadasterNietNatuurlijkPersoon kadasterNietNatuurlijkPersoon = (KadasterNietNatuurlijkPersoon) o;
    return Objects.equals(this.identificatie, kadasterNietNatuurlijkPersoon.identificatie) &&
        Objects.equals(this.omschrijving, kadasterNietNatuurlijkPersoon.omschrijving) &&
        Objects.equals(this.domein, kadasterNietNatuurlijkPersoon.domein) &&
        Objects.equals(this.indicatieNietToonbareDiakriet, kadasterNietNatuurlijkPersoon.indicatieNietToonbareDiakriet) &&
        Objects.equals(this.beschikkingsbevoegdheid, kadasterNietNatuurlijkPersoon.beschikkingsbevoegdheid) &&
        Objects.equals(this.woonadres, kadasterNietNatuurlijkPersoon.woonadres) &&
        Objects.equals(this.postadres, kadasterNietNatuurlijkPersoon.postadres) &&
        Objects.equals(this.kadastraalOnroerendeZaakIdentificaties, kadasterNietNatuurlijkPersoon.kadastraalOnroerendeZaakIdentificaties) &&
        Objects.equals(this.statutaireNaam, kadasterNietNatuurlijkPersoon.statutaireNaam) &&
        Objects.equals(this.statutaireZetel, kadasterNietNatuurlijkPersoon.statutaireZetel) &&
        Objects.equals(this.rechtsvorm, kadasterNietNatuurlijkPersoon.rechtsvorm) &&
        Objects.equals(this.kvkNummer, kadasterNietNatuurlijkPersoon.kvkNummer) &&
        Objects.equals(this.rsin, kadasterNietNatuurlijkPersoon.rsin);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, omschrijving, domein, indicatieNietToonbareDiakriet, beschikkingsbevoegdheid, woonadres, postadres, kadastraalOnroerendeZaakIdentificaties, statutaireNaam, statutaireZetel, rechtsvorm, kvkNummer, rsin);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KadasterNietNatuurlijkPersoon {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    omschrijving: ").append(toIndentedString(omschrijving)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    indicatieNietToonbareDiakriet: ").append(toIndentedString(indicatieNietToonbareDiakriet)).append("\n");
    sb.append("    beschikkingsbevoegdheid: ").append(toIndentedString(beschikkingsbevoegdheid)).append("\n");
    sb.append("    woonadres: ").append(toIndentedString(woonadres)).append("\n");
    sb.append("    postadres: ").append(toIndentedString(postadres)).append("\n");
    sb.append("    kadastraalOnroerendeZaakIdentificaties: ").append(toIndentedString(kadastraalOnroerendeZaakIdentificaties)).append("\n");
    sb.append("    statutaireNaam: ").append(toIndentedString(statutaireNaam)).append("\n");
    sb.append("    statutaireZetel: ").append(toIndentedString(statutaireZetel)).append("\n");
    sb.append("    rechtsvorm: ").append(toIndentedString(rechtsvorm)).append("\n");
    sb.append("    kvkNummer: ").append(toIndentedString(kvkNummer)).append("\n");
    sb.append("    rsin: ").append(toIndentedString(rsin)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

