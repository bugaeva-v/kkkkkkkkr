using System;
using System.Reflection;

namespace System
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.AppDomain.TypeResolve" />, <see cref="E:System.AppDomain.ResourceResolve" /> или <see cref="E:System.AppDomain.AssemblyResolve" /> объекта <see cref="T:System.AppDomain" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="args">Данные события.</param>
	/// <returns>Сборка, разрешающая тип, сборку или ресурс; либо значение <see langword="null" />, если сборку невозможно разрешить.</returns>
	// Token: 0x02000179 RID: 377
	// (Invoke) Token: 0x06000EE6 RID: 3814
	public delegate Assembly ResolveEventHandler(object sender, ResolveEventArgs args);
}
