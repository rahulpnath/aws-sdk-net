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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CertificateManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CertificateManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestCertificate Request Marshaller
    /// </summary>       
    public class RequestCertificateRequestMarshaller : IMarshaller<IRequest, RequestCertificateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestCertificateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RequestCertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CertificateManager");
            string target = "CertificateManager.RequestCertificate";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-12-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificateAuthorityArn())
                {
                    context.Writer.WritePropertyName("CertificateAuthorityArn");
                    context.Writer.Write(publicRequest.CertificateAuthorityArn);
                }

                if(publicRequest.IsSetDomainName())
                {
                    context.Writer.WritePropertyName("DomainName");
                    context.Writer.Write(publicRequest.DomainName);
                }

                if(publicRequest.IsSetDomainValidationOptions())
                {
                    context.Writer.WritePropertyName("DomainValidationOptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDomainValidationOptionsListValue in publicRequest.DomainValidationOptions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DomainValidationOptionMarshaller.Instance;
                        marshaller.Marshall(publicRequestDomainValidationOptionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                if(publicRequest.IsSetOptions())
                {
                    context.Writer.WritePropertyName("Options");
                    context.Writer.WriteObjectStart();

                    var marshaller = CertificateOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Options, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSubjectAlternativeNames())
                {
                    context.Writer.WritePropertyName("SubjectAlternativeNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubjectAlternativeNamesListValue in publicRequest.SubjectAlternativeNames)
                    {
                            context.Writer.Write(publicRequestSubjectAlternativeNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetValidationMethod())
                {
                    context.Writer.WritePropertyName("ValidationMethod");
                    context.Writer.Write(publicRequest.ValidationMethod);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RequestCertificateRequestMarshaller _instance = new RequestCertificateRequestMarshaller();        

        internal static RequestCertificateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestCertificateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}