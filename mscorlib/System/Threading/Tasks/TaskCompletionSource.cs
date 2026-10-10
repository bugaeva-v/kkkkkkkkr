using System;
using System.Collections.Generic;

namespace System.Threading.Tasks
{
	/// <summary>Представляет сторону производителя задач <see cref="T:System.Threading.Tasks.Task`1" />, не привязанных к делегату и предоставляющих доступ к потребительской стороне через свойство <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" />.</summary>
	/// <typeparam name="TResult">Тип значений результата, связанного с данным объектом <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</typeparam>
	// Token: 0x0200030A RID: 778
	public class TaskCompletionSource<TResult>
	{
		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</summary>
		// Token: 0x0600216E RID: 8558 RVA: 0x000784E9 File Offset: 0x000766E9
		public TaskCompletionSource()
		{
			this._task = new Task<TResult>();
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> с заданными параметрами.</summary>
		/// <param name="creationOptions">Параметры, используемые при создании базовых задач <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="creationOptions" /> представляет параметры, недопустимые для использования с <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</exception>
		// Token: 0x0600216F RID: 8559 RVA: 0x000784FC File Offset: 0x000766FC
		public TaskCompletionSource(TaskCreationOptions creationOptions) : this(null, creationOptions)
		{
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> с указанным состоянием.</summary>
		/// <param name="state">Состояние, используемое в качестве состояния AsyncState базового объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		// Token: 0x06002170 RID: 8560 RVA: 0x00078506 File Offset: 0x00076706
		public TaskCompletionSource(object state) : this(state, TaskCreationOptions.None)
		{
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> с заданным состоянием и параметрами.</summary>
		/// <param name="state">Состояние, используемое в качестве состояния AsyncState базового объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="creationOptions">Параметры, используемые при создании базовых задач <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="creationOptions" /> представляет параметры, недопустимые для использования с <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</exception>
		// Token: 0x06002171 RID: 8561 RVA: 0x00078510 File Offset: 0x00076710
		public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
		{
			this._task = new Task<TResult>(state, creationOptions);
		}

		/// <summary>Получает объект <see cref="T:System.Threading.Tasks.Task`1" />, созданный данным объектом <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</summary>
		/// <returns>Возвращает объект <see cref="T:System.Threading.Tasks.Task`1" />, созданный данным объектом <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</returns>
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x00078525 File Offset: 0x00076725
		public Task<TResult> Task
		{
			get
			{
				return this._task;
			}
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00078530 File Offset: 0x00076730
		private void SpinUntilCompleted()
		{
			SpinWait spinWait = default(SpinWait);
			while (!this._task.IsCompleted)
			{
				spinWait.SpinOnce();
			}
		}

		/// <summary>Пытается перевести базовый элемент <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> и привязывает его к определенному исключению.</summary>
		/// <param name="exception">Выражение для привязки к данному <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <returns>Значение true, если операция выполнена успешно; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Элемент <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="exception" /> имеет значение NULL.</exception>
		// Token: 0x06002174 RID: 8564 RVA: 0x0007855B File Offset: 0x0007675B
		public bool TrySetException(Exception exception)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			bool flag = this._task.TrySetException(exception);
			if (!flag && !this._task.IsCompleted)
			{
				this.SpinUntilCompleted();
			}
			return flag;
		}

		/// <summary>Пытается перевести базовый <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> и привязывает к нему коллекцию объектов исключений.</summary>
		/// <param name="exceptions">Коллекция исключений для привязки к данному объекту <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <returns>Значение true, если операция выполнена успешно; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Элемент <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="exceptions" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="exceptions" /> включает один или несколько элементов со значением null.  
		///
		/// или - 
		/// Коллекция <paramref name="exceptions" /> пуста.</exception>
		// Token: 0x06002175 RID: 8565 RVA: 0x0007858C File Offset: 0x0007678C
		public bool TrySetException(IEnumerable<Exception> exceptions)
		{
			if (exceptions == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exceptions);
			}
			List<Exception> list = new List<Exception>();
			foreach (Exception ex in exceptions)
			{
				if (ex == null)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.TaskCompletionSourceT_TrySetException_NullException, ExceptionArgument.exceptions);
				}
				list.Add(ex);
			}
			if (list.Count == 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.TaskCompletionSourceT_TrySetException_NoExceptions, ExceptionArgument.exceptions);
			}
			bool flag = this._task.TrySetException(list);
			if (!flag && !this._task.IsCompleted)
			{
				this.SpinUntilCompleted();
			}
			return flag;
		}

		/// <summary>Переводит базовый объект <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> и привязывает его к определенному исключению.</summary>
		/// <param name="exception">Выражение для привязки к данному <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">Элемент <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="exception" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовый элемент <see cref="T:System.Threading.Tasks.Task`1" /> уже находится в одном из трех конечных состояний: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> или <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x06002176 RID: 8566 RVA: 0x00078624 File Offset: 0x00076824
		public void SetException(Exception exception)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			if (!this.TrySetException(exception))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		/// <summary>Переводит базовый объект <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> и привязывает к нему коллекцию объектов исключений.</summary>
		/// <param name="exceptions">Коллекция исключений для привязки к данному объекту <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">Элемент <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="exceptions" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="exceptions" /> включает один или несколько элементов со значением null.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовый элемент <see cref="T:System.Threading.Tasks.Task`1" /> уже находится в одном из трех конечных состояний: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> или <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x06002177 RID: 8567 RVA: 0x00078640 File Offset: 0x00076840
		public void SetException(IEnumerable<Exception> exceptions)
		{
			if (!this.TrySetException(exceptions))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		/// <summary>Пытается перевести базовый объект <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />.</summary>
		/// <param name="result">Итоговое значение для привязки к данному <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <returns>Значение true, если операция выполнена успешно; в противном случае — значение false.</returns>
		// Token: 0x06002178 RID: 8568 RVA: 0x00078652 File Offset: 0x00076852
		public bool TrySetResult(TResult result)
		{
			bool flag = this._task.TrySetResult(result);
			if (!flag)
			{
				this.SpinUntilCompleted();
			}
			return flag;
		}

		/// <summary>Переводит базовый объект <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />.</summary>
		/// <param name="result">Итоговое значение для привязки к данному <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">Элемент <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовый элемент <see cref="T:System.Threading.Tasks.Task`1" /> уже находится в одном из трех конечных состояний: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> или <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x06002179 RID: 8569 RVA: 0x00078669 File Offset: 0x00076869
		public void SetResult(TResult result)
		{
			if (!this.TrySetResult(result))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		/// <summary>Пытается перевести базовый объект <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</summary>
		/// <returns>Значение true, если операция завершилась успешно; значение false, если не удалось завершить операцию или объект уже был удален.</returns>
		// Token: 0x0600217A RID: 8570 RVA: 0x0007867C File Offset: 0x0007687C
		public bool TrySetCanceled()
		{
			return this.TrySetCanceled(default(CancellationToken));
		}

		/// <summary>Пытается перевести базовый объект <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" /> и позволяет хранить токен отмены в задаче отмены.</summary>
		/// <param name="cancellationToken">Токен отмены.</param>
		/// <returns>Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600217B RID: 8571 RVA: 0x00078698 File Offset: 0x00076898
		public bool TrySetCanceled(CancellationToken cancellationToken)
		{
			bool flag = this._task.TrySetCanceled(cancellationToken);
			if (!flag && !this._task.IsCompleted)
			{
				this.SpinUntilCompleted();
			}
			return flag;
		}

		/// <summary>Переводит базовый объект <see cref="T:System.Threading.Tasks.Task`1" /> в состояние <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Базовая <see cref="T:System.Threading.Tasks.Task`1" /> уже находится в одном из трех конечных состояний: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />,  <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> или <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />, если базовая <see cref="T:System.Threading.Tasks.Task`1" /> уже была удалена.</exception>
		// Token: 0x0600217C RID: 8572 RVA: 0x000786BC File Offset: 0x000768BC
		public void SetCanceled()
		{
			if (!this.TrySetCanceled())
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted);
			}
		}

		// Token: 0x04001BC8 RID: 7112
		private readonly Task<TResult> _task;
	}
}
