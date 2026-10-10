using System;

namespace System.ComponentModel
{
	/// <summary>Определяет интерфейс для расширения свойств других компонентов в контейнере.</summary>
	// Token: 0x020003B5 RID: 949
	public interface IExtenderProvider
	{
		/// <summary>Определяет, может ли этот объект предоставить имеющиеся у него свойства средств расширения указанному объекту.</summary>
		/// <param name="extendee">Объект <see cref="T:System.Object" />, получающий свойства средства расширения.</param>
		/// <returns>Значение <see langword="true" />, если этот объект может предоставлять свойства средства расширения указанному объекту. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F12 RID: 7954
		bool CanExtend(object extendee);
	}
}
