using System;

namespace UnityEngine
{
	// Token: 0x02000100 RID: 256
	public struct BoundingSphere
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x00007FD2 File Offset: 0x000061D2
		public BoundingSphere(Vector3 pos, float rad)
		{
			this.position = pos;
			this.radius = rad;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00007FE3 File Offset: 0x000061E3
		public BoundingSphere(Vector4 packedSphere)
		{
			this.position = new Vector3(packedSphere.x, packedSphere.y, packedSphere.z);
			this.radius = packedSphere.w;
		}

		// Token: 0x04000367 RID: 871
		public Vector3 position;

		// Token: 0x04000368 RID: 872
		public float radius;
	}
}
