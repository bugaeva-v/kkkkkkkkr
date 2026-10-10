using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.U2D
{
	// Token: 0x02000275 RID: 629
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	public static class SpriteDataAccessExtensions
	{
		// Token: 0x06001B3D RID: 6973 RVA: 0x0002BAC4 File Offset: 0x00029CC4
		private static void CheckAttributeTypeMatchesAndThrow<T>(VertexAttribute channel)
		{
			bool flag;
			switch (channel)
			{
			case VertexAttribute.Position:
			case VertexAttribute.Normal:
				flag = (typeof(T) == typeof(Vector3));
				break;
			case VertexAttribute.Tangent:
				flag = (typeof(T) == typeof(Vector4));
				break;
			case VertexAttribute.Color:
				flag = (typeof(T) == typeof(Color32));
				break;
			case VertexAttribute.TexCoord0:
			case VertexAttribute.TexCoord1:
			case VertexAttribute.TexCoord2:
			case VertexAttribute.TexCoord3:
			case VertexAttribute.TexCoord4:
			case VertexAttribute.TexCoord5:
			case VertexAttribute.TexCoord6:
			case VertexAttribute.TexCoord7:
				flag = (typeof(T) == typeof(Vector2));
				break;
			case VertexAttribute.BlendWeight:
				flag = (typeof(T) == typeof(BoneWeight));
				break;
			default:
				throw new InvalidOperationException(string.Format("The requested channel '{0}' is unknown.", channel));
			}
			bool flag2 = !flag;
			if (flag2)
			{
				throw new InvalidOperationException(string.Format("The requested channel '{0}' does not match the return type {1}.", channel, typeof(T).Name));
			}
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0002BBD4 File Offset: 0x00029DD4
		public unsafe static NativeSlice<T> GetVertexAttribute<T>(this Sprite sprite, VertexAttribute channel) where T : struct
		{
			SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<T>(channel);
			SpriteChannelInfo channelInfo = SpriteDataAccessExtensions.GetChannelInfo(sprite, channel);
			byte* dataPointer = (byte*)channelInfo.buffer + channelInfo.offset;
			return NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<T>((void*)dataPointer, channelInfo.stride, channelInfo.count);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0002BC1B File Offset: 0x00029E1B
		public static void SetVertexAttribute<T>(this Sprite sprite, VertexAttribute channel, NativeArray<T> src) where T : struct
		{
			SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<T>(channel);
			SpriteDataAccessExtensions.SetChannelData(sprite, channel, src.GetUnsafeReadOnlyPtr<T>());
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0002BC34 File Offset: 0x00029E34
		public static NativeArray<Matrix4x4> GetBindPoses(this Sprite sprite)
		{
			SpriteChannelInfo bindPoseInfo = SpriteDataAccessExtensions.GetBindPoseInfo(sprite);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(bindPoseInfo.buffer, bindPoseInfo.count, Allocator.Invalid);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0002BC63 File Offset: 0x00029E63
		public static void SetBindPoses(this Sprite sprite, NativeArray<Matrix4x4> src)
		{
			SpriteDataAccessExtensions.SetBindPoseData(sprite, src.GetUnsafeReadOnlyPtr<Matrix4x4>(), src.Length);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0002BC7C File Offset: 0x00029E7C
		public static NativeArray<ushort> GetIndices(this Sprite sprite)
		{
			SpriteChannelInfo indicesInfo = SpriteDataAccessExtensions.GetIndicesInfo(sprite);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ushort>(indicesInfo.buffer, indicesInfo.count, Allocator.Invalid);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0002BCAB File Offset: 0x00029EAB
		public static void SetIndices(this Sprite sprite, NativeArray<ushort> src)
		{
			SpriteDataAccessExtensions.SetIndicesData(sprite, src.GetUnsafeReadOnlyPtr<ushort>(), src.Length);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		public static SpriteBone[] GetBones(this Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetBoneInfo(sprite);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0002BCDC File Offset: 0x00029EDC
		public static void SetBones(this Sprite sprite, SpriteBone[] src)
		{
			SpriteDataAccessExtensions.SetBoneData(sprite, src);
		}

		// Token: 0x06001B46 RID: 6982
		[NativeName("HasChannel")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasVertexAttribute([NotNull("ArgumentNullException")] this Sprite sprite, VertexAttribute channel);

		// Token: 0x06001B47 RID: 6983
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetVertexCount([NotNull("ArgumentNullException")] this Sprite sprite, int count);

		// Token: 0x06001B48 RID: 6984
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetVertexCount([NotNull("ArgumentNullException")] this Sprite sprite);

		// Token: 0x06001B49 RID: 6985 RVA: 0x0002BCE8 File Offset: 0x00029EE8
		private static SpriteChannelInfo GetBindPoseInfo([NotNull("ArgumentNullException")] Sprite sprite)
		{
			SpriteChannelInfo result;
			SpriteDataAccessExtensions.GetBindPoseInfo_Injected(sprite, out result);
			return result;
		}

		// Token: 0x06001B4A RID: 6986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SetBindPoseData([NotNull("ArgumentNullException")] Sprite sprite, void* src, int count);

		// Token: 0x06001B4B RID: 6987 RVA: 0x0002BD00 File Offset: 0x00029F00
		private static SpriteChannelInfo GetIndicesInfo([NotNull("ArgumentNullException")] Sprite sprite)
		{
			SpriteChannelInfo result;
			SpriteDataAccessExtensions.GetIndicesInfo_Injected(sprite, out result);
			return result;
		}

		// Token: 0x06001B4C RID: 6988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SetIndicesData([NotNull("ArgumentNullException")] Sprite sprite, void* src, int count);

		// Token: 0x06001B4D RID: 6989 RVA: 0x0002BD18 File Offset: 0x00029F18
		private static SpriteChannelInfo GetChannelInfo([NotNull("ArgumentNullException")] Sprite sprite, VertexAttribute channel)
		{
			SpriteChannelInfo result;
			SpriteDataAccessExtensions.GetChannelInfo_Injected(sprite, channel, out result);
			return result;
		}

		// Token: 0x06001B4E RID: 6990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SetChannelData([NotNull("ArgumentNullException")] Sprite sprite, VertexAttribute channel, void* src);

		// Token: 0x06001B4F RID: 6991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern SpriteBone[] GetBoneInfo([NotNull("ArgumentNullException")] Sprite sprite);

		// Token: 0x06001B50 RID: 6992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetBoneData([NotNull("ArgumentNullException")] Sprite sprite, SpriteBone[] src);

		// Token: 0x06001B51 RID: 6993
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetPrimaryVertexStreamSize(Sprite sprite);

		// Token: 0x06001B52 RID: 6994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetBindPoseInfo_Injected(Sprite sprite, out SpriteChannelInfo ret);

		// Token: 0x06001B53 RID: 6995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetIndicesInfo_Injected(Sprite sprite, out SpriteChannelInfo ret);

		// Token: 0x06001B54 RID: 6996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetChannelInfo_Injected(Sprite sprite, VertexAttribute channel, out SpriteChannelInfo ret);
	}
}
