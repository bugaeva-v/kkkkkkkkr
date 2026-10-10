using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Представляет структуру, используемую в интерфейсе <see cref="T:System.EnterpriseServices.ITransaction" />.</summary>
	// Token: 0x02000056 RID: 86
	[ComVisible(false)]
	public struct XACTTRANSINFO
	{
		/// <summary>Задает значение, равное нулю. Данное поле зарезервировано.</summary>
		// Token: 0x040000B0 RID: 176
		public int grfRMSupported;

		/// <summary>Задает значение, равное нулю. Данное поле зарезервировано.</summary>
		// Token: 0x040000B1 RID: 177
		public int grfRMSupportedRetaining;

		/// <summary>Представляет битовую маску, указывающую, какие флаги <see langword="grfTC" /> поддерживаются в реализации данной транзакции.</summary>
		// Token: 0x040000B2 RID: 178
		public int grfTCSupported;

		/// <summary>Задает значение, равное нулю. Данное поле зарезервировано.</summary>
		// Token: 0x040000B3 RID: 179
		public int grfTCSupportedRetaining;

		/// <summary>Задает значение, равное нулю. Данное поле зарезервировано.</summary>
		// Token: 0x040000B4 RID: 180
		public int isoFlags;

		/// <summary>Представляет уровень изоляции, связанный с этим объектом транзакции. Значение ISOLATIONLEVEL_UNSPECIFIED показывает, что уровень изоляции не указан.</summary>
		// Token: 0x040000B5 RID: 181
		public int isoLevel;

		/// <summary>Представляет единицу работы, связанную с этой транзакцией.</summary>
		// Token: 0x040000B6 RID: 182
		public BOID uow;
	}
}
