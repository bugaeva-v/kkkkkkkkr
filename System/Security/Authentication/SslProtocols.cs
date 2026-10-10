using System;

namespace System.Security.Authentication
{
	/// <summary>Определяет возможные версии <see cref="T:System.Security.Authentication.SslProtocols" />.</summary>
	// Token: 0x020002A0 RID: 672
	[Flags]
	public enum SslProtocols
	{
		/// <summary>Позволяет операционной системе выбрать наилучший протокол для использования и блокирования протоколов, которые не являются безопасными. Если к приложению не предъявляется особых требований, следует использовать это поле.</summary>
		// Token: 0x04000BE8 RID: 3048
		None = 0,
		/// <summary>Задается протокол SSL 2.0. Протокол SSL 2.0 был заменен протоколом TLS и предоставляется только в целях обратной совместимости.</summary>
		// Token: 0x04000BE9 RID: 3049
		Ssl2 = 12,
		/// <summary>Задает протокол SSL 3.0. Протокол SSL 3.0 был заменен протоколом TLS и предоставляется только в целях обратной совместимости.</summary>
		// Token: 0x04000BEA RID: 3050
		Ssl3 = 48,
		/// <summary>Задается протокол обеспечения безопасности TLS 1.0. Протокол TLS определяется в документе IETF RFC 2246.</summary>
		// Token: 0x04000BEB RID: 3051
		Tls = 192,
		/// <summary>Задает протокол обеспечения безопасности TLS 1.1. Протокол TLS определяется в документе IETF RFC 4346.</summary>
		// Token: 0x04000BEC RID: 3052
		[MonoTODO("unsupported")]
		Tls11 = 768,
		/// <summary>Задает протокол обеспечения безопасности TLS 1.2. Протокол TLS определяется в документе IETF RFC 5246.</summary>
		// Token: 0x04000BED RID: 3053
		[MonoTODO("unsupported")]
		Tls12 = 3072,
		/// <summary>Задает протокол безопасности TLS 1.3. Протокол TLS определяется в документе IETF RFC 8446.</summary>
		// Token: 0x04000BEE RID: 3054
		Tls13 = 12288,
		/// <summary>Используйте None вместо Default. Значение Default разрешает использовать для переговоров только протоколы SSL 3.0 или TLS 1.0 и в настоящее время считается устаревшим. Следовательно, значение Default не допускается во многих организациях. Несмотря на имя этого поля, <see cref="T:System.Net.Security.SslStream" /> не использует его по умолчанию, за исключением особых случаев.</summary>
		// Token: 0x04000BEF RID: 3055
		Default = 240
	}
}
