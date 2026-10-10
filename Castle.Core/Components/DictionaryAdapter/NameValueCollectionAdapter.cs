using System;
using System.Collections.Specialized;
using System.Linq;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000132 RID: 306
	public class NameValueCollectionAdapter : AbstractDictionaryAdapter
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x00016056 File Offset: 0x00014256
		public NameValueCollectionAdapter(NameValueCollection nameValues)
		{
			this.nameValues = nameValues;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00016065 File Offset: 0x00014265
		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00016068 File Offset: 0x00014268
		public override bool Contains(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this[key] != null || this.nameValues.AllKeys.Contains(key.ToString(), StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x1700014C RID: 332
		public override object this[object key]
		{
			get
			{
				return this.nameValues[key.ToString()];
			}
			set
			{
				string value2 = (value != null) ? value.ToString() : null;
				this.nameValues[key.ToString()] = value2;
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000160E0 File Offset: 0x000142E0
		public static NameValueCollectionAdapter Adapt(NameValueCollection nameValues)
		{
			return new NameValueCollectionAdapter(nameValues);
		}

		// Token: 0x040001DF RID: 479
		private readonly NameValueCollection nameValues;
	}
}
