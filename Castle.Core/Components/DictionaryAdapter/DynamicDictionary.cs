using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000119 RID: 281
	public class DynamicDictionary : DynamicObject
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x00015EB8 File Offset: 0x000140B8
		public DynamicDictionary(IDictionary dictionary)
		{
			this.dictionary = dictionary;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00015EC7 File Offset: 0x000140C7
		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return from object key in this.dictionary.Keys
			select key.ToString();
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00015EFD File Offset: 0x000140FD
		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			result = this.dictionary[binder.Name];
			return true;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00015F13 File Offset: 0x00014113
		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			this.dictionary[binder.Name] = value;
			return true;
		}

		// Token: 0x040001DD RID: 477
		private readonly IDictionary dictionary;
	}
}
