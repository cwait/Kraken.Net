﻿using CryptoExchange.Net.Objects.Options;
using Kraken.Net.Interfaces.Clients.FuturesApi;
using Kraken.Net.Interfaces.Clients.SpotApi;

namespace Kraken.Net.Interfaces.Clients
{
    /// <summary>
    /// Client for accessing the Kraken API. 
    /// </summary>
    public interface IKrakenRestClient : IRestClient
    {
        /// <summary>
        /// Spot API endpoints
        /// </summary>
        IKrakenRestClientSpotApi SpotApi { get; }

        /// <summary>
        /// Futures API endpoints
        /// </summary>
        IKrakenRestClientFuturesApi FuturesApi { get; }

        /// <summary>
        /// Update specific options
        /// </summary>
        /// <param name="options">Options to update. Only specific options are changable after the client has been created</param>
        void SetOptions(UpdateOptions options);

        /// <summary>
        /// Set the API credentials for this client. All Api clients in this client will use the new credentials, regardless of earlier set options.
        /// </summary>
        /// <param name="credentials">The credentials to set</param>
        void SetApiCredentials(ApiCredentials credentials);
    }
}