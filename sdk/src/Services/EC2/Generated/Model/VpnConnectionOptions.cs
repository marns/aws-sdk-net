/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes VPN connection options.
    /// </summary>
    public partial class VpnConnectionOptions
    {
        private bool? _enableAcceleration;
        private bool? _staticRoutesOnly;
        private List<TunnelOption> _tunnelOptions = new List<TunnelOption>();

        /// <summary>
        /// Gets and sets the property EnableAcceleration. 
        /// <para>
        /// Indicates whether acceleration is enabled for the VPN connection.
        /// </para>
        /// </summary>
        public bool EnableAcceleration
        {
            get { return this._enableAcceleration.GetValueOrDefault(); }
            set { this._enableAcceleration = value; }
        }

        // Check to see if EnableAcceleration property is set
        internal bool IsSetEnableAcceleration()
        {
            return this._enableAcceleration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StaticRoutesOnly. 
        /// <para>
        /// Indicates whether the VPN connection uses static routes only. Static routes must be
        /// used for devices that don't support BGP.
        /// </para>
        /// </summary>
        public bool StaticRoutesOnly
        {
            get { return this._staticRoutesOnly.GetValueOrDefault(); }
            set { this._staticRoutesOnly = value; }
        }

        // Check to see if StaticRoutesOnly property is set
        internal bool IsSetStaticRoutesOnly()
        {
            return this._staticRoutesOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TunnelOptions. 
        /// <para>
        /// Indicates the VPN tunnel options.
        /// </para>
        /// </summary>
        public List<TunnelOption> TunnelOptions
        {
            get { return this._tunnelOptions; }
            set { this._tunnelOptions = value; }
        }

        // Check to see if TunnelOptions property is set
        internal bool IsSetTunnelOptions()
        {
            return this._tunnelOptions != null && this._tunnelOptions.Count > 0; 
        }

    }
}