using System;
using System.Collections;
using System.Collections.Generic;

namespace App42Json
{
	// Token: 0x02000064 RID: 100
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0001595E File Offset: 0x00013B5E
		public object Current
		{
			get
			{
				return this.Entry;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001596C File Offset: 0x00013B6C
		public DictionaryEntry Entry
		{
			get
			{
				KeyValuePair<string, JsonData> keyValuePair = this.list_enumerator.Current;
				return new DictionaryEntry(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00015998 File Offset: 0x00013B98
		public object Key
		{
			get
			{
				KeyValuePair<string, JsonData> keyValuePair = this.list_enumerator.Current;
				return keyValuePair.Key;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x000159B8 File Offset: 0x00013BB8
		public object Value
		{
			get
			{
				KeyValuePair<string, JsonData> keyValuePair = this.list_enumerator.Current;
				return keyValuePair.Value;
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000159D8 File Offset: 0x00013BD8
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
			this.list_enumerator = enumerator;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000159E7 File Offset: 0x00013BE7
		public bool MoveNext()
		{
			return this.list_enumerator.MoveNext();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000159F4 File Offset: 0x00013BF4
		public void Reset()
		{
			this.list_enumerator.Reset();
		}

		// Token: 0x04000197 RID: 407
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
	}
}
