using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что значение по умолчанию для параметра или поля с атрибутами является экземпляром <see cref="T:System.Runtime.InteropServices.UnknownWrapper" />, где свойство <see cref="P:System.Runtime.InteropServices.UnknownWrapper.WrappedObject" /> имеет значение <see langword="null" />. Этот класс не наследуется.</summary>
	// Token: 0x02000842 RID: 2114
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class IUnknownConstantAttribute : CustomConstantAttribute
	{
		/// <summary>Получает константу <see langword="IUnknown" />, хранящуюся в данном атрибуте.</summary>
		/// <returns>Константа <see langword="IUnknown" />, хранящаяся в данном атрибуте. Допустимым значением константы <see langword="null" /> является только <see langword="IUnknown" />.</returns>
		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x000E7171 File Offset: 0x000E5371
		public override object Value
		{
			get
			{
				return new UnknownWrapper(null);
			}
		}
	}
}
