using System;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Представляет локальную переменную внутри метода или конструктора.</summary>
	// Token: 0x02000933 RID: 2355
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_LocalBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class LocalBuilder : LocalVariableInfo, _LocalBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060050F2 RID: 20722 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _LocalBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060050F3 RID: 20723 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _LocalBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060050F4 RID: 20724 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _LocalBuilder.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060050F5 RID: 20725 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _LocalBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x000FD7E0 File Offset: 0x000FB9E0
		internal LocalBuilder(Type t, ILGenerator ilgen)
		{
			this.type = t;
			this.ilgen = ilgen;
		}

		/// <summary>Задает имя и лексическую ограниченную область действия данной локальной переменной.</summary>
		/// <param name="name">Имя локальной переменной.</param>
		/// <param name="startOffset">Начальное смещение лексической ограниченной области действия локальной переменной.</param>
		/// <param name="endOffset">Конечное смещение лексической ограниченной области действия локальной переменной.</param>
		/// <exception cref="T:System.InvalidOperationException">Вмещающий тип был создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Для вмещающего модуля не определен интерфейс записи символьной информации.</exception>
		/// <exception cref="T:System.NotSupportedException">Эти локальные данные определены в динамическом методе, а не в методе динамического типа.</exception>
		// Token: 0x060050F7 RID: 20727 RVA: 0x000FD7F6 File Offset: 0x000FB9F6
		public void SetLocalSymInfo(string name, int startOffset, int endOffset)
		{
			this.name = name;
			this.startOffset = startOffset;
			this.endOffset = endOffset;
		}

		/// <summary>Задает имя данной локальной переменной.</summary>
		/// <param name="name">Имя локальной переменной.</param>
		/// <exception cref="T:System.InvalidOperationException">Вмещающий тип был создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Для вмещающего модуля не определен интерфейс записи символьной информации.</exception>
		/// <exception cref="T:System.NotSupportedException">Эти локальные данные определены в динамическом методе, а не в методе динамического типа.</exception>
		// Token: 0x060050F8 RID: 20728 RVA: 0x000FD80D File Offset: 0x000FBA0D
		public void SetLocalSymInfo(string name)
		{
			this.SetLocalSymInfo(name, 0, 0);
		}

		/// <summary>Возвращает тип локальной переменной.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> данной локальной переменной.</returns>
		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x000F3115 File Offset: 0x000F1315
		public override Type LocalType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Возвращает значение, указывающее, закреплен ли в памяти объект, на который ссылается локальная переменная.</summary>
		/// <returns>Значение <see langword="true" />, если объект, на который ссылается локальная переменная, закреплен в памяти; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x000F3105 File Offset: 0x000F1305
		public override bool IsPinned
		{
			get
			{
				return this.is_pinned;
			}
		}

		/// <summary>Возвращает начинающийся с нуля индекс локальной переменной в основном тексте метода.</summary>
		/// <returns>Целочисленное значение, которое представляет последовательность объявления локальной переменной в основном тексте метода.</returns>
		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x000F310D File Offset: 0x000F130D
		public override int LocalIndex
		{
			get
			{
				return (int)this.position;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x000FD818 File Offset: 0x000FBA18
		internal string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x000FD820 File Offset: 0x000FBA20
		internal int StartOffset
		{
			get
			{
				return this.startOffset;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x000FD828 File Offset: 0x000FBA28
		internal int EndOffset
		{
			get
			{
				return this.endOffset;
			}
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x000173AD File Offset: 0x000155AD
		internal LocalBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040031B3 RID: 12723
		private string name;

		// Token: 0x040031B4 RID: 12724
		internal ILGenerator ilgen;

		// Token: 0x040031B5 RID: 12725
		private int startOffset;

		// Token: 0x040031B6 RID: 12726
		private int endOffset;
	}
}
