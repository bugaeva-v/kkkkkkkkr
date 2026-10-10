using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	/// <summary>Указывает возможные состояния аренды жизненного цикла.</summary>
	// Token: 0x02000589 RID: 1417
	[ComVisible(true)]
	[Serializable]
	public enum LeaseState
	{
		/// <summary>Аренда не инициализирована.</summary>
		// Token: 0x04002595 RID: 9621
		Null,
		/// <summary>Аренда создана, но еще не активна.</summary>
		// Token: 0x04002596 RID: 9622
		Initial,
		/// <summary>Аренда активна, и ее срок не истек.</summary>
		// Token: 0x04002597 RID: 9623
		Active,
		/// <summary>Срок аренды истек, и идет поиск спонсора.</summary>
		// Token: 0x04002598 RID: 9624
		Renewing,
		/// <summary>Срок аренды истек и его невозможно обновить.</summary>
		// Token: 0x04002599 RID: 9625
		Expired
	}
}
