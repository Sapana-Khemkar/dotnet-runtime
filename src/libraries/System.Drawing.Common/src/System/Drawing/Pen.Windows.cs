// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Gdip = System.Drawing.SafeNativeMethods.Gdip;

namespace System.Drawing
{
    public partial class Pen
    {
        /// <summary>
        /// Gets or sets a custom cap style to use at the beginning of lines drawn with this <see cref='Pen'/>.
        /// </summary>
        public CustomLineCap CustomStartCap
        {
            get
            {
                IntPtr lineCap;
                int status = Gdip.GdipGetPenCustomStartCap(new HandleRef(this, NativePen), out lineCap);
                Gdip.CheckStatus(status);

                return CustomLineCap.CreateCustomLineCapObject(lineCap);
            }
            set
            {
                if (_immutable)
                {
                    throw new ArgumentException(SR.Format(SR.CantChangeImmutableObjects, nameof(Pen)));
                }

                int status = Gdip.GdipSetPenCustomStartCap(new HandleRef(this, NativePen),
                                                              new HandleRef(value, (value == null) ? IntPtr.Zero : value.nativeCap));
                Gdip.CheckStatus(status);
            }
        }

        /// <summary>
        /// Gets or sets a custom cap style to use at the end of lines drawn with this <see cref='Pen'/>.
        /// </summary>
        public CustomLineCap CustomEndCap
        {
            get
            {
                IntPtr lineCap;
                int status = Gdip.GdipGetPenCustomEndCap(new HandleRef(this, NativePen), out lineCap);
                Gdip.CheckStatus(status);
                return CustomLineCap.CreateCustomLineCapObject(lineCap);
            }
            set
            {
                if (_immutable)
                {
                    throw new ArgumentException(SR.Format(SR.CantChangeImmutableObjects, nameof(Pen)));
                }

                int status = Gdip.GdipSetPenCustomEndCap(
                    new HandleRef(this, NativePen),
                    new HandleRef(value, (value == null) ? IntPtr.Zero : value.nativeCap));
                Gdip.CheckStatus(status);
            }
        }
    }
}
