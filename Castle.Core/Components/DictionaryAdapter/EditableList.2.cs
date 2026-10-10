using System;
using System.Collections;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200013C RID: 316
	public class EditableList : EditableList<object>, IList, ICollection, IEnumerable
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x00016DBF File Offset: 0x00014FBF
		public EditableList()
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00016DC7 File Offset: 0x00014FC7
		public EditableList(IEnumerable<object> collection) : base(collection)
		{
		}
	}
}
