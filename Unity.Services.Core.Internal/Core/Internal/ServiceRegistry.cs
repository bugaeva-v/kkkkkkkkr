using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000050 RID: 80
	internal class ServiceRegistry : IServiceRegistry
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00003993 File Offset: 0x00001B93
		[NotNull]
		internal Dictionary<int, object> ServiceTypeHashToInstance { get; }

		// Token: 0x0600015A RID: 346 RVA: 0x0000399B File Offset: 0x00001B9B
		public ServiceRegistry()
		{
			this.ServiceTypeHashToInstance = new Dictionary<int, object>();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000039AE File Offset: 0x00001BAE
		public ServiceRegistry([NotNull] Dictionary<int, object> serviceTypeHashToInstance)
		{
			this.ServiceTypeHashToInstance = serviceTypeHashToInstance;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000039C0 File Offset: 0x00001BC0
		public void RegisterService<T>(T service)
		{
			Type typeFromHandle = typeof(T);
			if (service.GetType() == typeFromHandle)
			{
				throw new ArgumentException("Interface type of service not specified.");
			}
			int hashCode = typeFromHandle.GetHashCode();
			this.ServiceTypeHashToInstance[hashCode] = service;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00003A14 File Offset: 0x00001C14
		public T GetService<T>()
		{
			Type typeFromHandle = typeof(T);
			object obj;
			if (!this.ServiceTypeHashToInstance.TryGetValue(typeFromHandle.GetHashCode(), out obj))
			{
				return default(T);
			}
			return (T)((object)obj);
		}
	}
}
