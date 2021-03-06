// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum IosNotificationAlertType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum IosNotificationAlertType
    {
    
        /// <summary>
        /// device Default
        /// </summary>
        DeviceDefault = 0,
	
        /// <summary>
        /// banner
        /// </summary>
        Banner = 1,
	
        /// <summary>
        /// modal
        /// </summary>
        Modal = 2,
	
        /// <summary>
        /// none
        /// </summary>
        None = 3,
	
    }
}
