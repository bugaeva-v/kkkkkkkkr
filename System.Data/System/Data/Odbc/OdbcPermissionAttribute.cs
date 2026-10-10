using System;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.Odbc
{
	/// <summary>Связывает операцию безопасности с пользовательским атрибутом безопасности.</summary>
	// Token: 0x02000302 RID: 770
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class OdbcPermissionAttribute : DBDataPermissionAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcPermissionAttribute" /> с использованием одного из стандартных значений <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />, представляющих действие, которое может быть выполнено с применением декларативной безопасности.</param>
		// Token: 0x06002228 RID: 8744 RVA: 0x0005ABA6 File Offset: 0x00058DA6
		public OdbcPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Odbc.OdbcPermission" />, который настроен в соответствии со свойствами атрибутов.</summary>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcPermission" />.</returns>
		// Token: 0x06002229 RID: 8745 RVA: 0x0009ED6B File Offset: 0x0009CF6B
		public override IPermission CreatePermission()
		{
			return new OdbcPermission(this);
		}
	}
}
