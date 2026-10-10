using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет наличие типов объектов для элементов управления доступом.</summary>
	// Token: 0x0200053F RID: 1343
	[Flags]
	public enum ObjectAceFlags
	{
		/// <summary>Тип объекта отсутствует.</summary>
		// Token: 0x040024C8 RID: 9416
		None = 0,
		/// <summary>Присутствует тип объекта, связанный с элементом управления доступом.</summary>
		// Token: 0x040024C9 RID: 9417
		ObjectAceTypePresent = 1,
		/// <summary>Тип объекта, который может наследовать элемент управления доступом.</summary>
		// Token: 0x040024CA RID: 9418
		InheritedObjectAceTypePresent = 2
	}
}
