using System;
using System.Security;
using System.Security.Permissions;

namespace System.Data.Common
{
	/// <summary>Представляет набор методов для создания экземпляров реализации поставщика для классов источника данных.</summary>
	// Token: 0x0200039D RID: 925
	public abstract class DbProviderFactory
	{
		/// <summary>Возвращает новый экземпляр класса поставщика, который реализует версию класса <see cref="T:System.Security.CodeAccessPermission" /> данного поставщика.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <returns>Объект <see cref="T:System.Security.CodeAccessPermission" /> для указанного значения <see cref="T:System.Security.Permissions.PermissionState" />.</returns>
		// Token: 0x06002CF5 RID: 11509 RVA: 0x00003E32 File Offset: 0x00002032
		public virtual CodeAccessPermission CreatePermission(PermissionState state)
		{
			return null;
		}

		/// <summary>Указывает, поддерживает ли объект <see cref="T:System.Data.Common.DbProviderFactory" /> класс <see cref="T:System.Data.Common.DbDataSourceEnumerator" />.</summary>
		/// <returns>Значение <see langword="true" />, если экземпляр класса <see cref="T:System.Data.Common.DbProviderFactory" /> поддерживает класс <see cref="T:System.Data.Common.DbDataSourceEnumerator" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x00006D64 File Offset: 0x00004F64
		public virtual bool CanCreateDataSourceEnumerator
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000BEF18 File Offset: 0x000BD118
		public virtual bool CanCreateDataAdapter
		{
			get
			{
				if (this._canCreateDataAdapter == null)
				{
					using (DbDataAdapter dbDataAdapter = this.CreateDataAdapter())
					{
						this._canCreateDataAdapter = new bool?(dbDataAdapter != null);
					}
				}
				return this._canCreateDataAdapter.Value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000BEF70 File Offset: 0x000BD170
		public virtual bool CanCreateCommandBuilder
		{
			get
			{
				if (this._canCreateCommandBuilder == null)
				{
					using (DbCommandBuilder dbCommandBuilder = this.CreateCommandBuilder())
					{
						this._canCreateCommandBuilder = new bool?(dbCommandBuilder != null);
					}
				}
				return this._canCreateCommandBuilder.Value;
			}
		}

		/// <summary>Возвращает новый экземпляр класса поставщика, который реализует класс <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.DbCommand" />.</returns>
		// Token: 0x06002CFA RID: 11514 RVA: 0x00003E32 File Offset: 0x00002032
		public virtual DbCommand CreateCommand()
		{
			return null;
		}

		/// <summary>Возвращает новый экземпляр класса поставщика, который реализует класс <see cref="T:System.Data.Common.DbCommandBuilder" />.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.DbCommandBuilder" />.</returns>
		// Token: 0x06002CFB RID: 11515 RVA: 0x00003E32 File Offset: 0x00002032
		public virtual DbCommandBuilder CreateCommandBuilder()
		{
			return null;
		}

		/// <summary>Возвращает новый экземпляр класса поставщика, который реализует класс <see cref="T:System.Data.Common.DbConnection" />.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.DbConnection" />.</returns>
		// Token: 0x06002CFC RID: 11516 RVA: 0x00003E32 File Offset: 0x00002032
		public virtual DbConnection CreateConnection()
		{
			return null;
		}

		/// <summary>Возвращает новый экземпляр класса поставщика, который реализует класс <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</returns>
		// Token: 0x06002CFD RID: 11517 RVA: 0x00003E32 File Offset: 0x00002032
		public virtual DbConnectionStringBuilder CreateConnectionStringBuilder()
		{
			return null;
		}

		/// <summary>Возвращает новый экземпляр класса поставщика, который реализует класс <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.DbDataAdapter" />.</returns>
		// Token: 0x06002CFE RID: 11518 RVA: 0x00003E32 File Offset: 0x00002032
		public virtual DbDataAdapter CreateDataAdapter()
		{
			return null;
		}

		/// <summary>Возвращает новый экземпляр класса поставщика, который реализует класс <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.DbParameter" />.</returns>
		// Token: 0x06002CFF RID: 11519 RVA: 0x00003E32 File Offset: 0x00002032
		public virtual DbParameter CreateParameter()
		{
			return null;
		}

		/// <summary>Возвращает новый экземпляр класса поставщика, который реализует класс <see cref="T:System.Data.Common.DbDataSourceEnumerator" />.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.DbDataSourceEnumerator" />.</returns>
		// Token: 0x06002D00 RID: 11520 RVA: 0x00003E32 File Offset: 0x00002032
		public virtual DbDataSourceEnumerator CreateDataSourceEnumerator()
		{
			return null;
		}

		// Token: 0x04001B89 RID: 7049
		private bool? _canCreateDataAdapter;

		// Token: 0x04001B8A RID: 7050
		private bool? _canCreateCommandBuilder;
	}
}
