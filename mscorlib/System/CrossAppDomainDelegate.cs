using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Используется методом <see cref="M:System.AppDomain.DoCallBack(System.CrossAppDomainDelegate)" /> для вызовов между различными доменами приложения.</summary>
	// Token: 0x02000230 RID: 560
	// (Invoke) Token: 0x06001996 RID: 6550
	[ComVisible(true)]
	public delegate void CrossAppDomainDelegate();
}
