using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="ITypeLib" />.</summary>
	// Token: 0x020007CE RID: 1998
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00020402-0000-0000-C000-000000000046")]
	[ComImport]
	public interface ITypeLib
	{
		/// <summary>Возвращает число описаний типов в библиотеке типов.</summary>
		/// <returns>Число описаний типов в библиотеке типов.</returns>
		// Token: 0x06004590 RID: 17808
		[PreserveSig]
		int GetTypeInfoCount();

		/// <summary>Возвращает описание заданного типа из библиотеки.</summary>
		/// <param name="index">Индекс возвращаемого интерфейса <see langword="ITypeInfo" />.</param>
		/// <param name="ppTI">При возвращении данного метода содержит <see langword="ITypeInfo" /> с описанием типа, на который ссылается <paramref name="index" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004591 RID: 17809
		void GetTypeInfo(int index, out ITypeInfo ppTI);

		/// <summary>Возвращает тип описания типа.</summary>
		/// <param name="index">Индекс описания типа внутри библиотеки типов.</param>
		/// <param name="pTKind">При возвращении данного метода содержит ссылку на перечисление <see langword="TYPEKIND" /> для описания типа. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004592 RID: 17810
		void GetTypeInfoType(int index, out TYPEKIND pTKind);

		/// <summary>Загружает описание типа, соответствующее заданному идентификатору GUID.</summary>
		/// <param name="guid">IID интерфейса или CLSID класса, информация о типе которого запрашивается.</param>
		/// <param name="ppTInfo">При возвращении данного метода содержит требуемый интерфейс <see langword="ITypeInfo" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004593 RID: 17811
		void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);

		/// <summary>Возвращает структуру, содержащую атрибуты библиотеки.</summary>
		/// <param name="ppTLibAttr">При возвращении данного метода содержит структуру, содержащую атрибуты библиотеки. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004594 RID: 17812
		void GetLibAttr(out IntPtr ppTLibAttr);

		/// <summary>Позволяет компилятору клиента выполнить привязку к библиотечным типам, переменным, константам и глобальным функциям.</summary>
		/// <param name="ppTComp">При возвращении данного метода содержит экземпляр <see langword="ITypeComp" /> для <see langword="ITypeLib" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004595 RID: 17813
		void GetTypeComp(out ITypeComp ppTComp);

		/// <summary>Возвращает строку документации библиотеки, полный файл справки и путь к нему, а также идентификатор контекста для раздела справки библиотеки в файле справки.</summary>
		/// <param name="index">Индекс описания типа, для которого возвращается документация.</param>
		/// <param name="strName">При возвращении данного метода содержит строку, представляющую имя заданного элемента. Этот параметр передается неинициализированным.</param>
		/// <param name="strDocString">При возвращении данного метода содержит строку, представляющую строку документации для заданного элемента. Этот параметр передается неинициализированным.</param>
		/// <param name="dwHelpContext">При возвращении данного метода содержит идентификатор контекста справки, связанный с заданным элементом. Этот параметр передается неинициализированным.</param>
		/// <param name="strHelpFile">При возвращении данного метода содержит строку, представляющую полное имя файла справки. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004596 RID: 17814
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		/// <summary>Показывает, содержит ли переданная строка имя типа или члена, описанного в библиотеке.</summary>
		/// <param name="szNameBuf">Строка для проверки. Это параметр In или Out.</param>
		/// <param name="lHashVal">Хэш-значение для <paramref name="szNameBuf" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="szNameBuf" /> обнаружен в библиотеке типов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004597 RID: 17815
		[return: MarshalAs(UnmanagedType.Bool)]
		bool IsName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal);

		/// <summary>Обнаруживает экземпляры описания типа в библиотеке типов.</summary>
		/// <param name="szNameBuf">Имя, которое требуется найти. Это параметр In или Out.</param>
		/// <param name="lHashVal">Хэш-значение для ускорения поиска, вычисленное при помощи функции <see langword="LHashValOfNameSys" />. Если значение <paramref name="lHashVal" /> равно 0, то значение рассчитывается.</param>
		/// <param name="ppTInfo">При возвращении данного метода содержит массив указателей на описания типов, которые содержат имя, заданное в <paramref name="szNameBuf" />. Этот параметр передается неинициализированным.</param>
		/// <param name="rgMemId">Массив значений <see langword="MEMBERID" /> найденных элементов. <paramref name="rgMemId" />[i] является значением <see langword="MEMBERID" />, выполняющим индексацию в описании типа, заданном параметром <paramref name="ppTInfo" />[i]. Не может иметь значение <see langword="null" />.</param>
		/// <param name="pcFound">При входе показывает количество разыскиваемых экземпляров. Например, если <paramref name="pcFound" /> = 1 можно использовать для поиска первого экземпляра. Поиск прекращается после обнаружения первого экземпляра.  
		/// При выходе показывает число обнаруженных экземпляров. Если значения <see langword="in" /> и <see langword="out" /> параметра <paramref name="pcFound" /> идентичны, возможно найдены не все описания типа, содержащие нужное имя.</param>
		// Token: 0x06004598 RID: 17816
		void FindName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal, [MarshalAs(UnmanagedType.LPArray)] [Out] ITypeInfo[] ppTInfo, [MarshalAs(UnmanagedType.LPArray)] [Out] int[] rgMemId, ref short pcFound);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.TYPELIBATTR" />, первоначально полученную из метода <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeLib.GetLibAttr(System.IntPtr@)" />.</summary>
		/// <param name="pTLibAttr">Структура <see langword="TLIBATTR" />, которую следует освободить.</param>
		// Token: 0x06004599 RID: 17817
		[PreserveSig]
		void ReleaseTLibAttr(IntPtr pTLibAttr);
	}
}
