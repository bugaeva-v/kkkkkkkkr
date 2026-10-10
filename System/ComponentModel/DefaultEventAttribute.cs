using System;

namespace System.ComponentModel
{
	/// <summary>Задает событие по умолчанию для компонента.</summary>
	// Token: 0x0200039B RID: 923
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultEventAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultEventAttribute" />.</summary>
		/// <param name="name">Имя события по умолчанию для компонента, с которым связан этот атрибут.</param>
		// Token: 0x06001E38 RID: 7736 RVA: 0x0006B9F2 File Offset: 0x00069BF2
		public DefaultEventAttribute(string name)
		{
			this.Name = name;
		}

		/// <summary>Возвращает имя события по умолчанию для компонента, с которым связан этот атрибут.</summary>
		/// <returns>Имя события по умолчанию для компонента, с которым связан этот атрибут. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x0006BA01 File Offset: 0x00069C01
		public string Name { get; }

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.DefaultEventAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E3A RID: 7738 RVA: 0x0006BA0C File Offset: 0x00069C0C
		public override bool Equals(object obj)
		{
			DefaultEventAttribute defaultEventAttribute = obj as DefaultEventAttribute;
			return defaultEventAttribute != null && defaultEventAttribute.Name == this.Name;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E3B RID: 7739 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Задает значение по умолчанию для атрибута <see cref="T:System.ComponentModel.DefaultEventAttribute" />, равное <see langword="null" />. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000F19 RID: 3865
		public static readonly DefaultEventAttribute Default = new DefaultEventAttribute(null);
	}
}
