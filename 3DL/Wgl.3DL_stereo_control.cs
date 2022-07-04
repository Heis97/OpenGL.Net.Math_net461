
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_STEREO_EMITTER_ENABLE_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_EMITTER_ENABLE_3DL = 0x2055;

		/// <summary>
		/// [WGL] Value of WGL_STEREO_EMITTER_DISABLE_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_EMITTER_DISABLE_3DL = 0x2056;

		/// <summary>
		/// [WGL] Value of WGL_STEREO_POLARITY_NORMAL_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_POLARITY_NORMAL_3DL = 0x2057;

		/// <summary>
		/// [WGL] Value of WGL_STEREO_POLARITY_INVERT_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_POLARITY_INVERT_3DL = 0x2058;

		/// <summary>
		/// [WGL] wglSetStereoEmitterState3DL: Binding for wglSetStereoEmitterState3DL.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uState">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public static bool SetStereoEmitter3DL(IntPtr hDC, uint uState)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglSetStereoEmitterState3DL != null, "pwglSetStereoEmitterState3DL not implemented");
			retValue = Delegates.pwglSetStereoEmitterState3DL(hDC, uState);
			LogCommand("wglSetStereoEmitterState3DL", retValue, hDC, uState			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("WGL_3DL_stereo_control")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglSetStereoEmitterState3DL(IntPtr hDC, uint uState);

			[RequiredByFeature("WGL_3DL_stereo_control")]
			internal static wglSetStereoEmitterState3DL pwglSetStereoEmitterState3DL;

		}
	}

}