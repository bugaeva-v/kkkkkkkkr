using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что значение по умолчанию для параметра или поля с атрибутами является экземпляром <see cref="T:System.Runtime.InteropServices.DispatchWrapper" />, где свойство <see cref="P:System.Runtime.InteropServices.DispatchWrapper.WrappedObject" /> имеет значение <see langword="null" />.</summary>
	// Token: 0x02000835 RID: 2101
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[Serializable]
	public sealed class IDispatchConstantAttribute : CustomConstantAttribute
	{
		/// <summary>Получает константу <see langword="IDispatch" />, хранящуюся в данном атрибуте.</summary>
		/// <returns>Константа <see langword="IDispatch" />, хранящаяся в данном атрибуте. Допустимым значением константы <see langword="null" /> является только <see langword="IDispatch" />.</returns>
		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060046B7 RID: 18103 RVA: 0x000E713A File Offset: 0x000E533A
		public override object Value
		{
			get
			{
				return new DispatchWrapper(null);
			}
		}
	}
}
