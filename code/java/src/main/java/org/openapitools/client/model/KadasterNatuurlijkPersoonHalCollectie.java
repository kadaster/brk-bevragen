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
import org.openapitools.client.model.HalCollectionLinks;
import org.openapitools.client.model.KadasterNatuurlijkPersoonHalCollectieEmbedded;

/**
 * KadasterNatuurlijkPersoonHalCollectie
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-15T10:10:49.799642Z[Etc/UTC]")
public class KadasterNatuurlijkPersoonHalCollectie {
  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private HalCollectionLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private KadasterNatuurlijkPersoonHalCollectieEmbedded embedded;


  public KadasterNatuurlijkPersoonHalCollectie links(HalCollectionLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalCollectionLinks getLinks() {
    return links;
  }


  public void setLinks(HalCollectionLinks links) {
    this.links = links;
  }


  public KadasterNatuurlijkPersoonHalCollectie embedded(KadasterNatuurlijkPersoonHalCollectieEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public KadasterNatuurlijkPersoonHalCollectieEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(KadasterNatuurlijkPersoonHalCollectieEmbedded embedded) {
    this.embedded = embedded;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    KadasterNatuurlijkPersoonHalCollectie kadasterNatuurlijkPersoonHalCollectie = (KadasterNatuurlijkPersoonHalCollectie) o;
    return Objects.equals(this.links, kadasterNatuurlijkPersoonHalCollectie.links) &&
        Objects.equals(this.embedded, kadasterNatuurlijkPersoonHalCollectie.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KadasterNatuurlijkPersoonHalCollectie {\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
    sb.append("    embedded: ").append(toIndentedString(embedded)).append("\n");
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

