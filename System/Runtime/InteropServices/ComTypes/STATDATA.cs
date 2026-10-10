using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение структуры <see langword="STATDATA" />.</summary>
	// Token: 0x0200018F RID: 399
	public struct STATDATA
	{
		/// <summary>Представляет значение перечисления <see cref="T:System.Runtime.InteropServices.ComTypes.ADVF" />, определяющее, когда приемник будет уведомлен об изменениях в данных.</summary>
		// Token: 0x04000705 RID: 1797
		public ADVF advf;

		/// <summary>Представляет интерфейс <see cref="T:System.Runtime.InteropServices.ComTypes.IAdviseSink" />, который будет получать уведомления об изменениях.</summary>
		// Token: 0x04000706 RID: 1798
		public IAdviseSink advSink;

		/// <summary>Представляет маркер, уникально определяющий вспомогательное соединение. Этот маркер возвращается методом, настраивающим вспомогательное соединение.</summary>
		// Token: 0x04000707 RID: 1799
		public int connection;

		/// <summary>Представляет структуру <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> для данных, интересующих приемник уведомлений. Приемник получает уведомление об изменениях в данных, заданных этой структурой <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />.</summary>
		// Token: 0x04000708 RID: 1800
		public FORMATETC formatetc;
	}
}
