using System;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Представляет запрос для событий в журнал событий и параметры, определяющие, как выполняется запрос и на каком компьютере выполняется запрос для.
	///       </summary>
	// Token: 0x020003A8 RID: 936
	public class EventLogQuery
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogQuery" /> класса путем указания целевого запроса.
		///          Целевой объект может быть активного журнала событий или файла журнала.
		///       </summary>
		/// <param name="path">
		///           Имя запрашиваемому или путь к файлу журнала событий для запроса.
		///         </param>
		/// <param name="pathType">
		///           Указывает ли строка, используемая в параметре path указывает имя журнала событий или путь к файлу журнала событий.
		///         </param>
		// Token: 0x06001BC9 RID: 7113 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogQuery(string path, PathType pathType)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogQuery" /> класса путем указания целевого запроса и запроса событий.
		///          Целевой объект может быть активного журнала событий или файла журнала.
		///       </summary>
		/// <param name="path">
		///           Имя запрашиваемому или путь к файлу журнала событий для запроса.
		///         </param>
		/// <param name="pathType">
		///           Указывает ли строка, используемая в параметре path указывает имя журнала событий или путь к файлу журнала событий.
		///         </param>
		/// <param name="query">
		///           Запрос события, используемый для получения событий, которые удовлетворяют условиям запроса.
		///         </param>
		// Token: 0x06001BCA RID: 7114 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogQuery(string path, PathType pathType, string query)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает или задает логическое значение, которое определяет, следует ли считывать события, начиная с новейшего события в журнале событий до наиболее старого события в журнале.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если чтения начиная с новейшего события в журнале событий старые события и возвращает <see langword="false" /> Если события считываются из старых событий в журнале для последнего события.
		///       </returns>
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x0005A7DC File Offset: 0x000589DC
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x0000235B File Offset: 0x0000055B
		public bool ReverseDirection
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает или задает сеанс, получить доступ к службе журнала событий на локальном или удаленном компьютере.
		///          Этот объект можно задать для доступа к удаленной журнала событий путем создания <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReader" /> объекта или <see cref="T:System.Diagnostics.Eventing.Reader.EventLogWatcher" /> объект с данным <see cref="T:System.Diagnostics.Eventing.Reader.EventLogQuery" /> объекта.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogSession" /> объекта.
		///       </returns>
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogSession Session
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает или задает логическое значение, которое определяет, будет ли этот запрос для получения событий, если запрос содержит ошибку.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Указывает, что запрос будет продолжать извлекать события даже при ошибке запроса на некоторых журналах и <see langword="false" /> Указывает, что этот запрос не будет продолжать извлекать события в случае сбоя запроса.
		///       </returns>
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0005A7F8 File Offset: 0x000589F8
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0000235B File Offset: 0x0000055B
		public bool TolerateQueryErrors
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}
	}
}
