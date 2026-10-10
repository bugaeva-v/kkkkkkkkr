using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет простую реализацию интерфейса <see cref="T:System.ComponentModel.Design.IServiceContainer" />. Этот класс не наследуется.</summary>
	// Token: 0x02000472 RID: 1138
	public class ServiceContainer : IServiceContainer, IServiceProvider, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.ServiceContainer" />.</summary>
		// Token: 0x0600249E RID: 9374 RVA: 0x0000219B File Offset: 0x0000039B
		public ServiceContainer()
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.ComponentModel.Design.ServiceContainer" /> с использованием указанного родительского поставщика службы.</summary>
		/// <param name="parentProvider">Родительский поставщик службы.</param>
		// Token: 0x0600249F RID: 9375 RVA: 0x00081AF9 File Offset: 0x0007FCF9
		public ServiceContainer(IServiceProvider parentProvider)
		{
			this._parentProvider = parentProvider;
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x00081B08 File Offset: 0x0007FD08
		private IServiceContainer Container
		{
			get
			{
				IServiceContainer result = null;
				if (this._parentProvider != null)
				{
					result = (IServiceContainer)this._parentProvider.GetService(typeof(IServiceContainer));
				}
				return result;
			}
		}

		/// <summary>Возвращает службы по умолчанию, реализованные непосредственно классом <see cref="T:System.ComponentModel.Design.ServiceContainer" />.</summary>
		/// <returns>Службы по умолчанию.</returns>
		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x00081B3B File Offset: 0x0007FD3B
		protected virtual Type[] DefaultServices
		{
			get
			{
				return ServiceContainer.s_defaultServices;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x00081B44 File Offset: 0x0007FD44
		private ServiceContainer.ServiceCollection<object> Services
		{
			get
			{
				ServiceContainer.ServiceCollection<object> result;
				if ((result = this._services) == null)
				{
					result = (this._services = new ServiceContainer.ServiceCollection<object>());
				}
				return result;
			}
		}

		/// <summary>Добавляет заданную службу в контейнер служб.</summary>
		/// <param name="serviceType">Тип добавляемой службы.</param>
		/// <param name="serviceInstance">Экземпляр добавляемой службы. Данный объект должен реализовывать или наследовать тип, определяемый параметром <paramref name="serviceType" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="serviceType" /> или <paramref name="serviceInstance" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В контейнере уже присутствует служба с типом <paramref name="serviceType" />.</exception>
		// Token: 0x060024A3 RID: 9379 RVA: 0x00081B69 File Offset: 0x0007FD69
		public void AddService(Type serviceType, object serviceInstance)
		{
			this.AddService(serviceType, serviceInstance, false);
		}

		/// <summary>Добавляет заданную службу в контейнер служб.</summary>
		/// <param name="serviceType">Тип добавляемой службы.</param>
		/// <param name="serviceInstance">Экземпляр добавляемого типа службы. Данный объект должен реализовывать или наследовать тип, определяемый параметром <paramref name="serviceType" />.</param>
		/// <param name="promote">Значение <see langword="true" />, если эту службу следует добавить в любой родительский контейнер служб; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="serviceType" /> или <paramref name="serviceInstance" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В контейнере уже присутствует служба с типом <paramref name="serviceType" />.</exception>
		// Token: 0x060024A4 RID: 9380 RVA: 0x00081B74 File Offset: 0x0007FD74
		public virtual void AddService(Type serviceType, object serviceInstance, bool promote)
		{
			if (promote)
			{
				IServiceContainer container = this.Container;
				if (container != null)
				{
					container.AddService(serviceType, serviceInstance, promote);
					return;
				}
			}
			if (serviceType == null)
			{
				throw new ArgumentNullException("serviceType");
			}
			if (serviceInstance == null)
			{
				throw new ArgumentNullException("serviceInstance");
			}
			if (!(serviceInstance is ServiceCreatorCallback) && !serviceInstance.GetType().IsCOMObject && !serviceType.IsInstanceOfType(serviceInstance))
			{
				throw new ArgumentException(SR.Format("The service instance must derive from or implement {0}.", serviceType.FullName));
			}
			if (this.Services.ContainsKey(serviceType))
			{
				throw new ArgumentException(SR.Format("The service {0} already exists in the service container.", serviceType.FullName), "serviceType");
			}
			this.Services[serviceType] = serviceInstance;
		}

		/// <summary>Добавляет заданную службу в контейнер служб.</summary>
		/// <param name="serviceType">Тип добавляемой службы.</param>
		/// <param name="callback">Объект обратного вызова, создающий службу. Это позволяет объявить службу как доступную, однако создание объекта откладывается до запроса службы.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="serviceType" /> или <paramref name="callback" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В контейнере уже присутствует служба с типом <paramref name="serviceType" />.</exception>
		// Token: 0x060024A5 RID: 9381 RVA: 0x00081C24 File Offset: 0x0007FE24
		public void AddService(Type serviceType, ServiceCreatorCallback callback)
		{
			this.AddService(serviceType, callback, false);
		}

		/// <summary>Добавляет заданную службу в контейнер служб.</summary>
		/// <param name="serviceType">Тип добавляемой службы.</param>
		/// <param name="callback">Объект обратного вызова, создающий службу. Это позволяет объявить службу как доступную, однако создание объекта откладывается до запроса службы.</param>
		/// <param name="promote">Значение <see langword="true" />, если эту службу следует добавить в любой родительский контейнер служб; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="serviceType" /> или <paramref name="callback" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В контейнере уже присутствует служба с типом <paramref name="serviceType" />.</exception>
		// Token: 0x060024A6 RID: 9382 RVA: 0x00081C30 File Offset: 0x0007FE30
		public virtual void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote)
		{
			if (promote)
			{
				IServiceContainer container = this.Container;
				if (container != null)
				{
					container.AddService(serviceType, callback, promote);
					return;
				}
			}
			if (serviceType == null)
			{
				throw new ArgumentNullException("serviceType");
			}
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			if (this.Services.ContainsKey(serviceType))
			{
				throw new ArgumentException(SR.Format("The service {0} already exists in the service container.", serviceType.FullName), "serviceType");
			}
			this.Services[serviceType] = callback;
		}

		/// <summary>Удаляет данный контейнер служб.</summary>
		// Token: 0x060024A7 RID: 9383 RVA: 0x00081CAC File Offset: 0x0007FEAC
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Удаляет данный контейнер служб.</summary>
		/// <param name="disposing">Значение <see langword="true" />, если объект <see cref="T:System.ComponentModel.Design.ServiceContainer" /> находится в процессе удаления; в обратном случае — значение <see langword="false" />.</param>
		// Token: 0x060024A8 RID: 9384 RVA: 0x00081CB8 File Offset: 0x0007FEB8
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				ServiceContainer.ServiceCollection<object> services = this._services;
				this._services = null;
				if (services != null)
				{
					foreach (object obj in services.Values)
					{
						if (obj is IDisposable)
						{
							((IDisposable)obj).Dispose();
						}
					}
				}
			}
		}

		/// <summary>Возвращает запрашиваемую службу.</summary>
		/// <param name="serviceType">Тип возвращаемой службы.</param>
		/// <returns>Экземпляр службы, если ее удалось найти, в обратном случае — значение <see langword="null" />.</returns>
		// Token: 0x060024A9 RID: 9385 RVA: 0x00081D2C File Offset: 0x0007FF2C
		public virtual object GetService(Type serviceType)
		{
			object obj = null;
			Type[] defaultServices = this.DefaultServices;
			for (int i = 0; i < defaultServices.Length; i++)
			{
				if (serviceType.IsEquivalentTo(defaultServices[i]))
				{
					obj = this;
					break;
				}
			}
			if (obj == null)
			{
				this.Services.TryGetValue(serviceType, out obj);
			}
			if (obj is ServiceCreatorCallback)
			{
				obj = ((ServiceCreatorCallback)obj)(this, serviceType);
				if (obj != null && !obj.GetType().IsCOMObject && !serviceType.IsInstanceOfType(obj))
				{
					obj = null;
				}
				this.Services[serviceType] = obj;
			}
			if (obj == null && this._parentProvider != null)
			{
				obj = this._parentProvider.GetService(serviceType);
			}
			return obj;
		}

		/// <summary>Удаляет службы указанного типа из контейнера служб.</summary>
		/// <param name="serviceType">Тип удаляемой службы.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serviceType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060024AA RID: 9386 RVA: 0x00081DC8 File Offset: 0x0007FFC8
		public void RemoveService(Type serviceType)
		{
			this.RemoveService(serviceType, false);
		}

		/// <summary>Удаляет службы указанного типа из контейнера служб.</summary>
		/// <param name="serviceType">Тип удаляемой службы.</param>
		/// <param name="promote">Значение <see langword="true" />, если эту службу следует удалить из любого родительского контейнера служб; в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serviceType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060024AB RID: 9387 RVA: 0x00081DD4 File Offset: 0x0007FFD4
		public virtual void RemoveService(Type serviceType, bool promote)
		{
			if (promote)
			{
				IServiceContainer container = this.Container;
				if (container != null)
				{
					container.RemoveService(serviceType, promote);
					return;
				}
			}
			if (serviceType == null)
			{
				throw new ArgumentNullException("serviceType");
			}
			this.Services.Remove(serviceType);
		}

		// Token: 0x040010E6 RID: 4326
		private ServiceContainer.ServiceCollection<object> _services;

		// Token: 0x040010E7 RID: 4327
		private IServiceProvider _parentProvider;

		// Token: 0x040010E8 RID: 4328
		private static Type[] s_defaultServices = new Type[]
		{
			typeof(IServiceContainer),
			typeof(ServiceContainer)
		};

		// Token: 0x040010E9 RID: 4329
		private static TraceSwitch s_TRACESERVICE = new TraceSwitch("TRACESERVICE", "ServiceProvider: Trace service provider requests.");

		// Token: 0x02000473 RID: 1139
		private sealed class ServiceCollection<T> : Dictionary<Type, T>
		{
			// Token: 0x060024AD RID: 9389 RVA: 0x00081E53 File Offset: 0x00080053
			public ServiceCollection() : base(ServiceContainer.ServiceCollection<T>.s_serviceTypeComparer)
			{
			}

			// Token: 0x040010EA RID: 4330
			private static ServiceContainer.ServiceCollection<T>.EmbeddedTypeAwareTypeComparer s_serviceTypeComparer = new ServiceContainer.ServiceCollection<T>.EmbeddedTypeAwareTypeComparer();

			// Token: 0x02000474 RID: 1140
			private sealed class EmbeddedTypeAwareTypeComparer : IEqualityComparer<Type>
			{
				// Token: 0x060024AF RID: 9391 RVA: 0x00081E6C File Offset: 0x0008006C
				public bool Equals(Type x, Type y)
				{
					return x.IsEquivalentTo(y);
				}

				// Token: 0x060024B0 RID: 9392 RVA: 0x00081E75 File Offset: 0x00080075
				public int GetHashCode(Type obj)
				{
					return obj.FullName.GetHashCode();
				}
			}
		}
	}
}
