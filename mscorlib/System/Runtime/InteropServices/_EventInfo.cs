using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым членам класса <see cref="T:System.Reflection.EventInfo" />.</summary>
	// Token: 0x0200076C RID: 1900
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9DE59C64-D889-35A1-B897-587D74469E5B")]
	[TypeLibImportClass(typeof(EventInfo))]
	[ComVisible(true)]
	public interface _EventInfo
	{
		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" />.</summary>
		/// <param name="target">Источник события.</param>
		/// <param name="handler">Метод или методы, вызываемые, когда событие вызывается целевым объектом.</param>
		// Token: 0x06004313 RID: 17171
		void AddEventHandler(object target, Delegate handler);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, с которым сравнивается текущий объект <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004314 RID: 17172
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.EventInfo.GetAddMethod" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, используемый, чтобы добавить делегат обработчика событий для источника событий.</returns>
		// Token: 0x06004315 RID: 17173
		MethodInfo GetAddMethod();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.EventInfo.GetAddMethod(System.Boolean)" />.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, чтобы возвратить методы, не являющиеся открытыми, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, используемый, чтобы добавить делегат обработчика событий для источника событий.</returns>
		// Token: 0x06004316 RID: 17174
		MethodInfo GetAddMethod(bool nonPublic);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, или массив нулей (0), если атрибуты не определены.</returns>
		// Token: 0x06004317 RID: 17175
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Тип атрибута для поиска. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">
		///   <see langword="true" /> для поиска атрибутов в цепочке наследования этого элемента. В противном случае — <see langword="false" />.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив с нулем (0) элементов, если атрибуты не применялись.</returns>
		// Token: 0x06004318 RID: 17176
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x06004319 RID: 17177
		int GetHashCode();

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Массив сопоставляемых имен.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, выделенный вызывающим объектом, в который помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x0600431A RID: 17178
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Возвращает сведения о типе объекта, которые можно использовать для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x0600431B RID: 17179
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Когда выполнение этого метода завершается, содержит указатель, по которому записано число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600431C RID: 17180
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
		// Token: 0x0600431D RID: 17181
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.EventInfo.GetRaiseMethod" />.</summary>
		/// <returns>Метод, который вызывается при возникновении события.</returns>
		// Token: 0x0600431E RID: 17182
		MethodInfo GetRaiseMethod();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.EventInfo.GetRaiseMethod(System.Boolean)" />.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, чтобы возвратить методы, не являющиеся открытыми, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, вызванный при возникновении события.</returns>
		// Token: 0x0600431F RID: 17183
		MethodInfo GetRaiseMethod(bool nonPublic);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.EventInfo.GetRemoveMethod" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, используемый для удаления делегата обработчика событий из источника событий.</returns>
		// Token: 0x06004320 RID: 17184
		MethodInfo GetRemoveMethod();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.EventInfo.GetRemoveMethod(System.Boolean)" />.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, чтобы возвратить методы, не являющиеся открытыми, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, используемый для удаления делегата обработчика событий из источника событий.</returns>
		// Token: 0x06004321 RID: 17185
		MethodInfo GetRemoveMethod(bool nonPublic);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />.</returns>
		// Token: 0x06004322 RID: 17186
		Type GetType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">
		///   <see langword="true" /> для поиска атрибутов в цепочке наследования этого элемента. В противном случае — <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если к этому члену применяется один или несколько экземпляров параметра <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004323 RID: 17187
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.EventInfo.RemoveEventHandler(System.Object,System.Delegate)" />.</summary>
		/// <param name="target">Источник события.</param>
		/// <param name="handler">Делегат, связь которого с событиями, вызываемыми целевым объектом, должна быть разорвана.</param>
		// Token: 0x06004324 RID: 17188
		void RemoveEventHandler(object target, Delegate handler);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Строка, представляющая текущий объект <see cref="T:System.Object" />.</returns>
		// Token: 0x06004325 RID: 17189
		string ToString();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.EventInfo.Attributes" />.</summary>
		/// <returns>Атрибуты этого события, доступные только для чтения.</returns>
		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06004326 RID: 17190
		EventAttributes Attributes { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.DeclaringType" />.</summary>
		/// <returns>Объект <see langword="Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06004327 RID: 17191
		Type DeclaringType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.EventInfo.EventHandlerType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> с доступом только для чтения, представляющий обработчик событий делегата.</returns>
		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06004328 RID: 17192
		Type EventHandlerType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.EventInfo.IsMulticast" />.</summary>
		/// <returns>Значение <see langword="true" />, если делегат является многоадресным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06004329 RID: 17193
		bool IsMulticast { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.EventInfo.IsSpecialName" />.</summary>
		/// <returns>Значение <see langword="true" />, если у события есть специальное имя, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600432A RID: 17194
		bool IsSpecialName { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.EventInfo.MemberType" />.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" />, указывающее, что этот элемент является событием.</returns>
		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600432B RID: 17195
		MemberTypes MemberType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.Name" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя этого члена.</returns>
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600432C RID: 17196
		string Name { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.ReflectedType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, использованный для получения этого объекта.</returns>
		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600432D RID: 17197
		Type ReflectedType { get; }
	}
}
