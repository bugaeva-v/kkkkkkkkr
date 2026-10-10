using System;

namespace System.ComponentModel
{
	/// <summary>Указывает на возможность задания свойства только во время разработки.</summary>
	// Token: 0x02000367 RID: 871
	[AttributeUsage(AttributeTargets.All)]
	public sealed class DesignOnlyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignOnlyAttribute" />.</summary>
		/// <param name="isDesignOnly">Значение <see langword="true" />, если свойство может быть задано только во время разработки; значение <see langword="false" />, если свойство может быть задано во время разработки и во время выполнения.</param>
		// Token: 0x06001CEA RID: 7402 RVA: 0x0006808E File Offset: 0x0006628E
		public DesignOnlyAttribute(bool isDesignOnly)
		{
			this.IsDesignOnly = isDesignOnly;
		}

		/// <summary>Возвращает значение, показывающее возможность задания свойства только во время разработки.</summary>
		/// <returns>Значение <see langword="true" />, если свойство может быть задано только во время разработки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x0006809D File Offset: 0x0006629D
		public bool IsDesignOnly { get; }

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.DesignOnlyAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CEC RID: 7404 RVA: 0x000680A8 File Offset: 0x000662A8
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DesignOnlyAttribute designOnlyAttribute = obj as DesignOnlyAttribute;
			bool? flag = (designOnlyAttribute != null) ? new bool?(designOnlyAttribute.IsDesignOnly) : null;
			bool isDesignOnly = this.IsDesignOnly;
			return flag.GetValueOrDefault() == isDesignOnly & flag != null;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001CED RID: 7405 RVA: 0x000680F4 File Offset: 0x000662F4
		public override int GetHashCode()
		{
			return this.IsDesignOnly.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CEE RID: 7406 RVA: 0x0006810F File Offset: 0x0006630F
		public override bool IsDefaultAttribute()
		{
			return this.IsDesignOnly == DesignOnlyAttribute.Default.IsDesignOnly;
		}

		/// <summary>Определяет, что свойство может быть установлено только во время разработки. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EA5 RID: 3749
		public static readonly DesignOnlyAttribute Yes = new DesignOnlyAttribute(true);

		/// <summary>Определяет, что свойство может быть задано во время разработки или во время выполнения. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EA6 RID: 3750
		public static readonly DesignOnlyAttribute No = new DesignOnlyAttribute(false);

		/// <summary>Задает значение по умолчанию для атрибута <see cref="T:System.ComponentModel.DesignOnlyAttribute" />, равное <see cref="F:System.ComponentModel.DesignOnlyAttribute.No" />. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EA7 RID: 3751
		public static readonly DesignOnlyAttribute Default = DesignOnlyAttribute.No;
	}
}
