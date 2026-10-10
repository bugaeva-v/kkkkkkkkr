using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Permissions;

namespace System.Threading
{
	/// <summary>Обеспечивает базовую функциональность для распространения контекста синхронизации в различных моделях синхронизации.</summary>
	// Token: 0x020002D1 RID: 721
	[SecurityPermission(SecurityAction.InheritanceDemand, Flags = (SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy))]
	public class SynchronizationContext
	{
		/// <summary>Задает уведомление о требовании уведомления об ожидании и подготавливает метод обратного вызова. Таким образом, метод может быть вызван более надежным способом, когда происходит ожидание.</summary>
		// Token: 0x06001F46 RID: 8006 RVA: 0x000739B4 File Offset: 0x00071BB4
		[SecuritySafeCritical]
		protected void SetWaitNotificationRequired()
		{
			Type type = base.GetType();
			if (SynchronizationContext.s_cachedPreparedType1 != type && SynchronizationContext.s_cachedPreparedType2 != type && SynchronizationContext.s_cachedPreparedType3 != type && SynchronizationContext.s_cachedPreparedType4 != type && SynchronizationContext.s_cachedPreparedType5 != type)
			{
				RuntimeHelpers.PrepareDelegate(new SynchronizationContext.WaitDelegate(this.Wait));
				if (SynchronizationContext.s_cachedPreparedType1 == null)
				{
					SynchronizationContext.s_cachedPreparedType1 = type;
				}
				else if (SynchronizationContext.s_cachedPreparedType2 == null)
				{
					SynchronizationContext.s_cachedPreparedType2 = type;
				}
				else if (SynchronizationContext.s_cachedPreparedType3 == null)
				{
					SynchronizationContext.s_cachedPreparedType3 = type;
				}
				else if (SynchronizationContext.s_cachedPreparedType4 == null)
				{
					SynchronizationContext.s_cachedPreparedType4 = type;
				}
				else if (SynchronizationContext.s_cachedPreparedType5 == null)
				{
					SynchronizationContext.s_cachedPreparedType5 = type;
				}
			}
			this._props |= SynchronizationContextProperties.RequireWaitNotification;
		}

		/// <summary>Определяет, нужно ли уведомление об ожидании.</summary>
		/// <returns>Значение <see langword="true" />, если уведомление об ожидании требуется, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001F47 RID: 8007 RVA: 0x00073A9C File Offset: 0x00071C9C
		public bool IsWaitNotificationRequired()
		{
			return (this._props & SynchronizationContextProperties.RequireWaitNotification) > SynchronizationContextProperties.None;
		}

		/// <summary>При переопределении в производном классе отправляет синхронное сообщение в контекст синхронизации.</summary>
		/// <param name="d">Вызываемый делегат <see cref="T:System.Threading.SendOrPostCallback" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <exception cref="T:System.NotSupportedException">Метод был вызван в приложении для Магазина Windows. Реализация класса <see cref="T:System.Threading.SynchronizationContext" /> для приложений для Магазина Windows не поддерживает метод <see cref="M:System.Threading.SynchronizationContext.Send(System.Threading.SendOrPostCallback,System.Object)" />.</exception>
		// Token: 0x06001F48 RID: 8008 RVA: 0x00073AA9 File Offset: 0x00071CA9
		public virtual void Send(SendOrPostCallback d, object state)
		{
			d(state);
		}

		/// <summary>При переопределении в производном классе отправляет асинхронное сообщение в контекст синхронизации.</summary>
		/// <param name="d">Вызываемый делегат <see cref="T:System.Threading.SendOrPostCallback" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		// Token: 0x06001F49 RID: 8009 RVA: 0x00073AB2 File Offset: 0x00071CB2
		public virtual void Post(SendOrPostCallback d, object state)
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(d.Invoke), state);
		}

		/// <summary>При переопределении в производном классе отвечает на уведомление о запуске операции.</summary>
		// Token: 0x06001F4A RID: 8010 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public virtual void OperationStarted()
		{
		}

		/// <summary>При переопределении в производном классе отвечает на уведомление о завершении операции.</summary>
		// Token: 0x06001F4B RID: 8011 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public virtual void OperationCompleted()
		{
		}

		/// <summary>Ожидает получения сигнала всеми элементами заданного массива или любым из его элементов.</summary>
		/// <param name="waitHandles">Массив типа <see cref="T:System.IntPtr" />, содержащий собственные дескрипторы операционной системы.</param>
		/// <param name="waitAll">
		///   <see langword="true" /> для ожидания всех обработчиков; <see langword="false" /> для ожидания любого обработчика.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Индекс объекта, удовлетворившего операцию ожидания, в массиве.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение null.</exception>
		// Token: 0x06001F4C RID: 8012 RVA: 0x00073AC7 File Offset: 0x00071CC7
		[SecurityCritical]
		[CLSCompliant(false)]
		[PrePrepareMethod]
		public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			if (waitHandles == null)
			{
				throw new ArgumentNullException("waitHandles");
			}
			return SynchronizationContext.WaitHelper(waitHandles, waitAll, millisecondsTimeout);
		}

		/// <summary>Вспомогательная функция, ожидающая сигнала от всех или некоторых элементов заданного массива.</summary>
		/// <param name="waitHandles">Массив типа <see cref="T:System.IntPtr" />, содержащий собственные дескрипторы операционной системы.</param>
		/// <param name="waitAll">Значение <see langword="true" /> для ожидания всех дескрипторов; <see langword="false" /> для ожидания любого дескриптора.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Индекс объекта, удовлетворившего операцию ожидания, в массиве.</returns>
		// Token: 0x06001F4D RID: 8013 RVA: 0x00073AE0 File Offset: 0x00071CE0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityCritical]
		[CLSCompliant(false)]
		[PrePrepareMethod]
		protected unsafe static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			IntPtr* handles;
			if (waitHandles == null || waitHandles.Length == 0)
			{
				handles = null;
			}
			else
			{
				handles = &waitHandles[0];
			}
			return WaitHandle.Wait_internal(handles, waitHandles.Length, waitAll, millisecondsTimeout);
		}

		/// <summary>Задает текущий контекст синхронизации.</summary>
		/// <param name="syncContext">Задаваемый объект <see cref="T:System.Threading.SynchronizationContext" />.</param>
		// Token: 0x06001F4E RID: 8014 RVA: 0x00073B10 File Offset: 0x00071D10
		[SecurityCritical]
		public static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			mutableExecutionContext.SynchronizationContext = syncContext;
			mutableExecutionContext.SynchronizationContextNoFlow = syncContext;
		}

		/// <summary>Получает контекст синхронизации для текущего потока</summary>
		/// <returns>Объект <see cref="T:System.Threading.SynchronizationContext" />, представляющий текущий контекст синхронизации.</returns>
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00073B2C File Offset: 0x00071D2C
		public static SynchronizationContext Current
		{
			get
			{
				return Thread.CurrentThread.GetExecutionContextReader().SynchronizationContext ?? SynchronizationContext.GetThreadLocalContext();
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00073B54 File Offset: 0x00071D54
		internal static SynchronizationContext CurrentNoFlow
		{
			[FriendAccessAllowed]
			get
			{
				return Thread.CurrentThread.GetExecutionContextReader().SynchronizationContextNoFlow ?? SynchronizationContext.GetThreadLocalContext();
			}
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x0000AF5E File Offset: 0x0000915E
		private static SynchronizationContext GetThreadLocalContext()
		{
			return null;
		}

		/// <summary>При переопределении в производном классе создает копию контекста синхронизации.</summary>
		/// <returns>Новый объект <see cref="T:System.Threading.SynchronizationContext" />.</returns>
		// Token: 0x06001F52 RID: 8018 RVA: 0x00073B7C File Offset: 0x00071D7C
		public virtual SynchronizationContext CreateCopy()
		{
			return new SynchronizationContext();
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00073B83 File Offset: 0x00071D83
		[SecurityCritical]
		private static int InvokeWaitMethodHelper(SynchronizationContext syncContext, IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			return syncContext.Wait(waitHandles, waitAll, millisecondsTimeout);
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00073B8E File Offset: 0x00071D8E
		internal static SynchronizationContext CurrentExplicit
		{
			get
			{
				return SynchronizationContext.Current;
			}
		}

		// Token: 0x04001B0B RID: 6923
		private SynchronizationContextProperties _props;

		// Token: 0x04001B0C RID: 6924
		private static Type s_cachedPreparedType1;

		// Token: 0x04001B0D RID: 6925
		private static Type s_cachedPreparedType2;

		// Token: 0x04001B0E RID: 6926
		private static Type s_cachedPreparedType3;

		// Token: 0x04001B0F RID: 6927
		private static Type s_cachedPreparedType4;

		// Token: 0x04001B10 RID: 6928
		private static Type s_cachedPreparedType5;

		// Token: 0x020002D2 RID: 722
		// (Invoke) Token: 0x06001F56 RID: 8022
		private delegate int WaitDelegate(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout);
	}
}
