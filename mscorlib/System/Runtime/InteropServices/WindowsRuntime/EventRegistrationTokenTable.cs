using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Хранит сопоставления между делегатами и токенами событий для поддержки реализации события среды выполнения Windows в управляемом коде.</summary>
	/// <typeparam name="T">Тип делегата обработчика событий для конкретного события.</typeparam>
	// Token: 0x02000789 RID: 1929
	public sealed class EventRegistrationTokenTable<T> where T : class
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable`1" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Элемент <paramref name="T" /> не является типом делегата.</exception>
		// Token: 0x0600448E RID: 17550 RVA: 0x000E3BCC File Offset: 0x000E1DCC
		public EventRegistrationTokenTable()
		{
			if (!typeof(Delegate).IsAssignableFrom(typeof(T)))
			{
				throw new InvalidOperationException(Environment.GetResourceString("Type '{0}' is not a delegate type.  EventTokenTable may only be used with delegate types.", new object[]
				{
					typeof(T)
				}));
			}
		}

		/// <summary>Получает или задает делегат типа <paramref name="T" />, список вызовов которого включает все делегаты обработчика событий, которые были добавлены, и которые еще не были удалены. Вызов данного делегата вызывает все обработчики событий.</summary>
		/// <returns>Делегат типа <paramref name="T" />, представляющий все делегаты обработчика событий, которые в настоящее время зарегистрированы для события.</returns>
		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x000E3C28 File Offset: 0x000E1E28
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x000E3C34 File Offset: 0x000E1E34
		public T InvocationList
		{
			get
			{
				return this.m_invokeList;
			}
			set
			{
				Dictionary<EventRegistrationToken, T> tokens = this.m_tokens;
				lock (tokens)
				{
					this.m_tokens.Clear();
					this.m_invokeList = default(T);
					if (value != null)
					{
						this.AddEventHandlerNoLock(value);
					}
				}
			}
		}

		/// <summary>Добавляет указанный обработчик событий к таблице и к списку вызова и возвращает токен, который может использоваться для удаления обработчика событий.</summary>
		/// <param name="handler">Добавляемый обработчик событий.</param>
		/// <returns>Токен, который может быть использован для удаления обработчика событий из списка вызова и таблицы.</returns>
		// Token: 0x06004491 RID: 17553 RVA: 0x000E3C9C File Offset: 0x000E1E9C
		public EventRegistrationToken AddEventHandler(T handler)
		{
			if (handler == null)
			{
				return new EventRegistrationToken(0UL);
			}
			Dictionary<EventRegistrationToken, T> tokens = this.m_tokens;
			EventRegistrationToken result;
			lock (tokens)
			{
				result = this.AddEventHandlerNoLock(handler);
			}
			return result;
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x000E3CF0 File Offset: 0x000E1EF0
		private EventRegistrationToken AddEventHandlerNoLock(T handler)
		{
			EventRegistrationToken preferredToken = EventRegistrationTokenTable<T>.GetPreferredToken(handler);
			while (this.m_tokens.ContainsKey(preferredToken))
			{
				preferredToken = new EventRegistrationToken(preferredToken.Value + 1UL);
			}
			this.m_tokens[preferredToken] = handler;
			Delegate @delegate = (Delegate)((object)this.m_invokeList);
			@delegate = Delegate.Combine(@delegate, (Delegate)((object)handler));
			this.m_invokeList = (T)((object)@delegate);
			return preferredToken;
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x000E3D68 File Offset: 0x000E1F68
		[FriendAccessAllowed]
		internal T ExtractHandler(EventRegistrationToken token)
		{
			T result = default(T);
			Dictionary<EventRegistrationToken, T> tokens = this.m_tokens;
			lock (tokens)
			{
				if (this.m_tokens.TryGetValue(token, out result))
				{
					this.RemoveEventHandlerNoLock(token);
				}
			}
			return result;
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x000E3DC4 File Offset: 0x000E1FC4
		private static EventRegistrationToken GetPreferredToken(T handler)
		{
			Delegate[] invocationList = ((Delegate)((object)handler)).GetInvocationList();
			uint hashCode;
			if (invocationList.Length == 1)
			{
				hashCode = (uint)invocationList[0].Method.GetHashCode();
			}
			else
			{
				hashCode = (uint)handler.GetHashCode();
			}
			return new EventRegistrationToken((ulong)typeof(T).MetadataToken << 32 | (ulong)hashCode);
		}

		/// <summary>Удаляет обработчик событий, связанный с заданным токеном из таблицы и списка вызовов.</summary>
		/// <param name="token">Токен, который был возвращен при добавлении обработчика события.</param>
		// Token: 0x06004495 RID: 17557 RVA: 0x000E3E24 File Offset: 0x000E2024
		public void RemoveEventHandler(EventRegistrationToken token)
		{
			if (token.Value == 0UL)
			{
				return;
			}
			Dictionary<EventRegistrationToken, T> tokens = this.m_tokens;
			lock (tokens)
			{
				this.RemoveEventHandlerNoLock(token);
			}
		}

		/// <summary>Удаляет указанный делегат обработчика событий из таблицы и списка вызовов.</summary>
		/// <param name="handler">Обработчик событий, который требуется удалить.</param>
		// Token: 0x06004496 RID: 17558 RVA: 0x000E3E70 File Offset: 0x000E2070
		public void RemoveEventHandler(T handler)
		{
			if (handler == null)
			{
				return;
			}
			Dictionary<EventRegistrationToken, T> tokens = this.m_tokens;
			lock (tokens)
			{
				EventRegistrationToken preferredToken = EventRegistrationTokenTable<T>.GetPreferredToken(handler);
				T t;
				if (this.m_tokens.TryGetValue(preferredToken, out t) && t == handler)
				{
					this.RemoveEventHandlerNoLock(preferredToken);
				}
				else
				{
					foreach (KeyValuePair<EventRegistrationToken, T> keyValuePair in this.m_tokens)
					{
						if (keyValuePair.Value == (T)((object)handler))
						{
							this.RemoveEventHandlerNoLock(keyValuePair.Key);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x000E3F4C File Offset: 0x000E214C
		private void RemoveEventHandlerNoLock(EventRegistrationToken token)
		{
			T t;
			if (this.m_tokens.TryGetValue(token, out t))
			{
				this.m_tokens.Remove(token);
				Delegate @delegate = (Delegate)((object)this.m_invokeList);
				@delegate = Delegate.Remove(@delegate, (Delegate)((object)t));
				this.m_invokeList = (T)((object)@delegate);
			}
		}

		/// <summary>Возвращает указанную таблицу токена регистрации события, если это не <see langword="null" />; в противном случае возвращает новую таблицу токена регистрации события.</summary>
		/// <param name="refEventTable">Таблица токенов регистрации события, передаваемая по ссылке.</param>
		/// <returns>Таблица токена регистрации события, указанная объектом <paramref name="refEventTable" />, если его значение отлично от <see langword="null" />; в противном случае — новая таблица токена регистрации события.</returns>
		// Token: 0x06004498 RID: 17560 RVA: 0x000E3FA9 File Offset: 0x000E21A9
		public static EventRegistrationTokenTable<T> GetOrCreateEventRegistrationTokenTable(ref EventRegistrationTokenTable<T> refEventTable)
		{
			if (refEventTable == null)
			{
				Interlocked.CompareExchange<EventRegistrationTokenTable<T>>(ref refEventTable, new EventRegistrationTokenTable<T>(), null);
			}
			return refEventTable;
		}

		// Token: 0x04002C25 RID: 11301
		private Dictionary<EventRegistrationToken, T> m_tokens = new Dictionary<EventRegistrationToken, T>();

		// Token: 0x04002C26 RID: 11302
		private volatile T m_invokeList;
	}
}
