using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет порядок маршалинга параметров или полей в неуправляемый код.</summary>
	// Token: 0x020006FD RID: 1789
	[ComVisible(true)]
	[Serializable]
	public enum UnmanagedType
	{
		/// <summary>4-байтовое логическое значение (<see langword="true" /> != 0, <see langword="false" /> = 0). Это тип BOOL платформы Win32.</summary>
		// Token: 0x04002AA1 RID: 10913
		Bool = 2,
		/// <summary>1-байтовое целое число со знаком. Этот элемент можно использовать для преобразования логического значения типа в 1-байтовое значение <see langword="bool" /> в стиле языка C (<see langword="true" /> = 1, <see langword="false" /> = 0).</summary>
		// Token: 0x04002AA2 RID: 10914
		I1,
		/// <summary>1-байтовое целое число без знака.</summary>
		// Token: 0x04002AA3 RID: 10915
		U1,
		/// <summary>2-байтовое целое число со знаком.</summary>
		// Token: 0x04002AA4 RID: 10916
		I2,
		/// <summary>2-байтовое целое число без знака.</summary>
		// Token: 0x04002AA5 RID: 10917
		U2,
		/// <summary>4-байтовое целое число со знаком.</summary>
		// Token: 0x04002AA6 RID: 10918
		I4,
		/// <summary>4-байтовое целое число без знака.</summary>
		// Token: 0x04002AA7 RID: 10919
		U4,
		/// <summary>8-байтовое целое число со знаком.</summary>
		// Token: 0x04002AA8 RID: 10920
		I8,
		/// <summary>8-байтовое целое число без знака.</summary>
		// Token: 0x04002AA9 RID: 10921
		U8,
		/// <summary>4-байтовое число с плавающей запятой.</summary>
		// Token: 0x04002AAA RID: 10922
		R4,
		/// <summary>8-байтовое число с плавающей запятой.</summary>
		// Token: 0x04002AAB RID: 10923
		R8,
		/// <summary>Тип валюты. Используется в <see cref="T:System.Decimal" /> для маршалинга десятичного значения как типа денежной единицы COM, вместо <see langword="Decimal" />.</summary>
		// Token: 0x04002AAC RID: 10924
		Currency = 15,
		/// <summary>Двухбайтовая строка символов Юникода с префиксом, обозначающим ее длину. Этот элемент, являющийся строкой, определенной в COM по умолчанию, можно использовать для типа данных <see cref="T:System.String" />.</summary>
		// Token: 0x04002AAD RID: 10925
		BStr = 19,
		/// <summary>Однобайтовая строка знаков ANSI, заканчивающаяся нулем. Этот элемент можно использовать для типов данных <see cref="T:System.String" /> и <see cref="T:System.Text.StringBuilder" />.</summary>
		// Token: 0x04002AAE RID: 10926
		LPStr,
		/// <summary>2-байтовая строка символов Юникода, заканчивающаяся нулем.</summary>
		// Token: 0x04002AAF RID: 10927
		LPWStr,
		/// <summary>Строка символов, зависящих от платформы: ANSI для Windows 98, Юникод для Windows NT и Windows XP. Это значение поддерживается только для вызова неуправляемого кода и не используется для COM-взаимодействия, поскольку экспортирование строки типа <see langword="LPTStr" /> не поддерживается.</summary>
		// Token: 0x04002AB0 RID: 10928
		LPTStr,
		/// <summary>Используется для встроенных массивов знаков фиксированной длины, появляющихся в структуре. Тип символа, используемый с <see cref="F:System.Runtime.InteropServices.UnmanagedType.ByValTStr" />, определяется аргументом <see cref="T:System.Runtime.InteropServices.CharSet" /> атрибута <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" />, примененным к содержащей его структуре. Для задания размера массива всегда следует использовать поле <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.SizeConst" />.</summary>
		// Token: 0x04002AB1 RID: 10929
		ByValTStr,
		/// <summary>Указатель COM <see langword="IUnknown" />. Этот элемент можно использовать для типа данных <see cref="T:System.Object" />.</summary>
		// Token: 0x04002AB2 RID: 10930
		IUnknown = 25,
		/// <summary>Указатель COM <see langword="IDispatch" /> (<see langword="Object" /> в Microsoft Visual Basic 6.0).</summary>
		// Token: 0x04002AB3 RID: 10931
		IDispatch,
		/// <summary>Значение типа VARIANT, используемое для маршалинга управляемых форматируемых классов и типов значений.</summary>
		// Token: 0x04002AB4 RID: 10932
		Struct,
		/// <summary>Указатель интерфейса COM. Идентификатор <see cref="T:System.Guid" /> интерфейса получен из класса метаданных. Этот элемент можно использовать для указания точного типа интерфейса или типа интерфейса, используемого по умолчанию при применении к классу. Этот элемент определяет такое же поведение, что и <see cref="F:System.Runtime.InteropServices.UnmanagedType.IUnknown" />, при его применении к типу данных <see cref="T:System.Object" />.</summary>
		// Token: 0x04002AB5 RID: 10933
		Interface,
		/// <summary>
		///   <see langword="SafeArray" /> — это описывающий сам себя массив, передающий тип, ранг и границы соответствующего массива данных. Этот элемент можно использовать с полем <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.SafeArraySubType" />, чтобы переопределить тип элемента, заданный по умолчанию.</summary>
		// Token: 0x04002AB6 RID: 10934
		SafeArray,
		/// <summary>Если свойство <see cref="P:System.Runtime.InteropServices.MarshalAsAttribute.Value" /> равно <see langword="ByValArray" />, то для указания числа элементов массива следует задать поле <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.SizeConst" />. Если требуется различать типы строк, поле <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.ArraySubType" /> может содержать тип <see cref="T:System.Runtime.InteropServices.UnmanagedType" /> элементов массива. <see cref="T:System.Runtime.InteropServices.UnmanagedType" /> можно использовать только для массива, элементы которого отображаются как поля в структуре.</summary>
		// Token: 0x04002AB7 RID: 10935
		ByValArray,
		/// <summary>Зависящее от платформы целое число со знаком: 4 байта в 32-разрядной Windows, 8 байт в 64-разрядной Windows.</summary>
		// Token: 0x04002AB8 RID: 10936
		SysInt,
		/// <summary>Зависящее от платформы целое число без знака: 4 байта в 32-разрядной Windows, 8 байт в 64-разрядной Windows.</summary>
		// Token: 0x04002AB9 RID: 10937
		SysUInt,
		/// <summary>Значение, позволяющее Visual Basic изменять строку в неуправляемом коде и получать результаты, отраженные в управляемом коде. Это значение поддерживается только для вызова неуправляемого кода.</summary>
		// Token: 0x04002ABA RID: 10938
		VBByRefStr = 34,
		/// <summary>Строка однобайтовых знаков ANSI с префиксом, обозначающим ее длину. Этот элемент можно использовать для типа данных <see cref="T:System.String" />.</summary>
		// Token: 0x04002ABB RID: 10939
		AnsiBStr,
		/// <summary>Зависящая от платформы строка <see langword="char" />, предваряемая длиной: ANSI для Windows 98, Юникод для Windows NT. Этот элемент, аналогичный BSTR, используется редко.</summary>
		// Token: 0x04002ABC RID: 10940
		TBStr,
		/// <summary>2-байтовое значение типа VARIANT_BOOL, определенное OLE (<see langword="true" /> = -1, <see langword="false" /> = 0).</summary>
		// Token: 0x04002ABD RID: 10941
		VariantBool,
		/// <summary>Целое число, которое может использоваться как указатель функции в стиле языка С. Этот элемент можно использовать для типа данных <see cref="T:System.Delegate" /> или типа, наследуемого от <see cref="T:System.Delegate" />.</summary>
		// Token: 0x04002ABE RID: 10942
		FunctionPtr,
		/// <summary>Динамический тип, который определяет тип объекта во время выполнения и маршалирует объект как объекта данного типа. Этот член является допустимым только для методов вызова неуправляемого кода.</summary>
		// Token: 0x04002ABF RID: 10943
		AsAny = 40,
		/// <summary>Указатель на первый элемент массива в стиле языка C. При маршалинге из управляемого кода в неуправляемый длина массива определяется исходя из длины управляемого массива. При маршалинге из неуправляемого кода в управляемый длина массива определяется исходя из значений полей <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.SizeConst" /> и <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.SizeParamIndex" />, за которыми, если требуется различать тип строк, следует тип элементов неуправляемого массива.</summary>
		// Token: 0x04002AC0 RID: 10944
		LPArray = 42,
		/// <summary>Указатель на структуру в стиле языка C, используемую для маршалинга управляемых форматируемых классов. Этот член является допустимым только для методов вызова неуправляемого кода.</summary>
		// Token: 0x04002AC1 RID: 10945
		LPStruct,
		/// <summary>Задает класс настраиваемых модулей маршалинга при использовании с полем <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.MarshalType" /> или <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.MarshalTypeRef" />. Поле <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.MarshalCookie" /> можно использовать для передачи дополнительных сведений настраиваемому модулю маршалинга. Этот элемент можно использовать для всех ссылочных типов. Этот член допустим только для параметров и возвращаемых значений. Его нельзя использовать в полях.</summary>
		// Token: 0x04002AC2 RID: 10946
		CustomMarshaler,
		/// <summary>Собственный тип, связанный с <see cref="F:System.Runtime.InteropServices.UnmanagedType.I4" /> или <see cref="F:System.Runtime.InteropServices.UnmanagedType.U4" />, который приводит к экспорту параметра как значения HRESULT в экспортированной библиотеке типов.</summary>
		// Token: 0x04002AC3 RID: 10947
		Error,
		/// <summary>Указатель интерфейса Среда выполнения Windows. Этот элемент можно использовать для типа данных <see cref="T:System.Object" />.</summary>
		// Token: 0x04002AC4 RID: 10948
		[ComVisible(false)]
		IInspectable,
		/// <summary>Строка Среда выполнения Windows. Этот элемент можно использовать для типа данных <see cref="T:System.String" />.</summary>
		// Token: 0x04002AC5 RID: 10949
		[ComVisible(false)]
		HString,
		/// <summary>Указатель на строку в кодировке UTF-8.</summary>
		// Token: 0x04002AC6 RID: 10950
		[ComVisible(false)]
		LPUTF8Str
	}
}
