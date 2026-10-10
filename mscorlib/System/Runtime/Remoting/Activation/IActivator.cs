using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Activation
{
	/// <summary>Обеспечивает базовые функциональные возможности для класса активатора удаленного взаимодействия.</summary>
	// Token: 0x020005D0 RID: 1488
	[ComVisible(true)]
	public interface IActivator
	{
		/// <summary>Получает объект <see cref="T:System.Runtime.Remoting.Activation.ActivatorLevel" />, где действует этот активатор.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Activation.ActivatorLevel" />, где действует этот активатор.</returns>
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060038D7 RID: 14551
		ActivatorLevel Level { get; }

		/// <summary>Возвращает или задает следующий активатор в цепи.</summary>
		/// <returns>Следующий активатор в цепи.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060038D8 RID: 14552
		// (set) Token: 0x060038D9 RID: 14553
		IActivator NextActivator { get; set; }

		/// <summary>Создает экземпляр объекта, указанного в предоставленном <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary>
		/// <param name="msg">Сведения об объекте, необходимые для его активации, хранятся в <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</param>
		/// <returns>Состояние активации объекта, содержащегося в <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060038DA RID: 14554
		IConstructionReturnMessage Activate(IConstructionCallMessage msg);
	}
}
