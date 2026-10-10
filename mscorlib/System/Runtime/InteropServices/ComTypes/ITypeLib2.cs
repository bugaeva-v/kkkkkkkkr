using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="ITypeLib2" />.</summary>
	// Token: 0x020007CF RID: 1999
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00020411-0000-0000-C000-000000000046")]
	[ComImport]
	public interface ITypeLib2 : ITypeLib
	{
		/// <summary>Возвращает число описаний типов в библиотеке типов.</summary>
		/// <returns>Число описаний типов в библиотеке типов.</returns>
		// Token: 0x0600459A RID: 17818
		[PreserveSig]
		int GetTypeInfoCount();

		/// <summary>Возвращает описание заданного типа из библиотеки.</summary>
		/// <param name="index">Индекс возвращаемого интерфейса <see langword="ITypeInfo" />.</param>
		/// <param name="ppTI">При возвращении данного метода содержит <see langword="ITypeInfo" /> с описанием типа, на который ссылается <paramref name="index" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600459B RID: 17819
		void GetTypeInfo(int index, out ITypeInfo ppTI);

		/// <summary>Возвращает тип описания типа.</summary>
		/// <param name="index">Индекс описания типа внутри библиотеки типов.</param>
		/// <param name="pTKind">При возвращении данного метода содержит ссылку на перечисление <see langword="TYPEKIND" /> для описания типа. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600459C RID: 17820
		void GetTypeInfoType(int index, out TYPEKIND pTKind);

		/// <summary>Загружает описание типа, соответствующее заданному идентификатору GUID.</summary>
		/// <param name="guid">Идентификатор <see cref="T:System.Guid" />, переданный ссылкой, представляющий IID интерфейса <see langword="CLSID" /> класса, для которого требуются сведения о типе.</param>
		/// <param name="ppTInfo">При возвращении данного метода содержит требуемый интерфейс <see langword="ITypeInfo" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600459D RID: 17821
		void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);

		/// <summary>Возвращает структуру, содержащую атрибуты библиотеки.</summary>
		/// <param name="ppTLibAttr">При возвращении данного метода содержит структуру, содержащую атрибуты библиотеки. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600459E RID: 17822
		void GetLibAttr(out IntPtr ppTLibAttr);

		/// <summary>Позволяет компилятору клиента выполнить привязку к библиотечным типам, переменным, константам и глобальным функциям.</summary>
		/// <param name="ppTComp">При возвращении данного метода содержит экземпляр <see langword="ITypeComp" /> для <see langword="ITypeLib" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600459F RID: 17823
		void GetTypeComp(out ITypeComp ppTComp);

		/// <summary>Возвращает строку документации библиотеки, полный файл справки и путь к нему, а также идентификатор контекста для раздела справки библиотеки в файле справки.</summary>
		/// <param name="index">Индекс описания типа, для которого возвращается документация.</param>
		/// <param name="strName">При возвращении данного метода содержит строку, задающую имя заданного элемента. Этот параметр передается неинициализированным.</param>
		/// <param name="strDocString">При возвращении данного метода содержит строку документации для заданного элемента. Этот параметр передается неинициализированным.</param>
		/// <param name="dwHelpContext">При возвращении данного метода содержит идентификатор контекста справки, связанный с заданным элементом. Этот параметр передается неинициализированным.</param>
		/// <param name="strHelpFile">При возвращении данного метода содержит строку, задающую полное имя файла справки. Этот параметр передается неинициализированным.</param>
		// Token: 0x060045A0 RID: 17824
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		/// <summary>Показывает, содержит ли переданная строка имя типа или члена, описанного в библиотеке.</summary>
		/// <param name="szNameBuf">Строка для проверки.</param>
		/// <param name="lHashVal">Хэш-значение для <paramref name="szNameBuf" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="szNameBuf" /> обнаружен в библиотеке типов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060045A1 RID: 17825
		[return: MarshalAs(UnmanagedType.Bool)]
		bool IsName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal);

		/// <summary>Обнаруживает экземпляры описания типа в библиотеке типов.</summary>
		/// <param name="szNameBuf">Имя, которое требуется найти.</param>
		/// <param name="lHashVal">Хэш-значение для ускорения поиска, вычисленное при помощи функции <see langword="LHashValOfNameSys" />. Если значение <paramref name="lHashVal" /> равно 0, то значение рассчитывается.</param>
		/// <param name="ppTInfo">При возвращении данного метода содержит массив указателей на описания типов, которые содержат имя, заданное в <paramref name="szNameBuf" />. Этот параметр передается неинициализированным.</param>
		/// <param name="rgMemId">При возвращении данного метода содержит массив идентификаторов <see langword="MEMBERID" /> найденных элементов; <paramref name="rgMemId" /> [i] является значением <see langword="MEMBERID" />, выполняющим индексацию в описании типа, заданном параметром <paramref name="ppTInfo" /> [i]. Этот параметр не может иметь значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pcFound">На входе значение, переданное ссылкой, указывающее, сколько экземпляров следует искать. Например, если <paramref name="pcFound" /> = 1 можно использовать для поиска первого экземпляра. Поиск прекращается после обнаружения первого экземпляра.  
		/// При выходе показывает число обнаруженных экземпляров. Если значения <see langword="in" /> и <see langword="out" /> параметра <paramref name="pcFound" /> идентичны, возможно найдены не все описания типа, содержащие нужное имя.</param>
		// Token: 0x060045A2 RID: 17826
		void FindName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal, [MarshalAs(UnmanagedType.LPArray)] [Out] ITypeInfo[] ppTInfo, [MarshalAs(UnmanagedType.LPArray)] [Out] int[] rgMemId, ref short pcFound);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.TYPELIBATTR" />, первоначально полученную из метода <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeLib.GetLibAttr(System.IntPtr@)" />.</summary>
		/// <param name="pTLibAttr">Структура <see langword="TLIBATTR" />, которую следует освободить.</param>
		// Token: 0x060045A3 RID: 17827
		[PreserveSig]
		void ReleaseTLibAttr(IntPtr pTLibAttr);

		/// <summary>Возвращает пользовательские данные.</summary>
		/// <param name="guid">Параметр <see cref="T:System.Guid" />, передаваемый по ссылке и используемый для определения данных.</param>
		/// <param name="pVarVal">При возврате этого метода содержит объект для определения расположения полученных данных. Этот параметр передается неинициализированным.</param>
		// Token: 0x060045A4 RID: 17828
		void GetCustData(ref Guid guid, out object pVarVal);

		/// <summary>Позволяет получить строку документирования библиотеки, полное имя файла справки и путь к нему, контекст локализации, который следует использовать, и идентификатор контекста для раздела справки библиотеки в файле справки.</summary>
		/// <param name="index">Индекс описания типа, документация по которому должна быть возвращена. Если параметр <paramref name="index" /> имеет значение -1, документация библиотеки возвращается.</param>
		/// <param name="pbstrHelpString">При возвращении этот метод содержит параметр BSTR с именем указанного элемента. Если вызывающему объекту не требуется имя элемента, параметр <paramref name="pbstrHelpString" /> может иметь значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pdwHelpStringContext">После выполнения возврата этим методом содержит контекст локализации справки. Если вызывающему объекту не требуется контекст справки, параметр <paramref name="pdwHelpStringContext" /> может иметь значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pbstrHelpStringDll">После выполнения возврата этим методом содержит параметр BSTR, указывающий полное имя файла, который, в свою очередь, содержит библиотеку DLL, используемую для файла справки. Если вызывающему объекту не требуется имя файла, параметр <paramref name="pbstrHelpStringDll" /> может иметь значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x060045A5 RID: 17829
		[LCIDConversion(1)]
		void GetDocumentation2(int index, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);

		/// <summary>Возвращает статистику о библиотеке типов, необходимую для эффективного определения размеров хэш-таблиц.</summary>
		/// <param name="pcUniqueNames">Указатель на число уникальных имен. Если вызывающему объекту не требуются эти сведения, задайте значение <see langword="null" />.</param>
		/// <param name="pcchUniqueNames">При возвращении данного метода содержит указатель на изменение числа уникальных имен. Этот параметр передается неинициализированным.</param>
		// Token: 0x060045A6 RID: 17830
		void GetLibStatistics(IntPtr pcUniqueNames, out int pcchUniqueNames);

		/// <summary>Возвращает все пользовательские элементы данных для библиотеки.</summary>
		/// <param name="pCustData">Указатель на объект <see langword="CUSTDATA" />, который содержит все пользовательские элементы данных.</param>
		// Token: 0x060045A7 RID: 17831
		void GetAllCustData(IntPtr pCustData);
	}
}
