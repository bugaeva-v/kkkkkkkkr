using System;
using System.Data.Common;
using System.Data.Sql;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Представляет набор методов для создания экземпляров классов источников данных, реализованных поставщиком <see cref="N:System.Data.SqlClient" />.</summary>
	// Token: 0x020001AF RID: 431
	public sealed class SqlClientFactory : DbProviderFactory, IServiceProvider
	{
		// Token: 0x06001531 RID: 5425 RVA: 0x0005ADE6 File Offset: 0x00058FE6
		private SqlClientFactory()
		{
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommand" />.</returns>
		// Token: 0x06001532 RID: 5426 RVA: 0x00060C0C File Offset: 0x0005EE0C
		public override DbCommand CreateCommand()
		{
			return new SqlCommand();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommandBuilder" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbCommandBuilder" />.</returns>
		// Token: 0x06001533 RID: 5427 RVA: 0x00060C13 File Offset: 0x0005EE13
		public override DbCommandBuilder CreateCommandBuilder()
		{
			return new SqlCommandBuilder();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnection" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnection" />.</returns>
		// Token: 0x06001534 RID: 5428 RVA: 0x00060C1A File Offset: 0x0005EE1A
		public override DbConnection CreateConnection()
		{
			return new SqlConnection();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</returns>
		// Token: 0x06001535 RID: 5429 RVA: 0x00060C21 File Offset: 0x0005EE21
		public override DbConnectionStringBuilder CreateConnectionStringBuilder()
		{
			return new SqlConnectionStringBuilder();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbDataAdapter" />.</returns>
		// Token: 0x06001536 RID: 5430 RVA: 0x00060C28 File Offset: 0x0005EE28
		public override DbDataAdapter CreateDataAdapter()
		{
			return new SqlDataAdapter();
		}

		/// <summary>Возвращает строго типизированный экземпляр <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <returns>Новый строго типизированный экземпляр <see cref="T:System.Data.Common.DbParameter" />.</returns>
		// Token: 0x06001537 RID: 5431 RVA: 0x00060C2F File Offset: 0x0005EE2F
		public override DbParameter CreateParameter()
		{
			return new SqlParameter();
		}

		/// <summary>Вызывает значение, показывающее, можно ли создать <see cref="T:System.Data.Sql.SqlDataSourceEnumerator" />.</summary>
		/// <returns>
		///   <see langword="true" /> Если <see cref="T:System.Data.Sql.SqlDataSourceEnumerator" /> может быть создан; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x00006D61 File Offset: 0x00004F61
		public override bool CanCreateDataSourceEnumerator
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Data.Sql.SqlDataSourceEnumerator" />.</summary>
		/// <returns>Новый перечислитель источника данных.</returns>
		// Token: 0x06001539 RID: 5433 RVA: 0x00060C36 File Offset: 0x0005EE36
		public override DbDataSourceEnumerator CreateDataSourceEnumerator()
		{
			return SqlDataSourceEnumerator.Instance;
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Security.CodeAccessPermission" />.</summary>
		/// <param name="state">Элемент перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <returns>Строго типизированный экземпляр <see cref="T:System.Security.CodeAccessPermission" />.</returns>
		// Token: 0x0600153A RID: 5434 RVA: 0x00060C3D File Offset: 0x0005EE3D
		public override CodeAccessPermission CreatePermission(PermissionState state)
		{
			return new SqlClientPermission(state);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IServiceProvider.GetService(System.Type)" />.</summary>
		/// <param name="serviceType">Объект, определяющий тип объекта службы, который необходимо получить.</param>
		/// <returns>Объект службы.</returns>
		// Token: 0x0600153C RID: 5436 RVA: 0x00060C51 File Offset: 0x0005EE51
		object IServiceProvider.GetService(Type serviceType)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Получает экземпляр объекта <see cref="T:System.Data.SqlClient.SqlClientFactory" />. Это может использоваться для извлечения строго типизированных объектов данных.</summary>
		// Token: 0x04000D82 RID: 3458
		public static readonly SqlClientFactory Instance = new SqlClientFactory();
	}
}
