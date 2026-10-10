using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, что конструктор для класса относится к определенной категории.</summary>
	// Token: 0x02000368 RID: 872
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class DesignerCategoryAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignerCategoryAttribute" />, используя пустую строку ("").</summary>
		// Token: 0x06001CF0 RID: 7408 RVA: 0x00068145 File Offset: 0x00066345
		public DesignerCategoryAttribute()
		{
			this.Category = string.Empty;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignerCategoryAttribute" />, используя данное имя категории.</summary>
		/// <param name="category">Имя категории.</param>
		// Token: 0x06001CF1 RID: 7409 RVA: 0x00068158 File Offset: 0x00066358
		public DesignerCategoryAttribute(string category)
		{
			this.Category = category;
		}

		/// <summary>Возвращает имя категории.</summary>
		/// <returns>Имя категории.</returns>
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x00068167 File Offset: 0x00066367
		public string Category { get; }

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.DesignOnlyAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CF3 RID: 7411 RVA: 0x00068170 File Offset: 0x00066370
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DesignerCategoryAttribute designerCategoryAttribute = obj as DesignerCategoryAttribute;
			return designerCategoryAttribute != null && designerCategoryAttribute.Category == this.Category;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001CF4 RID: 7412 RVA: 0x000681A0 File Offset: 0x000663A0
		public override int GetHashCode()
		{
			return this.Category.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CF5 RID: 7413 RVA: 0x000681AD File Offset: 0x000663AD
		public override bool IsDefaultAttribute()
		{
			return this.Category.Equals(DesignerCategoryAttribute.Default.Category);
		}

		/// <summary>Возвращает уникальный идентификатор для этого атрибута.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, являющийся уникальным идентификатором атрибута.</returns>
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000681C4 File Offset: 0x000663C4
		public override object TypeId
		{
			get
			{
				return base.GetType().FullName + this.Category;
			}
		}

		/// <summary>Указывает, что компонент, отмеченный этой категорией, использует конструктор компонентов. Это поле доступно только для чтения.</summary>
		// Token: 0x04000EA8 RID: 3752
		public static readonly DesignerCategoryAttribute Component = new DesignerCategoryAttribute("Component");

		/// <summary>Определяет, что компонент, отмеченный этой категорией, не может использовать визуальный конструктор. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EA9 RID: 3753
		public static readonly DesignerCategoryAttribute Default = new DesignerCategoryAttribute();

		/// <summary>Указывает, что компонент, отмеченный этой категорией, использует конструктор форм. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EAA RID: 3754
		public static readonly DesignerCategoryAttribute Form = new DesignerCategoryAttribute("Form");

		/// <summary>Указывает, что компонент, отмеченный этой категорией, использует универсальный конструктор. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EAB RID: 3755
		public static readonly DesignerCategoryAttribute Generic = new DesignerCategoryAttribute("Designer");
	}
}
