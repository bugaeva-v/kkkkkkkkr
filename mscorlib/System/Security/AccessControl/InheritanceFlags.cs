using System;

namespace System.Security.AccessControl
{
	/// <summary>Флаги наследования определяют семантику наследования элементов управления доступом.</summary>
	// Token: 0x0200052F RID: 1327
	[Flags]
	public enum InheritanceFlags
	{
		/// <summary>Элемент управления доступом не наследуется дочерними объектами.</summary>
		// Token: 0x040024AB RID: 9387
		None = 0,
		/// <summary>Элемент управления доступом наследуется дочерними объектами-контейнерами.</summary>
		// Token: 0x040024AC RID: 9388
		ContainerInherit = 1,
		/// <summary>Элемент управления доступом наследуется дочерними конечными объектами.</summary>
		// Token: 0x040024AD RID: 9389
		ObjectInherit = 2
	}
}
