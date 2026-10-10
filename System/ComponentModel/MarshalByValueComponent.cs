using System;
using System.ComponentModel.Design;

namespace System.ComponentModel
{
	/// <summary>Реализует интерфейс <see cref="T:System.ComponentModel.IComponent" /> и предоставляет базовую реализацию для удаленных компонентов, которые маршалируются по значению (передается копия сериализованного объекта).</summary>
	// Token: 0x020003D4 RID: 980
	[TypeConverter(typeof(ComponentConverter))]
	[DesignerCategory("Component")]
	[Designer("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IRootDesigner))]
	public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
	{
		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x06001FA2 RID: 8098 RVA: 0x0006D7A0 File Offset: 0x0006B9A0
		~MarshalByValueComponent()
		{
			this.Dispose(false);
		}

		/// <summary>Добавляет обработчик событий, чтобы прослушивать событие <see cref="E:System.ComponentModel.MarshalByValueComponent.Disposed" /> для компонента.</summary>
		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06001FA3 RID: 8099 RVA: 0x0006D7D0 File Offset: 0x0006B9D0
		// (remove) Token: 0x06001FA4 RID: 8100 RVA: 0x0006D7E3 File Offset: 0x0006B9E3
		public event EventHandler Disposed
		{
			add
			{
				this.Events.AddHandler(MarshalByValueComponent.s_eventDisposed, value);
			}
			remove
			{
				this.Events.RemoveHandler(MarshalByValueComponent.s_eventDisposed, value);
			}
		}

		/// <summary>Возвращает список обработчиков событий, которые прикреплены к этому компоненту.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.EventHandlerList" />, предоставляющий делегаты для этого компонента.</returns>
		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0006D7F8 File Offset: 0x0006B9F8
		protected EventHandlerList Events
		{
			get
			{
				EventHandlerList result;
				if ((result = this._events) == null)
				{
					result = (this._events = new EventHandlerList());
				}
				return result;
			}
		}

		/// <summary>Получает или задает узел компонента.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.ComponentModel.ISite" />, который представляет узел компонента.</returns>
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0006D81D File Offset: 0x0006BA1D
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x0006D825 File Offset: 0x0006BA25
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site
		{
			get
			{
				return this._site;
			}
			set
			{
				this._site = value;
			}
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.ComponentModel.MarshalByValueComponent" />.</summary>
		// Token: 0x06001FA8 RID: 8104 RVA: 0x0006D82E File Offset: 0x0006BA2E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.MarshalByValueComponent" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06001FA9 RID: 8105 RVA: 0x0006D840 File Offset: 0x0006BA40
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				lock (this)
				{
					ISite site = this._site;
					if (site != null)
					{
						IContainer container = site.Container;
						if (container != null)
						{
							container.Remove(this);
						}
					}
					EventHandlerList events = this._events;
					EventHandler eventHandler = (EventHandler)((events != null) ? events[MarshalByValueComponent.s_eventDisposed] : null);
					if (eventHandler != null)
					{
						eventHandler(this, EventArgs.Empty);
					}
				}
			}
		}

		/// <summary>Возвращает контейнер для компонента.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.ComponentModel.IContainer" />, который представляет контейнер компонента, или значение <see langword="null" />, если у компонента отсутствует узел.</returns>
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0006D8C4 File Offset: 0x0006BAC4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IContainer Container
		{
			get
			{
				ISite site = this._site;
				if (site == null)
				{
					return null;
				}
				return site.Container;
			}
		}

		/// <summary>Возвращает средство реализации объекта <see cref="T:System.IServiceProvider" />.</summary>
		/// <param name="service">Объект <see cref="T:System.Type" />, представляющий нужный тип службы.</param>
		/// <returns>Объект <see cref="T:System.Object" />, который представляет средство реализации объекта <see cref="T:System.IServiceProvider" />.</returns>
		// Token: 0x06001FAB RID: 8107 RVA: 0x0006D8D7 File Offset: 0x0006BAD7
		public virtual object GetService(Type service)
		{
			ISite site = this._site;
			if (site == null)
			{
				return null;
			}
			return site.GetService(service);
		}

		/// <summary>Возвращает значение, показывающее, находится ли компонент в настоящий момент в режиме разработки.</summary>
		/// <returns>Значение <see langword="true" />, если компонент находится в режиме разработки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x0006D8EB File Offset: 0x0006BAEB
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool DesignMode
		{
			get
			{
				ISite site = this._site;
				return site != null && site.DesignMode;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.String" />, содержащий имя <see cref="T:System.ComponentModel.Component" />, если оно есть. Этот метод не следует переопределять.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая имя компонента <see cref="T:System.ComponentModel.Component" />, если у компонента есть имя.  
		///  Значение <see langword="null" />, если у компонента <see cref="T:System.ComponentModel.Component" /> нет имени.</returns>
		// Token: 0x06001FAD RID: 8109 RVA: 0x0006D900 File Offset: 0x0006BB00
		public override string ToString()
		{
			ISite site = this._site;
			if (site != null)
			{
				return site.Name + " [" + base.GetType().FullName + "]";
			}
			return base.GetType().FullName;
		}

		// Token: 0x04000F76 RID: 3958
		private static readonly object s_eventDisposed = new object();

		// Token: 0x04000F77 RID: 3959
		private ISite _site;

		// Token: 0x04000F78 RID: 3960
		private EventHandlerList _events;
	}
}
