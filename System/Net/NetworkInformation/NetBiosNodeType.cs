using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Указывает тип узла NetBIOS.</summary>
	// Token: 0x0200070C RID: 1804
	public enum NetBiosNodeType
	{
		/// <summary>узел неизвестного типа.</summary>
		// Token: 0x040021FB RID: 8699
		Unknown,
		/// <summary>Широковещательный узел.</summary>
		// Token: 0x040021FC RID: 8700
		Broadcast,
		/// <summary>Одноранговый узел.</summary>
		// Token: 0x040021FD RID: 8701
		Peer2Peer,
		/// <summary>Смешанный узел.</summary>
		// Token: 0x040021FE RID: 8702
		Mixed = 4,
		/// <summary>Гибридный узел.</summary>
		// Token: 0x040021FF RID: 8703
		Hybrid = 8
	}
}
