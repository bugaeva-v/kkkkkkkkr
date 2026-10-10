using System;

namespace System
{
	/// <summary>Указывает на применение другого класса атрибутов. Этот класс не наследуется.</summary>
	// Token: 0x020000FE RID: 254
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	[Serializable]
	public sealed class AttributeUsageAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AttributeUsageAttribute" /> указанным списком <see cref="T:System.AttributeTargets" />, значением свойства <see cref="P:System.AttributeUsageAttribute.AllowMultiple" /> и значением свойства <see cref="P:System.AttributeUsageAttribute.Inherited" />.</summary>
		/// <param name="validOn">Набор значений, определенный при помощи побитовой операции ИЛИ, для определения того, какие элементы программы являются допустимыми.</param>
		// Token: 0x06000751 RID: 1873 RVA: 0x0002172B File Offset: 0x0001F92B
		public AttributeUsageAttribute(AttributeTargets validOn)
		{
			this._attributeTarget = validOn;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0002174C File Offset: 0x0001F94C
		internal AttributeUsageAttribute(AttributeTargets validOn, bool allowMultiple, bool inherited)
		{
			this._attributeTarget = validOn;
			this._allowMultiple = allowMultiple;
			this._inherited = inherited;
		}

		/// <summary>Возвращает или задает набор значений, определяющих, к каким элементам программы может применяться указанный атрибут.</summary>
		/// <returns>Одно или несколько значений <see cref="T:System.AttributeTargets" />. Значение по умолчанию — <see langword="All" />.</returns>
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0002177B File Offset: 0x0001F97B
		public AttributeTargets ValidOn
		{
			get
			{
				return this._attributeTarget;
			}
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, возможно ли для одного элемента программы задать более одного экземпляра указанного атрибута.</summary>
		/// <returns>
		///   <see langword="true" />, если задание более одного экземпляра является допустимым; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00021783 File Offset: 0x0001F983
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0002178B File Offset: 0x0001F98B
		public bool AllowMultiple
		{
			get
			{
				return this._allowMultiple;
			}
			set
			{
				this._allowMultiple = value;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, определяющее, наследуется ли указанный атрибут производными классами и переопределяющими элементами.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если атрибут может наследоваться производными классами и переопределяющими элементами. В противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00021794 File Offset: 0x0001F994
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x0002179C File Offset: 0x0001F99C
		public bool Inherited
		{
			get
			{
				return this._inherited;
			}
			set
			{
				this._inherited = value;
			}
		}

		// Token: 0x04001064 RID: 4196
		private AttributeTargets _attributeTarget = AttributeTargets.All;

		// Token: 0x04001065 RID: 4197
		private bool _allowMultiple;

		// Token: 0x04001066 RID: 4198
		private bool _inherited = true;

		// Token: 0x04001067 RID: 4199
		internal static AttributeUsageAttribute Default = new AttributeUsageAttribute(AttributeTargets.All);
	}
}
