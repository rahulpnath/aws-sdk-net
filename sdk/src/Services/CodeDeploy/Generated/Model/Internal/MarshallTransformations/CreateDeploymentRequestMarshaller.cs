/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDeployment Request Marshaller
    /// </summary>       
    public class CreateDeploymentRequestMarshaller : IMarshaller<IRequest, CreateDeploymentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeploymentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeDeploy");
            string target = "CodeDeploy_20141006.CreateDeployment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationName())
                {
                    context.Writer.WritePropertyName("applicationName");
                    context.Writer.Write(publicRequest.ApplicationName);
                }

                if(publicRequest.IsSetAutoRollbackConfiguration())
                {
                    context.Writer.WritePropertyName("autoRollbackConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoRollbackConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoRollbackConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeploymentConfigName())
                {
                    context.Writer.WritePropertyName("deploymentConfigName");
                    context.Writer.Write(publicRequest.DeploymentConfigName);
                }

                if(publicRequest.IsSetDeploymentGroupName())
                {
                    context.Writer.WritePropertyName("deploymentGroupName");
                    context.Writer.Write(publicRequest.DeploymentGroupName);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetFileExistsBehavior())
                {
                    context.Writer.WritePropertyName("fileExistsBehavior");
                    context.Writer.Write(publicRequest.FileExistsBehavior);
                }

                if(publicRequest.IsSetIgnoreApplicationStopFailures())
                {
                    context.Writer.WritePropertyName("ignoreApplicationStopFailures");
                    context.Writer.Write(publicRequest.IgnoreApplicationStopFailures);
                }

                if(publicRequest.IsSetRevision())
                {
                    context.Writer.WritePropertyName("revision");
                    context.Writer.WriteObjectStart();

                    var marshaller = RevisionLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Revision, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTargetInstances())
                {
                    context.Writer.WritePropertyName("targetInstances");
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetInstancesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TargetInstances, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUpdateOutdatedInstancesOnly())
                {
                    context.Writer.WritePropertyName("updateOutdatedInstancesOnly");
                    context.Writer.Write(publicRequest.UpdateOutdatedInstancesOnly);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDeploymentRequestMarshaller _instance = new CreateDeploymentRequestMarshaller();        

        internal static CreateDeploymentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDeploymentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}