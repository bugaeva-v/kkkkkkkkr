using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Выявляет атрибуты метода и обеспечивает доступ к его метаданным.</summary>
	// Token: 0x020008AF RID: 2223
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_MethodInfo))]
	[Serializable]
	public abstract class MethodInfo : MethodBase, _MethodInfo
	{
		/// <summary>Возвращает значение <see cref="T:System.Reflection.MemberTypes" />, указывающее, что этот элемент является методом.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" />, указывающее, что этот элемент является методом.</returns>
		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x00047F71 File Offset: 0x00046171
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Method;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.ParameterInfo" />, который содержит сведения о типе возвращаемого значения этого метода, например, имеет ли тип возвращаемого значения пользовательские модификаторы.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.ParameterInfo" />, содержащий сведения о типе возвращаемого значения.</returns>
		/// <exception cref="T:System.NotImplementedException">Этот метод не реализован.</exception>
		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x00047226 File Offset: 0x00045426
		public virtual ParameterInfo ReturnParameter
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает тип значения, возвращаемый этим методом.</summary>
		/// <returns>Тип возвращаемого значения этого метода.</returns>
		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x00047226 File Offset: 0x00045426
		public virtual Type ReturnType
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Type" />, которые представляют аргументы универсального метода, относящиеся к типу, или параметры типа определения универсального метода.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа, относящиеся к универсальному методу, или параметры типа определения универсального метода. Возвращает пустой массив, если текущий метод не является универсальным методом.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x0600495F RID: 18783 RVA: 0x0004728A File Offset: 0x0004548A
		public override Type[] GetGenericArguments()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.MethodInfo" />, представляющий определение универсального метода, на основе которого можно сконструировать текущий метод.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий определение универсального метода, на основе которого может быть сконструирован текущий метод.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий метод не является универсальным. То есть <see cref="P:System.Reflection.MethodBase.IsGenericMethod" /> возвращает <see langword="false" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06004960 RID: 18784 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual MethodInfo GetGenericMethodDefinition()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Заменяет параметры типа элементами массива типов для определения текущего универсального метода и возвращает объект <see cref="T:System.Reflection.MethodInfo" />, представляющий итоговый сконструированный метод.</summary>
		/// <param name="typeArguments">Массив типов, который должен быть замещен параметрами типов текущего определения универсального метода.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" /> который представляет сконструированный метод, сформированный путем замены элементами <paramref name="typeArguments" /> параметров типов текущего определения универсального метода.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Reflection.MethodInfo" /> не представляет определение универсального метода. То есть <see cref="P:System.Reflection.MethodBase.IsGenericMethodDefinition" /> возвращает <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeArguments" /> — <see langword="null" />.  
		/// -или- 
		/// Любой элемент <paramref name="typeArguments" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Количество элементов в <paramref name="typeArguments" /> не совпадает с количеством параметров типа текущего определения универсального метода.  
		/// -или- 
		/// Элемент <paramref name="typeArguments" /> не соответствует ограничениям, указанным для соответствующего параметра типа текущего определения универсального метода.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06004961 RID: 18785 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Если переопределено в производном классе, возвращает объект <see cref="T:System.Reflection.MethodInfo" /> для метода в прямом или косвенном базовом классе, в котором был первоначально объявлен метод, предоставляемый этим экземпляром.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" /> для первой реализации этого метода.</returns>
		// Token: 0x06004962 RID: 18786
		public abstract MethodInfo GetBaseDefinition();

		/// <summary>Возвращает пользовательские атрибуты типа возвращаемого значения.</summary>
		/// <returns>Объект <see langword="ICustomAttributeProvider" />, представляющий пользовательские атрибуты для возвращаемого типа.</returns>
		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06004963 RID: 18787
		public abstract ICustomAttributeProvider ReturnTypeCustomAttributes { get; }

		/// <summary>Создает делегат заданного типа из этого метода.</summary>
		/// <param name="delegateType">Тип создаваемого делегата.</param>
		/// <returns>Делегат для этого метода.</returns>
		// Token: 0x06004964 RID: 18788 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual Delegate CreateDelegate(Type delegateType)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Создает делегат заданного типа с заданным целевым объектом из этого метода.</summary>
		/// <param name="delegateType">Тип создаваемого делегата.</param>
		/// <param name="target">Целевой объект для делегата.</param>
		/// <returns>Делегат для этого метода.</returns>
		// Token: 0x06004965 RID: 18789 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual Delegate CreateDelegate(Type delegateType, object target)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004966 RID: 18790 RVA: 0x000EE1E6 File Offset: 0x000EC3E6
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06004967 RID: 18791 RVA: 0x000EE1EF File Offset: 0x000EC3EF
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.MethodInfo" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004968 RID: 18792 RVA: 0x00064560 File Offset: 0x00062760
		public static bool operator ==(MethodInfo left, MethodInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.MethodInfo" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004969 RID: 18793 RVA: 0x000EEEA4 File Offset: 0x000ED0A4
		public static bool operator !=(MethodInfo left, MethodInfo right)
		{
			return !(left == right);
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x0600496A RID: 18794 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые можно использовать для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x0600496B RID: 18795 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x0600496C RID: 18796 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodInfo.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x0600496D RID: 18797 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к методу <see cref="M:System.Object.GetType" /> из COM-объекта.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип <see cref="T:System.Reflection.MethodInfo" />.</returns>
		// Token: 0x0600496E RID: 18798 RVA: 0x00047210 File Offset: 0x00045410
		Type _MethodInfo.GetType()
		{
			return base.GetType();
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x000EEEB0 File Offset: 0x000ED0B0
		internal virtual int GenericParameterCount
		{
			get
			{
				return this.GetGenericArguments().Length;
			}
		}
	}
}
