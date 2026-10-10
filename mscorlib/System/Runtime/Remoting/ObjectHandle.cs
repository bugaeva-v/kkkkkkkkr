using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Сворачивает ссылки объектов, маршалированных по значениям, разрешая их возвращение через косвенное обращение.</summary>
	// Token: 0x02000564 RID: 1380
	[ClassInterface(ClassInterfaceType.AutoDual)]
	[ComVisible(true)]
	public class ObjectHandle : MarshalByRefObject, IObjectHandle
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.ObjectHandle" />, сворачивая данный объект <paramref name="o" />.</summary>
		/// <param name="o">Объект, свернутый новым обработчиком <see cref="T:System.Runtime.Remoting.ObjectHandle" />.</param>
		// Token: 0x0600361F RID: 13855 RVA: 0x000C2ADD File Offset: 0x000C0CDD
		public ObjectHandle(object o)
		{
			this._wrapped = o;
		}

		/// <summary>Инициализирует пожизненную аренду свернутого объекта.</summary>
		/// <returns>Инициализированная <see cref="T:System.Runtime.Remoting.Lifetime.ILease" />, разрешающая контроль времени жизни свернутого объекта.</returns>
		// Token: 0x06003620 RID: 13856 RVA: 0x000C2AEC File Offset: 0x000C0CEC
		public override object InitializeLifetimeService()
		{
			return base.InitializeLifetimeService();
		}

		/// <summary>Возвращает свернутый объект.</summary>
		/// <returns>Инкапсулированный в обертку объект.</returns>
		// Token: 0x06003621 RID: 13857 RVA: 0x000C2AF4 File Offset: 0x000C0CF4
		public object Unwrap()
		{
			return this._wrapped;
		}

		// Token: 0x0400252C RID: 9516
		private object _wrapped;
	}
}
