using System;

namespace System.CodeDom
{
	/// <summary>Определяет идентификаторы атрибута элемента для элементов класса.</summary>
	// Token: 0x0200033F RID: 831
	public enum MemberAttributes
	{
		/// <summary>Абстрактный элемент.</summary>
		// Token: 0x04000E06 RID: 3590
		Abstract = 1,
		/// <summary>Элемент, который не может быть переопределен в производном классе.</summary>
		// Token: 0x04000E07 RID: 3591
		Final,
		/// <summary>Статический элемент. (Эквивалентно ключевому слову <see langword="Shared" /> в Visual Basic).</summary>
		// Token: 0x04000E08 RID: 3592
		Static,
		/// <summary>Элемент, переопределяющий элемент базового класса.</summary>
		// Token: 0x04000E09 RID: 3593
		Override,
		/// <summary>Постоянный элемент.</summary>
		// Token: 0x04000E0A RID: 3594
		Const,
		/// <summary>Новый элемент.</summary>
		// Token: 0x04000E0B RID: 3595
		New = 16,
		/// <summary>Перегруженный элемент. В некоторых языках, например в Visual Basic, необходимо явно указывать перегруженные члены.</summary>
		// Token: 0x04000E0C RID: 3596
		Overloaded = 256,
		/// <summary>Элемент, доступный для любого класса в одной сборке.</summary>
		// Token: 0x04000E0D RID: 3597
		Assembly = 4096,
		/// <summary>Элемент, доступный в своем классе и производных классах в одной сборке.</summary>
		// Token: 0x04000E0E RID: 3598
		FamilyAndAssembly = 8192,
		/// <summary>Элемент, доступный в семействе своего класса и производных классах.</summary>
		// Token: 0x04000E0F RID: 3599
		Family = 12288,
		/// <summary>Элемент, доступный в своем классе, производных классах в любой сборке и любом классе в одной сборке.</summary>
		// Token: 0x04000E10 RID: 3600
		FamilyOrAssembly = 16384,
		/// <summary>Закрытый элемент.</summary>
		// Token: 0x04000E11 RID: 3601
		Private = 20480,
		/// <summary>Открытый элемент.</summary>
		// Token: 0x04000E12 RID: 3602
		Public = 24576,
		/// <summary>Маска доступа.</summary>
		// Token: 0x04000E13 RID: 3603
		AccessMask = 61440,
		/// <summary>Маска области.</summary>
		// Token: 0x04000E14 RID: 3604
		ScopeMask = 15,
		/// <summary>Маска VTable.</summary>
		// Token: 0x04000E15 RID: 3605
		VTableMask = 240
	}
}
