using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Содержит флаги <see cref="T:System.Runtime.InteropServices.FUNCFLAGS" />, ранее импортированные для данного метода из библиотеки COM- типов.</summary>
	// Token: 0x020006FA RID: 1786
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class TypeLibFuncAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="TypeLibFuncAttribute" /> заданным значением <see cref="T:System.Runtime.InteropServices.TypeLibFuncFlags" />.</summary>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibFuncFlags" /> для метода с атрибутом, обнаруженное в библиотеке типов, из которой метод был импортирован.</param>
		// Token: 0x06004085 RID: 16517 RVA: 0x000E115C File Offset: 0x000DF35C
		public TypeLibFuncAttribute(TypeLibFuncFlags flags)
		{
			this._val = flags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="TypeLibFuncAttribute" /> заданным значением <see cref="T:System.Runtime.InteropServices.TypeLibFuncFlags" />.</summary>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibFuncFlags" /> для метода с атрибутом, обнаруженное в библиотеке типов, из которой метод был импортирован.</param>
		// Token: 0x06004086 RID: 16518 RVA: 0x000E115C File Offset: 0x000DF35C
		public TypeLibFuncAttribute(short flags)
		{
			this._val = (TypeLibFuncFlags)flags;
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.TypeLibFuncFlags" /> для этого метода.</summary>
		/// <returns>Значение <see cref="T:System.Runtime.InteropServices.TypeLibFuncFlags" /> для этого метода.</returns>
		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06004087 RID: 16519 RVA: 0x000E116B File Offset: 0x000DF36B
		public TypeLibFuncFlags Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A71 RID: 10865
		internal TypeLibFuncFlags _val;
	}
}
