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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Provides summary information about a transcription job.
    /// </summary>
    public partial class MedicalTranscriptionJobSummary
    {
        private DateTime? _completionTime;
        private MedicalContentIdentificationType _contentIdentificationType;
        private DateTime? _creationTime;
        private string _failureReason;
        private LanguageCode _languageCode;
        private string _medicalTranscriptionJobName;
        private OutputLocationType _outputLocationType;
        private Specialty _specialty;
        private DateTime? _startTime;
        private TranscriptionJobStatus _transcriptionJobStatus;
        private Type _type;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// A timestamp that shows when the job was completed.
        /// </para>
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Shows the type of information you've configured Amazon Transcribe Medical to identify
        /// in a transcription job. If the value is <code>PHI</code>, you've configured the transcription
        /// job to identify personal health information (PHI).
        /// </para>
        /// </summary>
        public MedicalContentIdentificationType ContentIdentificationType
        {
            get { return this._contentIdentificationType; }
            set { this._contentIdentificationType = value; }
        }

        // Check to see if ContentIdentificationType property is set
        internal bool IsSetContentIdentificationType()
        {
            return this._contentIdentificationType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the medical transcription job was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the <code>TranscriptionJobStatus</code> field is <code>FAILED</code>, a description
        /// of the error.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of the transcript in the source audio file.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property MedicalTranscriptionJobName. 
        /// <para>
        /// The name of a medical transcription job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string MedicalTranscriptionJobName
        {
            get { return this._medicalTranscriptionJobName; }
            set { this._medicalTranscriptionJobName = value; }
        }

        // Check to see if MedicalTranscriptionJobName property is set
        internal bool IsSetMedicalTranscriptionJobName()
        {
            return this._medicalTranscriptionJobName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocationType. 
        /// <para>
        /// Indicates the location of the transcription job's output. This field must be the path
        /// of an S3 bucket; if you don't already have an S3 bucket, one is created based on the
        /// path you add.
        /// </para>
        /// </summary>
        public OutputLocationType OutputLocationType
        {
            get { return this._outputLocationType; }
            set { this._outputLocationType = value; }
        }

        // Check to see if OutputLocationType property is set
        internal bool IsSetOutputLocationType()
        {
            return this._outputLocationType != null;
        }

        /// <summary>
        /// Gets and sets the property Specialty. 
        /// <para>
        /// The medical specialty of the transcription job. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/transcribe-medical-conversation.html">Transcribing
        /// a medical conversation</a>for a list of supported specialties.
        /// </para>
        /// </summary>
        public Specialty Specialty
        {
            get { return this._specialty; }
            set { this._specialty = value; }
        }

        // Check to see if Specialty property is set
        internal bool IsSetSpecialty()
        {
            return this._specialty != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A timestamp that shows when the job began processing.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TranscriptionJobStatus. 
        /// <para>
        /// The status of the medical transcription job.
        /// </para>
        /// </summary>
        public TranscriptionJobStatus TranscriptionJobStatus
        {
            get { return this._transcriptionJobStatus; }
            set { this._transcriptionJobStatus = value; }
        }

        // Check to see if TranscriptionJobStatus property is set
        internal bool IsSetTranscriptionJobStatus()
        {
            return this._transcriptionJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The speech of the clinician in the input audio.
        /// </para>
        /// </summary>
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}