using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает идентификатор диспетчера COM (DISPID) для метода, поля или свойства.</summary>
	// Token: 0x020006E5 RID: 1765
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = false)]
	[ComVisible(true)]
	public sealed class DispIdAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="DispIdAttribute" />, используя указанный идентификатор DISPID.</summary>
		/// <param name="dispId">Идентификатор DISPID для этого члена.</param>
		// Token: 0x06004062 RID: 16482 RVA: 0x000E0F57 File Offset: 0x000DF157
		public DispIdAttribute(int dispId)
		{
			this._val = dispId;
		}

		/// <summary>Возвращает идентификатор DISPID для члена.</summary>
		/// <returns>Идентификатор DISPID для этого члена.</returns>
		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x000E0F66 File Offset: 0x000DF166
		public int Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A2D RID: 10797
		internal int _val;
	}
}
