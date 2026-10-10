using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />.</summary>
	// Token: 0x0200075E RID: 1886
	[Guid("00000010-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Obsolete]
	[ComImport]
	public interface UCOMIRunningObjectTable
	{
		/// <summary>Регистрирует переход предоставленного объекта в состояние выполнения.</summary>
		/// <param name="grfFlags">Показывает, является ли ссылка таблицы текущих объектов ROT на <paramref name="punkObject" /> слабой или строгой, а также управляет доступом к объекту, используя соответствующую запись в таблице ROT.</param>
		/// <param name="punkObject">Ссылка на объект, зарегистрированный как выполняемый.</param>
		/// <param name="pmkObjectName">Ссылка на моникер, определяющий <paramref name="punkObject" />.</param>
		/// <param name="pdwRegister">Ссылка на 32-разрядное значение, используемое для определения записи в таблице ROT при последующих вызовах методов <see cref="M:System.Runtime.InteropServices.UCOMIRunningObjectTable.Revoke(System.Int32)" /> или <see cref="M:System.Runtime.InteropServices.UCOMIRunningObjectTable.NoteChangeTime(System.Int32,System.Runtime.InteropServices.FILETIME@)" />.</param>
		// Token: 0x06004284 RID: 17028
		void Register(int grfFlags, [MarshalAs(UnmanagedType.Interface)] object punkObject, UCOMIMoniker pmkObjectName, out int pdwRegister);

		/// <summary>Удаляет регистрацию указанного объекта в таблице ROT.</summary>
		/// <param name="dwRegister">Удаляемая запись в таблице ROT.</param>
		// Token: 0x06004285 RID: 17029
		void Revoke(int dwRegister);

		/// <summary>Определяет, зарегистрирован ли заданный моникер имя в таблице текущих объектов ROT.</summary>
		/// <param name="pmkObjectName">Ссылка на моникер, используемый для поиска в таблице ROT.</param>
		// Token: 0x06004286 RID: 17030
		void IsRunning(UCOMIMoniker pmkObjectName);

		/// <summary>Возвращает зарегистрированный объект, если предоставленное имя объекта зарегистрировано как выполняемое.</summary>
		/// <param name="pmkObjectName">Ссылка на моникер, используемый для поиска в таблице ROT.</param>
		/// <param name="ppunkObject">При удачном возвращении содержит запрошенный выполняемый объект.</param>
		// Token: 0x06004287 RID: 17031
		void GetObject(UCOMIMoniker pmkObjectName, [MarshalAs(UnmanagedType.Interface)] out object ppunkObject);

		/// <summary>Выполняет запись времени изменения определенного объекта, чтобы <see langword="IMoniker::GetTimeOfLastChange" /> мог сообщить о времени внесения изменений.</summary>
		/// <param name="dwRegister">Запись в таблице текущих объектов ROT для измененного объекта.</param>
		/// <param name="pfiletime">Ссылка на время последнего изменения объекта.</param>
		// Token: 0x06004288 RID: 17032
		void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);

		/// <summary>Выполняет поиск этого моникера в таблице ROT и сообщает записанное время изменения, если моникер найден.</summary>
		/// <param name="pmkObjectName">Ссылка на моникер, используемый для поиска в таблице ROT.</param>
		/// <param name="pfiletime">При удачном возвращении содержит время последнего изменения объектов.</param>
		// Token: 0x06004289 RID: 17033
		void GetTimeOfLastChange(UCOMIMoniker pmkObjectName, out FILETIME pfiletime);

		/// <summary>Перечисляет объекты, зарегистрированные в данный момент как запущенные.</summary>
		/// <param name="ppenumMoniker">При удачном возвращении — новый перечислитель для таблицы текущих объектов ROT.</param>
		// Token: 0x0600428A RID: 17034
		void EnumRunning(out UCOMIEnumMoniker ppenumMoniker);
	}
}
