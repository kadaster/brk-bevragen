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
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.HalLink;

/**
 * KadastraalOnroerendeZaakLinks
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-14T09:58:19.624161Z[Etc/UTC]")
public class KadastraalOnroerendeZaakLinks {
  public static final String SERIALIZED_NAME_SELF = "self";
  @SerializedName(SERIALIZED_NAME_SELF)
  private HalLink self;

  public static final String SERIALIZED_NAME_ZAKELIJK_GERECHTIGDEN = "zakelijkGerechtigden";
  @SerializedName(SERIALIZED_NAME_ZAKELIJK_GERECHTIGDEN)
  private List<HalLink> zakelijkGerechtigden = null;

  public static final String SERIALIZED_NAME_PRIVAATRECHTELIJKE_BEPERKINGEN = "privaatrechtelijkeBeperkingen";
  @SerializedName(SERIALIZED_NAME_PRIVAATRECHTELIJKE_BEPERKINGEN)
  private List<HalLink> privaatrechtelijkeBeperkingen = null;

  public static final String SERIALIZED_NAME_HYPOTHEKEN = "hypotheken";
  @SerializedName(SERIALIZED_NAME_HYPOTHEKEN)
  private List<HalLink> hypotheken = null;

  public static final String SERIALIZED_NAME_IS_ONTSTAAN_UIT = "isOntstaanUit";
  @SerializedName(SERIALIZED_NAME_IS_ONTSTAAN_UIT)
  private List<HalLink> isOntstaanUit = null;

  public static final String SERIALIZED_NAME_IS_OVERGEGAAN_IN = "isOvergegaanIn";
  @SerializedName(SERIALIZED_NAME_IS_OVERGEGAAN_IN)
  private List<HalLink> isOvergegaanIn = null;

  public static final String SERIALIZED_NAME_BESLAGEN = "beslagen";
  @SerializedName(SERIALIZED_NAME_BESLAGEN)
  private List<HalLink> beslagen = null;

  public static final String SERIALIZED_NAME_STUKKEN = "stukken";
  @SerializedName(SERIALIZED_NAME_STUKKEN)
  private List<HalLink> stukken = null;

  public static final String SERIALIZED_NAME_STUKDELEN = "stukdelen";
  @SerializedName(SERIALIZED_NAME_STUKDELEN)
  private List<HalLink> stukdelen = null;

  public static final String SERIALIZED_NAME_ADRESSEN = "adressen";
  @SerializedName(SERIALIZED_NAME_ADRESSEN)
  private List<HalLink> adressen = null;

  public static final String SERIALIZED_NAME_ADRESSEERBARE_OBJECTEN = "adresseerbareObjecten";
  @SerializedName(SERIALIZED_NAME_ADRESSEERBARE_OBJECTEN)
  private List<HalLink> adresseerbareObjecten = null;


  public KadastraalOnroerendeZaakLinks self(HalLink self) {
    
    this.self = self;
    return this;
  }

   /**
   * Get self
   * @return self
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getSelf() {
    return self;
  }


  public void setSelf(HalLink self) {
    this.self = self;
  }


  public KadastraalOnroerendeZaakLinks zakelijkGerechtigden(List<HalLink> zakelijkGerechtigden) {
    
    this.zakelijkGerechtigden = zakelijkGerechtigden;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addZakelijkGerechtigdenItem(HalLink zakelijkGerechtigdenItem) {
    if (this.zakelijkGerechtigden == null) {
      this.zakelijkGerechtigden = new ArrayList<>();
    }
    this.zakelijkGerechtigden.add(zakelijkGerechtigdenItem);
    return this;
  }

   /**
   * Get zakelijkGerechtigden
   * @return zakelijkGerechtigden
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getZakelijkGerechtigden() {
    return zakelijkGerechtigden;
  }


  public void setZakelijkGerechtigden(List<HalLink> zakelijkGerechtigden) {
    this.zakelijkGerechtigden = zakelijkGerechtigden;
  }


  public KadastraalOnroerendeZaakLinks privaatrechtelijkeBeperkingen(List<HalLink> privaatrechtelijkeBeperkingen) {
    
    this.privaatrechtelijkeBeperkingen = privaatrechtelijkeBeperkingen;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addPrivaatrechtelijkeBeperkingenItem(HalLink privaatrechtelijkeBeperkingenItem) {
    if (this.privaatrechtelijkeBeperkingen == null) {
      this.privaatrechtelijkeBeperkingen = new ArrayList<>();
    }
    this.privaatrechtelijkeBeperkingen.add(privaatrechtelijkeBeperkingenItem);
    return this;
  }

   /**
   * Get privaatrechtelijkeBeperkingen
   * @return privaatrechtelijkeBeperkingen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getPrivaatrechtelijkeBeperkingen() {
    return privaatrechtelijkeBeperkingen;
  }


  public void setPrivaatrechtelijkeBeperkingen(List<HalLink> privaatrechtelijkeBeperkingen) {
    this.privaatrechtelijkeBeperkingen = privaatrechtelijkeBeperkingen;
  }


  public KadastraalOnroerendeZaakLinks hypotheken(List<HalLink> hypotheken) {
    
    this.hypotheken = hypotheken;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addHypothekenItem(HalLink hypothekenItem) {
    if (this.hypotheken == null) {
      this.hypotheken = new ArrayList<>();
    }
    this.hypotheken.add(hypothekenItem);
    return this;
  }

   /**
   * Get hypotheken
   * @return hypotheken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getHypotheken() {
    return hypotheken;
  }


  public void setHypotheken(List<HalLink> hypotheken) {
    this.hypotheken = hypotheken;
  }


  public KadastraalOnroerendeZaakLinks isOntstaanUit(List<HalLink> isOntstaanUit) {
    
    this.isOntstaanUit = isOntstaanUit;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addIsOntstaanUitItem(HalLink isOntstaanUitItem) {
    if (this.isOntstaanUit == null) {
      this.isOntstaanUit = new ArrayList<>();
    }
    this.isOntstaanUit.add(isOntstaanUitItem);
    return this;
  }

   /**
   * Get isOntstaanUit
   * @return isOntstaanUit
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getIsOntstaanUit() {
    return isOntstaanUit;
  }


  public void setIsOntstaanUit(List<HalLink> isOntstaanUit) {
    this.isOntstaanUit = isOntstaanUit;
  }


  public KadastraalOnroerendeZaakLinks isOvergegaanIn(List<HalLink> isOvergegaanIn) {
    
    this.isOvergegaanIn = isOvergegaanIn;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addIsOvergegaanInItem(HalLink isOvergegaanInItem) {
    if (this.isOvergegaanIn == null) {
      this.isOvergegaanIn = new ArrayList<>();
    }
    this.isOvergegaanIn.add(isOvergegaanInItem);
    return this;
  }

   /**
   * Get isOvergegaanIn
   * @return isOvergegaanIn
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getIsOvergegaanIn() {
    return isOvergegaanIn;
  }


  public void setIsOvergegaanIn(List<HalLink> isOvergegaanIn) {
    this.isOvergegaanIn = isOvergegaanIn;
  }


  public KadastraalOnroerendeZaakLinks beslagen(List<HalLink> beslagen) {
    
    this.beslagen = beslagen;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addBeslagenItem(HalLink beslagenItem) {
    if (this.beslagen == null) {
      this.beslagen = new ArrayList<>();
    }
    this.beslagen.add(beslagenItem);
    return this;
  }

   /**
   * Get beslagen
   * @return beslagen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getBeslagen() {
    return beslagen;
  }


  public void setBeslagen(List<HalLink> beslagen) {
    this.beslagen = beslagen;
  }


  public KadastraalOnroerendeZaakLinks stukken(List<HalLink> stukken) {
    
    this.stukken = stukken;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addStukkenItem(HalLink stukkenItem) {
    if (this.stukken == null) {
      this.stukken = new ArrayList<>();
    }
    this.stukken.add(stukkenItem);
    return this;
  }

   /**
   * Get stukken
   * @return stukken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getStukken() {
    return stukken;
  }


  public void setStukken(List<HalLink> stukken) {
    this.stukken = stukken;
  }


  public KadastraalOnroerendeZaakLinks stukdelen(List<HalLink> stukdelen) {
    
    this.stukdelen = stukdelen;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addStukdelenItem(HalLink stukdelenItem) {
    if (this.stukdelen == null) {
      this.stukdelen = new ArrayList<>();
    }
    this.stukdelen.add(stukdelenItem);
    return this;
  }

   /**
   * Get stukdelen
   * @return stukdelen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getStukdelen() {
    return stukdelen;
  }


  public void setStukdelen(List<HalLink> stukdelen) {
    this.stukdelen = stukdelen;
  }


  public KadastraalOnroerendeZaakLinks adressen(List<HalLink> adressen) {
    
    this.adressen = adressen;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addAdressenItem(HalLink adressenItem) {
    if (this.adressen == null) {
      this.adressen = new ArrayList<>();
    }
    this.adressen.add(adressenItem);
    return this;
  }

   /**
   * Get adressen
   * @return adressen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getAdressen() {
    return adressen;
  }


  public void setAdressen(List<HalLink> adressen) {
    this.adressen = adressen;
  }


  public KadastraalOnroerendeZaakLinks adresseerbareObjecten(List<HalLink> adresseerbareObjecten) {
    
    this.adresseerbareObjecten = adresseerbareObjecten;
    return this;
  }

  public KadastraalOnroerendeZaakLinks addAdresseerbareObjectenItem(HalLink adresseerbareObjectenItem) {
    if (this.adresseerbareObjecten == null) {
      this.adresseerbareObjecten = new ArrayList<>();
    }
    this.adresseerbareObjecten.add(adresseerbareObjectenItem);
    return this;
  }

   /**
   * Get adresseerbareObjecten
   * @return adresseerbareObjecten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getAdresseerbareObjecten() {
    return adresseerbareObjecten;
  }


  public void setAdresseerbareObjecten(List<HalLink> adresseerbareObjecten) {
    this.adresseerbareObjecten = adresseerbareObjecten;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    KadastraalOnroerendeZaakLinks kadastraalOnroerendeZaakLinks = (KadastraalOnroerendeZaakLinks) o;
    return Objects.equals(this.self, kadastraalOnroerendeZaakLinks.self) &&
        Objects.equals(this.zakelijkGerechtigden, kadastraalOnroerendeZaakLinks.zakelijkGerechtigden) &&
        Objects.equals(this.privaatrechtelijkeBeperkingen, kadastraalOnroerendeZaakLinks.privaatrechtelijkeBeperkingen) &&
        Objects.equals(this.hypotheken, kadastraalOnroerendeZaakLinks.hypotheken) &&
        Objects.equals(this.isOntstaanUit, kadastraalOnroerendeZaakLinks.isOntstaanUit) &&
        Objects.equals(this.isOvergegaanIn, kadastraalOnroerendeZaakLinks.isOvergegaanIn) &&
        Objects.equals(this.beslagen, kadastraalOnroerendeZaakLinks.beslagen) &&
        Objects.equals(this.stukken, kadastraalOnroerendeZaakLinks.stukken) &&
        Objects.equals(this.stukdelen, kadastraalOnroerendeZaakLinks.stukdelen) &&
        Objects.equals(this.adressen, kadastraalOnroerendeZaakLinks.adressen) &&
        Objects.equals(this.adresseerbareObjecten, kadastraalOnroerendeZaakLinks.adresseerbareObjecten);
  }

  @Override
  public int hashCode() {
    return Objects.hash(self, zakelijkGerechtigden, privaatrechtelijkeBeperkingen, hypotheken, isOntstaanUit, isOvergegaanIn, beslagen, stukken, stukdelen, adressen, adresseerbareObjecten);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KadastraalOnroerendeZaakLinks {\n");
    sb.append("    self: ").append(toIndentedString(self)).append("\n");
    sb.append("    zakelijkGerechtigden: ").append(toIndentedString(zakelijkGerechtigden)).append("\n");
    sb.append("    privaatrechtelijkeBeperkingen: ").append(toIndentedString(privaatrechtelijkeBeperkingen)).append("\n");
    sb.append("    hypotheken: ").append(toIndentedString(hypotheken)).append("\n");
    sb.append("    isOntstaanUit: ").append(toIndentedString(isOntstaanUit)).append("\n");
    sb.append("    isOvergegaanIn: ").append(toIndentedString(isOvergegaanIn)).append("\n");
    sb.append("    beslagen: ").append(toIndentedString(beslagen)).append("\n");
    sb.append("    stukken: ").append(toIndentedString(stukken)).append("\n");
    sb.append("    stukdelen: ").append(toIndentedString(stukdelen)).append("\n");
    sb.append("    adressen: ").append(toIndentedString(adressen)).append("\n");
    sb.append("    adresseerbareObjecten: ").append(toIndentedString(adresseerbareObjecten)).append("\n");
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

