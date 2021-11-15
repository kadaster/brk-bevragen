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
import org.openapitools.client.model.StukdeelHalBasis;

/**
 * StukEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-15T10:10:49.799642Z[Etc/UTC]")
public class StukEmbedded {
  public static final String SERIALIZED_NAME_STUKDELEN = "stukdelen";
  @SerializedName(SERIALIZED_NAME_STUKDELEN)
  private List<StukdeelHalBasis> stukdelen = null;


  public StukEmbedded stukdelen(List<StukdeelHalBasis> stukdelen) {
    
    this.stukdelen = stukdelen;
    return this;
  }

  public StukEmbedded addStukdelenItem(StukdeelHalBasis stukdelenItem) {
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

  public List<StukdeelHalBasis> getStukdelen() {
    return stukdelen;
  }


  public void setStukdelen(List<StukdeelHalBasis> stukdelen) {
    this.stukdelen = stukdelen;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StukEmbedded stukEmbedded = (StukEmbedded) o;
    return Objects.equals(this.stukdelen, stukEmbedded.stukdelen);
  }

  @Override
  public int hashCode() {
    return Objects.hash(stukdelen);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StukEmbedded {\n");
    sb.append("    stukdelen: ").append(toIndentedString(stukdelen)).append("\n");
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

