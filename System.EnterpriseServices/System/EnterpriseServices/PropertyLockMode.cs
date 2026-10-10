using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Задает режим доступа к общим свойствам в диспетчере групп общих свойств.</summary>
	// Token: 0x02000038 RID: 56
	[ComVisible(false)]
	[Serializable]
	public enum PropertyLockMode
	{
		/// <summary>Блокирует все свойства в группе общих свойств для монопольного использования вызывающим объектом до тех пор, пока выполняется его текущий метод.</summary>
		// Token: 0x04000078 RID: 120
		Method = 1,
		/// <summary>Блокирует свойство при задании или получении, гарантируя для общего свойства атомарность каждой операции задания или получения.</summary>
		// Token: 0x04000079 RID: 121
		SetGet = 0
	}
}
