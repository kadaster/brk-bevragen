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

/**
 * EquivalentieVerklaarderAllOf
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-09T17:37:32.228183Z[Etc/UTC]")
public class EquivalentieVerklaarderAllOf {
  public static final String SERIALIZED_NAME_STANDPLAATS = "standplaats";
  @SerializedName(SERIALIZED_NAME_STANDPLAATS)
  private String standplaats;


  public EquivalentieVerklaarderAllOf standplaats(String standplaats) {
    
    this.standplaats = standplaats;
    return this;
  }

   /**
   * Adres of standplaats/plaats van vestiging van de ondertekenaar. 
   * @return standplaats
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Adres of standplaats/plaats van vestiging van de ondertekenaar. ")

  public String getStandplaats() {
    return standplaats;
  }


  public void setStandplaats(String standplaats) {
    this.standplaats = standplaats;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EquivalentieVerklaarderAllOf equivalentieVerklaarderAllOf = (EquivalentieVerklaarderAllOf) o;
    return Objects.equals(this.standplaats, equivalentieVerklaarderAllOf.standplaats);
  }

  @Override
  public int hashCode() {
    return Objects.hash(standplaats);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EquivalentieVerklaarderAllOf {\n");
    sb.append("    standplaats: ").append(toIndentedString(standplaats)).append("\n");
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

