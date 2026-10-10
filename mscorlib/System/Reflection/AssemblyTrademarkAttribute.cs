using System;

namespace System.Reflection
{
	/// <summary>Определяет настраиваемый атрибут товарного знака для манифеста сборки.</summary>
	// Token: 0x02000890 RID: 2192
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTrademarkAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyTrademarkAttribute" />.</summary>
		/// <param name="trademark">Сведения о товарном знаке.</param>
		// Token: 0x06004876 RID: 18550 RVA: 0x000EE1A0 File Offset: 0x000EC3A0
		public AssemblyTrademarkAttribute(string trademark)
		{
			this.Trademark = trademark;
		}

		/// <summary>Возвращает сведения о товарном знаке.</summary>
		/// <returns>Объект <see langword="String" />, содержащий сведения о товарном знаке.</returns>
		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06004877 RID: 18551 RVA: 0x000EE1AF File Offset: 0x000EC3AF
		public string Trademark { get; }
	}
}
