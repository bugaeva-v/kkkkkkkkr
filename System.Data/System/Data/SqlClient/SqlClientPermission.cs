using System;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.SqlClient
{
	/// <summary>Позволяет поставщику данных платформы .NET Framework для SQL Server убедиться, что пользователь обладает уровнем безопасности, достаточным для доступа к источнику данных.</summary>
	// Token: 0x0200027F RID: 639
	[Serializable]
	public sealed class SqlClientPermission : DBDataPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</summary>
		// Token: 0x06001E18 RID: 7704 RVA: 0x0008EEC2 File Offset: 0x0008D0C2
		[Obsolete("SqlClientPermission() has been deprecated.  Use the SqlClientPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
		public SqlClientPermission() : this(PermissionState.None)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		// Token: 0x06001E19 RID: 7705 RVA: 0x0005AABF File Offset: 0x00058CBF
		public SqlClientPermission(PermissionState state) : base(state)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <param name="allowBlankPassword">Указывает, разрешается ли пустой пароль.</param>
		// Token: 0x06001E1A RID: 7706 RVA: 0x0008EECB File Offset: 0x0008D0CB
		[Obsolete("SqlClientPermission(PermissionState state, Boolean allowBlankPassword) has been deprecated.  Use the SqlClientPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
		public SqlClientPermission(PermissionState state, bool allowBlankPassword) : this(state)
		{
			base.AllowBlankPassword = allowBlankPassword;
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0005AAD8 File Offset: 0x00058CD8
		private SqlClientPermission(SqlClientPermission permission) : base(permission)
		{
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0005AAE1 File Offset: 0x00058CE1
		internal SqlClientPermission(SqlClientPermissionAttribute permissionAttribute) : base(permissionAttribute)
		{
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0005AAEA File Offset: 0x00058CEA
		internal SqlClientPermission(SqlConnectionString constr) : base(constr)
		{
			if (constr == null || constr.IsEmpty)
			{
				base.Add(ADP.StrEmpty, ADP.StrEmpty, KeyRestrictionBehavior.AllowOnly);
			}
		}

		/// <summary>Добавляет новую строку подключения и набор запрещенных ключевых слов в объект <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</summary>
		/// <param name="connectionString">Строка подключения.</param>
		/// <param name="restrictions">Ключевые ограничения.</param>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.KeyRestrictionBehavior" />.</param>
		// Token: 0x06001E1E RID: 7710 RVA: 0x0008EEDC File Offset: 0x0008D0DC
		public override void Add(string connectionString, string restrictions, KeyRestrictionBehavior behavior)
		{
			DBConnectionString entry = new DBConnectionString(connectionString, restrictions, behavior, SqlConnectionString.GetParseSynonyms(), false);
			base.AddPermissionEntry(entry);
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.SqlClient.SqlClientPermission" /> в качестве <see cref="T:System.Security.IPermission" />.</summary>
		/// <returns>Копия текущего объекта разрешения.</returns>
		// Token: 0x06001E1F RID: 7711 RVA: 0x0008EEFF File Offset: 0x0008D0FF
		public override IPermission Copy()
		{
			return new SqlClientPermission(this);
		}
	}
}
