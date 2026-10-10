using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200027F RID: 639
	public struct Scale : IEquatable<Scale>
	{
		// Token: 0x060014B5 RID: 5301 RVA: 0x0005A548 File Offset: 0x00058748
		public Scale(Vector3 scale)
		{
			this.m_Scale = new Vector3(scale.x, scale.y, 1f);
			this.m_IsNone = false;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0005A570 File Offset: 0x00058770
		internal static Scale Initial()
		{
			return new Scale(Vector3.one);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0005A58C File Offset: 0x0005878C
		public static Scale None()
		{
			Scale result = Scale.Initial();
			result.m_IsNone = true;
			return result;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0005A5AD File Offset: 0x000587AD
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0005A5B5 File Offset: 0x000587B5
		public Vector3 value
		{
			get
			{
				return this.m_Scale;
			}
			set
			{
				this.m_Scale = new Vector3(value.x, value.y, 1f);
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0005A5D3 File Offset: 0x000587D3
		internal bool IsNone()
		{
			return this.m_IsNone;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0005A5DC File Offset: 0x000587DC
		public static bool operator ==(Scale lhs, Scale rhs)
		{
			return lhs.m_Scale == rhs.m_Scale;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0005A600 File Offset: 0x00058800
		public static bool operator !=(Scale lhs, Scale rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0005A61C File Offset: 0x0005881C
		public bool Equals(Scale other)
		{
			return other == this;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0005A63C File Offset: 0x0005883C
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Scale)
			{
				Scale other = (Scale)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0005A668 File Offset: 0x00058868
		public override int GetHashCode()
		{
			return this.m_Scale.GetHashCode() * 793;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0005A694 File Offset: 0x00058894
		public override string ToString()
		{
			return this.m_Scale.ToString();
		}

		// Token: 0x0400093B RID: 2363
		private Vector3 m_Scale;

		// Token: 0x0400093C RID: 2364
		private bool m_IsNone;
	}
}
