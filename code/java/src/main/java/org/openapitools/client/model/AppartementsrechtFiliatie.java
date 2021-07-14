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
import org.openapitools.client.model.AppartementsrechtFiliatie;
import org.openapitools.client.model.AppartementsrechtFiliatieAllOf;
import org.openapitools.client.model.KadastraalOnroerendeZaakFiliatie;
import org.openapitools.client.model.PerceelFiliatie;
import org.openapitools.client.model.TypeKadastraalOnroerendeZaakEnum;

/**
 * AppartementsrechtFiliatie
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-14T09:58:19.624161Z[Etc/UTC]")
public class AppartementsrechtFiliatie extends KadastraalOnroerendeZaakFiliatie {
  public static final String SERIALIZED_NAME_INDICATIE_SLUIMEREND = "indicatieSluimerend";
  @SerializedName(SERIALIZED_NAME_INDICATIE_SLUIMEREND)
  private Boolean indicatieSluimerend;

  public AppartementsrechtFiliatie() {
    this.type = this.getClass().getSimpleName();
  }

  public AppartementsrechtFiliatie indicatieSluimerend(Boolean indicatieSluimerend) {
    
    this.indicatieSluimerend = indicatieSluimerend;
    return this;
  }

   /**
   * Get indicatieSluimerend
   * @return indicatieSluimerend
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIndicatieSluimerend() {
    return indicatieSluimerend;
  }


  public void setIndicatieSluimerend(Boolean indicatieSluimerend) {
    this.indicatieSluimerend = indicatieSluimerend;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AppartementsrechtFiliatie appartementsrechtFiliatie = (AppartementsrechtFiliatie) o;
    return Objects.equals(this.indicatieSluimerend, appartementsrechtFiliatie.indicatieSluimerend) &&
        super.equals(o);
  }

  @Override
  public int hashCode() {
    return Objects.hash(indicatieSluimerend, super.hashCode());
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AppartementsrechtFiliatie {\n");
    sb.append("    ").append(toIndentedString(super.toString())).append("\n");
    sb.append("    indicatieSluimerend: ").append(toIndentedString(indicatieSluimerend)).append("\n");
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

