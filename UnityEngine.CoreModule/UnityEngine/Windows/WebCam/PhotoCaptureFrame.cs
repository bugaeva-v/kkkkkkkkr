using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x020002A7 RID: 679
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
	[MovedFrom("UnityEngine.XR.WSA.WebCam")]
	public sealed class PhotoCaptureFrame : IDisposable
	{
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0002E19F File Offset: 0x0002C39F
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0002E1A7 File Offset: 0x0002C3A7
		public int dataLength { get; private set; }

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0002E1B0 File Offset: 0x0002C3B0
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
		public bool hasLocationData { get; private set; }

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0002E1C1 File Offset: 0x0002C3C1
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0002E1C9 File Offset: 0x0002C3C9
		public CapturePixelFormat pixelFormat { get; private set; }

		// Token: 0x06001CCA RID: 7370
		[ThreadAndSerializationSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetDataLength();

		// Token: 0x06001CCB RID: 7371
		[ThreadAndSerializationSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool GetHasLocationData();

		// Token: 0x06001CCC RID: 7372
		[ThreadAndSerializationSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern CapturePixelFormat GetCapturePixelFormat();

		// Token: 0x06001CCD RID: 7373 RVA: 0x0002E1D4 File Offset: 0x0002C3D4
		public bool TryGetCameraToWorldMatrix(out Matrix4x4 cameraToWorldMatrix)
		{
			cameraToWorldMatrix = Matrix4x4.identity;
			bool hasLocationData = this.hasLocationData;
			bool result;
			if (hasLocationData)
			{
				cameraToWorldMatrix = this.GetCameraToWorldMatrix();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0002E210 File Offset: 0x0002C410
		[NativeConditional("PLATFORM_WIN && !PLATFORM_XBOXONE", "Matrix4x4f()")]
		[NativeName("GetCameraToWorld")]
		[ThreadAndSerializationSafe]
		private Matrix4x4 GetCameraToWorldMatrix()
		{
			Matrix4x4 result;
			this.GetCameraToWorldMatrix_Injected(out result);
			return result;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0002E228 File Offset: 0x0002C428
		public bool TryGetProjectionMatrix(out Matrix4x4 projectionMatrix)
		{
			bool hasLocationData = this.hasLocationData;
			bool result;
			if (hasLocationData)
			{
				projectionMatrix = this.GetProjection();
				result = true;
			}
			else
			{
				projectionMatrix = Matrix4x4.identity;
				result = false;
			}
			return result;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0002E264 File Offset: 0x0002C464
		public bool TryGetProjectionMatrix(float nearClipPlane, float farClipPlane, out Matrix4x4 projectionMatrix)
		{
			bool hasLocationData = this.hasLocationData;
			bool result;
			if (hasLocationData)
			{
				float num = 0.01f;
				bool flag = nearClipPlane < num;
				if (flag)
				{
					nearClipPlane = num;
				}
				bool flag2 = farClipPlane < nearClipPlane + num;
				if (flag2)
				{
					farClipPlane = nearClipPlane + num;
				}
				projectionMatrix = this.GetProjection();
				float num2 = 1f / (farClipPlane - nearClipPlane);
				float m = -(farClipPlane + nearClipPlane) * num2;
				float m2 = -(2f * farClipPlane * nearClipPlane) * num2;
				projectionMatrix.m22 = m;
				projectionMatrix.m23 = m2;
				result = true;
			}
			else
			{
				projectionMatrix = Matrix4x4.identity;
				result = false;
			}
			return result;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0002E2F8 File Offset: 0x0002C4F8
		[NativeConditional("PLATFORM_WIN && !PLATFORM_XBOXONE", "Matrix4x4f()")]
		[ThreadAndSerializationSafe]
		private Matrix4x4 GetProjection()
		{
			Matrix4x4 result;
			this.GetProjection_Injected(out result);
			return result;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0002E310 File Offset: 0x0002C510
		public void UploadImageDataToTexture(Texture2D targetTexture)
		{
			bool flag = targetTexture == null;
			if (flag)
			{
				throw new ArgumentNullException("targetTexture");
			}
			bool flag2 = this.pixelFormat > CapturePixelFormat.BGRA32;
			if (flag2)
			{
				throw new ArgumentException("Uploading PhotoCaptureFrame to a texture is only supported with BGRA32 CameraFrameFormat!");
			}
			this.UploadImageDataToTexture_Internal(targetTexture);
		}

		// Token: 0x06001CD3 RID: 7379
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[NativeName("UploadImageDataToTexture")]
		[ThreadAndSerializationSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void UploadImageDataToTexture_Internal(Texture2D targetTexture);

		// Token: 0x06001CD4 RID: 7380
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[ThreadAndSerializationSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern IntPtr GetUnsafePointerToBuffer();

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0002E358 File Offset: 0x0002C558
		public void CopyRawImageDataIntoBuffer(List<byte> byteBuffer)
		{
			bool flag = byteBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("byteBuffer");
			}
			byte[] array = new byte[this.dataLength];
			this.CopyRawImageDataIntoBuffer_Internal(array);
			bool flag2 = byteBuffer.Capacity < array.Length;
			if (flag2)
			{
				byteBuffer.Capacity = array.Length;
			}
			byteBuffer.Clear();
			byteBuffer.AddRange(array);
		}

		// Token: 0x06001CD6 RID: 7382
		[ThreadAndSerializationSafe]
		[NativeName("CopyRawImageDataIntoBuffer")]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void CopyRawImageDataIntoBuffer_Internal([Out] byte[] byteArray);

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0002E3B8 File Offset: 0x0002C5B8
		internal PhotoCaptureFrame(IntPtr nativePtr)
		{
			this.m_NativePtr = nativePtr;
			this.dataLength = this.GetDataLength();
			this.hasLocationData = this.GetHasLocationData();
			this.pixelFormat = this.GetCapturePixelFormat();
			GC.AddMemoryPressure((long)this.dataLength);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0002E408 File Offset: 0x0002C608
		private void Cleanup()
		{
			bool flag = this.m_NativePtr != IntPtr.Zero;
			if (flag)
			{
				GC.RemoveMemoryPressure((long)this.dataLength);
				this.Dispose_Internal();
				this.m_NativePtr = IntPtr.Zero;
			}
		}

		// Token: 0x06001CD9 RID: 7385
		[ThreadAndSerializationSafe]
		[NativeName("Dispose")]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Dispose_Internal();

		// Token: 0x06001CDA RID: 7386 RVA: 0x0002E44B File Offset: 0x0002C64B
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0002E45C File Offset: 0x0002C65C
		~PhotoCaptureFrame()
		{
			this.Cleanup();
		}

		// Token: 0x06001CDC RID: 7388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetCameraToWorldMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x06001CDD RID: 7389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetProjection_Injected(out Matrix4x4 ret);

		// Token: 0x04000968 RID: 2408
		private IntPtr m_NativePtr;
	}
}
