// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Analysis
{
    using System;		
    using System.Collections.Generic;		
    using System.Net.Http;		
    using System.Threading;		
    using System.Threading.Tasks;		
    using Rest;
    using Rest.Azure;
    using Models;

    /// <summary>
    /// ServersOperations operations.
    /// </summary>
    public partial interface IServersOperations
    {
        /// <summary>
        /// Gets details about the specified Analysis Services server
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> GetDetailsWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Provisions the specified Analysis Services server based on the
        /// configuration specified in the request
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='serverParameters'>
        /// Request body for provisioning
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> CreateWithHttpMessagesAsync(string resourceGroupName, string serverName, AnalysisServicesServer serverParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Provisions the specified Analysis Services server based on the
        /// configuration specified in the request
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='serverParameters'>
        /// Request body for provisioning
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string serverName, AnalysisServicesServer serverParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Analysis Services server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Analysis Services server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the current state of the specified Analysis Services server
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='serverUpdateParameters'>
        /// Request object for updating the server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> UpdateWithHttpMessagesAsync(string resourceGroupName, string serverName, AnalysisServicesServerUpdateParameters serverUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Supends the specified Analysis Services server instance
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> SuspendWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Supends the specified Analysis Services server instance
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginSuspendWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resumes the specified Analysis Services server instance
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResumeWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resumes the specified Analysis Services server instance
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='serverName'>
        /// Name of the Analysis Services server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginResumeWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the Analysis Services servers for the given resource group
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Azure Resource group which a given Analysis Services
        /// server is part of.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<AnalysisServicesServer>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all the Analysis Services servers for the given subscription
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<AnalysisServicesServer>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
