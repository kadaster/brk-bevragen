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
import java.time.LocalDate;

/**
 * Gegevens over de datums die mogelijk niet volledig zijn.
 */
@ApiModel(description = "Gegevens over de datums die mogelijk niet volledig zijn.")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-09-22T08:28:41.072015Z[Etc/UTC]")
public class DatumOnvolledig {
  public static final String SERIALIZED_NAME_DAG = "dag";
  @SerializedName(SERIALIZED_NAME_DAG)
  private Integer dag;

  public static final String SERIALIZED_NAME_DATUM = "datum";
  @SerializedName(SERIALIZED_NAME_DATUM)
  private LocalDate datum;

  public static final String SERIALIZED_NAME_JAAR = "jaar";
  @SerializedName(SERIALIZED_NAME_JAAR)
  private Integer jaar;

  public static final String SERIALIZED_NAME_MAAND = "maand";
  @SerializedName(SERIALIZED_NAME_MAAND)
  private Integer maand;


  public DatumOnvolledig dag(Integer dag) {
    
    this.dag = dag;
    return this;
  }

   /**
   * Als de dag van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.
   * minimum: 1
   * maximum: 31
   * @return dag
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "3", value = "Als de dag van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.")

  public Integer getDag() {
    return dag;
  }


  public void setDag(Integer dag) {
    this.dag = dag;
  }


  public DatumOnvolledig datum(LocalDate datum) {
    
    this.datum = datum;
    return this;
  }

   /**
   * Als de volledige datum bekend is wordt de datum gevuld die in de date definitie past.
   * @return datum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "Wed May 03 00:00:00 UTC 1989", value = "Als de volledige datum bekend is wordt de datum gevuld die in de date definitie past.")

  public LocalDate getDatum() {
    return datum;
  }


  public void setDatum(LocalDate datum) {
    this.datum = datum;
  }


  public DatumOnvolledig jaar(Integer jaar) {
    
    this.jaar = jaar;
    return this;
  }

   /**
   * Als het jaar van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.
   * maximum: 9999
   * @return jaar
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "1989", value = "Als het jaar van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.")

  public Integer getJaar() {
    return jaar;
  }


  public void setJaar(Integer jaar) {
    this.jaar = jaar;
  }


  public DatumOnvolledig maand(Integer maand) {
    
    this.maand = maand;
    return this;
  }

   /**
   * Als de maand van een datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.
   * minimum: 1
   * maximum: 12
   * @return maand
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "5", value = "Als de maand van een datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.")

  public Integer getMaand() {
    return maand;
  }


  public void setMaand(Integer maand) {
    this.maand = maand;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DatumOnvolledig datumOnvolledig = (DatumOnvolledig) o;
    return Objects.equals(this.dag, datumOnvolledig.dag) &&
        Objects.equals(this.datum, datumOnvolledig.datum) &&
        Objects.equals(this.jaar, datumOnvolledig.jaar) &&
        Objects.equals(this.maand, datumOnvolledig.maand);
  }

  @Override
  public int hashCode() {
    return Objects.hash(dag, datum, jaar, maand);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DatumOnvolledig {\n");
    sb.append("    dag: ").append(toIndentedString(dag)).append("\n");
    sb.append("    datum: ").append(toIndentedString(datum)).append("\n");
    sb.append("    jaar: ").append(toIndentedString(jaar)).append("\n");
    sb.append("    maand: ").append(toIndentedString(maand)).append("\n");
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

