using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет метаданные для свойства, представляющего поле данных. Этот класс не наследуется.</summary>
	// Token: 0x02000395 RID: 917
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DataObjectFieldAttribute : Attribute
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.ComponentModel.DataObjectFieldAttribute" /> и показывает, является ли поле первичным ключом для строки данных.</summary>
		/// <param name="primaryKey">Значение <see langword="true" />, показывающее, что это поле является первичным ключом строки данных; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001E14 RID: 7700 RVA: 0x0006B57A File Offset: 0x0006977A
		public DataObjectFieldAttribute(bool primaryKey) : this(primaryKey, false, false, -1)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DataObjectFieldAttribute" /> и показывает, является ли поле первичным ключом для строки данных и является ли это поле полем удостоверения базы данных.</summary>
		/// <param name="primaryKey">Значение <see langword="true" />, показывающее, что это поле является первичным ключом строки данных; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isIdentity">Значение <see langword="true" />, показывающее, что это поле является полем удостоверения данных, уникальным образом идентифицирующим строку данных; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001E15 RID: 7701 RVA: 0x0006B586 File Offset: 0x00069786
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity) : this(primaryKey, isIdentity, false, -1)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DataObjectFieldAttribute" /> и показывает, является ли поле первичным ключом для строки данных, является ли оно полем удостоверения данных, и может ли оно принимать значение "null".</summary>
		/// <param name="primaryKey">Значение <see langword="true" />, показывающее, что это поле является первичным ключом строки данных; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isIdentity">Значение <see langword="true" />, показывающее, что это поле является полем удостоверения данных, уникальным образом идентифицирующим строку данных; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isNullable">Значение <see langword="true" />, показывающее, что это поле в хранилище данных может принимать значение "null"; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001E16 RID: 7702 RVA: 0x0006B592 File Offset: 0x00069792
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable) : this(primaryKey, isIdentity, isNullable, -1)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DataObjectFieldAttribute" /> и показывает, является ли поле первичным ключом для строки данных, является ли оно полем удостоверения данных, и может ли оно принимать значение "null", и задает длину поля.</summary>
		/// <param name="primaryKey">Значение <see langword="true" />, показывающее, что это поле является первичным ключом строки данных; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isIdentity">Значение <see langword="true" />, показывающее, что это поле является полем удостоверения данных, уникальным образом идентифицирующим строку данных; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isNullable">Значение <see langword="true" />, показывающее, что это поле в хранилище данных может принимать значение "null"; в противном случае — значение <see langword="false" />.</param>
		/// <param name="length">Длина поля в байтах.</param>
		// Token: 0x06001E17 RID: 7703 RVA: 0x0006B59E File Offset: 0x0006979E
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length)
		{
			this.PrimaryKey = primaryKey;
			this.IsIdentity = isIdentity;
			this.IsNullable = isNullable;
			this.Length = length;
		}

		/// <summary>Возвращает значение, показывающее, представляет ли свойство поле удостоверения в базовых данных.</summary>
		/// <returns>Значение <see langword="true" />, если свойство представляет поле удостоверения в базовых данных; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x0006B5C3 File Offset: 0x000697C3
		public bool IsIdentity { get; }

		/// <summary>Возвращает значение, показывающее, представляет ли свойство поле, которое может принимать значение "null" в базовом хранилище данных.</summary>
		/// <returns>Значение <see langword="true" />, если свойство представляет поле, которое может принимать значение "null" в базовом хранилище данных; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x0006B5CB File Offset: 0x000697CB
		public bool IsNullable { get; }

		/// <summary>Возвращает длину свойства в байтах.</summary>
		/// <returns>Длина свойства в байтах, или -1, если это значение не задано.</returns>
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x0006B5D3 File Offset: 0x000697D3
		public int Length { get; }

		/// <summary>Возвращает значение, показывающее, входит ли свойство в первичный ключ базовых данных.</summary>
		/// <returns>Значение <see langword="true" />, если свойство является первичным ключом хранилища данных; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0006B5DB File Offset: 0x000697DB
		public bool PrimaryKey { get; }

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром атрибута <see cref="T:System.ComponentModel.DataObjectFieldAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если этот экземпляр совпадает с экземпляром, заданным параметром <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E1C RID: 7708 RVA: 0x0006B5E4 File Offset: 0x000697E4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DataObjectFieldAttribute dataObjectFieldAttribute = obj as DataObjectFieldAttribute;
			return dataObjectFieldAttribute != null && dataObjectFieldAttribute.IsIdentity == this.IsIdentity && dataObjectFieldAttribute.IsNullable == this.IsNullable && dataObjectFieldAttribute.Length == this.Length && dataObjectFieldAttribute.PrimaryKey == this.PrimaryKey;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E1D RID: 7709 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
