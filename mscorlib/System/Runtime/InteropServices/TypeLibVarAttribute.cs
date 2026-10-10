using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Содержит флаги <see cref="T:System.Runtime.InteropServices.VARFLAGS" />, ранее импортированные для данного поля из библиотеки COM-типов.</summary>
	// Token: 0x020006FB RID: 1787
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public sealed class TypeLibVarAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.TypeLibVarAttribute" /> заданным значением <see cref="T:System.Runtime.InteropServices.TypeLibVarFlags" />.</summary>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibVarFlags" /> для поля с атрибутом, обнаруженное в библиотеке типов, из которой выполнялся импорт.</param>
		// Token: 0x06004088 RID: 16520 RVA: 0x000E1173 File Offset: 0x000DF373
		public TypeLibVarAttribute(TypeLibVarFlags flags)
		{
			this._val = flags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.TypeLibVarAttribute" /> заданным значением <see cref="T:System.Runtime.InteropServices.TypeLibVarFlags" />.</summary>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibVarFlags" /> для поля с атрибутом, обнаруженное в библиотеке типов, из которой выполнялся импорт.</param>
		// Token: 0x06004089 RID: 16521 RVA: 0x000E1173 File Offset: 0x000DF373
		public TypeLibVarAttribute(short flags)
		{
			this._val = (TypeLibVarFlags)flags;
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.TypeLibVarFlags" /> для этого поля.</summary>
		/// <returns>Значение <see cref="T:System.Runtime.InteropServices.TypeLibVarFlags" /> для этого поля.</returns>
		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x000E1182 File Offset: 0x000DF382
		public TypeLibVarFlags Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A72 RID: 10866
		internal TypeLibVarFlags _val;
	}
}
