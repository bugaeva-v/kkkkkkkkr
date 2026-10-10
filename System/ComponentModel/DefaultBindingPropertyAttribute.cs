using System;

namespace System.ComponentModel
{
	/// <summary>Задает свойство привязки по умолчанию для компонента. Этот класс не наследуется.</summary>
	// Token: 0x0200039A RID: 922
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultBindingPropertyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" /> без параметров.</summary>
		// Token: 0x06001E32 RID: 7730 RVA: 0x00003D9F File Offset: 0x00001F9F
		public DefaultBindingPropertyAttribute()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" />, используя указанное имя свойства.</summary>
		/// <param name="name">Имя свойства привязки по умолчанию.</param>
		// Token: 0x06001E33 RID: 7731 RVA: 0x0006B9A5 File Offset: 0x00069BA5
		public DefaultBindingPropertyAttribute(string name)
		{
			this.Name = name;
		}

		/// <summary>Возвращает имя свойства привязки по умолчанию для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" />.</summary>
		/// <returns>Имя свойства привязки по умолчанию для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" />.</returns>
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x0006B9B4 File Offset: 0x00069BB4
		public string Name { get; }

		/// <summary>Определяет, равен ли указанный объект <see cref="T:System.Object" /> текущему экземпляру <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для сравнения с текущим экземпляром <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если объект равен текущему экземпляру; в противном случае — значение <see langword="false" />, сообщающее о неравенстве.</returns>
		// Token: 0x06001E35 RID: 7733 RVA: 0x0006B9BC File Offset: 0x00069BBC
		public override bool Equals(object obj)
		{
			DefaultBindingPropertyAttribute defaultBindingPropertyAttribute = obj as DefaultBindingPropertyAttribute;
			return defaultBindingPropertyAttribute != null && defaultBindingPropertyAttribute.Name == this.Name;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E36 RID: 7734 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Представляет значение по умолчанию для класса <see cref="T:System.ComponentModel.DefaultBindingPropertyAttribute" />.</summary>
		// Token: 0x04000F17 RID: 3863
		public static readonly DefaultBindingPropertyAttribute Default = new DefaultBindingPropertyAttribute();
	}
}
