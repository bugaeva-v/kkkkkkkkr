using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Указывает, что поле может использоваться в контрактах методов, если видимость поля меньше, чем видимость метода.</summary>
	// Token: 0x020009CB RID: 2507
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ContractPublicPropertyNameAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Contracts.ContractPublicPropertyNameAttribute" />.</summary>
		/// <param name="name">Имя применяемого к полю свойства.</param>
		// Token: 0x06005A05 RID: 23045 RVA: 0x00133D64 File Offset: 0x00131F64
		public ContractPublicPropertyNameAttribute(string name)
		{
			this._publicName = name;
		}

		/// <summary>Получает имя свойства, применяемого к полю.</summary>
		/// <returns>Имя свойства, которое следует применить к полю.</returns>
		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06005A06 RID: 23046 RVA: 0x00133D73 File Offset: 0x00131F73
		public string Name
		{
			get
			{
				return this._publicName;
			}
		}

		// Token: 0x040037A6 RID: 14246
		private string _publicName;
	}
}
