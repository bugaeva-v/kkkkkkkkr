using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, что это свойство может быть использовано в качестве параметра приложения.</summary>
	// Token: 0x020003E3 RID: 995
	[AttributeUsage(AttributeTargets.Property)]
	[Obsolete("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
	public class RecommendedAsConfigurableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.RecommendedAsConfigurableAttribute" />.</summary>
		/// <param name="recommendedAsConfigurable">Значение <see langword="true" />, если свойство, с которым связан этот атрибут, может быть использовано в качестве параметра приложения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060020AC RID: 8364 RVA: 0x00070CE0 File Offset: 0x0006EEE0
		public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable)
		{
			this.RecommendedAsConfigurable = recommendedAsConfigurable;
		}

		/// <summary>Возвращает значение, показывающее, может ли свойство, с которым связан этот атрибут, быть использовано в качестве параметра приложения.</summary>
		/// <returns>Значение <see langword="true" />, если свойство, с которым связан этот атрибут, может быть использовано в качестве параметра приложения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00070CEF File Offset: 0x0006EEEF
		public bool RecommendedAsConfigurable { get; }

		/// <summary>Указывает, равен ли этот экземпляр заданному объекту.</summary>
		/// <param name="obj">Другой объект, подлежащий сравнению.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020AE RID: 8366 RVA: 0x00070CF8 File Offset: 0x0006EEF8
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			RecommendedAsConfigurableAttribute recommendedAsConfigurableAttribute = obj as RecommendedAsConfigurableAttribute;
			return recommendedAsConfigurableAttribute != null && recommendedAsConfigurableAttribute.RecommendedAsConfigurable == this.RecommendedAsConfigurable;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.RecommendedAsConfigurableAttribute" />.</returns>
		// Token: 0x060020AF RID: 8367 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Показывает, является ли значение этого экземпляра значением по умолчанию для класса.</summary>
		/// <returns>Значение <see langword="true" />, если этот экземпляр является атрибутом по умолчанию для класса; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020B0 RID: 8368 RVA: 0x00070D25 File Offset: 0x0006EF25
		public override bool IsDefaultAttribute()
		{
			return !this.RecommendedAsConfigurable;
		}

		/// <summary>Определяет, что свойство не может быть использовано в качестве параметра приложения. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FD4 RID: 4052
		public static readonly RecommendedAsConfigurableAttribute No = new RecommendedAsConfigurableAttribute(false);

		/// <summary>Определяет, что свойство может использоваться в качестве параметра приложения. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FD5 RID: 4053
		public static readonly RecommendedAsConfigurableAttribute Yes = new RecommendedAsConfigurableAttribute(true);

		/// <summary>Задает значение по умолчанию для атрибута <see cref="T:System.ComponentModel.RecommendedAsConfigurableAttribute" />, равное <see cref="F:System.ComponentModel.RecommendedAsConfigurableAttribute.No" />. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FD6 RID: 4054
		public static readonly RecommendedAsConfigurableAttribute Default = RecommendedAsConfigurableAttribute.No;
	}
}
