using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Разрешает активацию одного или нескольких классов средой выполнения Windows.</summary>
	// Token: 0x0200078A RID: 1930
	[Guid("00000035-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IActivationFactory
	{
		/// <summary>Возвращает новый экземпляр класса Среда выполнения Windows, созданный интерфейсом <see cref="T:System.Runtime.InteropServices.WindowsRuntime.IActivationFactory" />.</summary>
		/// <returns>Новый экземпляр класса Среда выполнения Windows.</returns>
		// Token: 0x06004499 RID: 17561
		object ActivateInstance();
	}
}
