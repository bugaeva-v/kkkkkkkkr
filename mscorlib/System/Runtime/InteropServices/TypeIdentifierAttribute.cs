using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Обеспечивает поддержку эквивалентности типов.</summary>
	// Token: 0x020006E3 RID: 1763
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class TypeIdentifierAttribute : Attribute
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Runtime.InteropServices.TypeIdentifierAttribute" />.</summary>
		// Token: 0x0600405D RID: 16477 RVA: 0x00002050 File Offset: 0x00000250
		public TypeIdentifierAttribute()
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Runtime.InteropServices.TypeIdentifierAttribute" /> с указанными областью и идентификатором.</summary>
		/// <param name="scope">Первая строка эквивалентности типов.</param>
		/// <param name="identifier">Вторая строка эквивалентности типов.</param>
		// Token: 0x0600405E RID: 16478 RVA: 0x000E0F31 File Offset: 0x000DF131
		public TypeIdentifierAttribute(string scope, string identifier)
		{
			this.Scope_ = scope;
			this.Identifier_ = identifier;
		}

		/// <summary>Получает значение параметра <paramref name="scope" />, переданного конструктору <see cref="M:System.Runtime.InteropServices.TypeIdentifierAttribute.#ctor(System.String,System.String)" />.</summary>
		/// <returns>Значение параметра <paramref name="scope" /> конструктора.</returns>
		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x0600405F RID: 16479 RVA: 0x000E0F47 File Offset: 0x000DF147
		public string Scope
		{
			get
			{
				return this.Scope_;
			}
		}

		/// <summary>Получает значение параметра <paramref name="identifier" />, переданного конструктору <see cref="M:System.Runtime.InteropServices.TypeIdentifierAttribute.#ctor(System.String,System.String)" />.</summary>
		/// <returns>Значение параметра <paramref name="identifier" /> конструктора.</returns>
		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x000E0F4F File Offset: 0x000DF14F
		public string Identifier
		{
			get
			{
				return this.Identifier_;
			}
		}

		// Token: 0x04002A2B RID: 10795
		internal string Scope_;

		// Token: 0x04002A2C RID: 10796
		internal string Identifier_;
	}
}
