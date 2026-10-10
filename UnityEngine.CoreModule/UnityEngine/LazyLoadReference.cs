using System;

namespace UnityEngine
{
	// Token: 0x0200020E RID: 526
	[Serializable]
	public struct LazyLoadReference<T> where T : Object
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x000252FB File Offset: 0x000234FB
		public bool isSet
		{
			get
			{
				return this.m_InstanceID != 0;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00025306 File Offset: 0x00023506
		public bool isBroken
		{
			get
			{
				return this.m_InstanceID != 0 && !Object.DoesObjectWithInstanceIDExist(this.m_InstanceID);
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00025324 File Offset: 0x00023524
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x00025364 File Offset: 0x00023564
		public T asset
		{
			get
			{
				bool flag = this.m_InstanceID == 0;
				T result;
				if (flag)
				{
					result = default(T);
				}
				else
				{
					result = (T)((object)Object.ForceLoadFromInstanceID(this.m_InstanceID));
				}
				return result;
			}
			set
			{
				bool flag = value == null;
				if (flag)
				{
					this.m_InstanceID = 0;
				}
				else
				{
					bool flag2 = !Object.IsPersistent(value);
					if (flag2)
					{
						throw new ArgumentException("Object that does not belong to a persisted asset cannot be set as the target of a LazyLoadReference.");
					}
					this.m_InstanceID = value.GetInstanceID();
				}
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x000253BE File Offset: 0x000235BE
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x000253C6 File Offset: 0x000235C6
		public int instanceID
		{
			get
			{
				return this.m_InstanceID;
			}
			set
			{
				this.m_InstanceID = value;
			}
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x000253D0 File Offset: 0x000235D0
		public LazyLoadReference(T asset)
		{
			bool flag = asset == null;
			if (flag)
			{
				this.m_InstanceID = 0;
			}
			else
			{
				bool flag2 = !Object.IsPersistent(asset);
				if (flag2)
				{
					throw new ArgumentException("Object that does not belong to a persisted asset cannot be set as the target of a LazyLoadReference.");
				}
				this.m_InstanceID = asset.GetInstanceID();
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0002542A File Offset: 0x0002362A
		public LazyLoadReference(int instanceID)
		{
			this.m_InstanceID = instanceID;
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00025434 File Offset: 0x00023634
		public static implicit operator LazyLoadReference<T>(T asset)
		{
			return new LazyLoadReference<T>
			{
				asset = asset
			};
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00025458 File Offset: 0x00023658
		public static implicit operator LazyLoadReference<T>(int instanceID)
		{
			return new LazyLoadReference<T>
			{
				instanceID = instanceID
			};
		}

		// Token: 0x040007FB RID: 2043
		private const int kInstanceID_None = 0;

		// Token: 0x040007FC RID: 2044
		[SerializeField]
		private int m_InstanceID;
	}
}
