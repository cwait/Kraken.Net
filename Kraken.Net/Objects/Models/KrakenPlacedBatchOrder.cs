﻿namespace Kraken.Net.Objects.Models
{
    /// <summary>
    /// Batch order result
    /// </summary>
    public record KrakenBatchOrderResult
    {
        /// <summary>
        /// Orders
        /// </summary>
        [JsonPropertyName("orders")]
        public IEnumerable<KrakenPlacedBatchOrder> Orders { get; set; } = Array.Empty<KrakenPlacedBatchOrder>();
    }

    /// <summary>
    /// Placed batch order
    /// </summary>
    public record KrakenPlacedBatchOrder
    {
        /// <summary>
        /// Order id
        /// </summary>
        [JsonPropertyName("txid")]
        public string OrderId { get; set; } = null!;
        /// <summary>
        /// Description
        /// </summary>
        [JsonPropertyName("descr")]
        public KrakenPlacedOrderDescription Description { get; set; } = null!;
        /// <summary>
        /// Close order description
        /// </summary>
        [JsonPropertyName("close")]
        public string? CloseOrderInfo { get; set; }
    }
}
