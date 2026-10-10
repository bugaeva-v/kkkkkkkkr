using System;
using System.Data.SqlClient;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Разрешает управляемым хранимым процедурам, выполняемым внутри процесса в базе данных SQL Server, возвращать результаты в вызывающую программу. Этот класс не наследуется.</summary>
	// Token: 0x02000065 RID: 101
	public sealed class SqlPipe
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x00003D93 File Offset: 0x00001F93
		private SqlPipe()
		{
		}

		/// <summary>Получает значение, показывающее, находится ли объект <see cref="T:Microsoft.SqlServer.Server.SqlPipe" /> в режиме отправки одиночных результирующих наборов клиенту. Это свойство доступно только для чтения.</summary>
		/// <returns>
		///   <see langword="true" />, если вызван метод <see cref="M:Microsoft.SqlServer.Server.SqlPipe.SendResultsStart(Microsoft.SqlServer.Server.SqlDataRecord)" /> и объект <see cref="T:Microsoft.SqlServer.Server.SqlPipe" /> находится в режиме отправки одиночных результирующих наборов клиенту; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00006D64 File Offset: 0x00004F64
		public bool IsSendingResults
		{
			get
			{
				return false;
			}
		}

		/// <summary>Выполняет команду, переданную в качестве параметра, и отправляет результаты клиенту.</summary>
		/// <param name="command">Объект <see cref="T:System.Data.SqlClient.SqlCommand" />, который требуется выполнить.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="command" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный метод не поддерживается для команд, привязанных к подключениям вне процессов.</exception>
		// Token: 0x060004AB RID: 1195 RVA: 0x00010C60 File Offset: 0x0000EE60
		public void ExecuteAndSend(SqlCommand command)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет строковое сообщение непосредственно клиенту или текущему получателю выходных данных.</summary>
		/// <param name="message">Строка сообщения, отправляемая клиенту.</param>
		/// <exception cref="T:System.ArgumentException">Длина сообщения <paramref name="message" /> превышает 4000 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="message" /> — <see langword="null" />.</exception>
		// Token: 0x060004AC RID: 1196 RVA: 0x00010C60 File Offset: 0x0000EE60
		public void Send(string message)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет многострочный результирующий набор непосредственно клиенту или текущему получателю выходных данных.</summary>
		/// <param name="reader">Многострочный результирующий набор, отправляемый клиенту: объект <see cref="T:System.Data.SqlClient.SqlDataReader" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="reader" /> — <see langword="null" />.</exception>
		// Token: 0x060004AD RID: 1197 RVA: 0x00010C60 File Offset: 0x0000EE60
		public void Send(SqlDataReader reader)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет однострочный результирующий набор непосредственно клиенту или текущему получателю выходных данных.</summary>
		/// <param name="record">Однострочный результирующий набор, отправляемый клиенту: объект <see cref="T:Microsoft.SqlServer.Server.SqlDataRecord" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="record" /> — <see langword="null" />.</exception>
		// Token: 0x060004AE RID: 1198 RVA: 0x00010C60 File Offset: 0x0000EE60
		public void Send(SqlDataRecord record)
		{
			throw new NotImplementedException();
		}

		/// <summary>Помечает начало результирующего набора, отправляемого клиенту, и использует указанную запись для конструирования метаданных, описывающих результирующий набор.</summary>
		/// <param name="record">Объект <see cref="T:Microsoft.SqlServer.Server.SqlDataRecord" />, из которого извлекаются метаданные, используемые для описания результирующего набора.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="record" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Объект <paramref name="record" /> не содержит столбцов или не был инициализирован.</exception>
		/// <exception cref="T:System.InvalidOperationException">После вызова метода <see cref="M:Microsoft.SqlServer.Server.SqlPipe.SendResultsRow(Microsoft.SqlServer.Server.SqlDataRecord)" /> был вызван метод, отличный от <see cref="M:Microsoft.SqlServer.Server.SqlPipe.SendResultsEnd" /> и <see cref="M:Microsoft.SqlServer.Server.SqlPipe.SendResultsStart(Microsoft.SqlServer.Server.SqlDataRecord)" />.</exception>
		// Token: 0x060004AF RID: 1199 RVA: 0x00010C60 File Offset: 0x0000EE60
		public void SendResultsStart(SqlDataRecord record)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет клиенту одну строку данных.</summary>
		/// <param name="record">Объект <see cref="T:Microsoft.SqlServer.Server.SqlDataRecord" />, содержащий значения столбцов для строки, отправляемой клиенту. Схема для записи должна соответствовать схеме, описанной метаданными объекта <see cref="T:Microsoft.SqlServer.Server.SqlDataRecord" />, переданного в метод <see cref="M:Microsoft.SqlServer.Server.SqlPipe.SendResultsStart(Microsoft.SqlServer.Server.SqlDataRecord)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="record" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Перед этим не был вызван метод <see cref="M:Microsoft.SqlServer.Server.SqlPipe.SendResultsStart(Microsoft.SqlServer.Server.SqlDataRecord)" />.</exception>
		// Token: 0x060004B0 RID: 1200 RVA: 0x00010C60 File Offset: 0x0000EE60
		public void SendResultsRow(SqlDataRecord record)
		{
			throw new NotImplementedException();
		}

		/// <summary>Помечает окончание результирующего набора и возвращает экземпляр <see cref="T:Microsoft.SqlServer.Server.SqlPipe" /> в начальное состояние.</summary>
		/// <exception cref="T:System.InvalidOperationException">Перед этим не был вызван метод <see cref="M:Microsoft.SqlServer.Server.SqlPipe.SendResultsStart(Microsoft.SqlServer.Server.SqlDataRecord)" />.</exception>
		// Token: 0x060004B1 RID: 1201 RVA: 0x00010C60 File Offset: 0x0000EE60
		public void SendResultsEnd()
		{
			throw new NotImplementedException();
		}
	}
}
