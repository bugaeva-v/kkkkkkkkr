using System;

namespace System.ComponentModel.Design
{
	/// <summary>Определяет идентификаторы GUID, относящиеся к стандартному набору окон инструментов, доступному в среде разработки.</summary>
	// Token: 0x02000478 RID: 1144
	public class StandardToolWindows
	{
		/// <summary>Получает GUID для обозревателя объектов. Это поле доступно только для чтения.</summary>
		// Token: 0x0400147C RID: 5244
		public static readonly Guid ObjectBrowser = new Guid("{970d9861-ee83-11d0-a778-00a0c91110c3}");

		/// <summary>Получает GUID для окна вывода. Это поле доступно только для чтения.</summary>
		// Token: 0x0400147D RID: 5245
		public static readonly Guid OutputWindow = new Guid("{34e76e81-ee4a-11d0-ae2e-00a0c90fffc3}");

		/// <summary>Получает GUID для обозревателя решений. Это поле доступно только для чтения.</summary>
		// Token: 0x0400147E RID: 5246
		public static readonly Guid ProjectExplorer = new Guid("{3ae79031-e1bc-11d0-8f78-00a0c9110057}");

		/// <summary>Получает GUID для окна свойств. Это поле доступно только для чтения.</summary>
		// Token: 0x0400147F RID: 5247
		public static readonly Guid PropertyBrowser = new Guid("{eefa5220-e298-11d0-8f78-00a0c9110057}");

		/// <summary>Получает GUID для фрейма дополнительных ссылок. Это поле доступно только для чтения.</summary>
		// Token: 0x04001480 RID: 5248
		public static readonly Guid RelatedLinks = new Guid("{66dba47c-61df-11d2-aa79-00c04f990343}");

		/// <summary>Получает GUID для обозревателя серверов. Это поле доступно только для чтения.</summary>
		// Token: 0x04001481 RID: 5249
		public static readonly Guid ServerExplorer = new Guid("{74946827-37a0-11d2-a273-00c04f8ef4ff}");

		/// <summary>Получает GUID для списка задач. Это поле доступно только для чтения.</summary>
		// Token: 0x04001482 RID: 5250
		public static readonly Guid TaskList = new Guid("{4a9b7e51-aa16-11d0-a8c5-00a0c921a4d2}");

		/// <summary>Получает GUID для панели инструментов. Это поле доступно только для чтения.</summary>
		// Token: 0x04001483 RID: 5251
		public static readonly Guid Toolbox = new Guid("{b1e99781-ab81-11d0-b683-00aa00a3ee26}");
	}
}
