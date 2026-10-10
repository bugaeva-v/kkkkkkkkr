using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет явный идентификатор <see cref="T:System.Guid" /> в случае, когда использование автоматического идентификатора GUID нежелательно.</summary>
	// Token: 0x020006FF RID: 1791
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	public sealed class GuidAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.GuidAttribute" /> с заданным идентификатором GUID.</summary>
		/// <param name="guid">Присваиваемый идентификатор <see cref="T:System.Guid" />.</param>
		// Token: 0x0600408E RID: 16526 RVA: 0x000E11B2 File Offset: 0x000DF3B2
		public GuidAttribute(string guid)
		{
			this._val = guid;
		}

		/// <summary>Возвращает идентификатор <see cref="T:System.Guid" /> класса.</summary>
		/// <returns>Идентификатор <see cref="T:System.Guid" /> класса.</returns>
		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x000E11C1 File Offset: 0x000DF3C1
		public string Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002AC7 RID: 10951
		internal string _val;
	}
}
