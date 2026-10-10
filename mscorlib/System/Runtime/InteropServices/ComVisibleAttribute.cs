using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Управляет доступностью отдельного управляемого типа или члена либо всех типов в сборки для модели COM.</summary>
	// Token: 0x020006EB RID: 1771
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComVisibleAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="ComVisibleAttribute" />.</summary>
		/// <param name="visibility">Значение <see langword="true" />, если тип видим для COM; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</param>
		// Token: 0x0600406C RID: 16492 RVA: 0x000E0FB3 File Offset: 0x000DF1B3
		public ComVisibleAttribute(bool visibility)
		{
			this._val = visibility;
		}

		/// <summary>Возвращает значение, указывающее, видим ли данный тип для COM.</summary>
		/// <returns>Значение <see langword="true" />, если тип доступен; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x000E0FC2 File Offset: 0x000DF1C2
		public bool Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A3A RID: 10810
		internal bool _val;
	}
}
