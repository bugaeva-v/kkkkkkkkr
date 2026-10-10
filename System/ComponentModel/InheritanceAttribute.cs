using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, является ли компонент, связанный с этим атрибутом, унаследованным от базового класса. Этот класс не наследуется.</summary>
	// Token: 0x0200039E RID: 926
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class InheritanceAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InheritanceAttribute" />.</summary>
		// Token: 0x06001E4D RID: 7757 RVA: 0x0006BB33 File Offset: 0x00069D33
		public InheritanceAttribute()
		{
			this.InheritanceLevel = InheritanceAttribute.Default.InheritanceLevel;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InheritanceAttribute" />, используя указанный уровень наследования.</summary>
		/// <param name="inheritanceLevel">Объект <see cref="T:System.ComponentModel.InheritanceLevel" />, показывающий уровень наследования, который устанавливается для этого атрибута.</param>
		// Token: 0x06001E4E RID: 7758 RVA: 0x0006BB4B File Offset: 0x00069D4B
		public InheritanceAttribute(InheritanceLevel inheritanceLevel)
		{
			this.InheritanceLevel = inheritanceLevel;
		}

		/// <summary>Получает или задает текущий уровень наследования, хранящийся в этом атрибуте.</summary>
		/// <returns>Уровень <see cref="T:System.ComponentModel.InheritanceLevel" />, хранящийся в этом атрибуте.</returns>
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x0006BB5A File Offset: 0x00069D5A
		public InheritanceLevel InheritanceLevel { get; }

		/// <summary>Нужно переопределить для проверки равенства.</summary>
		/// <param name="value">Объект для тестирования.</param>
		/// <returns>Значение <see langword="true" /> если объекты совпадают; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E50 RID: 7760 RVA: 0x0006BB62 File Offset: 0x00069D62
		public override bool Equals(object value)
		{
			return value == this || (value is InheritanceAttribute && ((InheritanceAttribute)value).InheritanceLevel == this.InheritanceLevel);
		}

		/// <summary>Возвращает хэш-код для данного объекта.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.InheritanceAttribute" />.</returns>
		// Token: 0x06001E51 RID: 7761 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли текущее значение атрибута его значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если текущим значением атрибута является значение по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E52 RID: 7762 RVA: 0x0006BB87 File Offset: 0x00069D87
		public override bool IsDefaultAttribute()
		{
			return this.Equals(InheritanceAttribute.Default);
		}

		/// <summary>Преобразует этот атрибут в строку.</summary>
		/// <returns>Строка, представляющая эту структуру <see cref="T:System.ComponentModel.InheritanceAttribute" />.</returns>
		// Token: 0x06001E53 RID: 7763 RVA: 0x0006BB94 File Offset: 0x00069D94
		public override string ToString()
		{
			return TypeDescriptor.GetConverter(typeof(InheritanceLevel)).ConvertToString(this.InheritanceLevel);
		}

		/// <summary>Указывает, что компонент является унаследованным. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F1D RID: 3869
		public static readonly InheritanceAttribute Inherited = new InheritanceAttribute(InheritanceLevel.Inherited);

		/// <summary>Определяет, что компонент является унаследованным и доступен только для чтения. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F1E RID: 3870
		public static readonly InheritanceAttribute InheritedReadOnly = new InheritanceAttribute(InheritanceLevel.InheritedReadOnly);

		/// <summary>Определяет, что компонент не является унаследованным. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F1F RID: 3871
		public static readonly InheritanceAttribute NotInherited = new InheritanceAttribute(InheritanceLevel.NotInherited);

		/// <summary>Указывает, что значением по умолчанию для атрибута <see cref="T:System.ComponentModel.InheritanceAttribute" /> является <see cref="F:System.ComponentModel.InheritanceAttribute.NotInherited" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F20 RID: 3872
		public static readonly InheritanceAttribute Default = InheritanceAttribute.NotInherited;
	}
}
