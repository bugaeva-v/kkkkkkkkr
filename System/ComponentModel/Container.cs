using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Инкапсулирует ноль или более компонентов.</summary>
	// Token: 0x0200040F RID: 1039
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class Container : IContainer, IDisposable
	{
		/// <summary>Освобождает неуправляемые ресурсы и выполняет другие операции очистки, перед тем как объект <see cref="T:System.ComponentModel.Container" /> будет удален при сборке мусора.</summary>
		// Token: 0x06002191 RID: 8593 RVA: 0x00072AE4 File Offset: 0x00070CE4
		~Container()
		{
			this.Dispose(false);
		}

		/// <summary>Добавляет заданный объект <see cref="T:System.ComponentModel.Component" /> в <see cref="T:System.ComponentModel.Container" />. Компонент добавляется без имени.</summary>
		/// <param name="component">Добавляемый компонент.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="component" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002192 RID: 8594 RVA: 0x00072B14 File Offset: 0x00070D14
		public virtual void Add(IComponent component)
		{
			this.Add(component, null);
		}

		/// <summary>Добавляет указанный <see cref="T:System.ComponentModel.Component" /> в <see cref="T:System.ComponentModel.Container" /> и присваивает ему имя.</summary>
		/// <param name="component">Добавляемый компонент.</param>
		/// <param name="name">Назначаемое компоненту уникальное имя, в котором не учитывается регистр.  
		///
		/// или - 
		/// <see langword="null" />, при котором компонент остается безымянным.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="component" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="name" /> не является уникальным.</exception>
		// Token: 0x06002193 RID: 8595 RVA: 0x00072B20 File Offset: 0x00070D20
		public virtual void Add(IComponent component, string name)
		{
			object obj = this.syncObj;
			lock (obj)
			{
				if (component != null)
				{
					ISite site = component.Site;
					if (site == null || site.Container != this)
					{
						if (this.sites == null)
						{
							this.sites = new ISite[4];
						}
						else
						{
							this.ValidateName(component, name);
							if (this.sites.Length == this.siteCount)
							{
								ISite[] destinationArray = new ISite[this.siteCount * 2];
								Array.Copy(this.sites, 0, destinationArray, 0, this.siteCount);
								this.sites = destinationArray;
							}
						}
						if (site != null)
						{
							site.Container.Remove(component);
						}
						ISite site2 = this.CreateSite(component, name);
						ISite[] array = this.sites;
						int num = this.siteCount;
						this.siteCount = num + 1;
						array[num] = site2;
						component.Site = site2;
						this.components = null;
					}
				}
			}
		}

		/// <summary>Создает узел <see cref="T:System.ComponentModel.ISite" /> для указанного компонента <see cref="T:System.ComponentModel.IComponent" /> и присваивает узлу заданное имя.</summary>
		/// <param name="component">Компонент <see cref="T:System.ComponentModel.IComponent" />, для которого создается узел.</param>
		/// <param name="name">Имя, которое нужно присвоить параметру <paramref name="component" />, или <see langword="null" />, чтобы опустить назначение имени.</param>
		/// <returns>Вновь созданный узел.</returns>
		// Token: 0x06002194 RID: 8596 RVA: 0x00072C18 File Offset: 0x00070E18
		protected virtual ISite CreateSite(IComponent component, string name)
		{
			return new Container.Site(component, this, name);
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.ComponentModel.Container" />.</summary>
		// Token: 0x06002195 RID: 8597 RVA: 0x00072C22 File Offset: 0x00070E22
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые журналом <see cref="T:System.ComponentModel.Container" />, и при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002196 RID: 8598 RVA: 0x00072C34 File Offset: 0x00070E34
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				object obj = this.syncObj;
				lock (obj)
				{
					while (this.siteCount > 0)
					{
						ISite[] array = this.sites;
						int num = this.siteCount - 1;
						this.siteCount = num;
						object obj2 = array[num];
						((ISite)obj2).Component.Site = null;
						((ISite)obj2).Component.Dispose();
					}
					this.sites = null;
					this.components = null;
				}
			}
		}

		/// <summary>Получает объект службы указанного типа, если он доступен.</summary>
		/// <param name="service">Тип <see cref="T:System.Type" /> извлекаемой службы.</param>
		/// <returns>Объект <see cref="T:System.Object" />, реализующий запрошенную службу, или значение <see langword="null" />, если служба не может быть реализована.</returns>
		// Token: 0x06002197 RID: 8599 RVA: 0x00072CB8 File Offset: 0x00070EB8
		protected virtual object GetService(Type service)
		{
			if (!(service == typeof(IContainer)))
			{
				return null;
			}
			return this;
		}

		/// <summary>Получает все компоненты в контейнере <see cref="T:System.ComponentModel.Container" />.</summary>
		/// <returns>Коллекция компонентов, инкапсулированных в объект <see cref="T:System.ComponentModel.Container" />.</returns>
		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x00072CD0 File Offset: 0x00070ED0
		public virtual ComponentCollection Components
		{
			get
			{
				object obj = this.syncObj;
				ComponentCollection result;
				lock (obj)
				{
					if (this.components == null)
					{
						IComponent[] array = new IComponent[this.siteCount];
						for (int i = 0; i < this.siteCount; i++)
						{
							array[i] = this.sites[i].Component;
						}
						this.components = new ComponentCollection(array);
						if (this.filter == null && this.checkedFilter)
						{
							this.checkedFilter = false;
						}
					}
					if (!this.checkedFilter)
					{
						this.filter = (this.GetService(typeof(ContainerFilterService)) as ContainerFilterService);
						this.checkedFilter = true;
					}
					if (this.filter != null)
					{
						ComponentCollection componentCollection = this.filter.FilterComponents(this.components);
						if (componentCollection != null)
						{
							this.components = componentCollection;
						}
					}
					result = this.components;
				}
				return result;
			}
		}

		/// <summary>Удаляет компонент из контейнера <see cref="T:System.ComponentModel.Container" />.</summary>
		/// <param name="component">Удаляемый компонент.</param>
		// Token: 0x06002199 RID: 8601 RVA: 0x00072DC0 File Offset: 0x00070FC0
		public virtual void Remove(IComponent component)
		{
			this.Remove(component, false);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00072DCC File Offset: 0x00070FCC
		private void Remove(IComponent component, bool preserveSite)
		{
			object obj = this.syncObj;
			lock (obj)
			{
				if (component != null)
				{
					ISite site = component.Site;
					if (site != null && site.Container == this)
					{
						if (!preserveSite)
						{
							component.Site = null;
						}
						for (int i = 0; i < this.siteCount; i++)
						{
							if (this.sites[i] == site)
							{
								this.siteCount--;
								Array.Copy(this.sites, i + 1, this.sites, i, this.siteCount - i);
								this.sites[this.siteCount] = null;
								this.components = null;
								break;
							}
						}
					}
				}
			}
		}

		/// <summary>Удаляет компонент из контейнера <see cref="T:System.ComponentModel.Container" />, не устанавливая для узла <see cref="P:System.ComponentModel.IComponent.Site" /> значение <see langword="null" />.</summary>
		/// <param name="component">Удаляемый компонент.</param>
		// Token: 0x0600219B RID: 8603 RVA: 0x00072E8C File Offset: 0x0007108C
		protected void RemoveWithoutUnsiting(IComponent component)
		{
			this.Remove(component, true);
		}

		/// <summary>Определяет, является ли имя компонента уникальным для этого контейнера.</summary>
		/// <param name="component">Компонент с именем.</param>
		/// <param name="name">Проверяемое имя компонента.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="component" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="name" /> не является уникальным.</exception>
		// Token: 0x0600219C RID: 8604 RVA: 0x00072E98 File Offset: 0x00071098
		protected virtual void ValidateName(IComponent component, string name)
		{
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			if (name != null)
			{
				for (int i = 0; i < Math.Min(this.siteCount, this.sites.Length); i++)
				{
					ISite site = this.sites[i];
					if (site != null && site.Name != null && string.Equals(site.Name, name, StringComparison.OrdinalIgnoreCase) && site.Component != component && ((InheritanceAttribute)TypeDescriptor.GetAttributes(site.Component)[typeof(InheritanceAttribute)]).InheritanceLevel != InheritanceLevel.InheritedReadOnly)
					{
						throw new ArgumentException(SR.GetString("Duplicate component name '{0}'.  Component names must be unique and case-insensitive.", new object[]
						{
							name
						}));
					}
				}
			}
		}

		// Token: 0x04001019 RID: 4121
		private ISite[] sites;

		// Token: 0x0400101A RID: 4122
		private int siteCount;

		// Token: 0x0400101B RID: 4123
		private ComponentCollection components;

		// Token: 0x0400101C RID: 4124
		private ContainerFilterService filter;

		// Token: 0x0400101D RID: 4125
		private bool checkedFilter;

		// Token: 0x0400101E RID: 4126
		private object syncObj = new object();

		// Token: 0x02000410 RID: 1040
		private class Site : ISite, IServiceProvider
		{
			// Token: 0x0600219E RID: 8606 RVA: 0x00072F5A File Offset: 0x0007115A
			internal Site(IComponent component, Container container, string name)
			{
				this.component = component;
				this.container = container;
				this.name = name;
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x0600219F RID: 8607 RVA: 0x00072F77 File Offset: 0x00071177
			public IComponent Component
			{
				get
				{
					return this.component;
				}
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x060021A0 RID: 8608 RVA: 0x00072F7F File Offset: 0x0007117F
			public IContainer Container
			{
				get
				{
					return this.container;
				}
			}

			// Token: 0x060021A1 RID: 8609 RVA: 0x00072F87 File Offset: 0x00071187
			public object GetService(Type service)
			{
				if (!(service == typeof(ISite)))
				{
					return this.container.GetService(service);
				}
				return this;
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00003062 File Offset: 0x00001262
			public bool DesignMode
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00072FA9 File Offset: 0x000711A9
			// (set) Token: 0x060021A4 RID: 8612 RVA: 0x00072FB1 File Offset: 0x000711B1
			public string Name
			{
				get
				{
					return this.name;
				}
				set
				{
					if (value == null || this.name == null || !value.Equals(this.name))
					{
						this.container.ValidateName(this.component, value);
						this.name = value;
					}
				}
			}

			// Token: 0x0400101F RID: 4127
			private IComponent component;

			// Token: 0x04001020 RID: 4128
			private Container container;

			// Token: 0x04001021 RID: 4129
			private string name;
		}
	}
}
