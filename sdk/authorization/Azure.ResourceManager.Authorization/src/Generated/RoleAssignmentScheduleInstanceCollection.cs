// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleAssignmentScheduleInstanceResource" /> and their operations.
    /// Each <see cref="RoleAssignmentScheduleInstanceResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RoleAssignmentScheduleInstanceCollection" /> instance call the GetRoleAssignmentScheduleInstances method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RoleAssignmentScheduleInstanceCollection : ArmCollection, IEnumerable<RoleAssignmentScheduleInstanceResource>, IAsyncEnumerable<RoleAssignmentScheduleInstanceResource>
    {
        private readonly ClientDiagnostics _roleAssignmentScheduleInstanceClientDiagnostics;
        private readonly RoleAssignmentScheduleInstancesRestOperations _roleAssignmentScheduleInstanceRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleInstanceCollection"/> class for mocking. </summary>
        protected RoleAssignmentScheduleInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleAssignmentScheduleInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleAssignmentScheduleInstanceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleAssignmentScheduleInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleAssignmentScheduleInstanceResource.ResourceType, out string roleAssignmentScheduleInstanceApiVersion);
            _roleAssignmentScheduleInstanceRestClient = new RoleAssignmentScheduleInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleAssignmentScheduleInstanceApiVersion);
        }

        /// <summary>
        /// Gets the specified role assignment schedule instance.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleInstances/{roleAssignmentScheduleInstanceName}
        /// Operation Id: RoleAssignmentScheduleInstances_Get
        /// </summary>
        /// <param name="roleAssignmentScheduleInstanceName"> The name (hash of schedule name + time) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleInstanceName"/> is null. </exception>
        public virtual async Task<Response<RoleAssignmentScheduleInstanceResource>> GetAsync(string roleAssignmentScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleInstanceName, nameof(roleAssignmentScheduleInstanceName));

            using var scope = _roleAssignmentScheduleInstanceClientDiagnostics.CreateScope("RoleAssignmentScheduleInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleInstanceRestClient.GetAsync(Id, roleAssignmentScheduleInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified role assignment schedule instance.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleInstances/{roleAssignmentScheduleInstanceName}
        /// Operation Id: RoleAssignmentScheduleInstances_Get
        /// </summary>
        /// <param name="roleAssignmentScheduleInstanceName"> The name (hash of schedule name + time) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleInstanceName"/> is null. </exception>
        public virtual Response<RoleAssignmentScheduleInstanceResource> Get(string roleAssignmentScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleInstanceName, nameof(roleAssignmentScheduleInstanceName));

            using var scope = _roleAssignmentScheduleInstanceClientDiagnostics.CreateScope("RoleAssignmentScheduleInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleInstanceRestClient.Get(Id, roleAssignmentScheduleInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role assignment schedule instances of a role assignment schedule.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleInstances
        /// Operation Id: RoleAssignmentScheduleInstances_ListForScope
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal.  Use $filter=assignedTo(&apos;{userId}&apos;) to return all role assignment schedule instances for the user. Use $filter=asTarget() to return all role assignment schedule instances created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleAssignmentScheduleInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleAssignmentScheduleInstanceResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RoleAssignmentScheduleInstanceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _roleAssignmentScheduleInstanceClientDiagnostics.CreateScope("RoleAssignmentScheduleInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _roleAssignmentScheduleInstanceRestClient.ListForScopeAsync(Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentScheduleInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RoleAssignmentScheduleInstanceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _roleAssignmentScheduleInstanceClientDiagnostics.CreateScope("RoleAssignmentScheduleInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _roleAssignmentScheduleInstanceRestClient.ListForScopeNextPageAsync(nextLink, Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentScheduleInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets role assignment schedule instances of a role assignment schedule.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleInstances
        /// Operation Id: RoleAssignmentScheduleInstances_ListForScope
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal.  Use $filter=assignedTo(&apos;{userId}&apos;) to return all role assignment schedule instances for the user. Use $filter=asTarget() to return all role assignment schedule instances created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleAssignmentScheduleInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleAssignmentScheduleInstanceResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<RoleAssignmentScheduleInstanceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _roleAssignmentScheduleInstanceClientDiagnostics.CreateScope("RoleAssignmentScheduleInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _roleAssignmentScheduleInstanceRestClient.ListForScope(Id, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentScheduleInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RoleAssignmentScheduleInstanceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _roleAssignmentScheduleInstanceClientDiagnostics.CreateScope("RoleAssignmentScheduleInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _roleAssignmentScheduleInstanceRestClient.ListForScopeNextPage(nextLink, Id, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentScheduleInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleInstances/{roleAssignmentScheduleInstanceName}
        /// Operation Id: RoleAssignmentScheduleInstances_Get
        /// </summary>
        /// <param name="roleAssignmentScheduleInstanceName"> The name (hash of schedule name + time) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleAssignmentScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleInstanceName, nameof(roleAssignmentScheduleInstanceName));

            using var scope = _roleAssignmentScheduleInstanceClientDiagnostics.CreateScope("RoleAssignmentScheduleInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleInstanceRestClient.GetAsync(Id, roleAssignmentScheduleInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleInstances/{roleAssignmentScheduleInstanceName}
        /// Operation Id: RoleAssignmentScheduleInstances_Get
        /// </summary>
        /// <param name="roleAssignmentScheduleInstanceName"> The name (hash of schedule name + time) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleAssignmentScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleInstanceName, nameof(roleAssignmentScheduleInstanceName));

            using var scope = _roleAssignmentScheduleInstanceClientDiagnostics.CreateScope("RoleAssignmentScheduleInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleInstanceRestClient.Get(Id, roleAssignmentScheduleInstanceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleAssignmentScheduleInstanceResource> IEnumerable<RoleAssignmentScheduleInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleAssignmentScheduleInstanceResource> IAsyncEnumerable<RoleAssignmentScheduleInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
