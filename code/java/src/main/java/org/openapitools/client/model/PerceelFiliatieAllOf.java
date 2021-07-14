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

/**
 * PerceelFiliatieAllOf
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-14T09:58:19.624161Z[Etc/UTC]")
public class PerceelFiliatieAllOf {
  public static final String SERIALIZED_NAME_INDICATIE_VERVALLEN = "indicatieVervallen";
  @SerializedName(SERIALIZED_NAME_INDICATIE_VERVALLEN)
  private Boolean indicatieVervallen;


  public PerceelFiliatieAllOf indicatieVervallen(Boolean indicatieVervallen) {
    
    this.indicatieVervallen = indicatieVervallen;
    return this;
  }

   /**
   * Geeft aan of de filiatie verwijst naar een vervallen kadastraal onroerende zaak. 
   * @return indicatieVervallen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Geeft aan of de filiatie verwijst naar een vervallen kadastraal onroerende zaak. ")

  public Boolean getIndicatieVervallen() {
    return indicatieVervallen;
  }


  public void setIndicatieVervallen(Boolean indicatieVervallen) {
    this.indicatieVervallen = indicatieVervallen;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PerceelFiliatieAllOf perceelFiliatieAllOf = (PerceelFiliatieAllOf) o;
    return Objects.equals(this.indicatieVervallen, perceelFiliatieAllOf.indicatieVervallen);
  }

  @Override
  public int hashCode() {
    return Objects.hash(indicatieVervallen);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PerceelFiliatieAllOf {\n");
    sb.append("    indicatieVervallen: ").append(toIndentedString(indicatieVervallen)).append("\n");
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

