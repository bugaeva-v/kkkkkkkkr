using System;

namespace System.ComponentModel
{
	/// <summary>Задает строку фильтра и тип фильтра для использования в качестве элемента панели инструментов.</summary>
	// Token: 0x020003F0 RID: 1008
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[Serializable]
	public sealed class ToolboxItemFilterAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" />, используя заданную строку фильтра.</summary>
		/// <param name="filterString">Строка фильтра для элемента панели инструментов.</param>
		// Token: 0x060020F2 RID: 8434 RVA: 0x00071A83 File Offset: 0x0006FC83
		public ToolboxItemFilterAttribute(string filterString) : this(filterString, ToolboxItemFilterType.Allow)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" />, используя заданные строку фильтра и тип фильтра.</summary>
		/// <param name="filterString">Строка фильтра для элемента панели инструментов.</param>
		/// <param name="filterType">Объект <see cref="T:System.ComponentModel.ToolboxItemFilterType" />, указывающий тип фильтра.</param>
		// Token: 0x060020F3 RID: 8435 RVA: 0x00071A8D File Offset: 0x0006FC8D
		public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
		{
			this.FilterString = (filterString ?? string.Empty);
			this.FilterType = filterType;
		}

		/// <summary>Возвращает строку фильтра для элемента панели инструментов.</summary>
		/// <returns>Строка фильтра для элемента панели инструментов.</returns>
		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x00071AAC File Offset: 0x0006FCAC
		public string FilterString { get; }

		/// <summary>Возвращает тип фильтра.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.ToolboxItemFilterType" />, указывающий тип фильтра.</returns>
		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x00071AB4 File Offset: 0x0006FCB4
		public ToolboxItemFilterType FilterType { get; }

		/// <summary>Возвращает идентификатор типа для этого атрибута.</summary>
		/// <returns>Идентификатор типа для этого атрибута. Для всех объектом <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" /> с одинаковыми строками фильтра возвращаются одинаковые идентификаторы типа</returns>
		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x00071ABC File Offset: 0x0006FCBC
		public override object TypeId
		{
			get
			{
				string result;
				if ((result = this._typeId) == null)
				{
					result = (this._typeId = base.GetType().FullName + this.FilterString);
				}
				return result;
			}
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для сравнения с этим экземпляром или пустая ссылка (<see langword="Nothing" /> в Visual Basic).</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060020F7 RID: 8439 RVA: 0x00071AF4 File Offset: 0x0006FCF4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ToolboxItemFilterAttribute toolboxItemFilterAttribute = obj as ToolboxItemFilterAttribute;
			return toolboxItemFilterAttribute != null && toolboxItemFilterAttribute.FilterType.Equals(this.FilterType) && toolboxItemFilterAttribute.FilterString.Equals(this.FilterString);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060020F8 RID: 8440 RVA: 0x00071B45 File Offset: 0x0006FD45
		public override int GetHashCode()
		{
			return this.FilterString.GetHashCode();
		}

		/// <summary>Показывает, содержит ли заданный объект соответствующую строку фильтра.</summary>
		/// <param name="obj">Объект, в котором проверяется соответствующая строка фильтра.</param>
		/// <returns>Значение <see langword="true" />, если заданный объект содержит соответствующую строку фильтра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020F9 RID: 8441 RVA: 0x00071B54 File Offset: 0x0006FD54
		public override bool Match(object obj)
		{
			ToolboxItemFilterAttribute toolboxItemFilterAttribute = obj as ToolboxItemFilterAttribute;
			return toolboxItemFilterAttribute != null && toolboxItemFilterAttribute.FilterString.Equals(this.FilterString);
		}

		/// <summary>Возвращает строку, представляющую текущий объект.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x060020FA RID: 8442 RVA: 0x00071B83 File Offset: 0x0006FD83
		public override string ToString()
		{
			return this.FilterString + "," + Enum.GetName(typeof(ToolboxItemFilterType), this.FilterType);
		}

		// Token: 0x04000FE9 RID: 4073
		private string _typeId;
	}
}
