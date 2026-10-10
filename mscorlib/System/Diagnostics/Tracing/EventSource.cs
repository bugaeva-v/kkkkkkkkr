using System;
using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
	/// <summary>Предоставляет возможность создания событий для трассировки событий Windows (ETW).</summary>
	// Token: 0x020009F7 RID: 2551
	public class EventSource : IDisposable
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSource" />.</summary>
		// Token: 0x06005AD2 RID: 23250 RVA: 0x00134545 File Offset: 0x00132745
		protected EventSource()
		{
			this.Name = base.GetType().Name;
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSource" /> и определяет, следует ли создавать исключение при возникновении ошибки в базовом коде Windows.</summary>
		/// <param name="throwOnEventWriteErrors">Значение <see langword="true" /> для создания исключения при возникновении ошибки в базовом коде Windows; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06005AD3 RID: 23251 RVA: 0x0007B59C File Offset: 0x0007979C
		protected EventSource(bool throwOnEventWriteErrors) : this()
		{
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSource" /> с указанными параметрами конфигурации.</summary>
		/// <param name="settings">Побитовое сочетание значений перечисления, которое определяет параметры конфигурации, применяемые к источнику события.</param>
		// Token: 0x06005AD4 RID: 23252 RVA: 0x0013455E File Offset: 0x0013275E
		protected EventSource(EventSourceSettings settings) : this()
		{
			this.Settings = settings;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSource" /> для использования с неконтрактными событиями, который содержит указанные параметры и признаки.</summary>
		/// <param name="settings">Побитовое сочетание значений перечисления, которое определяет параметры конфигурации, применяемые к источнику события.</param>
		/// <param name="traits">Пары ключ-значение, определяющие признаки для источника события.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="traits" /> не указан в парах "ключ значение".</exception>
		// Token: 0x06005AD5 RID: 23253 RVA: 0x0013456D File Offset: 0x0013276D
		protected EventSource(EventSourceSettings settings, params string[] traits) : this(settings)
		{
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSource" /> с указанным именем.</summary>
		/// <param name="eventSourceName">Имя, назначаемое источнику событий. Значение не должно быть равно <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="eventSourceName" /> — <see langword="null" />.</exception>
		// Token: 0x06005AD6 RID: 23254 RVA: 0x00134576 File Offset: 0x00132776
		public EventSource(string eventSourceName)
		{
			this.Name = eventSourceName;
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSource" /> с указанным именем и параметрами.</summary>
		/// <param name="eventSourceName">Имя, назначаемое источнику событий. Значение не должно быть равно <see langword="null" />.</param>
		/// <param name="config">Побитовое сочетание значений перечисления, которое определяет параметры конфигурации, применяемые к источнику события.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="eventSourceName" /> — <see langword="null" />.</exception>
		// Token: 0x06005AD7 RID: 23255 RVA: 0x00134585 File Offset: 0x00132785
		public EventSource(string eventSourceName, EventSourceSettings config) : this(eventSourceName)
		{
			this.Settings = config;
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSource" /> с указанными параметрами конфигурации.</summary>
		/// <param name="eventSourceName">Имя, назначаемое источнику событий. Значение не должно быть равно <see langword="null" />.</param>
		/// <param name="config">Побитовое сочетание значений перечисления, которое определяет параметры конфигурации, применяемые к источнику события.</param>
		/// <param name="traits">Пары ключ-значение, определяющие признаки для источника события.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="eventSourceName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="traits" /> не указан в парах "ключ значение".</exception>
		// Token: 0x06005AD8 RID: 23256 RVA: 0x00134595 File Offset: 0x00132795
		public EventSource(string eventSourceName, EventSourceSettings config, params string[] traits) : this(eventSourceName, config)
		{
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x0013459F File Offset: 0x0013279F
		internal EventSource(Guid eventSourceGuid, string eventSourceName) : this(eventSourceName)
		{
		}

		/// <summary>Позволяет объекту <see cref="T:System.Diagnostics.Tracing.EventSource" /> предпринять попытку освободить ресурсы и выполнить другие операции очистки перед утилизацией объекта в процессе сборки мусора.</summary>
		// Token: 0x06005ADA RID: 23258 RVA: 0x001345A8 File Offset: 0x001327A8
		~EventSource()
		{
			this.Dispose(false);
		}

		/// <summary>Возвращает любое исключение, инициированное во время создания источника событий.</summary>
		/// <returns>Исключение, инициированное во время создания источника событий, или <see langword="null" />, если исключение не создано.</returns>
		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06005ADB RID: 23259 RVA: 0x0000AF5E File Offset: 0x0000915E
		public Exception ConstructionException
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает идентификатор действия текущего потока.</summary>
		/// <returns>Идентификатор действия текущего потока.</returns>
		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x001345D8 File Offset: 0x001327D8
		public static Guid CurrentThreadActivityId
		{
			get
			{
				return Guid.Empty;
			}
		}

		/// <summary>Уникальный идентификатор источника события.</summary>
		/// <returns>Уникальный идентификатор источника события.</returns>
		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06005ADD RID: 23261 RVA: 0x001345D8 File Offset: 0x001327D8
		public Guid Guid
		{
			get
			{
				return Guid.Empty;
			}
		}

		/// <summary>Понятное имя класса, производного от источника события.</summary>
		/// <returns>Понятное имя производного класса.  Значение по умолчанию — простое имя класса.</returns>
		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x001345DF File Offset: 0x001327DF
		// (set) Token: 0x06005ADF RID: 23263 RVA: 0x001345E7 File Offset: 0x001327E7
		public string Name { get; private set; }

		/// <summary>Возвращает параметры, применяемые к этому источнику события.</summary>
		/// <returns>Параметры, применяемые к этому источнику события.</returns>
		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x001345F0 File Offset: 0x001327F0
		// (set) Token: 0x06005AE1 RID: 23265 RVA: 0x001345F8 File Offset: 0x001327F8
		public EventSourceSettings Settings { get; private set; }

		/// <summary>Определяет, включен ли источник текущего события.</summary>
		/// <returns>Значение <see langword="true" />, если текущий источник события включен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005AE2 RID: 23266 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsEnabled()
		{
			return false;
		}

		/// <summary>Указывает, включен ли источник текущего события, который имеет заданный уровень и ключевое слово.</summary>
		/// <param name="level">Уровень источника события.</param>
		/// <param name="keywords">Ключевое слово источника события.</param>
		/// <returns>Значение <see langword="true" />, если источник события включен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005AE3 RID: 23267 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
			return false;
		}

		/// <summary>Определяет, включен ли текущий источник для событий с указанным уровнем, ключевыми словами и каналом.</summary>
		/// <param name="level">Проверяемый уровень событий. Источник событий будет считаться включенным, если этот уровень равен или больше <paramref name="level" />.</param>
		/// <param name="keywords">Проверяемые ключевые слова события.</param>
		/// <param name="channel">Проверяемый канал событий.</param>
		/// <returns>Значение <see langword="true" />, если источник события включен для указанного уровня событий, ключевых слов и канала; в противном случае — значение <see langword="false" />.  
		/// Результат выполнения этого метода только приблизительно показывает, активно ли определенное событие.  Используйте его, чтобы избежать ресурсоемких вычислений для ведения журнала, когда оно отключено. Работа источников событий может определяться дополнительной фильтрацией.</returns>
		// Token: 0x06005AE4 RID: 23268 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel)
		{
			return false;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Diagnostics.Tracing.EventSource" />.</summary>
		// Token: 0x06005AE5 RID: 23269 RVA: 0x00134601 File Offset: 0x00132801
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Получает значение признака, связанное с заданным ключом.</summary>
		/// <param name="key">Ключ признака, который необходимо получить.</param>
		/// <returns>Значение признака, связанное с указанным ключом. Если ключ не найден, возвращает значение <see langword="null" />.</returns>
		// Token: 0x06005AE6 RID: 23270 RVA: 0x0000AF5E File Offset: 0x0000915E
		public string GetTrait(string key)
		{
			return null;
		}

		/// <summary>Записывает событие без полей, но с указанным именем и параметрами по умолчанию.</summary>
		/// <param name="eventName">Имя записываемого события.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="eventName" /> — <see langword="null" />.</exception>
		// Token: 0x06005AE7 RID: 23271 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Write(string eventName)
		{
		}

		/// <summary>Записывает событие без полей, но с указанными именем и параметрами.</summary>
		/// <param name="eventName">Имя записываемого события.</param>
		/// <param name="options">Параметры события, такие как уровень, ключевые слова и код операции.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="eventName" /> — <see langword="null" />.</exception>
		// Token: 0x06005AE8 RID: 23272 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Write(string eventName, EventSourceOptions options)
		{
		}

		/// <summary>Записывает событие с указанными именем и данными.</summary>
		/// <param name="eventName">Имя события.</param>
		/// <param name="data">Данные события. Тип должен быть анонимным или помеченным атрибутом <see cref="T:System.Diagnostics.Tracing.EventDataAttribute" />.</param>
		/// <typeparam name="T">Тип, определяющий событие и связанные данные. Тип должен быть анонимным или помеченным атрибутом <see cref="T:System.Diagnostics.Tracing.EventSourceAttribute" />.</typeparam>
		// Token: 0x06005AE9 RID: 23273 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Write<T>(string eventName, T data)
		{
		}

		/// <summary>Записывает событие с указанными именем, данными и параметрами.</summary>
		/// <param name="eventName">Имя события.</param>
		/// <param name="options">Параметры события.</param>
		/// <param name="data">Данные события. Тип должен быть анонимным или помеченным атрибутом <see cref="T:System.Diagnostics.Tracing.EventDataAttribute" />.</param>
		/// <typeparam name="T">Тип, определяющий событие и связанные данные. Тип должен быть анонимным или помеченным атрибутом <see cref="T:System.Diagnostics.Tracing.EventSourceAttribute" />.</typeparam>
		// Token: 0x06005AEA RID: 23274 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Write<T>(string eventName, EventSourceOptions options, T data)
		{
		}

		/// <summary>Записывает событие с указанными именем, параметрами и данными.</summary>
		/// <param name="eventName">Имя события.</param>
		/// <param name="options">Параметры события.</param>
		/// <param name="data">Данные события. Тип должен быть анонимным или помеченным атрибутом <see cref="T:System.Diagnostics.Tracing.EventDataAttribute" />.</param>
		/// <typeparam name="T">Тип, определяющий событие и связанные данные. Тип должен быть анонимным или помеченным атрибутом <see cref="T:System.Diagnostics.Tracing.EventSourceAttribute" />.</typeparam>
		// Token: 0x06005AEB RID: 23275 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[CLSCompliant(false)]
		public void Write<T>(string eventName, ref EventSourceOptions options, ref T data)
		{
		}

		/// <summary>Записывает событие с указанными именем, параметрами, связанным действием и данными.</summary>
		/// <param name="eventName">Имя события.</param>
		/// <param name="options">Параметры события.</param>
		/// <param name="activityId">Идентификатор действия, связанного с событием.</param>
		/// <param name="relatedActivityId">Идентификатор связанного действия либо значение <see cref="F:System.Guid.Empty" />, если связанное действие отсутствует.</param>
		/// <param name="data">Данные события. Тип должен быть анонимным или помеченным атрибутом <see cref="T:System.Diagnostics.Tracing.EventDataAttribute" />.</param>
		/// <typeparam name="T">Тип, определяющий событие и связанные данные. Тип должен быть анонимным или помеченным атрибутом <see cref="T:System.Diagnostics.Tracing.EventSourceAttribute" />.</typeparam>
		// Token: 0x06005AEC RID: 23276 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Write<T>(string eventName, ref EventSourceOptions options, ref Guid activityId, ref Guid relatedActivityId, ref T data)
		{
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.Diagnostics.Tracing.EventSource" /> (при необходимости освобождает и управляемые ресурсы).</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x06005AED RID: 23277 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Вызывается, когда источник текущего события обновляется контроллером.</summary>
		/// <param name="command">Аргументы для события.</param>
		// Token: 0x06005AEE RID: 23278 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnEventCommand(EventCommandEventArgs command)
		{
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x00004BF9 File Offset: 0x00002DF9
		internal void ReportOutOfBandMessage(string msg, bool flush)
		{
		}

		/// <summary>Записывает событие, используя предоставленный идентификатор события.</summary>
		/// <param name="eventId">Идентификатор события. Это значение должно находиться в диапазоне от 0 до 65535.</param>
		// Token: 0x06005AF0 RID: 23280 RVA: 0x00134610 File Offset: 0x00132810
		protected void WriteEvent(int eventId)
		{
			this.WriteEvent(eventId, new object[0]);
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и аргумент в виде массива байтов.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Аргумент в виде массива байтов.</param>
		// Token: 0x06005AF1 RID: 23281 RVA: 0x0013461F File Offset: 0x0013281F
		protected void WriteEvent(int eventId, byte[] arg1)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и 32-разрядный целочисленный аргумент.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Целочисленный аргумент.</param>
		// Token: 0x06005AF2 RID: 23282 RVA: 0x00134632 File Offset: 0x00132832
		protected void WriteEvent(int eventId, int arg1)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и строковый аргумент.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Строковый аргумент.</param>
		// Token: 0x06005AF3 RID: 23283 RVA: 0x0013461F File Offset: 0x0013281F
		protected void WriteEvent(int eventId, string arg1)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и 32-разрядные целочисленные аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Целочисленный аргумент.</param>
		/// <param name="arg2">Целочисленный аргумент.</param>
		// Token: 0x06005AF4 RID: 23284 RVA: 0x0013464A File Offset: 0x0013284A
		protected void WriteEvent(int eventId, int arg1, int arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и 32-разрядные целочисленные аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Целочисленный аргумент.</param>
		/// <param name="arg2">Целочисленный аргумент.</param>
		/// <param name="arg3">Целочисленный аргумент.</param>
		// Token: 0x06005AF5 RID: 23285 RVA: 0x0013466B File Offset: 0x0013286B
		protected void WriteEvent(int eventId, int arg1, int arg2, int arg3)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2,
				arg3
			});
		}

		/// <summary>Записывает событие, используя предоставленный идентификатор, а также строковые и 32-разрядные целочисленные аргументы.</summary>
		/// <param name="eventId">Идентификатор события. Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">32-разрядный целочисленный аргумент.</param>
		/// <param name="arg2">Строковый аргумент.</param>
		// Token: 0x06005AF6 RID: 23286 RVA: 0x00134696 File Offset: 0x00132896
		protected void WriteEvent(int eventId, int arg1, string arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и 64-разрядный целочисленный аргумент.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">64-разрядный целочисленный аргумент.</param>
		// Token: 0x06005AF7 RID: 23287 RVA: 0x001346B2 File Offset: 0x001328B2
		protected void WriteEvent(int eventId, long arg1)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1
			});
		}

		/// <summary>Записывает данные события, используя указанный идентификатор, а также 64-разрядные целочисленные аргументы и аргументы в виде массива байтов.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">64-разрядный целочисленный аргумент.</param>
		/// <param name="arg2">Аргумент в виде массива байтов.</param>
		// Token: 0x06005AF8 RID: 23288 RVA: 0x001346CA File Offset: 0x001328CA
		protected void WriteEvent(int eventId, long arg1, byte[] arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и 64-разрядные аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">64-разрядный целочисленный аргумент.</param>
		/// <param name="arg2">64-разрядный целочисленный аргумент.</param>
		// Token: 0x06005AF9 RID: 23289 RVA: 0x001346E6 File Offset: 0x001328E6
		protected void WriteEvent(int eventId, long arg1, long arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и 64-разрядные аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">64-разрядный целочисленный аргумент.</param>
		/// <param name="arg2">64-разрядный целочисленный аргумент.</param>
		/// <param name="arg3">64-разрядный целочисленный аргумент.</param>
		// Token: 0x06005AFA RID: 23290 RVA: 0x00134707 File Offset: 0x00132907
		protected void WriteEvent(int eventId, long arg1, long arg2, long arg3)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2,
				arg3
			});
		}

		/// <summary>Записывает событие, используя предоставленный идентификатор, а также строковые и 64-разрядные целочисленные аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">64-разрядный целочисленный аргумент.</param>
		/// <param name="arg2">Строковый аргумент.</param>
		// Token: 0x06005AFB RID: 23291 RVA: 0x001346CA File Offset: 0x001328CA
		protected void WriteEvent(int eventId, long arg1, string arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и массив аргументов.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="args">Массив объектов.</param>
		// Token: 0x06005AFC RID: 23292 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected void WriteEvent(int eventId, params object[] args)
		{
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Строковый аргумент.</param>
		/// <param name="arg2">32-разрядный целочисленный аргумент.</param>
		// Token: 0x06005AFD RID: 23293 RVA: 0x00134732 File Offset: 0x00132932
		protected void WriteEvent(int eventId, string arg1, int arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Строковый аргумент.</param>
		/// <param name="arg2">32-разрядный целочисленный аргумент.</param>
		/// <param name="arg3">32-разрядный целочисленный аргумент.</param>
		// Token: 0x06005AFE RID: 23294 RVA: 0x0013474E File Offset: 0x0013294E
		protected void WriteEvent(int eventId, string arg1, int arg2, int arg3)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2,
				arg3
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Строковый аргумент.</param>
		/// <param name="arg2">64-разрядный целочисленный аргумент.</param>
		// Token: 0x06005AFF RID: 23295 RVA: 0x00134774 File Offset: 0x00132974
		protected void WriteEvent(int eventId, string arg1, long arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и строковые аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Строковый аргумент.</param>
		/// <param name="arg2">Строковый аргумент.</param>
		// Token: 0x06005B00 RID: 23296 RVA: 0x00134790 File Offset: 0x00132990
		protected void WriteEvent(int eventId, string arg1, string arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Записывает событие, используя предоставленные идентификатор события и строковые аргументы.</summary>
		/// <param name="eventId">Идентификатор события.  Это значение должно находиться в диапазоне от 0 до 65535.</param>
		/// <param name="arg1">Строковый аргумент.</param>
		/// <param name="arg2">Строковый аргумент.</param>
		/// <param name="arg3">Строковый аргумент.</param>
		// Token: 0x06005B01 RID: 23297 RVA: 0x001347A7 File Offset: 0x001329A7
		protected void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2,
				arg3
			});
		}

		/// <summary>Создает перегрузку <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> с помощью предоставленных идентификатора и данных события.</summary>
		/// <param name="eventId">Идентификатор события.</param>
		/// <param name="eventDataCount">Число элементов данных события.</param>
		/// <param name="data">Структура, содержащая данные события.</param>
		// Token: 0x06005B02 RID: 23298 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[CLSCompliant(false)]
		protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
		}

		/// <summary>Записывает событие, которое указывает, что текущее действие связано с другим действием.</summary>
		/// <param name="eventId">Идентификатор, который уникально идентифицирует это событие в источнике <see cref="T:System.Diagnostics.Tracing.EventSource" />.</param>
		/// <param name="relatedActivityId">Идентификатор связанного действия.</param>
		/// <param name="args">Массив объектов, которые содержат данные события.</param>
		// Token: 0x06005B03 RID: 23299 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected void WriteEventWithRelatedActivityId(int eventId, Guid relatedActivityId, params object[] args)
		{
		}

		/// <summary>Записывает событие, которое указывает, что текущее действие связано с другим действием.</summary>
		/// <param name="eventId">Идентификатор, который уникально идентифицирует это событие в источнике <see cref="T:System.Diagnostics.Tracing.EventSource" />.</param>
		/// <param name="relatedActivityId">Указатель на GUID идентификатора связанного действия.</param>
		/// <param name="eventDataCount">Число элементов в поле <paramref name="data" />.</param>
		/// <param name="data">Указатель на первый элемент в поле данных события.</param>
		// Token: 0x06005B04 RID: 23300 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[CLSCompliant(false)]
		protected unsafe void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventSource.EventData* data)
		{
		}

		/// <summary>Происходит, когда команда поступает от прослушивателя событий.</summary>
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06005B05 RID: 23301 RVA: 0x000479F8 File Offset: 0x00045BF8
		// (remove) Token: 0x06005B06 RID: 23302 RVA: 0x000479F8 File Offset: 0x00045BF8
		public event EventHandler<EventCommandEventArgs> EventCommandExecuted
		{
			add
			{
				throw new NotImplementedException();
			}
			remove
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает строку манифеста XML, связанного с текущим источником события.</summary>
		/// <param name="eventSourceType">Тип источника события.</param>
		/// <param name="assemblyPathToIncludeInManifest">Путь к файлу сборки (DLL-файлу) для включения в элемент поставщика манифеста.</param>
		/// <returns>Строка XML-данных.</returns>
		// Token: 0x06005B07 RID: 23303 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static string GenerateManifest(Type eventSourceType, string assemblyPathToIncludeInManifest)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает строку манифеста XML, связанного с текущим источником события.</summary>
		/// <param name="eventSourceType">Тип источника события.</param>
		/// <param name="assemblyPathToIncludeInManifest">Путь к файлу сборки (DLL-файлу) для включения в элемент поставщика манифеста.</param>
		/// <param name="flags">Побитовое сочетание значений перечисления, определяющее способ создания манифеста.</param>
		/// <returns>Строка XML-данных или <see langword="null" />.</returns>
		// Token: 0x06005B08 RID: 23304 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static string GenerateManifest(Type eventSourceType, string assemblyPathToIncludeInManifest, EventManifestOptions flags)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает уникальный идентификатор для данной реализации источника события.</summary>
		/// <param name="eventSourceType">Тип источника события.</param>
		/// <returns>Уникальный идентификатор для данного типа источника события.</returns>
		// Token: 0x06005B09 RID: 23305 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static Guid GetGuid(Type eventSourceType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает понятное имя источника события.</summary>
		/// <param name="eventSourceType">Тип источника события.</param>
		/// <returns>Понятное имя источника события. Значение по умолчанию — простое имя класса.</returns>
		// Token: 0x06005B0A RID: 23306 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static string GetName(Type eventSourceType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает снимок всех источников событий в домене приложения.</summary>
		/// <returns>Перечисление всех источников событий в домене приложения.</returns>
		// Token: 0x06005B0B RID: 23307 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IEnumerable<EventSource> GetSources()
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет команду указанному источнику события.</summary>
		/// <param name="eventSource">Источник событий, которому требуется отправлять команду.</param>
		/// <param name="command">Команда события, которую требуется отправить.</param>
		/// <param name="commandArguments">Аргументы для команды события.</param>
		// Token: 0x06005B0C RID: 23308 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static void SendCommand(EventSource eventSource, EventCommand command, IDictionary<string, string> commandArguments)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает идентификатор действия в текущем потоке.</summary>
		/// <param name="activityId">Новый идентификатор действия текущего потока или <see cref="F:System.Guid.Empty" />, чтобы указать, что работа в этом потоке не связана ни с каким действием.</param>
		// Token: 0x06005B0D RID: 23309 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static void SetCurrentThreadActivityId(Guid activityId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает идентификатор действия в текущем потоке и возвращает предыдущий идентификатор действия.</summary>
		/// <param name="activityId">Новый идентификатор действия текущего потока или <see cref="F:System.Guid.Empty" />, чтобы указать, что работа в этом потоке не связана ни с каким действием.</param>
		/// <param name="oldActivityThatWillContinue">При возврате из этого метода содержит идентификатор предыдущего действия в текущем потоке.</param>
		// Token: 0x06005B0E RID: 23310 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static void SetCurrentThreadActivityId(Guid activityId, out Guid oldActivityThatWillContinue)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет данные события для создания быстрые перегрузки <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> с помощью метода <see cref="M:System.Diagnostics.Tracing.EventSource.WriteEventCore(System.Int32,System.Int32,System.Diagnostics.Tracing.EventSource.EventData*)" />.</summary>
		// Token: 0x020009F8 RID: 2552
		protected internal struct EventData
		{
			/// <summary>Получает или задает указатель на данные для новой перегрузки <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" />.</summary>
			/// <returns>Указатель на данные.</returns>
			// Token: 0x17000F93 RID: 3987
			// (get) Token: 0x06005B0F RID: 23311 RVA: 0x001347C3 File Offset: 0x001329C3
			// (set) Token: 0x06005B10 RID: 23312 RVA: 0x001347CB File Offset: 0x001329CB
			public IntPtr DataPointer { readonly get; set; }

			/// <summary>Получает или задает количество элементов полезной нагрузки в новой перегрузке <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" />.</summary>
			/// <returns>Количество элементов полезной нагрузки в новой перегрузке.</returns>
			// Token: 0x17000F94 RID: 3988
			// (get) Token: 0x06005B11 RID: 23313 RVA: 0x001347D4 File Offset: 0x001329D4
			// (set) Token: 0x06005B12 RID: 23314 RVA: 0x001347DC File Offset: 0x001329DC
			public int Size { readonly get; set; }

			// Token: 0x17000F95 RID: 3989
			// (get) Token: 0x06005B13 RID: 23315 RVA: 0x001347E5 File Offset: 0x001329E5
			// (set) Token: 0x06005B14 RID: 23316 RVA: 0x001347ED File Offset: 0x001329ED
			internal int Reserved { readonly get; set; }
		}
	}
}
