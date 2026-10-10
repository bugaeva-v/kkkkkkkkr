using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IDataObject" />.</summary>
	// Token: 0x0200018C RID: 396
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010e-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IDataObject
	{
		/// <summary>Создает соединение между объектом данных и приемником уведомлений. Этот метод вызывается объектом, который поддерживает приемник уведомлений и позволяет уведомлять приемник об изменениях в данных объекта.</summary>
		/// <param name="pFormatetc">Структура <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, переданная ссылкой, определяющая формат, целевое устройство, аспект и среду передачи, которые будут использоваться для будущих уведомлений.</param>
		/// <param name="advf">Одно из значений <see cref="T:System.Runtime.InteropServices.ComTypes.ADVF" />, задающее группу флагов для контролирования вспомогательного соединения.</param>
		/// <param name="adviseSink">Указатель на интерфейс <see cref="T:System.Runtime.InteropServices.ComTypes.IAdviseSink" /> в приемнике уведомлений, который будет получать уведомления об изменениях.</param>
		/// <param name="connection">При возвращении данного метода содержит указатель на маркер DWORD, определяющий это соединение. Позднее этот маркер можно использовать для удаления вспомогательного соединения, передав его в <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.DUnadvise(System.Int32)" />. Если это значение равно нулю, соединение не было установлено. Этот параметр передается неинициализированным.</param>
		/// <returns>Этот метод поддерживает стандартные возвращаемые значения E_INVALIDARG, E_UNEXPECTED и E_OUTOFMEMORY, а также следующие. 
		///   Значение 
		///   Описание 
		///   S_OK 
		///   Было создано соединение для получения рекомендаций.  
		///   E_NOTIMPL 
		///   Этот метод не был реализован в объекте данных.  
		///   DV_E_LINDEX 
		///   Недопустимое значение для <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.lindex" />; в настоящий момент поддерживается только значение -1.  
		///   DV_E_FORMATETC 
		///   Недопустимое значение для параметра <paramref name="pFormatetc" />.  
		///   OLE_E_ADVISENOTSUPPORTED 
		///   Объект данных не поддерживает уведомление об изменении.</returns>
		// Token: 0x06000A75 RID: 2677
		[PreserveSig]
		int DAdvise([In] ref FORMATETC pFormatetc, ADVF advf, IAdviseSink adviseSink, out int connection);

		/// <summary>Разрывает соединение уведомления, которое было ранее установлено.</summary>
		/// <param name="connection">маркер DWORD, задающий соединение для удаления. Используйте значение, возвращенное <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.DAdvise(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.ADVF,System.Runtime.InteropServices.ComTypes.IAdviseSink,System.Int32@)" /> при первоначальной настройке соединения.</param>
		// Token: 0x06000A76 RID: 2678
		void DUnadvise(int connection);

		/// <summary>Создает объект, который может использоваться для перечисления текущих соединений для рекомендаций.</summary>
		/// <param name="enumAdvise">При возвращении данного метода содержит компонент <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumSTATDATA" />, получающий указатель интерфейса на новый объект перечислителя. Если при реализации для параметра <paramref name="enumAdvise" /> задается значение <see langword="null" />, в это время отсутствуют соединения с приемниками уведомлений. Этот параметр передается неинициализированным.</param>
		/// <returns>Этот метод поддерживает стандартное возвращаемое значение E_OUTOFMEMORY, а также следующие.  
		///   Значение  
		///
		///   Описание  
		///
		///   S_OK  
		///
		///   Экземпляр объекта перечисления успешно создан, или отсутствуют соединения.  
		///
		///   OLE_E_ADVISENOTSUPPORTED  
		///
		///   Этот объект не поддерживает уведомления о рекомендациях.</returns>
		// Token: 0x06000A77 RID: 2679
		[PreserveSig]
		int EnumDAdvise(out IEnumSTATDATA enumAdvise);

		/// <summary>Создает объект для перечисления структур <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> для объекта данных. Эти структуры используются в вызовах <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" /> или <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.SetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@,System.Boolean)" />.</summary>
		/// <param name="direction">Одно из значений <see cref="T:System.Runtime.InteropServices.ComTypes.DATADIR" />, определяющее направление данных.</param>
		/// <returns>Этот метод поддерживает стандартные возвращаемые значения E_INVALIDARG и E_OUTOFMEMORY, а также следующие. 
		///   Значение 
		///   Описание 
		///   S_OK 
		///   Объект перечисления был успешно создан.  
		///   E_NOTIMPL 
		///   Направление, заданное параметром <paramref name="direction" />, не поддерживается.  
		///   OLE_S_USEREG 
		///   Требует, чтобы OLE перечисляли форматы из реестра.</returns>
		// Token: 0x06000A78 RID: 2680
		IEnumFORMATETC EnumFormatEtc(DATADIR direction);

		/// <summary>Предоставляет стандартную структуру <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, которая логически эквивалентна более сложной структуре. Этот метод применяется, чтобы определить, будут ли две различные структуры <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> возвращать одинаковые данные, что позволяет избежать ненужной повторной отрисовки.</summary>
		/// <param name="formatIn">Указатель на структуру <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, переданную ссылкой, определяющую формат, среду передачи и целевое устройство, которые вызывающий объект хотел бы использовать для извлечения данных в последующем вызове, например <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />. В этом случае элемент <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" /> не важен и должен быть проигнорирован.</param>
		/// <param name="formatOut">Возвращаемые этим методом данные содержат указатель на структуру <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, которая содержит наиболее общие сведения для определенной прорисовки, делая его канонически эквивалентным <c>formatetIn</c>. Вызывающий объект должен выделить эту структуру, а метод <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetCanonicalFormatEtc(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.FORMATETC@)" /> должен заполнить данные. Для извлечения данных в последующем вызове, например <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />, вызывающий объект использует предоставленное значение параметра <paramref name="formatOut" />, если предоставленное значение не равно <see langword="null" />. Это значение равняется <see langword="null" />, если метод возвращает <see langword="DATA_S_SAMEFORMATETC" />. В этом случае элемент <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" /> не важен и должен быть проигнорирован. Этот параметр передается неинициализированным.</param>
		/// <returns>Этот метод поддерживает стандартные возвращаемые значения E_INVALIDARG, E_UNEXPECTED и E_OUTOFMEMORY, а также следующие. 
		///   Значение 
		///   Описание 
		///   S_OK 
		///   Возвращенная структура <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> отличается от структуры, которая была передана.  
		///   DATA_S_SAMEFORMATETC 
		///   Структуры <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" /> — те же самые, и значение <see langword="null" /> возвращается в параметре <paramref name="formatOut" />.  
		///   DV_E_LINDEX 
		///   Недопустимое значение для <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.lindex" />; в настоящий момент поддерживается только значение -1.  
		///   DV_E_FORMATETC 
		///   Недопустимое значение для параметра <paramref name="pFormatetc" />.  
		///   OLE_E_NOTRUNNING 
		///   Приложение не выполняется.</returns>
		// Token: 0x06000A79 RID: 2681
		[PreserveSig]
		int GetCanonicalFormatEtc([In] ref FORMATETC formatIn, out FORMATETC formatOut);

		/// <summary>Получает данные из исходного объекта данных. Метод <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />, который вызывается объектом-получателем данных, обрабатывает данные, описанные в заданной структуре <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, и передает их через заданную структуру <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" />. Затем вызывающий объект несет ответственность за освобождение структуры <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" />.</summary>
		/// <param name="format">Указатель на структуру <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, переданную ссылкой, которая определяет формат, среду передачи и целевое устройство для использования при передаче данных. С помощью логического оператора OR можно задать более одной среды передачи, разрешив методу выбирать лучшую среду передачи среди заданных.</param>
		/// <param name="medium">При возвращении данного метода содержит указатель на структуру <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" />, задающий среду хранения, содержащую возвращенные данные посредством своего элемента <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.tymed" />, и ответственность за освобождение среды передачи через значение своего элемента <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" />. Если <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> равняется <see langword="null" />, получатель среды передачи отвечает за ее освобождение; в противном случае <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> указывает на интерфейс <see langword="IUnknown" /> в соответствующем объекте, так чтобы можно было вызвать его метод <see langword="Release" />. Среда передачи должна быть выделена и заполнена с помощью <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06000A7A RID: 2682
		void GetData([In] ref FORMATETC format, out STGMEDIUM medium);

		/// <summary>Получает данные из исходного объекта данных. Этот метод, который вызывается объектом-получателем данных, отличается от метода <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />, в котором вызывающий объект должен выделить и освободить заданную среду хранения.</summary>
		/// <param name="format">Указатель на структуру <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, переданную ссылкой, которая определяет формат, среду передачи и целевое устройство для использования при передаче данных. Только одна среда может быть задана в <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" />, и только следующие значения <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" /> являются действительными: <see cref="F:System.Runtime.InteropServices.ComTypes.TYMED.TYMED_ISTORAGE" />, <see cref="F:System.Runtime.InteropServices.ComTypes.TYMED.TYMED_ISTREAM" />, <see cref="F:System.Runtime.InteropServices.ComTypes.TYMED.TYMED_HGLOBAL" /> или <see cref="F:System.Runtime.InteropServices.ComTypes.TYMED.TYMED_FILE" />.</param>
		/// <param name="medium">Компонент <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" />, переданный ссылкой, который определяет среду хранения, содержащую передаваемые данные. Среда передачи должна быть выделена вызывающим объектом и заполнена с помощью <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetDataHere(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />. Также вызывающий объект должен освободить среду передачи. При реализации этого метода должно всегда предоставляться значение <see langword="null" /> для элемента <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> структуры <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" />, на которую указывает этот параметр.</param>
		// Token: 0x06000A7B RID: 2683
		void GetDataHere([In] ref FORMATETC format, ref STGMEDIUM medium);

		/// <summary>Определяет, способен ли объект данных выполнять отрисовку данных, описанных в структуре <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />. Объекты, пытающиеся выполнять операцию вставки или перетаскивания, могут вызывать этот метод перед вызовом <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />, чтобы получить указание о том, может ли операция быть успешной.</summary>
		/// <param name="format">Указатель на структуру <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, переданную ссылкой, которая определяет формат, среду передачи и целевое устройство, которые должны использоваться для запроса.</param>
		/// <returns>Этот метод поддерживает стандартные возвращаемые значения E_INVALIDARG, E_UNEXPECTED и E_OUTOFMEMORY, а также следующие. 
		///   Значение 
		///   Описание 
		///   S_OK 
		///   Последующий вызов <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />, возможно, будет успешным.  
		///   DV_E_LINDEX 
		///   Недопустимое значение для <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.lindex" />; в настоящий момент поддерживается только значение -1.  
		///   DV_E_FORMATETC 
		///   Недопустимое значение для параметра <paramref name="pFormatetc" />.  
		///   DV_E_TYMED 
		///   Недопустимое значение <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.tymed" />.  
		///   DV_E_DVASPECT 
		///   Недопустимое значение <see cref="F:System.Runtime.InteropServices.ComTypes.FORMATETC.dwAspect" />.  
		///   OLE_E_NOTRUNNING 
		///   Приложение не выполняется.</returns>
		// Token: 0x06000A7C RID: 2684
		[PreserveSig]
		int QueryGetData([In] ref FORMATETC format);

		/// <summary>Передает данные в объект, реализующий этот метод. Этот метод вызывается объектом, содержащим источник данных.</summary>
		/// <param name="formatIn">Структура <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, переданная ссылкой, которая определяет формат, используемый объектом данных при интерпретации данных, содержащихся в среде хранения.</param>
		/// <param name="medium">Структура <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" />, переданная ссылкой, которая определяет среду хранения, в которой передаются данные.</param>
		/// <param name="release">Значение <see langword="true" /> задает, что вызванный объект данных, который реализует <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.SetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@,System.Boolean)" />, владеет средой хранения после возвращения вызова. Это означает, что объект данных должен освободить среду после ее использования, вызвав функцию <see langword="ReleaseStgMedium" />. Значение <see langword="false" /> для указания того, что вызывающий объект сохраняет владение средой хранения, а вызванный объект данных использует среду хранения только во время выполнения вызова.</param>
		// Token: 0x06000A7D RID: 2685
		void SetData([In] ref FORMATETC formatIn, [In] ref STGMEDIUM medium, [MarshalAs(UnmanagedType.Bool)] bool release);
	}
}
