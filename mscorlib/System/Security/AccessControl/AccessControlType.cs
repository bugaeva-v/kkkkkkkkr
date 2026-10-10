using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет тип правила <see cref="T:System.Security.AccessControl.AccessRule" /> — разрешающее или запрещающее доступ. Эти значения не являются флагами и их невозможно объединять.</summary>
	// Token: 0x02000502 RID: 1282
	public enum AccessControlType
	{
		/// <summary>Объект <see cref="T:System.Security.AccessControl.AccessRule" />, который используется для разрешения доступа к защищаемому объекту.</summary>
		// Token: 0x0400240C RID: 9228
		Allow,
		/// <summary>Объект <see cref="T:System.Security.AccessControl.AccessRule" />, который используется для запрета доступа к защищаемому объекту.</summary>
		// Token: 0x0400240D RID: 9229
		Deny
	}
}
