using System;

namespace System.ComponentModel
{
	/// <summary>Определяет метод работы с данными, предоставляемый типом, тип операций, выполняемых методом, и то, является ли этот метод методом работы с данным по умолчанию. Этот класс не наследуется.</summary>
	// Token: 0x02000396 RID: 918
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class DataObjectMethodAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DataObjectMethodAttribute" /> и определяет тип операций с данными, выполняемых методом.</summary>
		/// <param name="methodType">Одно из значений <see cref="T:System.ComponentModel.DataObjectMethodType" />, описывающих операцию с данными, выполняемую методом.</param>
		// Token: 0x06001E1E RID: 7710 RVA: 0x0006B63B File Offset: 0x0006983B
		public DataObjectMethodAttribute(DataObjectMethodType methodType) : this(methodType, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DataObjectMethodAttribute" />, определяет тип операции с данными, выполняемой методом, и определяет является ли этот метод методом работы с данными по умолчанию, предоставляемым объектом данных.</summary>
		/// <param name="methodType">Одно из значений <see cref="T:System.ComponentModel.DataObjectMethodType" />, описывающих операцию с данными, выполняемую методом.</param>
		/// <param name="isDefault">Значение <see langword="true" />, показывающее, что метод, к которому применен атрибут, является методом объекта данных по умолчанию для заданного параметра <paramref name="methodType" />; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001E1F RID: 7711 RVA: 0x0006B645 File Offset: 0x00069845
		public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
		{
			this.MethodType = methodType;
			this.IsDefault = isDefault;
		}

		/// <summary>Возвращает значение, показывающее, является ли метод, к которому применяется атрибут <see cref="T:System.ComponentModel.DataObjectMethodAttribute" />, методом по умолчанию для работы с данными, предоставленным объектом данных для конкретного типа метода.</summary>
		/// <returns>Значение <see langword="true" />, если метод является методом по умолчанию, предоставленным объектом для типа метода; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0006B65B File Offset: 0x0006985B
		public bool IsDefault { get; }

		/// <summary>Возвращает значение <see cref="T:System.ComponentModel.DataObjectMethodType" />, показывающее тип операции с данными, выполняемой методом.</summary>
		/// <returns>Одно из значений <see cref="T:System.ComponentModel.DataObjectMethodType" />, определяющих тип операции с данными, выполняемой методом, к которому применен атрибут <see cref="T:System.ComponentModel.DataObjectMethodAttribute" />.</returns>
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x0006B663 File Offset: 0x00069863
		public DataObjectMethodType MethodType { get; }

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром атрибута <see cref="T:System.ComponentModel.DataObjectMethodAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если этот экземпляр совпадает с экземпляром, заданным параметром <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E22 RID: 7714 RVA: 0x0006B66C File Offset: 0x0006986C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DataObjectMethodAttribute dataObjectMethodAttribute = obj as DataObjectMethodAttribute;
			return dataObjectMethodAttribute != null && dataObjectMethodAttribute.MethodType == this.MethodType && dataObjectMethodAttribute.IsDefault == this.IsDefault;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E23 RID: 7715 RVA: 0x0006B6A8 File Offset: 0x000698A8
		public override int GetHashCode()
		{
			return ((int)this.MethodType).GetHashCode() ^ this.IsDefault.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, использует ли этот экземпляр общую модель с заданным атрибутом.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром атрибута <see cref="T:System.ComponentModel.DataObjectMethodAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если этот экземпляр совпадает с экземпляром, заданным параметром <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E24 RID: 7716 RVA: 0x0006B6D4 File Offset: 0x000698D4
		public override bool Match(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DataObjectMethodAttribute dataObjectMethodAttribute = obj as DataObjectMethodAttribute;
			return dataObjectMethodAttribute != null && dataObjectMethodAttribute.MethodType == this.MethodType;
		}
	}
}
