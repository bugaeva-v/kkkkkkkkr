using System;

namespace System.Security.AccessControl
{
	/// <summary>Задает условия аудита попыток доступа к защищаемому объекту.</summary>
	// Token: 0x02000509 RID: 1289
	[Flags]
	public enum AuditFlags
	{
		/// <summary>Аудиту не подлежат никакие попытки доступа.</summary>
		// Token: 0x04002435 RID: 9269
		None = 0,
		/// <summary>Аудиту подлежат успешные попытки доступа.</summary>
		// Token: 0x04002436 RID: 9270
		Success = 1,
		/// <summary>Аудиту подлежат неудачные попытки доступа.</summary>
		// Token: 0x04002437 RID: 9271
		Failure = 2
	}
}
