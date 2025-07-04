using System.Text.Json.Serialization;
using Sdk.Core.Domain.Model;

namespace Sdk.Core.Domain.Messages;

public class DataFlowResponseMessage
{
    [JsonPropertyName(IConstants.EdcNamespace + "dataAddress")]
    public required DataAddress DataAddress { get; set; }

    public bool IsProvisioned { get; set; } = false;
}