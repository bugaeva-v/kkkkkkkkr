using System;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.SqlClient
{
	/// <summary>Связывает операцию безопасности с пользовательским атрибутом безопасности.</summary>
	// Token: 0x02000280 RID: 640
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class SqlClientPermissionAttribute : DBDataPermissionAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlClientPermissionAttribute" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />, представляющих действие, которое может быть выполнено с применением декларативной безопасности.</param>
		// Token: 0x06001E20 RID: 7712 RVA: 0x0005ABA6 File Offset: 0x00058DA6
		public SqlClientPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.SqlClient.SqlClientPermission" />, который настроен в соответствии со свойствами атрибутов.</summary>
		/// <returns>Объект <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</returns>
		// Token: 0x06001E21 RID: 7713 RVA: 0x0008EF07 File Offset: 0x0008D107
		public override IPermission CreatePermission()
		{
			return new SqlClientPermission(this);
		}
	}
}
