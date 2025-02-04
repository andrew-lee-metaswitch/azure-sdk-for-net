// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class SimpleFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(FilterType.ToString());
            writer.WriteEndObject();
        }

        internal static SimpleFilter DeserializeSimpleFilter(JsonElement element)
        {
            Optional<SimpleFilterParameters> parameters = default;
            FilterType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    parameters = SimpleFilterParameters.DeserializeSimpleFilterParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new FilterType(property.Value.GetString());
                    continue;
                }
            }
            return new SimpleFilter(type, parameters.Value);
        }
    }
}
