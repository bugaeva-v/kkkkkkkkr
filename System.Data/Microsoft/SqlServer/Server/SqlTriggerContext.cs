using System;
using System.Data.Common;
using System.Data.SqlTypes;
using Unity;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Предоставляет контекстную информацию о сработавшем триггере.</summary>
	// Token: 0x02000054 RID: 84
	public sealed class SqlTriggerContext
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x0001083D File Offset: 0x0000EA3D
		internal SqlTriggerContext(TriggerAction triggerAction, bool[] columnsUpdated, SqlXml eventInstanceData)
		{
			this._triggerAction = triggerAction;
			this._columnsUpdated = columnsUpdated;
			this._eventInstanceData = eventInstanceData;
		}

		/// <summary>Получает число столбцов, содержащихся в таблице данных, привязанной к триггеру. Это свойство доступно только для чтения.</summary>
		/// <returns>Целое число, обозначающее количество столбцов в таблице данных, привязанной к триггеру.</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001085C File Offset: 0x0000EA5C
		public int ColumnCount
		{
			get
			{
				int result = 0;
				if (this._columnsUpdated != null)
				{
					result = this._columnsUpdated.Length;
				}
				return result;
			}
		}

		/// <summary>Получает данные о событии, связанном с действием, которое вызвало срабатывание триггера.</summary>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlXml" /> с данными о событии, связанном с действием, вызвавшем срабатывание триггера, если имеется дополнительная информация; в противном случае возвращается <see langword="null" />.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0001087D File Offset: 0x0000EA7D
		public SqlXml EventData
		{
			get
			{
				return this._eventInstanceData;
			}
		}

		/// <summary>Показывает, какое действие вызвало срабатывание триггера.</summary>
		/// <returns>Действие, вызвавшее срабатывание триггера, в виде объекта <see cref="T:Microsoft.SqlServer.Server.TriggerAction" />.</returns>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00010885 File Offset: 0x0000EA85
		public TriggerAction TriggerAction
		{
			get
			{
				return this._triggerAction;
			}
		}

		/// <summary>Возвращает <see langword="true" />, если столбец был обработан оператором INSERT или UPDATE.</summary>
		/// <param name="columnOrdinal">Отсчитываемый от нуля порядковый номер столбца.</param>
		/// <returns>
		///   <see langword="true" />, если столбец был подвергнут операции INSERT или UPDATE.</returns>
		/// <exception cref="T:System.InvalidOperationException">Метод вызван в контексте триггера, в котором значение свойства <see cref="P:Microsoft.SqlServer.Server.SqlTriggerContext.TriggerAction" /> отлично от <see langword="Insert" /> и <see langword="Update" />.</exception>
		// Token: 0x06000454 RID: 1108 RVA: 0x0001088D File Offset: 0x0000EA8D
		public bool IsUpdatedColumn(int columnOrdinal)
		{
			if (this._columnsUpdated != null)
			{
				return this._columnsUpdated[columnOrdinal];
			}
			throw ADP.IndexOutOfRange(columnOrdinal);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal SqlTriggerContext()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400053A RID: 1338
		private TriggerAction _triggerAction;

		// Token: 0x0400053B RID: 1339
		private bool[] _columnsUpdated;

		// Token: 0x0400053C RID: 1340
		private SqlXml _eventInstanceData;
	}
}
