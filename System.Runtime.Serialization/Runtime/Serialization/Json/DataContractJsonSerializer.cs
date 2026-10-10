using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace System.Runtime.Serialization.Json
{
	/// <summary>Сериализует объекты в нотацию объектов JavaScript (JSON) и десериализует данные JSON в объекты. Этот класс не наследуется.</summary>
	// Token: 0x02000165 RID: 357
	[TypeForwardedFrom("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
	public sealed class DataContractJsonSerializer : XmlObjectSerializer
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		// Token: 0x060012AF RID: 4783 RVA: 0x00049551 File Offset: 0x00047751
		public DataContractJsonSerializer(Type type) : this(type, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа с использованием корневого элемента XML, заданного параметром.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Имя XML-элемента, содержащего данные для сериализации или десериализации.</param>
		// Token: 0x060012B0 RID: 4784 RVA: 0x0004955B File Offset: 0x0004775B
		public DataContractJsonSerializer(Type type, string rootName) : this(type, rootName, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа с использованием корневого элемента XML, заданного параметром типа <see cref="T:System.Xml.XmlDictionaryString" />.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Объект <see cref="T:System.Xml.XmlDictionaryString" />, содержащий имя корневого элемента содержимого.</param>
		// Token: 0x060012B1 RID: 4785 RVA: 0x00049566 File Offset: 0x00047766
		public DataContractJsonSerializer(Type type, XmlDictionaryString rootName) : this(type, rootName, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа с помощью коллекции известных типов, которые могут присутствовать в графе объекта.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся типы, которые могут присутствовать в графе объекта.</param>
		// Token: 0x060012B2 RID: 4786 RVA: 0x00049571 File Offset: 0x00047771
		public DataContractJsonSerializer(Type type, IEnumerable<Type> knownTypes) : this(type, knownTypes, int.MaxValue, false, null, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа, используя корневой элемент XML, заданный параметром, и коллекцию известных типов, которые могут присутствовать в графе объекта.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Имя XML-элемента, содержащего данные для сериализации или десериализации. Значение по умолчанию — "root".</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся типы, которые могут присутствовать в графе объекта.</param>
		// Token: 0x060012B3 RID: 4787 RVA: 0x00049583 File Offset: 0x00047783
		public DataContractJsonSerializer(Type type, string rootName, IEnumerable<Type> knownTypes) : this(type, rootName, knownTypes, int.MaxValue, false, null, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа с использованием корневого элемента XML, заданного параметром типа <see cref="T:System.Xml.XmlDictionaryString" />, с коллекцией известных типов, которые могут присутствовать в графе объекта.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Объект <see cref="T:System.Xml.XmlDictionaryString" />, содержащий имя корневого элемента содержимого.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся типы, которые могут присутствовать в графе объекта.</param>
		// Token: 0x060012B4 RID: 4788 RVA: 0x00049596 File Offset: 0x00047796
		public DataContractJsonSerializer(Type type, XmlDictionaryString rootName, IEnumerable<Type> knownTypes) : this(type, rootName, knownTypes, int.MaxValue, false, null, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает список известных типов, которые могут присутствовать в графе объектов, максимальное количество элементов графа для сериализации или десериализации, пропускать ли непредвиденные данные и создавать ли информацию о типе, а также суррогат для пользовательской сериализации.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="knownTypes">Объект <see cref="T:System.Xml.XmlDictionaryString" />, содержащий имя корневого элемента содержимого.</param>
		/// <param name="maxItemsInObjectGraph">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать интерфейс <see cref="T:System.Runtime.Serialization.IExtensibleDataObject" /> при сериализации и игнорировать непредвиденные данные при десериализации; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <param name="alwaysEmitTypeInformation">Значение <see langword="true" /> — для создания информации о типе; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</param>
		// Token: 0x060012B5 RID: 4789 RVA: 0x000495AC File Offset: 0x000477AC
		public DataContractJsonSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation)
		{
			EmitTypeInformation emitTypeInformation = alwaysEmitTypeInformation ? EmitTypeInformation.Always : EmitTypeInformation.AsNeeded;
			this.Initialize(type, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, dataContractSurrogate, emitTypeInformation, false, null, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает корневое имя XML-элемента, список известных типов, которые могут присутствовать в графе объектов, максимальное количество элементов графа для сериализации или десериализации, пропускать ли непредвиденные данные и создавать ли информацию о типе, а также суррогат для пользовательской сериализации.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Имя XML-элемента, содержащего данные для сериализации или десериализации. Значение по умолчанию — "root".</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="maxItemsInObjectGraph">Максимальное количество элементов в графе для сериализации или десериализации. Значением по умолчанию является значение, возвращенное свойством <see cref="F:System.Int32.MaxValue" />.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать интерфейс <see cref="T:System.Runtime.Serialization.IExtensibleDataObject" /> при сериализации и игнорировать непредвиденные данные при десериализации; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <param name="alwaysEmitTypeInformation">Значение <see langword="true" /> — для создания информации о типе; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</param>
		// Token: 0x060012B6 RID: 4790 RVA: 0x000495DC File Offset: 0x000477DC
		public DataContractJsonSerializer(Type type, string rootName, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation)
		{
			EmitTypeInformation emitTypeInformation = alwaysEmitTypeInformation ? EmitTypeInformation.Always : EmitTypeInformation.AsNeeded;
			XmlDictionary xmlDictionary = new XmlDictionary(2);
			this.Initialize(type, xmlDictionary.Add(rootName), knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, dataContractSurrogate, emitTypeInformation, false, null, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает корневое имя XML-элемента, список известных типов, которые могут присутствовать в графе объектов, максимальное количество элементов графа для сериализации или десериализации, пропускать ли непредвиденные данные и создавать ли информацию о типе, а также суррогат для пользовательской сериализации.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Объект <see cref="T:System.Xml.XmlDictionaryString" />, содержащий имя корневого элемента содержимого.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся известные типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="maxItemsInObjectGraph">Максимальное количество элементов в графе для сериализации или десериализации. Значением по умолчанию является значение, возвращенное свойством <see cref="F:System.Int32.MaxValue" />.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать интерфейс <see cref="T:System.Runtime.Serialization.IExtensibleDataObject" /> при сериализации и игнорировать непредвиденные данные при десериализации; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <param name="alwaysEmitTypeInformation">Значение <see langword="true" /> — для создания информации о типе; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</param>
		// Token: 0x060012B7 RID: 4791 RVA: 0x00049618 File Offset: 0x00047818
		public DataContractJsonSerializer(Type type, XmlDictionaryString rootName, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation)
		{
			EmitTypeInformation emitTypeInformation = alwaysEmitTypeInformation ? EmitTypeInformation.Always : EmitTypeInformation.AsNeeded;
			this.Initialize(type, rootName, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, dataContractSurrogate, emitTypeInformation, false, null, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" /> для сериализации или десериализации объекта указанного типа и параметров сериализатора.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="settings">Параметры сериализатора для сериализатора JSON.</param>
		// Token: 0x060012B8 RID: 4792 RVA: 0x00049648 File Offset: 0x00047848
		public DataContractJsonSerializer(Type type, DataContractJsonSerializerSettings settings)
		{
			if (settings == null)
			{
				settings = new DataContractJsonSerializerSettings();
			}
			XmlDictionaryString xmlDictionaryString = (settings.RootName == null) ? null : new XmlDictionary(1).Add(settings.RootName);
			this.Initialize(type, xmlDictionaryString, settings.KnownTypes, settings.MaxItemsInObjectGraph, settings.IgnoreExtensionDataObject, settings.DataContractSurrogate, settings.EmitTypeInformation, settings.SerializeReadOnlyTypes, settings.DateTimeFormat, settings.UseSimpleDictionaryFormat);
		}

		/// <summary>Возвращает тип суррогата, который в данный момент активен для заданного экземпляра <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" />. Суррогаты могут расширять процесс сериализации и десериализации.</summary>
		/// <returns>Реализация класса <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" />.</returns>
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x000496BA File Offset: 0x000478BA
		public IDataContractSurrogate DataContractSurrogate
		{
			get
			{
				return this.dataContractSurrogate;
			}
		}

		/// <summary>Возвращает значение, указывающее, игнорируются ли неизвестные данные при десериализации и игнорируется ли интерфейс <see cref="T:System.Runtime.Serialization.IExtensibleDataObject" /> при сериализации.</summary>
		/// <returns>Значение <see langword="true" />, если требуется игнорировать неизвестные данные и интерфейс <see cref="T:System.Runtime.Serialization.IExtensibleDataObject" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000496C2 File Offset: 0x000478C2
		public bool IgnoreExtensionDataObject
		{
			get
			{
				return this.ignoreExtensionDataObject;
			}
		}

		/// <summary>Возвращает коллекцию типов, которые могут присутствовать в графе объекта, сериализованном с помощью этого экземпляра класса <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, содержащая ожидаемые типы, переданные в качестве известных типов в конструктор <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" />.</returns>
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x000496CA File Offset: 0x000478CA
		public ReadOnlyCollection<Type> KnownTypes
		{
			get
			{
				if (this.knownTypeCollection == null)
				{
					if (this.knownTypeList != null)
					{
						this.knownTypeCollection = new ReadOnlyCollection<Type>(this.knownTypeList);
					}
					else
					{
						this.knownTypeCollection = new ReadOnlyCollection<Type>(Globals.EmptyTypeArray);
					}
				}
				return this.knownTypeCollection;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00049705 File Offset: 0x00047905
		internal override Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
		{
			get
			{
				if (this.knownDataContracts == null && this.knownTypeList != null)
				{
					this.knownDataContracts = XmlObjectSerializerContext.GetDataContractsForKnownTypes(this.knownTypeList);
				}
				return this.knownDataContracts;
			}
		}

		/// <summary>Возвращает максимальное количество элементов в графе объекта, которое сериализатор сериализует или десериализует в одном вызове на чтение или запись.</summary>
		/// <returns>Максимальное количество элементов для сериализации или десериализации.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество элементов превышает максимальное значение.</exception>
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x0004972E File Offset: 0x0004792E
		public int MaxItemsInObjectGraph
		{
			get
			{
				return this.maxItemsInObjectGraph;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x00049736 File Offset: 0x00047936
		internal bool AlwaysEmitTypeInformation
		{
			get
			{
				return this.emitTypeInformation == EmitTypeInformation.Always;
			}
		}

		/// <summary>Получает или задает параметры сериализатора контракта данных JSON для выдачи сведений о типе.</summary>
		/// <returns>Параметры сериализатора контракта данных JSON для выдачи сведений о типе.</returns>
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00049741 File Offset: 0x00047941
		public EmitTypeInformation EmitTypeInformation
		{
			get
			{
				return this.emitTypeInformation;
			}
		}

		/// <summary>Получает или задает значение, указывающее, следует ли сериализовать типы, доступные только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> для сериализации доступных только для чтения типов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x00049749 File Offset: 0x00047949
		public bool SerializeReadOnlyTypes
		{
			get
			{
				return this.serializeReadOnlyTypes;
			}
		}

		/// <summary>Получает формат элементов типа "дата и время" в графе объектов.</summary>
		/// <returns>Формат элементов типа "дата и время" в графе объектов.</returns>
		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00049751 File Offset: 0x00047951
		public DateTimeFormat DateTimeFormat
		{
			get
			{
				return this.dateTimeFormat;
			}
		}

		/// <summary>Получает значение, указывающее, следует ли использовать простой формат словаря.</summary>
		/// <returns>Значение <see langword="true" /> для использования простого формата словаря; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x00049759 File Offset: 0x00047959
		public bool UseSimpleDictionaryFormat
		{
			get
			{
				return this.useSimpleDictionaryFormat;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00049764 File Offset: 0x00047964
		private DataContract RootContract
		{
			get
			{
				if (this.rootContract == null)
				{
					this.rootContract = DataContract.GetDataContract((this.dataContractSurrogate == null) ? this.rootType : DataContractSerializer.GetSurrogatedType(this.dataContractSurrogate, this.rootType));
					DataContractJsonSerializer.CheckIfTypeIsReference(this.rootContract);
				}
				return this.rootContract;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x000497B6 File Offset: 0x000479B6
		private XmlDictionaryString RootName
		{
			get
			{
				return this.rootName ?? JsonGlobals.rootDictionaryString;
			}
		}

		/// <summary>Определяет, расположен ли объект <see cref="T:System.Xml.XmlReader" /> на объекте, который может быть десериализован.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />, используемый для чтения XML-потока.</param>
		/// <returns>Значение <see langword="true" />, если средство чтения расположено правильно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060012C5 RID: 4805 RVA: 0x000497C7 File Offset: 0x000479C7
		public override bool IsStartObject(XmlReader reader)
		{
			return base.IsStartObjectHandleExceptions(new JsonReaderDelegator(reader));
		}

		/// <summary>Возвращает значение, указывающее, расположен ли объект <see cref="T:System.Xml.XmlDictionaryReader" /> над XML-элементом, представляющим объект, из которого сериализатор может выполнить десериализацию.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlDictionaryReader" />, используемый для чтения XML-потока, полученного из JSON.</param>
		/// <returns>Значение <see langword="true" />, если средство чтения расположено правильно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060012C6 RID: 4806 RVA: 0x000497C7 File Offset: 0x000479C7
		public override bool IsStartObject(XmlDictionaryReader reader)
		{
			return base.IsStartObjectHandleExceptions(new JsonReaderDelegator(reader));
		}

		/// <summary>Выполняет чтение потока документа в формате JSON (нотации объектов JavaScript) и возвращает десериализованный объект.</summary>
		/// <param name="stream">Поток <see cref="T:System.IO.Stream" />, подлежащий чтению.</param>
		/// <returns>Десериализованный объект.</returns>
		// Token: 0x060012C7 RID: 4807 RVA: 0x000497D5 File Offset: 0x000479D5
		public override object ReadObject(Stream stream)
		{
			XmlObjectSerializer.CheckNull(stream, "stream");
			return this.ReadObject(JsonReaderWriterFactory.CreateJsonReader(stream, XmlDictionaryReaderQuotas.Max));
		}

		/// <summary>Выполняет чтение XML-документа, полученного из JSON (нотации объектов JavaScript), с помощью <see cref="T:System.Xml.XmlReader" /> и возвращает десериализованный объект.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />, используемый для чтения XML-документа, полученного из JSON.</param>
		/// <returns>Десериализованный объект.</returns>
		// Token: 0x060012C8 RID: 4808 RVA: 0x000497F3 File Offset: 0x000479F3
		public override object ReadObject(XmlReader reader)
		{
			return base.ReadObjectHandleExceptions(new JsonReaderDelegator(reader, this.DateTimeFormat), true);
		}

		/// <summary>Выполняет чтение XML-документа, полученного из JSON, с помощью <see cref="T:System.Xml.XmlReader" /> и возвращает десериализованный объект; также позволяет задать, должен ли сериализатор перед попыткой выполнить десериализацию проверить, что он расположен на соответствующем элементе.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />, используемый для чтения XML-документа, полученного из JSON.</param>
		/// <param name="verifyObjectName">Значение <see langword="true" /> — для проверки соответствия имени и пространства имен включающего XML-элемента ожидаемым имени и пространству имен; в противном случае — значение <see langword="false" /> (для пропуска проверки). Значение по умолчанию — <see langword="true" />.</param>
		/// <returns>Десериализованный объект.</returns>
		// Token: 0x060012C9 RID: 4809 RVA: 0x00049808 File Offset: 0x00047A08
		public override object ReadObject(XmlReader reader, bool verifyObjectName)
		{
			return base.ReadObjectHandleExceptions(new JsonReaderDelegator(reader, this.DateTimeFormat), verifyObjectName);
		}

		/// <summary>Выполняет чтение XML-документа, полученного из JSON (нотации объектов JavaScript), с помощью <see cref="T:System.Xml.XmlDictionaryReader" /> и возвращает десериализованный объект.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlDictionaryReader" />, используемый для чтения XML-документа, полученного из JSON.</param>
		/// <returns>Десериализованный объект.</returns>
		// Token: 0x060012CA RID: 4810 RVA: 0x000497F3 File Offset: 0x000479F3
		public override object ReadObject(XmlDictionaryReader reader)
		{
			return base.ReadObjectHandleExceptions(new JsonReaderDelegator(reader, this.DateTimeFormat), true);
		}

		/// <summary>Выполняет чтение XML-документа, полученного из JSON, с помощью <see cref="T:System.Xml.XmlDictionaryReader" /> и возвращает десериализованный объект; также позволяет задать, должен ли сериализатор перед попыткой выполнить десериализацию проверить, что он расположен на соответствующем элементе.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlDictionaryReader" />, используемый для чтения XML-документа, полученного из JSON.</param>
		/// <param name="verifyObjectName">Значение <see langword="true" /> — для проверки соответствия имени и пространства имен включающего XML-элемента ожидаемым имени и пространству имен; в противном случае — значение <see langword="false" /> (для пропуска проверки). Значение по умолчанию — <see langword="true" />.</param>
		/// <returns>Десериализованный объект.</returns>
		// Token: 0x060012CB RID: 4811 RVA: 0x00049808 File Offset: 0x00047A08
		public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName)
		{
			return base.ReadObjectHandleExceptions(new JsonReaderDelegator(reader, this.DateTimeFormat), verifyObjectName);
		}

		/// <summary>Записывает закрывающий XML-элемент в XML-документ (используя <see cref="T:System.Xml.XmlWriter" />), который может быть сопоставлен нотации объектов JavaScript (JSON).</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, используемый для записи в XML-документ, сопоставленный данным JSON.</param>
		// Token: 0x060012CC RID: 4812 RVA: 0x0004981D File Offset: 0x00047A1D
		public override void WriteEndObject(XmlWriter writer)
		{
			base.WriteEndObjectHandleExceptions(new JsonWriterDelegator(writer));
		}

		/// <summary>Записывает закрывающий XML-элемент в XML-документ (используя <see cref="T:System.Xml.XmlDictionaryWriter" />), который может быть сопоставлен нотации объектов JavaScript (JSON).</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, используемый для записи в XML-документ для сопоставления данным JSON.</param>
		// Token: 0x060012CD RID: 4813 RVA: 0x0004981D File Offset: 0x00047A1D
		public override void WriteEndObject(XmlDictionaryWriter writer)
		{
			base.WriteEndObjectHandleExceptions(new JsonWriterDelegator(writer));
		}

		/// <summary>Сериализует указанный объект в данные нотации объектов JavaScript (JSON) и записывает полученные данные JSON в поток.</summary>
		/// <param name="stream">Поток <see cref="T:System.IO.Stream" />, в который осуществляется запись.</param>
		/// <param name="graph">Объект, содержащий данные для записи в поток.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		/// <exception cref="T:System.ServiceModel.QuotaExceededException">Превышено максимально допустимое количество объектов для сериализации. Проверьте свойство <see cref="P:System.Runtime.Serialization.DataContractSerializer.MaxItemsInObjectGraph" />.</exception>
		// Token: 0x060012CE RID: 4814 RVA: 0x0004982C File Offset: 0x00047A2C
		public override void WriteObject(Stream stream, object graph)
		{
			XmlObjectSerializer.CheckNull(stream, "stream");
			XmlDictionaryWriter xmlDictionaryWriter = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, false);
			this.WriteObject(xmlDictionaryWriter, graph);
			xmlDictionaryWriter.Flush();
		}

		/// <summary>Сериализует объект в код XML, который может быть сопоставлен нотации объектов JavaScript (JSON). Записывает все данные объекта, включая начальный XML-элемент, содержимое и закрывающий элемент, с помощью <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, используемый для записи в XML-документ для сопоставления данным JSON.</param>
		/// <param name="graph">Объект, содержащий данные для записи.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		/// <exception cref="T:System.ServiceModel.QuotaExceededException">Превышено максимально допустимое количество объектов для сериализации. Проверьте свойство <see cref="P:System.Runtime.Serialization.DataContractSerializer.MaxItemsInObjectGraph" />.</exception>
		// Token: 0x060012CF RID: 4815 RVA: 0x0004985F File Offset: 0x00047A5F
		public override void WriteObject(XmlWriter writer, object graph)
		{
			base.WriteObjectHandleExceptions(new JsonWriterDelegator(writer, this.DateTimeFormat), graph);
		}

		/// <summary>Сериализует объект в код XML, который может быть сопоставлен нотации объектов JavaScript (JSON). Записывает все данные объекта, включая начальный XML-элемент, содержимое и закрывающий элемент, с помощью <see cref="T:System.Xml.XmlDictionaryWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, используемый для записи в XML-документ или поток для сопоставления данным JSON.</param>
		/// <param name="graph">Объект, содержащий данные для записи.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		/// <exception cref="T:System.ServiceModel.QuotaExceededException">Превышено максимально допустимое количество объектов для сериализации. Проверьте свойство <see cref="P:System.Runtime.Serialization.DataContractSerializer.MaxItemsInObjectGraph" />.</exception>
		// Token: 0x060012D0 RID: 4816 RVA: 0x0004985F File Offset: 0x00047A5F
		public override void WriteObject(XmlDictionaryWriter writer, object graph)
		{
			base.WriteObjectHandleExceptions(new JsonWriterDelegator(writer, this.DateTimeFormat), graph);
		}

		/// <summary>Записывает содержимое XML, которое может быть сопоставлено нотации объектов JavaScript (JSON), используя <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, в который выполняется запись.</param>
		/// <param name="graph">Записываемый объект.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		/// <exception cref="T:System.ServiceModel.QuotaExceededException">Превышено максимально допустимое количество объектов для сериализации. Проверьте свойство <see cref="P:System.Runtime.Serialization.DataContractSerializer.MaxItemsInObjectGraph" />.</exception>
		// Token: 0x060012D1 RID: 4817 RVA: 0x00049874 File Offset: 0x00047A74
		public override void WriteObjectContent(XmlWriter writer, object graph)
		{
			base.WriteObjectContentHandleExceptions(new JsonWriterDelegator(writer, this.DateTimeFormat), graph);
		}

		/// <summary>Записывает содержимое XML, которое может быть сопоставлено нотации объектов JavaScript (JSON), используя <see cref="T:System.Xml.XmlDictionaryWriter" />.</summary>
		/// <param name="writer">Экземпляр <see cref="T:System.Xml.XmlDictionaryWriter" />, в который выполняется запись.</param>
		/// <param name="graph">Записываемый объект.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		/// <exception cref="T:System.ServiceModel.QuotaExceededException">Превышено максимально допустимое количество объектов для сериализации. Проверьте свойство <see cref="P:System.Runtime.Serialization.DataContractSerializer.MaxItemsInObjectGraph" />.</exception>
		// Token: 0x060012D2 RID: 4818 RVA: 0x00049874 File Offset: 0x00047A74
		public override void WriteObjectContent(XmlDictionaryWriter writer, object graph)
		{
			base.WriteObjectContentHandleExceptions(new JsonWriterDelegator(writer, this.DateTimeFormat), graph);
		}

		/// <summary>Записывает открывающий XML-элемент для сериализации объекта в XML-код, который может быть сопоставлен нотации объектов JavaScript (JSON), используя <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, используемый для записи начального элемента XML.</param>
		/// <param name="graph">Записываемый объект.</param>
		// Token: 0x060012D3 RID: 4819 RVA: 0x00049889 File Offset: 0x00047A89
		public override void WriteStartObject(XmlWriter writer, object graph)
		{
			base.WriteStartObjectHandleExceptions(new JsonWriterDelegator(writer), graph);
		}

		/// <summary>Записывает открывающий XML-элемент для сериализации объекта в XML-код, который может быть сопоставлен нотации объектов JavaScript (JSON), используя <see cref="T:System.Xml.XmlDictionaryWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, используемый для записи начального элемента XML.</param>
		/// <param name="graph">Записываемый объект.</param>
		// Token: 0x060012D4 RID: 4820 RVA: 0x00049889 File Offset: 0x00047A89
		public override void WriteStartObject(XmlDictionaryWriter writer, object graph)
		{
			base.WriteStartObjectHandleExceptions(new JsonWriterDelegator(writer), graph);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00049898 File Offset: 0x00047A98
		internal static bool CheckIfJsonNameRequiresMapping(string jsonName)
		{
			if (jsonName != null)
			{
				if (!DataContract.IsValidNCName(jsonName))
				{
					return true;
				}
				for (int i = 0; i < jsonName.Length; i++)
				{
					if (XmlJsonWriter.CharacterNeedsEscaping(jsonName[i]))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000498D4 File Offset: 0x00047AD4
		internal static bool CheckIfJsonNameRequiresMapping(XmlDictionaryString jsonName)
		{
			return jsonName != null && DataContractJsonSerializer.CheckIfJsonNameRequiresMapping(jsonName.Value);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x000498E6 File Offset: 0x00047AE6
		internal static bool CheckIfXmlNameRequiresMapping(string xmlName)
		{
			return xmlName != null && DataContractJsonSerializer.CheckIfJsonNameRequiresMapping(DataContractJsonSerializer.ConvertXmlNameToJsonName(xmlName));
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000498F8 File Offset: 0x00047AF8
		internal static bool CheckIfXmlNameRequiresMapping(XmlDictionaryString xmlName)
		{
			return xmlName != null && DataContractJsonSerializer.CheckIfXmlNameRequiresMapping(xmlName.Value);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0004990A File Offset: 0x00047B0A
		internal static string ConvertXmlNameToJsonName(string xmlName)
		{
			return XmlConvert.DecodeName(xmlName);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00049912 File Offset: 0x00047B12
		internal static XmlDictionaryString ConvertXmlNameToJsonName(XmlDictionaryString xmlName)
		{
			if (xmlName != null)
			{
				return new XmlDictionary().Add(DataContractJsonSerializer.ConvertXmlNameToJsonName(xmlName.Value));
			}
			return null;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00049930 File Offset: 0x00047B30
		internal static bool IsJsonLocalName(XmlReaderDelegator reader, string elementName)
		{
			string b;
			return XmlObjectSerializerReadContextComplexJson.TryGetJsonLocalName(reader, out b) && elementName == b;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00049950 File Offset: 0x00047B50
		internal static object ReadJsonValue(DataContract contract, XmlReaderDelegator reader, XmlObjectSerializerReadContextComplexJson context)
		{
			return JsonDataContract.GetJsonDataContract(contract).ReadJsonValue(reader, context);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0004995F File Offset: 0x00047B5F
		internal static void WriteJsonNull(XmlWriterDelegator writer)
		{
			writer.WriteAttributeString(null, "type", null, "null");
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00049973 File Offset: 0x00047B73
		internal static void WriteJsonValue(JsonDataContract contract, XmlWriterDelegator writer, object graph, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle)
		{
			contract.WriteJsonValue(writer, graph, context, declaredTypeHandle);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00049980 File Offset: 0x00047B80
		internal override Type GetDeserializeType()
		{
			return this.rootType;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00049988 File Offset: 0x00047B88
		internal override Type GetSerializeType(object graph)
		{
			if (graph != null)
			{
				return graph.GetType();
			}
			return this.rootType;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0004999A File Offset: 0x00047B9A
		internal override bool InternalIsStartObject(XmlReaderDelegator reader)
		{
			return base.IsRootElement(reader, this.RootContract, this.RootName, XmlDictionaryString.Empty) || DataContractJsonSerializer.IsJsonLocalName(reader, this.RootName.Value);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000499CC File Offset: 0x00047BCC
		internal override object InternalReadObject(XmlReaderDelegator xmlReader, bool verifyObjectName)
		{
			if (this.MaxItemsInObjectGraph == 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("Maximum number of items that can be serialized or deserialized in an object graph is '{0}'.", new object[]
				{
					this.MaxItemsInObjectGraph
				})));
			}
			if (verifyObjectName)
			{
				if (!this.InternalIsStartObject(xmlReader))
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationExceptionWithReaderDetails(SR.GetString("Expecting element '{1}' from namespace '{0}'.", new object[]
					{
						XmlDictionaryString.Empty,
						this.RootName
					}), xmlReader));
				}
			}
			else if (!base.IsStartElement(xmlReader))
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationExceptionWithReaderDetails(SR.GetString("Expecting state '{0}' when ReadObject is called.", new object[]
				{
					XmlNodeType.Element
				}), xmlReader));
			}
			DataContract dataContract = this.RootContract;
			if (dataContract.IsPrimitive && dataContract.UnderlyingType == this.rootType)
			{
				return DataContractJsonSerializer.ReadJsonValue(dataContract, xmlReader, null);
			}
			return XmlObjectSerializerReadContextComplexJson.CreateContext(this, dataContract).InternalDeserialize(xmlReader, this.rootType, dataContract, null, null);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0003628A File Offset: 0x0003448A
		internal override void InternalWriteEndObject(XmlWriterDelegator writer)
		{
			writer.WriteEndElement();
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00049AAD File Offset: 0x00047CAD
		internal override void InternalWriteObject(XmlWriterDelegator writer, object graph)
		{
			this.InternalWriteStartObject(writer, graph);
			this.InternalWriteObjectContent(writer, graph);
			this.InternalWriteEndObject(writer);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00049AC8 File Offset: 0x00047CC8
		internal override void InternalWriteObjectContent(XmlWriterDelegator writer, object graph)
		{
			if (this.MaxItemsInObjectGraph == 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("Maximum number of items that can be serialized or deserialized in an object graph is '{0}'.", new object[]
				{
					this.MaxItemsInObjectGraph
				})));
			}
			DataContract dataContract = this.RootContract;
			Type underlyingType = dataContract.UnderlyingType;
			Type type = (graph == null) ? underlyingType : graph.GetType();
			if (this.dataContractSurrogate != null)
			{
				graph = DataContractSerializer.SurrogateToDataContractType(this.dataContractSurrogate, graph, underlyingType, ref type);
			}
			if (graph == null)
			{
				DataContractJsonSerializer.WriteJsonNull(writer);
				return;
			}
			if (underlyingType == type)
			{
				if (dataContract.CanContainReferences)
				{
					XmlObjectSerializerWriteContextComplexJson xmlObjectSerializerWriteContextComplexJson = XmlObjectSerializerWriteContextComplexJson.CreateContext(this, dataContract);
					xmlObjectSerializerWriteContextComplexJson.OnHandleReference(writer, graph, true);
					xmlObjectSerializerWriteContextComplexJson.SerializeWithoutXsiType(dataContract, writer, graph, underlyingType.TypeHandle);
					return;
				}
				DataContractJsonSerializer.WriteJsonValue(JsonDataContract.GetJsonDataContract(dataContract), writer, graph, null, underlyingType.TypeHandle);
				return;
			}
			else
			{
				XmlObjectSerializerWriteContextComplexJson xmlObjectSerializerWriteContextComplexJson2 = XmlObjectSerializerWriteContextComplexJson.CreateContext(this, this.RootContract);
				dataContract = DataContractJsonSerializer.GetDataContract(dataContract, underlyingType, type);
				if (dataContract.CanContainReferences)
				{
					xmlObjectSerializerWriteContextComplexJson2.OnHandleReference(writer, graph, true);
					xmlObjectSerializerWriteContextComplexJson2.SerializeWithXsiTypeAtTopLevel(dataContract, writer, graph, underlyingType.TypeHandle, type);
					return;
				}
				xmlObjectSerializerWriteContextComplexJson2.SerializeWithoutXsiType(dataContract, writer, graph, underlyingType.TypeHandle);
				return;
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00049BD4 File Offset: 0x00047DD4
		internal override void InternalWriteStartObject(XmlWriterDelegator writer, object graph)
		{
			if (this.rootNameRequiresMapping)
			{
				writer.WriteStartElement("a", "item", "item");
				writer.WriteAttributeString(null, "item", null, this.RootName.Value);
				return;
			}
			writer.WriteStartElement(this.RootName, XmlDictionaryString.Empty);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00049C28 File Offset: 0x00047E28
		private void AddCollectionItemTypeToKnownTypes(Type knownType)
		{
			Type type = knownType;
			Type type2;
			while (CollectionDataContract.IsCollection(type, out type2))
			{
				if (type2.IsGenericType && type2.GetGenericTypeDefinition() == Globals.TypeOfKeyValue)
				{
					type2 = Globals.TypeOfKeyValuePair.MakeGenericType(type2.GetGenericArguments());
				}
				this.knownTypeList.Add(type2);
				type = type2;
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00049C7C File Offset: 0x00047E7C
		private void Initialize(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, EmitTypeInformation emitTypeInformation, bool serializeReadOnlyTypes, DateTimeFormat dateTimeFormat, bool useSimpleDictionaryFormat)
		{
			XmlObjectSerializer.CheckNull(type, "type");
			this.rootType = type;
			if (knownTypes != null)
			{
				this.knownTypeList = new List<Type>();
				foreach (Type type2 in knownTypes)
				{
					this.knownTypeList.Add(type2);
					if (type2 != null)
					{
						this.AddCollectionItemTypeToKnownTypes(type2);
					}
				}
			}
			if (maxItemsInObjectGraph < 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("maxItemsInObjectGraph", SR.GetString("The value of this argument must be non-negative.")));
			}
			this.maxItemsInObjectGraph = maxItemsInObjectGraph;
			this.ignoreExtensionDataObject = ignoreExtensionDataObject;
			this.dataContractSurrogate = dataContractSurrogate;
			this.emitTypeInformation = emitTypeInformation;
			this.serializeReadOnlyTypes = serializeReadOnlyTypes;
			this.dateTimeFormat = dateTimeFormat;
			this.useSimpleDictionaryFormat = useSimpleDictionaryFormat;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00049D50 File Offset: 0x00047F50
		private void Initialize(Type type, XmlDictionaryString rootName, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, IDataContractSurrogate dataContractSurrogate, EmitTypeInformation emitTypeInformation, bool serializeReadOnlyTypes, DateTimeFormat dateTimeFormat, bool useSimpleDictionaryFormat)
		{
			this.Initialize(type, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, dataContractSurrogate, emitTypeInformation, serializeReadOnlyTypes, dateTimeFormat, useSimpleDictionaryFormat);
			this.rootName = DataContractJsonSerializer.ConvertXmlNameToJsonName(rootName);
			this.rootNameRequiresMapping = DataContractJsonSerializer.CheckIfJsonNameRequiresMapping(this.rootName);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00049D90 File Offset: 0x00047F90
		internal static void CheckIfTypeIsReference(DataContract dataContract)
		{
			if (dataContract.IsReference)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("Unsupported value for IsReference for type '{0}', IsReference value is {1}.", new object[]
				{
					DataContract.GetClrTypeFullName(dataContract.UnderlyingType),
					dataContract.IsReference
				})));
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00049DDC File Offset: 0x00047FDC
		internal static DataContract GetDataContract(DataContract declaredTypeContract, Type declaredType, Type objectType)
		{
			DataContract dataContract = DataContractSerializer.GetDataContract(declaredTypeContract, declaredType, objectType);
			DataContractJsonSerializer.CheckIfTypeIsReference(dataContract);
			return dataContract;
		}

		// Token: 0x04000971 RID: 2417
		internal IList<Type> knownTypeList;

		// Token: 0x04000972 RID: 2418
		internal Dictionary<XmlQualifiedName, DataContract> knownDataContracts;

		// Token: 0x04000973 RID: 2419
		private EmitTypeInformation emitTypeInformation;

		// Token: 0x04000974 RID: 2420
		private IDataContractSurrogate dataContractSurrogate;

		// Token: 0x04000975 RID: 2421
		private bool ignoreExtensionDataObject;

		// Token: 0x04000976 RID: 2422
		private ReadOnlyCollection<Type> knownTypeCollection;

		// Token: 0x04000977 RID: 2423
		private int maxItemsInObjectGraph;

		// Token: 0x04000978 RID: 2424
		private DataContract rootContract;

		// Token: 0x04000979 RID: 2425
		private XmlDictionaryString rootName;

		// Token: 0x0400097A RID: 2426
		private bool rootNameRequiresMapping;

		// Token: 0x0400097B RID: 2427
		private Type rootType;

		// Token: 0x0400097C RID: 2428
		private bool serializeReadOnlyTypes;

		// Token: 0x0400097D RID: 2429
		private DateTimeFormat dateTimeFormat;

		// Token: 0x0400097E RID: 2430
		private bool useSimpleDictionaryFormat;
	}
}
