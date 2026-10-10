using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Реализует домен синхронизации для текущего контекста и всех контекстов, совместно использующих один экземпляр.</summary>
	// Token: 0x0200059E RID: 1438
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Class)]
	[Serializable]
	public class SynchronizationAttribute : ContextAttribute, IContributeClientContextSink, IContributeServerContextSink
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> со значениями по умолчанию.</summary>
		// Token: 0x060037E1 RID: 14305 RVA: 0x000C8D40 File Offset: 0x000C6F40
		public SynchronizationAttribute() : this(8, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> с использованием логического значения, указывающего, требуется ли повторный вход.</summary>
		/// <param name="reEntrant">Логическое значение, указывающее, требуется ли повторный вход.</param>
		// Token: 0x060037E2 RID: 14306 RVA: 0x000C8D4A File Offset: 0x000C6F4A
		public SynchronizationAttribute(bool reEntrant) : this(8, reEntrant)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> с использованием флага, задающего поведение объекта, к которому применяется атрибут.</summary>
		/// <param name="flag">Целое значение, задающее поведение объекта, к которому применяется атрибут.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="flag" /> не является одним из определенных флагов.</exception>
		// Token: 0x060037E3 RID: 14307 RVA: 0x000C8D54 File Offset: 0x000C6F54
		public SynchronizationAttribute(int flag) : this(flag, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> с использованием флага, задающего поведение объекта, к которому применяется атрибут, и логического значения, указывающего на то, требуется ли повторный вход.</summary>
		/// <param name="flag">Целое значение, задающее поведение объекта, к которому применяется атрибут.</param>
		/// <param name="reEntrant">Имеет значение <see langword="true" />, если требуется повторный вход, а внешние вызовы должны перехватываться и упорядочиваться; иначе — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="flag" /> не является одним из определенных флагов.</exception>
		// Token: 0x060037E4 RID: 14308 RVA: 0x000C8D60 File Offset: 0x000C6F60
		public SynchronizationAttribute(int flag, bool reEntrant) : base("Synchronization")
		{
			if (flag != 1 && flag != 4 && flag != 8 && flag != 2)
			{
				throw new ArgumentException("flag");
			}
			this._bReEntrant = reEntrant;
			this._flavor = flag;
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, требуется ли повторный ввод.</summary>
		/// <returns>Логическое значение, указывающее, требуется ли повторный вход.</returns>
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060037E5 RID: 14309 RVA: 0x000C8DAD File Offset: 0x000C6FAD
		public virtual bool IsReEntrant
		{
			get
			{
				return this._bReEntrant;
			}
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, заблокирован ли <see cref="T:System.Runtime.Remoting.Contexts.Context" />, реализующий экземпляр атрибута <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> .</summary>
		/// <returns>Логическое значение, указывающее, заблокирован ли контекст <see cref="T:System.Runtime.Remoting.Contexts.Context" />, реализующий данный экземпляр атрибута <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" />.</returns>
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x000C8DB5 File Offset: 0x000C6FB5
		// (set) Token: 0x060037E7 RID: 14311 RVA: 0x000C8DC0 File Offset: 0x000C6FC0
		public virtual bool Locked
		{
			get
			{
				return this._lockCount > 0;
			}
			set
			{
				SynchronizationAttribute obj;
				if (value)
				{
					this.AcquireLock();
					obj = this;
					lock (obj)
					{
						if (this._lockCount > 1)
						{
							this.ReleaseLock();
						}
						return;
					}
				}
				obj = this;
				lock (obj)
				{
					while (this._lockCount > 0 && this._ownerThread == Thread.CurrentThread)
					{
						this.ReleaseLock();
					}
				}
			}
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x000C8E50 File Offset: 0x000C7050
		internal void AcquireLock()
		{
			this._mutex.WaitOne();
			lock (this)
			{
				this._ownerThread = Thread.CurrentThread;
				this._lockCount++;
			}
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x000C8EAC File Offset: 0x000C70AC
		internal void ReleaseLock()
		{
			lock (this)
			{
				if (this._lockCount > 0 && this._ownerThread == Thread.CurrentThread)
				{
					this._lockCount--;
					this._mutex.ReleaseMutex();
					if (this._lockCount == 0)
					{
						this._ownerThread = null;
					}
				}
			}
		}

		/// <summary>Добавляет контекстное свойство <see langword="Synchronized" /> в указанное сообщение <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> .</summary>
		/// <param name="ctorMsg">Сообщение <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />, к которому добавляется свойство.</param>
		// Token: 0x060037EA RID: 14314 RVA: 0x000C8F20 File Offset: 0x000C7120
		[SecurityCritical]
		[ComVisible(true)]
		public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
		{
			if (this._flavor != 1)
			{
				ctorMsg.ContextProperties.Add(this);
			}
		}

		/// <summary>Создает приемник внешних вызовов и добавляет его в качестве первого звена к предоставленной цепочке приемников на контекстной границе на клиентской стороне вызова удаленного взаимодействия.</summary>
		/// <param name="nextSink">Сформированная на данный момент цепочка приемников.</param>
		/// <returns>Составная цепочка приемников с новым приемников внешних вызовов.</returns>
		// Token: 0x060037EB RID: 14315 RVA: 0x000C8F38 File Offset: 0x000C7138
		[SecurityCritical]
		public virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
		{
			return new SynchronizedClientContextSink(nextSink, this);
		}

		/// <summary>Создает синхронизированный диспетчерский приемник и добавляет его в качестве первого звена к предоставленной цепочке приемников на границе контекста на серверной стороне вызова удаленного взаимодействия.</summary>
		/// <param name="nextSink">Сформированная на данный момент цепочка приемников.</param>
		/// <returns>Составная цепочка приемников с новым синхронизированным диспетчерским приемником.</returns>
		// Token: 0x060037EC RID: 14316 RVA: 0x000C8F41 File Offset: 0x000C7141
		[SecurityCritical]
		public virtual IMessageSink GetServerContextSink(IMessageSink nextSink)
		{
			return new SynchronizedServerContextSink(nextSink, this);
		}

		/// <summary>Возвращает логическое значение, указывающее, удовлетворяет ли параметр контекста требованиям атрибута контекста.</summary>
		/// <param name="ctx">Проверяемый контекст.</param>
		/// <param name="msg">Информация, собранная во время создания контекстно-связанного объекта, отмеченного этим атрибутом. Атрибут <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> может проверять, добавлять и удалять свойства из контекста, определяя приемлемость контекста для них.</param>
		/// <returns>Принимает значение <see langword="true" />, если заданный контекст приемлем, иначе —  <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="ctx" /> или параметра <paramref name="msg" /> — <see langword="null" />.</exception>
		// Token: 0x060037ED RID: 14317 RVA: 0x000C8F4C File Offset: 0x000C714C
		[SecurityCritical]
		[ComVisible(true)]
		public override bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			SynchronizationAttribute synchronizationAttribute = ctx.GetProperty("Synchronization") as SynchronizationAttribute;
			int flavor = this._flavor;
			switch (flavor)
			{
			case 1:
				return synchronizationAttribute == null;
			case 2:
				return true;
			case 3:
				break;
			case 4:
				return synchronizationAttribute != null;
			default:
				if (flavor == 8)
				{
					return false;
				}
				break;
			}
			return false;
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x000C8FA0 File Offset: 0x000C71A0
		internal static void ExitContext()
		{
			if (Thread.CurrentContext.IsDefaultContext)
			{
				return;
			}
			SynchronizationAttribute synchronizationAttribute = Thread.CurrentContext.GetProperty("Synchronization") as SynchronizationAttribute;
			if (synchronizationAttribute == null)
			{
				return;
			}
			synchronizationAttribute.Locked = false;
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x000C8FDC File Offset: 0x000C71DC
		internal static void EnterContext()
		{
			if (Thread.CurrentContext.IsDefaultContext)
			{
				return;
			}
			SynchronizationAttribute synchronizationAttribute = Thread.CurrentContext.GetProperty("Synchronization") as SynchronizationAttribute;
			if (synchronizationAttribute == null)
			{
				return;
			}
			synchronizationAttribute.Locked = true;
		}

		/// <summary>Указывает, что класс, к которому применяется этот атрибут, не может быть создан в контексте, имеющем синхронизацию. Это поле является константой.</summary>
		// Token: 0x040025B7 RID: 9655
		public const int NOT_SUPPORTED = 1;

		/// <summary>Указывает, что класс, к которому применяется этот атрибут, не зависит от того, имеет ли контекст синхронизацию. Это поле является константой.</summary>
		// Token: 0x040025B8 RID: 9656
		public const int SUPPORTED = 2;

		/// <summary>Указывает, что класс, к которому применяется этот атрибут, должен создаваться в контексте, имеющем синхронизацию. Это поле является константой.</summary>
		// Token: 0x040025B9 RID: 9657
		public const int REQUIRED = 4;

		/// <summary>Указывает, что класс, к которому применяется этот атрибут, должен создаваться каждый раз в контексте с новым экземпляром свойства синхронизации. Это поле является константой.</summary>
		// Token: 0x040025BA RID: 9658
		public const int REQUIRES_NEW = 8;

		// Token: 0x040025BB RID: 9659
		private bool _bReEntrant;

		// Token: 0x040025BC RID: 9660
		private int _flavor;

		// Token: 0x040025BD RID: 9661
		[NonSerialized]
		private int _lockCount;

		// Token: 0x040025BE RID: 9662
		[NonSerialized]
		private Mutex _mutex = new Mutex(false);

		// Token: 0x040025BF RID: 9663
		[NonSerialized]
		private Thread _ownerThread;
	}
}
