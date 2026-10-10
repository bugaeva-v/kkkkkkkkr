using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, какой тип использовать в качестве преобразователя для объекта, с которым связан этот атрибут.</summary>
	// Token: 0x020003F2 RID: 1010
	[AttributeUsage(AttributeTargets.All)]
	public sealed class TypeConverterAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeConverterAttribute" />, используя заданный по умолчанию преобразователь типов, представляющий собой пустую строку ("").</summary>
		// Token: 0x060020FB RID: 8443 RVA: 0x00071BAF File Offset: 0x0006FDAF
		public TypeConverterAttribute()
		{
			this.ConverterTypeName = string.Empty;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeConverterAttribute" />, используя заданный тип в качестве преобразователя данных для объекта, с которым связан этот атрибут.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, представляющий тип класса преобразователя, используемого с целью преобразования данных для объекта, с которым связан этот атрибут.</param>
		// Token: 0x060020FC RID: 8444 RVA: 0x00071BC2 File Offset: 0x0006FDC2
		public TypeConverterAttribute(Type type)
		{
			this.ConverterTypeName = type.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeConverterAttribute" />, используя заданное имя типа в качестве преобразователя данных для объекта, с которым связан этот атрибут.</summary>
		/// <param name="typeName">Полное имя класса, который будет использован в качестве преобразователя данных для объекта, с которым связан этот атрибут.</param>
		// Token: 0x060020FD RID: 8445 RVA: 0x00071BD6 File Offset: 0x0006FDD6
		public TypeConverterAttribute(string typeName)
		{
			this.ConverterTypeName = typeName;
		}

		/// <summary>Возвращает полное имя типа <see cref="T:System.Type" />, используемого в качестве преобразователя для объекта, с которым связан этот атрибут.</summary>
		/// <returns>Полное имя типа <see cref="T:System.Type" />, используемого в качестве преобразователя для объекта, с которым связан этот атрибут, или пустая строка (""), если этот тип не существует. Значением по умолчанию является пустая строка ("").</returns>
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x00071BE5 File Offset: 0x0006FDE5
		public string ConverterTypeName { get; }

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.TypeConverterAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего атрибута <see cref="T:System.ComponentModel.TypeConverterAttribute" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020FF RID: 8447 RVA: 0x00071BF0 File Offset: 0x0006FDF0
		public override bool Equals(object obj)
		{
			TypeConverterAttribute typeConverterAttribute = obj as TypeConverterAttribute;
			return typeConverterAttribute != null && typeConverterAttribute.ConverterTypeName == this.ConverterTypeName;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.TypeConverterAttribute" />.</returns>
		// Token: 0x06002100 RID: 8448 RVA: 0x00071C1A File Offset: 0x0006FE1A
		public override int GetHashCode()
		{
			return this.ConverterTypeName.GetHashCode();
		}

		/// <summary>Определяет, какой тип использовать в качестве преобразователя для объекта, с которым связан этот атрибут.</summary>
		// Token: 0x04000FF1 RID: 4081
		public static readonly TypeConverterAttribute Default = new TypeConverterAttribute();
	}
}
