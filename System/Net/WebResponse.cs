using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Предоставляет ответ с URI. Это класс <see langword="abstract" />.</summary>
	// Token: 0x0200061C RID: 1564
	[Serializable]
	public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebResponse" />.</summary>
		// Token: 0x06003195 RID: 12693 RVA: 0x0002D758 File Offset: 0x0002B958
		protected WebResponse()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebResponse" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сведения, необходимые для сериализации нового экземпляра <see cref="T:System.Net.WebRequest" />.</param>
		/// <param name="streamingContext">Экземпляр класса <see cref="T:System.Runtime.Serialization.StreamingContext" />, указывающий источник сериализованного потока, связанного с новым экземпляром класса <see cref="T:System.Net.WebRequest" />.</param>
		/// <exception cref="T:System.NotSupportedException">Если данный конструктор не переопределен во вложенном классе, предпринимаются все возможные попытки получить к нему доступ.</exception>
		// Token: 0x06003196 RID: 12694 RVA: 0x0002D758 File Offset: 0x0002B958
		protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации экземпляра <see cref="T:System.Net.WebResponse" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который будет содержать сериализованные данные для <see cref="T:System.Net.WebResponse" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий назначение сериализованного потока, связанного с классом <see cref="T:System.Net.WebResponse" />.</param>
		// Token: 0x06003197 RID: 12695 RVA: 0x000ABB1C File Offset: 0x000A9D1C
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x06003198 RID: 12696 RVA: 0x00003917 File Offset: 0x00001B17
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		/// <summary>При переопределении во вложенном классе закрывает поток ответа.</summary>
		/// <exception cref="T:System.NotSupportedException">Если метод не переопределен во вложенном классе, предпринимаются все возможные попытки получить к нему доступ.</exception>
		// Token: 0x06003199 RID: 12697 RVA: 0x00003917 File Offset: 0x00001B17
		public virtual void Close()
		{
		}

		/// <summary>Высвобождает неуправляемые ресурсы, используемые в объекте <see cref="T:System.Net.WebResponse" />.</summary>
		// Token: 0x0600319A RID: 12698 RVA: 0x000ABB26 File Offset: 0x000A9D26
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.WebResponse" />, и опционально — управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x0600319B RID: 12699 RVA: 0x000ABB38 File Offset: 0x000A9D38
		protected virtual void Dispose(bool disposing)
		{
			if (!disposing)
			{
				return;
			}
			try
			{
				this.Close();
			}
			catch
			{
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, указывающее, был ли этот ответ получен из кэша.</summary>
		/// <returns>Значение <see langword="true" />, если ответ был взят из кэша; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x000ABB68 File Offset: 0x000A9D68
		public virtual bool IsFromCache
		{
			get
			{
				return this.m_IsFromCache;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (set) Token: 0x0600319D RID: 12701 RVA: 0x000ABB70 File Offset: 0x000A9D70
		internal bool InternalSetFromCache
		{
			set
			{
				this.m_IsFromCache = value;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x000ABB79 File Offset: 0x000A9D79
		internal virtual bool IsCacheFresh
		{
			get
			{
				return this.m_IsCacheFresh;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x000ABB81 File Offset: 0x000A9D81
		internal bool InternalSetIsCacheFresh
		{
			set
			{
				this.m_IsCacheFresh = value;
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, указывающее, была ли выполнена взаимная проверка подлинности.</summary>
		/// <returns>Значение <see langword="true" />, если и клиент, и сервер прошли проверку подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool IsMutuallyAuthenticated
		{
			get
			{
				return false;
			}
		}

		/// <summary>При переопределении во вложенном классе возвращает или задает длину содержимого принимаемых данных.</summary>
		/// <returns>Число байтов, возвращенных из Интернет-ресурса.</returns>
		/// <exception cref="T:System.NotSupportedException">Если свойство не переопределено во вложенном классе, предпринимаются все возможные попытки вернуть или задать его.</exception>
		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000A5C43 File Offset: 0x000A3E43
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x000A5C43 File Offset: 0x000A3E43
		public virtual long ContentLength
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>При переопределении производного класса возвращает или задает тип содержимого принимаемых данных.</summary>
		/// <returns>Строка, содержащая тип содержимого ответа.</returns>
		/// <exception cref="T:System.NotSupportedException">Если свойство не переопределено во вложенном классе, предпринимаются все возможные попытки вернуть или задать его.</exception>
		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x000A5C43 File Offset: 0x000A3E43
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x000A5C43 File Offset: 0x000A3E43
		public virtual string ContentType
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>При переопределении во вложенном классе возвращает поток данных из этого Интернет-ресурса.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.IO.Stream" /> для чтения данных из Интернет-ресурса.</returns>
		/// <exception cref="T:System.NotSupportedException">Если метод не переопределен во вложенном классе, предпринимаются все возможные попытки получить к нему доступ.</exception>
		// Token: 0x060031A5 RID: 12709 RVA: 0x000A5C4A File Offset: 0x000A3E4A
		public virtual Stream GetResponseStream()
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>При переопределении в производном классе возвращает URI Интернет-ресурса, который ответил на данный запрос.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Uri" />, содержащий URI Интернет-ресурса, который ответил на данный запрос.</returns>
		/// <exception cref="T:System.NotSupportedException">Если свойство не переопределено во вложенном классе, предпринимаются все возможные попытки вернуть или задать его.</exception>
		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x000A5C43 File Offset: 0x000A3E43
		public virtual Uri ResponseUri
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>При переопределении в производном классе возвращает коллекцию пар "имя-значение" для заголовка, связанную с данным запросом.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Net.WebHeaderCollection" />, содержащий значения заголовка, связанные с данным ответом.</returns>
		/// <exception cref="T:System.NotSupportedException">Если свойство не переопределено во вложенном классе, предпринимаются все возможные попытки вернуть или задать его.</exception>
		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x000A5C43 File Offset: 0x000A3E43
		public virtual WebHeaderCollection Headers
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>Возвращает значение, указывающее, поддерживаются ли заголовки.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.  
		///  Значение <see langword="true" />, если заголовки поддерживаются; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool SupportsHeaders
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04001CC7 RID: 7367
		private bool m_IsCacheFresh;

		// Token: 0x04001CC8 RID: 7368
		private bool m_IsFromCache;
	}
}
