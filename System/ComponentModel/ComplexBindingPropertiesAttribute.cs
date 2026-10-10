using System;

namespace System.ComponentModel
{
	/// <summary>Задает источник данных и свойства элемента данных для компонента, поддерживающего сложную привязку данных. Этот класс не наследуется.</summary>
	// Token: 0x0200038D RID: 909
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ComplexBindingPropertiesAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" /> без параметров.</summary>
		// Token: 0x06001DE0 RID: 7648 RVA: 0x00003D9F File Offset: 0x00001F9F
		public ComplexBindingPropertiesAttribute()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />, используя указанный источник данных.</summary>
		/// <param name="dataSource">Имя свойства, используемого в качестве источника данных.</param>
		// Token: 0x06001DE1 RID: 7649 RVA: 0x00069A52 File Offset: 0x00067C52
		public ComplexBindingPropertiesAttribute(string dataSource)
		{
			this.DataSource = dataSource;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />, используя указанный источник данных и элемент данных.</summary>
		/// <param name="dataSource">Имя свойства, используемого в качестве источника данных.</param>
		/// <param name="dataMember">Имя свойства, используемого в качестве источника данных.</param>
		// Token: 0x06001DE2 RID: 7650 RVA: 0x00069A61 File Offset: 0x00067C61
		public ComplexBindingPropertiesAttribute(string dataSource, string dataMember)
		{
			this.DataSource = dataSource;
			this.DataMember = dataMember;
		}

		/// <summary>Возвращает имя свойства источника данных для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />.</summary>
		/// <returns>Имя свойства источника данных для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />.</returns>
		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00069A77 File Offset: 0x00067C77
		public string DataSource { get; }

		/// <summary>Возвращает имя свойства элемента данных для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />.</summary>
		/// <returns>Имя свойства элемента данных для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />.</returns>
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00069A7F File Offset: 0x00067C7F
		public string DataMember { get; }

		/// <summary>Определяет, равен ли указанный объект <see cref="T:System.Object" /> текущему экземпляру <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для сравнения с текущим экземпляром <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если объект равен текущему экземпляру; в противном случае — значение <see langword="false" />, сообщающее о неравенстве.</returns>
		// Token: 0x06001DE5 RID: 7653 RVA: 0x00069A88 File Offset: 0x00067C88
		public override bool Equals(object obj)
		{
			ComplexBindingPropertiesAttribute complexBindingPropertiesAttribute = obj as ComplexBindingPropertiesAttribute;
			return complexBindingPropertiesAttribute != null && complexBindingPropertiesAttribute.DataSource == this.DataSource && complexBindingPropertiesAttribute.DataMember == this.DataMember;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001DE6 RID: 7654 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Представляет значение по умолчанию для класса <see cref="T:System.ComponentModel.ComplexBindingPropertiesAttribute" />.</summary>
		// Token: 0x04000EFE RID: 3838
		public static readonly ComplexBindingPropertiesAttribute Default = new ComplexBindingPropertiesAttribute();
	}
}
