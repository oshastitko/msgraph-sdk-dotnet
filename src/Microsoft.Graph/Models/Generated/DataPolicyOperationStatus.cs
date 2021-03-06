// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DataPolicyOperationStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DataPolicyOperationStatus
    {
    
        /// <summary>
        /// not Started
        /// </summary>
        NotStarted = 0,
	
        /// <summary>
        /// running
        /// </summary>
        Running = 1,
	
        /// <summary>
        /// complete
        /// </summary>
        Complete = 2,
	
        /// <summary>
        /// failed
        /// </summary>
        Failed = 3,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
