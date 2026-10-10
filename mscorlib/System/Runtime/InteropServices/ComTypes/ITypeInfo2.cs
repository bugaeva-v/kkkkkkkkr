using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="ITypeInfo2" />.</summary>
	// Token: 0x020007CA RID: 1994
	[Guid("00020412-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface ITypeInfo2 : ITypeInfo
	{
		/// <summary>Возвращает структуру <see cref="T:System.Runtime.InteropServices.TYPEATTR" />, содержащую атрибуты описания типа.</summary>
		/// <param name="ppTypeAttr">При возвращении данного метода содержит ссылку на структуру, содержащую атрибуты этого описания типа. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600456E RID: 17774
		void GetTypeAttr(out IntPtr ppTypeAttr);

		/// <summary>Извлекает интерфейс <see langword="ITypeComp" /> описания типа, позволяющий компилятору клиента выполнить привязку к элементам описания типа.</summary>
		/// <param name="ppTComp">При возвращении данного метода содержит ссылку на <see langword="ITypeComp" /> содержащей библиотеки типов. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600456F RID: 17775
		void GetTypeComp(out ITypeComp ppTComp);

		/// <summary>Возвращает структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />, содержащую сведения о заданной функции.</summary>
		/// <param name="index">Индекс возвращаемого описания функции.</param>
		/// <param name="ppFuncDesc">При возвращении данного метода содержит ссылку на структуру <see langword="FUNCDESC" />, описывающую заданную функцию. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004570 RID: 17776
		void GetFuncDesc(int index, out IntPtr ppFuncDesc);

		/// <summary>Извлекает структуру <see langword="VARDESC" />, описывающую указанную переменную.</summary>
		/// <param name="index">Индекс возвращаемого описания переменной.</param>
		/// <param name="ppVarDesc">При возвращении данного метода содержит ссылку на структуру <see langword="VARDESC" />, описывающую заданную переменную. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004571 RID: 17777
		void GetVarDesc(int index, out IntPtr ppVarDesc);

		/// <summary>Извлекает переменную с указанным идентификатором (либо имя свойства или метода и его параметры), соответствующую заданному идентификатору функции.</summary>
		/// <param name="memid">Идентификатор элемента, для которого возвращается имя (или имена).</param>
		/// <param name="rgBstrNames">При возвращении данного метода содержит имя (или имена), связанное с элементом. Этот параметр передается неинициализированным.</param>
		/// <param name="cMaxNames">Длина массива <paramref name="rgBstrNames" />.</param>
		/// <param name="pcNames">При возвращении данного метода содержит число имен в массиве <paramref name="rgBstrNames" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004572 RID: 17778
		void GetNames(int memid, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] [Out] string[] rgBstrNames, int cMaxNames, out int pcNames);

		/// <summary>Извлекает описание типа для реализованных типов интерфейсов, если в описании типа описывается класс COM.</summary>
		/// <param name="index">Индекс реализованного типа, дескриптор которого возвращается.</param>
		/// <param name="href">При возвращении данного метода содержит ссылку на дескриптор для реализованного интерфейса. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004573 RID: 17779
		void GetRefTypeOfImplType(int index, out int href);

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.IMPLTYPEFLAGS" /> для одного реализованного интерфейса или базового интерфейса в описании типа.</summary>
		/// <param name="index">Индекс реализованного интерфейса или базового интерфейса.</param>
		/// <param name="pImplTypeFlags">При возвращении данного метода содержит ссылку на перечисление <see langword="IMPLTYPEFLAGS" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004574 RID: 17780
		void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);

		/// <summary>Сопоставляет друг с другом имена и идентификаторы элементов и параметров.</summary>
		/// <param name="rgszNames">Массив имен, которые следует сопоставить.</param>
		/// <param name="cNames">Число сопоставляемых имен.</param>
		/// <param name="pMemId">При возвращении данного метода содержит ссылку на массив, в который помещены сопоставления имен. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004575 RID: 17781
		void GetIDsOfNames([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] [In] string[] rgszNames, int cNames, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] int[] pMemId);

		/// <summary>Вызывает метод или обращается к свойству объекта, реализующему интерфейс, описанный в описании типа.</summary>
		/// <param name="pvInstance">Ссылка на интерфейс, описанный в данном описании типа.</param>
		/// <param name="memid">Идентификатор элемента интерфейса.</param>
		/// <param name="wFlags">Флаги, описывающие контекст используемого вызова.</param>
		/// <param name="pDispParams">Ссылка на структуру, содержащую массив аргументов, массив идентификаторов DISPID именованных аргументов, а также количество элементов в каждом массиве.</param>
		/// <param name="pVarResult">Ссылка на место хранения результата. Если <paramref name="wFlags" /> задает <see langword="DISPATCH_PROPERTYPUT" /> или <see langword="DISPATCH_PROPERTYPUTREF" />, то параметр <paramref name="pVarResult" /> не учитывается. Если результат не требуется, можно задать значение <see langword="null" />.</param>
		/// <param name="pExcepInfo">Указатель на структуру сведений об исключении, заполняемую только при возвращении <see langword="DISP_E_EXCEPTION" />.</param>
		/// <param name="puArgErr">Если <see langword="Invoke" /> возвращает <see langword="DISP_E_TYPEMISMATCH" />, то параметр <paramref name="puArgErr" /> показывает индекс аргумента с неверным типом. Если ошибка возвращается для нескольких аргументов, <paramref name="puArgErr" /> показывает только первый из них.</param>
		// Token: 0x06004576 RID: 17782
		void Invoke([MarshalAs(UnmanagedType.IUnknown)] object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);

		/// <summary>Извлекает строку документации, полный файл справки и путь к нему, а также идентификатор контекста разделов справки для заданного описания типа.</summary>
		/// <param name="index">Идентификатор элемента, для которого возвращается документация.</param>
		/// <param name="strName">При возвращении данного метода содержит имя метода элемента. Этот параметр передается неинициализированным.</param>
		/// <param name="strDocString">При возвращении данного метода содержит строку документации для заданного элемента. Этот параметр передается неинициализированным.</param>
		/// <param name="dwHelpContext">При возвращении данного метода содержит ссылку на контекст справки, связанный с заданным элементом. Этот параметр передается неинициализированным.</param>
		/// <param name="strHelpFile">При возвращении данного метода содержит полное имя файла справки. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004577 RID: 17783
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		/// <summary>Возвращает описание или спецификацию точки входа для функции в динамической библиотеке DLL.</summary>
		/// <param name="memid">Идентификатор функции элемента, для которого возвращается описание входа динамической библиотеки DLL.</param>
		/// <param name="invKind">Одно из значений <see cref="T:System.Runtime.InteropServices.ComTypes.INVOKEKIND" />, указывающее тип элемента, определенного с помощью <paramref name="memid" />.</param>
		/// <param name="pBstrDllName">Если значение не равно <see langword="null" />, функция задает для параметра <paramref name="pBstrDllName" /> значение <see langword="BSTR" />, содержащее имя динамической библиотеки DLL.</param>
		/// <param name="pBstrName">Если значение не равно <see langword="null" />, функция задает для параметра lpbstrName значение <see langword="BSTR" />, содержащее имя точки входа.</param>
		/// <param name="pwOrdinal">Если значение не равно <see langword="null" /> и функция определена порядковым номером, то параметр lpwOrdinal должен указывать на порядковый номер.</param>
		// Token: 0x06004578 RID: 17784
		void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);

		/// <summary>Извлекает описания типов, на которые указывают ссылки, если описание типа ссылается на другие описания типов.</summary>
		/// <param name="hRef">Возвращаемый дескриптор для описания ссылочного типа.</param>
		/// <param name="ppTI">При возвращении данного метода содержит описание ссылочного типа. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004579 RID: 17785
		void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);

		/// <summary>Извлекает адреса статических функций и переменных, определенных в библиотеке DLL.</summary>
		/// <param name="memid">Идентификатор элемента для извлекаемого адреса элемента типа <see langword="static" />.</param>
		/// <param name="invKind">Одно из значений <see cref="T:System.Runtime.InteropServices.ComTypes.INVOKEKIND" />, указывающее, является ли член свойством, и, если да, то какого типа.</param>
		/// <param name="ppv">При возвращении данного метода содержит ссылку на элемент <see langword="static" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600457A RID: 17786
		void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);

		/// <summary>Создает новый экземпляр типа, описывающего класс компонента (совместный класс).</summary>
		/// <param name="pUnkOuter">Объект, действующий как контролирующий <see langword="IUnknown" />.</param>
		/// <param name="riid">Идентификатор IID интерфейса, используемый вызывающим объектом для связи с итоговым объектом.</param>
		/// <param name="ppvObj">При возвращении данного метода содержит ссылку на созданный объект. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600457B RID: 17787
		void CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

		/// <summary>Извлекает сведения о маршалинге.</summary>
		/// <param name="memid">Идентификатор элемента, показывающий, какие необходимы сведения о маршалинге.</param>
		/// <param name="pBstrMops">При возвращении данного метода содержит ссылку на строку <see langword="opcode" />, используемую при маршалинге полей структуры, описанной в описании ссылочного типа, либо возвращает <see langword="null" />, если сведения отсутствуют. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600457C RID: 17788
		void GetMops(int memid, out string pBstrMops);

		/// <summary>Извлекает библиотеку типов, содержащую описание этого типа и его индекс внутри этой библиотеки типов.</summary>
		/// <param name="ppTLB">При возвращении данного метода содержит ссылку на содержащую библиотеку типов. Этот параметр передается неинициализированным.</param>
		/// <param name="pIndex">При возвращении данного метода содержит ссылку на индекс описания типа в содержащей библиотеке типов. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600457D RID: 17789
		void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.TYPEATTR" />, ранее возвращенную методом <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetTypeAttr(System.IntPtr@)" />.</summary>
		/// <param name="pTypeAttr">Ссылка на освобождаемую структуру <see langword="TYPEATTR" />.</param>
		// Token: 0x0600457E RID: 17790
		[PreserveSig]
		void ReleaseTypeAttr(IntPtr pTypeAttr);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />, ранее возвращенную методом <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetFuncDesc(System.Int32,System.IntPtr@)" />.</summary>
		/// <param name="pFuncDesc">Ссылка на освобождаемую структуру <see langword="FUNCDESC" />.</param>
		// Token: 0x0600457F RID: 17791
		[PreserveSig]
		void ReleaseFuncDesc(IntPtr pFuncDesc);

		/// <summary>Освобождает структуру <see langword="VARDESC" />, ранее возвращенную методом <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetVarDesc(System.Int32,System.IntPtr@)" />.</summary>
		/// <param name="pVarDesc">Ссылка на освобождаемую структуру <see langword="VARDESC" />.</param>
		// Token: 0x06004580 RID: 17792
		[PreserveSig]
		void ReleaseVarDesc(IntPtr pVarDesc);

		/// <summary>Возвращает перечисление <see langword="TYPEKIND" /> быстро и без распределения.</summary>
		/// <param name="pTypeKind">При возврате этого метода содержит ссылку <see langword="TYPEKIND" /> на перечисление. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004581 RID: 17793
		void GetTypeKind(out TYPEKIND pTypeKind);

		/// <summary>Возвращает флаги типа без каких-либо распределений. Этот метод возвращает флаг типа <see langword="DWORD" />, который расширяет флаги типа, не увеличивая <see langword="TYPEATTR" /> (атрибут типа).</summary>
		/// <param name="pTypeFlags">При возврате этого метода содержит ссылку <see langword="DWORD" /> на <see langword="TYPEFLAG" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004582 RID: 17794
		void GetTypeFlags(out int pTypeFlags);

		/// <summary>Привязывает к определенному члену на основе известного идентификатора DISPID с неизвестным именем члена (например, при привязке к элементу по умолчанию).</summary>
		/// <param name="memid">Идентификатор члена.</param>
		/// <param name="invKind">Одно из значений <see cref="T:System.Runtime.InteropServices.ComTypes.INVOKEKIND" />, которые определяют тип члена (определяется memid).</param>
		/// <param name="pFuncIndex">При возврате этого метода содержит индекс, используемый в функции. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004583 RID: 17795
		void GetFuncIndexOfMemId(int memid, INVOKEKIND invKind, out int pFuncIndex);

		/// <summary>Привязывает к определенному элементу на основе известного идентификатора <see langword="DISPID" /> с неизвестным именем элемента (например, при привязке к элементу по умолчанию).</summary>
		/// <param name="memid">Идентификатор члена.</param>
		/// <param name="pVarIndex">При возврате этого метода этот параметр содержит индекс <paramref name="memid" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004584 RID: 17796
		void GetVarIndexOfMemId(int memid, out int pVarIndex);

		/// <summary>Возвращает пользовательские данные.</summary>
		/// <param name="guid">GUID, используемый для определения данных.</param>
		/// <param name="pVarVal">При возврате этого метода содержит объект <see langword="Object" /> для определения расположения полученных данных. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004585 RID: 17797
		void GetCustData(ref Guid guid, out object pVarVal);

		/// <summary>Получает пользовательские данные из указанной функции.</summary>
		/// <param name="index">Индекс функции, для которой следует получить пользовательские данные.</param>
		/// <param name="guid">GUID, используемый для определения данных.</param>
		/// <param name="pVarVal">При возврате этого метода содержит <see langword="Object" /> для определения расположения размещаемых данных. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004586 RID: 17798
		void GetFuncCustData(int index, ref Guid guid, out object pVarVal);

		/// <summary>Возвращает заданный параметр пользовательских данных.</summary>
		/// <param name="indexFunc">Индекс функции, для которой следует получить пользовательские данные.</param>
		/// <param name="indexParam">Индекс параметра функции, для которого следует получить пользовательские данные.</param>
		/// <param name="guid">GUID, используемый для определения данных.</param>
		/// <param name="pVarVal">При возврате этого метода содержит объект <see langword="Object" /> для определения расположения полученных данных. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004587 RID: 17799
		void GetParamCustData(int indexFunc, int indexParam, ref Guid guid, out object pVarVal);

		/// <summary>Возвращает переменную для пользовательских данных.</summary>
		/// <param name="index">Индекс переменной, для которой будут получены пользовательские данные.</param>
		/// <param name="guid">GUID, используемый для определения данных.</param>
		/// <param name="pVarVal">При возврате этого метода содержит объект <see langword="Object" /> для определения расположения полученных данных. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004588 RID: 17800
		void GetVarCustData(int index, ref Guid guid, out object pVarVal);

		/// <summary>Получает тип реализации пользовательских данных.</summary>
		/// <param name="index">Индекс типа реализации для пользовательских данных.</param>
		/// <param name="guid">GUID, используемый для определения данных.</param>
		/// <param name="pVarVal">При возврате этого метода содержит объект <see langword="Object" /> для определения расположения полученных данных. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004589 RID: 17801
		void GetImplTypeCustData(int index, ref Guid guid, out object pVarVal);

		/// <summary>Позволяет получить строку документирования, полное имя файла справки и путь к нему, контекст локализации, который следует использовать, и идентификатор контекста для раздела справки библиотеки в файле справки.</summary>
		/// <param name="memid">Идентификатор элемента для описания типа.</param>
		/// <param name="pbstrHelpString">После выполнения возврата этим методом содержит параметр <see langword="BSTR" /> с именем указанного элемента. Если вызывающему объекту не требуется имя элемента, параметр <paramref name="pbstrHelpString" /> может иметь значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pdwHelpStringContext">После выполнения возврата этим методом содержит контекст локализации справки. Если вызывающему объекту не требуется контекст справки, параметр <paramref name="pdwHelpStringContext" /> может иметь значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pbstrHelpStringDll">После выполнения возврата этим методом содержит параметр <see langword="BSTR" />с полным именем файла, который, в свою очередь, содержит библиотеку DLL, используемую для файла справки. Если вызывающему объекту не требуется имя файла, параметр <paramref name="pbstrHelpStringDll" /> может иметь значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600458A RID: 17802
		[LCIDConversion(1)]
		void GetDocumentation2(int memid, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);

		/// <summary>Возвращает все пользовательские элементы данных для библиотеки.</summary>
		/// <param name="pCustData">Указатель на объект <see langword="CUSTDATA" />, который содержит все пользовательские элементы данных.</param>
		// Token: 0x0600458B RID: 17803
		void GetAllCustData(IntPtr pCustData);

		/// <summary>Получает все пользовательские данные из заданной функции.</summary>
		/// <param name="index">Индекс функции, для которой следует получить пользовательские данные.</param>
		/// <param name="pCustData">Указатель на объект <see langword="CUSTDATA" />, который содержит все пользовательские элементы данных.</param>
		// Token: 0x0600458C RID: 17804
		void GetAllFuncCustData(int index, IntPtr pCustData);

		/// <summary>Возвращает все пользовательские данные для указанного параметра функции.</summary>
		/// <param name="indexFunc">Индекс функции, для которой следует получить пользовательские данные.</param>
		/// <param name="indexParam">Индекс параметра функции, для которого следует получить пользовательские данные.</param>
		/// <param name="pCustData">Указатель на объект <see langword="CUSTDATA" />, который содержит все пользовательские элементы данных.</param>
		// Token: 0x0600458D RID: 17805
		void GetAllParamCustData(int indexFunc, int indexParam, IntPtr pCustData);

		/// <summary>Возвращает переменную для пользовательских данных.</summary>
		/// <param name="index">Индекс переменной, для которой будут получены пользовательские данные.</param>
		/// <param name="pCustData">Указатель на объект <see langword="CUSTDATA" />, который содержит все пользовательские элементы данных.</param>
		// Token: 0x0600458E RID: 17806
		void GetAllVarCustData(int index, IntPtr pCustData);

		/// <summary>Возвращает все пользовательские данные для указанного типа реализации.</summary>
		/// <param name="index">Индекс типа реализации для пользовательских данных.</param>
		/// <param name="pCustData">Указатель на объект <see langword="CUSTDATA" />, который содержит все пользовательские элементы данных.</param>
		// Token: 0x0600458F RID: 17807
		void GetAllImplTypeCustData(int index, IntPtr pCustData);
	}
}
