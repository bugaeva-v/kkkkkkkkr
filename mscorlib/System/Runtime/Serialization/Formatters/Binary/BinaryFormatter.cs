using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	/// <summary>Сериализует и десериализует объект или полный граф связанных объектов в двоичном формате.</summary>
	// Token: 0x020006A9 RID: 1705
	[ComVisible(true)]
	public sealed class BinaryFormatter : IRemotingFormatter, IFormatter
	{
		/// <summary>Получает или задает формат, в котором описания типов раскладываются в сериализованном потоке.</summary>
		/// <returns>Стиль разбивки типов для использования.</returns>
		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x000D883F File Offset: 0x000D6A3F
		// (set) Token: 0x06003E9C RID: 16028 RVA: 0x000D8847 File Offset: 0x000D6A47
		public FormatterTypeStyle TypeFormat
		{
			get
			{
				return this.m_typeFormat;
			}
			set
			{
				this.m_typeFormat = value;
			}
		}

		/// <summary>Получает или задает поведение десериализатора в части, касающейся поиска и загрузки сборок.</summary>
		/// <returns>Одно из значений <see cref="T:System.Runtime.Serialization.Formatters.FormatterAssemblyStyle" />, определяющее поведение десериализатора.</returns>
		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x000D8850 File Offset: 0x000D6A50
		// (set) Token: 0x06003E9E RID: 16030 RVA: 0x000D8858 File Offset: 0x000D6A58
		public FormatterAssemblyStyle AssemblyFormat
		{
			get
			{
				return this.m_assemblyFormat;
			}
			set
			{
				this.m_assemblyFormat = value;
			}
		}

		/// <summary>Получает или задает уровень <see cref="T:System.Runtime.Serialization.Formatters.TypeFilterLevel" /> автоматической десериализации, которая осуществляется <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" />.</summary>
		/// <returns>Уровень <see cref="T:System.Runtime.Serialization.Formatters.TypeFilterLevel" />, предоставляющий текущий уровень автоматической десериализации.</returns>
		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x000D8861 File Offset: 0x000D6A61
		// (set) Token: 0x06003EA0 RID: 16032 RVA: 0x000D8869 File Offset: 0x000D6A69
		public TypeFilterLevel FilterLevel
		{
			get
			{
				return this.m_securityLevel;
			}
			set
			{
				this.m_securityLevel = value;
			}
		}

		/// <summary>Получает или задает <see cref="T:System.Runtime.Serialization.ISurrogateSelector" />, управляющий подстановкой типа при сериализации и десериализации.</summary>
		/// <returns>Суррогатный селектор, используемый с этим форматером.</returns>
		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x000D8872 File Offset: 0x000D6A72
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x000D887A File Offset: 0x000D6A7A
		public ISurrogateSelector SurrogateSelector
		{
			get
			{
				return this.m_surrogates;
			}
			set
			{
				this.m_surrogates = value;
			}
		}

		/// <summary>Получает или задает объект типа <see cref="T:System.Runtime.Serialization.SerializationBinder" />, который управляет привязкой сериализованного объекта к типу.</summary>
		/// <returns>Связыватель сериализации, используемый с этим форматером.</returns>
		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x000D8883 File Offset: 0x000D6A83
		// (set) Token: 0x06003EA4 RID: 16036 RVA: 0x000D888B File Offset: 0x000D6A8B
		public SerializationBinder Binder
		{
			get
			{
				return this.m_binder;
			}
			set
			{
				this.m_binder = value;
			}
		}

		/// <summary>Получает или задает <see cref="T:System.Runtime.Serialization.StreamingContext" /> для этого форматера.</summary>
		/// <returns>Строковый контекст, используемый с этим форматером.</returns>
		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06003EA5 RID: 16037 RVA: 0x000D8894 File Offset: 0x000D6A94
		// (set) Token: 0x06003EA6 RID: 16038 RVA: 0x000D889C File Offset: 0x000D6A9C
		public StreamingContext Context
		{
			get
			{
				return this.m_context;
			}
			set
			{
				this.m_context = value;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> со значениями по умолчанию.</summary>
		// Token: 0x06003EA7 RID: 16039 RVA: 0x000D88A5 File Offset: 0x000D6AA5
		public BinaryFormatter()
		{
			this.m_surrogates = null;
			this.m_context = new StreamingContext(StreamingContextStates.All);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> с заданными суррогатным селектором и потоковым контекстом.</summary>
		/// <param name="selector">Используемый <see cref="T:System.Runtime.Serialization.ISurrogateSelector" />. Может иметь значение <see langword="null" />.</param>
		/// <param name="context">Новые источник и назначение для сериализованных данных.</param>
		// Token: 0x06003EA8 RID: 16040 RVA: 0x000D88D2 File Offset: 0x000D6AD2
		public BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
		{
			this.m_surrogates = selector;
			this.m_context = context;
		}

		/// <summary>Десериализует заданный поток в граф объекта.</summary>
		/// <param name="serializationStream">Поток, из которого десериализуется граф объекта.</param>
		/// <returns>Верхняя (корневая) позиция графы объектов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="serializationStream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">
		///   <paramref name="serializationStream" /> поддерживает поиск, но его длина равна 0.  
		///
		/// или - 
		/// Целевым типом является тип <see cref="T:System.Decimal" />, однако его значение находится за пределами диапазона типа <see cref="T:System.Decimal" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003EA9 RID: 16041 RVA: 0x000D88F6 File Offset: 0x000D6AF6
		public object Deserialize(Stream serializationStream)
		{
			return this.Deserialize(serializationStream, null);
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x000D8900 File Offset: 0x000D6B00
		[SecurityCritical]
		internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck)
		{
			return this.Deserialize(serializationStream, handler, fCheck, null);
		}

		/// <summary>Десериализует заданный поток в граф объекта. Предоставленный <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> обрабатывает любые заголовки в этом потоке.</summary>
		/// <param name="serializationStream">Поток, из которого десериализуется граф объекта.</param>
		/// <param name="handler">
		///   <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" />, который обрабатывает любые заголовки в <paramref name="serializationStream" />. Может иметь значение <see langword="null" />.</param>
		/// <returns>Десериализованный объект или верхний объект (корень) графа объектов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="serializationStream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">
		///   <paramref name="serializationStream" /> поддерживает поиск, но его длина равна 0.  
		///
		/// или - 
		/// Целевым типом является тип <see cref="T:System.Decimal" />, однако его значение находится за пределами диапазона типа <see cref="T:System.Decimal" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003EAB RID: 16043 RVA: 0x000D890C File Offset: 0x000D6B0C
		[SecuritySafeCritical]
		public object Deserialize(Stream serializationStream, HeaderHandler handler)
		{
			return this.Deserialize(serializationStream, handler, true);
		}

		/// <summary>Десериализует ответ удаленному вызову метода от предоставленного <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="serializationStream">Поток, из которого десериализуется граф объекта.</param>
		/// <param name="handler">
		///   <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" />, который обрабатывает любые заголовки в <paramref name="serializationStream" />. Может иметь значение <see langword="null" />.</param>
		/// <param name="methodCallMessage">
		///   <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" />, содержащее дополнительные сведения об источнике вызова.</param>
		/// <returns>Десериализованный ответ удаленному вызову метода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="serializationStream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">
		///   <paramref name="serializationStream" /> поддерживает поиск, но его длина равна 0.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003EAC RID: 16044 RVA: 0x000D8917 File Offset: 0x000D6B17
		[SecuritySafeCritical]
		public object DeserializeMethodResponse(Stream serializationStream, HeaderHandler handler, IMethodCallMessage methodCallMessage)
		{
			return this.Deserialize(serializationStream, handler, true, methodCallMessage);
		}

		/// <summary>Десериализует заданный поток в граф объекта. Предоставленный <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> обрабатывает любые заголовки в этом потоке.</summary>
		/// <param name="serializationStream">Поток, из которого десериализуется граф объекта.</param>
		/// <param name="handler">
		///   <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" />, который обрабатывает любые заголовки в <paramref name="serializationStream" />. Может иметь значение <see langword="null" />.</param>
		/// <returns>Десериализованный объект или верхний объект (корень) графа объектов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="serializationStream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">
		///   <paramref name="serializationStream" /> поддерживает поиск, но его длина равна 0.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003EAD RID: 16045 RVA: 0x000D8923 File Offset: 0x000D6B23
		[SecurityCritical]
		[ComVisible(false)]
		public object UnsafeDeserialize(Stream serializationStream, HeaderHandler handler)
		{
			return this.Deserialize(serializationStream, handler, false);
		}

		/// <summary>Десериализует ответ удаленному вызову метода от предоставленного <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="serializationStream">Поток, из которого десериализуется граф объекта.</param>
		/// <param name="handler">
		///   <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" />, который обрабатывает любые заголовки в <paramref name="serializationStream" />. Может иметь значение <see langword="null" />.</param>
		/// <param name="methodCallMessage">
		///   <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" />, содержащее дополнительные сведения об источнике вызова.</param>
		/// <returns>Десериализованный ответ удаленному вызову метода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="serializationStream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">
		///   <paramref name="serializationStream" /> поддерживает поиск, но его длина равна 0.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003EAE RID: 16046 RVA: 0x000D892E File Offset: 0x000D6B2E
		[SecurityCritical]
		[ComVisible(false)]
		public object UnsafeDeserializeMethodResponse(Stream serializationStream, HeaderHandler handler, IMethodCallMessage methodCallMessage)
		{
			return this.Deserialize(serializationStream, handler, false, methodCallMessage);
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x000D893A File Offset: 0x000D6B3A
		[SecurityCritical]
		internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck, IMethodCallMessage methodCallMessage)
		{
			return this.Deserialize(serializationStream, handler, fCheck, false, methodCallMessage);
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x000D8948 File Offset: 0x000D6B48
		[SecurityCritical]
		internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck, bool isCrossAppDomain, IMethodCallMessage methodCallMessage)
		{
			if (serializationStream == null)
			{
				throw new ArgumentNullException("serializationStream", Environment.GetResourceString("Parameter '{0}' cannot be null.", new object[]
				{
					serializationStream
				}));
			}
			if (serializationStream.CanSeek && serializationStream.Length == 0L)
			{
				throw new SerializationException(Environment.GetResourceString("Attempting to deserialize an empty stream."));
			}
			InternalFE internalFE = new InternalFE();
			internalFE.FEtypeFormat = this.m_typeFormat;
			internalFE.FEserializerTypeEnum = InternalSerializerTypeE.Binary;
			internalFE.FEassemblyFormat = this.m_assemblyFormat;
			internalFE.FEsecurityLevel = this.m_securityLevel;
			ObjectReader objectReader = new ObjectReader(serializationStream, this.m_surrogates, this.m_context, internalFE, this.m_binder);
			objectReader.crossAppDomainArray = this.m_crossAppDomainArray;
			return objectReader.Deserialize(handler, new __BinaryParser(serializationStream, objectReader), fCheck, isCrossAppDomain, methodCallMessage);
		}

		/// <summary>Сериализует объект или граф объектов с указанной вершиной (корнем) в заданный поток.</summary>
		/// <param name="serializationStream">Поток, для которого необходимо сериализовать граф.</param>
		/// <param name="graph">Объект в корне сериализуемого графа.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="serializationStream" /> — <see langword="null" />.  
		///
		/// или - 
		/// Значением параметра <paramref name="graph" /> является null.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Во время сериализации произошла ошибка, например, если объект в параметре <paramref name="graph" /> не отмечен как сериализуемый.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003EB1 RID: 16049 RVA: 0x000D8A01 File Offset: 0x000D6C01
		public void Serialize(Stream serializationStream, object graph)
		{
			this.Serialize(serializationStream, graph, null);
		}

		/// <summary>Сериализует объект или граф объектов с указанной вершиной (корнем) в заданный поток, присоединяя предоставленные заголовки.</summary>
		/// <param name="serializationStream">Поток, для которого необходимо сериализовать объект.</param>
		/// <param name="graph">Объект в корне сериализуемого графа.</param>
		/// <param name="headers">Удаленные заголовки, включаемые в сериализацию. Может иметь значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="serializationStream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Во время сериализации произошла ошибка, например, если объект в параметре <paramref name="graph" /> не отмечен как сериализуемый.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003EB2 RID: 16050 RVA: 0x000D8A0C File Offset: 0x000D6C0C
		[SecuritySafeCritical]
		public void Serialize(Stream serializationStream, object graph, Header[] headers)
		{
			this.Serialize(serializationStream, graph, headers, true);
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x000D8A18 File Offset: 0x000D6C18
		[SecurityCritical]
		internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck)
		{
			if (serializationStream == null)
			{
				throw new ArgumentNullException("serializationStream", Environment.GetResourceString("Parameter '{0}' cannot be null.", new object[]
				{
					serializationStream
				}));
			}
			InternalFE internalFE = new InternalFE();
			internalFE.FEtypeFormat = this.m_typeFormat;
			internalFE.FEserializerTypeEnum = InternalSerializerTypeE.Binary;
			internalFE.FEassemblyFormat = this.m_assemblyFormat;
			ObjectWriter objectWriter = new ObjectWriter(this.m_surrogates, this.m_context, internalFE, this.m_binder);
			__BinaryWriter serWriter = new __BinaryWriter(serializationStream, objectWriter, this.m_typeFormat);
			objectWriter.Serialize(graph, headers, serWriter, fCheck);
			this.m_crossAppDomainArray = objectWriter.crossAppDomainArray;
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x000D8AAC File Offset: 0x000D6CAC
		internal static TypeInformation GetTypeInformation(Type type)
		{
			Dictionary<Type, TypeInformation> obj = BinaryFormatter.typeNameCache;
			TypeInformation result;
			lock (obj)
			{
				TypeInformation typeInformation = null;
				if (!BinaryFormatter.typeNameCache.TryGetValue(type, out typeInformation))
				{
					bool hasTypeForwardedFrom;
					string clrAssemblyName = FormatterServices.GetClrAssemblyName(type, out hasTypeForwardedFrom);
					typeInformation = new TypeInformation(FormatterServices.GetClrTypeFullName(type), clrAssemblyName, hasTypeForwardedFrom);
					BinaryFormatter.typeNameCache.Add(type, typeInformation);
				}
				result = typeInformation;
			}
			return result;
		}

		// Token: 0x040028CE RID: 10446
		internal ISurrogateSelector m_surrogates;

		// Token: 0x040028CF RID: 10447
		internal StreamingContext m_context;

		// Token: 0x040028D0 RID: 10448
		internal SerializationBinder m_binder;

		// Token: 0x040028D1 RID: 10449
		internal FormatterTypeStyle m_typeFormat = FormatterTypeStyle.TypesAlways;

		// Token: 0x040028D2 RID: 10450
		internal FormatterAssemblyStyle m_assemblyFormat;

		// Token: 0x040028D3 RID: 10451
		internal TypeFilterLevel m_securityLevel = TypeFilterLevel.Full;

		// Token: 0x040028D4 RID: 10452
		internal object[] m_crossAppDomainArray;

		// Token: 0x040028D5 RID: 10453
		private static Dictionary<Type, TypeInformation> typeNameCache = new Dictionary<Type, TypeInformation>();
	}
}
