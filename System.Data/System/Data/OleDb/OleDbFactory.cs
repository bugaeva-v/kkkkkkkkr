using System;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.OleDb
{
	/// <summary>Представляет набор методов для создания экземпляров классов поставщиков OLEDB, реализующих источник данных.</summary>
	// Token: 0x02000167 RID: 359
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbFactory : DbProviderFactory
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x0005ADE6 File Offset: 0x00058FE6
		internal OleDbFactory()
		{
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommand" />.</returns>
		// Token: 0x06001368 RID: 4968 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DbCommand CreateCommand()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommandBuilder" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommandBuilder" />.</returns>
		// Token: 0x06001369 RID: 4969 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DbCommandBuilder CreateCommandBuilder()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnection" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnection" />.</returns>
		// Token: 0x0600136A RID: 4970 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DbConnection CreateConnection()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</returns>
		// Token: 0x0600136B RID: 4971 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DbConnectionStringBuilder CreateConnectionStringBuilder()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbDataAdapter" />.</returns>
		// Token: 0x0600136C RID: 4972 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DbDataAdapter CreateDataAdapter()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbParameter" />.</returns>
		// Token: 0x0600136D RID: 4973 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DbParameter CreateParameter()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Security.CodeAccessPermission" />.</summary>
		/// <param name="state">Элемент перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <returns>Строго типизированный экземпляр <see cref="T:System.Security.CodeAccessPermission" />.</returns>
		// Token: 0x0600136E RID: 4974 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override CodeAccessPermission CreatePermission(PermissionState state)
		{
			throw ADP.OleDb();
		}

		/// <summary>Получает экземпляр объекта <see cref="T:System.Data.OleDb.OleDbFactory" />. Это может использоваться для извлечения строго типизированных объектов данных.</summary>
		// Token: 0x04000BD4 RID: 3028
		public static readonly OleDbFactory Instance;
	}
}
