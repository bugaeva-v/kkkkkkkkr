using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Предоставляет набор методов и свойств, которые позволяют приложениям делать трассировку выполнения кода и связывать сообщения трассировки с их источником.</summary>
	// Token: 0x02000235 RID: 565
	public class TraceSource
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TraceSource" />, используя указанное имя источника.</summary>
		/// <param name="name">Имя источника (обычно — имя приложения).</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> является пустой строкой ("").</exception>
		// Token: 0x060010E4 RID: 4324 RVA: 0x000496FD File Offset: 0x000478FD
		public TraceSource(string name) : this(name, SourceLevels.Off)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TraceSource" />, используя заданное для источника имя и уровень источника по умолчанию, при котором происходит трассировка.</summary>
		/// <param name="name">Имя источника, обычно — имя приложения.</param>
		/// <param name="defaultLevel">Поразрядное сочетание значений перечисления, которое задает уровень источника по умолчанию, при котором должна выполняться трассировка.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> является пустой строкой ("").</exception>
		// Token: 0x060010E5 RID: 4325 RVA: 0x00049708 File Offset: 0x00047908
		public TraceSource(string name, SourceLevels defaultLevel)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("name");
			}
			this.sourceName = name;
			this.switchLevel = defaultLevel;
			List<WeakReference> obj = TraceSource.tracesources;
			lock (obj)
			{
				TraceSource._pruneCachedTraceSources();
				TraceSource.tracesources.Add(new WeakReference(this));
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00049790 File Offset: 0x00047990
		private static void _pruneCachedTraceSources()
		{
			List<WeakReference> obj = TraceSource.tracesources;
			lock (obj)
			{
				if (TraceSource.s_LastCollectionCount != GC.CollectionCount(2))
				{
					List<WeakReference> list = new List<WeakReference>(TraceSource.tracesources.Count);
					for (int i = 0; i < TraceSource.tracesources.Count; i++)
					{
						if ((TraceSource)TraceSource.tracesources[i].Target != null)
						{
							list.Add(TraceSource.tracesources[i]);
						}
					}
					if (list.Count < TraceSource.tracesources.Count)
					{
						TraceSource.tracesources.Clear();
						TraceSource.tracesources.AddRange(list);
						TraceSource.tracesources.TrimExcess();
					}
					TraceSource.s_LastCollectionCount = GC.CollectionCount(2);
				}
			}
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00049864 File Offset: 0x00047A64
		private void Initialize()
		{
			if (!this._initCalled)
			{
				lock (this)
				{
					if (!this._initCalled)
					{
						SourceElementsCollection sources = DiagnosticsConfiguration.Sources;
						if (sources != null)
						{
							SourceElement sourceElement = sources[this.sourceName];
							if (sourceElement != null)
							{
								if (!string.IsNullOrEmpty(sourceElement.SwitchName))
								{
									this.CreateSwitch(sourceElement.SwitchType, sourceElement.SwitchName);
								}
								else
								{
									this.CreateSwitch(sourceElement.SwitchType, this.sourceName);
									if (!string.IsNullOrEmpty(sourceElement.SwitchValue))
									{
										this.internalSwitch.Level = (SourceLevels)Enum.Parse(typeof(SourceLevels), sourceElement.SwitchValue);
									}
								}
								this.listeners = sourceElement.Listeners.GetRuntimeObject();
								this.attributes = new StringDictionary();
								TraceUtils.VerifyAttributes(sourceElement.Attributes, this.GetSupportedAttributes(), this);
								this.attributes.ReplaceHashtable(sourceElement.Attributes);
							}
							else
							{
								this.NoConfigInit();
							}
						}
						else
						{
							this.NoConfigInit();
						}
						this._initCalled = true;
					}
				}
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0004999C File Offset: 0x00047B9C
		private void NoConfigInit()
		{
			this.internalSwitch = new SourceSwitch(this.sourceName, this.switchLevel.ToString());
			this.listeners = new TraceListenerCollection();
			this.listeners.Add(new DefaultTraceListener());
			this.attributes = null;
		}

		/// <summary>Закрывает все прослушиватели трассировки в коллекции таких прослушивателей.</summary>
		// Token: 0x060010E9 RID: 4329 RVA: 0x000499F8 File Offset: 0x00047BF8
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public void Close()
		{
			if (this.listeners != null)
			{
				object critSec = TraceInternal.critSec;
				lock (critSec)
				{
					foreach (object obj in this.listeners)
					{
						((TraceListener)obj).Close();
					}
				}
			}
		}

		/// <summary>Записывает все прослушиватели трассировки в коллекции таких прослушивателей.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Предпринята попытка трассировки события в процессе завершения.</exception>
		// Token: 0x060010EA RID: 4330 RVA: 0x00049A80 File Offset: 0x00047C80
		public void Flush()
		{
			if (this.listeners != null)
			{
				if (TraceInternal.UseGlobalLock)
				{
					object critSec = TraceInternal.critSec;
					lock (critSec)
					{
						using (IEnumerator enumerator = this.listeners.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								((TraceListener)obj).Flush();
							}
							return;
						}
					}
				}
				foreach (object obj2 in this.listeners)
				{
					TraceListener traceListener = (TraceListener)obj2;
					if (!traceListener.IsThreadSafe)
					{
						TraceListener obj3 = traceListener;
						lock (obj3)
						{
							traceListener.Flush();
							continue;
						}
					}
					traceListener.Flush();
				}
			}
		}

		/// <summary>Получает настраиваемые атрибуты, поддерживаемые источником трассировки.</summary>
		/// <returns>Строковый массив, именующий настраиваемые атрибуты, поддерживаемые источником трассировки, или <see langword="null" />, если настраиваемые атрибуты отсутствуют.</returns>
		// Token: 0x060010EB RID: 4331 RVA: 0x00002F6A File Offset: 0x0000116A
		protected internal virtual string[] GetSupportedAttributes()
		{
			return null;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00049B98 File Offset: 0x00047D98
		internal static void RefreshAll()
		{
			List<WeakReference> obj = TraceSource.tracesources;
			lock (obj)
			{
				TraceSource._pruneCachedTraceSources();
				for (int i = 0; i < TraceSource.tracesources.Count; i++)
				{
					TraceSource traceSource = (TraceSource)TraceSource.tracesources[i].Target;
					if (traceSource != null)
					{
						traceSource.Refresh();
					}
				}
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00049C0C File Offset: 0x00047E0C
		internal void Refresh()
		{
			if (!this._initCalled)
			{
				this.Initialize();
				return;
			}
			SourceElementsCollection sources = DiagnosticsConfiguration.Sources;
			if (sources != null)
			{
				SourceElement sourceElement = sources[this.Name];
				if (sourceElement != null)
				{
					if ((string.IsNullOrEmpty(sourceElement.SwitchType) && this.internalSwitch.GetType() != typeof(SourceSwitch)) || sourceElement.SwitchType != this.internalSwitch.GetType().AssemblyQualifiedName)
					{
						if (!string.IsNullOrEmpty(sourceElement.SwitchName))
						{
							this.CreateSwitch(sourceElement.SwitchType, sourceElement.SwitchName);
						}
						else
						{
							this.CreateSwitch(sourceElement.SwitchType, this.Name);
							if (!string.IsNullOrEmpty(sourceElement.SwitchValue))
							{
								this.internalSwitch.Level = (SourceLevels)Enum.Parse(typeof(SourceLevels), sourceElement.SwitchValue);
							}
						}
					}
					else if (!string.IsNullOrEmpty(sourceElement.SwitchName))
					{
						if (sourceElement.SwitchName != this.internalSwitch.DisplayName)
						{
							this.CreateSwitch(sourceElement.SwitchType, sourceElement.SwitchName);
						}
						else
						{
							this.internalSwitch.Refresh();
						}
					}
					else if (!string.IsNullOrEmpty(sourceElement.SwitchValue))
					{
						this.internalSwitch.Level = (SourceLevels)Enum.Parse(typeof(SourceLevels), sourceElement.SwitchValue);
					}
					else
					{
						this.internalSwitch.Level = SourceLevels.Off;
					}
					TraceListenerCollection traceListenerCollection = new TraceListenerCollection();
					foreach (object obj in sourceElement.Listeners)
					{
						ListenerElement listenerElement = (ListenerElement)obj;
						TraceListener traceListener = this.listeners[listenerElement.Name];
						if (traceListener != null)
						{
							traceListenerCollection.Add(listenerElement.RefreshRuntimeObject(traceListener));
						}
						else
						{
							traceListenerCollection.Add(listenerElement.GetRuntimeObject());
						}
					}
					TraceUtils.VerifyAttributes(sourceElement.Attributes, this.GetSupportedAttributes(), this);
					this.attributes = new StringDictionary();
					this.attributes.ReplaceHashtable(sourceElement.Attributes);
					this.listeners = traceListenerCollection;
					return;
				}
				this.internalSwitch.Level = this.switchLevel;
				this.listeners.Clear();
				this.attributes = null;
			}
		}

		/// <summary>Записывает сообщение о событии трассировки в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.TraceSource.Listeners" />, используя для этого указанный тип и идентификатор события.</summary>
		/// <param name="eventType">Одно из значений перечисления, с помощью которого можно определить тип события для данных трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <exception cref="T:System.ObjectDisposedException">Предпринята попытка трассировки события в процессе завершения.</exception>
		// Token: 0x060010EE RID: 4334 RVA: 0x00049E7C File Offset: 0x0004807C
		[Conditional("TRACE")]
		public void TraceEvent(TraceEventType eventType, int id)
		{
			this.Initialize();
			TraceEventCache eventCache = new TraceEventCache();
			if (this.internalSwitch.ShouldTrace(eventType) && this.listeners != null)
			{
				if (TraceInternal.UseGlobalLock)
				{
					object critSec = TraceInternal.critSec;
					lock (critSec)
					{
						for (int i = 0; i < this.listeners.Count; i++)
						{
							TraceListener traceListener = this.listeners[i];
							traceListener.TraceEvent(eventCache, this.Name, eventType, id);
							if (Trace.AutoFlush)
							{
								traceListener.Flush();
							}
						}
						return;
					}
				}
				int j = 0;
				while (j < this.listeners.Count)
				{
					TraceListener traceListener2 = this.listeners[j];
					if (!traceListener2.IsThreadSafe)
					{
						TraceListener obj = traceListener2;
						lock (obj)
						{
							traceListener2.TraceEvent(eventCache, this.Name, eventType, id);
							if (Trace.AutoFlush)
							{
								traceListener2.Flush();
							}
							goto IL_10F;
						}
						goto IL_F1;
					}
					goto IL_F1;
					IL_10F:
					j++;
					continue;
					IL_F1:
					traceListener2.TraceEvent(eventCache, this.Name, eventType, id);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
						goto IL_10F;
					}
					goto IL_10F;
				}
			}
		}

		/// <summary>Записывает сообщение о событии трассировки в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.TraceSource.Listeners" />, используя для этого указанный тип и идентификатор события, а также сообщение.</summary>
		/// <param name="eventType">Одно из значений перечисления, с помощью которого можно определить тип события для данных трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="message">Записываемое сообщение трассировки.</param>
		/// <exception cref="T:System.ObjectDisposedException">Предпринята попытка трассировки события в процессе завершения.</exception>
		// Token: 0x060010EF RID: 4335 RVA: 0x00049FD0 File Offset: 0x000481D0
		[Conditional("TRACE")]
		public void TraceEvent(TraceEventType eventType, int id, string message)
		{
			this.Initialize();
			TraceEventCache eventCache = new TraceEventCache();
			if (this.internalSwitch.ShouldTrace(eventType) && this.listeners != null)
			{
				if (TraceInternal.UseGlobalLock)
				{
					object critSec = TraceInternal.critSec;
					lock (critSec)
					{
						for (int i = 0; i < this.listeners.Count; i++)
						{
							TraceListener traceListener = this.listeners[i];
							traceListener.TraceEvent(eventCache, this.Name, eventType, id, message);
							if (Trace.AutoFlush)
							{
								traceListener.Flush();
							}
						}
						return;
					}
				}
				int j = 0;
				while (j < this.listeners.Count)
				{
					TraceListener traceListener2 = this.listeners[j];
					if (!traceListener2.IsThreadSafe)
					{
						TraceListener obj = traceListener2;
						lock (obj)
						{
							traceListener2.TraceEvent(eventCache, this.Name, eventType, id, message);
							if (Trace.AutoFlush)
							{
								traceListener2.Flush();
							}
							goto IL_112;
						}
						goto IL_F3;
					}
					goto IL_F3;
					IL_112:
					j++;
					continue;
					IL_F3:
					traceListener2.TraceEvent(eventCache, this.Name, eventType, id, message);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
						goto IL_112;
					}
					goto IL_112;
				}
			}
		}

		/// <summary>Записывает сообщение о событии трассировки в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.TraceSource.Listeners" />, используя для этого указанный тип и идентификатор события, а также массив аргументов и формат.</summary>
		/// <param name="eventType">Одно из значений перечисления, с помощью которого можно определить тип события для данных трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="format">Строка составного формата, содержащая текст, который перемежается несколькими элементами форматирования (или ни одним из них), соответствующими объектам в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив <see langword="object" />, содержащий несколько объектов (или ни одного), которые необходимо отформатировать.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		///
		/// или - 
		/// Число, указывающее аргумент для форматирования, меньше нуля или больше или равно числу указанных объектов для форматирования.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предпринята попытка трассировки события в процессе завершения.</exception>
		// Token: 0x060010F0 RID: 4336 RVA: 0x0004A128 File Offset: 0x00048328
		[Conditional("TRACE")]
		public void TraceEvent(TraceEventType eventType, int id, string format, params object[] args)
		{
			this.Initialize();
			TraceEventCache eventCache = new TraceEventCache();
			if (this.internalSwitch.ShouldTrace(eventType) && this.listeners != null)
			{
				if (TraceInternal.UseGlobalLock)
				{
					object critSec = TraceInternal.critSec;
					lock (critSec)
					{
						for (int i = 0; i < this.listeners.Count; i++)
						{
							TraceListener traceListener = this.listeners[i];
							traceListener.TraceEvent(eventCache, this.Name, eventType, id, format, args);
							if (Trace.AutoFlush)
							{
								traceListener.Flush();
							}
						}
						return;
					}
				}
				int j = 0;
				while (j < this.listeners.Count)
				{
					TraceListener traceListener2 = this.listeners[j];
					if (!traceListener2.IsThreadSafe)
					{
						TraceListener obj = traceListener2;
						lock (obj)
						{
							traceListener2.TraceEvent(eventCache, this.Name, eventType, id, format, args);
							if (Trace.AutoFlush)
							{
								traceListener2.Flush();
							}
							goto IL_118;
						}
						goto IL_F7;
					}
					goto IL_F7;
					IL_118:
					j++;
					continue;
					IL_F7:
					traceListener2.TraceEvent(eventCache, this.Name, eventType, id, format, args);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
						goto IL_118;
					}
					goto IL_118;
				}
			}
		}

		/// <summary>Записывает данные трассировки в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.TraceSource.Listeners" />, используя для этого указанный тип и идентификатор события, а также данные трассировки.</summary>
		/// <param name="eventType">Одно из значений перечисления, с помощью которого можно определить тип события для данных трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="data">Данные трассировки.</param>
		/// <exception cref="T:System.ObjectDisposedException">Предпринята попытка трассировки события в процессе завершения.</exception>
		// Token: 0x060010F1 RID: 4337 RVA: 0x0004A284 File Offset: 0x00048484
		[Conditional("TRACE")]
		public void TraceData(TraceEventType eventType, int id, object data)
		{
			this.Initialize();
			TraceEventCache eventCache = new TraceEventCache();
			if (this.internalSwitch.ShouldTrace(eventType) && this.listeners != null)
			{
				if (TraceInternal.UseGlobalLock)
				{
					object critSec = TraceInternal.critSec;
					lock (critSec)
					{
						for (int i = 0; i < this.listeners.Count; i++)
						{
							TraceListener traceListener = this.listeners[i];
							traceListener.TraceData(eventCache, this.Name, eventType, id, data);
							if (Trace.AutoFlush)
							{
								traceListener.Flush();
							}
						}
						return;
					}
				}
				int j = 0;
				while (j < this.listeners.Count)
				{
					TraceListener traceListener2 = this.listeners[j];
					if (!traceListener2.IsThreadSafe)
					{
						TraceListener obj = traceListener2;
						lock (obj)
						{
							traceListener2.TraceData(eventCache, this.Name, eventType, id, data);
							if (Trace.AutoFlush)
							{
								traceListener2.Flush();
							}
							goto IL_112;
						}
						goto IL_F3;
					}
					goto IL_F3;
					IL_112:
					j++;
					continue;
					IL_F3:
					traceListener2.TraceData(eventCache, this.Name, eventType, id, data);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
						goto IL_112;
					}
					goto IL_112;
				}
			}
		}

		/// <summary>Записывает данные трассировки в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.TraceSource.Listeners" />, используя для этого указанный тип и идентификатор события, а также данные трассировки.</summary>
		/// <param name="eventType">Одно из значений перечисления, с помощью которого можно определить тип события для данных трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="data">Массив объектного типа, содержащий данные трассировки.</param>
		/// <exception cref="T:System.ObjectDisposedException">Предпринята попытка трассировки события в процессе завершения.</exception>
		// Token: 0x060010F2 RID: 4338 RVA: 0x0004A3DC File Offset: 0x000485DC
		[Conditional("TRACE")]
		public void TraceData(TraceEventType eventType, int id, params object[] data)
		{
			this.Initialize();
			TraceEventCache eventCache = new TraceEventCache();
			if (this.internalSwitch.ShouldTrace(eventType) && this.listeners != null)
			{
				if (TraceInternal.UseGlobalLock)
				{
					object critSec = TraceInternal.critSec;
					lock (critSec)
					{
						for (int i = 0; i < this.listeners.Count; i++)
						{
							TraceListener traceListener = this.listeners[i];
							traceListener.TraceData(eventCache, this.Name, eventType, id, data);
							if (Trace.AutoFlush)
							{
								traceListener.Flush();
							}
						}
						return;
					}
				}
				int j = 0;
				while (j < this.listeners.Count)
				{
					TraceListener traceListener2 = this.listeners[j];
					if (!traceListener2.IsThreadSafe)
					{
						TraceListener obj = traceListener2;
						lock (obj)
						{
							traceListener2.TraceData(eventCache, this.Name, eventType, id, data);
							if (Trace.AutoFlush)
							{
								traceListener2.Flush();
							}
							goto IL_112;
						}
						goto IL_F3;
					}
					goto IL_F3;
					IL_112:
					j++;
					continue;
					IL_F3:
					traceListener2.TraceData(eventCache, this.Name, eventType, id, data);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
						goto IL_112;
					}
					goto IL_112;
				}
			}
		}

		/// <summary>Записывает информационное сообщение в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.TraceSource.Listeners" />, используя для этого указанное сообщение.</summary>
		/// <param name="message">Информационное сообщение для записи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Предпринята попытка трассировки события в процессе завершения.</exception>
		// Token: 0x060010F3 RID: 4339 RVA: 0x00003917 File Offset: 0x00001B17
		[Conditional("TRACE")]
		public void TraceInformation(string message)
		{
		}

		/// <summary>Записывает информационное сообщение в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.TraceSource.Listeners" />, используя для этого указанный массив объектов и сведения о форматировании.</summary>
		/// <param name="format">Строка составного формата, содержащая текст, который перемежается несколькими элементами форматирования (или ни одним из них), соответствующими объектам в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив, содержащий несколько (или ни одного) объектов, которые необходимо отформатировать.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		///
		/// или - 
		/// Число, указывающее аргумент для форматирования, меньше нуля или больше или равно числу указанных объектов для форматирования.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предпринята попытка трассировки события в процессе завершения.</exception>
		// Token: 0x060010F4 RID: 4340 RVA: 0x00003917 File Offset: 0x00001B17
		[Conditional("TRACE")]
		public void TraceInformation(string format, params object[] args)
		{
		}

		/// <summary>Записывает сообщение о перемещении трассировки в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.TraceSource.Listeners" />, используя для этого указанный числовой идентификатор, сообщение, а также идентификатор сопутствующего действия.</summary>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="message">Записываемое сообщение трассировки.</param>
		/// <param name="relatedActivityId">Структура, идентифицирующая сопутствующее действие.</param>
		// Token: 0x060010F5 RID: 4341 RVA: 0x0004A534 File Offset: 0x00048734
		[Conditional("TRACE")]
		public void TraceTransfer(int id, string message, Guid relatedActivityId)
		{
			this.Initialize();
			TraceEventCache eventCache = new TraceEventCache();
			if (this.internalSwitch.ShouldTrace(TraceEventType.Transfer) && this.listeners != null)
			{
				if (TraceInternal.UseGlobalLock)
				{
					object critSec = TraceInternal.critSec;
					lock (critSec)
					{
						for (int i = 0; i < this.listeners.Count; i++)
						{
							TraceListener traceListener = this.listeners[i];
							traceListener.TraceTransfer(eventCache, this.Name, id, message, relatedActivityId);
							if (Trace.AutoFlush)
							{
								traceListener.Flush();
							}
						}
						return;
					}
				}
				int j = 0;
				while (j < this.listeners.Count)
				{
					TraceListener traceListener2 = this.listeners[j];
					if (!traceListener2.IsThreadSafe)
					{
						TraceListener obj = traceListener2;
						lock (obj)
						{
							traceListener2.TraceTransfer(eventCache, this.Name, id, message, relatedActivityId);
							if (Trace.AutoFlush)
							{
								traceListener2.Flush();
							}
							goto IL_116;
						}
						goto IL_F7;
					}
					goto IL_F7;
					IL_116:
					j++;
					continue;
					IL_F7:
					traceListener2.TraceTransfer(eventCache, this.Name, id, message, relatedActivityId);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
						goto IL_116;
					}
					goto IL_116;
				}
			}
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0004A690 File Offset: 0x00048890
		private void CreateSwitch(string typename, string name)
		{
			if (!string.IsNullOrEmpty(typename))
			{
				this.internalSwitch = (SourceSwitch)TraceUtils.GetRuntimeObject(typename, typeof(SourceSwitch), name);
				return;
			}
			this.internalSwitch = new SourceSwitch(name, this.switchLevel.ToString());
		}

		/// <summary>Получает настраиваемые атрибуты переключателя, определенные в файле конфигурации приложения.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Specialized.StringDictionary" />, содержащий настраиваемые атрибуты для переключателя трассировки.</returns>
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0004A6E3 File Offset: 0x000488E3
		public StringDictionary Attributes
		{
			get
			{
				this.Initialize();
				if (this.attributes == null)
				{
					this.attributes = new StringDictionary();
				}
				return this.attributes;
			}
		}

		/// <summary>Получает имя источника трассировки.</summary>
		/// <returns>Имя источника трассировки.</returns>
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0004A704 File Offset: 0x00048904
		public string Name
		{
			get
			{
				return this.sourceName;
			}
		}

		/// <summary>Получает коллекцию прослушивателей трассировки для ее источника.</summary>
		/// <returns>Коллекция <see cref="T:System.Diagnostics.TraceListenerCollection" />, в которой содержатся связанные с источником прослушиватели трассировки.</returns>
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0004A70E File Offset: 0x0004890E
		public TraceListenerCollection Listeners
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				this.Initialize();
				return this.listeners;
			}
		}

		/// <summary>Получает или задает значение переключателя источника.</summary>
		/// <returns>Объект <see cref="T:System.Diagnostics.SourceSwitch" />, представляющий значение переключателя источника.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Diagnostics.TraceSource.Switch" /> задается значение <see langword="null" />.</exception>
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0004A71E File Offset: 0x0004891E
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x0004A72E File Offset: 0x0004892E
		public SourceSwitch Switch
		{
			get
			{
				this.Initialize();
				return this.internalSwitch;
			}
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Switch");
				}
				this.Initialize();
				this.internalSwitch = value;
			}
		}

		// Token: 0x04000A09 RID: 2569
		private static List<WeakReference> tracesources = new List<WeakReference>();

		// Token: 0x04000A0A RID: 2570
		private static int s_LastCollectionCount;

		// Token: 0x04000A0B RID: 2571
		private volatile SourceSwitch internalSwitch;

		// Token: 0x04000A0C RID: 2572
		private volatile TraceListenerCollection listeners;

		// Token: 0x04000A0D RID: 2573
		private StringDictionary attributes;

		// Token: 0x04000A0E RID: 2574
		private SourceLevels switchLevel;

		// Token: 0x04000A0F RID: 2575
		private volatile string sourceName;

		// Token: 0x04000A10 RID: 2576
		internal volatile bool _initCalled;
	}
}
