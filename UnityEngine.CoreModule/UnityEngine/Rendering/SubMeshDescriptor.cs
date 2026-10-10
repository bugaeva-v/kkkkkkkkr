using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003C1 RID: 961
	public struct SubMeshDescriptor
	{
		// Token: 0x06001F5D RID: 8029 RVA: 0x0003327C File Offset: 0x0003147C
		public SubMeshDescriptor(int indexStart, int indexCount, MeshTopology topology = MeshTopology.Triangles)
		{
			this.indexStart = indexStart;
			this.indexCount = indexCount;
			this.topology = topology;
			this.bounds = default(Bounds);
			this.baseVertex = 0;
			this.firstVertex = 0;
			this.vertexCount = 0;
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x000332CA File Offset: 0x000314CA
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x000332D2 File Offset: 0x000314D2
		public Bounds bounds { readonly get; set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x000332DB File Offset: 0x000314DB
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x000332E3 File Offset: 0x000314E3
		public MeshTopology topology { readonly get; set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x000332EC File Offset: 0x000314EC
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x000332F4 File Offset: 0x000314F4
		public int indexStart { readonly get; set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x000332FD File Offset: 0x000314FD
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x00033305 File Offset: 0x00031505
		public int indexCount { readonly get; set; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0003330E File Offset: 0x0003150E
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x00033316 File Offset: 0x00031516
		public int baseVertex { readonly get; set; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0003331F File Offset: 0x0003151F
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00033327 File Offset: 0x00031527
		public int firstVertex { readonly get; set; }

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00033330 File Offset: 0x00031530
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00033338 File Offset: 0x00031538
		public int vertexCount { readonly get; set; }

		// Token: 0x06001F6C RID: 8044 RVA: 0x00033344 File Offset: 0x00031544
		public override string ToString()
		{
			return string.Format("(topo={0} indices={1},{2} vertices={3},{4} basevtx={5} bounds={6})", new object[]
			{
				this.topology,
				this.indexStart,
				this.indexCount,
				this.firstVertex,
				this.vertexCount,
				this.baseVertex,
				this.bounds
			});
		}
	}
}
