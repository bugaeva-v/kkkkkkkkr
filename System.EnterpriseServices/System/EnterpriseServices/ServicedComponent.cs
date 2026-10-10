using System;

namespace System.EnterpriseServices
{
	/// <summary>Представляет базовый класс для всех классов, используя службы COM+.</summary>
	// Token: 0x02000048 RID: 72
	[Serializable]
	public abstract class ServicedComponent : ContextBoundObject, IDisposable, IRemoteDispatch, IServicedComponentInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ServicedComponent" />.</summary>
		// Token: 0x0600012F RID: 303 RVA: 0x000025AD File Offset: 0x000007AD
		public ServicedComponent()
		{
		}

		/// <summary>Вызывается инфраструктурой при создании объекта или его выделении из пула. Чтобы добавить для объектов пользовательский код инициализации, следует переопределить этот метод.</summary>
		// Token: 0x06000130 RID: 304 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		protected internal virtual void Activate()
		{
			throw new NotImplementedException();
		}

		/// <summary>Этот метод вызывается инфраструктурой перед возвращением объекта в пул. Чтобы иметь возможность выбрать, возвращать объект в пул или нет, следует переопределить этот метод.</summary>
		/// <returns>Значение <see langword="true" />, если компонент служб может быть помещен в пул; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000131 RID: 305 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		protected internal virtual bool CanBePooled()
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается инфраструктурой сразу после вызова конструктора при передаче строки конструктора. Чтобы сделать возможным использование значения строки конструирования, следует переопределить этот метод.</summary>
		/// <param name="s">Строка конструирования.</param>
		// Token: 0x06000132 RID: 306 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		protected internal virtual void Construct(string s)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается инфраструктурой перед тем, как объект будет отключен. Этот метод следует переопределить для добавления в объекты пользовательского кода завершения при использовании JIT-скомпилированного кода или пула объектов.</summary>
		// Token: 0x06000133 RID: 307 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		protected internal virtual void Deactivate()
		{
			throw new NotImplementedException();
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.EnterpriseServices.ServicedComponent" />.</summary>
		// Token: 0x06000134 RID: 308 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void Dispose()
		{
			throw new NotImplementedException();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.EnterpriseServices.ServicedComponent" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x06000135 RID: 309 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		protected virtual void Dispose(bool disposing)
		{
			throw new NotImplementedException();
		}

		/// <summary>Завершает объект и удаляет соответствующую ссылку COM+.</summary>
		/// <param name="sc">Удаляемый объект.</param>
		// Token: 0x06000136 RID: 310 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static void DisposeObject(ServicedComponent sc)
		{
			throw new NotImplementedException();
		}

		/// <summary>Гарантирует, что в контексте COM+ для объекта класса <see cref="T:System.EnterpriseServices.ServicedComponent" /> бит <see langword="done" /> устанавливается в значение <see langword="true" /> после удаленного вызова метода.</summary>
		/// <param name="s">Строка, преобразуемая в объект запроса, который реализует интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />.</param>
		/// <returns>Строка, преобразованная из объекта запроса, реализующего интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" />.</returns>
		// Token: 0x06000137 RID: 311 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		string IRemoteDispatch.RemoteDispatchAutoDone(string s)
		{
			throw new NotImplementedException();
		}

		/// <summary>Не гарантирует, что в контексте COM+ для объекта класса <see cref="T:System.EnterpriseServices.ServicedComponent" /> для бита <see langword="done" /> устанавливается значение <see langword="true" /> после удаленного вызова метода.</summary>
		/// <param name="s">Строка, преобразуемая в объект запроса, который реализует интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />.</param>
		/// <returns>Строка, преобразованная из объекта запроса, реализующего интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" />.</returns>
		// Token: 0x06000138 RID: 312 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		string IRemoteDispatch.RemoteDispatchNotAutoDone(string s)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает определенную информацию об экземпляре класса <see cref="T:System.EnterpriseServices.ServicedComponent" />.</summary>
		/// <param name="infoMask">Битовая маска, где 0x00000001 — ключ для идентификатора обслуживаемого компонента, 0x00000002 — ключ для идентификатора домена приложения, а 0x00000004 — ключ для удаленного URI обслуживаемого компонента.</param>
		/// <param name="infoArray">Строковый массив, который может содержать любые или все из следующих элементов: идентификатор процесса обслуживаемого компонента, идентификатор домена приложения и удаленный URI обслуживаемого компонента.</param>
		// Token: 0x06000139 RID: 313 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		void IServicedComponentInfo.GetComponentInfo(ref int infoMask, out string[] infoArray)
		{
			throw new NotImplementedException();
		}
	}
}
