using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	/// <summary>Распространяет уведомление о том, что операции следует отменить.</summary>
	// Token: 0x0200029E RID: 670
	[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
	public readonly struct CancellationToken
	{
		/// <summary>Возвращает пустое значение <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <returns>Пустой токен отмены.</returns>
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0006EB4C File Offset: 0x0006CD4C
		public static CancellationToken None
		{
			get
			{
				return default(CancellationToken);
			}
		}

		/// <summary>Возвращает значение, указывающее, есть ли для данного токена запрос на отмену.</summary>
		/// <returns>Значение <see langword="true" />, если для данного токена есть запрос на отмену; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0006EB62 File Offset: 0x0006CD62
		public bool IsCancellationRequested
		{
			get
			{
				return this._source != null && this._source.IsCancellationRequested;
			}
		}

		/// <summary>Возвращает значение, указывающее, может ли данный токен находиться в отмененном состоянии.</summary>
		/// <returns>Значение <see langword="true" />, если данный токен может быть в отмененном состоянии; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0006EB79 File Offset: 0x0006CD79
		public bool CanBeCanceled
		{
			get
			{
				return this._source != null;
			}
		}

		/// <summary>Возвращает дескриптор <see cref="T:System.Threading.WaitHandle" />, получающий сигнал при отмене токена.</summary>
		/// <returns>Дескриптор <see cref="T:System.Threading.WaitHandle" />, получающий сигнал при отмене токена.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> удален.</exception>
		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0006EB84 File Offset: 0x0006CD84
		public WaitHandle WaitHandle
		{
			get
			{
				return (this._source ?? CancellationTokenSource.s_neverCanceledSource).WaitHandle;
			}
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0006EB9A File Offset: 0x0006CD9A
		internal CancellationToken(CancellationTokenSource source)
		{
			this._source = source;
		}

		/// <summary>Инициализирует объект <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="canceled">Состояние отмены для токена.</param>
		// Token: 0x06001DC6 RID: 7622 RVA: 0x0006EBA3 File Offset: 0x0006CDA3
		public CancellationToken(bool canceled)
		{
			this = new CancellationToken(canceled ? CancellationTokenSource.s_canceledSource : null);
		}

		/// <summary>Регистрирует делегат, который будет вызываться при отмене данного токена <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="callback">Делегат, выполняемый при отмене токена <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <returns>Экземпляр <see cref="T:System.Threading.CancellationTokenRegistration" />, который можно использовать для отмены регистрации обратного вызова.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="callback" /> имеет значение null.</exception>
		// Token: 0x06001DC7 RID: 7623 RVA: 0x0006EBB6 File Offset: 0x0006CDB6
		public CancellationTokenRegistration Register(Action callback)
		{
			Action<object> callback2 = CancellationToken.s_actionToActionObjShunt;
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			return this.Register(callback2, callback, false, true);
		}

		/// <summary>Регистрирует делегат, который будет вызываться при отмене данного токена <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="callback">Делегат, выполняемый при отмене токена <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <param name="useSynchronizationContext">Значение, указывающее, следует ли записывать текущий объект <see cref="T:System.Threading.SynchronizationContext" /> и использовать его при вызове <paramref name="callback" />.</param>
		/// <returns>Экземпляр <see cref="T:System.Threading.CancellationTokenRegistration" />, который можно использовать для отмены регистрации обратного вызова.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="callback" /> имеет значение null.</exception>
		// Token: 0x06001DC8 RID: 7624 RVA: 0x0006EBD5 File Offset: 0x0006CDD5
		public CancellationTokenRegistration Register(Action callback, bool useSynchronizationContext)
		{
			Action<object> callback2 = CancellationToken.s_actionToActionObjShunt;
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			return this.Register(callback2, callback, useSynchronizationContext, true);
		}

		/// <summary>Регистрирует делегат, который будет вызываться при отмене данного токена <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="callback">Делегат, выполняемый при отмене токена <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <param name="state">Состояние, передаваемое обратному вызову <paramref name="callback" /> при вызове делегата. Может содержать пустое значение.</param>
		/// <returns>Экземпляр <see cref="T:System.Threading.CancellationTokenRegistration" />, который можно использовать для отмены регистрации обратного вызова.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="callback" /> имеет значение null.</exception>
		// Token: 0x06001DC9 RID: 7625 RVA: 0x0006EBF4 File Offset: 0x0006CDF4
		public CancellationTokenRegistration Register(Action<object> callback, object state)
		{
			return this.Register(callback, state, false, true);
		}

		/// <summary>Регистрирует делегат, который будет вызываться при отмене данного токена <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="callback">Делегат, выполняемый при отмене токена <see cref="T:System.Threading.CancellationToken" />.</param>
		/// <param name="state">Состояние, передаваемое обратному вызову <paramref name="callback" /> при вызове делегата. Может содержать пустое значение.</param>
		/// <param name="useSynchronizationContext">Логическое значение, указывающее, следует ли записывать текущий объект <see cref="T:System.Threading.SynchronizationContext" /> и использовать его при вызове <paramref name="callback" />.</param>
		/// <returns>Экземпляр <see cref="T:System.Threading.CancellationTokenRegistration" />, который можно использовать для отмены регистрации обратного вызова.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="callback" /> имеет значение null.</exception>
		// Token: 0x06001DCA RID: 7626 RVA: 0x0006EC00 File Offset: 0x0006CE00
		public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext)
		{
			return this.Register(callback, state, useSynchronizationContext, true);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0006EC0C File Offset: 0x0006CE0C
		internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state)
		{
			return this.Register(callback, state, false, false);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0006EC18 File Offset: 0x0006CE18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			CancellationTokenSource source = this._source;
			if (source == null)
			{
				return default(CancellationTokenRegistration);
			}
			return source.InternalRegister(callback, state, useSynchronizationContext ? SynchronizationContext.Current : null, useExecutionContext ? ExecutionContext.Capture() : null);
		}

		/// <summary>Определяет, равен ли текущий экземпляр <see cref="T:System.Threading.CancellationToken" /> заданному токену.</summary>
		/// <param name="other">Другой объект <see cref="T:System.Threading.CancellationToken" /> для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если экземпляры равны; в противном случае — <see langword="false" />. Дополнительные сведения см. в разделе "Примечания".</returns>
		// Token: 0x06001DCD RID: 7629 RVA: 0x0006EC66 File Offset: 0x0006CE66
		public bool Equals(CancellationToken other)
		{
			return this._source == other._source;
		}

		/// <summary>Определяет, равен ли текущий экземпляр <see cref="T:System.Threading.CancellationToken" /> заданному объекту <see cref="T:System.Object" />.</summary>
		/// <param name="other">Другой объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр является <paramref name="other" /> имеет значение <see cref="T:System.Threading.CancellationToken" />, и если два эти экземпляра равны; в противном случае — значение <see langword="false" />. Дополнительные сведения см. в разделе "Примечания".</returns>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> был удален.</exception>
		// Token: 0x06001DCE RID: 7630 RVA: 0x0006EC76 File Offset: 0x0006CE76
		public override bool Equals(object other)
		{
			return other is CancellationToken && this.Equals((CancellationToken)other);
		}

		/// <summary>Служит хэш-функцией для <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра <see cref="T:System.Threading.CancellationToken" />.</returns>
		// Token: 0x06001DCF RID: 7631 RVA: 0x0006EC8E File Offset: 0x0006CE8E
		public override int GetHashCode()
		{
			return (this._source ?? CancellationTokenSource.s_neverCanceledSource).GetHashCode();
		}

		/// <summary>Определяет, равны ли два экземпляра <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="left">Первый экземпляр.</param>
		/// <param name="right">Второй экземпляр.</param>
		/// <returns>
		///   <see langword="true" />, если экземпляры равны, в противном случае <see langword="false" />. Дополнительную информацию см. в разделе "Примечания".</returns>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> был удален.</exception>
		// Token: 0x06001DD0 RID: 7632 RVA: 0x0006ECA4 File Offset: 0x0006CEA4
		public static bool operator ==(CancellationToken left, CancellationToken right)
		{
			return left.Equals(right);
		}

		/// <summary>Определяет, действительно ли два экземпляра <see cref="T:System.Threading.CancellationToken" /> не равны.</summary>
		/// <param name="left">Первый экземпляр.</param>
		/// <param name="right">Второй экземпляр.</param>
		/// <returns>Значение <see langword="true" />, если эти экземпляры не равны; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> был удален.</exception>
		// Token: 0x06001DD1 RID: 7633 RVA: 0x0006ECAE File Offset: 0x0006CEAE
		public static bool operator !=(CancellationToken left, CancellationToken right)
		{
			return !left.Equals(right);
		}

		/// <summary>Создает исключение <see cref="T:System.OperationCanceledException" />, если для данного токена есть запрос на отмену.</summary>
		/// <exception cref="T:System.OperationCanceledException">Этот токен имел запрос на отмену.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Связанный объект <see cref="T:System.Threading.CancellationTokenSource" /> удален.</exception>
		// Token: 0x06001DD2 RID: 7634 RVA: 0x0006ECBB File Offset: 0x0006CEBB
		public void ThrowIfCancellationRequested()
		{
			if (this.IsCancellationRequested)
			{
				this.ThrowOperationCanceledException();
			}
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0006ECCB File Offset: 0x0006CECB
		private void ThrowOperationCanceledException()
		{
			throw new OperationCanceledException("The operation was canceled.", this);
		}

		// Token: 0x04001A56 RID: 6742
		private readonly CancellationTokenSource _source;

		// Token: 0x04001A57 RID: 6743
		private static readonly Action<object> s_actionToActionObjShunt = delegate(object obj)
		{
			((Action)obj)();
		};
	}
}
