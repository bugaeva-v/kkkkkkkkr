using System;

namespace System.ComponentModel
{
	/// <summary>Задает свойство по умолчанию для компонента.</summary>
	// Token: 0x0200039C RID: 924
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultPropertyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultPropertyAttribute" />.</summary>
		/// <param name="name">Имя свойства по умолчанию для компонента, с которым связан этот атрибут.</param>
		// Token: 0x06001E3D RID: 7741 RVA: 0x0006BA43 File Offset: 0x00069C43
		public DefaultPropertyAttribute(string name)
		{
			this.Name = name;
		}

		/// <summary>Возвращает имя свойства по умолчанию для компонента, с которым связан этот атрибут.</summary>
		/// <returns>Имя свойства по умолчанию для компонента, с которым связан этот атрибут. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x0006BA52 File Offset: 0x00069C52
		public string Name { get; }

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.DefaultPropertyAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E3F RID: 7743 RVA: 0x0006BA5C File Offset: 0x00069C5C
		public override bool Equals(object obj)
		{
			DefaultPropertyAttribute defaultPropertyAttribute = obj as DefaultPropertyAttribute;
			return defaultPropertyAttribute != null && defaultPropertyAttribute.Name == this.Name;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E40 RID: 7744 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Задает значение по умолчанию для атрибута <see cref="T:System.ComponentModel.DefaultPropertyAttribute" />, равное <see langword="null" />. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000F1B RID: 3867
		public static readonly DefaultPropertyAttribute Default = new DefaultPropertyAttribute(null);
	}
}
