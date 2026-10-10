using System;

namespace System.Reflection
{
	/// <summary>Указывает флаги, управляющие привязкой и способом, используемым отражением при поиске членов и типов.</summary>
	// Token: 0x02000893 RID: 2195
	[Flags]
	public enum BindingFlags
	{
		/// <summary>Указывает, что флаги привязки не заданы.</summary>
		// Token: 0x04002E68 RID: 11880
		Default = 0,
		/// <summary>Указывает, что регистр имени члена не должен учитываться во время привязки.</summary>
		// Token: 0x04002E69 RID: 11881
		IgnoreCase = 1,
		/// <summary>Указывает, что следует учитывать только члены, объявленные на уровне иерархии предоставленного типа. Унаследованные члены не учитываются.</summary>
		// Token: 0x04002E6A RID: 11882
		DeclaredOnly = 2,
		/// <summary>Указывает, что члены экземпляров следует включить в поиск.</summary>
		// Token: 0x04002E6B RID: 11883
		Instance = 4,
		/// <summary>Указывает, что статические члены следует включить в поиск.</summary>
		// Token: 0x04002E6C RID: 11884
		Static = 8,
		/// <summary>Указывает, что общедоступные члены следует включить в поиск.</summary>
		// Token: 0x04002E6D RID: 11885
		Public = 16,
		/// <summary>Указывает, что частные члены следует включить в поиск.</summary>
		// Token: 0x04002E6E RID: 11886
		NonPublic = 32,
		/// <summary>Указывает, что следует вернуть общедоступные и защищенные статические члены вверху иерархии. Частные статические члены в наследуемых классах не возвращаются. Статические члены включают поля, методы, события и свойства. Вложенные типы не возвращаются.</summary>
		// Token: 0x04002E6F RID: 11887
		FlattenHierarchy = 64,
		/// <summary>Указывает, что следует вызвать метод. Это не должен быть конструктор или инициализатор типа.  
		/// Этот флаг передается в метод <see langword="InvokeMember" /> для вызова метода.</summary>
		// Token: 0x04002E70 RID: 11888
		InvokeMethod = 256,
		/// <summary>Указывает, что отражение должно создавать экземпляр указанного типа. Вызывает конструктор, соответствующий указанным аргументам. Имя указанного члена игнорируется. Если тип поиска не указан, будет использоваться (Instance | Public). Невозможно вызвать инициализатор типа.  
		/// Этот флаг передается в метод <see langword="InvokeMember" /> для вызова конструктора.</summary>
		// Token: 0x04002E71 RID: 11889
		CreateInstance = 512,
		/// <summary>Указывает, что должно возвращаться значение заданного поля.  
		/// Этот флаг передается в метод <see langword="InvokeMember" /> для получения значения поля.</summary>
		// Token: 0x04002E72 RID: 11890
		GetField = 1024,
		/// <summary>Указывает, что следует установить значение заданного поля.  
		/// Этот флаг передается в метод <see langword="InvokeMember" /> для указания значения поля.</summary>
		// Token: 0x04002E73 RID: 11891
		SetField = 2048,
		/// <summary>Указывает, что должно возвращаться значение заданного свойства.  
		/// Этот флаг передается в метод <see langword="InvokeMember" /> для вызова метода считывания свойства.</summary>
		// Token: 0x04002E74 RID: 11892
		GetProperty = 4096,
		/// <summary>Указывает, что следует установить значение заданного свойства. Для свойств COM указание этого флага привязки эквивалентно заданию <see langword="PutDispProperty" /> и <see langword="PutRefDispProperty" />.  
		/// Этот флаг передается в метод <see langword="InvokeMember" /> для вызова метода задания свойства.</summary>
		// Token: 0x04002E75 RID: 11893
		SetProperty = 8192,
		/// <summary>Указывает, что следует вызвать член <see langword="PROPPUT" /> в объекте COM. <see langword="PROPPUT" /> указывает функцию, задающую свойства, которая использует значение. Используйте <see langword="PutDispProperty" />, если свойство содержит как объект <see langword="PROPPUT" />, так и <see langword="PROPPUTREF" />, и вам нужно определить, какой из них вызывается.</summary>
		// Token: 0x04002E76 RID: 11894
		PutDispProperty = 16384,
		/// <summary>Указывает, что следует вызвать член <see langword="PROPPUTREF" /> в объекте COM. <see langword="PROPPUTREF" /> указывает функцию, задающую свойство, которая использует ссылку вместо значения. Используйте <see langword="PutRefDispProperty" />, если свойство содержит как объект <see langword="PROPPUT" />, так и <see langword="PROPPUTREF" />, и вам нужно определить, какой из них вызывается.</summary>
		// Token: 0x04002E77 RID: 11895
		PutRefDispProperty = 32768,
		/// <summary>Указывает, что типы предоставленных аргументов должны точно совпадать с типами соответствующих формальных параметров. Отражение вызывает исключение, если вызывающий предоставляет ненулевой объект <see langword="Binder" />, так как это подразумевает, что вызывающий предоставляет реализации <see langword="BindToXXX" />, которые выберут соответствующий метод.</summary>
		// Token: 0x04002E78 RID: 11896
		ExactBinding = 65536,
		/// <summary>Не реализовано.</summary>
		// Token: 0x04002E79 RID: 11897
		SuppressChangeType = 131072,
		/// <summary>Возвращает набор членов, количество параметров у которых совпадает с количеством предоставленных аргументов. Этот флаг привязки используется для методов, имеющих параметры со значениями по умолчанию, и методов с переменными аргументами (varargs). Этот флаг должен использоваться только с <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />.</summary>
		// Token: 0x04002E7A RID: 11898
		OptionalParamBinding = 262144,
		/// <summary>Используется во взаимодействии COM для указания того, что возвращаемое значение члена можно игнорировать.</summary>
		// Token: 0x04002E7B RID: 11899
		IgnoreReturn = 16777216,
		// Token: 0x04002E7C RID: 11900
		DoNotWrapExceptions = 33554432
	}
}
