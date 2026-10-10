using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IRunningObjectTable" />.</summary>
	// Token: 0x020007AD RID: 1965
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00000010-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IRunningObjectTable
	{
		/// <summary>Регистрирует переход предоставленного объекта в состояние выполнения.</summary>
		/// <param name="grfFlags">Показывает, является ли ссылка таблицы текущих объектов ROT на <paramref name="punkObject" /> слабой или строгой, а также управляет доступом к объекту, используя соответствующую запись в таблице ROT.</param>
		/// <param name="punkObject">Ссылка на объект, зарегистрированный как выполняемый.</param>
		/// <param name="pmkObjectName">Ссылка на моникер, определяющий <paramref name="punkObject" />.</param>
		/// <returns>Значение, которое можно использовать для определения записи в таблице ROT при последующих вызовах метода <see cref="M:System.Runtime.InteropServices.ComTypes.IRunningObjectTable.Revoke(System.Int32)" /> или <see cref="M:System.Runtime.InteropServices.ComTypes.IRunningObjectTable.NoteChangeTime(System.Int32,System.Runtime.InteropServices.ComTypes.FILETIME@)" />.</returns>
		// Token: 0x06004547 RID: 17735
		int Register(int grfFlags, [MarshalAs(UnmanagedType.Interface)] object punkObject, IMoniker pmkObjectName);

		/// <summary>Удаляет регистрацию заданного объекта из таблицы текущих объектов (ROT).</summary>
		/// <param name="dwRegister">Удаляемая запись в таблице текущих объектов (ROT).</param>
		// Token: 0x06004548 RID: 17736
		void Revoke(int dwRegister);

		/// <summary>Определяет, зарегистрирован ли заданный моникер в таблице текущих объектов (ROT).</summary>
		/// <param name="pmkObjectName">Ссылка на моникер, используемый для поиска в таблице текущих объектов (ROT).</param>
		/// <returns>Значение <see langword="HRESULT" />, показывающее успешное или неуспешное выполнение операции.</returns>
		// Token: 0x06004549 RID: 17737
		[PreserveSig]
		int IsRunning(IMoniker pmkObjectName);

		/// <summary>Возвращает зарегистрированный объект, если предоставленное имя объекта зарегистрировано как выполняемое.</summary>
		/// <param name="pmkObjectName">Ссылка на моникер, используемый для поиска в таблице текущих объектов (ROT).</param>
		/// <param name="ppunkObject">При возвращении данного метода содержит запрошенный выполняемый объект. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="HRESULT" />, показывающее успешное или неуспешное выполнение операции.</returns>
		// Token: 0x0600454A RID: 17738
		[PreserveSig]
		int GetObject(IMoniker pmkObjectName, [MarshalAs(UnmanagedType.Interface)] out object ppunkObject);

		/// <summary>Записывает время изменения определенного объекта, чтобы <see langword="IMoniker::GetTimeOfLastChange" /> мог сообщить о времени внесения изменений.</summary>
		/// <param name="dwRegister">Запись измененного объекта в таблице текущих объектов (ROT).</param>
		/// <param name="pfiletime">Ссылка на время последнего изменения объекта.</param>
		// Token: 0x0600454B RID: 17739
		void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);

		/// <summary>Выполняет поиск этого моникера в таблице текущих объектов (ROT) и сообщает записанное время изменения, если моникер найден.</summary>
		/// <param name="pmkObjectName">Ссылка на моникер, используемый для поиска в таблице текущих объектов (ROT).</param>
		/// <param name="pfiletime">При возвращении данного объекта содержит время последнего изменения объекта. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="HRESULT" />, показывающее успешное или неуспешное выполнение операции.</returns>
		// Token: 0x0600454C RID: 17740
		[PreserveSig]
		int GetTimeOfLastChange(IMoniker pmkObjectName, out FILETIME pfiletime);

		/// <summary>Перечисляет объекты, зарегистрированные в данный момент как запущенные.</summary>
		/// <param name="ppenumMoniker">При возвращении данного метода содержит новый перечислитель для таблицы текущих объектов (ROT). Этот параметр передается неинициализированным.</param>
		// Token: 0x0600454D RID: 17741
		void EnumRunning(out IEnumMoniker ppenumMoniker);
	}
}
