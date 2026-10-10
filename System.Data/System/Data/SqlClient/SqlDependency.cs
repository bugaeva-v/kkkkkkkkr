using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.ProviderBase;
using System.Data.Sql;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;

namespace System.Data.SqlClient
{
	/// <summary>Объект <see cref="T:System.Data.SqlClient.SqlDependency" /> представляет зависимость уведомления о запросе между приложением и экземпляром SQL Server. Приложение может создавать объект <see cref="T:System.Data.SqlClient.SqlDependency" /> и регистрироваться для получения уведомлений через обработчик событий <see cref="T:System.Data.SqlClient.OnChangeEventHandler" />.</summary>
	// Token: 0x020001F6 RID: 502
	public sealed class SqlDependency
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlDependency" />, используя значения по умолчанию.</summary>
		// Token: 0x06001871 RID: 6257 RVA: 0x00070CB9 File Offset: 0x0006EEB9
		public SqlDependency() : this(null, null, 0)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlDependency" /> и связывает его с параметром <see cref="T:System.Data.SqlClient.SqlCommand" />.</summary>
		/// <param name="command">Объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который необходимо связать с данным объектом <see cref="T:System.Data.SqlClient.SqlDependency" />. Конструктор создаст объект <see cref="T:System.Data.Sql.SqlNotificationRequest" /> и свяжет его с этой командой.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="command" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.SqlClient.SqlCommand" /> уже имеет объект <see cref="T:System.Data.Sql.SqlNotificationRequest" />, связанный с его свойством <see cref="P:System.Data.SqlClient.SqlCommand.Notification" />, и этот объект <see cref="T:System.Data.Sql.SqlNotificationRequest" /> не связан с данной зависимостью.</exception>
		// Token: 0x06001872 RID: 6258 RVA: 0x00070CC4 File Offset: 0x0006EEC4
		public SqlDependency(SqlCommand command) : this(command, null, 0)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlDependency" /> и связывает его с параметром <see cref="T:System.Data.SqlClient.SqlCommand" />, а также задает параметры уведомления и таймаут.</summary>
		/// <param name="command">Объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который необходимо связать с данным объектом <see cref="T:System.Data.SqlClient.SqlDependency" />. Конструктор создает объект <see cref="T:System.Data.Sql.SqlNotificationRequest" /> и связывает его с этой командой.</param>
		/// <param name="options">Параметры запроса уведомления, которые должны использоваться данной зависимостью. Значение <see langword="null" />, чтобы использовать службу по умолчанию.</param>
		/// <param name="timeout">Время ожидания уведомляющего сообщения в секундах. Значением по умолчанию является 0, указывающее, что следует использовать время ожидания, установленное на сервере.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="command" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение таймаута меньше нуля.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.SqlClient.SqlCommand" /> уже имеет объект <see cref="T:System.Data.Sql.SqlNotificationRequest" />, связанный с его свойством <see cref="P:System.Data.SqlClient.SqlCommand.Notification" />, и этот объект <see cref="T:System.Data.Sql.SqlNotificationRequest" /> не связан с данной зависимостью.  
		/// Предпринята попытка создать экземпляр SqlDependency в SQLCLR.</exception>
		// Token: 0x06001873 RID: 6259 RVA: 0x00070CD0 File Offset: 0x0006EED0
		public SqlDependency(SqlCommand command, string options, int timeout)
		{
			if (timeout < 0)
			{
				throw SQL.InvalidSqlDependencyTimeout("timeout");
			}
			this._timeout = timeout;
			if (options != null)
			{
				this._options = options;
			}
			this.AddCommandInternal(command);
			SqlDependencyPerAppDomainDispatcher.SingletonInstance.AddDependencyEntry(this);
		}

		/// <summary>Возвращает значение, указывающее, изменился ли какой-либо из результирующих наборов, связанных с данной зависимостью.</summary>
		/// <returns>Логическое значение, указывающее, изменился ли какой-либо из результирующих наборов.</returns>
		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00070D69 File Offset: 0x0006EF69
		public bool HasChanges
		{
			get
			{
				return this._dependencyFired;
			}
		}

		/// <summary>Возвращает значение, являющееся уникальным идентификатором данного экземпляра класса <see cref="T:System.Data.SqlClient.SqlDependency" />.</summary>
		/// <returns>Строковое представление GUID, генерируемого для каждого экземпляра класса <see cref="T:System.Data.SqlClient.SqlDependency" />.</returns>
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x00070D71 File Offset: 0x0006EF71
		public string Id
		{
			get
			{
				return this._id;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00070D79 File Offset: 0x0006EF79
		internal static string AppDomainKey
		{
			get
			{
				return SqlDependency.s_appDomainKey;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x00070D80 File Offset: 0x0006EF80
		internal DateTime ExpirationTime
		{
			get
			{
				return this._expirationTime;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00070D88 File Offset: 0x0006EF88
		internal string Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x00070D90 File Offset: 0x0006EF90
		internal static SqlDependencyProcessDispatcher ProcessDispatcher
		{
			get
			{
				return SqlDependency.s_processDispatcher;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00070D97 File Offset: 0x0006EF97
		internal int Timeout
		{
			get
			{
				return this._timeout;
			}
		}

		/// <summary>Генерируется при получении уведомления для любой команды, связанной с данным объектом <see cref="T:System.Data.SqlClient.SqlDependency" />.</summary>
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600187B RID: 6267 RVA: 0x00070DA0 File Offset: 0x0006EFA0
		// (remove) Token: 0x0600187C RID: 6268 RVA: 0x00070E28 File Offset: 0x0006F028
		public event OnChangeEventHandler OnChange
		{
			add
			{
				if (value != null)
				{
					SqlNotificationEventArgs sqlNotificationEventArgs = null;
					object eventHandlerLock = this._eventHandlerLock;
					lock (eventHandlerLock)
					{
						if (this._dependencyFired)
						{
							sqlNotificationEventArgs = new SqlNotificationEventArgs(SqlNotificationType.Subscribe, SqlNotificationInfo.AlreadyChanged, SqlNotificationSource.Client);
						}
						else
						{
							SqlDependency.EventContextPair item = new SqlDependency.EventContextPair(value, this);
							if (this._eventList.Contains(item))
							{
								throw SQL.SqlDependencyEventNoDuplicate();
							}
							this._eventList.Add(item);
						}
					}
					if (sqlNotificationEventArgs != null)
					{
						value(this, sqlNotificationEventArgs);
					}
				}
			}
			remove
			{
				if (value != null)
				{
					SqlDependency.EventContextPair item = new SqlDependency.EventContextPair(value, this);
					object eventHandlerLock = this._eventHandlerLock;
					lock (eventHandlerLock)
					{
						int num = this._eventList.IndexOf(item);
						if (0 <= num)
						{
							this._eventList.RemoveAt(num);
						}
					}
				}
			}
		}

		/// <summary>Связывает объект <see cref="T:System.Data.SqlClient.SqlCommand" /> с этим экземпляром <see cref="T:System.Data.SqlClient.SqlDependency" />.</summary>
		/// <param name="command">Объект <see cref="T:System.Data.SqlClient.SqlCommand" />, содержащий инструкцию, для которой возможно уведомление.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="command" /> имеет значение null.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.SqlClient.SqlCommand" /> уже имеет объект <see cref="T:System.Data.Sql.SqlNotificationRequest" />, связанный с его свойством <see cref="P:System.Data.SqlClient.SqlCommand.Notification" />, и этот объект <see cref="T:System.Data.Sql.SqlNotificationRequest" /> не связан с данной зависимостью.</exception>
		// Token: 0x0600187D RID: 6269 RVA: 0x00070E8C File Offset: 0x0006F08C
		public void AddCommandDependency(SqlCommand command)
		{
			if (command == null)
			{
				throw ADP.ArgumentNull("command");
			}
			this.AddCommandInternal(command);
		}

		/// <summary>Запускает прослушиватель для получения уведомлений об изменении зависимости от экземпляра SQL Server, заданного в строке подключения.</summary>
		/// <param name="connectionString">Строка подключения для экземпляра SQL Server, от которого необходимо получать уведомления об изменении зависимости.</param>
		/// <returns>Значение <see langword="true" />, если прослушиватель инициализирован успешно; значение <see langword="false" />, если совместимый прослушиватель уже существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="connectionString" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="connectionString" /> такой же, как в предыдущем вызове этого метода, но параметры различны.  
		/// Этот метод вызывается из CLR.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код не имеет разрешения на управление доступом для кода (CAS), возвращенного <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</exception>
		/// <exception cref="T:System.Data.SqlClient.SqlException">Следующий вызов этого метода выполнен с эквивалентным параметром <paramref name="connectionString" />, содержащим другое имя пользователя, или пользователь не является используемым по умолчанию в той же схеме.  
		/// Кроме того, любые базовые исключения SqlClient.</exception>
		// Token: 0x0600187E RID: 6270 RVA: 0x00070EA3 File Offset: 0x0006F0A3
		public static bool Start(string connectionString)
		{
			return SqlDependency.Start(connectionString, null, true);
		}

		/// <summary>Запускает прослушиватель для получения уведомлений об изменении зависимости от экземпляра SQL Server, заданного в строке подключения, с использованием заданной очереди сервис-брокера SQL Server.</summary>
		/// <param name="connectionString">Строка подключения для экземпляра SQL Server, от которого необходимо получать уведомления об изменении зависимости.</param>
		/// <param name="queue">Будет использоваться существующая очередь сервис-брокера SQL Server. Если значение <see langword="null" />, используется очередь по умолчанию.</param>
		/// <returns>Значение <see langword="true" />, если прослушиватель инициализирован успешно; значение <see langword="false" />, если совместимый прослушиватель уже существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="connectionString" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="connectionString" /> такой же, как в предыдущем вызове этого метода, но параметры различны.  
		/// Этот метод вызывается из CLR.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код не имеет разрешения на управление доступом для кода (CAS), возвращенного <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</exception>
		/// <exception cref="T:System.Data.SqlClient.SqlException">Следующий вызов этого метода выполнен с эквивалентным параметром <paramref name="connectionString" />, содержащим другое имя пользователя, или пользователь не является используемым по умолчанию в той же схеме.  
		/// Кроме того, любые базовые исключения SqlClient.</exception>
		// Token: 0x0600187F RID: 6271 RVA: 0x00070EAD File Offset: 0x0006F0AD
		public static bool Start(string connectionString, string queue)
		{
			return SqlDependency.Start(connectionString, queue, false);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00070EB8 File Offset: 0x0006F0B8
		internal static bool Start(string connectionString, string queue, bool useDefaults)
		{
			if (!string.IsNullOrEmpty(connectionString))
			{
				if (!useDefaults && string.IsNullOrEmpty(queue))
				{
					useDefaults = true;
					queue = null;
				}
				bool flag = false;
				bool result = false;
				object obj = SqlDependency.s_startStopLock;
				lock (obj)
				{
					try
					{
						if (SqlDependency.s_processDispatcher == null)
						{
							SqlDependency.s_processDispatcher = SqlDependencyProcessDispatcher.SingletonProcessDispatcher;
						}
						if (useDefaults)
						{
							string server = null;
							DbConnectionPoolIdentity identity = null;
							string userName = null;
							string database = null;
							string service = null;
							bool flag3 = false;
							RuntimeHelpers.PrepareConstrainedRegions();
							try
							{
								result = SqlDependency.s_processDispatcher.StartWithDefault(connectionString, out server, out identity, out userName, out database, ref service, SqlDependency.s_appDomainKey, SqlDependencyPerAppDomainDispatcher.SingletonInstance, out flag, out flag3);
								goto IL_FF;
							}
							finally
							{
								if (flag3 && !flag)
								{
									SqlDependency.IdentityUserNamePair identityUser = new SqlDependency.IdentityUserNamePair(identity, userName);
									SqlDependency.DatabaseServicePair databaseService = new SqlDependency.DatabaseServicePair(database, service);
									if (!SqlDependency.AddToServerUserHash(server, identityUser, databaseService))
									{
										try
										{
											SqlDependency.Stop(connectionString, queue, useDefaults, true);
										}
										catch (Exception e)
										{
											if (!ADP.IsCatchableExceptionType(e))
											{
												throw;
											}
											ADP.TraceExceptionWithoutRethrow(e);
										}
										throw SQL.SqlDependencyDuplicateStart();
									}
								}
							}
						}
						result = SqlDependency.s_processDispatcher.Start(connectionString, queue, SqlDependency.s_appDomainKey, SqlDependencyPerAppDomainDispatcher.SingletonInstance);
						IL_FF:;
					}
					catch (Exception e2)
					{
						if (!ADP.IsCatchableExceptionType(e2))
						{
							throw;
						}
						ADP.TraceExceptionWithoutRethrow(e2);
						throw;
					}
				}
				return result;
			}
			if (connectionString == null)
			{
				throw ADP.ArgumentNull("connectionString");
			}
			throw ADP.Argument("connectionString");
		}

		/// <summary>Останавливает прослушиватель для подключения, заданного в предыдущем вызове <see cref="Overload:System.Data.SqlClient.SqlDependency.Start" />.</summary>
		/// <param name="connectionString">Строка подключения для экземпляра SQL Server, использовавшегося в предыдущем вызове <see cref="M:System.Data.SqlClient.SqlDependency.Start(System.String)" />.</param>
		/// <returns>Значение <see langword="true" />, если прослушиватель был полностью остановлен; значение <see langword="false" />, если домен <see cref="T:System.AppDomain" /> был отсоединен от прослушивателя, но имеется еще хотя бы один домен <see cref="T:System.AppDomain" />, использующий этот же прослушиватель.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="connectionString" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод вызывается из SQLCLR.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код не имеет разрешения на управление доступом для кода (CAS), возвращенного <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</exception>
		/// <exception cref="T:System.Data.SqlClient.SqlException">Произошло базовое исключение SqlClient.</exception>
		// Token: 0x06001881 RID: 6273 RVA: 0x00071018 File Offset: 0x0006F218
		public static bool Stop(string connectionString)
		{
			return SqlDependency.Stop(connectionString, null, true, false);
		}

		/// <summary>Останавливает прослушиватель для подключения, заданного в предыдущем вызове <see cref="Overload:System.Data.SqlClient.SqlDependency.Start" />.</summary>
		/// <param name="connectionString">Строка подключения для экземпляра SQL Server, использовавшегося в предыдущем вызове <see cref="M:System.Data.SqlClient.SqlDependency.Start(System.String,System.String)" />.</param>
		/// <param name="queue">Очередь сервис-брокера SQL Server, использовавшаяся в предыдущем вызове <see cref="M:System.Data.SqlClient.SqlDependency.Start(System.String,System.String)" />.</param>
		/// <returns>Значение <see langword="true" />, если прослушиватель был полностью остановлен; значение <see langword="false" />, если домен <see cref="T:System.AppDomain" /> был отсоединен от прослушивателя, но имеется еще хотя бы один домен <see cref="T:System.AppDomain" />, использующий этот же прослушиватель.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="connectionString" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод вызывается из SQLCLR.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код не имеет разрешения на управление доступом для кода (CAS), возвращенного <see cref="T:System.Data.SqlClient.SqlClientPermission" />.</exception>
		/// <exception cref="T:System.Data.SqlClient.SqlException">Кроме того, произошло базовое исключение SqlClient.</exception>
		// Token: 0x06001882 RID: 6274 RVA: 0x00071023 File Offset: 0x0006F223
		public static bool Stop(string connectionString, string queue)
		{
			return SqlDependency.Stop(connectionString, queue, false, false);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00071030 File Offset: 0x0006F230
		internal static bool Stop(string connectionString, string queue, bool useDefaults, bool startFailed)
		{
			if (!string.IsNullOrEmpty(connectionString))
			{
				if (!useDefaults && string.IsNullOrEmpty(queue))
				{
					useDefaults = true;
					queue = null;
				}
				bool result = false;
				object obj = SqlDependency.s_startStopLock;
				lock (obj)
				{
					if (SqlDependency.s_processDispatcher != null)
					{
						try
						{
							string server = null;
							DbConnectionPoolIdentity identity = null;
							string userName = null;
							string database = null;
							string service = null;
							if (useDefaults)
							{
								bool flag2 = false;
								RuntimeHelpers.PrepareConstrainedRegions();
								try
								{
									result = SqlDependency.s_processDispatcher.Stop(connectionString, out server, out identity, out userName, out database, ref service, SqlDependency.s_appDomainKey, out flag2);
									goto IL_CB;
								}
								finally
								{
									if (flag2 && !startFailed)
									{
										SqlDependency.IdentityUserNamePair identityUser = new SqlDependency.IdentityUserNamePair(identity, userName);
										SqlDependency.DatabaseServicePair databaseService = new SqlDependency.DatabaseServicePair(database, service);
										SqlDependency.RemoveFromServerUserHash(server, identityUser, databaseService);
									}
								}
							}
							bool flag3;
							result = SqlDependency.s_processDispatcher.Stop(connectionString, out server, out identity, out userName, out database, ref queue, SqlDependency.s_appDomainKey, out flag3);
							IL_CB:;
						}
						catch (Exception e)
						{
							if (!ADP.IsCatchableExceptionType(e))
							{
								throw;
							}
							ADP.TraceExceptionWithoutRethrow(e);
						}
					}
				}
				return result;
			}
			if (connectionString == null)
			{
				throw ADP.ArgumentNull("connectionString");
			}
			throw ADP.Argument("connectionString");
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00071150 File Offset: 0x0006F350
		private static bool AddToServerUserHash(string server, SqlDependency.IdentityUserNamePair identityUser, SqlDependency.DatabaseServicePair databaseService)
		{
			bool result = false;
			Dictionary<string, Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>>> obj = SqlDependency.s_serverUserHash;
			lock (obj)
			{
				Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>> dictionary;
				if (!SqlDependency.s_serverUserHash.ContainsKey(server))
				{
					dictionary = new Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>>();
					SqlDependency.s_serverUserHash.Add(server, dictionary);
				}
				else
				{
					dictionary = SqlDependency.s_serverUserHash[server];
				}
				List<SqlDependency.DatabaseServicePair> list;
				if (!dictionary.ContainsKey(identityUser))
				{
					list = new List<SqlDependency.DatabaseServicePair>();
					dictionary.Add(identityUser, list);
				}
				else
				{
					list = dictionary[identityUser];
				}
				if (!list.Contains(databaseService))
				{
					list.Add(databaseService);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000711F4 File Offset: 0x0006F3F4
		private static void RemoveFromServerUserHash(string server, SqlDependency.IdentityUserNamePair identityUser, SqlDependency.DatabaseServicePair databaseService)
		{
			Dictionary<string, Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>>> obj = SqlDependency.s_serverUserHash;
			lock (obj)
			{
				if (SqlDependency.s_serverUserHash.ContainsKey(server))
				{
					Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>> dictionary = SqlDependency.s_serverUserHash[server];
					if (dictionary.ContainsKey(identityUser))
					{
						List<SqlDependency.DatabaseServicePair> list = dictionary[identityUser];
						int num = list.IndexOf(databaseService);
						if (num >= 0)
						{
							list.RemoveAt(num);
							if (list.Count == 0)
							{
								dictionary.Remove(identityUser);
								if (dictionary.Count == 0)
								{
									SqlDependency.s_serverUserHash.Remove(server);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00071294 File Offset: 0x0006F494
		internal static string GetDefaultComposedOptions(string server, string failoverServer, SqlDependency.IdentityUserNamePair identityUser, string database)
		{
			Dictionary<string, Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>>> obj = SqlDependency.s_serverUserHash;
			string result;
			lock (obj)
			{
				if (!SqlDependency.s_serverUserHash.ContainsKey(server))
				{
					if (SqlDependency.s_serverUserHash.Count == 0)
					{
						throw SQL.SqlDepDefaultOptionsButNoStart();
					}
					if (string.IsNullOrEmpty(failoverServer) || !SqlDependency.s_serverUserHash.ContainsKey(failoverServer))
					{
						throw SQL.SqlDependencyNoMatchingServerStart();
					}
					server = failoverServer;
				}
				Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>> dictionary = SqlDependency.s_serverUserHash[server];
				List<SqlDependency.DatabaseServicePair> list = null;
				if (!dictionary.ContainsKey(identityUser))
				{
					if (dictionary.Count > 1)
					{
						throw SQL.SqlDependencyNoMatchingServerStart();
					}
					using (Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>>.Enumerator enumerator = dictionary.GetEnumerator())
					{
						if (!enumerator.MoveNext())
						{
							goto IL_B6;
						}
						KeyValuePair<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>> keyValuePair = enumerator.Current;
						list = keyValuePair.Value;
						goto IL_B6;
					}
				}
				list = dictionary[identityUser];
				IL_B6:
				SqlDependency.DatabaseServicePair item = new SqlDependency.DatabaseServicePair(database, null);
				SqlDependency.DatabaseServicePair databaseServicePair = null;
				int num = list.IndexOf(item);
				if (num != -1)
				{
					databaseServicePair = list[num];
				}
				if (databaseServicePair != null)
				{
					database = SqlDependency.FixupServiceOrDatabaseName(databaseServicePair.Database);
					string str = SqlDependency.FixupServiceOrDatabaseName(databaseServicePair.Service);
					result = "Service=" + str + ";Local Database=" + database;
				}
				else
				{
					if (list.Count != 1)
					{
						throw SQL.SqlDependencyNoMatchingServerDatabaseStart();
					}
					object[] array = list.ToArray();
					databaseServicePair = (SqlDependency.DatabaseServicePair)array[0];
					string str2 = SqlDependency.FixupServiceOrDatabaseName(databaseServicePair.Database);
					string str3 = SqlDependency.FixupServiceOrDatabaseName(databaseServicePair.Service);
					result = "Service=" + str3 + ";Local Database=" + str2;
				}
			}
			return result;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00071448 File Offset: 0x0006F648
		internal void AddToServerList(string server)
		{
			List<string> serverList = this._serverList;
			lock (serverList)
			{
				int num = this._serverList.BinarySearch(server, StringComparer.OrdinalIgnoreCase);
				if (0 > num)
				{
					num = ~num;
					this._serverList.Insert(num, server);
				}
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000714A8 File Offset: 0x0006F6A8
		internal bool ContainsServer(string server)
		{
			List<string> serverList = this._serverList;
			bool result;
			lock (serverList)
			{
				result = this._serverList.Contains(server);
			}
			return result;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x000714F0 File Offset: 0x0006F6F0
		internal string ComputeHashAndAddToDispatcher(SqlCommand command)
		{
			string commandHash = this.ComputeCommandHash(command.Connection.ConnectionString, command);
			return SqlDependencyPerAppDomainDispatcher.SingletonInstance.AddCommandEntry(commandHash, this);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0007151C File Offset: 0x0006F71C
		internal void Invalidate(SqlNotificationType type, SqlNotificationInfo info, SqlNotificationSource source)
		{
			List<SqlDependency.EventContextPair> list = null;
			object eventHandlerLock = this._eventHandlerLock;
			lock (eventHandlerLock)
			{
				if (this._dependencyFired && SqlNotificationInfo.AlreadyChanged != info && SqlNotificationSource.Client != source)
				{
					if (this.ExpirationTime >= DateTime.UtcNow)
					{
					}
				}
				else
				{
					this._dependencyFired = true;
					list = this._eventList;
					this._eventList = new List<SqlDependency.EventContextPair>();
				}
			}
			if (list != null)
			{
				foreach (SqlDependency.EventContextPair eventContextPair in list)
				{
					eventContextPair.Invoke(new SqlNotificationEventArgs(type, info, source));
				}
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x000715DC File Offset: 0x0006F7DC
		internal void StartTimer(SqlNotificationRequest notificationRequest)
		{
			if (this._expirationTime == DateTime.MaxValue)
			{
				int num = 432000;
				if (this._timeout != 0)
				{
					num = this._timeout;
				}
				if (notificationRequest != null && notificationRequest.Timeout < num && notificationRequest.Timeout != 0)
				{
					num = notificationRequest.Timeout;
				}
				this._expirationTime = DateTime.UtcNow.AddSeconds((double)num);
				SqlDependencyPerAppDomainDispatcher.SingletonInstance.StartTimer(this);
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0007164C File Offset: 0x0006F84C
		private void AddCommandInternal(SqlCommand cmd)
		{
			if (cmd != null)
			{
				SqlConnection connection = cmd.Connection;
				if (cmd.Notification != null)
				{
					if (cmd._sqlDep == null || cmd._sqlDep != this)
					{
						throw SQL.SqlCommandHasExistingSqlNotificationRequest();
					}
				}
				else
				{
					bool flag = false;
					object eventHandlerLock = this._eventHandlerLock;
					lock (eventHandlerLock)
					{
						if (!this._dependencyFired)
						{
							cmd.Notification = new SqlNotificationRequest
							{
								Timeout = this._timeout
							};
							if (this._options != null)
							{
								cmd.Notification.Options = this._options;
							}
							cmd._sqlDep = this;
						}
						else if (this._eventList.Count == 0)
						{
							flag = true;
						}
					}
					if (flag)
					{
						this.Invalidate(SqlNotificationType.Subscribe, SqlNotificationInfo.AlreadyChanged, SqlNotificationSource.Client);
					}
				}
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00071718 File Offset: 0x0006F918
		private string ComputeCommandHash(string connectionString, SqlCommand command)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0};{1}", connectionString, command.CommandText);
			for (int i = 0; i < command.Parameters.Count; i++)
			{
				object value = command.Parameters[i].Value;
				if (value == null || value == DBNull.Value)
				{
					stringBuilder.Append("; NULL");
				}
				else
				{
					Type type = value.GetType();
					if (type == typeof(byte[]))
					{
						stringBuilder.Append(";");
						byte[] array = (byte[])value;
						for (int j = 0; j < array.Length; j++)
						{
							stringBuilder.Append(array[j].ToString("x2", CultureInfo.InvariantCulture));
						}
					}
					else if (type == typeof(char[]))
					{
						stringBuilder.Append((char[])value);
					}
					else if (type == typeof(XmlReader))
					{
						stringBuilder.Append(";");
						stringBuilder.Append(Guid.NewGuid().ToString());
					}
					else
					{
						stringBuilder.Append(";");
						stringBuilder.Append(value.ToString());
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00071864 File Offset: 0x0006FA64
		internal static string FixupServiceOrDatabaseName(string name)
		{
			if (!string.IsNullOrEmpty(name))
			{
				return "\"" + name.Replace("\"", "\"\"") + "\"";
			}
			return name;
		}

		// Token: 0x04000FA9 RID: 4009
		private readonly string _id = Guid.NewGuid().ToString() + ";" + SqlDependency.s_appDomainKey;

		// Token: 0x04000FAA RID: 4010
		private string _options;

		// Token: 0x04000FAB RID: 4011
		private int _timeout;

		// Token: 0x04000FAC RID: 4012
		private bool _dependencyFired;

		// Token: 0x04000FAD RID: 4013
		private List<SqlDependency.EventContextPair> _eventList = new List<SqlDependency.EventContextPair>();

		// Token: 0x04000FAE RID: 4014
		private object _eventHandlerLock = new object();

		// Token: 0x04000FAF RID: 4015
		private DateTime _expirationTime = DateTime.MaxValue;

		// Token: 0x04000FB0 RID: 4016
		private List<string> _serverList = new List<string>();

		// Token: 0x04000FB1 RID: 4017
		private static object s_startStopLock = new object();

		// Token: 0x04000FB2 RID: 4018
		private static readonly string s_appDomainKey = Guid.NewGuid().ToString();

		// Token: 0x04000FB3 RID: 4019
		private static Dictionary<string, Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>>> s_serverUserHash = new Dictionary<string, Dictionary<SqlDependency.IdentityUserNamePair, List<SqlDependency.DatabaseServicePair>>>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000FB4 RID: 4020
		private static SqlDependencyProcessDispatcher s_processDispatcher = null;

		// Token: 0x04000FB5 RID: 4021
		private static readonly string s_assemblyName = typeof(SqlDependencyProcessDispatcher).Assembly.FullName;

		// Token: 0x04000FB6 RID: 4022
		private static readonly string s_typeName = typeof(SqlDependencyProcessDispatcher).FullName;

		// Token: 0x020001F7 RID: 503
		internal class IdentityUserNamePair
		{
			// Token: 0x06001890 RID: 6288 RVA: 0x00071901 File Offset: 0x0006FB01
			internal IdentityUserNamePair(DbConnectionPoolIdentity identity, string userName)
			{
				this._identity = identity;
				this._userName = userName;
			}

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x06001891 RID: 6289 RVA: 0x00071917 File Offset: 0x0006FB17
			internal DbConnectionPoolIdentity Identity
			{
				get
				{
					return this._identity;
				}
			}

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x06001892 RID: 6290 RVA: 0x0007191F File Offset: 0x0006FB1F
			internal string UserName
			{
				get
				{
					return this._userName;
				}
			}

			// Token: 0x06001893 RID: 6291 RVA: 0x00071928 File Offset: 0x0006FB28
			public override bool Equals(object value)
			{
				SqlDependency.IdentityUserNamePair identityUserNamePair = (SqlDependency.IdentityUserNamePair)value;
				bool result = false;
				if (identityUserNamePair == null)
				{
					result = false;
				}
				else if (this == identityUserNamePair)
				{
					result = true;
				}
				else if (this._identity != null)
				{
					if (this._identity.Equals(identityUserNamePair._identity))
					{
						result = true;
					}
				}
				else if (this._userName == identityUserNamePair._userName)
				{
					result = true;
				}
				return result;
			}

			// Token: 0x06001894 RID: 6292 RVA: 0x00071984 File Offset: 0x0006FB84
			public override int GetHashCode()
			{
				int hashCode;
				if (this._identity != null)
				{
					hashCode = this._identity.GetHashCode();
				}
				else
				{
					hashCode = this._userName.GetHashCode();
				}
				return hashCode;
			}

			// Token: 0x04000FB7 RID: 4023
			private DbConnectionPoolIdentity _identity;

			// Token: 0x04000FB8 RID: 4024
			private string _userName;
		}

		// Token: 0x020001F8 RID: 504
		private class DatabaseServicePair
		{
			// Token: 0x06001895 RID: 6293 RVA: 0x000719B6 File Offset: 0x0006FBB6
			internal DatabaseServicePair(string database, string service)
			{
				this._database = database;
				this._service = service;
			}

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x06001896 RID: 6294 RVA: 0x000719CC File Offset: 0x0006FBCC
			internal string Database
			{
				get
				{
					return this._database;
				}
			}

			// Token: 0x17000469 RID: 1129
			// (get) Token: 0x06001897 RID: 6295 RVA: 0x000719D4 File Offset: 0x0006FBD4
			internal string Service
			{
				get
				{
					return this._service;
				}
			}

			// Token: 0x06001898 RID: 6296 RVA: 0x000719DC File Offset: 0x0006FBDC
			public override bool Equals(object value)
			{
				SqlDependency.DatabaseServicePair databaseServicePair = (SqlDependency.DatabaseServicePair)value;
				bool result = false;
				if (databaseServicePair == null)
				{
					result = false;
				}
				else if (this == databaseServicePair)
				{
					result = true;
				}
				else if (this._database == databaseServicePair._database)
				{
					result = true;
				}
				return result;
			}

			// Token: 0x06001899 RID: 6297 RVA: 0x00071A17 File Offset: 0x0006FC17
			public override int GetHashCode()
			{
				return this._database.GetHashCode();
			}

			// Token: 0x04000FB9 RID: 4025
			private string _database;

			// Token: 0x04000FBA RID: 4026
			private string _service;
		}

		// Token: 0x020001F9 RID: 505
		internal class EventContextPair
		{
			// Token: 0x0600189A RID: 6298 RVA: 0x00071A24 File Offset: 0x0006FC24
			internal EventContextPair(OnChangeEventHandler eventHandler, SqlDependency dependency)
			{
				this._eventHandler = eventHandler;
				this._context = ExecutionContext.Capture();
				this._dependency = dependency;
			}

			// Token: 0x0600189B RID: 6299 RVA: 0x00071A48 File Offset: 0x0006FC48
			public override bool Equals(object value)
			{
				SqlDependency.EventContextPair eventContextPair = (SqlDependency.EventContextPair)value;
				bool result = false;
				if (eventContextPair == null)
				{
					result = false;
				}
				else if (this == eventContextPair)
				{
					result = true;
				}
				else if (this._eventHandler == eventContextPair._eventHandler)
				{
					result = true;
				}
				return result;
			}

			// Token: 0x0600189C RID: 6300 RVA: 0x00071A83 File Offset: 0x0006FC83
			public override int GetHashCode()
			{
				return this._eventHandler.GetHashCode();
			}

			// Token: 0x0600189D RID: 6301 RVA: 0x00071A90 File Offset: 0x0006FC90
			internal void Invoke(SqlNotificationEventArgs args)
			{
				this._args = args;
				ExecutionContext.Run(this._context, SqlDependency.EventContextPair.s_contextCallback, this);
			}

			// Token: 0x0600189E RID: 6302 RVA: 0x00071AAC File Offset: 0x0006FCAC
			private static void InvokeCallback(object eventContextPair)
			{
				SqlDependency.EventContextPair eventContextPair2 = (SqlDependency.EventContextPair)eventContextPair;
				eventContextPair2._eventHandler(eventContextPair2._dependency, eventContextPair2._args);
			}

			// Token: 0x04000FBB RID: 4027
			private OnChangeEventHandler _eventHandler;

			// Token: 0x04000FBC RID: 4028
			private ExecutionContext _context;

			// Token: 0x04000FBD RID: 4029
			private SqlDependency _dependency;

			// Token: 0x04000FBE RID: 4030
			private SqlNotificationEventArgs _args;

			// Token: 0x04000FBF RID: 4031
			private static ContextCallback s_contextCallback = new ContextCallback(SqlDependency.EventContextPair.InvokeCallback);
		}
	}
}
