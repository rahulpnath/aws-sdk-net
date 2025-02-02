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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeType operation.
    /// Returns detailed information about an extension that has been registered.
    /// 
    ///  
    /// <para>
    /// If you specify a <code>VersionId</code>, <code>DescribeType</code> returns information
    /// about that specific extension version. Otherwise, it returns information about the
    /// default extension version.
    /// </para>
    /// </summary>
    public partial class DescribeTypeRequest : AmazonCloudFormationRequest
    {
        private string _arn;
        private string _publicVersionNumber;
        private string _publisherId;
        private RegistryType _type;
        private string _typeName;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>TypeName</code> and <code>Type</code>,
        /// or <code>Arn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property PublicVersionNumber. 
        /// <para>
        /// The version number of a public third-party extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5)]
        public string PublicVersionNumber
        {
            get { return this._publicVersionNumber; }
            set { this._publicVersionNumber = value; }
        }

        // Check to see if PublicVersionNumber property is set
        internal bool IsSetPublicVersionNumber()
        {
            return this._publicVersionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The publisher ID of the extension publisher.
        /// </para>
        ///  
        /// <para>
        /// Extensions provided by Amazon are not assigned a publisher ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string PublisherId
        {
            get { return this._publisherId; }
            set { this._publisherId = value; }
        }

        // Check to see if PublisherId property is set
        internal bool IsSetPublisherId()
        {
            return this._publisherId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>TypeName</code> and <code>Type</code>,
        /// or <code>Arn</code>.
        /// </para>
        /// </summary>
        public RegistryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>TypeName</code> and <code>Type</code>,
        /// or <code>Arn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=204)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of a specific version of the extension. The version ID is the value at the
        /// end of the Amazon Resource Name (ARN) assigned to the extension version when it is
        /// registered.
        /// </para>
        ///  
        /// <para>
        /// If you specify a <code>VersionId</code>, <code>DescribeType</code> returns information
        /// about that specific extension version. Otherwise, it returns information about the
        /// default extension version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}