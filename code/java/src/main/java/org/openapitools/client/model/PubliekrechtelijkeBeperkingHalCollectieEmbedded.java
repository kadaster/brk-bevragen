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
import org.openapitools.client.model.PubliekrechtelijkeBeperkingHal;

/**
 * PubliekrechtelijkeBeperkingHalCollectieEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-15T10:10:49.799642Z[Etc/UTC]")
public class PubliekrechtelijkeBeperkingHalCollectieEmbedded {
  public static final String SERIALIZED_NAME_PUBLIEKRECHTELIJKE_BEPERKINGEN = "publiekrechtelijkeBeperkingen";
  @SerializedName(SERIALIZED_NAME_PUBLIEKRECHTELIJKE_BEPERKINGEN)
  private List<PubliekrechtelijkeBeperkingHal> publiekrechtelijkeBeperkingen = null;


  public PubliekrechtelijkeBeperkingHalCollectieEmbedded publiekrechtelijkeBeperkingen(List<PubliekrechtelijkeBeperkingHal> publiekrechtelijkeBeperkingen) {
    
    this.publiekrechtelijkeBeperkingen = publiekrechtelijkeBeperkingen;
    return this;
  }

  public PubliekrechtelijkeBeperkingHalCollectieEmbedded addPubliekrechtelijkeBeperkingenItem(PubliekrechtelijkeBeperkingHal publiekrechtelijkeBeperkingenItem) {
    if (this.publiekrechtelijkeBeperkingen == null) {
      this.publiekrechtelijkeBeperkingen = new ArrayList<>();
    }
    this.publiekrechtelijkeBeperkingen.add(publiekrechtelijkeBeperkingenItem);
    return this;
  }

   /**
   * Get publiekrechtelijkeBeperkingen
   * @return publiekrechtelijkeBeperkingen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<PubliekrechtelijkeBeperkingHal> getPubliekrechtelijkeBeperkingen() {
    return publiekrechtelijkeBeperkingen;
  }


  public void setPubliekrechtelijkeBeperkingen(List<PubliekrechtelijkeBeperkingHal> publiekrechtelijkeBeperkingen) {
    this.publiekrechtelijkeBeperkingen = publiekrechtelijkeBeperkingen;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PubliekrechtelijkeBeperkingHalCollectieEmbedded publiekrechtelijkeBeperkingHalCollectieEmbedded = (PubliekrechtelijkeBeperkingHalCollectieEmbedded) o;
    return Objects.equals(this.publiekrechtelijkeBeperkingen, publiekrechtelijkeBeperkingHalCollectieEmbedded.publiekrechtelijkeBeperkingen);
  }

  @Override
  public int hashCode() {
    return Objects.hash(publiekrechtelijkeBeperkingen);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PubliekrechtelijkeBeperkingHalCollectieEmbedded {\n");
    sb.append("    publiekrechtelijkeBeperkingen: ").append(toIndentedString(publiekrechtelijkeBeperkingen)).append("\n");
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

