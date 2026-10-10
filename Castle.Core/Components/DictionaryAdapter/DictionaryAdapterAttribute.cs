using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x020000FA RID: 250
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class DictionaryAdapterAttribute : Attribute
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x00013018 File Offset: 0x00011218
		public DictionaryAdapterAttribute(Type interfaceType)
		{
			this.InterfaceType = interfaceType;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00013027 File Offset: 0x00011227
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0001302F File Offset: 0x0001122F
		public Type InterfaceType { get; private set; }
	}
}
