// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type UserFindMeetingTimesRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserFindMeetingTimesRequestBody
    {
    
        /// <summary>
        /// Gets or sets Attendees.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Attendees", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AttendeeBase> Attendees { get; set; }
    
        /// <summary>
        /// Gets or sets LocationConstraint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "LocationConstraint", Required = Newtonsoft.Json.Required.Default)]
        public LocationConstraint LocationConstraint { get; set; }
    
        /// <summary>
        /// Gets or sets TimeConstraint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "TimeConstraint", Required = Newtonsoft.Json.Required.Default)]
        public TimeConstraint TimeConstraint { get; set; }
    
        /// <summary>
        /// Gets or sets MeetingDuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "MeetingDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration MeetingDuration { get; set; }
    
        /// <summary>
        /// Gets or sets MaxCandidates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "MaxCandidates", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaxCandidates { get; set; }
    
        /// <summary>
        /// Gets or sets IsOrganizerOptional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "IsOrganizerOptional", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsOrganizerOptional { get; set; }
    
        /// <summary>
        /// Gets or sets ReturnSuggestionReasons.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ReturnSuggestionReasons", Required = Newtonsoft.Json.Required.Default)]
        public bool? ReturnSuggestionReasons { get; set; }
    
        /// <summary>
        /// Gets or sets MinimumAttendeePercentage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "MinimumAttendeePercentage", Required = Newtonsoft.Json.Required.Default)]
        public double? MinimumAttendeePercentage { get; set; }
    
    }
}
