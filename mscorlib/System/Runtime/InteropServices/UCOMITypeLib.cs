using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeLib" />.</summary>
	// Token: 0x02000761 RID: 1889
	[Obsolete]
	[Guid("00020402-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMITypeLib
	{
		/// <summary>Возвращает число описаний типов в библиотеке типов.</summary>
		/// <returns>Число описаний типов в библиотеке типов.</returns>
		// Token: 0x06004298 RID: 17048
		[PreserveSig]
		int GetTypeInfoCount();

		/// <summary>Возвращает описание заданного типа из библиотеки.</summary>
		/// <param name="index">Индекс возвращаемого интерфейса <see langword="UCOMITypeInfo" />.</param>
		/// <param name="ppTI">При успешном возвращении — <see langword="UCOMITypeInfo" />, описывающий тип, на который ссылается <paramref name="index" />.</param>
		// Token: 0x06004299 RID: 17049
		void GetTypeInfo(int index, out UCOMITypeInfo ppTI);

		/// <summary>Возвращает тип описания типа.</summary>
		/// <param name="index">Индекс описания типа внутри библиотеки типов.</param>
		/// <param name="pTKind">Ссылка на перечисление <see langword="TYPEKIND" /> для описания типа.</param>
		// Token: 0x0600429A RID: 17050
		void GetTypeInfoType(int index, out TYPEKIND pTKind);

		/// <summary>Загружает описание типа, соответствующее заданному идентификатору GUID.</summary>
		/// <param name="guid">Идентификатор IID интерфейса для идентификатора класса CLSID, для которого запрашивается информация о типе.</param>
		/// <param name="ppTInfo">При удачном возвращении — запрошенный интерфейс <see langword="ITypeInfo" />.</param>
		// Token: 0x0600429B RID: 17051
		void GetTypeInfoOfGuid(ref Guid guid, out UCOMITypeInfo ppTInfo);

		/// <summary>Возвращает структуру, содержащую атрибуты библиотеки.</summary>
		/// <param name="ppTLibAttr">При удачном возвращении — структура, содержащая атрибуты библиотеки.</param>
		// Token: 0x0600429C RID: 17052
		void GetLibAttr(out IntPtr ppTLibAttr);

		/// <summary>Позволяет компилятору клиента выполнить привязку к библиотечным типам, переменным, константам и глобальным функциям.</summary>
		/// <param name="ppTComp">При удачном возвращении — экземпляр <see langword="UCOMITypeComp" /> для <see langword="ITypeLib" />.</param>
		// Token: 0x0600429D RID: 17053
		void GetTypeComp(out UCOMITypeComp ppTComp);

		/// <summary>Возвращает строку документации библиотеки, полный файл справки и путь к нему, а также идентификатор контекста для раздела справки библиотеки в файле справки.</summary>
		/// <param name="index">Индекс описания типа, для которого возвращается документация.</param>
		/// <param name="strName">Возвращает строку, содержащую имя указанного элемента.</param>
		/// <param name="strDocString">Возвращает строку, содержащую строку документации для указанного элемента.</param>
		/// <param name="dwHelpContext">Возвращает идентификатор контекста справки, связанный с указанным элементом.</param>
		/// <param name="strHelpFile">Возвращает строку, содержащую полное имя файла справки.</param>
		// Token: 0x0600429E RID: 17054
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		/// <summary>Показывает, содержит ли переданная строка имя типа или члена, описанного в библиотеке.</summary>
		/// <param name="szNameBuf">Строка для проверки.</param>
		/// <param name="lHashVal">Хэш-значение для <paramref name="szNameBuf" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="szNameBuf" /> обнаружен в библиотеке типов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600429F RID: 17055
		[return: MarshalAs(UnmanagedType.Bool)]
		bool IsName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal);

		/// <summary>Обнаруживает экземпляры описания типа в библиотеке типов.</summary>
		/// <param name="szNameBuf">Имя, которое требуется найти.</param>
		/// <param name="lHashVal">Хэш-значение для ускорения поиска, вычисленное при помощи функции <see langword="LHashValOfNameSys" />. Если значение <paramref name="lHashVal" /> равно 0, то значение рассчитывается.</param>
		/// <param name="ppTInfo">При удачном возвращении — массив указателей на описания типов, содержащих имя, заданное в параметре <paramref name="szNameBuf" />.</param>
		/// <param name="rgMemId">Массив значений <see langword="MEMBERID" /> найденных элементов. <paramref name="rgMemId" />[i] является значением <see langword="MEMBERID" />, выполняющим индексацию в описании типа, заданном параметром <paramref name="ppTInfo" />[i]. Не может иметь значение <see langword="null" />.</param>
		/// <param name="pcFound">При входе показывает количество разыскиваемых экземпляров. Например, если <paramref name="pcFound" /> = 1 можно использовать для поиска первого экземпляра. Поиск прекращается после обнаружения первого экземпляра.  
		/// При выходе показывает число обнаруженных экземпляров. Если значения <see langword="in" /> и <see langword="out" /> параметра <paramref name="pcFound" /> идентичны, возможно найдены не все описания типа, содержащие нужное имя.</param>
		// Token: 0x060042A0 RID: 17056
		void FindName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal, [MarshalAs(UnmanagedType.LPArray)] [Out] UCOMITypeInfo[] ppTInfo, [MarshalAs(UnmanagedType.LPArray)] [Out] int[] rgMemId, ref short pcFound);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.TYPELIBATTR" />, полученную из метода <see cref="M:System.Runtime.InteropServices.UCOMITypeLib.GetLibAttr(System.IntPtr@)" />.</summary>
		/// <param name="pTLibAttr">Освобождаемая структура <see langword="TLIBATTR" />.</param>
		// Token: 0x060042A1 RID: 17057
		[PreserveSig]
		void ReleaseTLibAttr(IntPtr pTLibAttr);
	}
}
