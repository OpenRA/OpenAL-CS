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
	public static class ALC10
	{
		private const string nativeLibName = "soft_oal";

		/* typedef int ALenum; */
		public const int ALC_FALSE =			0x0000;
		public const int ALC_TRUE =			0x0001;
		public const int ALC_FREQUENCY =		0x1007;
		public const int ALC_REFRESH =			0x1008;
		public const int ALC_SYNC =			0x1009;

		public const int ALC_NO_ERROR =			0x0000;
		public const int ALC_INVALID_DEVICE =		0xA001;
		public const int ALC_INVALID_CONTEXT =		0xA002;
		public const int ALC_INVALID_ENUM =		0xA003;
		public const int ALC_INVALID_VALUE =		0xA004;
		public const int ALC_OUT_OF_MEMORY =		0xA005;

		public const int ALC_MAJOR_VERSION =		0x1000;
		public const int ALC_MINOR_VERSION =		0x1001;
		public const int ALC_ATTRIBUTES_SIZE =		0x1002;
		public const int ALC_ALL_ATTRIBUTES =		0x1003;
		public const int ALC_DEFAULT_DEVICE_SPECIFIER =	0x1004;
		public const int ALC_DEVICE_SPECIFIER =		0x1005;
		public const int ALC_EXTENSIONS =		0x1006;

		/* IntPtr refers to an ALCcontext*, device to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr alcCreateContext(
			IntPtr device,
			int[] attrList
		);

		/* context refers to an ALCcontext* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool alcMakeContextCurrent(IntPtr context);

		/* context refers to an ALCcontext* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alcDestroyContext(IntPtr context);

		/* IntPtr refers to an ALCcontext* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr alcGetCurrentContext();

		/* IntPtr refers to an ALCdevice*, context to an ALCcontext* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr alcGetContextsDevice(IntPtr context);

		/* IntPtr refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr alcOpenDevice(
			[In()] [MarshalAs(UnmanagedType.LPStr)]
				string devicename
		);

		/* device refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool alcCloseDevice(IntPtr device);

		/* device refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern int alcGetError(IntPtr device);

		/* IntPtr refers to a function pointer, device to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr alcGetProcAddress(
			IntPtr device,
			[In()] [MarshalAs(UnmanagedType.LPStr)]
				string funcname
		);

		/* device refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern int alcGetEnumValue(
			IntPtr device,
			[In()] [MarshalAs(UnmanagedType.LPStr)]
				string enumname
		);

		/* device refers to an ALCdevice* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr alcGetString(IntPtr device, int param);

		/* device refers to an ALCdevice*, size to an ALCsizei */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alcGetIntegerv(
			IntPtr device,
			int param,
			int size,
			int[] values
		);
	}
}
