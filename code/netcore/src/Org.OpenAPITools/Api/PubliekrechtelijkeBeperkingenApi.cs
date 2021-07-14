/*
 * Kadaster - BRK-Bevragen API
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie. 
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPubliekrechtelijkeBeperkingenApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Zoek publiekrechtelijke beperkingen op een kadastraal onroerende zaak. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="kadastraalOnroerendeZaakIdentificatie">De unieke identificatie van een kadastraal onroerende zaak. Gezocht wordt naar publiekrechtelijke beperkingen die rusten op de onroerende zaak </param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature) (optional)</param>
        /// <returns>PubliekrechtelijkeBeperkingHalCollectie</returns>
        PubliekrechtelijkeBeperkingHalCollectie GetPubliekrechtelijkeBeperkingen(string kadastraalOnroerendeZaakIdentificatie, string fields = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Zoek publiekrechtelijke beperkingen op een kadastraal onroerende zaak. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="kadastraalOnroerendeZaakIdentificatie">De unieke identificatie van een kadastraal onroerende zaak. Gezocht wordt naar publiekrechtelijke beperkingen die rusten op de onroerende zaak </param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature) (optional)</param>
        /// <returns>ApiResponse of PubliekrechtelijkeBeperkingHalCollectie</returns>
        ApiResponse<PubliekrechtelijkeBeperkingHalCollectie> GetPubliekrechtelijkeBeperkingenWithHttpInfo(string kadastraalOnroerendeZaakIdentificatie, string fields = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPubliekrechtelijkeBeperkingenApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Zoek publiekrechtelijke beperkingen op een kadastraal onroerende zaak. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="kadastraalOnroerendeZaakIdentificatie">De unieke identificatie van een kadastraal onroerende zaak. Gezocht wordt naar publiekrechtelijke beperkingen die rusten op de onroerende zaak </param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PubliekrechtelijkeBeperkingHalCollectie</returns>
        System.Threading.Tasks.Task<PubliekrechtelijkeBeperkingHalCollectie> GetPubliekrechtelijkeBeperkingenAsync(string kadastraalOnroerendeZaakIdentificatie, string fields = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Zoek publiekrechtelijke beperkingen op een kadastraal onroerende zaak. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="kadastraalOnroerendeZaakIdentificatie">De unieke identificatie van een kadastraal onroerende zaak. Gezocht wordt naar publiekrechtelijke beperkingen die rusten op de onroerende zaak </param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PubliekrechtelijkeBeperkingHalCollectie)</returns>
        System.Threading.Tasks.Task<ApiResponse<PubliekrechtelijkeBeperkingHalCollectie>> GetPubliekrechtelijkeBeperkingenWithHttpInfoAsync(string kadastraalOnroerendeZaakIdentificatie, string fields = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPubliekrechtelijkeBeperkingenApi : IPubliekrechtelijkeBeperkingenApiSync, IPubliekrechtelijkeBeperkingenApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PubliekrechtelijkeBeperkingenApi : IPubliekrechtelijkeBeperkingenApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PubliekrechtelijkeBeperkingenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PubliekrechtelijkeBeperkingenApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PubliekrechtelijkeBeperkingenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PubliekrechtelijkeBeperkingenApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PubliekrechtelijkeBeperkingenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PubliekrechtelijkeBeperkingenApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PubliekrechtelijkeBeperkingenApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PubliekrechtelijkeBeperkingenApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Zoek publiekrechtelijke beperkingen op een kadastraal onroerende zaak. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="kadastraalOnroerendeZaakIdentificatie">De unieke identificatie van een kadastraal onroerende zaak. Gezocht wordt naar publiekrechtelijke beperkingen die rusten op de onroerende zaak </param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature) (optional)</param>
        /// <returns>PubliekrechtelijkeBeperkingHalCollectie</returns>
        public PubliekrechtelijkeBeperkingHalCollectie GetPubliekrechtelijkeBeperkingen(string kadastraalOnroerendeZaakIdentificatie, string fields = default(string))
        {
            Org.OpenAPITools.Client.ApiResponse<PubliekrechtelijkeBeperkingHalCollectie> localVarResponse = GetPubliekrechtelijkeBeperkingenWithHttpInfo(kadastraalOnroerendeZaakIdentificatie, fields);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Zoek publiekrechtelijke beperkingen op een kadastraal onroerende zaak. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="kadastraalOnroerendeZaakIdentificatie">De unieke identificatie van een kadastraal onroerende zaak. Gezocht wordt naar publiekrechtelijke beperkingen die rusten op de onroerende zaak </param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature) (optional)</param>
        /// <returns>ApiResponse of PubliekrechtelijkeBeperkingHalCollectie</returns>
        public Org.OpenAPITools.Client.ApiResponse<PubliekrechtelijkeBeperkingHalCollectie> GetPubliekrechtelijkeBeperkingenWithHttpInfo(string kadastraalOnroerendeZaakIdentificatie, string fields = default(string))
        {
            // verify the required parameter 'kadastraalOnroerendeZaakIdentificatie' is set
            if (kadastraalOnroerendeZaakIdentificatie == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'kadastraalOnroerendeZaakIdentificatie' when calling PubliekrechtelijkeBeperkingenApi->GetPubliekrechtelijkeBeperkingen");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/hal+json",
                "application/problem+json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "fields", fields));
            }
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "kadastraalOnroerendeZaakIdentificatie", kadastraalOnroerendeZaakIdentificatie));

            // authentication (apiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PubliekrechtelijkeBeperkingHalCollectie>("/publiekrechtelijkebeperkingen", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPubliekrechtelijkeBeperkingen", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Zoek publiekrechtelijke beperkingen op een kadastraal onroerende zaak. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="kadastraalOnroerendeZaakIdentificatie">De unieke identificatie van een kadastraal onroerende zaak. Gezocht wordt naar publiekrechtelijke beperkingen die rusten op de onroerende zaak </param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PubliekrechtelijkeBeperkingHalCollectie</returns>
        public async System.Threading.Tasks.Task<PubliekrechtelijkeBeperkingHalCollectie> GetPubliekrechtelijkeBeperkingenAsync(string kadastraalOnroerendeZaakIdentificatie, string fields = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<PubliekrechtelijkeBeperkingHalCollectie> localVarResponse = await GetPubliekrechtelijkeBeperkingenWithHttpInfoAsync(kadastraalOnroerendeZaakIdentificatie, fields, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Zoek publiekrechtelijke beperkingen op een kadastraal onroerende zaak. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="kadastraalOnroerendeZaakIdentificatie">De unieke identificatie van een kadastraal onroerende zaak. Gezocht wordt naar publiekrechtelijke beperkingen die rusten op de onroerende zaak </param>
        /// <param name="fields">Hiermee kun je de inhoud van de resource naar behoefte aanpassen door een door komma&#39;s gescheiden lijst van property namen op te geven. Bij opgave van niet-bestaande properties wordt een 400 Bad Request teruggegeven. Wanneer de fields parameter niet is opgegeven, worden alle properties met een waarde teruggegeven. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PubliekrechtelijkeBeperkingHalCollectie)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<PubliekrechtelijkeBeperkingHalCollectie>> GetPubliekrechtelijkeBeperkingenWithHttpInfoAsync(string kadastraalOnroerendeZaakIdentificatie, string fields = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'kadastraalOnroerendeZaakIdentificatie' is set
            if (kadastraalOnroerendeZaakIdentificatie == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'kadastraalOnroerendeZaakIdentificatie' when calling PubliekrechtelijkeBeperkingenApi->GetPubliekrechtelijkeBeperkingen");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/hal+json",
                "application/problem+json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "fields", fields));
            }
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "kadastraalOnroerendeZaakIdentificatie", kadastraalOnroerendeZaakIdentificatie));

            // authentication (apiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PubliekrechtelijkeBeperkingHalCollectie>("/publiekrechtelijkebeperkingen", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPubliekrechtelijkeBeperkingen", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
