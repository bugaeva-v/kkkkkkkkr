using System;

namespace System.ComponentModel
{
	/// <summary>Определяет идентификаторы для типов уровней наследования.</summary>
	// Token: 0x0200039F RID: 927
	public enum InheritanceLevel
	{
		/// <summary>Объект является унаследованным.</summary>
		// Token: 0x04000F23 RID: 3875
		Inherited = 1,
		/// <summary>Объект является унаследованным, но доступен только для чтения.</summary>
		// Token: 0x04000F24 RID: 3876
		InheritedReadOnly,
		/// <summary>Объект не является унаследованным.</summary>
		// Token: 0x04000F25 RID: 3877
		NotInherited
	}
}
