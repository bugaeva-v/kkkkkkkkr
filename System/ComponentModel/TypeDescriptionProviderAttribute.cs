using System;

namespace System.ComponentModel
{
	/// <summary>Определяет настраиваемый поставщик описания типа для класса. Этот класс не наследуется.</summary>
	// Token: 0x020003F5 RID: 1013
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class TypeDescriptionProviderAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeDescriptionProviderAttribute" />, используя указанное имя типа.</summary>
		/// <param name="typeName">Полное имя типа.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002112 RID: 8466 RVA: 0x00071E4F File Offset: 0x0007004F
		public TypeDescriptionProviderAttribute(string typeName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			this.TypeName = typeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeDescriptionProviderAttribute" />, используя указанный тип.</summary>
		/// <param name="type">Тип, сохраняемый в атрибуте.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002113 RID: 8467 RVA: 0x00071E6C File Offset: 0x0007006C
		public TypeDescriptionProviderAttribute(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.TypeName = type.AssemblyQualifiedName;
		}

		/// <summary>Возвращает имя типа для поставщика описания типа.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая полное имя поставщика <see cref="T:System.ComponentModel.TypeDescriptionProvider" />.</returns>
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x00071E94 File Offset: 0x00070094
		public string TypeName { get; }
	}
}
