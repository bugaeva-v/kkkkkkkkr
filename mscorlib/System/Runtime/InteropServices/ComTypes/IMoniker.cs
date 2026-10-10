using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IMoniker" /> с функциональной возможностью COM из <see langword="IPersist" /> и <see langword="IPersistStream" />.</summary>
	// Token: 0x020007AA RID: 1962
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000000f-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IMoniker
	{
		/// <summary>Возвращает идентификатор класса CLSID для объекта.</summary>
		/// <param name="pClassID">При возвращении этого метода содержит CLSID. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004521 RID: 17697
		void GetClassID(out Guid pClassID);

		/// <summary>Проверяет наличие изменений в объекте с момента его последнего сохранения.</summary>
		/// <returns>Значение <see langword="S_OK" /><see langword="HRESULT" />, если объект был изменен; в противном случае — значение <see langword="S_FALSE" /><see langword="HRESULT" />.</returns>
		// Token: 0x06004522 RID: 17698
		[PreserveSig]
		int IsDirty();

		/// <summary>Инициализирует объект из потока, в котором он был предварительно сохранен.</summary>
		/// <param name="pStm">Поток, из которого загружается объект.</param>
		// Token: 0x06004523 RID: 17699
		void Load(IStream pStm);

		/// <summary>Сохраняет объект в указанном потоке.</summary>
		/// <param name="pStm">Поток, в котором будет сохранен объект.</param>
		/// <param name="fClearDirty">Значение <see langword="true" /> показывает, что необходима очистка измененного флага после сохранения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06004524 RID: 17700
		void Save(IStream pStm, [MarshalAs(UnmanagedType.Bool)] bool fClearDirty);

		/// <summary>Возвращает размер потока, необходимого для сохранения объекта, в байтах.</summary>
		/// <param name="pcbSize">При возвращении данного метода содержит значение <see langword="long" />, показывающее размер потока, необходимого для сохранения объекта, в байтах. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004525 RID: 17701
		void GetSizeMax(out long pcbSize);

		/// <summary>Использует моникер для привязки к определяемому объекту.</summary>
		/// <param name="pbc">Ссылка на интерфейс <see langword="IBindCtx" /> объекта контекстной привязки, используемого в данной операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если моникер является частью составного моникера.</param>
		/// <param name="riidResult">Идентификатор интерфейса (IID), выбранного клиентом для установки соединения с объектом, который определен моникером.</param>
		/// <param name="ppvResult">При возвращении данного метода содержит ссылку на интерфейс, запрошенный <paramref name="riidResult" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004526 RID: 17702
		void BindToObject(IBindCtx pbc, IMoniker pmkToLeft, [In] ref Guid riidResult, [MarshalAs(UnmanagedType.Interface)] out object ppvResult);

		/// <summary>Возвращает указатель интерфейса на хранилище, в котором содержится объект, определенный моникером.</summary>
		/// <param name="pbc">Ссылка на интерфейс <see langword="IBindCtx" /> объекта контекстной привязки, используемого в процессе операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если моникер является частью составного моникера.</param>
		/// <param name="riid">Идентификатор IID запрошенного интерфейса хранилища.</param>
		/// <param name="ppvObj">При возвращении данного метода содержит ссылку на интерфейс, запрошенный <paramref name="riid" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004527 RID: 17703
		void BindToStorage(IBindCtx pbc, IMoniker pmkToLeft, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObj);

		/// <summary>Возвращает уменьшенный моникер, представляющий собой другой моникер, ссылающийся на тот же объект, но который может быть привязан с такой же или большей эффективностью.</summary>
		/// <param name="pbc">Ссылка на интерфейс <see langword="IBindCtx" /> контекста привязки, используемый в данной операции привязки.</param>
		/// <param name="dwReduceHowFar">Значение, задающее, насколько следует уменьшить текущий моникер.</param>
		/// <param name="ppmkToLeft">Ссылка на моникер слева от текущего моникера.</param>
		/// <param name="ppmkReduced">При возвращении данного метода содержит ссылку на уменьшенную форму текущего моникера, который может иметь значение <see langword="null" />, если происходит ошибка или если текущий моникер уменьшен до нуля. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004528 RID: 17704
		void Reduce(IBindCtx pbc, int dwReduceHowFar, ref IMoniker ppmkToLeft, out IMoniker ppmkReduced);

		/// <summary>Объединяет текущий моникер с другим, создавая составной моникер.</summary>
		/// <param name="pmkRight">Ссылка на интерфейс <see langword="IMoniker" /> моникера для добавления в конец данного моникера.</param>
		/// <param name="fOnlyIfNotGeneric">Значение <see langword="true" /> показывает, что вызывающему объекту требуется неуниверсальное объединение. Операция продолжается только в том случае, если параметр <paramref name="pmkRight" /> является классом моникера, с которым текущий моникер может быть объединен каким-либо способом, кроме образования универсального объединения. Значение <see langword="false" /> показывает, что при необходимости метод может создать универсальное объединение.</param>
		/// <param name="ppmkComposite">При возвращении данного метода содержит ссылку на итоговый составной моникер. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004529 RID: 17705
		void ComposeWith(IMoniker pmkRight, [MarshalAs(UnmanagedType.Bool)] bool fOnlyIfNotGeneric, out IMoniker ppmkComposite);

		/// <summary>Предоставляет указатель на перечислитель, способный перечислить компоненты составного моникера.</summary>
		/// <param name="fForward">Значение <see langword="true" /> используется для перечисления моникеров слева направо. Значение <see langword="false" /> используется для перечисления справа налево.</param>
		/// <param name="ppenumMoniker">При возвращении данного метода содержит ссылку на объект перечислителя для моникера. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600452A RID: 17706
		void Enum([MarshalAs(UnmanagedType.Bool)] bool fForward, out IEnumMoniker ppenumMoniker);

		/// <summary>Сравнивает текущий моникер с заданным моникером и показывает, совпадают ли они.</summary>
		/// <param name="pmkOtherMoniker">Ссылка на моникер, используемый для сравнения.</param>
		/// <returns>Значение <see langword="S_OK" /><see langword="HRESULT" />, если моникеры совпадают; в противном случае — значение <see langword="S_FALSE" /><see langword="HRESULT" />.</returns>
		// Token: 0x0600452B RID: 17707
		[PreserveSig]
		int IsEqual(IMoniker pmkOtherMoniker);

		/// <summary>Вычисляет 32-разрядное целое число, используя внутреннее состояние моникера.</summary>
		/// <param name="pdwHash">При возвращении данного метода содержит хэш-значения для этого моникера. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600452C RID: 17708
		void Hash(out int pdwHash);

		/// <summary>Определяет, загружен и запущен ли в данный момент объект, определенный текущим моникером.</summary>
		/// <param name="pbc">Ссылка на контекст привязки, используемый при выполнении данной операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если текущий моникер является частью составного моникера.</param>
		/// <param name="pmkNewlyRunning">Ссылка на моникер, который был добавлен в таблицу текущих объектов (ROT) самым последним.</param>
		/// <returns>Значение <see langword="S_OK" /><see langword="HRESULT" />, если моникер выполняется, значение <see langword="S_FALSE" /><see langword="HRESULT" />, если моникер не выполняется, или значение <see langword="E_UNEXPECTED" /><see langword="HRESULT" />.</returns>
		// Token: 0x0600452D RID: 17709
		[PreserveSig]
		int IsRunning(IBindCtx pbc, IMoniker pmkToLeft, IMoniker pmkNewlyRunning);

		/// <summary>Предоставляет число, указывающее время последнего изменения объекта, определенного текущим моникером.</summary>
		/// <param name="pbc">Ссылка на контекст привязки, используемый при выполнении данной операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если моникер является частью составного моникера.</param>
		/// <param name="pFileTime">При возвращении данного метода содержит время последнего изменения. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600452E RID: 17710
		void GetTimeOfLastChange(IBindCtx pbc, IMoniker pmkToLeft, out FILETIME pFileTime);

		/// <summary>Предоставляет моникер, объединение которого с правой частью данного моникера или моникера с подобной структурой приводит к нулевому значению.</summary>
		/// <param name="ppmk">При возвращении данного метода содержит моникер, который является инверсией текущего моникера. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600452F RID: 17711
		void Inverse(out IMoniker ppmk);

		/// <summary>Создает новый моникер на основании общего префикса, который данный моникер использует совместно с другим моникером.</summary>
		/// <param name="pmkOther">Ссылка на интерфейс <see langword="IMoniker" /> другого моникера, сравниваемого с данным моникером для выявления общего префикса.</param>
		/// <param name="ppmkPrefix">При возвращении данного метода содержит моникер, который является общим префиксом текущего моникера и <paramref name="pmkOther" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004530 RID: 17712
		void CommonPrefixWith(IMoniker pmkOther, out IMoniker ppmkPrefix);

		/// <summary>Предоставляет моникер, добавление которого к текущему моникеру (или к одной из подобных структур) приводит к получению указанного моникера.</summary>
		/// <param name="pmkOther">Ссылка на моникер, для которого нужно получить относительный путь.</param>
		/// <param name="ppmkRelPath">При возвращении данного метода содержит ссылку на относительный моникер. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004531 RID: 17713
		void RelativePathTo(IMoniker pmkOther, out IMoniker ppmkRelPath);

		/// <summary>Возвращает отображаемое имя, являющееся представлением текущего моникера, удобным для чтения пользователем.</summary>
		/// <param name="pbc">Ссылка на контекст привязки, используемый в данной операции.</param>
		/// <param name="pmkToLeft">Ссылка на моникер слева от данного моникера, если моникер является частью составного моникера.</param>
		/// <param name="ppszDisplayName">При возвращении данного метода содержит строку отображаемого имени. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004532 RID: 17714
		void GetDisplayName(IBindCtx pbc, IMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] out string ppszDisplayName);

		/// <summary>Считывает столько знаков указанного отображаемого имени, сколько может воспринять <see cref="M:System.Runtime.InteropServices.ComTypes.IMoniker.ParseDisplayName(System.Runtime.InteropServices.ComTypes.IBindCtx,System.Runtime.InteropServices.ComTypes.IMoniker,System.String,System.Int32@,System.Runtime.InteropServices.ComTypes.IMoniker@)" />, и создает моникер, соответствующий считанной части.</summary>
		/// <param name="pbc">Ссылка на контекст привязки, используемый при выполнении данной операции привязки.</param>
		/// <param name="pmkToLeft">Ссылка на моникер, созданный из отображаемого имени до данной точки.</param>
		/// <param name="pszDisplayName">Ссылка на строку, содержащую оставшуюся часть анализируемого отображаемого имени.</param>
		/// <param name="pchEaten">При возвращении данного метода содержит число знаков, использованных при анализе <paramref name="pszDisplayName" />. Этот параметр передается неинициализированным.</param>
		/// <param name="ppmkOut">При возвращении данного метода содержит ссылку на моникер, построенный из <paramref name="pszDisplayName" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004533 RID: 17715
		void ParseDisplayName(IBindCtx pbc, IMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] string pszDisplayName, out int pchEaten, out IMoniker ppmkOut);

		/// <summary>Показывает, является ли данный моникер одним из классов моникеров, предоставляемых системой.</summary>
		/// <param name="pdwMksys">При возвращении данного метода содержит указатель на целое число, являющееся одним из значений из перечисления <see langword="MKSYS" /> и ссылающееся на один из классов моникеров COM. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="S_OK" /><see langword="HRESULT" />, если моникер является моникером системы; в противном случае — значение <see langword="S_FALSE" /><see langword="HRESULT" />.</returns>
		// Token: 0x06004534 RID: 17716
		[PreserveSig]
		int IsSystemMoniker(out int pdwMksys);
	}
}
