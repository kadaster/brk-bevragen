/*
 * Kadaster - BRK-Bevragen API
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.3.0
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
import org.openapitools.client.model.Naam;
import org.openapitools.client.model.NaamPersoonAllOf;

/**
 * NaamPersoon
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-14T09:58:19.624161Z[Etc/UTC]")
public class NaamPersoon {
  public static final String SERIALIZED_NAME_GESLACHTSNAAM = "geslachtsnaam";
  @SerializedName(SERIALIZED_NAME_GESLACHTSNAAM)
  private String geslachtsnaam;

  public static final String SERIALIZED_NAME_VOORNAMEN = "voornamen";
  @SerializedName(SERIALIZED_NAME_VOORNAMEN)
  private String voornamen;

  public static final String SERIALIZED_NAME_VOORVOEGSEL = "voorvoegsel";
  @SerializedName(SERIALIZED_NAME_VOORVOEGSEL)
  private String voorvoegsel;

  public static final String SERIALIZED_NAME_AANSCHRIJFWIJZE = "aanschrijfwijze";
  @SerializedName(SERIALIZED_NAME_AANSCHRIJFWIJZE)
  private String aanschrijfwijze;

  public static final String SERIALIZED_NAME_AANHEF = "aanhef";
  @SerializedName(SERIALIZED_NAME_AANHEF)
  private String aanhef;

  public static final String SERIALIZED_NAME_GEBRUIK_IN_LOPENDE_TEKST = "gebruikInLopendeTekst";
  @SerializedName(SERIALIZED_NAME_GEBRUIK_IN_LOPENDE_TEKST)
  private String gebruikInLopendeTekst;


  public NaamPersoon geslachtsnaam(String geslachtsnaam) {
    
    this.geslachtsnaam = geslachtsnaam;
    return this;
  }

   /**
   * De geslachtsnaam is de (achter)naam waarvan eventuele voorvoegsels en adellijke titel zijn afgesplitst. 
   * @return geslachtsnaam
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De geslachtsnaam is de (achter)naam waarvan eventuele voorvoegsels en adellijke titel zijn afgesplitst. ")

  public String getGeslachtsnaam() {
    return geslachtsnaam;
  }


  public void setGeslachtsnaam(String geslachtsnaam) {
    this.geslachtsnaam = geslachtsnaam;
  }


  public NaamPersoon voornamen(String voornamen) {
    
    this.voornamen = voornamen;
    return this;
  }

   /**
   * De voornamen zijn de verzameling namen die, gescheiden door spaties, aan de geslachtsnaam voorafgaat. Indien aanwezig, wordt het predikaat afgesplitst. 
   * @return voornamen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De voornamen zijn de verzameling namen die, gescheiden door spaties, aan de geslachtsnaam voorafgaat. Indien aanwezig, wordt het predikaat afgesplitst. ")

  public String getVoornamen() {
    return voornamen;
  }


  public void setVoornamen(String voornamen) {
    this.voornamen = voornamen;
  }


  public NaamPersoon voorvoegsel(String voorvoegsel) {
    
    this.voorvoegsel = voorvoegsel;
    return this;
  }

   /**
   * Voorvoegselsgeslachtsnaam is het deel van de geslachtsnaam dat, gescheiden door een spatie, vooraf gaat aan de rest van de geslachtsnaam. 
   * @return voorvoegsel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Voorvoegselsgeslachtsnaam is het deel van de geslachtsnaam dat, gescheiden door een spatie, vooraf gaat aan de rest van de geslachtsnaam. ")

  public String getVoorvoegsel() {
    return voorvoegsel;
  }


  public void setVoorvoegsel(String voorvoegsel) {
    this.voorvoegsel = voorvoegsel;
  }


  public NaamPersoon aanschrijfwijze(String aanschrijfwijze) {
    
    this.aanschrijfwijze = aanschrijfwijze;
    return this;
  }

   /**
   * De aanschrijfwijze wordt gebruikt als eerste regel in de adressering op een envelop, of links bovenaan een brief, direct boven het adres. 
   * @return aanschrijfwijze
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "G.H I. In het Veld-van Velzen", value = "De aanschrijfwijze wordt gebruikt als eerste regel in de adressering op een envelop, of links bovenaan een brief, direct boven het adres. ")

  public String getAanschrijfwijze() {
    return aanschrijfwijze;
  }


  public void setAanschrijfwijze(String aanschrijfwijze) {
    this.aanschrijfwijze = aanschrijfwijze;
  }


  public NaamPersoon aanhef(String aanhef) {
    
    this.aanhef = aanhef;
    return this;
  }

   /**
   * De aanhef wordt gebruikt bovenaan een brief 
   * @return aanhef
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "Geachte mevrouw In het Veld-van Velzen", value = "De aanhef wordt gebruikt bovenaan een brief ")

  public String getAanhef() {
    return aanhef;
  }


  public void setAanhef(String aanhef) {
    this.aanhef = aanhef;
  }


  public NaamPersoon gebruikInLopendeTekst(String gebruikInLopendeTekst) {
    
    this.gebruikInLopendeTekst = gebruikInLopendeTekst;
    return this;
  }

   /**
   * De gebruikInLopendeTekst wordt gebruikt om de persoon aan te duiden binnen een zin in een tekst 
   * @return gebruikInLopendeTekst
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "mevrouw In het Veld-van Velzen", value = "De gebruikInLopendeTekst wordt gebruikt om de persoon aan te duiden binnen een zin in een tekst ")

  public String getGebruikInLopendeTekst() {
    return gebruikInLopendeTekst;
  }


  public void setGebruikInLopendeTekst(String gebruikInLopendeTekst) {
    this.gebruikInLopendeTekst = gebruikInLopendeTekst;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    NaamPersoon naamPersoon = (NaamPersoon) o;
    return Objects.equals(this.geslachtsnaam, naamPersoon.geslachtsnaam) &&
        Objects.equals(this.voornamen, naamPersoon.voornamen) &&
        Objects.equals(this.voorvoegsel, naamPersoon.voorvoegsel) &&
        Objects.equals(this.aanschrijfwijze, naamPersoon.aanschrijfwijze) &&
        Objects.equals(this.aanhef, naamPersoon.aanhef) &&
        Objects.equals(this.gebruikInLopendeTekst, naamPersoon.gebruikInLopendeTekst);
  }

  @Override
  public int hashCode() {
    return Objects.hash(geslachtsnaam, voornamen, voorvoegsel, aanschrijfwijze, aanhef, gebruikInLopendeTekst);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class NaamPersoon {\n");
    sb.append("    geslachtsnaam: ").append(toIndentedString(geslachtsnaam)).append("\n");
    sb.append("    voornamen: ").append(toIndentedString(voornamen)).append("\n");
    sb.append("    voorvoegsel: ").append(toIndentedString(voorvoegsel)).append("\n");
    sb.append("    aanschrijfwijze: ").append(toIndentedString(aanschrijfwijze)).append("\n");
    sb.append("    aanhef: ").append(toIndentedString(aanhef)).append("\n");
    sb.append("    gebruikInLopendeTekst: ").append(toIndentedString(gebruikInLopendeTekst)).append("\n");
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

