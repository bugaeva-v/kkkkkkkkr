using System;

namespace System.IO
{
	/// <summary>Определяет постоянные величины для типов дисков, включая CDRom, Fixed, Network, NoRootDirectory, Ram, Removable и Unknown.</summary>
	// Token: 0x02000B2D RID: 2861
	public enum DriveType
	{
		/// <summary>Неизвестный тип диска.</summary>
		// Token: 0x04003C1F RID: 15391
		Unknown,
		/// <summary>Диск не содержит корневого каталога.</summary>
		// Token: 0x04003C20 RID: 15392
		NoRootDirectory,
		/// <summary>Диск является съемным устройством хранения, например дисководом гибких дисков или USB-устройством флэш-памяти.</summary>
		// Token: 0x04003C21 RID: 15393
		Removable,
		/// <summary>Диск является жестким диском.</summary>
		// Token: 0x04003C22 RID: 15394
		Fixed,
		/// <summary>Диск является сетевым диском.</summary>
		// Token: 0x04003C23 RID: 15395
		Network,
		/// <summary>Диск — это оптическое дисковое устройство, например компакт-диск или DVD-диск.</summary>
		// Token: 0x04003C24 RID: 15396
		CDRom,
		/// <summary>Диск является диском ОЗУ.</summary>
		// Token: 0x04003C25 RID: 15397
		Ram
	}
}
