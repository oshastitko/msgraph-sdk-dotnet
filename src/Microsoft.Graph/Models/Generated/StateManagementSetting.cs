// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum StateManagementSetting.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum StateManagementSetting
    {
    
        /// <summary>
        /// not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// blocked
        /// </summary>
        Blocked = 1,
	
        /// <summary>
        /// allowed
        /// </summary>
        Allowed = 2,
	
    }
}
