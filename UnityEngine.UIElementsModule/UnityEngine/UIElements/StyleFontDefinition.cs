using System;
using System.Runtime.InteropServices;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x02000289 RID: 649
	public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition>
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0005E890 File Offset: 0x0005CA90
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x0005E8BB File Offset: 0x0005CABB
		public FontDefinition value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(FontDefinition);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x0005E8CC File Offset: 0x0005CACC
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x0005E8E4 File Offset: 0x0005CAE4
		public StyleKeyword keyword
		{
			get
			{
				return this.m_Keyword;
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0005E8EE File Offset: 0x0005CAEE
		public StyleFontDefinition(FontDefinition f)
		{
			this = new StyleFontDefinition(f, StyleKeyword.Undefined);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0005E8FA File Offset: 0x0005CAFA
		public StyleFontDefinition(FontAsset f)
		{
			this = new StyleFontDefinition(f, StyleKeyword.Undefined);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0005E906 File Offset: 0x0005CB06
		public StyleFontDefinition(Font f)
		{
			this = new StyleFontDefinition(f, StyleKeyword.Undefined);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0005E914 File Offset: 0x0005CB14
		public StyleFontDefinition(StyleKeyword keyword)
		{
			this = new StyleFontDefinition(default(FontDefinition), keyword);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0005E933 File Offset: 0x0005CB33
		internal StyleFontDefinition(object obj, StyleKeyword keyword)
		{
			this = new StyleFontDefinition(FontDefinition.FromObject(obj), keyword);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0005E944 File Offset: 0x0005CB44
		internal StyleFontDefinition(object obj)
		{
			this = new StyleFontDefinition(FontDefinition.FromObject(obj), StyleKeyword.Undefined);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0005E955 File Offset: 0x0005CB55
		internal StyleFontDefinition(FontAsset f, StyleKeyword keyword)
		{
			this = new StyleFontDefinition(FontDefinition.FromSDFFont(f), keyword);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0005E966 File Offset: 0x0005CB66
		internal StyleFontDefinition(Font f, StyleKeyword keyword)
		{
			this = new StyleFontDefinition(FontDefinition.FromFont(f), keyword);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0005E978 File Offset: 0x0005CB78
		internal StyleFontDefinition(GCHandle gcHandle, StyleKeyword keyword)
		{
			this = new StyleFontDefinition(gcHandle.IsAllocated ? FontDefinition.FromObject(gcHandle.Target) : default(FontDefinition), keyword);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0005E9AE File Offset: 0x0005CBAE
		internal StyleFontDefinition(FontDefinition f, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = f;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0005E9BF File Offset: 0x0005CBBF
		internal StyleFontDefinition(StyleFontDefinition sfd)
		{
			this.m_Keyword = sfd.keyword;
			this.m_Value = sfd.value;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0005E9DC File Offset: 0x0005CBDC
		public static implicit operator StyleFontDefinition(StyleKeyword keyword)
		{
			return new StyleFontDefinition(keyword);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0005E9F4 File Offset: 0x0005CBF4
		public static implicit operator StyleFontDefinition(FontDefinition f)
		{
			return new StyleFontDefinition(f);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0005EA0C File Offset: 0x0005CC0C
		public bool Equals(StyleFontDefinition other)
		{
			return this.m_Keyword == other.m_Keyword && this.m_Value.Equals(other.m_Value);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0005EA40 File Offset: 0x0005CC40
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleFontDefinition)
			{
				StyleFontDefinition other = (StyleFontDefinition)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0005EA6C File Offset: 0x0005CC6C
		public override int GetHashCode()
		{
			return (int)(this.m_Keyword * (StyleKeyword)397 ^ (StyleKeyword)this.m_Value.GetHashCode());
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
		public static bool operator ==(StyleFontDefinition left, StyleFontDefinition right)
		{
			return left.Equals(right);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0005EABC File Offset: 0x0005CCBC
		public static bool operator !=(StyleFontDefinition left, StyleFontDefinition right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000952 RID: 2386
		private StyleKeyword m_Keyword;

		// Token: 0x04000953 RID: 2387
		private FontDefinition m_Value;
	}
}
