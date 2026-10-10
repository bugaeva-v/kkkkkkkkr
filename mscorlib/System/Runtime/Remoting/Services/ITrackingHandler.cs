using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Services
{
	/// <summary>Указывает, что реализующий объект должен быть уведомлен о маршалинге, распаковке и отключении объектов и прокси инфраструктурой удаленного взаимодействия.</summary>
	// Token: 0x0200057C RID: 1404
	[ComVisible(true)]
	public interface ITrackingHandler
	{
		/// <summary>Уведомляет текущий экземпляр об отсоединении объекта от его прокси.</summary>
		/// <param name="obj">Отсоединенный объект.</param>
		// Token: 0x0600370B RID: 14091
		void DisconnectedObject(object obj);

		/// <summary>Уведомляет текущий экземпляр о проведенном маршалинге объекта.</summary>
		/// <param name="obj">Маршалированный объект.</param>
		/// <param name="or">
		///   <see cref="T:System.Runtime.Remoting.ObjRef" />, являющаяся результатом операции маршалинга и представляющая заданный объект.</param>
		// Token: 0x0600370C RID: 14092
		void MarshaledObject(object obj, ObjRef or);

		/// <summary>Уведомляет текущий экземпляр о проведенном маршалинге объекта.</summary>
		/// <param name="obj">Распакованный объект.</param>
		/// <param name="or">
		///   <see cref="T:System.Runtime.Remoting.ObjRef" />, представляющий заданный объект.</param>
		// Token: 0x0600370D RID: 14093
		void UnmarshaledObject(object obj, ObjRef or);
	}
}
