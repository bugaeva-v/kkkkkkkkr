using System;

namespace Castle.DynamicProxy
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class InvalidProxyConstructorArgumentsException : ArgumentException
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00002E61 File Offset: 0x00001061
		public InvalidProxyConstructorArgumentsException(string message, Type proxyType, Type classToProxy) : base(message)
		{
			this.ProxyType = proxyType;
			this.ClassToProxy = classToProxy;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002E78 File Offset: 0x00001078
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002E80 File Offset: 0x00001080
		public Type ClassToProxy { get; private set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002E89 File Offset: 0x00001089
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002E91 File Offset: 0x00001091
		public Type ProxyType { get; private set; }
	}
}
