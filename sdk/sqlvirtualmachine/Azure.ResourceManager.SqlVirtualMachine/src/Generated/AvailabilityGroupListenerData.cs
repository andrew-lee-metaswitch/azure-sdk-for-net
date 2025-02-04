// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    /// <summary> A class representing the AvailabilityGroupListener data model. </summary>
    public partial class AvailabilityGroupListenerData : ResourceData
    {
        /// <summary> Initializes a new instance of AvailabilityGroupListenerData. </summary>
        public AvailabilityGroupListenerData()
        {
            LoadBalancerConfigurations = new ChangeTrackingList<AvailabilityGroupListenerLoadBalancerConfiguration>();
            MultiSubnetIPConfigurations = new ChangeTrackingList<MultiSubnetIPConfiguration>();
        }

        /// <summary> Initializes a new instance of AvailabilityGroupListenerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state to track the async operation status. </param>
        /// <param name="availabilityGroupName"> Name of the availability group. </param>
        /// <param name="loadBalancerConfigurations"> List of load balancer configurations for an availability group listener. </param>
        /// <param name="multiSubnetIPConfigurations"> List of multi subnet IP configurations for an AG listener. </param>
        /// <param name="createDefaultAvailabilityGroupIfNotExist"> Create a default availability group if it does not exist. </param>
        /// <param name="port"> Listener port. </param>
        /// <param name="availabilityGroupConfiguration"> Availability Group configuration. </param>
        internal AvailabilityGroupListenerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provisioningState, string availabilityGroupName, IList<AvailabilityGroupListenerLoadBalancerConfiguration> loadBalancerConfigurations, IList<MultiSubnetIPConfiguration> multiSubnetIPConfigurations, bool? createDefaultAvailabilityGroupIfNotExist, int? port, AvailabilityGroupConfiguration availabilityGroupConfiguration) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            AvailabilityGroupName = availabilityGroupName;
            LoadBalancerConfigurations = loadBalancerConfigurations;
            MultiSubnetIPConfigurations = multiSubnetIPConfigurations;
            CreateDefaultAvailabilityGroupIfNotExist = createDefaultAvailabilityGroupIfNotExist;
            Port = port;
            AvailabilityGroupConfiguration = availabilityGroupConfiguration;
        }

        /// <summary> Provisioning state to track the async operation status. </summary>
        public string ProvisioningState { get; }
        /// <summary> Name of the availability group. </summary>
        public string AvailabilityGroupName { get; set; }
        /// <summary> List of load balancer configurations for an availability group listener. </summary>
        public IList<AvailabilityGroupListenerLoadBalancerConfiguration> LoadBalancerConfigurations { get; }
        /// <summary> List of multi subnet IP configurations for an AG listener. </summary>
        public IList<MultiSubnetIPConfiguration> MultiSubnetIPConfigurations { get; }
        /// <summary> Create a default availability group if it does not exist. </summary>
        public bool? CreateDefaultAvailabilityGroupIfNotExist { get; set; }
        /// <summary> Listener port. </summary>
        public int? Port { get; set; }
        /// <summary> Availability Group configuration. </summary>
        internal AvailabilityGroupConfiguration AvailabilityGroupConfiguration { get; set; }
        /// <summary> Replica configurations. </summary>
        public IList<AvailabilityGroupReplica> AvailabilityGroupReplicas
        {
            get
            {
                if (AvailabilityGroupConfiguration is null)
                    AvailabilityGroupConfiguration = new AvailabilityGroupConfiguration();
                return AvailabilityGroupConfiguration.Replicas;
            }
        }
    }
}
