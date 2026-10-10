using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeInfo" />.</summary>
	// Token: 0x02000736 RID: 1846
	[Guid("00020401-0000-0000-C000-000000000046")]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.ITypeInfo instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMITypeInfo
	{
		/// <summary>Возвращает структуру <see cref="T:System.Runtime.InteropServices.TYPEATTR" />, содержащую атрибуты описания типа.</summary>
		/// <param name="ppTypeAttr">При удачном возвращении — ссылка на структуру, содержащую атрибуты этого описания типа.</param>
		// Token: 0x06004101 RID: 16641
		void GetTypeAttr(out IntPtr ppTypeAttr);

		/// <summary>Извлекает интерфейс <see langword="ITypeComp" /> описания типа, позволяющий компилятору клиента выполнить привязку к элементам описания типа.</summary>
		/// <param name="ppTComp">При успешном возвращении — ссылка на <see langword="UCOMITypeComp" /> соответствующей библиотеки типов.</param>
		// Token: 0x06004102 RID: 16642
		void GetTypeComp(out UCOMITypeComp ppTComp);

		/// <summary>Возвращает структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />, содержащую сведения о заданной функции.</summary>
		/// <param name="index">Индекс возвращаемого описания функции.</param>
		/// <param name="ppFuncDesc">Ссылка на структуру <see langword="FUNCDESC" />, описывающую заданную функцию.</param>
		// Token: 0x06004103 RID: 16643
		void GetFuncDesc(int index, out IntPtr ppFuncDesc);

		/// <summary>Извлекает структуру <see langword="VARDESC" />, описывающую указанную переменную.</summary>
		/// <param name="index">Индекс возвращаемого описания переменной.</param>
		/// <param name="ppVarDesc">При успешном возвращении — ссылка на структуру <see langword="VARDESC" />, описывающую указанную переменную.</param>
		// Token: 0x06004104 RID: 16644
		void GetVarDesc(int index, out IntPtr ppVarDesc);

		/// <summary>Извлекает переменную с указанным идентификатором (либо имя свойства или метода и его параметры), соответствующую заданному идентификатору функции.</summary>
		/// <param name="memid">Идентификатор элемента, для которого возвращается имя (или имена).</param>
		/// <param name="rgBstrNames">При удачном возвращении содержит имя (или имена), связанное с этим элементом.</param>
		/// <param name="cMaxNames">Длина массива <paramref name="rgBstrNames" />.</param>
		/// <param name="pcNames">При удачном возвращении — число имен в массиве <paramref name="rgBstrNames" />.</param>
		// Token: 0x06004105 RID: 16645
		void GetNames(int memid, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] [Out] string[] rgBstrNames, int cMaxNames, out int pcNames);

		/// <summary>Если в описании типа описывается класс COM, то извлекается описание типа для реализованных типов интерфейсов.</summary>
		/// <param name="index">Индекс реализованного типа, дескриптор которого возвращается.</param>
		/// <param name="href">Ссылка на дескриптор реализованного интерфейса.</param>
		// Token: 0x06004106 RID: 16646
		void GetRefTypeOfImplType(int index, out int href);

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.IMPLTYPEFLAGS" /> для одного реализованного интерфейса или базового интерфейса в описании типа.</summary>
		/// <param name="index">Индекс реализованного интерфейса или базового интерфейса.</param>
		/// <param name="pImplTypeFlags">При успешном возвращении — ссылка на перечисление <see langword="IMPLTYPEFLAGS" />.</param>
		// Token: 0x06004107 RID: 16647
		void GetImplTypeFlags(int index, out int pImplTypeFlags);

		/// <summary>Сопоставляет друг с другом имена и идентификаторы элементов и параметров.</summary>
		/// <param name="rgszNames">При удачном возвращении — массив сопоставляемых имен.</param>
		/// <param name="cNames">Число сопоставляемых имен.</param>
		/// <param name="pMemId">Ссылка на массив, в котором расположены сопоставления имен.</param>
		// Token: 0x06004108 RID: 16648
		void GetIDsOfNames([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] [In] string[] rgszNames, int cNames, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] int[] pMemId);

		/// <summary>Вызывает метод или обращается к свойству объекта, реализующему интерфейс, описанный в описании типа.</summary>
		/// <param name="pvInstance">Ссылка на интерфейс, описанный в данном описании типа.</param>
		/// <param name="memid">Определяет элемент интерфейса.</param>
		/// <param name="wFlags">Флаги, описывающие контекст используемого вызова.</param>
		/// <param name="pDispParams">Ссылка на структуру, содержащую массив аргументов, массив идентификаторов DISPID именованных аргументов, а также количество элементов в каждом массиве.</param>
		/// <param name="pVarResult">Ссылка на место хранения результата. Если <paramref name="wFlags" /> задает <see langword="DISPATCH_PROPERTYPUT" /> или <see langword="DISPATCH_PROPERTYPUTREF" />, то параметр <paramref name="pVarResult" /> не учитывается. Если результат не требуется, можно задать значение <see langword="null" />.</param>
		/// <param name="pExcepInfo">Указывает на структуру сведений об исключении, заполняемую только при возвращении <see langword="DISP_E_EXCEPTION" />.</param>
		/// <param name="puArgErr">Если <see langword="Invoke" /> возвращает <see langword="DISP_E_TYPEMISMATCH" />, то параметр <paramref name="puArgErr" /> показывает индекс аргумента с неверным типом внутри rgvarg. Если ошибка возвращается для нескольких аргументов, <paramref name="puArgErr" /> показывает только первый из них.</param>
		// Token: 0x06004109 RID: 16649
		void Invoke([MarshalAs(UnmanagedType.IUnknown)] object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, out object pVarResult, out EXCEPINFO pExcepInfo, out int puArgErr);

		/// <summary>Извлекает строку документации, полный файл справки и путь к нему, а также идентификатор контекста разделов справки для заданного описания типа.</summary>
		/// <param name="index">Идентификатор элемента, для которого возвращается документация.</param>
		/// <param name="strName">При удачном возвращении — имя метода для элемента.</param>
		/// <param name="strDocString">При удачном возвращении — строка документации для заданного элемента.</param>
		/// <param name="dwHelpContext">При удачном возвращении — ссылка на контекст справки, связанный с заданным элементом.</param>
		/// <param name="strHelpFile">При удачном возвращении — полное имя файла справки.</param>
		// Token: 0x0600410A RID: 16650
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		/// <summary>Возвращает описание или спецификацию точки входа для функции в динамической библиотеке DLL.</summary>
		/// <param name="memid">Идентификационный номер функции-элемента, для которого возвращается описание входа динамической библиотеки DLL.</param>
		/// <param name="invKind">Задает тип элемента, определенного параметром <paramref name="memid" />.</param>
		/// <param name="pBstrDllName">Если значение не равно <see langword="null" />, функция задает для параметра <paramref name="pBstrDllName" /> значение <see langword="BSTR" />, содержащее имя динамической библиотеки DLL.</param>
		/// <param name="pBstrName">Если значение не равно <see langword="null" />, функция задает для параметра lpbstrName значение <see langword="BSTR" />, содержащее имя точки входа.</param>
		/// <param name="pwOrdinal">Если значение не равно <see langword="null" /> и функция определена порядковым номером, то параметр lpwOrdinal должен указывать на порядковый номер.</param>
		// Token: 0x0600410B RID: 16651
		void GetDllEntry(int memid, INVOKEKIND invKind, out string pBstrDllName, out string pBstrName, out short pwOrdinal);

		/// <summary>Если описание типа ссылается на другие описания типов, извлекаются описания типов, на которые указывают ссылки.</summary>
		/// <param name="hRef">Возвращаемый дескриптор для описания ссылочного типа.</param>
		/// <param name="ppTI">При удачном возвращении — описание ссылочного типа.</param>
		// Token: 0x0600410C RID: 16652
		void GetRefTypeInfo(int hRef, out UCOMITypeInfo ppTI);

		/// <summary>Извлекает адреса статических функций и переменных, определенных в библиотеке DLL.</summary>
		/// <param name="memid">Идентификационный номер элемента для извлекаемого адреса элемента типа <see langword="static" />.</param>
		/// <param name="invKind">Показывает, является ли элемент свойством, и если да, то какого рода.</param>
		/// <param name="ppv">При успешном возвращении — ссылка на элемент типа <see langword="static" />.</param>
		// Token: 0x0600410D RID: 16653
		void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);

		/// <summary>Создает новый экземпляр типа, описывающего класс компонента (совместный класс).</summary>
		/// <param name="pUnkOuter">Объект, действующий как управляющий <see langword="IUnknown" />.</param>
		/// <param name="riid">Идентификатор IID интерфейса, используемый вызывающим объектом для связи с итоговым объектом.</param>
		/// <param name="ppvObj">При успешном возвращении — ссылка на созданный объект.</param>
		// Token: 0x0600410E RID: 16654
		void CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

		/// <summary>Извлекает сведения о маршалинге.</summary>
		/// <param name="memid">Идентификатор элемента, показывающий, какие необходимы сведения о маршалинге.</param>
		/// <param name="pBstrMops">Ссылка на строку кода операции, используемую при маршалинге полей структуры, описанной в описании ссылочного типа, либо <see langword="null" />, если сведения отсутствуют.</param>
		// Token: 0x0600410F RID: 16655
		void GetMops(int memid, out string pBstrMops);

		/// <summary>Извлекает библиотеку типов, содержащую описание этого типа и его индекс внутри этой библиотеки типов.</summary>
		/// <param name="ppTLB">При успешном возвращении — ссылка на содержащую тип библиотеку типов.</param>
		/// <param name="pIndex">При успешном возвращении — ссылка на индекс описания типа внутри содержащей его библиотеки типов.</param>
		// Token: 0x06004110 RID: 16656
		void GetContainingTypeLib(out UCOMITypeLib ppTLB, out int pIndex);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.TYPEATTR" />, возвращенную ранее методом <see cref="M:System.Runtime.InteropServices.UCOMITypeInfo.GetTypeAttr(System.IntPtr@)" />.</summary>
		/// <param name="pTypeAttr">Ссылка на освобождаемую структуру <see langword="TYPEATTR" />.</param>
		// Token: 0x06004111 RID: 16657
		void ReleaseTypeAttr(IntPtr pTypeAttr);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />, возвращенную ранее методом <see cref="M:System.Runtime.InteropServices.UCOMITypeInfo.GetFuncDesc(System.Int32,System.IntPtr@)" />.</summary>
		/// <param name="pFuncDesc">Ссылка на освобождаемую структуру <see langword="FUNCDESC" />.</param>
		// Token: 0x06004112 RID: 16658
		void ReleaseFuncDesc(IntPtr pFuncDesc);

		/// <summary>Освобождает структуру <see langword="VARDESC" />, возвращенную ранее методом <see cref="M:System.Runtime.InteropServices.UCOMITypeInfo.GetVarDesc(System.Int32,System.IntPtr@)" />.</summary>
		/// <param name="pVarDesc">Ссылка на освобождаемую структуру <see langword="VARDESC" />.</param>
		// Token: 0x06004113 RID: 16659
		void ReleaseVarDesc(IntPtr pVarDesc);
	}
}
