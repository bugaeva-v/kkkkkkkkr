using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Представляет метод обратного вызова, который вызывается при инициализации домена приложения.</summary>
	/// <param name="args">Массив строк, передаваемых в качестве аргументов методу обратного вызова.</param>
	// Token: 0x02000225 RID: 549
	// (Invoke) Token: 0x0600187E RID: 6270
	[ComVisible(true)]
	[Serializable]
	public delegate void AppDomainInitializer(string[] args);
}
