// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [LibraryImport(Libraries.SystemNative, EntryPoint = "SystemNative_Receive")]
        internal static unsafe partial Error Receive(SafeHandle socket, byte* buffer, int bufferLen, SocketFlags flags, int* received);
    }
}
