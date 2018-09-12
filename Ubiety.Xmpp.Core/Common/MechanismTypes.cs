﻿// Copyright 2018 Dieter Lunn
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;

namespace Ubiety.Xmpp.Core.Common
{
    /// <summary>
    ///     Type of authentication mechanmism
    /// </summary>
    [Flags]
    public enum MechanismTypes
    {
        /// <summary>
        ///     No authentication mechanism
        /// </summary>
        None,

        /// <summary>
        ///     Plain authentication
        /// </summary>
        Plain = 1 << 0,

        /// <summary>
        ///     DigestMD5 authentication
        /// </summary>
        DigestMd5 = 1 << 1,

        /// <summary>
        ///     External authentication
        /// </summary>
        External = 1 << 2,

        /// <summary>
        ///     SCRAM-SHA-1 authentication
        /// </summary>
        Scram = 1 << 3,

        /// <summary>
        ///     SCRAM-SHA-1-PLUS authentication
        /// </summary>
        ScramPlus = 1 << 4,

        /// <summary>
        ///     Default authentication methods - Currently SCRAM-SHA-1 and SCRAM-SHA-1-PLUS
        /// </summary>
        Default = Scram | ScramPlus
    }
}