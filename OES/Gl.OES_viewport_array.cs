
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] glDepthRangeArrayfvOES: Binding for glDepthRangeArrayfvOES.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void DepthRangeArrayOES(uint first, int count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayfvOES != null, "pglDepthRangeArrayfvOES not implemented");
					Delegates.pglDepthRangeArrayfvOES(first, count, p_v);
					LogCommand("glDepthRangeArrayfvOES", null, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDepthRangeIndexedfOES: Binding for glDepthRangeIndexedfOES.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void DepthRangeIndexedOES(uint index, float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexedfOES != null, "pglDepthRangeIndexedfOES not implemented");
			Delegates.pglDepthRangeIndexedfOES(index, n, f);
			LogCommand("glDepthRangeIndexedfOES", null, index, n, f			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDepthRangeArrayfvOES(uint first, int count, float* v);

			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glDepthRangeArrayfvOES pglDepthRangeArrayfvOES;

			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDepthRangeIndexedfOES(uint index, float n, float f);

			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glDepthRangeIndexedfOES pglDepthRangeIndexedfOES;

		}
	}

}
