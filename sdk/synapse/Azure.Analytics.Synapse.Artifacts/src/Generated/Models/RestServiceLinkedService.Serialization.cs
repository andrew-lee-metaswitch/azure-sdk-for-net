// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RestServiceLinkedServiceConverter))]
    public partial class RestServiceLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("url");
            writer.WriteObjectValue(Url);
            if (Optional.IsDefined(EnableServerCertificateValidation))
            {
                writer.WritePropertyName("enableServerCertificateValidation");
                writer.WriteObjectValue(EnableServerCertificateValidation);
            }
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName");
                writer.WriteObjectValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId");
                writer.WriteObjectValue(ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey");
                writer.WriteObjectValue(ServicePrincipalKey);
            }
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant");
                writer.WriteObjectValue(Tenant);
            }
            if (Optional.IsDefined(AzureCloudType))
            {
                writer.WritePropertyName("azureCloudType");
                writer.WriteObjectValue(AzureCloudType);
            }
            if (Optional.IsDefined(AadResourceId))
            {
                writer.WritePropertyName("aadResourceId");
                writer.WriteObjectValue(AadResourceId);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
                writer.WriteObjectValue(EncryptedCredential);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteObjectValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret");
                writer.WriteObjectValue(ClientSecret);
            }
            if (Optional.IsDefined(TokenEndpoint))
            {
                writer.WritePropertyName("tokenEndpoint");
                writer.WriteObjectValue(TokenEndpoint);
            }
            if (Optional.IsDefined(Resource))
            {
                writer.WritePropertyName("resource");
                writer.WriteObjectValue(Resource);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteObjectValue(Scope);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static RestServiceLinkedService DeserializeRestServiceLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object url = default;
            Optional<object> enableServerCertificateValidation = default;
            RestServiceAuthenticationType authenticationType = default;
            Optional<object> userName = default;
            Optional<SecretBase> password = default;
            Optional<object> servicePrincipalId = default;
            Optional<SecretBase> servicePrincipalKey = default;
            Optional<object> tenant = default;
            Optional<object> azureCloudType = default;
            Optional<object> aadResourceId = default;
            Optional<object> encryptedCredential = default;
            Optional<object> clientId = default;
            Optional<SecretBase> clientSecret = default;
            Optional<object> tokenEndpoint = default;
            Optional<object> resource = default;
            Optional<object> scope = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("url"))
                        {
                            url = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableServerCertificateValidation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableServerCertificateValidation = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"))
                        {
                            authenticationType = new RestServiceAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            userName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            servicePrincipalId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            servicePrincipalKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tenant"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tenant = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("azureCloudType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureCloudType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("aadResourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            aadResourceId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientSecret = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tokenEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tokenEndpoint = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("resource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resource = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("scope"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scope = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RestServiceLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, url, enableServerCertificateValidation.Value, authenticationType, userName.Value, password.Value, servicePrincipalId.Value, servicePrincipalKey.Value, tenant.Value, azureCloudType.Value, aadResourceId.Value, encryptedCredential.Value, clientId.Value, clientSecret.Value, tokenEndpoint.Value, resource.Value, scope.Value);
        }

        internal partial class RestServiceLinkedServiceConverter : JsonConverter<RestServiceLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, RestServiceLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RestServiceLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRestServiceLinkedService(document.RootElement);
            }
        }
    }
}
