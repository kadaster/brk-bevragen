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
import org.openapitools.client.model.RedenVerzoek;
import org.openapitools.client.model.Waardelijst;

/**
 * Een verzoek om verbetering van een aangeboden stuk, of om de aanbieder te wijzen op het niet inschrijven van het stuk. Waardelijst in deze component :   [aard](http://www.kadaster.nl/schemas/waardelijsten/AardKadasterverzoek/) 
 */
@ApiModel(description = "Een verzoek om verbetering van een aangeboden stuk, of om de aanbieder te wijzen op het niet inschrijven van het stuk. Waardelijst in deze component :   [aard](http://www.kadaster.nl/schemas/waardelijsten/AardKadasterverzoek/) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-09-22T10:30:56.069820Z[Etc/UTC]")
public class Kadasterverzoek {
  public static final String SERIALIZED_NAME_AARD = "aard";
  @SerializedName(SERIALIZED_NAME_AARD)
  private Waardelijst aard;

  public static final String SERIALIZED_NAME_REDENEN_VERZOEK = "redenenVerzoek";
  @SerializedName(SERIALIZED_NAME_REDENEN_VERZOEK)
  private List<RedenVerzoek> redenenVerzoek = null;


  public Kadasterverzoek aard(Waardelijst aard) {
    
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


  public Kadasterverzoek redenenVerzoek(List<RedenVerzoek> redenenVerzoek) {
    
    this.redenenVerzoek = redenenVerzoek;
    return this;
  }

  public Kadasterverzoek addRedenenVerzoekItem(RedenVerzoek redenenVerzoekItem) {
    if (this.redenenVerzoek == null) {
      this.redenenVerzoek = new ArrayList<>();
    }
    this.redenenVerzoek.add(redenenVerzoekItem);
    return this;
  }

   /**
   * Get redenenVerzoek
   * @return redenenVerzoek
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<RedenVerzoek> getRedenenVerzoek() {
    return redenenVerzoek;
  }


  public void setRedenenVerzoek(List<RedenVerzoek> redenenVerzoek) {
    this.redenenVerzoek = redenenVerzoek;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Kadasterverzoek kadasterverzoek = (Kadasterverzoek) o;
    return Objects.equals(this.aard, kadasterverzoek.aard) &&
        Objects.equals(this.redenenVerzoek, kadasterverzoek.redenenVerzoek);
  }

  @Override
  public int hashCode() {
    return Objects.hash(aard, redenenVerzoek);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Kadasterverzoek {\n");
    sb.append("    aard: ").append(toIndentedString(aard)).append("\n");
    sb.append("    redenenVerzoek: ").append(toIndentedString(redenenVerzoek)).append("\n");
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

