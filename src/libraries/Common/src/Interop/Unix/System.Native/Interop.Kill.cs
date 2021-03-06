// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        internal enum Signals : int
        {
            None = 0,
            SIGKILL = 9,
            SIGSTOP = 19
        }

        [LibraryImport(Libraries.SystemNative, EntryPoint = "SystemNative_Kill", SetLastError = true)]
        internal static partial int Kill(int pid, Signals signal);
    }
}
