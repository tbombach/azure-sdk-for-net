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
    using System.Collections;		
    using System.Collections.Generic;		
    using System.Threading;
    using System.Threading.Tasks;
    using Rest;
    using Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ServersOperations.
    /// </summary>
    public static partial class ServersOperationsExtensions
    {
            /// <summary>
            /// Gets details about the specified Analysis Services server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            public static AnalysisServicesServer GetDetails(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                return Task.Factory.StartNew(s => ((IServersOperations)s).GetDetailsAsync(resourceGroupName, serverName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details about the specified Analysis Services server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServer> GetDetailsAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDetailsWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provisions the specified Analysis Services server based on the
            /// configuration specified in the request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='serverParameters'>
            /// Request body for provisioning
            /// </param>
            public static AnalysisServicesServer Create(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServer serverParameters)
            {
                return Task.Factory.StartNew(s => ((IServersOperations)s).CreateAsync(resourceGroupName, serverName, serverParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provisions the specified Analysis Services server based on the
            /// configuration specified in the request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='serverParameters'>
            /// Request body for provisioning
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServer> CreateAsync(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServer serverParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, serverName, serverParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provisions the specified Analysis Services server based on the
            /// configuration specified in the request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='serverParameters'>
            /// Request body for provisioning
            /// </param>
            public static AnalysisServicesServer BeginCreate(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServer serverParameters)
            {
                return Task.Factory.StartNew(s => ((IServersOperations)s).BeginCreateAsync(resourceGroupName, serverName, serverParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provisions the specified Analysis Services server based on the
            /// configuration specified in the request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='serverParameters'>
            /// Request body for provisioning
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServer> BeginCreateAsync(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServer serverParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, serverName, serverParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            public static void Delete(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                Task.Factory.StartNew(s => ((IServersOperations)s).DeleteAsync(resourceGroupName, serverName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            public static void BeginDelete(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                Task.Factory.StartNew(s => ((IServersOperations)s).BeginDeleteAsync(resourceGroupName, serverName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Updates the current state of the specified Analysis Services server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='serverUpdateParameters'>
            /// Request object for updating the server
            /// </param>
            public static AnalysisServicesServer Update(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerUpdateParameters serverUpdateParameters)
            {
                return Task.Factory.StartNew(s => ((IServersOperations)s).UpdateAsync(resourceGroupName, serverName, serverUpdateParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the current state of the specified Analysis Services server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='serverUpdateParameters'>
            /// Request object for updating the server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServer> UpdateAsync(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerUpdateParameters serverUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, serverUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Supends the specified Analysis Services server instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            public static void Suspend(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                Task.Factory.StartNew(s => ((IServersOperations)s).SuspendAsync(resourceGroupName, serverName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Supends the specified Analysis Services server instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SuspendAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.SuspendWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Supends the specified Analysis Services server instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            public static void BeginSuspend(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                Task.Factory.StartNew(s => ((IServersOperations)s).BeginSuspendAsync(resourceGroupName, serverName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Supends the specified Analysis Services server instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginSuspendAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginSuspendWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Resumes the specified Analysis Services server instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            public static void Resume(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                Task.Factory.StartNew(s => ((IServersOperations)s).ResumeAsync(resourceGroupName, serverName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resumes the specified Analysis Services server instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResumeAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResumeWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Resumes the specified Analysis Services server instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            public static void BeginResume(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                Task.Factory.StartNew(s => ((IServersOperations)s).BeginResumeAsync(resourceGroupName, serverName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resumes the specified Analysis Services server instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='serverName'>
            /// Name of the Analysis Services server
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginResumeAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginResumeWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all the Analysis Services servers for the given resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            public static IEnumerable<AnalysisServicesServer> ListByResourceGroup(this IServersOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IServersOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Analysis Services servers for the given resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Azure Resource group which a given Analysis Services server is
            /// part of.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<AnalysisServicesServer>> ListByResourceGroupAsync(this IServersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the Analysis Services servers for the given subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<AnalysisServicesServer> List(this IServersOperations operations)
            {
                return Task.Factory.StartNew(s => ((IServersOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the Analysis Services servers for the given subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<AnalysisServicesServer>> ListAsync(this IServersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
