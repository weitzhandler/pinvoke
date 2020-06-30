﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System.Runtime.InteropServices;

    /// <content>
    /// Contains the <see cref="ServiceDelayedAutoStartInfo"/> nested type.
    /// </content>
    public static partial class AdvApi32
    {
        /// <summary>
        /// Contains the delayed auto-start setting of an auto-start service.
        /// </summary>
        public struct ServiceDelayedAutoStartInfo
        {
            /// <summary>
            /// If this member is TRUE, the service is started after other auto-start services are started plus a short delay.
            /// Otherwise, the service is started during system boot.
            /// This setting is ignored unless the service is an auto-start service.
            /// </summary>
            public bool fDelayedAutostart;
        }
    }
}
