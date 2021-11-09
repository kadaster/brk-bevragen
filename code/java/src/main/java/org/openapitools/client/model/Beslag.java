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
import org.openapitools.client.model.AantekeningBasis;
import org.openapitools.client.model.Bedrag;
import org.openapitools.client.model.PersoonBeperkt;
import org.openapitools.client.model.TypeBreuk;
import org.openapitools.client.model.Waardelijst;

/**
 * Tijdelijke maatregel opgelegd door een partij waardoor de zakelijk gerechtigde niets met de kadastraal onroerende zaak kan doen.  Waardelijst in deze component : - [omschrijvingBetrokkenRecht](http://www.kadaster.nl/schemas/waardelijsten/BetrokkenRecht/) en [aard](http://www.kadaster.nl/schemas/waardelijsten/AardBeslag/) 
 */
@ApiModel(description = "Tijdelijke maatregel opgelegd door een partij waardoor de zakelijk gerechtigde niets met de kadastraal onroerende zaak kan doen.  Waardelijst in deze component : - [omschrijvingBetrokkenRecht](http://www.kadaster.nl/schemas/waardelijsten/BetrokkenRecht/) en [aard](http://www.kadaster.nl/schemas/waardelijsten/AardBeslag/) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-09T17:37:32.228183Z[Etc/UTC]")
public class Beslag {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_AANDEEL_IN_BETROKKEN_RECHT = "aandeelInBetrokkenRecht";
  @SerializedName(SERIALIZED_NAME_AANDEEL_IN_BETROKKEN_RECHT)
  private TypeBreuk aandeelInBetrokkenRecht;

  public static final String SERIALIZED_NAME_GEDEELTELIJKE_BEZWARING_OUD_OBJECT = "gedeeltelijkeBezwaringOudObject";
  @SerializedName(SERIALIZED_NAME_GEDEELTELIJKE_BEZWARING_OUD_OBJECT)
  private Boolean gedeeltelijkeBezwaringOudObject;

  public static final String SERIALIZED_NAME_OMSCHRIJVING_BETROKKEN_RECHT = "omschrijvingBetrokkenRecht";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING_BETROKKEN_RECHT)
  private Waardelijst omschrijvingBetrokkenRecht;

  public static final String SERIALIZED_NAME_TOELICHTING_BEWAARDER = "toelichtingBewaarder";
  @SerializedName(SERIALIZED_NAME_TOELICHTING_BEWAARDER)
  private String toelichtingBewaarder;

  public static final String SERIALIZED_NAME_AARD = "aard";
  @SerializedName(SERIALIZED_NAME_AARD)
  private Waardelijst aard;

  public static final String SERIALIZED_NAME_AANTEKENINGEN = "aantekeningen";
  @SerializedName(SERIALIZED_NAME_AANTEKENINGEN)
  private List<AantekeningBasis> aantekeningen = null;

  public static final String SERIALIZED_NAME_BESLAGLEGGERS = "beslagleggers";
  @SerializedName(SERIALIZED_NAME_BESLAGLEGGERS)
  private List<PersoonBeperkt> beslagleggers = null;

  public static final String SERIALIZED_NAME_BEDRAG_VORDERING = "bedragVordering";
  @SerializedName(SERIALIZED_NAME_BEDRAG_VORDERING)
  private Bedrag bedragVordering;

  public static final String SERIALIZED_NAME_STUK_IDENTIFICATIES = "stukIdentificaties";
  @SerializedName(SERIALIZED_NAME_STUK_IDENTIFICATIES)
  private List<String> stukIdentificaties = null;

  public static final String SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIE = "isGebaseerdOpStukdeelIdentificatie";
  @SerializedName(SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIE)
  private String isGebaseerdOpStukdeelIdentificatie;

  public static final String SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES = "isVermeldInStukdeelIdentificaties";
  @SerializedName(SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES)
  private List<String> isVermeldInStukdeelIdentificaties = null;


  public Beslag identificatie(String identificatie) {
    
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


  public Beslag domein(String domein) {
    
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


  public Beslag aandeelInBetrokkenRecht(TypeBreuk aandeelInBetrokkenRecht) {
    
    this.aandeelInBetrokkenRecht = aandeelInBetrokkenRecht;
    return this;
  }

   /**
   * Get aandeelInBetrokkenRecht
   * @return aandeelInBetrokkenRecht
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypeBreuk getAandeelInBetrokkenRecht() {
    return aandeelInBetrokkenRecht;
  }


  public void setAandeelInBetrokkenRecht(TypeBreuk aandeelInBetrokkenRecht) {
    this.aandeelInBetrokkenRecht = aandeelInBetrokkenRecht;
  }


  public Beslag gedeeltelijkeBezwaringOudObject(Boolean gedeeltelijkeBezwaringOudObject) {
    
    this.gedeeltelijkeBezwaringOudObject = gedeeltelijkeBezwaringOudObject;
    return this;
  }

   /**
   * Indicatie of het object waarop beslag is gelegd gedeeltelijk uit een inmiddels vervallen object bestaat. 
   * @return gedeeltelijkeBezwaringOudObject
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Indicatie of het object waarop beslag is gelegd gedeeltelijk uit een inmiddels vervallen object bestaat. ")

  public Boolean getGedeeltelijkeBezwaringOudObject() {
    return gedeeltelijkeBezwaringOudObject;
  }


  public void setGedeeltelijkeBezwaringOudObject(Boolean gedeeltelijkeBezwaringOudObject) {
    this.gedeeltelijkeBezwaringOudObject = gedeeltelijkeBezwaringOudObject;
  }


  public Beslag omschrijvingBetrokkenRecht(Waardelijst omschrijvingBetrokkenRecht) {
    
    this.omschrijvingBetrokkenRecht = omschrijvingBetrokkenRecht;
    return this;
  }

   /**
   * Get omschrijvingBetrokkenRecht
   * @return omschrijvingBetrokkenRecht
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getOmschrijvingBetrokkenRecht() {
    return omschrijvingBetrokkenRecht;
  }


  public void setOmschrijvingBetrokkenRecht(Waardelijst omschrijvingBetrokkenRecht) {
    this.omschrijvingBetrokkenRecht = omschrijvingBetrokkenRecht;
  }


  public Beslag toelichtingBewaarder(String toelichtingBewaarder) {
    
    this.toelichtingBewaarder = toelichtingBewaarder;
    return this;
  }

   /**
   * Toelichtende tekst van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. 
   * @return toelichtingBewaarder
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Toelichtende tekst van de bewaarder. De bewaarder is iemand die bij het Kadaster werkt. Hij schrijft stukken in in de openbare registers en de basisregistratie Kadaster conform de Kadasterwet. ")

  public String getToelichtingBewaarder() {
    return toelichtingBewaarder;
  }


  public void setToelichtingBewaarder(String toelichtingBewaarder) {
    this.toelichtingBewaarder = toelichtingBewaarder;
  }


  public Beslag aard(Waardelijst aard) {
    
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


  public Beslag aantekeningen(List<AantekeningBasis> aantekeningen) {
    
    this.aantekeningen = aantekeningen;
    return this;
  }

  public Beslag addAantekeningenItem(AantekeningBasis aantekeningenItem) {
    if (this.aantekeningen == null) {
      this.aantekeningen = new ArrayList<>();
    }
    this.aantekeningen.add(aantekeningenItem);
    return this;
  }

   /**
   * Get aantekeningen
   * @return aantekeningen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<AantekeningBasis> getAantekeningen() {
    return aantekeningen;
  }


  public void setAantekeningen(List<AantekeningBasis> aantekeningen) {
    this.aantekeningen = aantekeningen;
  }


  public Beslag beslagleggers(List<PersoonBeperkt> beslagleggers) {
    
    this.beslagleggers = beslagleggers;
    return this;
  }

  public Beslag addBeslagleggersItem(PersoonBeperkt beslagleggersItem) {
    if (this.beslagleggers == null) {
      this.beslagleggers = new ArrayList<>();
    }
    this.beslagleggers.add(beslagleggersItem);
    return this;
  }

   /**
   * Get beslagleggers
   * @return beslagleggers
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<PersoonBeperkt> getBeslagleggers() {
    return beslagleggers;
  }


  public void setBeslagleggers(List<PersoonBeperkt> beslagleggers) {
    this.beslagleggers = beslagleggers;
  }


  public Beslag bedragVordering(Bedrag bedragVordering) {
    
    this.bedragVordering = bedragVordering;
    return this;
  }

   /**
   * Get bedragVordering
   * @return bedragVordering
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Bedrag getBedragVordering() {
    return bedragVordering;
  }


  public void setBedragVordering(Bedrag bedragVordering) {
    this.bedragVordering = bedragVordering;
  }


  public Beslag stukIdentificaties(List<String> stukIdentificaties) {
    
    this.stukIdentificaties = stukIdentificaties;
    return this;
  }

  public Beslag addStukIdentificatiesItem(String stukIdentificatiesItem) {
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


  public Beslag isGebaseerdOpStukdeelIdentificatie(String isGebaseerdOpStukdeelIdentificatie) {
    
    this.isGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
    return this;
  }

   /**
   * De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop dit beslag is gebaseerd. 
   * @return isGebaseerdOpStukdeelIdentificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De identificatie van het stukdeel (paragraaf in een akte met een rechtsfeit) waarop dit beslag is gebaseerd. ")

  public String getIsGebaseerdOpStukdeelIdentificatie() {
    return isGebaseerdOpStukdeelIdentificatie;
  }


  public void setIsGebaseerdOpStukdeelIdentificatie(String isGebaseerdOpStukdeelIdentificatie) {
    this.isGebaseerdOpStukdeelIdentificatie = isGebaseerdOpStukdeelIdentificatie;
  }


  public Beslag isVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
    return this;
  }

  public Beslag addIsVermeldInStukdeelIdentificatiesItem(String isVermeldInStukdeelIdentificatiesItem) {
    if (this.isVermeldInStukdeelIdentificaties == null) {
      this.isVermeldInStukdeelIdentificaties = new ArrayList<>();
    }
    this.isVermeldInStukdeelIdentificaties.add(isVermeldInStukdeelIdentificatiesItem);
    return this;
  }

   /**
   * De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin dit beslag is vermeld 
   * @return isVermeldInStukdeelIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "De identificaties van de stukdelen (paragrafen in een akte met een rechtsfeit) waarin dit beslag is vermeld ")

  public List<String> getIsVermeldInStukdeelIdentificaties() {
    return isVermeldInStukdeelIdentificaties;
  }


  public void setIsVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Beslag beslag = (Beslag) o;
    return Objects.equals(this.identificatie, beslag.identificatie) &&
        Objects.equals(this.domein, beslag.domein) &&
        Objects.equals(this.aandeelInBetrokkenRecht, beslag.aandeelInBetrokkenRecht) &&
        Objects.equals(this.gedeeltelijkeBezwaringOudObject, beslag.gedeeltelijkeBezwaringOudObject) &&
        Objects.equals(this.omschrijvingBetrokkenRecht, beslag.omschrijvingBetrokkenRecht) &&
        Objects.equals(this.toelichtingBewaarder, beslag.toelichtingBewaarder) &&
        Objects.equals(this.aard, beslag.aard) &&
        Objects.equals(this.aantekeningen, beslag.aantekeningen) &&
        Objects.equals(this.beslagleggers, beslag.beslagleggers) &&
        Objects.equals(this.bedragVordering, beslag.bedragVordering) &&
        Objects.equals(this.stukIdentificaties, beslag.stukIdentificaties) &&
        Objects.equals(this.isGebaseerdOpStukdeelIdentificatie, beslag.isGebaseerdOpStukdeelIdentificatie) &&
        Objects.equals(this.isVermeldInStukdeelIdentificaties, beslag.isVermeldInStukdeelIdentificaties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, domein, aandeelInBetrokkenRecht, gedeeltelijkeBezwaringOudObject, omschrijvingBetrokkenRecht, toelichtingBewaarder, aard, aantekeningen, beslagleggers, bedragVordering, stukIdentificaties, isGebaseerdOpStukdeelIdentificatie, isVermeldInStukdeelIdentificaties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Beslag {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    aandeelInBetrokkenRecht: ").append(toIndentedString(aandeelInBetrokkenRecht)).append("\n");
    sb.append("    gedeeltelijkeBezwaringOudObject: ").append(toIndentedString(gedeeltelijkeBezwaringOudObject)).append("\n");
    sb.append("    omschrijvingBetrokkenRecht: ").append(toIndentedString(omschrijvingBetrokkenRecht)).append("\n");
    sb.append("    toelichtingBewaarder: ").append(toIndentedString(toelichtingBewaarder)).append("\n");
    sb.append("    aard: ").append(toIndentedString(aard)).append("\n");
    sb.append("    aantekeningen: ").append(toIndentedString(aantekeningen)).append("\n");
    sb.append("    beslagleggers: ").append(toIndentedString(beslagleggers)).append("\n");
    sb.append("    bedragVordering: ").append(toIndentedString(bedragVordering)).append("\n");
    sb.append("    stukIdentificaties: ").append(toIndentedString(stukIdentificaties)).append("\n");
    sb.append("    isGebaseerdOpStukdeelIdentificatie: ").append(toIndentedString(isGebaseerdOpStukdeelIdentificatie)).append("\n");
    sb.append("    isVermeldInStukdeelIdentificaties: ").append(toIndentedString(isVermeldInStukdeelIdentificaties)).append("\n");
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

