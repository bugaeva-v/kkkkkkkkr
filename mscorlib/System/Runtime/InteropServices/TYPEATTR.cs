using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.TYPEATTR" />.</summary>
	// Token: 0x02000724 RID: 1828
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.TYPEATTR instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPEATTR
	{
		/// <summary>Константа, используемая с полями <see cref="F:System.Runtime.InteropServices.TYPEATTR.memidConstructor" /> и <see cref="F:System.Runtime.InteropServices.TYPEATTR.memidDestructor" />.</summary>
		// Token: 0x04002B2C RID: 11052
		public const int MEMBER_ID_NIL = -1;

		/// <summary>Идентификатор GUID информации о типе.</summary>
		// Token: 0x04002B2D RID: 11053
		public Guid guid;

		/// <summary>Языковой стандарт имен элементов и строк документации.</summary>
		// Token: 0x04002B2E RID: 11054
		public int lcid;

		/// <summary>Зарезервировано для будущего использования.</summary>
		// Token: 0x04002B2F RID: 11055
		public int dwReserved;

		/// <summary>Идентификатор конструктора или <see cref="F:System.Runtime.InteropServices.TYPEATTR.MEMBER_ID_NIL" />, если конструктор отсутствует.</summary>
		// Token: 0x04002B30 RID: 11056
		public int memidConstructor;

		/// <summary>Идентификатор деструктора или <see cref="F:System.Runtime.InteropServices.TYPEATTR.MEMBER_ID_NIL" />, если деструктор отсутствует.</summary>
		// Token: 0x04002B31 RID: 11057
		public int memidDestructor;

		/// <summary>Зарезервировано для будущего использования.</summary>
		// Token: 0x04002B32 RID: 11058
		public IntPtr lpstrSchema;

		/// <summary>Размер экземпляра этого типа.</summary>
		// Token: 0x04002B33 RID: 11059
		public int cbSizeInstance;

		/// <summary>Значение <see cref="T:System.Runtime.InteropServices.TYPEKIND" />, описывающее тип, описанный этими данными.</summary>
		// Token: 0x04002B34 RID: 11060
		public TYPEKIND typekind;

		/// <summary>Указывает количество функций в интерфейсе, описанном структурой.</summary>
		// Token: 0x04002B35 RID: 11061
		public short cFuncs;

		/// <summary>Указывает число переменных и полей данных в интерфейсе, описанном структурой.</summary>
		// Token: 0x04002B36 RID: 11062
		public short cVars;

		/// <summary>Указывает количество реализованных интерфейсов в интерфейсе, описанном структурой.</summary>
		// Token: 0x04002B37 RID: 11063
		public short cImplTypes;

		/// <summary>Размер таблицы виртуальных методов этого типа (VTBL).</summary>
		// Token: 0x04002B38 RID: 11064
		public short cbSizeVft;

		/// <summary>Задает выравнивание по границе байта для экземпляра этого типа.</summary>
		// Token: 0x04002B39 RID: 11065
		public short cbAlignment;

		/// <summary>Значение <see cref="T:System.Runtime.InteropServices.TYPEFLAGS" />, описывающее эти данные.</summary>
		// Token: 0x04002B3A RID: 11066
		public TYPEFLAGS wTypeFlags;

		/// <summary>Основной номер версии.</summary>
		// Token: 0x04002B3B RID: 11067
		public short wMajorVerNum;

		/// <summary>Дополнительный номер версии.</summary>
		// Token: 0x04002B3C RID: 11068
		public short wMinorVerNum;

		/// <summary>Если <see cref="F:System.Runtime.InteropServices.TYPEATTR.typekind" /> == <see cref="F:System.Runtime.InteropServices.TYPEKIND.TKIND_ALIAS" />, определяет тип, для которого данный тип является псевдонимом.</summary>
		// Token: 0x04002B3D RID: 11069
		public TYPEDESC tdescAlias;

		/// <summary>Атрибуты IDL описанного типа.</summary>
		// Token: 0x04002B3E RID: 11070
		public IDLDESC idldescType;
	}
}
