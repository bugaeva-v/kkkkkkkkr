using System;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Представляет средство ведения журнала клиента SQL.</summary>
	// Token: 0x020003F0 RID: 1008
	public class SqlClientLogger
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlClientLogger" />.</summary>
		// Token: 0x06002F94 RID: 12180 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlClientLogger()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает значение, указывающее, включена ли трассировка встроенных средств диагностики.</summary>
		/// <returns>Значение <see langword="true" />, если трассировка встроенных средств диагностики включена; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x000CBAE8 File Offset: 0x000C9CE8
		public bool IsLoggingEnabled
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>Регистрирует указанное сообщение, если <paramref name="value" /> — <see langword="false" />.</summary>
		/// <param name="value">Значение <see langword="false" /> для записи сообщения в журнал; в противном случае — <see langword="true" />.</param>
		/// <param name="type">Тип, который записывается в журнал.</param>
		/// <param name="method">Метод ведения журнала.</param>
		/// <param name="message">Сообщение для записи.</param>
		/// <returns>Значение <see langword="true" />, если сообщение не регистрируется; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002F96 RID: 12182 RVA: 0x000CBB04 File Offset: 0x000C9D04
		public bool LogAssert(bool value, string type, string method, string message)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>Записывает в журнал ошибку с помощью заданного метода для типа текущего экземпляра.</summary>
		/// <param name="type">Тип, который записывается в журнал.</param>
		/// <param name="method">Метод ведения журнала.</param>
		/// <param name="message">Сообщение для записи.</param>
		// Token: 0x06002F97 RID: 12183 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public void LogError(string type, string method, string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Записывает сведения в журнал с использованием заданного метода для типа текущего экземпляра.</summary>
		/// <param name="type">Тип, который записывается в журнал.</param>
		/// <param name="method">Метод ведения журнала.</param>
		/// <param name="message">Сообщение для записи.</param>
		// Token: 0x06002F98 RID: 12184 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public void LogInfo(string type, string method, string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
