using System;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing
{
	/// <summary>
	///         Этот класс используется для записи событий.
	///       </summary>
	// Token: 0x02000394 RID: 916
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventProvider : IDisposable
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.EventProvider" />.
		///       </summary>
		/// <param name="providerGuid">
		///           Идентификатор GUID, однозначно определяющий поставщика.
		///         </param>
		/// <exception cref="T:System.InsufficientMemoryException">
		///             Не хватает памяти для завершения операции.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Классы в <see cref="N:System.Diagnostics.Eventing" /> рабочего пространства имен только в Windows Vista.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="providerGuid" /> не может иметь значение null.
		///           </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">
		///             Ошибки, возвращенной в подсистему ETW.
		///           </exception>
		// Token: 0x06001B58 RID: 7000 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		[PermissionSet(SecurityAction.Demand, Unrestricted = true)]
		public EventProvider(Guid providerGuid)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Удаляет регистрацию поставщика из подсистемы ETW и освобождает все неуправляемые ресурсы.
		///       </summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">
		///             Ошибки, возвращенной в подсистему ETW.
		///           </exception>
		// Token: 0x06001B59 RID: 7001 RVA: 0x0000235B File Offset: 0x0000055B
		public virtual void Close()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Создает уникальный идентификатор действия для поставщика.
		///       </summary>
		/// <returns>
		///         Уникальный идентификатор Guid, который используется при вызове <see cref="M:System.Diagnostics.Eventing.EventProvider.SetActivityId(System.Guid@)" /> метода, чтобы задать идентификатор действия для поставщика.
		///       </returns>
		// Token: 0x06001B5A RID: 7002 RVA: 0x0005A400 File Offset: 0x00058600
		[SecurityCritical]
		public static Guid CreateActivityId()
		{
			ThrowStub.ThrowNotSupportedException();
			return default(Guid);
		}

		/// <summary>
		///         Освобождает ресурсы, используемые объектом <see cref="T:System.Diagnostics.Eventing.EventProvider" />.
		///       </summary>
		// Token: 0x06001B5B RID: 7003 RVA: 0x0000235B File Offset: 0x0000055B
		public void Dispose()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Освобождает ресурсы, используемые объектом <see cref="T:System.Diagnostics.Eventing.EventProvider" />.
		///       </summary>
		/// <param name="disposing">
		///           Этот параметр игнорируется этим методом ввиду отсутствия неуправляемых ресурсов.
		///         </param>
		// Token: 0x06001B5C RID: 7004 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает код последней ошибки, связанные со сбоем записи события.
		///       </summary>
		/// <returns>
		///         Используйте значение для определения причины сбоя записи события.
		///       </returns>
		// Token: 0x06001B5D RID: 7005 RVA: 0x0005A41C File Offset: 0x0005861C
		public static EventProvider.WriteEventErrorCode GetLastWriteEventError()
		{
			ThrowStub.ThrowNotSupportedException();
			return EventProvider.WriteEventErrorCode.NoError;
		}

		/// <summary>
		///         Определяет, разрешен ли любого сеанса поставщика, независимо от того, уровень и ключевое слово значения, используемые для разрешения этого поставщика.
		///       </summary>
		/// <returns>
		///         — <see langword="true" /> Если поставщик включен для любого сеанса; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001B5E RID: 7006 RVA: 0x0005A438 File Offset: 0x00058638
		public bool IsEnabled()
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Определяет, запрашивает ли любого сеанса указанного события от поставщика.
		///       </summary>
		/// <param name="level">
		///           Уровень детализации сведений, включаемых в событие.
		///         </param>
		/// <param name="keywords">
		///           Битовая маска, указывающая категорию события.
		///            Эта маска должна быть ту же ключевое слово маску, которая определена в манифесте события.
		///         </param>
		/// <returns>
		///         Является <see langword="true" /> при любой сеансе запрашивается указанное событие; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001B5F RID: 7007 RVA: 0x0005A454 File Offset: 0x00058654
		public bool IsEnabled(byte level, long keywords)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Задает текущий идентификатор действия, используемые <see cref="Overload:System.Diagnostics.Eventing.EventProvider.WriteEvent" /> методы.
		///       </summary>
		/// <param name="id">
		///           Уникальный идентификатор действия, <see cref="M:System.Diagnostics.Eventing.EventProvider.CreateActivityId" /> возвращает метод.
		///         </param>
		// Token: 0x06001B60 RID: 7008 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public static void SetActivityId(ref Guid id)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Записывает событие.
		///          Данные события указываются в виде блока памяти.
		///       </summary>
		/// <param name="eventDescriptor">
		///           Экземпляр <see cref="T:System.Diagnostics.Eventing.EventDescriptor" /> определяющий события для записи.
		///         </param>
		/// <param name="dataCount">
		///           Размер данных события, к которому <paramref name="data" /> параметр точек.
		///            Максимальный размер данных события ограничен 64 КБ за вычетом размера заголовков события.
		///            Размер события меньше, если меньше размер буфера сеанса и сеанс включает в себя расширенные элементы данных с событием.
		///         </param>
		/// <param name="data">
		///           Указатель на данные события для записи.
		///         </param>
		/// <returns>
		///         — <see langword="true" /> Если событие является запись; в противном случае — <see langword="false" />.
		///          Если значение равно false, вызовите <see cref="M:System.Diagnostics.Eventing.EventProvider.GetLastWriteEventError" /> метод для определения причины сбоя.
		///       </returns>
		// Token: 0x06001B61 RID: 7009 RVA: 0x0005A470 File Offset: 0x00058670
		[SecurityCritical]
		protected bool WriteEvent(ref EventDescriptor eventDescriptor, int dataCount, IntPtr data)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Записывает событие.
		///          Данные события указываются в виде массива объектов.
		///       </summary>
		/// <param name="eventDescriptor">
		///           Экземпляр <see cref="T:System.Diagnostics.Eventing.EventDescriptor" /> определяющий события для записи.
		///         </param>
		/// <param name="eventPayload">
		///           Массив объектов, содержащих данные события для записи.
		///            Объект должен быть в порядке, указанном в манифесте.
		///            Массив ограничен 32 объектами, из которых только 8 могут быть строчными.
		///            Максимальный размер данных события ограничен 64 КБ за вычетом размера заголовков события.
		///            Размер события меньше, если меньше размер буфера сеанса и сеанс включает в себя расширенные элементы данных с событием.
		///
		///           Этот параметр может быть нулевым.
		///         </param>
		/// <returns>
		///         — <see langword="true" /> Если событие является запись; в противном случае — <see langword="false" />.
		///          Если значение равно false, вызовите <see cref="M:System.Diagnostics.Eventing.EventProvider.GetLastWriteEventError" /> метод для определения причины сбоя.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="eventPayload" /> Параметр содержит слишком много объектов или строк.
		///           </exception>
		// Token: 0x06001B62 RID: 7010 RVA: 0x0005A48C File Offset: 0x0005868C
		public bool WriteEvent(ref EventDescriptor eventDescriptor, object[] eventPayload)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Записывает событие.
		///          Данные события указаны в виде строки.
		///       </summary>
		/// <param name="eventDescriptor">
		///           Экземпляр <see cref="T:System.Diagnostics.Eventing.EventDescriptor" /> определяющий события для записи.
		///         </param>
		/// <param name="data">
		///           Строка для записи в качестве данных события.
		///         </param>
		/// <returns>
		///         — <see langword="true" /> Если событие является запись; в противном случае — <see langword="false" />.
		///          Если значение равно false, вызовите <see cref="M:System.Diagnostics.Eventing.EventProvider.GetLastWriteEventError" /> метод для определения причины сбоя.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Если <paramref name="data" /> является <see langword="null" />.
		///           </exception>
		// Token: 0x06001B63 RID: 7011 RVA: 0x0005A4A8 File Offset: 0x000586A8
		[SecurityCritical]
		public bool WriteEvent(ref EventDescriptor eventDescriptor, string data)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Записывает событие, которое содержит строку в качестве данных.
		///       </summary>
		/// <param name="eventMessage">
		///           Строка для записи в качестве данных события.
		///         </param>
		/// <returns>
		///         — <see langword="true" /> Если событие является запись; в противном случае — <see langword="false" />.
		///          Если значение равно false, вызовите <see cref="M:System.Diagnostics.Eventing.EventProvider.GetLastWriteEventError" /> метод для определения причины сбоя.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Если <paramref name="eventMessage" /> является <see langword="null" />.
		///           </exception>
		// Token: 0x06001B64 RID: 7012 RVA: 0x0005A4C4 File Offset: 0x000586C4
		public bool WriteMessageEvent(string eventMessage)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Записывает событие, которое содержит строку в качестве данных, если уровень и ключевое слово соответствуют событиям, запрашиваемым сеансом.
		///       </summary>
		/// <param name="eventMessage">
		///           Строка для записи в качестве данных события.
		///         </param>
		/// <param name="eventLevel">
		///           Уровень детализации сведений, включаемых в событие.
		///            Если поставщик использует манифест для определения события, это значение того же уровня, определенное в манифесте.
		///         </param>
		/// <param name="eventKeywords">
		///           Битовая маска, указывающая категорию события.
		///            Если поставщик использует манифест для определения события, это значение равно же маску ключевого слова, определенное в манифесте.
		///         </param>
		/// <returns>
		///         — <see langword="true" /> Если событие является запись; в противном случае — <see langword="false" />.
		///          Если значение равно false, вызовите <see cref="M:System.Diagnostics.Eventing.EventProvider.GetLastWriteEventError" /> метод для определения причины сбоя.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Если <paramref name="eventMessage" /> является <see langword="null" />.
		///           </exception>
		// Token: 0x06001B65 RID: 7013 RVA: 0x0005A4E0 File Offset: 0x000586E0
		[SecurityCritical]
		public bool WriteMessageEvent(string eventMessage, byte eventLevel, long eventKeywords)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Связывает события при трассировке событий в сценарии end-to-end.
		///          Данные события указываются в виде блока памяти.
		///       </summary>
		/// <param name="eventDescriptor">
		///           Экземпляр <see cref="T:System.Diagnostics.Eventing.EventDescriptor" /> определяющий события для записи.
		///         </param>
		/// <param name="relatedActivityId">
		///           Идентификатор действия от предыдущего компонента.
		///            Используйте этот параметр для связи событий компонента с событиями предыдущего компонента.
		///         </param>
		/// <param name="dataCount">
		///           Размер данных события, к которому <paramref name="data" /> параметр точек.
		///            Максимальный размер данных события ограничен 64 КБ за вычетом размера заголовков события.
		///            Размер события меньше, если меньше размер буфера сеанса и сеанс включает в себя расширенные элементы данных с событием.
		///         </param>
		/// <param name="data">
		///           Указатель на данные события для записи.
		///         </param>
		/// <returns>
		///         — <see langword="true" /> Если событие является запись; в противном случае — <see langword="false" />.
		///          Если значение равно false, вызовите <see cref="M:System.Diagnostics.Eventing.EventProvider.GetLastWriteEventError" /> метод для определения причины сбоя.
		///       </returns>
		// Token: 0x06001B66 RID: 7014 RVA: 0x0005A4FC File Offset: 0x000586FC
		[SecurityCritical]
		protected bool WriteTransferEvent(ref EventDescriptor eventDescriptor, Guid relatedActivityId, int dataCount, IntPtr data)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Связывает события при трассировке событий в сценарии end-to-end.
		///          Данные события указываются в виде массива объектов.
		///       </summary>
		/// <param name="eventDescriptor">
		///           Экземпляр <see cref="T:System.Diagnostics.Eventing.EventDescriptor" /> определяющий события для записи.
		///         </param>
		/// <param name="relatedActivityId">
		///           Идентификатор действия от предыдущего компонента.
		///            Используйте этот параметр для связи событий компонента с событиями предыдущего компонента.
		///         </param>
		/// <param name="eventPayload">
		///           Массив объектов, содержащих данные события для записи.
		///            Данные должны быть в порядке, указанном в манифесте.
		///            Массив ограничен 32 объектами, из которых только 8 могут быть строчными.
		///            Максимальный размер данных события ограничен 64 КБ за вычетом размера заголовков события.
		///            Размер события меньше, если меньше размер буфера сеанса и сеанс включает в себя расширенные элементы данных с событием.
		///         </param>
		/// <returns>
		///         — <see langword="true" /> Если событие является запись; в противном случае — <see langword="false" />.
		///          Если значение равно false, вызовите <see cref="M:System.Diagnostics.Eventing.EventProvider.GetLastWriteEventError" /> метод для определения причины сбоя.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Если <paramref name="eventPayload" /> содержит слишком много объектов или строк.
		///           </exception>
		// Token: 0x06001B67 RID: 7015 RVA: 0x0005A518 File Offset: 0x00058718
		[SecurityCritical]
		public bool WriteTransferEvent(ref EventDescriptor eventDescriptor, Guid relatedActivityId, object[] eventPayload)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>
		///         Определяет возможные состояния последней операции записи.
		///       </summary>
		// Token: 0x02000395 RID: 917
		public enum WriteEventErrorCode
		{
			/// <summary>
			///         Событие превышает размер буфера сеанса. события не может выходить за пределы буферов.
			///       </summary>
			// Token: 0x04000D3F RID: 3391
			EventTooBig = 2,
			/// <summary>
			///         Запись выполнена успешно.
			///       </summary>
			// Token: 0x04000D40 RID: 3392
			NoError = 0,
			/// <summary>
			///         Сеанс исчерпал свободные буфера для записи.
			///          Это может произойти при высокой частоте событий из-за перегрузки дисковой подсистемы или количество буферов слишком мал.
			///          Вместо блокировки, пока буферы не станут доступны, то событие удаляется.
			///          Рекомендуется увеличить количество и размер буферов для сеанса, или уменьшить количество записанных событий или размер события.
			///       </summary>
			// Token: 0x04000D41 RID: 3393
			NoFreeBuffers
		}
	}
}
