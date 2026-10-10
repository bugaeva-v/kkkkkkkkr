using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IMoniker" />.</summary>
	// Token: 0x0200075C RID: 1884
	[Obsolete]
	[Guid("0000000f-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMIMoniker
	{
		/// <summary>Возвращает идентификатор класса CLSID для объекта.</summary>
		/// <param name="pClassID">При удачном возвращении содержит идентификатор класса CLSID.</param>
		// Token: 0x0600426A RID: 17002
		void GetClassID(out Guid pClassID);

		/// <summary>Проверяет наличие изменений в объекте с момента его последнего сохранения.</summary>
		/// <returns>Значение <see langword="S_OK" /><see langword="HRESULT" />, если объект был изменен; в противном случае — значение <see langword="S_FALSE" /><see langword="HRESULT" />.</returns>
		// Token: 0x0600426B RID: 17003
		[PreserveSig]
		int IsDirty();

		/// <summary>Инициализирует объект из потока, в котором он был предварительно сохранен.</summary>
		/// <param name="pStm">Поток, из которого загружается объект.</param>
		// Token: 0x0600426C RID: 17004
		void Load(UCOMIStream pStm);

		/// <summary>Сохраняет объект в указанном потоке.</summary>
		/// <param name="pStm">Поток, в котором будет сохранен объект.</param>
		/// <param name="fClearDirty">Показывает, необходима ли очистка измененного флага после сохранения.</param>
		// Token: 0x0600426D RID: 17005
		void Save(UCOMIStream pStm, [MarshalAs(UnmanagedType.Bool)] bool fClearDirty);

		/// <summary>Возвращает размер потока, необходимого для сохранения объекта, в байтах.</summary>
		/// <param name="pcbSize">При удачном возвращении содержит значение <see langword="long" />, показывающее размер потока, необходимого для сохранения объекта, в байтах.</param>
		// Token: 0x0600426E RID: 17006
		void GetSizeMax(out long pcbSize);

		/// <summary>Использует моникер для привязки к определяемому объекту.</summary>
		/// <param name="pbc">Ссылка на интерфейс <see langword="IBindCtx" /> объекта контекстной привязки, используемого в данной операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если моникер является частью составного моникера.</param>
		/// <param name="riidResult">Идентификатор интерфейса (IID), выбранного клиентом для установки соединения с объектом, который определен моникером.</param>
		/// <param name="ppvResult">При успешном возвращении — ссылка на интерфейс, запрошенный <paramref name="riidResult" />.</param>
		// Token: 0x0600426F RID: 17007
		void BindToObject(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, [In] ref Guid riidResult, [MarshalAs(UnmanagedType.Interface)] out object ppvResult);

		/// <summary>Возвращает указатель интерфейса на хранилище, в котором содержится объект, определенный моникером.</summary>
		/// <param name="pbc">Ссылка на интерфейс <see langword="IBindCtx" /> объекта контекстной привязки, используемого в процессе операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если моникер является частью составного моникера.</param>
		/// <param name="riid">Идентификатор IID запрошенного интерфейса хранилища.</param>
		/// <param name="ppvObj">При успешном возвращении — ссылка на интерфейс, запрошенный <paramref name="riid" />.</param>
		// Token: 0x06004270 RID: 17008
		void BindToStorage(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObj);

		/// <summary>Возвращает уменьшенный моникер, представляющий собой другой моникер, ссылающийся на тот же объект, но который может быть привязан с такой же или большей эффективностью.</summary>
		/// <param name="pbc">Ссылка на интерфейс <see langword="IBindCtx" /> контекста привязки, используемый в данной операции привязки.</param>
		/// <param name="dwReduceHowFar">Определяет способ уменьшения моникера.</param>
		/// <param name="ppmkToLeft">Ссылка на моникер слева от данного моникера.</param>
		/// <param name="ppmkReduced">При удачном возвращении — ссылка на уменьшенный моникер. Может равняться <see langword="null" />, если возникла ошибка или моникер уменьшен до нулевого значения.</param>
		// Token: 0x06004271 RID: 17009
		void Reduce(UCOMIBindCtx pbc, int dwReduceHowFar, ref UCOMIMoniker ppmkToLeft, out UCOMIMoniker ppmkReduced);

		/// <summary>Объединяет текущий моникер с другим, создавая составной моникер.</summary>
		/// <param name="pmkRight">Ссылка на интерфейс <see langword="IMoniker" /> моникера, для добавления в конец данного моникера.</param>
		/// <param name="fOnlyIfNotGeneric">Если значение равно <see langword="true" />, вызывающему объекту требуется нестандартное объединение. Таким образом, операция продолжается, только если <paramref name="pmkRight" /> является классом моникера, с которым данный моникер может быть объединен каким-либо способом, кроме образования универсального объединения. Если значение равно <see langword="false" />, при необходимости метод может создать универсальное объединение.</param>
		/// <param name="ppmkComposite">При успешном возвращении — ссылка на итоговый составной моникер.</param>
		// Token: 0x06004272 RID: 17010
		void ComposeWith(UCOMIMoniker pmkRight, [MarshalAs(UnmanagedType.Bool)] bool fOnlyIfNotGeneric, out UCOMIMoniker ppmkComposite);

		/// <summary>Предоставляет указатель на перечислитель, способный перечислить компоненты составного моникера.</summary>
		/// <param name="fForward">Если значение равно <see langword="true" />, моникеры перечисляются слева направо. Если значение равно <see langword="false" />, перечисление выполняется справа налево.</param>
		/// <param name="ppenumMoniker">При удачном возвращении — ссылка на объект-перечислитель моникера.</param>
		// Token: 0x06004273 RID: 17011
		void Enum([MarshalAs(UnmanagedType.Bool)] bool fForward, out UCOMIEnumMoniker ppenumMoniker);

		/// <summary>Сравнивает этот моникер с заданным моникером и показывает, совпадают ли они.</summary>
		/// <param name="pmkOtherMoniker">Ссылка на моникер, используемый для сравнения.</param>
		// Token: 0x06004274 RID: 17012
		void IsEqual(UCOMIMoniker pmkOtherMoniker);

		/// <summary>Вычисляет 32-разрядное целое число, используя внутреннее состояние моникера.</summary>
		/// <param name="pdwHash">При удачном возвращении содержит хэш-значение моникера.</param>
		// Token: 0x06004275 RID: 17013
		void Hash(out int pdwHash);

		/// <summary>Определяет, загружен и запущен ли в данный момент объект, определенный этим моникером.</summary>
		/// <param name="pbc">Ссылка на контекст привязки, используемый при выполнении данной операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если данный моникер является частью составного моникера.</param>
		/// <param name="pmkNewlyRunning">Ссылка на моникер, который был добавлен в таблицу текущих объектов самым последним.</param>
		// Token: 0x06004276 RID: 17014
		void IsRunning(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, UCOMIMoniker pmkNewlyRunning);

		/// <summary>Предоставляет число, указывающее время последнего изменения объекта, определенного этим моникером.</summary>
		/// <param name="pbc">Ссылка на контекст привязки, используемый при выполнении данной операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если моникер является частью составного моникера.</param>
		/// <param name="pFileTime">При удачном возвращении содержит время последнего изменения.</param>
		// Token: 0x06004277 RID: 17015
		void GetTimeOfLastChange(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, out FILETIME pFileTime);

		/// <summary>Предоставляет моникер, объединение которого с правой частью данного моникера или моникера с подобной структурой приводит к нулевому значению.</summary>
		/// <param name="ppmk">При успешном возвращении содержит моникер, являющийся обратным по отношению к данному моникеру.</param>
		// Token: 0x06004278 RID: 17016
		void Inverse(out UCOMIMoniker ppmk);

		/// <summary>Создает новый моникер на основании общего префикса, который данный моникер использует совместно с другим моникером.</summary>
		/// <param name="pmkOther">Ссылка на интерфейс <see langword="IMoniker" /> другого моникера, сравниваемого сравнить с данным для выявления общего префикса.</param>
		/// <param name="ppmkPrefix">При успешном возвращении содержит моникер, являющийся общим префиксом данного моникера и моникера <paramref name="pmkOther" />.</param>
		// Token: 0x06004279 RID: 17017
		void CommonPrefixWith(UCOMIMoniker pmkOther, out UCOMIMoniker ppmkPrefix);

		/// <summary>Предоставляет моникер, добавление которого к данному моникеру (или к одной из подобных структур) приводит к получению указанного моникера.</summary>
		/// <param name="pmkOther">Ссылка на моникер, для которого нужно получить относительный путь.</param>
		/// <param name="ppmkRelPath">При успешном возвращении — ссылка на относительный моникер.</param>
		// Token: 0x0600427A RID: 17018
		void RelativePathTo(UCOMIMoniker pmkOther, out UCOMIMoniker ppmkRelPath);

		/// <summary>Возвращает отображаемое имя, являющееся представлением этого моникера, удобным для чтения пользователем.</summary>
		/// <param name="pbc">Ссылка на контекст привязки, используемый в данной операции.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если моникер является частью составного моникера.</param>
		/// <param name="ppszDisplayName">При удачном возвращении содержит строку отображаемого имени.</param>
		// Token: 0x0600427B RID: 17019
		void GetDisplayName(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] out string ppszDisplayName);

		/// <summary>Считывает столько знаков указанного отображаемого имени, сколько может воспринять, и создает моникер, соответствующий считанной части.</summary>
		/// <param name="pbc">Ссылка на контекст привязки, используемый при выполнении данной операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер, созданный из отображаемого имени до данной точки.</param>
		/// <param name="pszDisplayName">Ссылка на строку, содержащую оставшуюся часть анализируемого отображаемого имени.</param>
		/// <param name="pchEaten">При удачном возвращении содержит число знаков в <paramref name="pszDisplayName" />, использованных на этом шаге.</param>
		/// <param name="ppmkOut">Ссылка на моникер, созданный из <paramref name="pszDisplayName" />.</param>
		// Token: 0x0600427C RID: 17020
		void ParseDisplayName(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] string pszDisplayName, out int pchEaten, out UCOMIMoniker ppmkOut);

		/// <summary>Показывает, является ли данный моникер одним из классов моникеров, предоставляемых системой.</summary>
		/// <param name="pdwMksys">Указатель на целое число, являющееся одним из значений перечисления <see langword="MKSYS" /> и ссылающееся на один из классов моникеров COM.</param>
		// Token: 0x0600427D RID: 17021
		void IsSystemMoniker(out int pdwMksys);
	}
}
