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
import org.openapitools.client.model.Waardelijst;

/**
 * Oppervlakte   Waardelijst in deze component :   [soortGrootte](http://www.kadaster.nl/schemas/waardelijsten/SoortGrootte/) 
 */
@ApiModel(description = "Oppervlakte   Waardelijst in deze component :   [soortGrootte](http://www.kadaster.nl/schemas/waardelijsten/SoortGrootte/) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-09T17:37:32.228183Z[Etc/UTC]")
public class TypeOppervlak {
  public static final String SERIALIZED_NAME_SOORT_GROOTTE = "soortGrootte";
  @SerializedName(SERIALIZED_NAME_SOORT_GROOTTE)
  private Waardelijst soortGrootte;

  public static final String SERIALIZED_NAME_WAARDE = "waarde";
  @SerializedName(SERIALIZED_NAME_WAARDE)
  private Integer waarde;


  public TypeOppervlak soortGrootte(Waardelijst soortGrootte) {
    
    this.soortGrootte = soortGrootte;
    return this;
  }

   /**
   * Get soortGrootte
   * @return soortGrootte
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardelijst getSoortGrootte() {
    return soortGrootte;
  }


  public void setSoortGrootte(Waardelijst soortGrootte) {
    this.soortGrootte = soortGrootte;
  }


  public TypeOppervlak waarde(Integer waarde) {
    
    this.waarde = waarde;
    return this;
  }

   /**
   * Oppervlak grootte, in vierkante meters 
   * @return waarde
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Oppervlak grootte, in vierkante meters ")

  public Integer getWaarde() {
    return waarde;
  }


  public void setWaarde(Integer waarde) {
    this.waarde = waarde;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TypeOppervlak typeOppervlak = (TypeOppervlak) o;
    return Objects.equals(this.soortGrootte, typeOppervlak.soortGrootte) &&
        Objects.equals(this.waarde, typeOppervlak.waarde);
  }

  @Override
  public int hashCode() {
    return Objects.hash(soortGrootte, waarde);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TypeOppervlak {\n");
    sb.append("    soortGrootte: ").append(toIndentedString(soortGrootte)).append("\n");
    sb.append("    waarde: ").append(toIndentedString(waarde)).append("\n");
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

