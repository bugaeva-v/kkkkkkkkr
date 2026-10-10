using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	// Token: 0x02000266 RID: 614
	internal struct TextureId
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x0004AD14 File Offset: 0x00048F14
		public TextureId(int index)
		{
			this.m_Index = index + 1;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0004AD20 File Offset: 0x00048F20
		public int index
		{
			get
			{
				return this.m_Index - 1;
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0004AD2C File Offset: 0x00048F2C
		public float ConvertToGpu()
		{
			return (float)this.index;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0004AD48 File Offset: 0x00048F48
		public override bool Equals(object obj)
		{
			bool flag = !(obj is TextureId);
			return !flag && (TextureId)obj == this;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0004AD80 File Offset: 0x00048F80
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(TextureId other)
		{
			return this.m_Index == other.m_Index;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0004ADA0 File Offset: 0x00048FA0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return this.m_Index.GetHashCode();
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0004ADC0 File Offset: 0x00048FC0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(TextureId left, TextureId right)
		{
			return left.m_Index == right.m_Index;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0004ADE0 File Offset: 0x00048FE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(TextureId left, TextureId right)
		{
			return !(left == right);
		}

		// Token: 0x040008AD RID: 2221
		private readonly int m_Index;

		// Token: 0x040008AE RID: 2222
		public static readonly TextureId invalid = new TextureId(-1);
	}
}
