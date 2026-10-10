using System;

namespace System.ComponentModel
{
	/// <summary>Определяет свойство, предлагаемое поставщиком расширений. Этот класс не наследуется.</summary>
	// Token: 0x020003AB RID: 939
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ExtenderProvidedPropertyAttribute : Attribute
	{
		// Token: 0x06001EC6 RID: 7878 RVA: 0x0006CB0F File Offset: 0x0006AD0F
		internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider)
		{
			return new ExtenderProvidedPropertyAttribute
			{
				ExtenderProperty = extenderProperty,
				ReceiverType = receiverType,
				Provider = provider
			};
		}

		/// <summary>Возвращает предоставляемое свойство.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, инкапсулирующий предоставляемое свойство.</returns>
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x0006CB2B File Offset: 0x0006AD2B
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0006CB33 File Offset: 0x0006AD33
		public PropertyDescriptor ExtenderProperty { get; private set; }

		/// <summary>Возвращает поставщика расширений, предоставляющего свойство.</summary>
		/// <returns>Поставщик <see cref="T:System.ComponentModel.IExtenderProvider" />, предоставляющий свойство.</returns>
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0006CB3C File Offset: 0x0006AD3C
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x0006CB44 File Offset: 0x0006AD44
		public IExtenderProvider Provider { get; private set; }

		/// <summary>Возвращает тип объекта, который может получить данное свойство.</summary>
		/// <returns>Тип <see cref="T:System.Type" />, описывающий тип объекта, который может получить данное свойство.</returns>
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0006CB4D File Offset: 0x0006AD4D
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x0006CB55 File Offset: 0x0006AD55
		public Type ReceiverType { get; private set; }

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для сравнения с этим экземпляром или пустая ссылка (<see langword="Nothing" /> в Visual Basic).</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001ECE RID: 7886 RVA: 0x0006CB60 File Offset: 0x0006AD60
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ExtenderProvidedPropertyAttribute extenderProvidedPropertyAttribute = obj as ExtenderProvidedPropertyAttribute;
			return extenderProvidedPropertyAttribute != null && extenderProvidedPropertyAttribute.ExtenderProperty.Equals(this.ExtenderProperty) && extenderProvidedPropertyAttribute.Provider.Equals(this.Provider) && extenderProvidedPropertyAttribute.ReceiverType.Equals(this.ReceiverType);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001ECF RID: 7887 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Предоставляет признак, показывающий, является ли значение этого экземпляра значением по умолчанию для производного класса.</summary>
		/// <returns>Значение <see langword="true" />, если этот экземпляр является атрибутом по умолчанию для класса; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001ED0 RID: 7888 RVA: 0x0006CBB6 File Offset: 0x0006ADB6
		public override bool IsDefaultAttribute()
		{
			return this.ReceiverType == null;
		}
	}
}
