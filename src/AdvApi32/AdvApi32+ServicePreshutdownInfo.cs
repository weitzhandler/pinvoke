﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System.Runtime.InteropServices;

    /// <content>
    /// Contains the <see cref="ServicePreshutdownInfo"/> nested type.
    /// </content>
    public static partial class AdvApi32
    {
        /// <summary>
        /// Contains preshutdown settings
        /// </summary>
        public struct ServicePreshutdownInfo
        {
            /// <summary>
            /// The time-out value, in milliseconds.
            /// </summary>
            public int dwPreshutdownTimeout;
        }
    }
}
