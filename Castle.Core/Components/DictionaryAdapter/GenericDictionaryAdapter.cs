using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200011A RID: 282
	public class GenericDictionaryAdapter<TValue> : AbstractDictionaryAdapter
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x00015F28 File Offset: 0x00014128
		public GenericDictionaryAdapter(IDictionary<string, TValue> dictionary)
		{
			this.dictionary = dictionary;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00015F37 File Offset: 0x00014137
		public override bool IsReadOnly
		{
			get
			{
				return this.dictionary.IsReadOnly;
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00015F44 File Offset: 0x00014144
		public override bool Contains(object key)
		{
			return this.dictionary.Keys.Contains(GenericDictionaryAdapter<TValue>.GetKey(key));
		}

		// Token: 0x1700013F RID: 319
		public override object this[object key]
		{
			get
			{
				TValue tvalue;
				return this.dictionary.TryGetValue(GenericDictionaryAdapter<TValue>.GetKey(key), out tvalue) ? tvalue : default(TValue);
			}
			set
			{
				this.dictionary[GenericDictionaryAdapter<TValue>.GetKey(key)] = (TValue)((object)value);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00015FA8 File Offset: 0x000141A8
		private static string GetKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return key.ToString();
		}

		// Token: 0x040001DE RID: 478
		private readonly IDictionary<string, TValue> dictionary;
	}
}
