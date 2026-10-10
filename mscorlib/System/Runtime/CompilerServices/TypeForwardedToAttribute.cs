using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает целевой <see cref="T:System.Type" /> в другой сборке.</summary>
	// Token: 0x0200080A RID: 2058
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class TypeForwardedToAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.TypeForwardedToAttribute" />, задавая целевой <see cref="T:System.Type" />.</summary>
		/// <param name="destination">Целевой <see cref="T:System.Type" /> в другой сборке.</param>
		// Token: 0x06004628 RID: 17960 RVA: 0x000E5999 File Offset: 0x000E3B99
		public TypeForwardedToAttribute(Type destination)
		{
			this.Destination = destination;
		}

		/// <summary>Возвращает целевой <see cref="T:System.Type" /> в другой сборке.</summary>
		/// <returns>Целевой <see cref="T:System.Type" /> в другой сборке.</returns>
		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x000E59A8 File Offset: 0x000E3BA8
		public Type Destination { get; }
	}
}
