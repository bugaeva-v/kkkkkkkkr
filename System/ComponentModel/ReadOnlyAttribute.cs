using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, доступно ли свойство, с которым связан данный атрибут, только для чтения или для чтения и записи. Этот класс не наследуется.</summary>
	// Token: 0x02000377 RID: 887
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ReadOnlyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ReadOnlyAttribute" />.</summary>
		/// <param name="isReadOnly">Значение <see langword="true" />, чтобы показать, что свойство, с которым связан этот атрибут, доступно только для чтения, или значение <see langword="false" />, показывающее, что это свойство доступно для чтения и записи.</param>
		// Token: 0x06001D39 RID: 7481 RVA: 0x000686D3 File Offset: 0x000668D3
		public ReadOnlyAttribute(bool isReadOnly)
		{
			this.IsReadOnly = isReadOnly;
		}

		/// <summary>Возвращает значение, показывающее, доступно ли свойство, с которым связан этот атрибут, только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если свойство, с которым связан этот атрибут, доступно только для чтения, или значение <see langword="false" />, если это свойство доступно и для чтения, и для записи.</returns>
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x000686E2 File Offset: 0x000668E2
		public bool IsReadOnly { get; }

		/// <summary>Указывает, равен ли этот экземпляр заданному объекту.</summary>
		/// <param name="value">Другой объект, подлежащий сравнению.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="value" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D3B RID: 7483 RVA: 0x000686EC File Offset: 0x000668EC
		public override bool Equals(object value)
		{
			if (this == value)
			{
				return true;
			}
			ReadOnlyAttribute readOnlyAttribute = value as ReadOnlyAttribute;
			bool? flag = (readOnlyAttribute != null) ? new bool?(readOnlyAttribute.IsReadOnly) : null;
			bool isReadOnly = this.IsReadOnly;
			return flag.GetValueOrDefault() == isReadOnly & flag != null;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.ReadOnlyAttribute" />.</returns>
		// Token: 0x06001D3C RID: 7484 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D3D RID: 7485 RVA: 0x00068738 File Offset: 0x00066938
		public override bool IsDefaultAttribute()
		{
			return this.IsReadOnly == ReadOnlyAttribute.Default.IsReadOnly;
		}

		/// <summary>Определяет, что свойство, с которым связан данный атрибут, доступно только для чтения и не может быть изменено в обозревателе серверов. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000ECA RID: 3786
		public static readonly ReadOnlyAttribute Yes = new ReadOnlyAttribute(true);

		/// <summary>Определяет, что свойство, с которым связан данный атрибут, доступно и для чтения, и для записи и может быть изменено. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000ECB RID: 3787
		public static readonly ReadOnlyAttribute No = new ReadOnlyAttribute(false);

		/// <summary>Определяет значение по умолчанию для атрибута <see cref="T:System.ComponentModel.ReadOnlyAttribute" />, равное <see cref="F:System.ComponentModel.ReadOnlyAttribute.No" /> (то есть свойство, с которым связан этот атрибут, доступно для чтения и записи). Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000ECC RID: 3788
		public static readonly ReadOnlyAttribute Default = ReadOnlyAttribute.No;
	}
}
