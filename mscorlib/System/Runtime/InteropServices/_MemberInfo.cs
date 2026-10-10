using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым элементам класса <see cref="T:System.Reflection.MemberInfo" />.</summary>
	// Token: 0x02000772 RID: 1906
	[ComVisible(true)]
	[TypeLibImportClass(typeof(MemberInfo))]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[CLSCompliant(false)]
	[Guid("f7102fa9-cabb-3a74-a6da-b4567ef1b079")]
	public interface _MemberInfo
	{
		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, который необходимо сравнить с текущим объектом <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600436B RID: 17259
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, или массив нулей (0), если атрибуты не определены.</returns>
		// Token: 0x0600436C RID: 17260
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Искомый тип атрибута. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив нулей (0), если атрибуты не применялись.</returns>
		// Token: 0x0600436D RID: 17261
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x0600436E RID: 17262
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />.</returns>
		// Token: 0x0600436F RID: 17263
		Type GetType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Объект <see cref="T:System.Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если к этому члену применяется один или несколько экземпляров параметра <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004370 RID: 17264
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Строка, представляющая текущий <see cref="T:System.Object" />.</returns>
		// Token: 0x06004371 RID: 17265
		string ToString();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.DeclaringType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06004372 RID: 17266
		Type DeclaringType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.MemberType" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MemberTypes" />, указывающее тип члена.</returns>
		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06004373 RID: 17267
		MemberTypes MemberType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.Name" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя этого члена.</returns>
		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06004374 RID: 17268
		string Name { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.ReflectedType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, используемый для получения этого объекта <see cref="T:System.Reflection.MemberInfo" />.</returns>
		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06004375 RID: 17269
		Type ReflectedType { get; }

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Массив сопоставляемых имен.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, выделенный вызывающим объектом, в который помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x06004376 RID: 17270
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Возвращает сведения о типе объекта, которые могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x06004377 RID: 17271
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Когда выполнение этого метода завершается, содержит указатель, по которому записано число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004378 RID: 17272
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентификатор члена.</param>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Ссылка на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также количество элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		// Token: 0x06004379 RID: 17273
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
	}
}
