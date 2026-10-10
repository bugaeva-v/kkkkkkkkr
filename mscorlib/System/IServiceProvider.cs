using System;

namespace System
{
	/// <summary>Определяет механизм извлечения объекта обслуживания (объекта, обеспечивающего настраиваемую поддержку других объектов).</summary>
	// Token: 0x020001BB RID: 443
	public interface IServiceProvider
	{
		/// <summary>Возвращает объект обслуживания указанного типа.</summary>
		/// <param name="serviceType">Объект, определяющий тип объекта обслуживания, который необходимо получить.</param>
		/// <returns>Объект обслуживания типа <paramref name="serviceType" />.  
		/// -или- 
		///  <see langword="null" />, если объекта обслуживания типа <paramref name="serviceType" /> не существует.</returns>
		// Token: 0x0600132F RID: 4911
		object GetService(Type serviceType);
	}
}
