using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Управляет макетом объекта при его экспорте в неуправляемый код.</summary>
	// Token: 0x020006C6 RID: 1734
	public enum LayoutKind
	{
		/// <summary>Члены объекта располагаются последовательно, в порядке своего появления при экспортировании в неуправляемую память. Члены располагаются в соответствии с компоновкой, заданной в <see cref="F:System.Runtime.InteropServices.StructLayoutAttribute.Pack" />, и могут быть несмежными.</summary>
		// Token: 0x040029F6 RID: 10742
		Sequential,
		/// <summary>Точное положение каждого члена объекта в неуправляемой памяти управляется явно в соответствии с настройкой поля <see cref="F:System.Runtime.InteropServices.StructLayoutAttribute.Pack" />. Каждый член должен использовать атрибут <see cref="T:System.Runtime.InteropServices.FieldOffsetAttribute" /> для указания положения этого поля внутри типа.</summary>
		// Token: 0x040029F7 RID: 10743
		Explicit = 2,
		/// <summary>Среда CLR автоматически выбирает соответствующее размещение для членов объекта в неуправляемой памяти. Доступ к объектам, определенным при помощи этого члена перечисления, не может быть предоставлен вне управляемого кода. Попытка выполнить такую операцию вызовет исключение.</summary>
		// Token: 0x040029F8 RID: 10744
		Auto
	}
}
