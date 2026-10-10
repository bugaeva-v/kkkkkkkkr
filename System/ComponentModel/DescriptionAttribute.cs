using System;

namespace System.ComponentModel
{
	/// <summary>Задает описание для свойства или события.</summary>
	// Token: 0x02000366 RID: 870
	[AttributeUsage(AttributeTargets.All)]
	public class DescriptionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DescriptionAttribute" /> без параметров.</summary>
		// Token: 0x06001CE1 RID: 7393 RVA: 0x00068003 File Offset: 0x00066203
		public DescriptionAttribute() : this(string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DescriptionAttribute" /> с указанным описанием.</summary>
		/// <param name="description">Текст описания.</param>
		// Token: 0x06001CE2 RID: 7394 RVA: 0x00068010 File Offset: 0x00066210
		public DescriptionAttribute(string description)
		{
			this.DescriptionValue = description;
		}

		/// <summary>Возвращает описание, хранящееся в данном атрибуте.</summary>
		/// <returns>Описание, хранящееся в данном атрибуте.</returns>
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0006801F File Offset: 0x0006621F
		public virtual string Description
		{
			get
			{
				return this.DescriptionValue;
			}
		}

		/// <summary>Получает или задает строку, хранящуюся в качестве описания.</summary>
		/// <returns>Строка, хранящаяся как описание. Значением по умолчанию является пустая строка ("").</returns>
		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00068027 File Offset: 0x00066227
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0006802F File Offset: 0x0006622F
		protected string DescriptionValue { get; set; }

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.DescriptionAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CE6 RID: 7398 RVA: 0x00068038 File Offset: 0x00066238
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DescriptionAttribute descriptionAttribute = obj as DescriptionAttribute;
			return descriptionAttribute != null && descriptionAttribute.Description == this.Description;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001CE7 RID: 7399 RVA: 0x00068068 File Offset: 0x00066268
		public override int GetHashCode()
		{
			return this.Description.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли этот атрибут <see cref="T:System.ComponentModel.DescriptionAttribute" /> экземпляром по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если это атрибут по умолчанию <see cref="T:System.ComponentModel.DescriptionAttribute" /> по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CE8 RID: 7400 RVA: 0x00068075 File Offset: 0x00066275
		public override bool IsDefaultAttribute()
		{
			return this.Equals(DescriptionAttribute.Default);
		}

		/// <summary>Определяет значение по умолчанию для атрибута <see cref="T:System.ComponentModel.DescriptionAttribute" />, являющееся пустой строкой (""). Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EA2 RID: 3746
		public static readonly DescriptionAttribute Default = new DescriptionAttribute();
	}
}
