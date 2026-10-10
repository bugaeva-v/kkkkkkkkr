using System;

namespace System.Data
{
	/// <summary>Предоставляет данные для события изменения состояния поставщика данных .NET Framework.</summary>
	// Token: 0x02000131 RID: 305
	public sealed class StateChangeEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.StateChangeEventArgs" /> при данном исходном и текущем состоянии объекта.</summary>
		/// <param name="originalState">Одно из значений перечисления <see cref="T:System.Data.ConnectionState" />.</param>
		/// <param name="currentState">Одно из значений перечисления <see cref="T:System.Data.ConnectionState" />.</param>
		// Token: 0x060010A2 RID: 4258 RVA: 0x00045BDA File Offset: 0x00043DDA
		public StateChangeEventArgs(ConnectionState originalState, ConnectionState currentState)
		{
			this._originalState = originalState;
			this._currentState = currentState;
		}

		/// <summary>Получает новое состояние подключения. Объект подключения будет уже в новом состоянии, когда событие запущено.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Data.ConnectionState" />.</returns>
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00045BF0 File Offset: 0x00043DF0
		public ConnectionState CurrentState
		{
			get
			{
				return this._currentState;
			}
		}

		/// <summary>Получает текущее состояние подключения.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Data.ConnectionState" />.</returns>
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00045BF8 File Offset: 0x00043DF8
		public ConnectionState OriginalState
		{
			get
			{
				return this._originalState;
			}
		}

		// Token: 0x04000A42 RID: 2626
		private ConnectionState _originalState;

		// Token: 0x04000A43 RID: 2627
		private ConnectionState _currentState;
	}
}
