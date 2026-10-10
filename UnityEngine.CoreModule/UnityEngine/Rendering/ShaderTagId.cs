using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000411 RID: 1041
	public struct ShaderTagId : IEquatable<ShaderTagId>
	{
		// Token: 0x060023DF RID: 9183 RVA: 0x0003C86A File Offset: 0x0003AA6A
		public ShaderTagId(string name)
		{
			this.m_Id = Shader.TagToID(name);
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x0003C87C File Offset: 0x0003AA7C
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x0003C894 File Offset: 0x0003AA94
		internal int id
		{
			get
			{
				return this.m_Id;
			}
			set
			{
				this.m_Id = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0003C8A0 File Offset: 0x0003AAA0
		public string name
		{
			get
			{
				return Shader.IDToTag(this.id);
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0003C8C0 File Offset: 0x0003AAC0
		public override bool Equals(object obj)
		{
			return obj is ShaderTagId && this.Equals((ShaderTagId)obj);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x0003C8EC File Offset: 0x0003AAEC
		public bool Equals(ShaderTagId other)
		{
			return this.m_Id == other.m_Id;
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x0003C90C File Offset: 0x0003AB0C
		public override int GetHashCode()
		{
			int num = 2079669542;
			return num * -1521134295 + this.m_Id.GetHashCode();
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x0003C93C File Offset: 0x0003AB3C
		public static bool operator ==(ShaderTagId tag1, ShaderTagId tag2)
		{
			return tag1.Equals(tag2);
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x0003C958 File Offset: 0x0003AB58
		public static bool operator !=(ShaderTagId tag1, ShaderTagId tag2)
		{
			return !(tag1 == tag2);
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x0003C974 File Offset: 0x0003AB74
		public static explicit operator ShaderTagId(string name)
		{
			return new ShaderTagId(name);
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0003C98C File Offset: 0x0003AB8C
		public static explicit operator string(ShaderTagId tagId)
		{
			return tagId.name;
		}

		// Token: 0x04000D3A RID: 3386
		public static readonly ShaderTagId none;

		// Token: 0x04000D3B RID: 3387
		private int m_Id;
	}
}
