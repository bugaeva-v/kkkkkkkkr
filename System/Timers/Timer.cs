using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Permissions;
using System.Threading;

namespace System.Timers
{
	/// <summary>Создает событие после заданного интервала с возможностью создания повторяющихся событий.</summary>
	// Token: 0x02000193 RID: 403
	[DefaultProperty("Interval")]
	[DefaultEvent("Elapsed")]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public class Timer : Component, ISupportInitialize
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Timers.Timer" /> и задает всем свойствам начальные значения.</summary>
		// Token: 0x06000A8A RID: 2698 RVA: 0x0002D760 File Offset: 0x0002B960
		public Timer()
		{
			this.interval = 100.0;
			this.enabled = false;
			this.autoReset = true;
			this.initializing = false;
			this.delayedEnable = false;
			this.callback = new TimerCallback(this.MyTimerCallback);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Timers.Timer" /> и задает свойству <see cref="P:System.Timers.Timer.Interval" /> указанное значение в миллисекундах.</summary>
		/// <param name="interval">Время между событиями в миллисекундах. Значение должно быть больше нуля и меньше или равно <see cref="F:System.Int32.MaxValue" />.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="interval" /> меньше или равно нулю, или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06000A8B RID: 2699 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		public Timer(double interval) : this()
		{
			if (interval <= 0.0)
			{
				throw new ArgumentException(SR.GetString("Invalid value '{1}' for parameter '{0}'.", new object[]
				{
					"interval",
					interval
				}));
			}
			this.interval = (double)Timer.CalculateRoundedInterval(interval, true);
		}

		/// <summary>Возвращает или задает логическое значение, определяющее, должен ли объект <see cref="T:System.Timers.Timer" /> вызывать событие <see cref="E:System.Timers.Timer.Elapsed" /> один раз (<see langword="false" />) или неоднократно (<see langword="true" />).</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Timers.Timer" /> должен вызывать событие <see cref="E:System.Timers.Timer.Elapsed" /> каждый раз по истечении интервала времени; <see langword="false" />, если событие <see cref="E:System.Timers.Timer.Elapsed" /> следует вызвать только один раз, когда пройдет указанное время. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002D804 File Offset: 0x0002BA04
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0002D80C File Offset: 0x0002BA0C
		[TimersDescription("Indicates whether the timer will be restarted when it is enabled.")]
		[Category("Behavior")]
		[DefaultValue(true)]
		public bool AutoReset
		{
			get
			{
				return this.autoReset;
			}
			set
			{
				if (base.DesignMode)
				{
					this.autoReset = value;
					return;
				}
				if (this.autoReset != value)
				{
					this.autoReset = value;
					if (this.timer != null)
					{
						this.UpdateTimer();
					}
				}
			}
		}

		/// <summary>Возвращает или задает значение, определяющее, должен ли объект <see cref="T:System.Timers.Timer" /> вызывать событие <see cref="E:System.Timers.Timer.Elapsed" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Timers.Timer" /> должен вызывать событие <see cref="E:System.Timers.Timer.Elapsed" />; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Данное свойство задать нельзя, так как таймер удален.</exception>
		/// <exception cref="T:System.ArgumentException">Перед включением таймера свойству <see cref="P:System.Timers.Timer.Interval" /> задано значение больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0002D83C File Offset: 0x0002BA3C
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0002D844 File Offset: 0x0002BA44
		[DefaultValue(false)]
		[Category("Behavior")]
		[TimersDescription("Indicates whether the timer is enabled to fire events at a defined interval.")]
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				if (base.DesignMode)
				{
					this.delayedEnable = value;
					this.enabled = value;
					return;
				}
				if (this.initializing)
				{
					this.delayedEnable = value;
					return;
				}
				if (this.enabled != value)
				{
					if (!value)
					{
						if (this.timer != null)
						{
							this.cookie = null;
							this.timer.Dispose();
							this.timer = null;
						}
						this.enabled = value;
						return;
					}
					this.enabled = value;
					if (this.timer == null)
					{
						if (this.disposed)
						{
							throw new ObjectDisposedException(base.GetType().Name);
						}
						int num = Timer.CalculateRoundedInterval(this.interval, false);
						this.cookie = new object();
						this.timer = new Timer(this.callback, this.cookie, num, this.autoReset ? num : -1);
						return;
					}
					else
					{
						this.UpdateTimer();
					}
				}
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0002D91C File Offset: 0x0002BB1C
		private static int CalculateRoundedInterval(double interval, bool argumentCheck = false)
		{
			double num = Math.Ceiling(interval);
			if (num <= 2147483647.0 && num > 0.0)
			{
				return (int)num;
			}
			if (argumentCheck)
			{
				throw new ArgumentException(SR.GetString("Invalid value '{1}' for parameter '{0}'.", new object[]
				{
					"interval",
					interval
				}));
			}
			throw new ArgumentOutOfRangeException(SR.GetString("Invalid value '{1}' for parameter '{0}'.", new object[]
			{
				"interval",
				interval
			}));
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0002D99C File Offset: 0x0002BB9C
		private void UpdateTimer()
		{
			int num = Timer.CalculateRoundedInterval(this.interval, false);
			this.timer.Change(num, this.autoReset ? num : -1);
		}

		/// <summary>Возвращает или задает интервал в миллисекундах, по истечении которого возникает событие <see cref="E:System.Timers.Timer.Elapsed" />.</summary>
		/// <returns>Время между событиями <see cref="E:System.Timers.Timer.Elapsed" /> в миллисекундах. Значение должно быть больше нуля и меньше или равно <see cref="F:System.Int32.MaxValue" />. Значение по умолчанию — 100 миллисекунд.</returns>
		/// <exception cref="T:System.ArgumentException">Интервал меньше или равен нулю.  
		///
		/// или - 
		/// Интервал больше, чем <see cref="F:System.Int32.MaxValue" />, а таймер в настоящий момент включен. (Если таймер в данный момент выключен, исключение не генерируется до его включения.)</exception>
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002D9CF File Offset: 0x0002BBCF
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
		[Category("Behavior")]
		[TimersDescription("The number of milliseconds between timer events.")]
		[DefaultValue(100.0)]
		[SettingsBindable(true)]
		public double Interval
		{
			get
			{
				return this.interval;
			}
			set
			{
				if (value <= 0.0)
				{
					throw new ArgumentException(SR.GetString("'{0}' is not a valid value for 'Interval'. 'Interval' must be greater than {1}.", new object[]
					{
						value,
						0
					}));
				}
				this.interval = value;
				if (this.timer != null)
				{
					this.UpdateTimer();
				}
			}
		}

		/// <summary>Происходит по истечении интервала времени.</summary>
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000A94 RID: 2708 RVA: 0x0002DA2E File Offset: 0x0002BC2E
		// (remove) Token: 0x06000A95 RID: 2709 RVA: 0x0002DA47 File Offset: 0x0002BC47
		[TimersDescription("Occurs when the Interval has elapsed.")]
		[Category("Behavior")]
		public event ElapsedEventHandler Elapsed
		{
			add
			{
				this.onIntervalElapsed = (ElapsedEventHandler)Delegate.Combine(this.onIntervalElapsed, value);
			}
			remove
			{
				this.onIntervalElapsed = (ElapsedEventHandler)Delegate.Remove(this.onIntervalElapsed, value);
			}
		}

		/// <summary>Возвращает или задает сайт, который привязывает <see cref="T:System.Timers.Timer" /> к его контейнеру в режиме конструктора.</summary>
		/// <returns>Интерфейс <see cref="T:System.ComponentModel.ISite" />, представляющий сайт, который привязывает объект <see cref="T:System.Timers.Timer" /> к его контейнеру.</returns>
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0002DA78 File Offset: 0x0002BC78
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0002DA60 File Offset: 0x0002BC60
		public override ISite Site
		{
			get
			{
				return base.Site;
			}
			set
			{
				base.Site = value;
				if (base.DesignMode)
				{
					this.enabled = true;
				}
			}
		}

		/// <summary>Получает или задает объект, используемый для маршалирования вызовов обработчика событий, осуществленных после истечения интервала времени.</summary>
		/// <returns>
		///   <see cref="T:System.ComponentModel.ISynchronizeInvoke" />, представляющий объект, используемый для маршалинга вызовов обработчика событий, осуществленных после истечения интервала времени. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0002DA80 File Offset: 0x0002BC80
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0002DADA File Offset: 0x0002BCDA
		[Browsable(false)]
		[DefaultValue(null)]
		[TimersDescription("The object used to marshal the event handler calls issued when an interval has elapsed.")]
		public ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				if (this.synchronizingObject == null && base.DesignMode)
				{
					IDesignerHost designerHost = (IDesignerHost)this.GetService(typeof(IDesignerHost));
					if (designerHost != null)
					{
						object rootComponent = designerHost.RootComponent;
						if (rootComponent != null && rootComponent is ISynchronizeInvoke)
						{
							this.synchronizingObject = (ISynchronizeInvoke)rootComponent;
						}
					}
				}
				return this.synchronizingObject;
			}
			set
			{
				this.synchronizingObject = value;
			}
		}

		/// <summary>Начинает во время выполнения инициализацию класса <see cref="T:System.Timers.Timer" />, используемого в форме или другим компонентом.</summary>
		// Token: 0x06000A9A RID: 2714 RVA: 0x0002DAE3 File Offset: 0x0002BCE3
		public void BeginInit()
		{
			this.Close();
			this.initializing = true;
		}

		/// <summary>Освобождает ресурсы, используемые объектом <see cref="T:System.Timers.Timer" />.</summary>
		// Token: 0x06000A9B RID: 2715 RVA: 0x0002DAF2 File Offset: 0x0002BCF2
		public void Close()
		{
			this.initializing = false;
			this.delayedEnable = false;
			this.enabled = false;
			if (this.timer != null)
			{
				this.timer.Dispose();
				this.timer = null;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим объектом <see cref="T:System.Timers.Timer" />.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06000A9C RID: 2716 RVA: 0x0002DB23 File Offset: 0x0002BD23
		protected override void Dispose(bool disposing)
		{
			this.Close();
			this.disposed = true;
			base.Dispose(disposing);
		}

		/// <summary>Заканчивает во время выполнения инициализацию класса <see cref="T:System.Timers.Timer" />, используемого в форме или другим компонентом.</summary>
		// Token: 0x06000A9D RID: 2717 RVA: 0x0002DB39 File Offset: 0x0002BD39
		public void EndInit()
		{
			this.initializing = false;
			this.Enabled = this.delayedEnable;
		}

		/// <summary>Начинает вызывать событие <see cref="E:System.Timers.Timer.Elapsed" />, задавая для свойства <see cref="P:System.Timers.Timer.Enabled" /> значение <see langword="true" />.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <see cref="T:System.Timers.Timer" /> создается с интервалом не меньше <see cref="F:System.Int32.MaxValue" />+1, либо задается интервал меньше нуля.</exception>
		// Token: 0x06000A9E RID: 2718 RVA: 0x0002DB4E File Offset: 0x0002BD4E
		public void Start()
		{
			this.Enabled = true;
		}

		/// <summary>Прекращает вызывать событие <see cref="E:System.Timers.Timer.Elapsed" />, задавая для свойства <see cref="P:System.Timers.Timer.Enabled" /> значение <see langword="false" />.</summary>
		// Token: 0x06000A9F RID: 2719 RVA: 0x0002DB57 File Offset: 0x0002BD57
		public void Stop()
		{
			this.Enabled = false;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002DB60 File Offset: 0x0002BD60
		private void MyTimerCallback(object state)
		{
			if (state != this.cookie)
			{
				return;
			}
			if (!this.autoReset)
			{
				this.enabled = false;
			}
			ElapsedEventArgs elapsedEventArgs = new ElapsedEventArgs(DateTime.Now);
			try
			{
				ElapsedEventHandler elapsedEventHandler = this.onIntervalElapsed;
				if (elapsedEventHandler != null)
				{
					if (this.SynchronizingObject != null && this.SynchronizingObject.InvokeRequired)
					{
						this.SynchronizingObject.BeginInvoke(elapsedEventHandler, new object[]
						{
							this,
							elapsedEventArgs
						});
					}
					else
					{
						elapsedEventHandler(this, elapsedEventArgs);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000715 RID: 1813
		private double interval;

		// Token: 0x04000716 RID: 1814
		private bool enabled;

		// Token: 0x04000717 RID: 1815
		private bool initializing;

		// Token: 0x04000718 RID: 1816
		private bool delayedEnable;

		// Token: 0x04000719 RID: 1817
		private ElapsedEventHandler onIntervalElapsed;

		// Token: 0x0400071A RID: 1818
		private bool autoReset;

		// Token: 0x0400071B RID: 1819
		private ISynchronizeInvoke synchronizingObject;

		// Token: 0x0400071C RID: 1820
		private bool disposed;

		// Token: 0x0400071D RID: 1821
		private Timer timer;

		// Token: 0x0400071E RID: 1822
		private TimerCallback callback;

		// Token: 0x0400071F RID: 1823
		private object cookie;
	}
}
