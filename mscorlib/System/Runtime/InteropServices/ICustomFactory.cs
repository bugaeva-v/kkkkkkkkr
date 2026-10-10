using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Позволяет пользователям создавать код активизации для управляемых объектов, расширяющих <see cref="T:System.MarshalByRefObject" />,.</summary>
	// Token: 0x020006D8 RID: 1752
	public interface ICustomFactory
	{
		/// <summary>Создает новый экземпляр заданного типа.</summary>
		/// <param name="serverType">Активируемый тип.</param>
		/// <returns>Поставщик <see cref="T:System.MarshalByRefObject" />, связанный с указанным типом.</returns>
		// Token: 0x06004033 RID: 16435
		MarshalByRefObject CreateInstance(Type serverType);
	}
}
