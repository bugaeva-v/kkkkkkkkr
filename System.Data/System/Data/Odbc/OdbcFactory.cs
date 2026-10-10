using System;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.Odbc
{
	/// <summary>Представляет набор методов для создания экземпляров классов поставщиков ODBC, реализующих источник данных.</summary>
	// Token: 0x020002EA RID: 746
	public sealed class OdbcFactory : DbProviderFactory
	{
		// Token: 0x06002113 RID: 8467 RVA: 0x0005ADE6 File Offset: 0x00058FE6
		private OdbcFactory()
		{
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommand" />.</returns>
		// Token: 0x06002114 RID: 8468 RVA: 0x0009A79A File Offset: 0x0009899A
		public override DbCommand CreateCommand()
		{
			return new OdbcCommand();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommandBuilder" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommandBuilder" />.</returns>
		// Token: 0x06002115 RID: 8469 RVA: 0x0009A7A1 File Offset: 0x000989A1
		public override DbCommandBuilder CreateCommandBuilder()
		{
			return new OdbcCommandBuilder();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnection" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnection" />.</returns>
		// Token: 0x06002116 RID: 8470 RVA: 0x0009A7A8 File Offset: 0x000989A8
		public override DbConnection CreateConnection()
		{
			return new OdbcConnection();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</returns>
		// Token: 0x06002117 RID: 8471 RVA: 0x0009A7AF File Offset: 0x000989AF
		public override DbConnectionStringBuilder CreateConnectionStringBuilder()
		{
			return new OdbcConnectionStringBuilder();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbDataAdapter" />.</returns>
		// Token: 0x06002118 RID: 8472 RVA: 0x0009A7B6 File Offset: 0x000989B6
		public override DbDataAdapter CreateDataAdapter()
		{
			return new OdbcDataAdapter();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbParameter" />.</returns>
		// Token: 0x06002119 RID: 8473 RVA: 0x00094874 File Offset: 0x00092A74
		public override DbParameter CreateParameter()
		{
			return new OdbcParameter();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Security.CodeAccessPermission" />.</summary>
		/// <param name="state">Элемент перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Security.CodeAccessPermission" />.</returns>
		// Token: 0x0600211A RID: 8474 RVA: 0x0009A7BD File Offset: 0x000989BD
		public override CodeAccessPermission CreatePermission(PermissionState state)
		{
			return new OdbcPermission(state);
		}

		/// <summary>Получает экземпляр <see cref="T:System.Data.Odbc.OdbcFactory" />, который позволяет извлекать объекты данных со строгой типизацией.</summary>
		// Token: 0x040017BC RID: 6076
		public static readonly OdbcFactory Instance = new OdbcFactory();
	}
}
