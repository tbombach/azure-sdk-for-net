// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for AlertRulesOperations.
    /// </summary>
    public static partial class AlertRulesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='parameters'>
            /// The parameters of the rule to create or update.
            /// </param>
            public static AlertRuleResource CreateOrUpdate(this IAlertRulesOperations operations, string resourceGroupName, string ruleName, AlertRuleResource parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlertRulesOperations)s).CreateOrUpdateAsync(resourceGroupName, ruleName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='parameters'>
            /// The parameters of the rule to create or update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<AlertRuleResource> CreateOrUpdateAsync(this IAlertRulesOperations operations, string resourceGroupName, string ruleName, AlertRuleResource parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, ruleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static void Delete(this IAlertRulesOperations operations, string resourceGroupName, string ruleName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlertRulesOperations)s).DeleteAsync(resourceGroupName, ruleName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IAlertRulesOperations operations, string resourceGroupName, string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, ruleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static AlertRuleResource Get(this IAlertRulesOperations operations, string resourceGroupName, string ruleName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlertRulesOperations)s).GetAsync(resourceGroupName, ruleName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<AlertRuleResource> GetAsync(this IAlertRulesOperations operations, string resourceGroupName, string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, ruleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the alert rules within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static System.Collections.Generic.IEnumerable<AlertRuleResource> ListByResourceGroup(this IAlertRulesOperations operations, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<AlertRuleResource> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<AlertRuleResource>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlertRulesOperations)s).ListByResourceGroupAsync(resourceGroupName, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the alert rules within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<AlertRuleResource>> ListByResourceGroupAsync(this IAlertRulesOperations operations, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<AlertRuleResource> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<AlertRuleResource>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
