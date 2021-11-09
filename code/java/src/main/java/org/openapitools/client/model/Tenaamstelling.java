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
import org.openapitools.client.model.AantekeningTenaamstelling;
import org.openapitools.client.model.NatuurlijkPersoonBeperkt;
import org.openapitools.client.model.NietNatuurlijkPersoonBeperkt;
import org.openapitools.client.model.TypeBreuk;
import org.openapitools.client.model.Waardelijst;

/**
 * Een registratie van (een aandeel in) een zakelijk recht dat een persoon heeft, dat rust op een kadastraal onroerende zaak.   Waardelijst in deze component :   [burgerlijkeStaatTenTijdeVanVerkrijging](http://www.kadaster.nl/schemas/waardelijsten/BurgerlijkeStaat/) en [verkregenNamensSamenwerkingsverband](http://www.kadaster.nl/schemas/waardelijsten/Samenwerkingsverband/) 
 */
@ApiModel(description = "Een registratie van (een aandeel in) een zakelijk recht dat een persoon heeft, dat rust op een kadastraal onroerende zaak.   Waardelijst in deze component :   [burgerlijkeStaatTenTijdeVanVerkrijging](http://www.kadaster.nl/schemas/waardelijsten/BurgerlijkeStaat/) en [verkregenNamensSamenwerkingsverband](http://www.kadaster.nl/schemas/waardelijsten/Samenwerkingsverband/) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-09T17:37:32.228183Z[Etc/UTC]")
public class Tenaamstelling {
  public static final String SERIALIZED_NAME_AANDEEL = "aandeel";
  @SerializedName(SERIALIZED_NAME_AANDEEL)
  private TypeBreuk aandeel;

  public static final String SERIALIZED_NAME_BURGERLIJKE_STAAT_TEN_TIJDE_VAN_VERKRIJGING = "burgerlijkeStaatTenTijdeVanVerkrijging";
  @SerializedName(SERIALIZED_NAME_BURGERLIJKE_STAAT_TEN_TIJDE_VAN_VERKRIJGING)
  private Waardelijst burgerlijkeStaatTenTijdeVanVerkrijging;

  public static final String SERIALIZED_NAME_VERKREGEN_NAMENS_SAMENWERKINGSVERBAND = "verkregenNamensSamenwerkingsverband";
  @SerializedName(SERIALIZED_NAME_VERKREGEN_NAMENS_SAMENWERKINGSVERBAND)
  private Waardelijst verkregenNamensSamenwerkingsverband;

  public static final String SERIALIZED_NAME_AANTEKENINGEN = "aantekeningen";
  @SerializedName(SERIALIZED_NAME_AANTEKENINGEN)
  private List<AantekeningTenaamstelling> aantekeningen = null;

  public static final String SERIALIZED_NAME_GEZAMENLIJK_AANDEEL = "gezamenlijkAandeel";
  @SerializedName(SERIALIZED_NAME_GEZAMENLIJK_AANDEEL)
  private TypeBreuk gezamenlijkAandeel;

  public static final String SERIALIZED_NAME_BETROKKEN_PARTNER = "betrokkenPartner";
  @SerializedName(SERIALIZED_NAME_BETROKKEN_PARTNER)
  private NatuurlijkPersoonBeperkt betrokkenPartner;

  public static final String SERIALIZED_NAME_BETROKKEN_SAMENWERKINGSVERBAND = "betrokkenSamenwerkingsverband";
  @SerializedName(SERIALIZED_NAME_BETROKKEN_SAMENWERKINGSVERBAND)
  private NietNatuurlijkPersoonBeperkt betrokkenSamenwerkingsverband;

  public static final String SERIALIZED_NAME_BETROKKEN_GORZEN_EN_AANWASSEN = "betrokkenGorzenEnAanwassen";
  @SerializedName(SERIALIZED_NAME_BETROKKEN_GORZEN_EN_AANWASSEN)
  private NietNatuurlijkPersoonBeperkt betrokkenGorzenEnAanwassen;

  public static final String SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIES = "isGebaseerdOpStukdeelIdentificaties";
  @SerializedName(SERIALIZED_NAME_IS_GEBASEERD_OP_STUKDEEL_IDENTIFICATIES)
  private List<String> isGebaseerdOpStukdeelIdentificaties = null;

  public static final String SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES = "isVermeldInStukdeelIdentificaties";
  @SerializedName(SERIALIZED_NAME_IS_VERMELD_IN_STUKDEEL_IDENTIFICATIES)
  private List<String> isVermeldInStukdeelIdentificaties = null;

  public static final String SERIALIZED_NAME_STUK_IDENTIFICATIES = "stukIdentificaties";
  @SerializedName(SERIALIZED_NAME_STUK_IDENTIFICATIES)
  private List<String> stukIdentificaties = null;


  public Tenaamstelling aandeel(TypeBreuk aandeel) {
    
    this.aandeel = aandeel;
    return this;
  }

   /**
   * Get aandeel
   * @return aandeel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypeBreuk getAandeel() {
    return aandeel;
  }


  public void setAandeel(TypeBreuk aandeel) {
    this.aandeel = aandeel;
  }


  public Tenaamstelling burgerlijkeStaatTenTijdeVanVerkrijging(Waardelijst burgerlijkeStaatTenTijdeVanVerkrijging) {
    
    this.burgerlijkeStaatTenTijdeVanVerkrijging = burgerlijkeStaatTenTijdeVanVerkrijging;
    return this;
  }

   /**
   * Get burgerlijkeStaatTenTijdeVanVerkrijging
   * @return burgerlijkeStaatTenTijdeVanVerkrijging
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getBurgerlijkeStaatTenTijdeVanVerkrijging() {
    return burgerlijkeStaatTenTijdeVanVerkrijging;
  }


  public void setBurgerlijkeStaatTenTijdeVanVerkrijging(Waardelijst burgerlijkeStaatTenTijdeVanVerkrijging) {
    this.burgerlijkeStaatTenTijdeVanVerkrijging = burgerlijkeStaatTenTijdeVanVerkrijging;
  }


  public Tenaamstelling verkregenNamensSamenwerkingsverband(Waardelijst verkregenNamensSamenwerkingsverband) {
    
    this.verkregenNamensSamenwerkingsverband = verkregenNamensSamenwerkingsverband;
    return this;
  }

   /**
   * Get verkregenNamensSamenwerkingsverband
   * @return verkregenNamensSamenwerkingsverband
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getVerkregenNamensSamenwerkingsverband() {
    return verkregenNamensSamenwerkingsverband;
  }


  public void setVerkregenNamensSamenwerkingsverband(Waardelijst verkregenNamensSamenwerkingsverband) {
    this.verkregenNamensSamenwerkingsverband = verkregenNamensSamenwerkingsverband;
  }


  public Tenaamstelling aantekeningen(List<AantekeningTenaamstelling> aantekeningen) {
    
    this.aantekeningen = aantekeningen;
    return this;
  }

  public Tenaamstelling addAantekeningenItem(AantekeningTenaamstelling aantekeningenItem) {
    if (this.aantekeningen == null) {
      this.aantekeningen = new ArrayList<>();
    }
    this.aantekeningen.add(aantekeningenItem);
    return this;
  }

   /**
   * Een aantekening is een verwijzing naar een ter inschrijving aangeboden stuk. Een aantekening op een tenaamstelling van een zakelijk recht is meestal een beperking. Bijvoorbeeld de verkrijging van een aandeel in een zakelijk recht onder opschortende voorwaarde, een beperking van de handelingsbevoegdheid van de zakelijk gerechtigde, of een koopovereenkomst 
   * @return aantekeningen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Een aantekening is een verwijzing naar een ter inschrijving aangeboden stuk. Een aantekening op een tenaamstelling van een zakelijk recht is meestal een beperking. Bijvoorbeeld de verkrijging van een aandeel in een zakelijk recht onder opschortende voorwaarde, een beperking van de handelingsbevoegdheid van de zakelijk gerechtigde, of een koopovereenkomst ")

  public List<AantekeningTenaamstelling> getAantekeningen() {
    return aantekeningen;
  }


  public void setAantekeningen(List<AantekeningTenaamstelling> aantekeningen) {
    this.aantekeningen = aantekeningen;
  }


  public Tenaamstelling gezamenlijkAandeel(TypeBreuk gezamenlijkAandeel) {
    
    this.gezamenlijkAandeel = gezamenlijkAandeel;
    return this;
  }

   /**
   * Get gezamenlijkAandeel
   * @return gezamenlijkAandeel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypeBreuk getGezamenlijkAandeel() {
    return gezamenlijkAandeel;
  }


  public void setGezamenlijkAandeel(TypeBreuk gezamenlijkAandeel) {
    this.gezamenlijkAandeel = gezamenlijkAandeel;
  }


  public Tenaamstelling betrokkenPartner(NatuurlijkPersoonBeperkt betrokkenPartner) {
    
    this.betrokkenPartner = betrokkenPartner;
    return this;
  }

   /**
   * Get betrokkenPartner
   * @return betrokkenPartner
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public NatuurlijkPersoonBeperkt getBetrokkenPartner() {
    return betrokkenPartner;
  }


  public void setBetrokkenPartner(NatuurlijkPersoonBeperkt betrokkenPartner) {
    this.betrokkenPartner = betrokkenPartner;
  }


  public Tenaamstelling betrokkenSamenwerkingsverband(NietNatuurlijkPersoonBeperkt betrokkenSamenwerkingsverband) {
    
    this.betrokkenSamenwerkingsverband = betrokkenSamenwerkingsverband;
    return this;
  }

   /**
   * Get betrokkenSamenwerkingsverband
   * @return betrokkenSamenwerkingsverband
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public NietNatuurlijkPersoonBeperkt getBetrokkenSamenwerkingsverband() {
    return betrokkenSamenwerkingsverband;
  }


  public void setBetrokkenSamenwerkingsverband(NietNatuurlijkPersoonBeperkt betrokkenSamenwerkingsverband) {
    this.betrokkenSamenwerkingsverband = betrokkenSamenwerkingsverband;
  }


  public Tenaamstelling betrokkenGorzenEnAanwassen(NietNatuurlijkPersoonBeperkt betrokkenGorzenEnAanwassen) {
    
    this.betrokkenGorzenEnAanwassen = betrokkenGorzenEnAanwassen;
    return this;
  }

   /**
   * Get betrokkenGorzenEnAanwassen
   * @return betrokkenGorzenEnAanwassen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public NietNatuurlijkPersoonBeperkt getBetrokkenGorzenEnAanwassen() {
    return betrokkenGorzenEnAanwassen;
  }


  public void setBetrokkenGorzenEnAanwassen(NietNatuurlijkPersoonBeperkt betrokkenGorzenEnAanwassen) {
    this.betrokkenGorzenEnAanwassen = betrokkenGorzenEnAanwassen;
  }


  public Tenaamstelling isGebaseerdOpStukdeelIdentificaties(List<String> isGebaseerdOpStukdeelIdentificaties) {
    
    this.isGebaseerdOpStukdeelIdentificaties = isGebaseerdOpStukdeelIdentificaties;
    return this;
  }

  public Tenaamstelling addIsGebaseerdOpStukdeelIdentificatiesItem(String isGebaseerdOpStukdeelIdentificatiesItem) {
    if (this.isGebaseerdOpStukdeelIdentificaties == null) {
      this.isGebaseerdOpStukdeelIdentificaties = new ArrayList<>();
    }
    this.isGebaseerdOpStukdeelIdentificaties.add(isGebaseerdOpStukdeelIdentificatiesItem);
    return this;
  }

   /**
   * Get isGebaseerdOpStukdeelIdentificaties
   * @return isGebaseerdOpStukdeelIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getIsGebaseerdOpStukdeelIdentificaties() {
    return isGebaseerdOpStukdeelIdentificaties;
  }


  public void setIsGebaseerdOpStukdeelIdentificaties(List<String> isGebaseerdOpStukdeelIdentificaties) {
    this.isGebaseerdOpStukdeelIdentificaties = isGebaseerdOpStukdeelIdentificaties;
  }


  public Tenaamstelling isVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
    return this;
  }

  public Tenaamstelling addIsVermeldInStukdeelIdentificatiesItem(String isVermeldInStukdeelIdentificatiesItem) {
    if (this.isVermeldInStukdeelIdentificaties == null) {
      this.isVermeldInStukdeelIdentificaties = new ArrayList<>();
    }
    this.isVermeldInStukdeelIdentificaties.add(isVermeldInStukdeelIdentificatiesItem);
    return this;
  }

   /**
   * Get isVermeldInStukdeelIdentificaties
   * @return isVermeldInStukdeelIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getIsVermeldInStukdeelIdentificaties() {
    return isVermeldInStukdeelIdentificaties;
  }


  public void setIsVermeldInStukdeelIdentificaties(List<String> isVermeldInStukdeelIdentificaties) {
    this.isVermeldInStukdeelIdentificaties = isVermeldInStukdeelIdentificaties;
  }


  public Tenaamstelling stukIdentificaties(List<String> stukIdentificaties) {
    
    this.stukIdentificaties = stukIdentificaties;
    return this;
  }

  public Tenaamstelling addStukIdentificatiesItem(String stukIdentificatiesItem) {
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


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Tenaamstelling tenaamstelling = (Tenaamstelling) o;
    return Objects.equals(this.aandeel, tenaamstelling.aandeel) &&
        Objects.equals(this.burgerlijkeStaatTenTijdeVanVerkrijging, tenaamstelling.burgerlijkeStaatTenTijdeVanVerkrijging) &&
        Objects.equals(this.verkregenNamensSamenwerkingsverband, tenaamstelling.verkregenNamensSamenwerkingsverband) &&
        Objects.equals(this.aantekeningen, tenaamstelling.aantekeningen) &&
        Objects.equals(this.gezamenlijkAandeel, tenaamstelling.gezamenlijkAandeel) &&
        Objects.equals(this.betrokkenPartner, tenaamstelling.betrokkenPartner) &&
        Objects.equals(this.betrokkenSamenwerkingsverband, tenaamstelling.betrokkenSamenwerkingsverband) &&
        Objects.equals(this.betrokkenGorzenEnAanwassen, tenaamstelling.betrokkenGorzenEnAanwassen) &&
        Objects.equals(this.isGebaseerdOpStukdeelIdentificaties, tenaamstelling.isGebaseerdOpStukdeelIdentificaties) &&
        Objects.equals(this.isVermeldInStukdeelIdentificaties, tenaamstelling.isVermeldInStukdeelIdentificaties) &&
        Objects.equals(this.stukIdentificaties, tenaamstelling.stukIdentificaties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(aandeel, burgerlijkeStaatTenTijdeVanVerkrijging, verkregenNamensSamenwerkingsverband, aantekeningen, gezamenlijkAandeel, betrokkenPartner, betrokkenSamenwerkingsverband, betrokkenGorzenEnAanwassen, isGebaseerdOpStukdeelIdentificaties, isVermeldInStukdeelIdentificaties, stukIdentificaties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Tenaamstelling {\n");
    sb.append("    aandeel: ").append(toIndentedString(aandeel)).append("\n");
    sb.append("    burgerlijkeStaatTenTijdeVanVerkrijging: ").append(toIndentedString(burgerlijkeStaatTenTijdeVanVerkrijging)).append("\n");
    sb.append("    verkregenNamensSamenwerkingsverband: ").append(toIndentedString(verkregenNamensSamenwerkingsverband)).append("\n");
    sb.append("    aantekeningen: ").append(toIndentedString(aantekeningen)).append("\n");
    sb.append("    gezamenlijkAandeel: ").append(toIndentedString(gezamenlijkAandeel)).append("\n");
    sb.append("    betrokkenPartner: ").append(toIndentedString(betrokkenPartner)).append("\n");
    sb.append("    betrokkenSamenwerkingsverband: ").append(toIndentedString(betrokkenSamenwerkingsverband)).append("\n");
    sb.append("    betrokkenGorzenEnAanwassen: ").append(toIndentedString(betrokkenGorzenEnAanwassen)).append("\n");
    sb.append("    isGebaseerdOpStukdeelIdentificaties: ").append(toIndentedString(isGebaseerdOpStukdeelIdentificaties)).append("\n");
    sb.append("    isVermeldInStukdeelIdentificaties: ").append(toIndentedString(isVermeldInStukdeelIdentificaties)).append("\n");
    sb.append("    stukIdentificaties: ").append(toIndentedString(stukIdentificaties)).append("\n");
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

