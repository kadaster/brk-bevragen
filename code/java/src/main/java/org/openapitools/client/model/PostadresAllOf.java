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
 * PostadresAllOf
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-09T17:37:32.228183Z[Etc/UTC]")
public class PostadresAllOf {
  public static final String SERIALIZED_NAME_POSTBUSNUMMER = "postbusnummer";
  @SerializedName(SERIALIZED_NAME_POSTBUSNUMMER)
  private Integer postbusnummer;


  public PostadresAllOf postbusnummer(Integer postbusnummer) {
    
    this.postbusnummer = postbusnummer;
    return this;
  }

   /**
   * Get postbusnummer
   * @return postbusnummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getPostbusnummer() {
    return postbusnummer;
  }


  public void setPostbusnummer(Integer postbusnummer) {
    this.postbusnummer = postbusnummer;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PostadresAllOf postadresAllOf = (PostadresAllOf) o;
    return Objects.equals(this.postbusnummer, postadresAllOf.postbusnummer);
  }

  @Override
  public int hashCode() {
    return Objects.hash(postbusnummer);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PostadresAllOf {\n");
    sb.append("    postbusnummer: ").append(toIndentedString(postbusnummer)).append("\n");
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

