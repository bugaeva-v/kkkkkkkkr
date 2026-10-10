using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает условия, при которых должна проводиться проверка сертификатов цепочки X509.</summary>
	// Token: 0x020002CA RID: 714
	[Flags]
	public enum X509VerificationFlags
	{
		/// <summary>Не включены флаги, относящиеся к проверке.</summary>
		// Token: 0x04000CC6 RID: 3270
		NoFlag = 0,
		/// <summary>При проверке сертификата не учитывать сертификаты в цепочке, которые недействительны, так как срок их действия истек или не наступил.</summary>
		// Token: 0x04000CC7 RID: 3271
		IgnoreNotTimeValid = 1,
		/// <summary>При проверке сертификата не учитывать, что список доверия сертификатов (CTL) недействителен, например, из-за истечения срока действия списка доверия сертификатов.</summary>
		// Token: 0x04000CC8 RID: 3272
		IgnoreCtlNotTimeValid = 2,
		/// <summary>При проверке сертификата не учитывать, что сертификат центра сертификации (ЦС) и выданный сертификат имеют сроки действия, которые не являются вложенными. Например, сертификат ЦС может действовать с 1 января по 1 декабря, а выданный сертификат — со 2 января по 2 декабря, что означает, что сроки действия не являются вложенными.</summary>
		// Token: 0x04000CC9 RID: 3273
		IgnoreNotTimeNested = 4,
		/// <summary>При проверке сертификата не учитывать, что основные ограничения недопустимы.</summary>
		// Token: 0x04000CCA RID: 3274
		IgnoreInvalidBasicConstraints = 8,
		/// <summary>Не учитывать, что цепочку нельзя проверить из-за неизвестного центра сертификации (ЦС).</summary>
		// Token: 0x04000CCB RID: 3275
		AllowUnknownCertificateAuthority = 16,
		/// <summary>При проверке сертификата не учитывать, что сертификат был выдан не текущему пользователю.</summary>
		// Token: 0x04000CCC RID: 3276
		IgnoreWrongUsage = 32,
		/// <summary>При проверке сертификата не учитывать, что сертификат имеет недопустимое имя.</summary>
		// Token: 0x04000CCD RID: 3277
		IgnoreInvalidName = 64,
		/// <summary>При проверке сертификата не учитывать, что сертификат имеет недопустимую политику.</summary>
		// Token: 0x04000CCE RID: 3278
		IgnoreInvalidPolicy = 128,
		/// <summary>При проверке сертификата не учитывать, что отзыв конечного сертификата (сертификата пользователя) неизвестен.</summary>
		// Token: 0x04000CCF RID: 3279
		IgnoreEndRevocationUnknown = 256,
		/// <summary>При проверке сертификата не учитывать, что отзыв подписавшего список доверия сертификатов (CTL) неизвестен.</summary>
		// Token: 0x04000CD0 RID: 3280
		IgnoreCtlSignerRevocationUnknown = 512,
		/// <summary>При проверке сертификата не учитывать, что отзыв центра сертификации неизвестен.</summary>
		// Token: 0x04000CD1 RID: 3281
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		/// <summary>При проверке сертификата не учитывать, что корневой отзыв неизвестен.</summary>
		// Token: 0x04000CD2 RID: 3282
		IgnoreRootRevocationUnknown = 2048,
		/// <summary>Включены все флаги, относящиеся к проверке.</summary>
		// Token: 0x04000CD3 RID: 3283
		AllFlags = 4095
	}
}
