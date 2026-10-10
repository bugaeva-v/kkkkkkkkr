using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Activation
{
	/// <summary>Представляет запрос вызова конструкции объекта.</summary>
	// Token: 0x020005D1 RID: 1489
	[ComVisible(true)]
	public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage
	{
		/// <summary>Возвращает тип удаленного объекта, подлежащего активации.</summary>
		/// <returns>Тип удаленного объекта, подлежащего активации.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060038DB RID: 14555
		Type ActivationType { get; }

		/// <summary>Получает полное имя типа удаленного типа, подлежащего активации.</summary>
		/// <returns>Полное имя типа удаленного типа, подлежащего активации.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060038DC RID: 14556
		string ActivationTypeName { get; }

		/// <summary>Получает или задает активатор, который активирует удаленные объекты.</summary>
		/// <returns>Активатор, который активирует удаленные объекты.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060038DD RID: 14557
		// (set) Token: 0x060038DE RID: 14558
		IActivator Activator { get; set; }

		/// <summary>Получает атрибуты активации веб-узла вызова.</summary>
		/// <returns>Атрибуты активации веб-узла вызова.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060038DF RID: 14559
		object[] CallSiteActivationAttributes { get; }

		/// <summary>Получает список контекстных свойств, которые определяют контекст, в котором создается объект.</summary>
		/// <returns>Список свойств контекста, в котором конструируется объект.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060038E0 RID: 14560
		IList ContextProperties { get; }
	}
}
