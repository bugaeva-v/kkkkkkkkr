using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, что таблица свойств должна обновляться при изменении значения связанного свойства. Этот класс не наследуется.</summary>
	// Token: 0x02000437 RID: 1079
	[AttributeUsage(AttributeTargets.All)]
	public sealed class RefreshPropertiesAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.RefreshPropertiesAttribute" />.</summary>
		/// <param name="refresh">Значение <see cref="T:System.ComponentModel.RefreshProperties" />, показывающее природу обновления.</param>
		// Token: 0x06002367 RID: 9063 RVA: 0x00080D14 File Offset: 0x0007EF14
		public RefreshPropertiesAttribute(RefreshProperties refresh)
		{
			this.refresh = refresh;
		}

		/// <summary>Возвращает или устанавливает свойства обновления для элемента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.RefreshProperties" />, показывающий текущие свойства обновления для элемента.</returns>
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x00080D23 File Offset: 0x0007EF23
		public RefreshProperties RefreshProperties
		{
			get
			{
				return this.refresh;
			}
		}

		/// <summary>Переопределяет метод <see cref="Overload:System.Object.Equals" /> объекта.</summary>
		/// <param name="value">Объект для проверки на равенство.</param>
		/// <returns>Значение <see langword="true" />, если указанные объекты совпадают; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002369 RID: 9065 RVA: 0x00080D2B File Offset: 0x0007EF2B
		public override bool Equals(object value)
		{
			return value is RefreshPropertiesAttribute && ((RefreshPropertiesAttribute)value).RefreshProperties == this.refresh;
		}

		/// <summary>Возвращает хэш-код для этого объекта.</summary>
		/// <returns>Хэш-код для объекта, которому принадлежит данный атрибут.</returns>
		// Token: 0x0600236A RID: 9066 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли текущее значение атрибута его значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если текущим значением атрибута является значение по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600236B RID: 9067 RVA: 0x00080D4A File Offset: 0x0007EF4A
		public override bool IsDefaultAttribute()
		{
			return this.Equals(RefreshPropertiesAttribute.Default);
		}

		/// <summary>Показывает, что при изменении значения свойства все свойства будут опрошены и обновлены повторно. Это поле доступно только для чтения.</summary>
		// Token: 0x040010A2 RID: 4258
		public static readonly RefreshPropertiesAttribute All = new RefreshPropertiesAttribute(RefreshProperties.All);

		/// <summary>Показывает, что при изменении значения свойства будет обновлено представление всех свойств. Это поле доступно только для чтения.</summary>
		// Token: 0x040010A3 RID: 4259
		public static readonly RefreshPropertiesAttribute Repaint = new RefreshPropertiesAttribute(RefreshProperties.Repaint);

		/// <summary>Показывает, что при изменении значения свойства другие свойства обновлять не нужно. Это поле доступно только для чтения.</summary>
		// Token: 0x040010A4 RID: 4260
		public static readonly RefreshPropertiesAttribute Default = new RefreshPropertiesAttribute(RefreshProperties.None);

		// Token: 0x040010A5 RID: 4261
		private RefreshProperties refresh;
	}
}
