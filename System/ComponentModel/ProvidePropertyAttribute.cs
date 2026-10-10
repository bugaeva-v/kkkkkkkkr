using System;

namespace System.ComponentModel
{
	/// <summary>Определяет имя свойства, которое средство реализации <see cref="T:System.ComponentModel.IExtenderProvider" /> предоставляет другим компонентам. Этот класс не наследуется.</summary>
	// Token: 0x020003E2 RID: 994
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ProvidePropertyAttribute" />, используя имя свойства и его тип <see cref="T:System.Type" />.</summary>
		/// <param name="propertyName">Имя свойства, распространяющегося на объект заданного типа.</param>
		/// <param name="receiverType">Тип <see cref="T:System.Type" /> данных объекта, который может получить данное свойство.</param>
		// Token: 0x060020A5 RID: 8357 RVA: 0x00070C28 File Offset: 0x0006EE28
		public ProvidePropertyAttribute(string propertyName, Type receiverType)
		{
			this.PropertyName = propertyName;
			this.ReceiverTypeName = receiverType.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ProvidePropertyAttribute" />, используя данное имя свойства и тип его получателя.</summary>
		/// <param name="propertyName">Имя свойства, распространяющегося на объект заданного типа.</param>
		/// <param name="receiverTypeName">Имя типа данных, на который может распространяться это свойство.</param>
		// Token: 0x060020A6 RID: 8358 RVA: 0x00070C43 File Offset: 0x0006EE43
		public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
		{
			this.PropertyName = propertyName;
			this.ReceiverTypeName = receiverTypeName;
		}

		/// <summary>Возвращает имя свойства, предоставляемого данным классом.</summary>
		/// <returns>Имя свойства, предоставляемого данным классом.</returns>
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00070C59 File Offset: 0x0006EE59
		public string PropertyName { get; }

		/// <summary>Возвращает имя типа данных, на который может распространяться это свойство.</summary>
		/// <returns>Имя типа данных, на который может распространяться это свойство.</returns>
		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x00070C61 File Offset: 0x0006EE61
		public string ReceiverTypeName { get; }

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.ProvidePropertyAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020A9 RID: 8361 RVA: 0x00070C6C File Offset: 0x0006EE6C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ProvidePropertyAttribute providePropertyAttribute = obj as ProvidePropertyAttribute;
			return providePropertyAttribute != null && providePropertyAttribute.PropertyName == this.PropertyName && providePropertyAttribute.ReceiverTypeName == this.ReceiverTypeName;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.ProvidePropertyAttribute" />.</returns>
		// Token: 0x060020AA RID: 8362 RVA: 0x00070CAF File Offset: 0x0006EEAF
		public override int GetHashCode()
		{
			return this.PropertyName.GetHashCode() ^ this.ReceiverTypeName.GetHashCode();
		}

		/// <summary>Возвращает уникальный идентификатор для этого атрибута.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, являющийся уникальным идентификатором атрибута.</returns>
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x00070CC8 File Offset: 0x0006EEC8
		public override object TypeId
		{
			get
			{
				return base.GetType().FullName + this.PropertyName;
			}
		}
	}
}
