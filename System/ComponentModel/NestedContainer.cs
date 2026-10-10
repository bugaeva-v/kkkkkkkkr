using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Предоставляет базовую реализацию интерфейса <see cref="T:System.ComponentModel.INestedContainer" />, позволяющую использовать компонент-владелец для контейнеров.</summary>
	// Token: 0x020003DB RID: 987
	public class NestedContainer : Container, INestedContainer, IContainer, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.NestedContainer" />.</summary>
		/// <param name="owner">Интерфейс <see cref="T:System.ComponentModel.IComponent" />, являющийся владельцем этого вложенного контейнера.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="owner" /> — <see langword="null" />.</exception>
		// Token: 0x06002026 RID: 8230 RVA: 0x0006F756 File Offset: 0x0006D956
		public NestedContainer(IComponent owner)
		{
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			this.Owner = owner;
			this.Owner.Disposed += this.OnOwnerDisposed;
		}

		/// <summary>Возвращает компонент-владелец для этого вложенного контейнера.</summary>
		/// <returns>Интерфейс <see cref="T:System.ComponentModel.IComponent" />, являющийся владельцем этого вложенного контейнера.</returns>
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x0006F78A File Offset: 0x0006D98A
		public IComponent Owner { get; }

		/// <summary>Возвращает имя компонента-владельца.</summary>
		/// <returns>Имя компонента-владельца.</returns>
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x0006F794 File Offset: 0x0006D994
		protected virtual string OwnerName
		{
			get
			{
				string result = null;
				if (this.Owner != null && this.Owner.Site != null)
				{
					INestedSite nestedSite = this.Owner.Site as INestedSite;
					if (nestedSite != null)
					{
						result = nestedSite.FullName;
					}
					else
					{
						result = this.Owner.Site.Name;
					}
				}
				return result;
			}
		}

		/// <summary>Создает внутри контейнера узел для компонента.</summary>
		/// <param name="component">Компонент <see cref="T:System.ComponentModel.IComponent" />, для которого создается узел.</param>
		/// <param name="name">Имя, которое нужно присвоить параметру <paramref name="component" />, или <see langword="null" />, чтобы опустить назначение имени.</param>
		/// <returns>Вновь созданный объект <see cref="T:System.ComponentModel.ISite" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="component" /> — <see langword="null" />.</exception>
		// Token: 0x06002029 RID: 8233 RVA: 0x0006F7E7 File Offset: 0x0006D9E7
		protected override ISite CreateSite(IComponent component, string name)
		{
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			return new NestedContainer.Site(component, this, name);
		}

		/// <summary>Освобождает ресурсы, используемые вложенным контейнером.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x0600202A RID: 8234 RVA: 0x0006F7FF File Offset: 0x0006D9FF
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Owner.Disposed -= this.OnOwnerDisposed;
			}
			base.Dispose(disposing);
		}

		/// <summary>Возвращает объект службы указанного типа, если он доступен.</summary>
		/// <param name="service">
		///   <see cref="T:System.Type" /> искомой службы.</param>
		/// <returns>Объект <see cref="T:System.Object" />, реализующий запрошенную службу, или значение <see langword="null" />, если служба не может быть разрешена.</returns>
		// Token: 0x0600202B RID: 8235 RVA: 0x0006F822 File Offset: 0x0006DA22
		protected override object GetService(Type service)
		{
			if (service == typeof(INestedContainer))
			{
				return this;
			}
			return base.GetService(service);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0006F83F File Offset: 0x0006DA3F
		private void OnOwnerDisposed(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x020003DC RID: 988
		private class Site : INestedSite, ISite, IServiceProvider
		{
			// Token: 0x0600202D RID: 8237 RVA: 0x0006F847 File Offset: 0x0006DA47
			internal Site(IComponent component, NestedContainer container, string name)
			{
				this.Component = component;
				this.Container = container;
				this._name = name;
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x0600202E RID: 8238 RVA: 0x0006F864 File Offset: 0x0006DA64
			public IComponent Component { get; }

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x0600202F RID: 8239 RVA: 0x0006F86C File Offset: 0x0006DA6C
			public IContainer Container { get; }

			// Token: 0x06002030 RID: 8240 RVA: 0x0006F874 File Offset: 0x0006DA74
			public object GetService(Type service)
			{
				if (!(service == typeof(ISite)))
				{
					return ((NestedContainer)this.Container).GetService(service);
				}
				return this;
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x06002031 RID: 8241 RVA: 0x0006F89C File Offset: 0x0006DA9C
			public bool DesignMode
			{
				get
				{
					IComponent owner = ((NestedContainer)this.Container).Owner;
					return owner != null && owner.Site != null && owner.Site.DesignMode;
				}
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x06002032 RID: 8242 RVA: 0x0006F8D4 File Offset: 0x0006DAD4
			public string FullName
			{
				get
				{
					if (this._name != null)
					{
						string ownerName = ((NestedContainer)this.Container).OwnerName;
						string text = this._name;
						if (ownerName != null)
						{
							text = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", ownerName, text);
						}
						return text;
					}
					return this._name;
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x06002033 RID: 8243 RVA: 0x0006F91E File Offset: 0x0006DB1E
			// (set) Token: 0x06002034 RID: 8244 RVA: 0x0006F926 File Offset: 0x0006DB26
			public string Name
			{
				get
				{
					return this._name;
				}
				set
				{
					if (value == null || this._name == null || !value.Equals(this._name))
					{
						((NestedContainer)this.Container).ValidateName(this.Component, value);
						this._name = value;
					}
				}
			}

			// Token: 0x04000FB5 RID: 4021
			private string _name;
		}
	}
}
