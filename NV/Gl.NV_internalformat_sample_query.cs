
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
		/// [GL] Value of GL_MULTISAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int MULTISAMPLES_NV = 0x9371;

		/// <summary>
		/// [GL] Value of GL_SUPERSAMPLE_SCALE_X_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int SUPERSAMPLE_SCALE_X_NV = 0x9372;

		/// <summary>
		/// [GL] Value of GL_SUPERSAMPLE_SCALE_Y_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int SUPERSAMPLE_SCALE_Y_NV = 0x9373;

		/// <summary>
		/// [GL] Value of GL_CONFORMANT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int CONFORMANT_NV = 0x9374;

		/// <summary>
		/// [GL] glGetInternalformatSampleivNV: Binding for glGetInternalformatSampleivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:InternalFormatPName"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public static void GetInternalformatSampleNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int bufSize, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformatSampleivNV != null, "pglGetInternalformatSampleivNV not implemented");
					Delegates.pglGetInternalformatSampleivNV((int)target, (int)internalformat, samples, (int)pname, bufSize, p_params);
					LogCommand("glGetInternalformatSampleivNV", null, target, internalformat, samples, pname, bufSize, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetInternalformatSampleivNV: Binding for glGetInternalformatSampleivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:InternalFormatPName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public static void GetInternalformatSampleNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformatSampleivNV != null, "pglGetInternalformatSampleivNV not implemented");
					Delegates.pglGetInternalformatSampleivNV((int)target, (int)internalformat, samples, (int)pname, @params.Length, p_params);
					LogCommand("glGetInternalformatSampleivNV", null, target, internalformat, samples, pname, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetInternalformatSampleivNV(int target, int internalformat, int samples, int pname, int bufSize, int* @params);

			[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetInternalformatSampleivNV pglGetInternalformatSampleivNV;

		}
	}

}