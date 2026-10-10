using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020003C2 RID: 962
	[UsedByNativeCode]
	public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
	{
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x000333C8 File Offset: 0x000315C8
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x000333D0 File Offset: 0x000315D0
		public VertexAttribute attribute { readonly get; set; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x000333D9 File Offset: 0x000315D9
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x000333E1 File Offset: 0x000315E1
		public VertexAttributeFormat format { readonly get; set; }

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x000333EA File Offset: 0x000315EA
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x000333F2 File Offset: 0x000315F2
		public int dimension { readonly get; set; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x000333FB File Offset: 0x000315FB
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x00033403 File Offset: 0x00031603
		public int stream { readonly get; set; }

		// Token: 0x06001F75 RID: 8053 RVA: 0x0003340C File Offset: 0x0003160C
		public VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0)
		{
			this.attribute = attribute;
			this.format = format;
			this.dimension = dimension;
			this.stream = stream;
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00033430 File Offset: 0x00031630
		public override string ToString()
		{
			return string.Format("(attr={0} fmt={1} dim={2} stream={3})", new object[]
			{
				this.attribute,
				this.format,
				this.dimension,
				this.stream
			});
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0003348C File Offset: 0x0003168C
		public override int GetHashCode()
		{
			int num = 17;
			num = (int)(num * 23 + this.attribute);
			num = (int)(num * 23 + this.format);
			num = num * 23 + this.dimension;
			return num * 23 + this.stream;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x000334D4 File Offset: 0x000316D4
		public override bool Equals(object other)
		{
			bool flag = !(other is VertexAttributeDescriptor);
			return !flag && this.Equals((VertexAttributeDescriptor)other);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00033508 File Offset: 0x00031708
		public bool Equals(VertexAttributeDescriptor other)
		{
			return this.attribute == other.attribute && this.format == other.format && this.dimension == other.dimension && this.stream == other.stream;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x0003355C File Offset: 0x0003175C
		public static bool operator ==(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00033578 File Offset: 0x00031778
		public static bool operator !=(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
		{
			return !lhs.Equals(rhs);
		}
	}
}
