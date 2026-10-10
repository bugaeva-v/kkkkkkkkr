using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Сообщения трассировки журналов при компиляции инфраструктуры сериализации платформы .NET Framework.</summary>
	// Token: 0x0200067D RID: 1661
	[SecurityCritical]
	[ComVisible(true)]
	public sealed class InternalRM
	{
		/// <summary>Печатает сообщения трассировки SOAP.</summary>
		/// <param name="messages">Массив сообщений трассировки для печати.</param>
		// Token: 0x06003DD6 RID: 15830 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[Conditional("_LOGGING")]
		public static void InfoSoap(params object[] messages)
		{
		}

		/// <summary>Проверяет, включена ли трассировка SOAP.</summary>
		/// <returns>Значение равно <see langword="true" />, если трассировка включена; в противном случае — значение равно <see langword="false" />.</returns>
		// Token: 0x06003DD7 RID: 15831 RVA: 0x000D59B0 File Offset: 0x000D3BB0
		public static bool SoapCheckEnabled()
		{
			return BCLDebug.CheckEnabled("SOAP");
		}
	}
}
