using System;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Transactions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Transactions.DistributedTransactionPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000031 RID: 49
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public sealed class DistributedTransactionPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.DistributedTransactionPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x060000F0 RID: 240 RVA: 0x000021EE File Offset: 0x000003EE
		public DistributedTransactionPermissionAttribute(SecurityAction action)
		{
		}

		/// <summary>Создает объект разрешения, который затем может быть сериализован в двоичной форме и сохранен вместе с <see cref="T:System.Security.Permissions.SecurityAction" /> в области метаданных сборки.</summary>
		/// <returns>Сериализуемый объект разрешения.</returns>
		// Token: 0x060000F1 RID: 241 RVA: 0x00003476 File Offset: 0x00001676
		public override IPermission CreatePermission()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
