using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200012E RID: 302
	public interface IDictionaryValidate : IDataErrorInfo
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600080F RID: 2063
		// (set) Token: 0x06000810 RID: 2064
		bool CanValidate { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000811 RID: 2065
		bool IsValid { get; }

		// Token: 0x06000812 RID: 2066
		DictionaryValidateGroup ValidateGroups(params object[] groups);

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000813 RID: 2067
		IEnumerable<IDictionaryValidator> Validators { get; }

		// Token: 0x06000814 RID: 2068
		void AddValidator(IDictionaryValidator validator);
	}
}
