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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProgram Request Marshaller
    /// </summary>       
    public class CreateProgramRequestMarshaller : IMarshaller<IRequest, CreateProgramRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProgramRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProgramRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetChannelName())
                throw new AmazonMediaTailorException("Request object does not have required field ChannelName set");
            request.AddPathResource("{channelName}", StringUtils.FromString(publicRequest.ChannelName));
            if (!publicRequest.IsSetProgramName())
                throw new AmazonMediaTailorException("Request object does not have required field ProgramName set");
            request.AddPathResource("{programName}", StringUtils.FromString(publicRequest.ProgramName));
            request.ResourcePath = "/channel/{channelName}/program/{programName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdBreaks())
                {
                    context.Writer.WritePropertyName("AdBreaks");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdBreaksListValue in publicRequest.AdBreaks)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AdBreakMarshaller.Instance;
                        marshaller.Marshall(publicRequestAdBreaksListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetScheduleConfiguration())
                {
                    context.Writer.WritePropertyName("ScheduleConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScheduleConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScheduleConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceLocationName())
                {
                    context.Writer.WritePropertyName("SourceLocationName");
                    context.Writer.Write(publicRequest.SourceLocationName);
                }

                if(publicRequest.IsSetVodSourceName())
                {
                    context.Writer.WritePropertyName("VodSourceName");
                    context.Writer.Write(publicRequest.VodSourceName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateProgramRequestMarshaller _instance = new CreateProgramRequestMarshaller();        

        internal static CreateProgramRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProgramRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}