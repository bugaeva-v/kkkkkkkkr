using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, что неуправляемая подпись метода предполагает наличие параметра идентификатора языкового стандарта LCID.</summary>
	// Token: 0x020006ED RID: 1773
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class LCIDConversionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="LCIDConversionAttribute" />, используя позицию идентификатора LCID в неуправляемой подписи.</summary>
		/// <param name="lcid">Указывает позицию аргумента LCID в неуправляемой подписи, в которой первым аргументом является 0.</param>
		// Token: 0x06004070 RID: 16496 RVA: 0x000E0FE6 File Offset: 0x000DF1E6
		public LCIDConversionAttribute(int lcid)
		{
			this._val = lcid;
		}

		/// <summary>Возвращает позицию аргумента LCID в неуправляемой подписи.</summary>
		/// <returns>Позиция аргумента LCID в неуправляемой подписи, в которой первым аргументом является 0.</returns>
		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x000E0FF5 File Offset: 0x000DF1F5
		public int Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A3C RID: 10812
		internal int _val;
	}
}
