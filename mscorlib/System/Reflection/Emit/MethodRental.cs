using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Reflection.Emit
{
	/// <summary>Позволяет быстро менять реализацию основного текста сообщения метода, задающего метод класса.</summary>
	// Token: 0x02000936 RID: 2358
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_MethodRental))]
	public sealed class MethodRental : _MethodRental
	{
		// Token: 0x0600516A RID: 20842 RVA: 0x0000259F File Offset: 0x0000079F
		private MethodRental()
		{
		}

		/// <summary>Меняет текст сообщения метода.</summary>
		/// <param name="cls">Класс, содержащий данный метод.</param>
		/// <param name="methodtoken">маркер метода.</param>
		/// <param name="rgIL">Указатель на метод. Должен содержать заголовок метода.</param>
		/// <param name="methodSize">Размер нового основного текста сообщения метода в байтах.</param>
		/// <param name="flags">Флаги, управляющие заменой. См. определения констант.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="cls" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="cls" /> не полон.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="methodSize" /> меньше единицы или больше 4128767 (3effff hex).</exception>
		// Token: 0x0600516B RID: 20843 RVA: 0x000FE90C File Offset: 0x000FCB0C
		[MonoTODO]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public static void SwapMethodBody(Type cls, int methodtoken, IntPtr rgIL, int methodSize, int flags)
		{
			if (methodSize <= 0 || methodSize >= 4128768)
			{
				throw new ArgumentException("Data size must be > 0 and < 0x3f0000", "methodSize");
			}
			if (cls == null)
			{
				throw new ArgumentNullException("cls");
			}
			if (cls is TypeBuilder && !((TypeBuilder)cls).is_created)
			{
				throw new NotSupportedException("Type '" + ((cls != null) ? cls.ToString() : null) + "' is not yet created.");
			}
			throw new NotImplementedException();
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600516C RID: 20844 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodRental.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600516D RID: 20845 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodRental.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600516E RID: 20846 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodRental.GetTypeInfoCount(out uint pcTInfo)
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
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600516F RID: 20847 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodRental.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Указывает, что JIT-компиляция для данного метода должна выполняться немедленно.</summary>
		// Token: 0x040031D6 RID: 12758
		public const int JitImmediate = 1;

		/// <summary>Указывает, что JIT-компиляция для данного метода должна выполняться при необходимости.</summary>
		// Token: 0x040031D7 RID: 12759
		public const int JitOnDemand = 0;
	}
}
