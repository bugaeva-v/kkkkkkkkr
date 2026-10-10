using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Позволяет пользователю задавать идентификатор ProgID класса.</summary>
	// Token: 0x020006F0 RID: 1776
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	public sealed class ProgIdAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="ProgIdAttribute" />, используя указанный идентификатор ProgID.</summary>
		/// <param name="progId">Идентификатор ProgID, присваиваемый классу.</param>
		// Token: 0x06004074 RID: 16500 RVA: 0x000E0FFD File Offset: 0x000DF1FD
		public ProgIdAttribute(string progId)
		{
			this._val = progId;
		}

		/// <summary>Возвращает идентификатор ProgID класса.</summary>
		/// <returns>Идентификатор ProgID класса.</returns>
		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x000E100C File Offset: 0x000DF20C
		public string Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A3D RID: 10813
		internal string _val;
	}
}
