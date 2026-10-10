using System;
using System.Reflection.Emit;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к классу <see cref="T:System.Reflection.Emit.ConstructorBuilder" />.</summary>
	// Token: 0x02000767 RID: 1895
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ED3E4384-D7E2-3FA7-8FFD-8940D330519A")]
	[TypeLibImportClass(typeof(ConstructorBuilder))]
	[ComVisible(true)]
	public interface _ConstructorBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Массив сопоставляемых имен.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, выделенный вызывающим объектом, в который помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x060042DE RID: 17118
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Возвращает сведения о типе объекта, которые можно использовать для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x060042DF RID: 17119
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Когда выполнение этого метода завершается, содержит указатель, по которому записано число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе. Этот параметр передается неинициализированным.</param>
		// Token: 0x060042E0 RID: 17120
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентификатор члена.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель на место сохранения результата.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		// Token: 0x060042E1 RID: 17121
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
	}
}
