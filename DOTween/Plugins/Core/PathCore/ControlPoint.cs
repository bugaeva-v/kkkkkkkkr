using System;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public struct ControlPoint
	{
		// Token: 0x06000228 RID: 552 RVA: 0x0000C888 File Offset: 0x0000AA88
		public ControlPoint(Vector3 a, Vector3 b)
		{
			this.a = a;
			this.b = b;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000C898 File Offset: 0x0000AA98
		public static ControlPoint operator +(ControlPoint cp, Vector3 v)
		{
			return new ControlPoint(cp.a + v, cp.b + v);
		}

		// Token: 0x04000102 RID: 258
		public Vector3 a;

		// Token: 0x04000103 RID: 259
		public Vector3 b;
	}
}
