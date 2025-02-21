#region License
/* OpenAL# - C# Wrapper for OpenAL Soft
 *
 * Copyright (c) 2014-2015 Ethan Lee
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. If you use this software in a
 * product, an acknowledgment in the product documentation would be
 * appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 * misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 *
 * Ethan "flibitijibibo" Lee <flibitijibibo@flibitijibibo.com>
 *
 */
#endregion

#region Using Statements
using System;
using System.Runtime.InteropServices;
#endregion

namespace OpenAL
{
	public static class ALC11
	{
		private const string nativeLibName = "soft_oal";

		/* typedef int ALenum */
		public const int ALC_MONO_SOURCES =			0x1010;
		public const int ALC_STEREO_SOURCES =			0x1011;

		public const int ALC_CAPTURE_DEVICE_SPECIFIER =		0x0310;
		public const int ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER =	0x0311;
		public const int ALC_CAPTURE_SAMPLES =			0x0312;
		public const int ALC_DEFAULT_ALL_DEVICES_SPECIFIER =	0x1012;
		public const int ALC_ALL_DEVICES_SPECIFIER =		0x1013;

		/* context refers to an ALCcontext* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alcProcessContext(IntPtr context);

		/* context refers to an ALCcontext* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alcSuspendContext(IntPtr context);

		/* device refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool alcIsExtensionPresent(
			IntPtr device,
			[In()] [MarshalAs(UnmanagedType.LPStr)]
				string extname
		);

		/* IntPtr refers to an ALCdevice*, buffersize to an ALCsizei */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr alcCaptureOpenDevice(
			[In()] [MarshalAs(UnmanagedType.LPStr)]
				string devicename,
			uint frequency,
			int format,
			int buffersize
		);

		/* device refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool alcCaptureCloseDevice(IntPtr device);

		/* device refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alcCaptureStart(IntPtr device);

		/* device refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alcCaptureStop(IntPtr device);

		/* device refers to an ALCdevice*, samples to an ALCsizei */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alcCaptureSamples(
			IntPtr device,
			IntPtr buffer,
			int samples
		);
	}
}
