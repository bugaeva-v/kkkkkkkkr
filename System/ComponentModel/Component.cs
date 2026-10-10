using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Предоставляет базовую реализацию интерфейса <see cref="T:System.ComponentModel.IComponent" /> и делает возможным совместное использование объектов разными приложениями.</summary>
	// Token: 0x0200040D RID: 1037
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[DesignerCategory("Component")]
	public class Component : MarshalByRefObject, IComponent, IDisposable
	{
		/// <summary>Освобождает неуправляемые ресурсы и выполняет другие операции очистки, перед тем как объект <see cref="T:System.ComponentModel.Component" /> будет удален при сборке мусора.</summary>
		// Token: 0x0600217E RID: 8574 RVA: 0x00072904 File Offset: 0x00070B04
		~Component()
		{
			this.Dispose(false);
		}

		/// <summary>Возвращает значение, показывающее, может ли компонент вызывать событие.</summary>
		/// <returns>Значение <see langword="true" />, если компонент может вызывать события, в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x0000390E File Offset: 0x00001B0E
		protected virtual bool CanRaiseEvents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x00072934 File Offset: 0x00070B34
		internal bool CanRaiseEventsInternal
		{
			get
			{
				return this.CanRaiseEvents;
			}
		}

		/// <summary>Происходит при удалении компонента вызовом метода <see cref="M:System.ComponentModel.Component.Dispose" />.</summary>
		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06002181 RID: 8577 RVA: 0x0007293C File Offset: 0x00070B3C
		// (remove) Token: 0x06002182 RID: 8578 RVA: 0x0007294F File Offset: 0x00070B4F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[Browsable(false)]
		public event EventHandler Disposed
		{
			add
			{
				this.Events.AddHandler(Component.EventDisposed, value);
			}
			remove
			{
				this.Events.RemoveHandler(Component.EventDisposed, value);
			}
		}

		/// <summary>Возвращает список обработчиков событий, которые прикреплены к этому объекту <see cref="T:System.ComponentModel.Component" />.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.EventHandlerList" />, предоставляющий делегаты для этого компонента.</returns>
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x00072962 File Offset: 0x00070B62
		protected EventHandlerList Events
		{
			get
			{
				if (this.events == null)
				{
					this.events = new EventHandlerList(this);
				}
				return this.events;
			}
		}

		/// <summary>Возвращает или задает <see cref="T:System.ComponentModel.ISite" /> объекта <see cref="T:System.ComponentModel.Component" />.</summary>
		/// <returns>узел <see cref="T:System.ComponentModel.ISite" />, связанный с компонентом <see cref="T:System.ComponentModel.Component" />, или <see langword="null" />, если компонент <see cref="T:System.ComponentModel.Component" /> не инкапсулирован в контейнер <see cref="T:System.ComponentModel.IContainer" />, с компонентом <see cref="T:System.ComponentModel.Component" /> не связан узел <see cref="T:System.ComponentModel.ISite" />, или компонент <see cref="T:System.ComponentModel.Component" /> удален из своего контейнера <see cref="T:System.ComponentModel.IContainer" />.</returns>
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0007297E File Offset: 0x00070B7E
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x00072986 File Offset: 0x00070B86
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site
		{
			get
			{
				return this.site;
			}
			set
			{
				this.site = value;
			}
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.ComponentModel.Component" />.</summary>
		// Token: 0x06002186 RID: 8582 RVA: 0x0007298F File Offset: 0x00070B8F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.Component" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002187 RID: 8583 RVA: 0x000729A0 File Offset: 0x00070BA0
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				lock (this)
				{
					if (this.site != null && this.site.Container != null)
					{
						this.site.Container.Remove(this);
					}
					if (this.events != null)
					{
						EventHandler eventHandler = (EventHandler)this.events[Component.EventDisposed];
						if (eventHandler != null)
						{
							eventHandler(this, EventArgs.Empty);
						}
					}
				}
			}
		}

		/// <summary>Возвращает контейнер <see cref="T:System.ComponentModel.IContainer" />, содержащий компонент <see cref="T:System.ComponentModel.Component" />.</summary>
		/// <returns>Контейнер <see cref="T:System.ComponentModel.IContainer" />, содержащий компонент <see cref="T:System.ComponentModel.Component" />, если таковой присутствует, или значение <see langword="null" />, если компонент <see cref="T:System.ComponentModel.Component" /> не инкапсулирован в контейнер <see cref="T:System.ComponentModel.IContainer" />.</returns>
		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x00072A2C File Offset: 0x00070C2C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IContainer Container
		{
			get
			{
				ISite site = this.site;
				if (site != null)
				{
					return site.Container;
				}
				return null;
			}
		}

		/// <summary>Возвращает объект, представляющий службу, предоставляемую классом <see cref="T:System.ComponentModel.Component" /> или классом <see cref="T:System.ComponentModel.Container" />.</summary>
		/// <param name="service">Служба, предоставляемая компонентом <see cref="T:System.ComponentModel.Component" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий службу, обеспечиваемую компонентом <see cref="T:System.ComponentModel.Component" />, или <see langword="null" />, если компонент <see cref="T:System.ComponentModel.Component" /> не предоставляет заданную службу.</returns>
		// Token: 0x06002189 RID: 8585 RVA: 0x00072A4C File Offset: 0x00070C4C
		protected virtual object GetService(Type service)
		{
			ISite site = this.site;
			if (site != null)
			{
				return site.GetService(service);
			}
			return null;
		}

		/// <summary>Возвращает значение, указывающее, находится ли данный компонент <see cref="T:System.ComponentModel.Component" /> в режиме конструктора в настоящее время.</summary>
		/// <returns>Значение <see langword="true" />, если компонент <see cref="T:System.ComponentModel.Component" /> находится в режиме конструктора, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00072A6C File Offset: 0x00070C6C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		protected bool DesignMode
		{
			get
			{
				ISite site = this.site;
				return site != null && site.DesignMode;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.String" />, содержащий имя <see cref="T:System.ComponentModel.Component" />, если оно есть. Этот метод не следует переопределять.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя <see cref="T:System.ComponentModel.Component" />, если оно есть, или <see langword="null" />, если <see cref="T:System.ComponentModel.Component" /> не имеет имени.</returns>
		// Token: 0x0600218B RID: 8587 RVA: 0x00072A8C File Offset: 0x00070C8C
		public override string ToString()
		{
			ISite site = this.site;
			if (site != null)
			{
				return site.Name + " [" + base.GetType().FullName + "]";
			}
			return base.GetType().FullName;
		}

		// Token: 0x04001016 RID: 4118
		private static readonly object EventDisposed = new object();

		// Token: 0x04001017 RID: 4119
		private ISite site;

		// Token: 0x04001018 RID: 4120
		private EventHandlerList events;
	}
}
