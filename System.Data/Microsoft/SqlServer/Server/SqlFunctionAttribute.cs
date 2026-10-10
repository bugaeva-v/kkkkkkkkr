using System;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Используется, чтобы пометить определение метода пользовательской агрегатной функции как функцию в SQL Server. Свойства этого атрибута отражают физические характеристики, используемые при регистрации типа в SQL Server.</summary>
	// Token: 0x02000059 RID: 89
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public class SqlFunctionAttribute : Attribute
	{
		/// <summary>Необязательный атрибут пользовательской агрегатной функции, указывающий, следует ли регистрировать этот метод в SQL Server как функцию. Используется также для задания свойств <see cref="P:Microsoft.SqlServer.Server.SqlFunctionAttribute.DataAccess" />, <see cref="P:Microsoft.SqlServer.Server.SqlFunctionAttribute.FillRowMethodName" />, <see cref="P:Microsoft.SqlServer.Server.SqlFunctionAttribute.IsDeterministic" />, <see cref="P:Microsoft.SqlServer.Server.SqlFunctionAttribute.IsPrecise" />, <see cref="P:Microsoft.SqlServer.Server.SqlFunctionAttribute.Name" />, <see cref="P:Microsoft.SqlServer.Server.SqlFunctionAttribute.SystemDataAccess" /> и <see cref="P:Microsoft.SqlServer.Server.SqlFunctionAttribute.TableDefinition" /> атрибута функции.</summary>
		// Token: 0x06000463 RID: 1123 RVA: 0x00010902 File Offset: 0x0000EB02
		public SqlFunctionAttribute()
		{
			this.m_fDeterministic = false;
			this.m_eDataAccess = DataAccessKind.None;
			this.m_eSystemDataAccess = SystemDataAccessKind.None;
			this.m_fPrecise = false;
			this.m_fName = null;
			this.m_fTableDefinition = null;
			this.m_FillRowMethodName = null;
		}

		/// <summary>Показывает, детерминирована ли пользовательская функция.</summary>
		/// <returns>
		///   <see langword="true" />, если функция детерминирована, в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0001093B File Offset: 0x0000EB3B
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00010943 File Offset: 0x0000EB43
		public bool IsDeterministic
		{
			get
			{
				return this.m_fDeterministic;
			}
			set
			{
				this.m_fDeterministic = value;
			}
		}

		/// <summary>Показывает, предусматривает ли функция доступ к пользовательским данным, хранящимся в локальном экземпляре SQL Server.</summary>
		/// <returns>
		///   <see cref="T:Microsoft.SqlServer.Server.DataAccessKind" />. <see langword="None" />: Не доступ к данным. <see cref="T:Microsoft.SqlServer.Server.DataAccessKind" />. <see langword="Read" />: Считываются только пользовательские данные.</returns>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001094C File Offset: 0x0000EB4C
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00010954 File Offset: 0x0000EB54
		public DataAccessKind DataAccess
		{
			get
			{
				return this.m_eDataAccess;
			}
			set
			{
				this.m_eDataAccess = value;
			}
		}

		/// <summary>Показывает, требуется ли функции доступ к данным, хранящимся в системных каталогах или виртуальных системных таблицах SQL Server.</summary>
		/// <returns>
		///   <see cref="T:Microsoft.SqlServer.Server.DataAccessKind" />. <see langword="None" />: Не доступ к системным данным. <see cref="T:Microsoft.SqlServer.Server.DataAccessKind" />. <see langword="Read" />: Только чтение системных данных.</returns>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001095D File Offset: 0x0000EB5D
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00010965 File Offset: 0x0000EB65
		public SystemDataAccessKind SystemDataAccess
		{
			get
			{
				return this.m_eSystemDataAccess;
			}
			set
			{
				this.m_eSystemDataAccess = value;
			}
		}

		/// <summary>Показывает, предусматривает ли функция неточные вычисления, например операции с плавающей запятой.</summary>
		/// <returns>
		///   <see langword="true" />, если функция выполняет точные вычисления, в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001096E File Offset: 0x0000EB6E
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00010976 File Offset: 0x0000EB76
		public bool IsPrecise
		{
			get
			{
				return this.m_fPrecise;
			}
			set
			{
				this.m_fPrecise = value;
			}
		}

		/// <summary>Имя, под которым функция должна быть зарегистрирована в SQL Server.</summary>
		/// <returns>Значение типа <see cref="T:System.String" />, представляющее имя, под которым функция должна быть зарегистрирована.</returns>
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001097F File Offset: 0x0000EB7F
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00010987 File Offset: 0x0000EB87
		public string Name
		{
			get
			{
				return this.m_fName;
			}
			set
			{
				this.m_fName = value;
			}
		}

		/// <summary>Строка, представляющая определение таблицы результатов, если метод используется в качестве функции с табличным значением (TVF).</summary>
		/// <returns>Значение типа <see cref="T:System.String" />, представляющее определение таблицы результатов.</returns>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00010990 File Offset: 0x0000EB90
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00010998 File Offset: 0x0000EB98
		public string TableDefinition
		{
			get
			{
				return this.m_fTableDefinition;
			}
			set
			{
				this.m_fTableDefinition = value;
			}
		}

		/// <summary>Имя метода в том же классе, который используется для заполнения строки данных в таблице, возвращаемой функцией с табличным значением.</summary>
		/// <returns>Объект <see cref="T:System.String" /> значение, представляющее имя метода в том же классе, который используется для заполнения строки данных в таблицу, возвращаемую функцией возвращающих табличные значения.</returns>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x000109A1 File Offset: 0x0000EBA1
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x000109A9 File Offset: 0x0000EBA9
		public string FillRowMethodName
		{
			get
			{
				return this.m_FillRowMethodName;
			}
			set
			{
				this.m_FillRowMethodName = value;
			}
		}

		// Token: 0x04000548 RID: 1352
		private bool m_fDeterministic;

		// Token: 0x04000549 RID: 1353
		private DataAccessKind m_eDataAccess;

		// Token: 0x0400054A RID: 1354
		private SystemDataAccessKind m_eSystemDataAccess;

		// Token: 0x0400054B RID: 1355
		private bool m_fPrecise;

		// Token: 0x0400054C RID: 1356
		private string m_fName;

		// Token: 0x0400054D RID: 1357
		private string m_fTableDefinition;

		// Token: 0x0400054E RID: 1358
		private string m_FillRowMethodName;
	}
}
