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
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.Aantekening;
import org.openapitools.client.model.PrivaatrechtelijkeBeperkingHalAllOf;
import org.openapitools.client.model.PrivaatrechtelijkeBeperkingLinks;
import org.openapitools.client.model.Waardelijst;

/**
 * PrivaatrechtelijkeBeperkingHal
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-15T10:10:49.799642Z[Etc/UTC]")
public class PrivaatrechtelijkeBeperkingHal {
  public static final String SERIALIZED_NAME_AARD = "aard";
  @SerializedName(SERIALIZED_NAME_AARD)
  private Waardelijst aard;

  public static final String SERIALIZED_NAME_OMSCHRIJVING = "omschrijving";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING)
  private String omschrijving;

  public static final String SERIALIZED_NAME_BETREFT_GEDEELTE_VAN_PERCEEL = "betreftGedeelteVanPerceel";
  @SerializedName(SERIALIZED_NAME_BETREFT_GEDEELTE_VAN_PERCEEL)
  private Boolean betreftGedeelteVanPerceel;

  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_EINDDATUM = "einddatum";
  @SerializedName(SERIALIZED_NAME_EINDDATUM)
  private LocalDate einddatum;

  public static final String SERIALIZED_NAME_EINDDATUM_RECHT = "einddatumRecht";
  @SerializedName(SERIALIZED_NAME_EINDDATUM_RECHT)
  private LocalDate einddatumRecht;

  public static final String SERIALIZED_NAME_STUK_IDENTIFICATIES = "stukIdentificaties";
  @SerializedName(SERIALIZED_NAME_STUK_IDENTIFICATIES)
  private List<String> stukIdentificaties = null;

  public static final String SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIE = "isGebaseerdOpStukdeelIdentificatie";
  @SerializedName(SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIE)
  private String isGebaseerdOpStukdeelIdentificatie;

  public static final String SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES = "isVermeldInStukdeelIdentificaties";
  @SerializedName(SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES)
  private List<String> isVermeldInStukdeelIdentificaties = null;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private PrivaatrechtelijkeBeperkingLinks links;


  public PrivaatrechtelijkeBeperkingHal aard(Waardelijst aard) {
    
    this.aard = aard;
    return this;
  }

   /**
   * Get aard
   * @return aard
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getAard() {
    return aard;
  }


  public void setAard(Waardelijst aard) {
    this.aard = aard;
  }


  public PrivaatrechtelijkeBeperkingHal omschrijving(String omschrijving) {
    
    this.omschrijving = omschrijving;
    return this;
  }

   /**
   * Get omschrijving
   * @return omschrijving
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getOmschrijving() {
    return omschrijving;
  }


  public void setOmschrijving(String omschrijving) {
    this.omschrijving = omschrijving;
  }


  public PrivaatrechtelijkeBeperkingHal betreftGedeelteVanPerceel(Boolean betreftGedeelteVanPerceel) {
    
    this.betreftGedeelteVanPerceel = betreftGedeelteVanPerceel;
    return this;
  }

   /**
   * Get betreftGedeelteVanPerceel
   * @return betreftGedeelteVanPerceel
   * @deprecated
  **/
  @Deprecated
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getBetreftGedeelteVanPerceel() {
    return betreftGedeelteVanPerceel;
  }


  public void setBetreftGedeelteVanPerceel(Boolean betreftGedeelteVanPerceel) {
    this.betreftGedeelteVanPerceel = betreftGedeelteVanPerceel;
  }


  public PrivaatrechtelijkeBeperkingHal identificatie(String identificatie) {
    
    this.identificatie = identificatie;
    return this;
  }

   /**
   * Get identificatie
   * @return identificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getIdentificatie() {
    return identificatie;
  }


  public void setIdentificatie(String identificatie) {
    this.identificatie = identificatie;
  }


  public PrivaatrechtelijkeBeperkingHal domein(String domein) {
    
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


  public PrivaatrechtelijkeBeperkingHal einddatum(LocalDate einddatum) {
    
    this.einddatum = einddatum;
    return this;
  }

   /**
   * Get einddatum
   * @return einddatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public LocalDate getEinddatum() {
    return einddatum;
  }


  public void setEinddatum(LocalDate einddatum) {
    this.einddatum = einddatum;
  }


  public PrivaatrechtelijkeBeperkingHal einddatumRecht(LocalDate einddatumRecht) {
    
    this.einddatumRecht = einddatumRecht;
    return this;
  }

   /**
   * Get einddatumRecht
   * @return einddatumRecht
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public LocalDate getEinddatumRecht() {
    return einddatumRecht;
  }


  public void setEinddatumRecht(LocalDate einddatumRecht) {
    this.einddatumRecht = einddatumRecht;
  }


  public PrivaatrechtelijkeBeperkingHal stukIdentificaties(List<String> stukIdentificaties) {
    
    this.stukIdentificaties = stukIdentificaties;
    return this;
  }

  public PrivaatrechtelijkeBeperkingHal addStukIdentificatiesItem(String stukIdentificatiesItem) {
    if (this.stukIdentificaties == null) {
      this.stukIdentificaties = new ArrayList<>();
    }
    this.stukIdentificaties.add(stukIdentificatiesItem);
    return this;
  }

   /**
   * Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. 
   * @return stukIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Identificatie van het stuk. Een stuk is een brondocument dat aanleiding geeft tot een wijziging van de gegevens in een basisregistratie. Dit kan een aangeboden stuk of een kadasterstuk zijn. ")

  public List<String> getStukIdentificaties() {
    return stukIdentificaties;
  }


  public void setStukIdentificaties(List<String> stukIdentificaties) {
    this.stukIdentificaties = stukIdentificaties;
  }


  public PrivaatrechtelijkeBeperkingHal isGebaseerdOpStukdeelIdentificatie(String isGebaseerdOpStukdeelIdentificatie) {
    
    this.isGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
    return this;
  }

   /**
   * De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze aantekening is gebaseerd. 
   * @return isGebaseerdOpStukdeelIdentificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop deze aantekening is gebaseerd. ")

  public String getIsGebaseerdOpStukdeelIdentificatie() {
    return isGebaseerdOpStukdeelIdentificatie;
  }


  public void setIsGebaseerdOpStukdeelIdentificatie(String isGebaseerdOpStukdeelIdentificatie) {
    this.isGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
  }


  public PrivaatrechtelijkeBeperkingHal isVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
    return this;
  }

  public PrivaatrechtelijkeBeperkingHal addIsVermeldInStukdeelIdentificatiesItem(String isVermeldInStukdeelIdentificatiesItem) {
    if (this.isVermeldInStukdeelIdentificaties == null) {
      this.isVermeldInStukdeelIdentificaties = new ArrayList<>();
    }
    this.isVermeldInStukdeelIdentificaties.add(isVermeldInStukdeelIdentificatiesItem);
    return this;
  }

   /**
   * De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze aantekening is vermeld 
   * @return isVermeldInStukdeelIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin deze aantekening is vermeld ")

  public List<String> getIsVermeldInStukdeelIdentificaties() {
    return isVermeldInStukdeelIdentificaties;
  }


  public void setIsVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
  }


  public PrivaatrechtelijkeBeperkingHal links(PrivaatrechtelijkeBeperkingLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public PrivaatrechtelijkeBeperkingLinks getLinks() {
    return links;
  }


  public void setLinks(PrivaatrechtelijkeBeperkingLinks links) {
    this.links = links;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PrivaatrechtelijkeBeperkingHal privaatrechtelijkeBeperkingHal = (PrivaatrechtelijkeBeperkingHal) o;
    return Objects.equals(this.aard, privaatrechtelijkeBeperkingHal.aard) &&
        Objects.equals(this.omschrijving, privaatrechtelijkeBeperkingHal.omschrijving) &&
        Objects.equals(this.betreftGedeelteVanPerceel, privaatrechtelijkeBeperkingHal.betreftGedeelteVanPerceel) &&
        Objects.equals(this.identificatie, privaatrechtelijkeBeperkingHal.identificatie) &&
        Objects.equals(this.domein, privaatrechtelijkeBeperkingHal.domein) &&
        Objects.equals(this.einddatum, privaatrechtelijkeBeperkingHal.einddatum) &&
        Objects.equals(this.einddatumRecht, privaatrechtelijkeBeperkingHal.einddatumRecht) &&
        Objects.equals(this.stukIdentificaties, privaatrechtelijkeBeperkingHal.stukIdentificaties) &&
        Objects.equals(this.isGebaseerdOpStukdeelIdentificatie, privaatrechtelijkeBeperkingHal.isGebaseerdOpStukdeelIdentificatie) &&
        Objects.equals(this.isVermeldInStukdeelIdentificaties, privaatrechtelijkeBeperkingHal.isVermeldInStukdeelIdentificaties) &&
        Objects.equals(this.links, privaatrechtelijkeBeperkingHal.links);
  }

  @Override
  public int hashCode() {
    return Objects.hash(aard, omschrijving, betreftGedeelteVanPerceel, identificatie, domein, einddatum, einddatumRecht, stukIdentificaties, isGebaseerdOpStukdeelIdentificatie, isVermeldInStukdeelIdentificaties, links);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PrivaatrechtelijkeBeperkingHal {\n");
    sb.append("    aard: ").append(toIndentedString(aard)).append("\n");
    sb.append("    omschrijving: ").append(toIndentedString(omschrijving)).append("\n");
    sb.append("    betreftGedeelteVanPerceel: ").append(toIndentedString(betreftGedeelteVanPerceel)).append("\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    einddatum: ").append(toIndentedString(einddatum)).append("\n");
    sb.append("    einddatumRecht: ").append(toIndentedString(einddatumRecht)).append("\n");
    sb.append("    stukIdentificaties: ").append(toIndentedString(stukIdentificaties)).append("\n");
    sb.append("    isGebaseerdOpStukdeelIdentificatie: ").append(toIndentedString(isGebaseerdOpStukdeelIdentificatie)).append("\n");
    sb.append("    isVermeldInStukdeelIdentificaties: ").append(toIndentedString(isVermeldInStukdeelIdentificaties)).append("\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
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

