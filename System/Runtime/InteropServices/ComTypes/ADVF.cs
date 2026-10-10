using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет требуемое поведение при настройке приемника уведомлений или подключения кэширования к объекту.</summary>
	// Token: 0x02000187 RID: 391
	[Flags]
	public enum ADVF
	{
		/// <summary>При использовании вспомогательных соединений с данными (<see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.DAdvise(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.ADVF,System.Runtime.InteropServices.ComTypes.IAdviseSink,System.Int32@)" /> или <see cref="M:System.Runtime.InteropServices.ComTypes.IConnectionPoint.Advise(System.Object,System.Int32@)" />) этот флаг требует, чтобы объект данных не отправлял данные, когда вызывается <see cref="M:System.Runtime.InteropServices.ComTypes.IAdviseSink.OnDataChange(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />.</summary>
		// Token: 0x040006F1 RID: 1777
		ADVF_NODATA = 1,
		/// <summary>Требует, чтобы объект не ждал изменения данных или представления до выполнения начального вызова <see cref="M:System.Runtime.InteropServices.ComTypes.IAdviseSink.OnDataChange(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" /> (для вспомогательных соединений с данными или представлениями) или обновления кэша (для соединений с кэшем).</summary>
		// Token: 0x040006F2 RID: 1778
		ADVF_PRIMEFIRST = 2,
		/// <summary>Требует, чтобы объект создавал только одно уведомление об изменении или обновление кэша перед удалением соединения.</summary>
		// Token: 0x040006F3 RID: 1779
		ADVF_ONLYONCE = 4,
		/// <summary>Синоним для <see cref="F:System.Runtime.InteropServices.ComTypes.ADVF.ADVFCACHE_FORCEBUILTIN" />, который используется более часто.</summary>
		// Token: 0x040006F4 RID: 1780
		ADVFCACHE_NOHANDLER = 8,
		/// <summary>Это значение используется приложениями объектов DLL и дескрипторами объектов, которые выполняют рисунок своих объектов.</summary>
		// Token: 0x040006F5 RID: 1781
		ADVFCACHE_FORCEBUILTIN = 16,
		/// <summary>Если используются соединения с кэшем, этот флаг обновляет кэшированное представление только при сохранении объекта, содержащего кэш.</summary>
		// Token: 0x040006F6 RID: 1782
		ADVFCACHE_ONSAVE = 32,
		/// <summary>При использовании вспомогательных соединений с данными обеспечивает доступ к данным.</summary>
		// Token: 0x040006F7 RID: 1783
		ADVF_DATAONSTOP = 64
	}
}
