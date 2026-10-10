using System;
using System.Security;
using System.Security.Permissions;

namespace System.Drawing.Printing
{
	/// <summary>Разрешает декларативные проверки разрешений для печати.</summary>
	// Token: 0x020000CA RID: 202
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	[Serializable]
	public sealed class PrintingPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrintingPermissionAttribute" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06000ACF RID: 2767 RVA: 0x00018788 File Offset: 0x00016988
		public PrintingPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает тип разрешенной печати.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Printing.PrintingPermissionLevel" />.</returns>
		/// <exception cref="T:System.ArgumentException">Данное значение не является одним из значений <see cref="T:System.Drawing.Printing.PrintingPermissionLevel" />.</exception>
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00018791 File Offset: 0x00016991
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00018799 File Offset: 0x00016999
		public PrintingPermissionLevel Level { get; set; }

		/// <summary>Создает разрешение на атрибут, где разрешения основаны на запрашиваемом уровне доступа, заданном через свойство <see cref="P:System.Drawing.Printing.PrintingPermissionAttribute.Level" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.IPermission" />, представляющий созданное разрешение.</returns>
		// Token: 0x06000AD2 RID: 2770 RVA: 0x00018785 File Offset: 0x00016985
		public override IPermission CreatePermission()
		{
			return null;
		}
	}
}
