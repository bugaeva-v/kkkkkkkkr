using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, должно ли быть локализовано свойство. Этот класс не наследуется.</summary>
	// Token: 0x02000375 RID: 885
	[AttributeUsage(AttributeTargets.All)]
	public sealed class LocalizableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.LocalizableAttribute" />.</summary>
		/// <param name="isLocalizable">Значение <see langword="true" />, если свойство должно быть локализовано; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001D2D RID: 7469 RVA: 0x000685A2 File Offset: 0x000667A2
		public LocalizableAttribute(bool isLocalizable)
		{
			this.IsLocalizable = isLocalizable;
		}

		/// <summary>Возвращает значение, показывающее, должно ли быть локализовано свойство.</summary>
		/// <returns>Значение <see langword="true" />, если свойство должно быть локализовано; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000685B1 File Offset: 0x000667B1
		public bool IsLocalizable { get; }

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.LocalizableAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D2F RID: 7471 RVA: 0x000685BC File Offset: 0x000667BC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			LocalizableAttribute localizableAttribute = obj as LocalizableAttribute;
			bool? flag = (localizableAttribute != null) ? new bool?(localizableAttribute.IsLocalizable) : null;
			bool isLocalizable = this.IsLocalizable;
			return flag.GetValueOrDefault() == isLocalizable & flag != null;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.LocalizableAttribute" />.</returns>
		// Token: 0x06001D30 RID: 7472 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D31 RID: 7473 RVA: 0x00068608 File Offset: 0x00066808
		public override bool IsDefaultAttribute()
		{
			return this.IsLocalizable == LocalizableAttribute.Default.IsLocalizable;
		}

		/// <summary>Определяет, что свойство должно быть локализовано. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EC3 RID: 3779
		public static readonly LocalizableAttribute Yes = new LocalizableAttribute(true);

		/// <summary>Определяет, что свойство не должно быть локализовано. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EC4 RID: 3780
		public static readonly LocalizableAttribute No = new LocalizableAttribute(false);

		/// <summary>Определяет значение по умолчанию, которое равно атрибуту <see cref="F:System.ComponentModel.LocalizableAttribute.No" />. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EC5 RID: 3781
		public static readonly LocalizableAttribute Default = LocalizableAttribute.No;
	}
}
