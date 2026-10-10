using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000F1 RID: 241
	[NativeHeader("Runtime/Misc/Cache.h")]
	[StaticAccessor("CacheWrapper", StaticAccessorType.DoubleColon)]
	public struct Cache : IEquatable<Cache>
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00007030 File Offset: 0x00005230
		internal int handle
		{
			get
			{
				return this.m_Handle;
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00007048 File Offset: 0x00005248
		public static bool operator ==(Cache lhs, Cache rhs)
		{
			return lhs.handle == rhs.handle;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000706C File Offset: 0x0000526C
		public static bool operator !=(Cache lhs, Cache rhs)
		{
			return lhs.handle != rhs.handle;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00007094 File Offset: 0x00005294
		public override int GetHashCode()
		{
			return this.m_Handle;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000070AC File Offset: 0x000052AC
		public override bool Equals(object other)
		{
			return other is Cache && this.Equals((Cache)other);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000070D8 File Offset: 0x000052D8
		public bool Equals(Cache other)
		{
			return this.handle == other.handle;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x000070FC File Offset: 0x000052FC
		public bool valid
		{
			get
			{
				return Cache.Cache_IsValid(this.m_Handle);
			}
		}

		// Token: 0x06000458 RID: 1112
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Cache_IsValid(int handle);

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000711C File Offset: 0x0000531C
		public bool ready
		{
			get
			{
				return Cache.Cache_IsReady(this.m_Handle);
			}
		}

		// Token: 0x0600045A RID: 1114
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Cache_IsReady(int handle);

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000713C File Offset: 0x0000533C
		public bool readOnly
		{
			get
			{
				return Cache.Cache_IsReadonly(this.m_Handle);
			}
		}

		// Token: 0x0600045C RID: 1116
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Cache_IsReadonly(int handle);

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000715C File Offset: 0x0000535C
		public string path
		{
			get
			{
				return Cache.Cache_GetPath(this.m_Handle);
			}
		}

		// Token: 0x0600045E RID: 1118
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Cache_GetPath(int handle);

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0000717C File Offset: 0x0000537C
		public int index
		{
			get
			{
				return Cache.Cache_GetIndex(this.m_Handle);
			}
		}

		// Token: 0x06000460 RID: 1120
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Cache_GetIndex(int handle);

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000719C File Offset: 0x0000539C
		public long spaceFree
		{
			get
			{
				return Cache.Cache_GetSpaceFree(this.m_Handle);
			}
		}

		// Token: 0x06000462 RID: 1122
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern long Cache_GetSpaceFree(int handle);

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000071BC File Offset: 0x000053BC
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x000071D9 File Offset: 0x000053D9
		public long maximumAvailableStorageSpace
		{
			get
			{
				return Cache.Cache_GetMaximumDiskSpaceAvailable(this.m_Handle);
			}
			set
			{
				Cache.Cache_SetMaximumDiskSpaceAvailable(this.m_Handle, value);
			}
		}

		// Token: 0x06000465 RID: 1125
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern long Cache_GetMaximumDiskSpaceAvailable(int handle);

		// Token: 0x06000466 RID: 1126
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Cache_SetMaximumDiskSpaceAvailable(int handle, long value);

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000071EC File Offset: 0x000053EC
		public long spaceOccupied
		{
			get
			{
				return Cache.Cache_GetCachingDiskSpaceUsed(this.m_Handle);
			}
		}

		// Token: 0x06000468 RID: 1128
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern long Cache_GetCachingDiskSpaceUsed(int handle);

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000720C File Offset: 0x0000540C
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00007229 File Offset: 0x00005429
		public int expirationDelay
		{
			get
			{
				return Cache.Cache_GetExpirationDelay(this.m_Handle);
			}
			set
			{
				Cache.Cache_SetExpirationDelay(this.m_Handle, value);
			}
		}

		// Token: 0x0600046B RID: 1131
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Cache_GetExpirationDelay(int handle);

		// Token: 0x0600046C RID: 1132
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Cache_SetExpirationDelay(int handle, int value);

		// Token: 0x0600046D RID: 1133 RVA: 0x0000723C File Offset: 0x0000543C
		public bool ClearCache()
		{
			return Cache.Cache_ClearCache(this.m_Handle);
		}

		// Token: 0x0600046E RID: 1134
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Cache_ClearCache(int handle);

		// Token: 0x0600046F RID: 1135 RVA: 0x0000725C File Offset: 0x0000545C
		public bool ClearCache(int expiration)
		{
			return Cache.Cache_ClearCache_Expiration(this.m_Handle, expiration);
		}

		// Token: 0x06000470 RID: 1136
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Cache_ClearCache_Expiration(int handle, int expiration);

		// Token: 0x0400032A RID: 810
		private int m_Handle;
	}
}
