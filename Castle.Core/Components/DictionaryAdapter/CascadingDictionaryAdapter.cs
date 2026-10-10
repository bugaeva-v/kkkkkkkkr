using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000111 RID: 273
	public class CascadingDictionaryAdapter : AbstractDictionaryAdapter
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x00013BB6 File Offset: 0x00011DB6
		public CascadingDictionaryAdapter(IDictionary primary, IDictionary secondary)
		{
			this.primary = primary;
			this.secondary = secondary;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00013BCC File Offset: 0x00011DCC
		public IDictionary Primary
		{
			get
			{
				return this.primary;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00013BD4 File Offset: 0x00011DD4
		public IDictionary Secondary
		{
			get
			{
				return this.secondary;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00013BDC File Offset: 0x00011DDC
		public override bool IsReadOnly
		{
			get
			{
				return this.primary.IsReadOnly;
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00013BE9 File Offset: 0x00011DE9
		public override bool Contains(object key)
		{
			return this.primary.Contains(key) || this.secondary.Contains(key);
		}

		// Token: 0x17000117 RID: 279
		public override object this[object key]
		{
			get
			{
				return this.primary[key] ?? this.secondary[key];
			}
			set
			{
				this.primary[key] = value;
			}
		}

		// Token: 0x040001AD RID: 429
		private readonly IDictionary primary;

		// Token: 0x040001AE RID: 430
		private readonly IDictionary secondary;
	}
}
