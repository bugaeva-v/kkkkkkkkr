using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000283 RID: 643
	internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> where T : struct, IEquatable<T>, IStyleDataGroup<T>
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0005AC92 File Offset: 0x00058E92
		public int refCount
		{
			get
			{
				StyleDataRef<T>.RefCounted @ref = this.m_Ref;
				return (@ref != null) ? @ref.refCount : 0;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0005ACA6 File Offset: 0x00058EA6
		public uint id
		{
			get
			{
				StyleDataRef<T>.RefCounted @ref = this.m_Ref;
				return (@ref != null) ? @ref.id : 0U;
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0005ACBC File Offset: 0x00058EBC
		public StyleDataRef<T> Acquire()
		{
			this.m_Ref.Acquire();
			return this;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0005ACE0 File Offset: 0x00058EE0
		public void Release()
		{
			this.m_Ref.Release();
			this.m_Ref = null;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0005ACF8 File Offset: 0x00058EF8
		public void CopyFrom(StyleDataRef<T> other)
		{
			bool flag = this.m_Ref.refCount == 1;
			if (flag)
			{
				this.m_Ref.value.CopyFrom(ref other.m_Ref.value);
			}
			else
			{
				this.m_Ref.Release();
				this.m_Ref = other.m_Ref;
				this.m_Ref.Acquire();
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0005AD64 File Offset: 0x00058F64
		public ref readonly T Read()
		{
			return ref this.m_Ref.value;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0005AD74 File Offset: 0x00058F74
		public ref T Write()
		{
			bool flag = this.m_Ref.refCount == 1;
			T result;
			if (flag)
			{
				result = ref this.m_Ref.value;
			}
			else
			{
				StyleDataRef<T>.RefCounted @ref = this.m_Ref;
				this.m_Ref = this.m_Ref.Copy();
				@ref.Release();
				result = ref this.m_Ref.value;
			}
			return ref result;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0005ADD0 File Offset: 0x00058FD0
		public static StyleDataRef<T> Create()
		{
			return new StyleDataRef<T>
			{
				m_Ref = new StyleDataRef<T>.RefCounted()
			};
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0005ADF8 File Offset: 0x00058FF8
		public override int GetHashCode()
		{
			return (this.m_Ref != null) ? this.m_Ref.value.GetHashCode() : 0;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0005AE2C File Offset: 0x0005902C
		public static bool operator ==(StyleDataRef<T> lhs, StyleDataRef<T> rhs)
		{
			return lhs.m_Ref == rhs.m_Ref || lhs.m_Ref.value.Equals(rhs.m_Ref.value);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0005AE70 File Offset: 0x00059070
		public static bool operator !=(StyleDataRef<T> lhs, StyleDataRef<T> rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0005AE8C File Offset: 0x0005908C
		public bool Equals(StyleDataRef<T> other)
		{
			return other == this;
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0005AEAC File Offset: 0x000590AC
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleDataRef<T>)
			{
				StyleDataRef<T> other = (StyleDataRef<T>)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000943 RID: 2371
		private StyleDataRef<T>.RefCounted m_Ref;

		// Token: 0x02000284 RID: 644
		private class RefCounted
		{
			// Token: 0x170004E6 RID: 1254
			// (get) Token: 0x06001504 RID: 5380 RVA: 0x0005AED7 File Offset: 0x000590D7
			public int refCount
			{
				get
				{
					return this.m_RefCount;
				}
			}

			// Token: 0x170004E7 RID: 1255
			// (get) Token: 0x06001505 RID: 5381 RVA: 0x0005AEDF File Offset: 0x000590DF
			public uint id
			{
				get
				{
					return this.m_Id;
				}
			}

			// Token: 0x06001506 RID: 5382 RVA: 0x0005AEE7 File Offset: 0x000590E7
			public RefCounted()
			{
				this.m_RefCount = 1;
				this.m_Id = (StyleDataRef<T>.RefCounted.m_NextId += 1U);
			}

			// Token: 0x06001507 RID: 5383 RVA: 0x0005AF0B File Offset: 0x0005910B
			public void Acquire()
			{
				this.m_RefCount++;
			}

			// Token: 0x06001508 RID: 5384 RVA: 0x0005AF1B File Offset: 0x0005911B
			public void Release()
			{
				this.m_RefCount--;
			}

			// Token: 0x06001509 RID: 5385 RVA: 0x0005AF2C File Offset: 0x0005912C
			public StyleDataRef<T>.RefCounted Copy()
			{
				return new StyleDataRef<T>.RefCounted
				{
					value = this.value.Copy()
				};
			}

			// Token: 0x04000944 RID: 2372
			private static uint m_NextId = 1U;

			// Token: 0x04000945 RID: 2373
			private int m_RefCount;

			// Token: 0x04000946 RID: 2374
			private readonly uint m_Id;

			// Token: 0x04000947 RID: 2375
			public T value;
		}
	}
}
