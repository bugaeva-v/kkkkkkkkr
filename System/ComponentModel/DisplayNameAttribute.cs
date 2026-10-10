using System;

namespace System.ComponentModel
{
	/// <summary>Задает отображаемое имя свойства, события или открытого метода типа void, не принимающего аргументов.</summary>
	// Token: 0x0200036B RID: 875
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class DisplayNameAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DisplayNameAttribute" />.</summary>
		// Token: 0x06001CFE RID: 7422 RVA: 0x000682B2 File Offset: 0x000664B2
		public DisplayNameAttribute() : this(string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DisplayNameAttribute" />, используя отображаемое имя.</summary>
		/// <param name="displayName">Отображаемое имя.</param>
		// Token: 0x06001CFF RID: 7423 RVA: 0x000682BF File Offset: 0x000664BF
		public DisplayNameAttribute(string displayName)
		{
			this.DisplayNameValue = displayName;
		}

		/// <summary>Возвращает отображаемое имя для свойства, события или открытого метода типа void, не принимающего аргументов, хранящихся в этом атрибуте.</summary>
		/// <returns>Отображаемое имя.</returns>
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x000682CE File Offset: 0x000664CE
		public virtual string DisplayName
		{
			get
			{
				return this.DisplayNameValue;
			}
		}

		/// <summary>Возвращает или задает отображаемое имя.</summary>
		/// <returns>Отображаемое имя.</returns>
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x000682D6 File Offset: 0x000664D6
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x000682DE File Offset: 0x000664DE
		protected string DisplayNameValue { get; set; }

		/// <summary>Определяет, равны ли два экземпляра <see cref="T:System.ComponentModel.DisplayNameAttribute" />.</summary>
		/// <param name="obj">Атрибут <see cref="T:System.ComponentModel.DisplayNameAttribute" />, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего объекта; в противном случае — значение <see langword="false" />, если нет.</returns>
		// Token: 0x06001D03 RID: 7427 RVA: 0x000682E8 File Offset: 0x000664E8
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DisplayNameAttribute displayNameAttribute = obj as DisplayNameAttribute;
			return displayNameAttribute != null && displayNameAttribute.DisplayName == this.DisplayName;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.DisplayNameAttribute" />.</returns>
		// Token: 0x06001D04 RID: 7428 RVA: 0x00068318 File Offset: 0x00066518
		public override int GetHashCode()
		{
			return this.DisplayName.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D05 RID: 7429 RVA: 0x00068325 File Offset: 0x00066525
		public override bool IsDefaultAttribute()
		{
			return this.Equals(DisplayNameAttribute.Default);
		}

		/// <summary>Определяет значение по умолчанию для атрибута <see cref="T:System.ComponentModel.DisplayNameAttribute" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04000EB6 RID: 3766
		public static readonly DisplayNameAttribute Default = new DisplayNameAttribute();
	}
}
