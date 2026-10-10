using System;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.Odbc
{
	/// <summary>Позволяет поставщику данных .NET Framework для ODBC обеспечить пользователю уровень безопасности, достаточный для доступа к источнику данных ODBC. Этот класс не наследуется.</summary>
	// Token: 0x02000301 RID: 769
	[Serializable]
	public sealed class OdbcPermission : DBDataPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcPermission" />.</summary>
		// Token: 0x06002220 RID: 8736 RVA: 0x0009ED29 File Offset: 0x0009CF29
		[Obsolete("OdbcPermission() has been deprecated.  Use the OdbcPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
		public OdbcPermission() : this(PermissionState.None)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcPermission" /> с использованием одного из стандартных значений <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		// Token: 0x06002221 RID: 8737 RVA: 0x0005AABF File Offset: 0x00058CBF
		public OdbcPermission(PermissionState state) : base(state)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcPermission" />.</summary>
		/// <param name="state">Одно из значений перечисления <see langword="System.Security.Permissions.PermissionState" />.</param>
		/// <param name="allowBlankPassword">Указывает, разрешается ли пустой пароль.</param>
		// Token: 0x06002222 RID: 8738 RVA: 0x0009ED32 File Offset: 0x0009CF32
		[Obsolete("OdbcPermission(PermissionState state, Boolean allowBlankPassword) has been deprecated.  Use the OdbcPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
		public OdbcPermission(PermissionState state, bool allowBlankPassword) : this(state)
		{
			base.AllowBlankPassword = allowBlankPassword;
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0005AAD8 File Offset: 0x00058CD8
		private OdbcPermission(OdbcPermission permission) : base(permission)
		{
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0005AAE1 File Offset: 0x00058CE1
		internal OdbcPermission(OdbcPermissionAttribute permissionAttribute) : base(permissionAttribute)
		{
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0005AAEA File Offset: 0x00058CEA
		internal OdbcPermission(OdbcConnectionString constr) : base(constr)
		{
			if (constr == null || constr.IsEmpty)
			{
				base.Add(ADP.StrEmpty, ADP.StrEmpty, KeyRestrictionBehavior.AllowOnly);
			}
		}

		/// <summary>Добавляет доступ к существующему состоянию разрешения для заданной строки подключения.</summary>
		/// <param name="connectionString">Разрешенная строка подключения.</param>
		/// <param name="restrictions">Строка, определяющая разрешенные или запрещенные параметры строки подключения.</param>
		/// <param name="behavior">Одно из значений перечисления <see cref="T:System.Data.KeyRestrictionBehavior" />.</param>
		// Token: 0x06002226 RID: 8742 RVA: 0x0009ED44 File Offset: 0x0009CF44
		public override void Add(string connectionString, string restrictions, KeyRestrictionBehavior behavior)
		{
			DBConnectionString entry = new DBConnectionString(connectionString, restrictions, behavior, null, true);
			base.AddPermissionEntry(entry);
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Odbc.OdbcPermission" /> в качестве <see cref="T:System.Security.IPermission" />.</summary>
		/// <returns>Копия текущего объекта разрешения.</returns>
		// Token: 0x06002227 RID: 8743 RVA: 0x0009ED63 File Offset: 0x0009CF63
		public override IPermission Copy()
		{
			return new OdbcPermission(this);
		}
	}
}
