// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [LibraryImport(Libraries.SystemNative, EntryPoint = "SystemNative_PlatformSupportsDualModeIPv4PacketInfo")]
        [SuppressGCTransition]
        internal static partial int PlatformSupportsDualModeIPv4PacketInfo();
    }
}
