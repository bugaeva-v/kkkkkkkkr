using System;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Определяет значения для типа проверки подлинности, используемый во время входа на сервер удаленного вызова процедур (RPC).
	///          Это имя входа происходит при создании <see cref="T:System.Diagnostics.Eventing.Reader.EventLogSession" /> указывающий соединение с удаленным компьютером.
	///       </summary>
	// Token: 0x0200039C RID: 924
	public enum SessionAuthentication
	{
		/// <summary>
		///         Метод проверки подлинности по умолчанию во время входа RPC.
		///          Проверка подлинности по умолчанию эквивалентен Negotiate.
		///       </summary>
		// Token: 0x04000D43 RID: 3395
		Default,
		/// <summary>
		///         Использование проверки подлинности Kerberos при входе RPC.
		///       </summary>
		// Token: 0x04000D44 RID: 3396
		Kerberos = 2,
		/// <summary>
		///         Метод проверки подлинности Negotiate во время входа RPC.
		///          Это позволяет клиентскому приложению выбрать наиболее подходящий метод проверки подлинности (NTLM или Kerberos) для ситуации.
		///       </summary>
		// Token: 0x04000D45 RID: 3397
		Negotiate = 1,
		/// <summary>
		///         Использовать проверку подлинности Windows NT LAN Manager (NTLM) во время входа RPC.
		///       </summary>
		// Token: 0x04000D46 RID: 3398
		Ntlm = 3
	}
}
