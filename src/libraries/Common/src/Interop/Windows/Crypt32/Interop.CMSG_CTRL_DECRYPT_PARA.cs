// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct CMSG_CTRL_DECRYPT_PARA
        {
            internal int cbSize;
            internal IntPtr hKey;
            internal CryptKeySpec dwKeySpec;
            internal int dwRecipientIndex;
        }
    }
}
