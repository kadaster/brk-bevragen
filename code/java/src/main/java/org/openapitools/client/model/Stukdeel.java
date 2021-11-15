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
import org.openapitools.client.model.Bedrag;
import org.openapitools.client.model.Waardelijst;

/**
 * Een stukdeel is een paragraaf in een akte waarmee een recht gevestigd wordt. 
 */
@ApiModel(description = "Een stukdeel is een paragraaf in een akte waarmee een recht gevestigd wordt. ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-15T10:10:49.799642Z[Etc/UTC]")
public class Stukdeel {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_AARD = "aard";
  @SerializedName(SERIALIZED_NAME_AARD)
  private Waardelijst aard;

  public static final String SERIALIZED_NAME_BEDRAG_TRANSACTIESOM_LEVERING = "bedragTransactiesomLevering";
  @SerializedName(SERIALIZED_NAME_BEDRAG_TRANSACTIESOM_LEVERING)
  private Bedrag bedragTransactiesomLevering;

  public static final String SERIALIZED_NAME_OMSCHRIJVING_KADASTRALE_OBJECTEN = "omschrijvingKadastraleObjecten";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING_KADASTRALE_OBJECTEN)
  private String omschrijvingKadastraleObjecten;

  public static final String SERIALIZED_NAME_OMSCHRIJVING_TOPOGRAFISCHE_MUTATIE = "omschrijvingTopografischeMutatie";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING_TOPOGRAFISCHE_MUTATIE)
  private String omschrijvingTopografischeMutatie;


  public Stukdeel identificatie(String identificatie) {
    
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


  public Stukdeel domein(String domein) {
    
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


  public Stukdeel aard(Waardelijst aard) {
    
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


  public Stukdeel bedragTransactiesomLevering(Bedrag bedragTransactiesomLevering) {
    
    this.bedragTransactiesomLevering = bedragTransactiesomLevering;
    return this;
  }

   /**
   * Get bedragTransactiesomLevering
   * @return bedragTransactiesomLevering
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Bedrag getBedragTransactiesomLevering() {
    return bedragTransactiesomLevering;
  }


  public void setBedragTransactiesomLevering(Bedrag bedragTransactiesomLevering) {
    this.bedragTransactiesomLevering = bedragTransactiesomLevering;
  }


  public Stukdeel omschrijvingKadastraleObjecten(String omschrijvingKadastraleObjecten) {
    
    this.omschrijvingKadastraleObjecten = omschrijvingKadastraleObjecten;
    return this;
  }

   /**
   * Get omschrijvingKadastraleObjecten
   * @return omschrijvingKadastraleObjecten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getOmschrijvingKadastraleObjecten() {
    return omschrijvingKadastraleObjecten;
  }


  public void setOmschrijvingKadastraleObjecten(String omschrijvingKadastraleObjecten) {
    this.omschrijvingKadastraleObjecten = omschrijvingKadastraleObjecten;
  }


  public Stukdeel omschrijvingTopografischeMutatie(String omschrijvingTopografischeMutatie) {
    
    this.omschrijvingTopografischeMutatie = omschrijvingTopografischeMutatie;
    return this;
  }

   /**
   * Get omschrijvingTopografischeMutatie
   * @return omschrijvingTopografischeMutatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getOmschrijvingTopografischeMutatie() {
    return omschrijvingTopografischeMutatie;
  }


  public void setOmschrijvingTopografischeMutatie(String omschrijvingTopografischeMutatie) {
    this.omschrijvingTopografischeMutatie = omschrijvingTopografischeMutatie;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Stukdeel stukdeel = (Stukdeel) o;
    return Objects.equals(this.identificatie, stukdeel.identificatie) &&
        Objects.equals(this.domein, stukdeel.domein) &&
        Objects.equals(this.aard, stukdeel.aard) &&
        Objects.equals(this.bedragTransactiesomLevering, stukdeel.bedragTransactiesomLevering) &&
        Objects.equals(this.omschrijvingKadastraleObjecten, stukdeel.omschrijvingKadastraleObjecten) &&
        Objects.equals(this.omschrijvingTopografischeMutatie, stukdeel.omschrijvingTopografischeMutatie);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, domein, aard, bedragTransactiesomLevering, omschrijvingKadastraleObjecten, omschrijvingTopografischeMutatie);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Stukdeel {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    aard: ").append(toIndentedString(aard)).append("\n");
    sb.append("    bedragTransactiesomLevering: ").append(toIndentedString(bedragTransactiesomLevering)).append("\n");
    sb.append("    omschrijvingKadastraleObjecten: ").append(toIndentedString(omschrijvingKadastraleObjecten)).append("\n");
    sb.append("    omschrijvingTopografischeMutatie: ").append(toIndentedString(omschrijvingTopografischeMutatie)).append("\n");
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

