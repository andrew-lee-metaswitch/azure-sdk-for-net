// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppTwitterConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Registration))
            {
                writer.WritePropertyName("registration");
                writer.WriteObjectValue(Registration);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppTwitterConfiguration DeserializeContainerAppTwitterConfiguration(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<ContainerAppTwitterRegistration> registration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("registration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    registration = ContainerAppTwitterRegistration.DeserializeContainerAppTwitterRegistration(property.Value);
                    continue;
                }
            }
            return new ContainerAppTwitterConfiguration(Optional.ToNullable(enabled), registration.Value);
        }
    }
}
