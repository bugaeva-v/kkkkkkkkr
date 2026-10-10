using System;

namespace System.ComponentModel
{
	/// <summary>Определяет свойства, поддерживающие привязку на основе поиска. Этот класс не наследуется.</summary>
	// Token: 0x020003D3 RID: 979
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class LookupBindingPropertiesAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" /> без параметров.</summary>
		// Token: 0x06001F98 RID: 8088 RVA: 0x0006D6C7 File Offset: 0x0006B8C7
		public LookupBindingPropertiesAttribute()
		{
			this.DataSource = null;
			this.DisplayMember = null;
			this.ValueMember = null;
			this.LookupMember = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</summary>
		/// <param name="dataSource">Имя свойства, используемого в качестве источника данных.</param>
		/// <param name="displayMember">Имя свойства, используемого для отображаемого имени.</param>
		/// <param name="valueMember">Имя свойства, используемого в качестве источника значений.</param>
		/// <param name="lookupMember">Имя свойства, используемого для поиска.</param>
		// Token: 0x06001F99 RID: 8089 RVA: 0x0006D6EB File Offset: 0x0006B8EB
		public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
		{
			this.DataSource = dataSource;
			this.DisplayMember = displayMember;
			this.ValueMember = valueMember;
			this.LookupMember = lookupMember;
		}

		/// <summary>Возвращает имя свойства источника данных для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</summary>
		/// <returns>Свойство источника данных для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</returns>
		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x0006D710 File Offset: 0x0006B910
		public string DataSource { get; }

		/// <summary>Возвращает свойство элемента отображения для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</summary>
		/// <returns>Имя свойства элемента отображения для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</returns>
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0006D718 File Offset: 0x0006B918
		public string DisplayMember { get; }

		/// <summary>Возвращает имя свойства элемента значения для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</summary>
		/// <returns>Имя свойства элемента значения для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</returns>
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x0006D720 File Offset: 0x0006B920
		public string ValueMember { get; }

		/// <summary>Возвращает имя элемента поиска для компонента, к которому привязан этот атрибут.</summary>
		/// <returns>Имя свойства элемента поиска для компонента, к которому привязан атрибут <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</returns>
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0006D728 File Offset: 0x0006B928
		public string LookupMember { get; }

		/// <summary>Определяет, равен ли указанный объект <see cref="T:System.Object" /> текущему экземпляру <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для сравнения с текущим экземпляром <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если объект равен текущему экземпляру; в противном случае — значение <see langword="false" />, сообщающее о неравенстве.</returns>
		// Token: 0x06001F9E RID: 8094 RVA: 0x0006D730 File Offset: 0x0006B930
		public override bool Equals(object obj)
		{
			LookupBindingPropertiesAttribute lookupBindingPropertiesAttribute = obj as LookupBindingPropertiesAttribute;
			return lookupBindingPropertiesAttribute != null && lookupBindingPropertiesAttribute.DataSource == this.DataSource && lookupBindingPropertiesAttribute.DisplayMember == this.DisplayMember && lookupBindingPropertiesAttribute.ValueMember == this.ValueMember && lookupBindingPropertiesAttribute.LookupMember == this.LookupMember;
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</returns>
		// Token: 0x06001F9F RID: 8095 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Представляет значение по умолчанию для класса <see cref="T:System.ComponentModel.LookupBindingPropertiesAttribute" />.</summary>
		// Token: 0x04000F75 RID: 3957
		public static readonly LookupBindingPropertiesAttribute Default = new LookupBindingPropertiesAttribute();
	}
}
