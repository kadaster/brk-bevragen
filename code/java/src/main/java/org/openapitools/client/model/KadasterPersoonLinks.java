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
 * KadasterPersoonLinks
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-14T09:58:19.624161Z[Etc/UTC]")
public class KadasterPersoonLinks {
  public static final String SERIALIZED_NAME_SELF = "self";
  @SerializedName(SERIALIZED_NAME_SELF)
  private HalLink self;

  public static final String SERIALIZED_NAME_WOONADRES = "woonadres";
  @SerializedName(SERIALIZED_NAME_WOONADRES)
  private HalLink woonadres;

  public static final String SERIALIZED_NAME_POSTADRES = "postadres";
  @SerializedName(SERIALIZED_NAME_POSTADRES)
  private HalLink postadres;

  public static final String SERIALIZED_NAME_KADASTRAAL_ONROERENDE_ZAKEN = "kadastraalOnroerendeZaken";
  @SerializedName(SERIALIZED_NAME_KADASTRAAL_ONROERENDE_ZAKEN)
  private List<HalLink> kadastraalOnroerendeZaken = null;

  public static final String SERIALIZED_NAME_ZAKELIJK_GERECHTIGDEN = "zakelijkGerechtigden";
  @SerializedName(SERIALIZED_NAME_ZAKELIJK_GERECHTIGDEN)
  private List<HalLink> zakelijkGerechtigden = null;


  public KadasterPersoonLinks self(HalLink self) {
    
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


  public KadasterPersoonLinks woonadres(HalLink woonadres) {
    
    this.woonadres = woonadres;
    return this;
  }

   /**
   * Get woonadres
   * @return woonadres
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getWoonadres() {
    return woonadres;
  }


  public void setWoonadres(HalLink woonadres) {
    this.woonadres = woonadres;
  }


  public KadasterPersoonLinks postadres(HalLink postadres) {
    
    this.postadres = postadres;
    return this;
  }

   /**
   * Get postadres
   * @return postadres
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getPostadres() {
    return postadres;
  }


  public void setPostadres(HalLink postadres) {
    this.postadres = postadres;
  }


  public KadasterPersoonLinks kadastraalOnroerendeZaken(List<HalLink> kadastraalOnroerendeZaken) {
    
    this.kadastraalOnroerendeZaken = kadastraalOnroerendeZaken;
    return this;
  }

  public KadasterPersoonLinks addKadastraalOnroerendeZakenItem(HalLink kadastraalOnroerendeZakenItem) {
    if (this.kadastraalOnroerendeZaken == null) {
      this.kadastraalOnroerendeZaken = new ArrayList<>();
    }
    this.kadastraalOnroerendeZaken.add(kadastraalOnroerendeZakenItem);
    return this;
  }

   /**
   * Get kadastraalOnroerendeZaken
   * @return kadastraalOnroerendeZaken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<HalLink> getKadastraalOnroerendeZaken() {
    return kadastraalOnroerendeZaken;
  }


  public void setKadastraalOnroerendeZaken(List<HalLink> kadastraalOnroerendeZaken) {
    this.kadastraalOnroerendeZaken = kadastraalOnroerendeZaken;
  }


  public KadasterPersoonLinks zakelijkGerechtigden(List<HalLink> zakelijkGerechtigden) {
    
    this.zakelijkGerechtigden = zakelijkGerechtigden;
    return this;
  }

  public KadasterPersoonLinks addZakelijkGerechtigdenItem(HalLink zakelijkGerechtigdenItem) {
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


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    KadasterPersoonLinks kadasterPersoonLinks = (KadasterPersoonLinks) o;
    return Objects.equals(this.self, kadasterPersoonLinks.self) &&
        Objects.equals(this.woonadres, kadasterPersoonLinks.woonadres) &&
        Objects.equals(this.postadres, kadasterPersoonLinks.postadres) &&
        Objects.equals(this.kadastraalOnroerendeZaken, kadasterPersoonLinks.kadastraalOnroerendeZaken) &&
        Objects.equals(this.zakelijkGerechtigden, kadasterPersoonLinks.zakelijkGerechtigden);
  }

  @Override
  public int hashCode() {
    return Objects.hash(self, woonadres, postadres, kadastraalOnroerendeZaken, zakelijkGerechtigden);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KadasterPersoonLinks {\n");
    sb.append("    self: ").append(toIndentedString(self)).append("\n");
    sb.append("    woonadres: ").append(toIndentedString(woonadres)).append("\n");
    sb.append("    postadres: ").append(toIndentedString(postadres)).append("\n");
    sb.append("    kadastraalOnroerendeZaken: ").append(toIndentedString(kadastraalOnroerendeZaken)).append("\n");
    sb.append("    zakelijkGerechtigden: ").append(toIndentedString(zakelijkGerechtigden)).append("\n");
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

