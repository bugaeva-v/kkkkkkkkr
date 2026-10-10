using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Содержит атрибуты <see langword="UCOMITypeInfo" />.</summary>
	// Token: 0x020007B6 RID: 1974
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPEATTR
	{
		/// <summary>Константа, используемая с полями <see cref="F:System.Runtime.InteropServices.TYPEATTR.memidConstructor" /> и <see cref="F:System.Runtime.InteropServices.TYPEATTR.memidDestructor" />.</summary>
		// Token: 0x04002C7F RID: 11391
		public const int MEMBER_ID_NIL = -1;

		/// <summary>Идентификатор GUID информации о типе.</summary>
		// Token: 0x04002C80 RID: 11392
		public Guid guid;

		/// <summary>Языковой стандарт имен элементов и строк документации.</summary>
		// Token: 0x04002C81 RID: 11393
		public int lcid;

		/// <summary>Зарезервировано для будущего использования.</summary>
		// Token: 0x04002C82 RID: 11394
		public int dwReserved;

		/// <summary>Идентификатор конструктора или <see cref="F:System.Runtime.InteropServices.TYPEATTR.MEMBER_ID_NIL" />, если конструктор отсутствует.</summary>
		// Token: 0x04002C83 RID: 11395
		public int memidConstructor;

		/// <summary>Идентификатор деструктора или <see cref="F:System.Runtime.InteropServices.TYPEATTR.MEMBER_ID_NIL" />, если деструктор отсутствует.</summary>
		// Token: 0x04002C84 RID: 11396
		public int memidDestructor;

		/// <summary>Зарезервировано для будущего использования.</summary>
		// Token: 0x04002C85 RID: 11397
		public IntPtr lpstrSchema;

		/// <summary>Размер экземпляра этого типа.</summary>
		// Token: 0x04002C86 RID: 11398
		public int cbSizeInstance;

		/// <summary>Значение <see cref="T:System.Runtime.InteropServices.TYPEKIND" />, описывающее тип, описанный этими данными.</summary>
		// Token: 0x04002C87 RID: 11399
		public TYPEKIND typekind;

		/// <summary>Указывает количество функций в интерфейсе, описанном структурой.</summary>
		// Token: 0x04002C88 RID: 11400
		public short cFuncs;

		/// <summary>Указывает число переменных и полей данных в интерфейсе, описанном структурой.</summary>
		// Token: 0x04002C89 RID: 11401
		public short cVars;

		/// <summary>Указывает количество реализованных интерфейсов в интерфейсе, описанном структурой.</summary>
		// Token: 0x04002C8A RID: 11402
		public short cImplTypes;

		/// <summary>Размер таблицы виртуальных методов этого типа (VTBL).</summary>
		// Token: 0x04002C8B RID: 11403
		public short cbSizeVft;

		/// <summary>Задает выравнивание по границе байта для экземпляра этого типа.</summary>
		// Token: 0x04002C8C RID: 11404
		public short cbAlignment;

		/// <summary>Значение <see cref="T:System.Runtime.InteropServices.TYPEFLAGS" />, описывающее эти данные.</summary>
		// Token: 0x04002C8D RID: 11405
		public TYPEFLAGS wTypeFlags;

		/// <summary>Основной номер версии.</summary>
		// Token: 0x04002C8E RID: 11406
		public short wMajorVerNum;

		/// <summary>Дополнительный номер версии.</summary>
		// Token: 0x04002C8F RID: 11407
		public short wMinorVerNum;

		/// <summary>Если <see cref="F:System.Runtime.InteropServices.TYPEATTR.typekind" /> == <see cref="F:System.Runtime.InteropServices.TYPEKIND.TKIND_ALIAS" />, определяет тип, для которого данный тип является псевдонимом.</summary>
		// Token: 0x04002C90 RID: 11408
		public TYPEDESC tdescAlias;

		/// <summary>Атрибуты IDL описанного типа.</summary>
		// Token: 0x04002C91 RID: 11409
		public IDLDESC idldescType;
	}
}
