/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElastiCache.Model;
using Amazon.ElastiCache.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache
{
    /// <summary>
    /// Implementation for accessing AmazonElastiCache.
    /// 
    /// 
    /// </summary>
	public partial class AmazonElastiCacheClient : AmazonWebServiceClient, Amazon.ElastiCache.IAmazonElastiCache
    {

        QueryStringSigner signer = new QueryStringSigner();
        #region Constructors

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElastiCacheClient(AWSCredentials credentials)
            : this(credentials, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElastiCacheConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials and an
        /// AmazonElastiCacheClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(AWSCredentials credentials, AmazonElastiCacheConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElastiCacheConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElastiCacheConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElastiCacheConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="authorizeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        /// AuthorizeCacheSecurityGroupIngress service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the AuthorizeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AuthorizeCacheSecurityGroupIngressResponse> AuthorizeCacheSecurityGroupIngressAsync(AuthorizeCacheSecurityGroupIngressRequest authorizeCacheSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeCacheSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AuthorizeCacheSecurityGroupIngressRequest, AuthorizeCacheSecurityGroupIngressResponse>(authorizeCacheSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ClusterQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateCacheClusterResponse> CreateCacheClusterAsync(CreateCacheClusterRequest createCacheClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheClusterRequestMarshaller();
            var unmarshaller = CreateCacheClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCacheClusterRequest, CreateCacheClusterResponse>(createCacheClusterRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createCacheParameterGroupRequest">Container for the necessary parameters to execute the CreateCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateCacheParameterGroupResponse> CreateCacheParameterGroupAsync(CreateCacheParameterGroupRequest createCacheParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheParameterGroupRequestMarshaller();
            var unmarshaller = CreateCacheParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCacheParameterGroupRequest, CreateCacheParameterGroupResponse>(createCacheParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createCacheSecurityGroupRequest">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateCacheSecurityGroupResponse> CreateCacheSecurityGroupAsync(CreateCacheSecurityGroupRequest createCacheSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheSecurityGroupRequestMarshaller();
            var unmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCacheSecurityGroupRequest, CreateCacheSecurityGroupResponse>(createCacheSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createCacheSubnetGroupRequest">Container for the necessary parameters to execute the CreateCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSubnetException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateCacheSubnetGroupResponse> CreateCacheSubnetGroupAsync(CreateCacheSubnetGroupRequest createCacheSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheSubnetGroupRequestMarshaller();
            var unmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateCacheSubnetGroupRequest, CreateCacheSubnetGroupResponse>(createCacheSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteCacheClusterRequest">Container for the necessary parameters to execute the DeleteCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteCacheClusterResponse> DeleteCacheClusterAsync(DeleteCacheClusterRequest deleteCacheClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheClusterRequestMarshaller();
            var unmarshaller = DeleteCacheClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCacheClusterRequest, DeleteCacheClusterResponse>(deleteCacheClusterRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteCacheParameterGroupRequest">Container for the necessary parameters to execute the DeleteCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteCacheParameterGroupResponse> DeleteCacheParameterGroupAsync(DeleteCacheParameterGroupRequest deleteCacheParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheParameterGroupRequestMarshaller();
            var unmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCacheParameterGroupRequest, DeleteCacheParameterGroupResponse>(deleteCacheParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteCacheSecurityGroupRequest">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteCacheSecurityGroupResponse> DeleteCacheSecurityGroupAsync(DeleteCacheSecurityGroupRequest deleteCacheSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCacheSecurityGroupRequest, DeleteCacheSecurityGroupResponse>(deleteCacheSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteCacheSubnetGroupRequest">Container for the necessary parameters to execute the DeleteCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupInUseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteCacheSubnetGroupResponse> DeleteCacheSubnetGroupAsync(DeleteCacheSubnetGroupRequest deleteCacheSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteCacheSubnetGroupRequest, DeleteCacheSubnetGroupResponse>(deleteCacheSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCacheClustersRequest">Container for the necessary parameters to execute the DescribeCacheClusters service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(DescribeCacheClustersRequest describeCacheClustersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheClustersRequestMarshaller();
            var unmarshaller = DescribeCacheClustersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheClustersRequest, DescribeCacheClustersResponse>(describeCacheClustersRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCacheEngineVersionsRequest">Container for the necessary parameters to execute the DescribeCacheEngineVersions service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(DescribeCacheEngineVersionsRequest describeCacheEngineVersionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeCacheEngineVersionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheEngineVersionsRequest, DescribeCacheEngineVersionsResponse>(describeCacheEngineVersionsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCacheParameterGroupsRequest">Container for the necessary parameters to execute the DescribeCacheParameterGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(DescribeCacheParameterGroupsRequest describeCacheParameterGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheParameterGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheParameterGroupsRequest, DescribeCacheParameterGroupsResponse>(describeCacheParameterGroupsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCacheParametersRequest">Container for the necessary parameters to execute the DescribeCacheParameters service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCacheParametersResponse> DescribeCacheParametersAsync(DescribeCacheParametersRequest describeCacheParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheParametersRequestMarshaller();
            var unmarshaller = DescribeCacheParametersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheParametersRequest, DescribeCacheParametersResponse>(describeCacheParametersRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCacheSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheSecurityGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheSecurityGroupsRequest, DescribeCacheSecurityGroupsResponse>(describeCacheSecurityGroupsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeCacheSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(DescribeCacheSubnetGroupsRequest describeCacheSubnetGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCacheSubnetGroupsRequest, DescribeCacheSubnetGroupsResponse>(describeCacheSubnetGroupsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        /// service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEngineDefaultParametersRequest, DescribeEngineDefaultParametersResponse>(describeEngineDefaultParametersRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEventsRequest, DescribeEventsResponse>(describeEventsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesRequest">Container for the necessary parameters to execute the DescribeReservedCacheNodes service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(DescribeReservedCacheNodesRequest describeReservedCacheNodesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedCacheNodesRequestMarshaller();
            var unmarshaller = DescribeReservedCacheNodesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReservedCacheNodesRequest, DescribeReservedCacheNodesResponse>(describeReservedCacheNodesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesOfferingsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedCacheNodesOfferings service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(DescribeReservedCacheNodesOfferingsRequest describeReservedCacheNodesOfferingsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedCacheNodesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReservedCacheNodesOfferingsRequest, DescribeReservedCacheNodesOfferingsResponse>(describeReservedCacheNodesOfferingsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="modifyCacheClusterRequest">Container for the necessary parameters to execute the ModifyCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ModifyCacheClusterResponse> ModifyCacheClusterAsync(ModifyCacheClusterRequest modifyCacheClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheClusterRequestMarshaller();
            var unmarshaller = ModifyCacheClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyCacheClusterRequest, ModifyCacheClusterResponse>(modifyCacheClusterRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="modifyCacheParameterGroupRequest">Container for the necessary parameters to execute the ModifyCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ModifyCacheParameterGroupResponse> ModifyCacheParameterGroupAsync(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheParameterGroupRequestMarshaller();
            var unmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyCacheParameterGroupRequest, ModifyCacheParameterGroupResponse>(modifyCacheParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="modifyCacheSubnetGroupRequest">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SubnetInUseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ModifyCacheSubnetGroupResponse> ModifyCacheSubnetGroupAsync(ModifyCacheSubnetGroupRequest modifyCacheSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyCacheSubnetGroupRequest, ModifyCacheSubnetGroupResponse>(modifyCacheSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="purchaseReservedCacheNodesOfferingRequest">Container for the necessary parameters to execute the
        /// PurchaseReservedCacheNodesOffering service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the PurchaseReservedCacheNodesOffering service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<PurchaseReservedCacheNodesOfferingResponse> PurchaseReservedCacheNodesOfferingAsync(PurchaseReservedCacheNodesOfferingRequest purchaseReservedCacheNodesOfferingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedCacheNodesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PurchaseReservedCacheNodesOfferingRequest, PurchaseReservedCacheNodesOfferingResponse>(purchaseReservedCacheNodesOfferingRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="rebootCacheClusterRequest">Container for the necessary parameters to execute the RebootCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RebootCacheClusterResponse> RebootCacheClusterAsync(RebootCacheClusterRequest rebootCacheClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootCacheClusterRequestMarshaller();
            var unmarshaller = RebootCacheClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RebootCacheClusterRequest, RebootCacheClusterResponse>(rebootCacheClusterRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="resetCacheParameterGroupRequest">Container for the necessary parameters to execute the ResetCacheParameterGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ResetCacheParameterGroupResponse> ResetCacheParameterGroupAsync(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetCacheParameterGroupRequestMarshaller();
            var unmarshaller = ResetCacheParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ResetCacheParameterGroupRequest, ResetCacheParameterGroupResponse>(resetCacheParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="revokeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress
        /// service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RevokeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.AuthorizationNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RevokeCacheSecurityGroupIngressResponse> RevokeCacheSecurityGroupIngressAsync(RevokeCacheSecurityGroupIngressRequest revokeCacheSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeCacheSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RevokeCacheSecurityGroupIngressRequest, RevokeCacheSecurityGroupIngressResponse>(revokeCacheSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
