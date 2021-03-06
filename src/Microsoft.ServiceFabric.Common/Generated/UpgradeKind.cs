// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Common
{
    /// <summary>
    /// Defines values for UpgradeKind.
    /// </summary>
    public enum UpgradeKind
    {
        /// <summary>
        /// Indicates the upgrade kind is invalid. All Service Fabric enumerations have the invalid type. The value is zero.
        /// </summary>
        Invalid,

        /// <summary>
        /// The upgrade progresses one upgrade domain at a time. The value is 1.
        /// </summary>
        Rolling,
    }
}
