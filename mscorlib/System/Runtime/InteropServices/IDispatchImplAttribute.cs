using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, какая реализация <see langword="IDispatch" /> используется средой CLR при предоставлении COM сдвоенных и диспетчерских интерфейсов.</summary>
	// Token: 0x020006F3 RID: 1779
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, Inherited = false)]
	[Obsolete("This attribute is deprecated and will be removed in a future version.", false)]
	public sealed class IDispatchImplAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="IDispatchImplAttribute" />, используя заданное значение <see cref="T:System.Runtime.InteropServices.IDispatchImplType" />.</summary>
		/// <param name="implType">Указывает, какое перечисление <see cref="T:System.Runtime.InteropServices.IDispatchImplType" /> будет использоваться.</param>
		// Token: 0x06004078 RID: 16504 RVA: 0x000E102B File Offset: 0x000DF22B
		public IDispatchImplAttribute(IDispatchImplType implType)
		{
			this._val = implType;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="IDispatchImplAttribute" />, используя заданное значение <see cref="T:System.Runtime.InteropServices.IDispatchImplType" />.</summary>
		/// <param name="implType">Указывает, какое перечисление <see cref="T:System.Runtime.InteropServices.IDispatchImplType" /> будет использоваться.</param>
		// Token: 0x06004079 RID: 16505 RVA: 0x000E102B File Offset: 0x000DF22B
		public IDispatchImplAttribute(short implType)
		{
			this._val = (IDispatchImplType)implType;
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.IDispatchImplType" />, используемое классом.</summary>
		/// <returns>Значение <see cref="T:System.Runtime.InteropServices.IDispatchImplType" />, используемое классом.</returns>
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x000E103A File Offset: 0x000DF23A
		public IDispatchImplType Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A43 RID: 10819
		internal IDispatchImplType _val;
	}
}
