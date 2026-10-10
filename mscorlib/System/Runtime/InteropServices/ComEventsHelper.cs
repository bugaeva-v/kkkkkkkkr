using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет методы, активирующие делегаты .NET Framework для обработки событий, которые нужно добавить или удалить из объектов COM.</summary>
	// Token: 0x0200073A RID: 1850
	public static class ComEventsHelper
	{
		/// <summary>Добавляет делегат в список вызова источника событий, поступающих из COM-объекта.</summary>
		/// <param name="rcw">COM-объект, инициирующий события, на которые вызывающему объекту требуется реагировать.</param>
		/// <param name="iid">Идентификатор исходного интерфейса, с помощью которого COM-объект инициирует события.</param>
		/// <param name="dispid">Идентификатор диспетчеризации метода исходного интерфейса.</param>
		/// <param name="d">Делегат, вызываемый при срабатывании события COM.</param>
		// Token: 0x0600411C RID: 16668 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static void Combine(object rcw, Guid iid, int dispid, Delegate d)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет делегат из списка вызова событий, поступающих от COM-объекта.</summary>
		/// <param name="rcw">COM-объект, к которому прикреплен делегат.</param>
		/// <param name="iid">Идентификатор исходного интерфейса, с помощью которого COM-объект инициирует события.</param>
		/// <param name="dispid">Идентификатор диспетчеризации метода исходного интерфейса.</param>
		/// <param name="d">Делегат, удаляемый из списка вызова.</param>
		/// <returns>Делегат, удаленный из списка вызова.</returns>
		// Token: 0x0600411D RID: 16669 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static Delegate Remove(object rcw, Guid iid, int dispid, Delegate d)
		{
			throw new NotImplementedException();
		}
	}
}
