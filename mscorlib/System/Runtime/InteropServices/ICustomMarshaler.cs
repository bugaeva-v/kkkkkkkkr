using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет настраиваемые оболочки, обрабатывающие вызовы методов.</summary>
	// Token: 0x020006D9 RID: 1753
	public interface ICustomMarshaler
	{
		/// <summary>Преобразует неуправляемые данные в управляемые.</summary>
		/// <param name="pNativeData">Указатель на неуправляемые данные, которые необходимо инкапсулировать.</param>
		/// <returns>Объект, представляющий управляемое представление данных модели COM.</returns>
		// Token: 0x06004034 RID: 16436
		object MarshalNativeToManaged(IntPtr pNativeData);

		/// <summary>Преобразует управляемые данные в неуправляемые.</summary>
		/// <param name="ManagedObj">Управляемый объект, который необходимо преобразовать.</param>
		/// <returns>Указатель на COM-представление управляемого объекта.</returns>
		// Token: 0x06004035 RID: 16437
		IntPtr MarshalManagedToNative(object ManagedObj);

		/// <summary>Выполняет необходимую очистку неуправляемых данных, если они больше не нужны.</summary>
		/// <param name="pNativeData">Указатель на неуправляемые данные, которые необходимо уничтожить.</param>
		// Token: 0x06004036 RID: 16438
		void CleanUpNativeData(IntPtr pNativeData);

		/// <summary>Выполняет необходимую очистку управляемых данных, если они больше не нужны.</summary>
		/// <param name="ManagedObj">Управляемый объект, который необходимо уничтожить.</param>
		// Token: 0x06004037 RID: 16439
		void CleanUpManagedData(object ManagedObj);

		/// <summary>Возвращает размер собственных данных для маршалинга.</summary>
		/// <returns>Размер собственных данных в байтах.</returns>
		// Token: 0x06004038 RID: 16440
		int GetNativeDataSize();
	}
}
