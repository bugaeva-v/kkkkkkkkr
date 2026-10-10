using System;
using System.Security.Principal;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Представляет абстракцию контекста вызывающего кода, обеспечивающую доступ к объектам <see cref="T:Microsoft.SqlServer.Server.SqlPipe" />, <see cref="T:Microsoft.SqlServer.Server.SqlTriggerContext" /> и <see cref="T:System.Security.Principal.WindowsIdentity" />. Этот класс не наследуется.</summary>
	// Token: 0x02000064 RID: 100
	public sealed class SqlContext
	{
		/// <summary>Показывает, выполняется ли вызывающий код в SQL Server и доступно ли контекстное соединение.</summary>
		/// <returns>
		///   <see langword="True" />, если контекстное соединение доступно, равно как и остальные члены класса <see cref="T:Microsoft.SqlServer.Server.SqlContext" />.</returns>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00006D64 File Offset: 0x00004F64
		public static bool IsAvailable
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект канала, позволяющий отправлять из вызывающего кода клиенту результирующие наборы, сообщения и результаты выполнения команд.</summary>
		/// <returns>Экземпляр <see cref="T:Microsoft.SqlServer.Server.SqlPipe" />, если канал доступен, или <see langword="null" /> при вызове из контекста, в котором канал недоступен (например, в пользовательской функции).</returns>
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00003E32 File Offset: 0x00002032
		public static SqlPipe Pipe
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает контекст триггера, используемый для передачи в вызывающий код сведений о причинах срабатывания триггера и таблицы обновленных столбцов.</summary>
		/// <returns>Экземпляр <see cref="T:Microsoft.SqlServer.Server.SqlTriggerContext" />, если контекст триггера доступен, или <see langword="null" /> при вызове извне области действия триггера.</returns>
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00003E32 File Offset: 0x00002032
		public static SqlTriggerContext TriggerContext
		{
			get
			{
				return null;
			}
		}

		/// <summary>Удостоверение Microsoft Windows для вызывающего кода.</summary>
		/// <returns>Экземпляр <see cref="T:System.Security.Principal.WindowsIdentity" />, представляющий удостоверение Windows для вызывающего кода, или <see langword="null" />, если клиент прошел проверку подлинности с помощью средств проверки подлинности SQL Server.</returns>
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00003E32 File Offset: 0x00002032
		public static WindowsIdentity WindowsIdentity
		{
			get
			{
				return null;
			}
		}
	}
}
