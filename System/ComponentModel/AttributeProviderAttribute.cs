using System;

namespace System.ComponentModel
{
	/// <summary>Включает перенаправление атрибутов. Этот класс не наследуется.</summary>
	// Token: 0x0200037F RID: 895
	[AttributeUsage(AttributeTargets.Property)]
	public class AttributeProviderAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AttributeProviderAttribute" />, используя заданное имя типа.</summary>
		/// <param name="typeName">Имя задаваемого типа.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001D6F RID: 7535 RVA: 0x00068F18 File Offset: 0x00067118
		public AttributeProviderAttribute(string typeName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			this.TypeName = typeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AttributeProviderAttribute" />, используя заданное имя типа и имя свойства.</summary>
		/// <param name="typeName">Имя задаваемого типа.</param>
		/// <param name="propertyName">Имя свойства, для которого будут возвращены атрибуты.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="propertyName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001D70 RID: 7536 RVA: 0x00068F35 File Offset: 0x00067135
		public AttributeProviderAttribute(string typeName, string propertyName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			if (propertyName == null)
			{
				throw new ArgumentNullException("propertyName");
			}
			this.TypeName = typeName;
			this.PropertyName = propertyName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AttributeProviderAttribute" />, используя заданный тип.</summary>
		/// <param name="type">Задаваемый тип.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001D71 RID: 7537 RVA: 0x00068F67 File Offset: 0x00067167
		public AttributeProviderAttribute(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.TypeName = type.AssemblyQualifiedName;
		}

		/// <summary>Возвращает имя типа, переданное в конструктор, с указанием сборки.</summary>
		/// <returns>Имя типа с указанием имя сборки для типа, заданного в конструкторе.</returns>
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00068F8F File Offset: 0x0006718F
		public string TypeName { get; }

		/// <summary>Возвращает имя свойства, для которого будут возвращены атрибуты.</summary>
		/// <returns>Имя свойства, для которого будут возвращены атрибуты.</returns>
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00068F97 File Offset: 0x00067197
		public string PropertyName { get; }
	}
}
