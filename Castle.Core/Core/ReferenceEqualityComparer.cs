using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Castle.Core
{
	// Token: 0x020000B2 RID: 178
	[Serializable]
	public class ReferenceEqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
	{
		// Token: 0x0600043D RID: 1085 RVA: 0x0000F882 File Offset: 0x0000DA82
		private ReferenceEqualityComparer()
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000F88A File Offset: 0x0000DA8A
		public int GetHashCode(object obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000F892 File Offset: 0x0000DA92
		bool IEqualityComparer.Equals(object x, object y)
		{
			return x == y;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000F898 File Offset: 0x0000DA98
		bool IEqualityComparer<!0>.Equals(T x, T y)
		{
			return x == y;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000F8A8 File Offset: 0x0000DAA8
		int IEqualityComparer<!0>.GetHashCode(T obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000F8B5 File Offset: 0x0000DAB5
		public static ReferenceEqualityComparer<T> Instance
		{
			get
			{
				return ReferenceEqualityComparer<T>.instance;
			}
		}

		// Token: 0x0400013C RID: 316
		private static readonly ReferenceEqualityComparer<T> instance = new ReferenceEqualityComparer<T>();
	}
}
