using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что импортирующий компилятор должен полностью понимать семантику определения типа либо отказаться от его использования.  Этот класс не наследуется.</summary>
	// Token: 0x02000847 RID: 2119
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class RequiredAttributeAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.RequiredAttributeAttribute" />.</summary>
		/// <param name="requiredContract">Тип, который должен быть полностью понятен импортирующему компилятору.  
		/// Этот параметр не поддерживается в версии .NET Framework 2.0 и более поздних.</param>
		// Token: 0x060046C5 RID: 18117 RVA: 0x000E71B5 File Offset: 0x000E53B5
		public RequiredAttributeAttribute(Type requiredContract)
		{
			this.requiredContract = requiredContract;
		}

		/// <summary>Возвращает тип, который должен быть полностью понятен импортирующему компилятору.</summary>
		/// <returns>Тип, который должен быть полностью понятен импортирующему компилятору.</returns>
		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060046C6 RID: 18118 RVA: 0x000E71C4 File Offset: 0x000E53C4
		public Type RequiredContract
		{
			get
			{
				return this.requiredContract;
			}
		}

		// Token: 0x04002D8F RID: 11663
		private Type requiredContract;
	}
}
