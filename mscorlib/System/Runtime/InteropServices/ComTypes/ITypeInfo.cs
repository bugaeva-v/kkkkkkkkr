using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса автоматизации компонентов ITypeInfo.</summary>
	// Token: 0x020007C9 RID: 1993
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00020401-0000-0000-C000-000000000046")]
	[ComImport]
	public interface ITypeInfo
	{
		/// <summary>Возвращает структуру <see cref="T:System.Runtime.InteropServices.TYPEATTR" />, содержащую атрибуты описания типа.</summary>
		/// <param name="ppTypeAttr">При возвращении данного метода содержит ссылку на структуру, содержащую атрибуты этого описания типа. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600455B RID: 17755
		void GetTypeAttr(out IntPtr ppTypeAttr);

		/// <summary>Извлекает интерфейс <see langword="ITypeComp" /> описания типа, позволяющий компилятору клиента выполнить привязку к элементам описания типа.</summary>
		/// <param name="ppTComp">При возвращении данного метода содержит ссылку на интерфейс <see langword="ITypeComp" /> содержащей библиотеки типов. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600455C RID: 17756
		void GetTypeComp(out ITypeComp ppTComp);

		/// <summary>Возвращает структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />, содержащую сведения о заданной функции.</summary>
		/// <param name="index">Индекс возвращаемого описания функции.</param>
		/// <param name="ppFuncDesc">При возвращении данного метода содержит ссылку на структуру <see langword="FUNCDESC" />, описывающую заданную функцию. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600455D RID: 17757
		void GetFuncDesc(int index, out IntPtr ppFuncDesc);

		/// <summary>Извлекает структуру <see langword="VARDESC" />, описывающую указанную переменную.</summary>
		/// <param name="index">Индекс возвращаемого описания переменной.</param>
		/// <param name="ppVarDesc">При возвращении данного метода содержит ссылку на структуру <see langword="VARDESC" />, описывающую заданную переменную. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600455E RID: 17758
		void GetVarDesc(int index, out IntPtr ppVarDesc);

		/// <summary>Извлекает переменную с указанным идентификатором (либо имя свойства или метода и его параметры), соответствующую заданному идентификатору функции.</summary>
		/// <param name="memid">Идентификатор элемента, для которого возвращается имя (или имена).</param>
		/// <param name="rgBstrNames">При возвращении данного метода содержит имя (или имена), связанное с элементом. Этот параметр передается неинициализированным.</param>
		/// <param name="cMaxNames">Длина массива <paramref name="rgBstrNames" />.</param>
		/// <param name="pcNames">При возвращении данного метода содержит число имен в массиве <paramref name="rgBstrNames" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600455F RID: 17759
		void GetNames(int memid, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] [Out] string[] rgBstrNames, int cMaxNames, out int pcNames);

		/// <summary>Извлекает описание типа для реализованных типов интерфейсов, если в описании типа описывается класс COM.</summary>
		/// <param name="index">Индекс реализованного типа, дескриптор которого возвращается.</param>
		/// <param name="href">При возвращении данного метода содержит ссылку на дескриптор для реализованного интерфейса. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004560 RID: 17760
		void GetRefTypeOfImplType(int index, out int href);

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.IMPLTYPEFLAGS" /> для одного реализованного интерфейса или базового интерфейса в описании типа.</summary>
		/// <param name="index">Индекс реализованного интерфейса или базового интерфейса.</param>
		/// <param name="pImplTypeFlags">При возвращении данного метода содержит ссылку на перечисление <see langword="IMPLTYPEFLAGS" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004561 RID: 17761
		void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);

		/// <summary>Сопоставляет друг с другом имена и идентификаторы элементов и параметров.</summary>
		/// <param name="rgszNames">Массив имен, которые следует сопоставить.</param>
		/// <param name="cNames">Число сопоставляемых имен.</param>
		/// <param name="pMemId">При возвращении данного метода содержит ссылку на массив, в который помещены сопоставления имен. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004562 RID: 17762
		void GetIDsOfNames([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] [In] string[] rgszNames, int cNames, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] int[] pMemId);

		/// <summary>Вызывает метод или обращается к свойству объекта, реализующему интерфейс, описанный в описании типа.</summary>
		/// <param name="pvInstance">Ссылка на интерфейс, описанный в данном описании типа.</param>
		/// <param name="memid">Значение, задающее элемент интерфейса.</param>
		/// <param name="wFlags">Флаги, описывающие контекст используемого вызова.</param>
		/// <param name="pDispParams">Ссылка на структуру, содержащую массив аргументов, массив идентификаторов DISPID именованных аргументов, а также количество элементов в каждом массиве.</param>
		/// <param name="pVarResult">Ссылка на место хранения результата. Если <paramref name="wFlags" /> задает <see langword="DISPATCH_PROPERTYPUT" /> или <see langword="DISPATCH_PROPERTYPUTREF" />, то параметр <paramref name="pVarResult" /> не учитывается. Если результат не требуется, можно задать значение <see langword="null" />.</param>
		/// <param name="pExcepInfo">Указатель на структуру сведений об исключении, заполняемую только при возвращении <see langword="DISP_E_EXCEPTION" />.</param>
		/// <param name="puArgErr">Если <see langword="Invoke" /> возвращает <see langword="DISP_E_TYPEMISMATCH" />, то параметр <paramref name="puArgErr" /> показывает индекс аргумента с неверным типом внутри rgvarg. Если ошибка возвращается для нескольких аргументов, <paramref name="puArgErr" /> показывает только первый из них. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004563 RID: 17763
		void Invoke([MarshalAs(UnmanagedType.IUnknown)] object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);

		/// <summary>Извлекает строку документации, полный файл справки и путь к нему, а также идентификатор контекста разделов справки для заданного описания типа.</summary>
		/// <param name="index">Идентификатор элемента, для которого возвращается документация.</param>
		/// <param name="strName">При возвращении данного метода содержит имя метода элемента. Этот параметр передается неинициализированным.</param>
		/// <param name="strDocString">При возвращении данного метода содержит строку документации для заданного элемента. Этот параметр передается неинициализированным.</param>
		/// <param name="dwHelpContext">При возвращении данного метода содержит ссылку на контекст справки, связанный с заданным элементом. Этот параметр передается неинициализированным.</param>
		/// <param name="strHelpFile">При возвращении данного метода содержит полное имя файла справки. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004564 RID: 17764
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		/// <summary>Возвращает описание или спецификацию точки входа для функции в динамической библиотеке DLL.</summary>
		/// <param name="memid">Идентификатор функции элемента, для которого возвращается описание входа динамической библиотеки DLL.</param>
		/// <param name="invKind">Одно из значений <see cref="T:System.Runtime.InteropServices.ComTypes.INVOKEKIND" />, указывающее тип элемента, определенного с помощью <paramref name="memid" />.</param>
		/// <param name="pBstrDllName">Если значение не равно <see langword="null" />, функция задает для параметра <paramref name="pBstrDllName" /> значение <see langword="BSTR" />, содержащее имя динамической библиотеки DLL.</param>
		/// <param name="pBstrName">Если значение не равно <see langword="null" />, функция задает для параметра lpbstrName значение <see langword="BSTR" />, содержащее имя точки входа.</param>
		/// <param name="pwOrdinal">Если значение не равно <see langword="null" /> и функция определена порядковым номером, то параметр lpwOrdinal должен указывать на порядковый номер.</param>
		// Token: 0x06004565 RID: 17765
		void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);

		/// <summary>Извлекает описания ссылочных типов, если описание типа ссылается на другие описания типов.</summary>
		/// <param name="hRef">Возвращаемый дескриптор для описания ссылочного типа.</param>
		/// <param name="ppTI">При возвращении данного метода содержит описание ссылочного типа. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004566 RID: 17766
		void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);

		/// <summary>Извлекает адреса статических функций и переменных, определенных в библиотеке DLL.</summary>
		/// <param name="memid">Идентификатор элемента для извлекаемого адреса элемента типа <see langword="static" />.</param>
		/// <param name="invKind">Одно из значений <see cref="T:System.Runtime.InteropServices.ComTypes.INVOKEKIND" />, указывающее, является ли член свойством, и, если да, то какого типа.</param>
		/// <param name="ppv">При возвращении данного метода содержит ссылку на элемент <see langword="static" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004567 RID: 17767
		void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);

		/// <summary>Создает новый экземпляр типа, описывающего класс компонента (совместный класс).</summary>
		/// <param name="pUnkOuter">Объект, действующий как управляющий <see langword="IUnknown" />.</param>
		/// <param name="riid">Идентификатор IID интерфейса, используемый вызывающим объектом для связи с итоговым объектом.</param>
		/// <param name="ppvObj">При возвращении данного метода содержит ссылку на созданный объект. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004568 RID: 17768
		void CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

		/// <summary>Извлекает сведения о маршалинге.</summary>
		/// <param name="memid">Идентификатор элемента, показывающий, какие необходимы сведения о маршалинге.</param>
		/// <param name="pBstrMops">При возвращении данного метода содержит ссылку на строку <see langword="opcode" />, используемую при маршалинге полей структуры, описанной в описании ссылочного типа, либо возвращает <see langword="null" />, если сведения отсутствуют. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004569 RID: 17769
		void GetMops(int memid, out string pBstrMops);

		/// <summary>Извлекает библиотеку типов, содержащую описание этого типа и его индекс внутри этой библиотеки типов.</summary>
		/// <param name="ppTLB">При возвращении данного метода содержит ссылку на содержащую библиотеку типов. Этот параметр передается неинициализированным.</param>
		/// <param name="pIndex">При возвращении данного метода содержит ссылку на индекс описания типа в содержащей библиотеке типов. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600456A RID: 17770
		void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.TYPEATTR" />, ранее возвращенную методом <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetTypeAttr(System.IntPtr@)" />.</summary>
		/// <param name="pTypeAttr">Ссылка на освобождаемую структуру <see langword="TYPEATTR" />.</param>
		// Token: 0x0600456B RID: 17771
		[PreserveSig]
		void ReleaseTypeAttr(IntPtr pTypeAttr);

		/// <summary>Освобождает структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />, ранее возвращенную методом <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetFuncDesc(System.Int32,System.IntPtr@)" />.</summary>
		/// <param name="pFuncDesc">Ссылка на освобождаемую структуру <see langword="FUNCDESC" />.</param>
		// Token: 0x0600456C RID: 17772
		[PreserveSig]
		void ReleaseFuncDesc(IntPtr pFuncDesc);

		/// <summary>Освобождает структуру <see langword="VARDESC" />, ранее возвращенную методом <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetVarDesc(System.Int32,System.IntPtr@)" />.</summary>
		/// <param name="pVarDesc">Ссылка на освобождаемую структуру <see langword="VARDESC" />.</param>
		// Token: 0x0600456D RID: 17773
		[PreserveSig]
		void ReleaseVarDesc(IntPtr pVarDesc);
	}
}
