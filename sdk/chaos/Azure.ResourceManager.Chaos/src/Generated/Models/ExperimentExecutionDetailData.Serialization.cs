// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Chaos.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos
{
    public partial class ExperimentExecutionDetailData
    {
        internal static ExperimentExecutionDetailData DeserializeExperimentExecutionDetailData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> experimentId = default;
            Optional<string> status = default;
            Optional<string> failureReason = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> lastActionDateTime = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> stopDateTime = default;
            Optional<ExperimentExecutionDetailsPropertiesRunInformation> runInformation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("experimentId"))
                        {
                            experimentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("failureReason"))
                        {
                            failureReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastActionDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastActionDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("stopDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            stopDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("runInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            runInformation = ExperimentExecutionDetailsPropertiesRunInformation.DeserializeExperimentExecutionDetailsPropertiesRunInformation(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExperimentExecutionDetailData(id, name, type, systemData.Value, experimentId.Value, status.Value, failureReason.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(lastActionDateTime), Optional.ToNullable(startDateTime), Optional.ToNullable(stopDateTime), runInformation.Value);
        }
    }
}
