using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000222 RID: 546
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class TrackedReference
	{
		// Token: 0x06001790 RID: 6032 RVA: 0x00008CE3 File Offset: 0x00006EE3
		protected TrackedReference()
		{
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00026254 File Offset: 0x00024454
		public static bool operator ==(TrackedReference x, TrackedReference y)
		{
			bool flag = y == null && x == null;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				bool flag2 = y == null;
				if (flag2)
				{
					result = (x.m_Ptr == IntPtr.Zero);
				}
				else
				{
					bool flag3 = x == null;
					if (flag3)
					{
						result = (y.m_Ptr == IntPtr.Zero);
					}
					else
					{
						result = (x.m_Ptr == y.m_Ptr);
					}
				}
			}
			return result;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000262C8 File Offset: 0x000244C8
		public static bool operator !=(TrackedReference x, TrackedReference y)
		{
			return !(x == y);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000262E4 File Offset: 0x000244E4
		public override bool Equals(object o)
		{
			return o as TrackedReference == this;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00026304 File Offset: 0x00024504
		public override int GetHashCode()
		{
			return (int)this.m_Ptr;
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00026324 File Offset: 0x00024524
		public static implicit operator bool(TrackedReference exists)
		{
			return exists != null;
		}

		// Token: 0x04000815 RID: 2069
		internal IntPtr m_Ptr;
	}
}
