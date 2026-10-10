using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Задает имя свойства, которое обращается к полю с атрибутами.</summary>
	// Token: 0x020007D8 RID: 2008
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class AccessedThroughPropertyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="AccessedThroughPropertyAttribute" /> с именем свойства, используемого для доступа к полю с атрибутами.</summary>
		/// <param name="propertyName">Имя свойства, используемого для доступа к полю с атрибутами.</param>
		// Token: 0x060045B8 RID: 17848 RVA: 0x000E5160 File Offset: 0x000E3360
		public AccessedThroughPropertyAttribute(string propertyName)
		{
			this.PropertyName = propertyName;
		}

		/// <summary>Возвращает имя свойства, используемого для доступа к полю с атрибутами.</summary>
		/// <returns>Имя свойства, используемого для доступа к полю с атрибутами.</returns>
		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060045B9 RID: 17849 RVA: 0x000E516F File Offset: 0x000E336F
		public string PropertyName { get; }
	}
}
