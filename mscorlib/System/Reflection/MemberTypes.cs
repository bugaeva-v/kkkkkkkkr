using System;

namespace System.Reflection
{
	/// <summary>Отмечает каждый тип элемент, определенный как производный класс класса <see cref="T:System.Reflection.MemberInfo" />.</summary>
	// Token: 0x020008AB RID: 2219
	[Flags]
	public enum MemberTypes
	{
		/// <summary>Указывает, что элемент — это конструктор.</summary>
		// Token: 0x04002EBB RID: 11963
		Constructor = 1,
		/// <summary>Указывает, что элемент — это событие.</summary>
		// Token: 0x04002EBC RID: 11964
		Event = 2,
		/// <summary>Указывает, что элемент — это поле.</summary>
		// Token: 0x04002EBD RID: 11965
		Field = 4,
		/// <summary>Указывает, что элемент — это метод.</summary>
		// Token: 0x04002EBE RID: 11966
		Method = 8,
		/// <summary>Указывает, что элемент — это свойство.</summary>
		// Token: 0x04002EBF RID: 11967
		Property = 16,
		/// <summary>Указывает, что элемент — это тип.</summary>
		// Token: 0x04002EC0 RID: 11968
		TypeInfo = 32,
		/// <summary>Указывает, что элемент — это тип настраиваемого элемента.</summary>
		// Token: 0x04002EC1 RID: 11969
		Custom = 64,
		/// <summary>Указывает, что элемент — это вложенный тип.</summary>
		// Token: 0x04002EC2 RID: 11970
		NestedType = 128,
		/// <summary>Задает все типы элементов.</summary>
		// Token: 0x04002EC3 RID: 11971
		All = 191
	}
}
