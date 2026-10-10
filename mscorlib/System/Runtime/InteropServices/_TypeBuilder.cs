using System;
using System.Reflection.Emit;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к классу <see cref="T:System.Reflection.Emit.TypeBuilder" />.</summary>
	// Token: 0x02000780 RID: 1920
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7E5678EE-48B3-3F83-B076-C58543498A58")]
	[TypeLibImportClass(typeof(TypeBuilder))]
	[ComVisible(true)]
	[CLSCompliant(false)]
	public interface _TypeBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Массив сопоставляемых имен.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, выделенный вызывающим объектом, в который помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x06004476 RID: 17526
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Возвращает сведения о типе объекта, которые можно использовать для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x06004477 RID: 17527
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">При наличии выходного параметра в соответствии с вышеприведенным синтаксисом должна использоваться следующая формулировка "Когда этот метод возвращает значение, оно содержит указатель, по которому записывается количество интерфейсов для доступа к сведениям о типе, предоставляемых объектом. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004478 RID: 17528
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
		// Token: 0x06004479 RID: 17529
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
	}
}
