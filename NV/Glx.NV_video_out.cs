
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_COLOR_NV = 0x20C3;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_ALPHA_NV = 0x20C4;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_DEPTH_NV = 0x20C5;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_COLOR_AND_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_COLOR_AND_ALPHA_NV = 0x20C6;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_COLOR_AND_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_COLOR_AND_DEPTH_NV = 0x20C7;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_FRAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_FRAME_NV = 0x20C8;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_FIELD_1_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_FIELD_1_NV = 0x20C9;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_FIELD_2_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_FIELD_2_NV = 0x20CA;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_STACKED_FIELDS_1_2_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_STACKED_FIELDS_1_2_NV = 0x20CB;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_STACKED_FIELDS_2_1_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_STACKED_FIELDS_2_1_NV = 0x20CC;

		/// <summary>
		/// [GLX] glXGetVideoDeviceNV: Binding for glXGetVideoDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numVideoDevices">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pVideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int GetVideoDeviceNV(IntPtr dpy, int screen, int numVideoDevices, IntPtr pVideoDevice)
		{
			int retValue;

			Debug.Assert(Delegates.pglXGetVideoDeviceNV != null, "pglXGetVideoDeviceNV not implemented");
			retValue = Delegates.pglXGetVideoDeviceNV(dpy, screen, numVideoDevices, pVideoDevice);
			LogCommand("glXGetVideoDeviceNV", retValue, dpy, screen, numVideoDevices, pVideoDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXReleaseVideoDeviceNV: Binding for glXReleaseVideoDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="VideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int ReleaseVideoDeviceNV(IntPtr dpy, int screen, IntPtr VideoDevice)
		{
			int retValue;

			Debug.Assert(Delegates.pglXReleaseVideoDeviceNV != null, "pglXReleaseVideoDeviceNV not implemented");
			retValue = Delegates.pglXReleaseVideoDeviceNV(dpy, screen, VideoDevice);
			LogCommand("glXReleaseVideoDeviceNV", retValue, dpy, screen, VideoDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXBindVideoImageNV: Binding for glXBindVideoImageNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="VideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iVideoBuffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int BindVideoImageNV(IntPtr dpy, IntPtr VideoDevice, IntPtr pbuf, int iVideoBuffer)
		{
			int retValue;

			Debug.Assert(Delegates.pglXBindVideoImageNV != null, "pglXBindVideoImageNV not implemented");
			retValue = Delegates.pglXBindVideoImageNV(dpy, VideoDevice, pbuf, iVideoBuffer);
			LogCommand("glXBindVideoImageNV", retValue, dpy, VideoDevice, pbuf, iVideoBuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXReleaseVideoImageNV: Binding for glXReleaseVideoImageNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int ReleaseVideoImageNV(IntPtr dpy, IntPtr pbuf)
		{
			int retValue;

			Debug.Assert(Delegates.pglXReleaseVideoImageNV != null, "pglXReleaseVideoImageNV not implemented");
			retValue = Delegates.pglXReleaseVideoImageNV(dpy, pbuf);
			LogCommand("glXReleaseVideoImageNV", retValue, dpy, pbuf			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXSendPbufferToVideoNV: Binding for glXSendPbufferToVideoNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iBufferType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pulCounterPbuffer">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="bBlock">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int SendPbufferToVideoNV(IntPtr dpy, IntPtr pbuf, int iBufferType, uint[] pulCounterPbuffer, bool bBlock)
		{
			int retValue;

			unsafe {
				fixed (uint* p_pulCounterPbuffer = pulCounterPbuffer)
				{
					Debug.Assert(Delegates.pglXSendPbufferToVideoNV != null, "pglXSendPbufferToVideoNV not implemented");
					retValue = Delegates.pglXSendPbufferToVideoNV(dpy, pbuf, iBufferType, p_pulCounterPbuffer, bBlock);
					LogCommand("glXSendPbufferToVideoNV", retValue, dpy, pbuf, iBufferType, pulCounterPbuffer, bBlock					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXGetVideoInfoNV: Binding for glXGetVideoInfoNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="VideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pulCounterOutputPbuffer">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="pulCounterOutputVideo">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int GetVideoInfoNV(IntPtr dpy, int screen, IntPtr VideoDevice, [Out] uint[] pulCounterOutputPbuffer, [Out] uint[] pulCounterOutputVideo)
		{
			int retValue;

			unsafe {
				fixed (uint* p_pulCounterOutputPbuffer = pulCounterOutputPbuffer)
				fixed (uint* p_pulCounterOutputVideo = pulCounterOutputVideo)
				{
					Debug.Assert(Delegates.pglXGetVideoInfoNV != null, "pglXGetVideoInfoNV not implemented");
					retValue = Delegates.pglXGetVideoInfoNV(dpy, screen, VideoDevice, p_pulCounterOutputPbuffer, p_pulCounterOutputVideo);
					LogCommand("glXGetVideoInfoNV", retValue, dpy, screen, VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GLX_NV_video_out")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXGetVideoDeviceNV(IntPtr dpy, int screen, int numVideoDevices, IntPtr pVideoDevice);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXGetVideoDeviceNV pglXGetVideoDeviceNV;

			[RequiredByFeature("GLX_NV_video_out")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXReleaseVideoDeviceNV(IntPtr dpy, int screen, IntPtr VideoDevice);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXReleaseVideoDeviceNV pglXReleaseVideoDeviceNV;

			[RequiredByFeature("GLX_NV_video_out")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXBindVideoImageNV(IntPtr dpy, IntPtr VideoDevice, IntPtr pbuf, int iVideoBuffer);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXBindVideoImageNV pglXBindVideoImageNV;

			[RequiredByFeature("GLX_NV_video_out")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXReleaseVideoImageNV(IntPtr dpy, IntPtr pbuf);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXReleaseVideoImageNV pglXReleaseVideoImageNV;

			[RequiredByFeature("GLX_NV_video_out")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXSendPbufferToVideoNV(IntPtr dpy, IntPtr pbuf, int iBufferType, uint* pulCounterPbuffer, [MarshalAs(UnmanagedType.I1)] bool bBlock);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXSendPbufferToVideoNV pglXSendPbufferToVideoNV;

			[RequiredByFeature("GLX_NV_video_out")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXGetVideoInfoNV(IntPtr dpy, int screen, IntPtr VideoDevice, uint* pulCounterOutputPbuffer, uint* pulCounterOutputVideo);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXGetVideoInfoNV pglXGetVideoInfoNV;

		}
	}

}
