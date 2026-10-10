using System;
using System.Security;

namespace System.Threading
{
	/// <summary>Обеспечивает функциональность для восстановления миграции или перемещения контекста выполнения между потоками.</summary>
	// Token: 0x020002CA RID: 714
	public struct AsyncFlowControl : IDisposable
	{
		// Token: 0x06001EE8 RID: 7912 RVA: 0x00072BD8 File Offset: 0x00070DD8
		[SecurityCritical]
		internal void Setup()
		{
			this.useEC = true;
			Thread currentThread = Thread.CurrentThread;
			this._ec = currentThread.GetMutableExecutionContext();
			this._ec.isFlowSuppressed = true;
			this._thread = currentThread;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Threading.AsyncFlowControl" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Структура <see cref="T:System.Threading.AsyncFlowControl" /> не используется в потоке, в котором она была создана.  
		///
		/// или - 
		/// Структура <see cref="T:System.Threading.AsyncFlowControl" /> уже использовалась для вызова <see cref="M:System.Threading.AsyncFlowControl.Dispose" /> или <see cref="M:System.Threading.AsyncFlowControl.Undo" />.</exception>
		// Token: 0x06001EE9 RID: 7913 RVA: 0x00072C11 File Offset: 0x00070E11
		public void Dispose()
		{
			this.Undo();
		}

		/// <summary>Восстанавливает перемещение контекста выполнения между потоками.</summary>
		/// <exception cref="T:System.InvalidOperationException">Структура <see cref="T:System.Threading.AsyncFlowControl" /> не используется в потоке, в котором она была создана.  
		///
		/// или - 
		/// Структура <see cref="T:System.Threading.AsyncFlowControl" /> уже использовалась для вызова <see cref="M:System.Threading.AsyncFlowControl.Dispose" /> или <see cref="M:System.Threading.AsyncFlowControl.Undo" />.</exception>
		// Token: 0x06001EEA RID: 7914 RVA: 0x00072C1C File Offset: 0x00070E1C
		[SecuritySafeCritical]
		public void Undo()
		{
			if (this._thread == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("AsyncFlowControl object can be used only once to call Undo()."));
			}
			if (this._thread != Thread.CurrentThread)
			{
				throw new InvalidOperationException(Environment.GetResourceString("AsyncFlowControl object must be used on the thread where it was created."));
			}
			if (this.useEC)
			{
				if (Thread.CurrentThread.GetMutableExecutionContext() != this._ec)
				{
					throw new InvalidOperationException(Environment.GetResourceString("AsyncFlowControl objects can be used to restore flow only on the Context that had its flow suppressed."));
				}
				ExecutionContext.RestoreFlow();
			}
			this._thread = null;
		}

		/// <summary>Получает хэш-код текущей структуры <see cref="T:System.Threading.AsyncFlowControl" />.</summary>
		/// <returns>Хэш-код для текущей структуры <see cref="T:System.Threading.AsyncFlowControl" />.</returns>
		// Token: 0x06001EEB RID: 7915 RVA: 0x00072C94 File Offset: 0x00070E94
		public override int GetHashCode()
		{
			if (this._thread != null)
			{
				return this._thread.GetHashCode();
			}
			return this.ToString().GetHashCode();
		}

		/// <summary>Определяет, эквивалентен ли указанный объект текущей структуре <see cref="T:System.Threading.AsyncFlowControl" />.</summary>
		/// <param name="obj">Объект для сравнения с текущей структурой.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является структурой <see cref="T:System.Threading.AsyncFlowControl" /> и эквивалентен текущей структуре <see cref="T:System.Threading.AsyncFlowControl" /> в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001EEC RID: 7916 RVA: 0x00072CBB File Offset: 0x00070EBB
		public override bool Equals(object obj)
		{
			return obj is AsyncFlowControl && this.Equals((AsyncFlowControl)obj);
		}

		/// <summary>Определяет, равна ли указанная структура <see cref="T:System.Threading.AsyncFlowControl" /> текущей структуре <see cref="T:System.Threading.AsyncFlowControl" />.</summary>
		/// <param name="obj">Структура <see cref="T:System.Threading.AsyncFlowControl" /> для сравнения с текущей структурой.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> равен текущей структуре <see cref="T:System.Threading.AsyncFlowControl" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001EED RID: 7917 RVA: 0x00072CD3 File Offset: 0x00070ED3
		public bool Equals(AsyncFlowControl obj)
		{
			return obj.useEC == this.useEC && obj._ec == this._ec && obj._thread == this._thread;
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Threading.AsyncFlowControl" />, чтобы определить, совпадают ли они.</summary>
		/// <param name="a">Структура <see cref="T:System.Threading.AsyncFlowControl" />.</param>
		/// <param name="b">Структура <see cref="T:System.Threading.AsyncFlowControl" />.</param>
		/// <returns>Значение <see langword="true" />, если обе структуры эквивалентны, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001EEE RID: 7918 RVA: 0x00072D01 File Offset: 0x00070F01
		public static bool operator ==(AsyncFlowControl a, AsyncFlowControl b)
		{
			return a.Equals(b);
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Threading.AsyncFlowControl" /> на неравенство.</summary>
		/// <param name="a">Структура <see cref="T:System.Threading.AsyncFlowControl" />.</param>
		/// <param name="b">Структура <see cref="T:System.Threading.AsyncFlowControl" />.</param>
		/// <returns>Значение <see langword="true" />, если структуры не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001EEF RID: 7919 RVA: 0x00072D0B File Offset: 0x00070F0B
		public static bool operator !=(AsyncFlowControl a, AsyncFlowControl b)
		{
			return !(a == b);
		}

		// Token: 0x04001AF2 RID: 6898
		private bool useEC;

		// Token: 0x04001AF3 RID: 6899
		private ExecutionContext _ec;

		// Token: 0x04001AF4 RID: 6900
		private Thread _thread;
	}
}
