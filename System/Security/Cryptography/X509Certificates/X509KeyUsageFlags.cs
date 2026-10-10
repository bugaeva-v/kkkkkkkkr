using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Определяет способ использования ключа сертификата. Если это значение не определено, ключ может использоваться для любых целей.</summary>
	// Token: 0x020002C5 RID: 709
	[Flags]
	public enum X509KeyUsageFlags
	{
		/// <summary>Параметры использования ключа отсутствуют.</summary>
		// Token: 0x04000CA8 RID: 3240
		None = 0,
		/// <summary>Ключ можно использовать только для шифрования.</summary>
		// Token: 0x04000CA9 RID: 3241
		EncipherOnly = 1,
		/// <summary>Ключ можно использовать для подписания списка отзыва сертификатов (CRL).</summary>
		// Token: 0x04000CAA RID: 3242
		CrlSign = 2,
		/// <summary>Ключ можно использовать для подписания сертификатов.</summary>
		// Token: 0x04000CAB RID: 3243
		KeyCertSign = 4,
		/// <summary>Ключ можно использовать для определения согласования ключа, например ключа, созданного с использованием алгоритма согласования ключей Диффи — Хелмана.</summary>
		// Token: 0x04000CAC RID: 3244
		KeyAgreement = 8,
		/// <summary>Ключ можно использовать для шифрования данных.</summary>
		// Token: 0x04000CAD RID: 3245
		DataEncipherment = 16,
		/// <summary>Ключ можно использовать для шифрования ключей.</summary>
		// Token: 0x04000CAE RID: 3246
		KeyEncipherment = 32,
		/// <summary>Ключ можно использовать для проверки подлинности.</summary>
		// Token: 0x04000CAF RID: 3247
		NonRepudiation = 64,
		/// <summary>Ключ можно использовать как цифровую подпись.</summary>
		// Token: 0x04000CB0 RID: 3248
		DigitalSignature = 128,
		/// <summary>Ключ можно использовать только для расшифровки.</summary>
		// Token: 0x04000CB1 RID: 3249
		DecipherOnly = 32768
	}
}
