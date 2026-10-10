using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace System.Runtime.Serialization
{
	/// <summary>Сериализует и десериализует экземпляр типа в XML-поток или документ с помощью предоставленного контракта данных. Этот класс не наследуется.</summary>
	// Token: 0x020000C6 RID: 198
	public sealed class DataContractSerializer : XmlObjectSerializer
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		// Token: 0x06000B49 RID: 2889 RVA: 0x0003031E File Offset: 0x0002E51E
		public DataContractSerializer(Type type) : this(type, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для выполнения сериализации или десериализации объекта указанного типа и инициализирует коллекцию известных типов, которые могут присутствовать в графе объекта.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся типы, которые могут присутствовать в графе объекта.</param>
		// Token: 0x06000B4A RID: 2890 RVA: 0x00030328 File Offset: 0x0002E528
		public DataContractSerializer(Type type, IEnumerable<Type> knownTypes) : this(type, knownTypes, int.MaxValue, false, false, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает список известных типов, которые могут присутствовать в графе объекта; максимальное количество сериализуемых элементов графа; параметры, указывающие, пропускать ли непредвиденные данные, использовать ли нестандартные конструкции XML для сохранения данных ссылок на объект в графе и использовать ли суррогат для пользовательской сериализации.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся известные типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="maxItemsInObjectGraph">Максимальное количество элементов в графе для сериализации или десериализации. Значением по умолчанию является значение, возвращенное свойством <see cref="F:System.Int32.MaxValue" />.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать предоставляемые расширением типа данные при сериализации и десериализации; в противном случае — значение <see langword="false" />.</param>
		/// <param name="preserveObjectReferences">Значение <see langword="true" />, если требуется использовать нестандартные конструкции XML для сохранения данных ссылок на объект; в противном случае — значение <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество элементов превышает максимальное значение.</exception>
		// Token: 0x06000B4B RID: 2891 RVA: 0x0003033A File Offset: 0x0002E53A
		public DataContractSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate) : this(type, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, preserveObjectReferences, dataContractSurrogate, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает список известных типов, которые могут присутствовать в графе объекта; максимальное количество сериализуемых элементов графа; параметры, указывающие, пропускать ли непредвиденные данные, использовать ли нестандартные конструкции XML для сохранения данных ссылок на объект в графе и использовать ли суррогат для пользовательской сериализации; а также альтернативу для сопоставления объявлений <see langword="xsi:type" /> во время выполнения.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся известные типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="maxItemsInObjectGraph">Максимальное количество элементов в графе для сериализации или десериализации. Значением по умолчанию является значение, возвращенное свойством <see cref="F:System.Int32.MaxValue" />.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать предоставляемые расширением типа данные при сериализации и десериализации; в противном случае — значение <see langword="false" />.</param>
		/// <param name="preserveObjectReferences">Значение <see langword="true" />, если требуется использовать нестандартные конструкции XML для сохранения данных ссылок на объект; в противном случае — значение <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <param name="dataContractResolver">Реализация <see cref="T:System.Runtime.Serialization.DataContractResolver" /> для сопоставления объявлений <see langword="xsi:type" /> типам контракта данных.</param>
		// Token: 0x06000B4C RID: 2892 RVA: 0x0003034C File Offset: 0x0002E54C
		public DataContractSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver)
		{
			this.Initialize(type, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, preserveObjectReferences, dataContractSurrogate, dataContractResolver, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для выполнения сериализации или десериализации объекта указанного типа с помощью предоставленных корневых элемента и пространства имен XML.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Имя XML-элемента, содержащего данные для сериализации или десериализации.</param>
		/// <param name="rootNamespace">Пространство имен XML-элемента, содержащего данные для сериализации или десериализации.</param>
		// Token: 0x06000B4D RID: 2893 RVA: 0x00030371 File Offset: 0x0002E571
		public DataContractSerializer(Type type, string rootName, string rootNamespace) : this(type, rootName, rootNamespace, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает корневые XML-элемент и пространство имен в двух строковых параметрах, а также список известных типов, которые могут присутствовать в графе объектов.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Имя корневого элемента содержимого.</param>
		/// <param name="rootNamespace">Пространство имен корневого элемента.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся типы, которые могут присутствовать в графе объекта.</param>
		// Token: 0x06000B4E RID: 2894 RVA: 0x00030380 File Offset: 0x0002E580
		public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes) : this(type, rootName, rootNamespace, knownTypes, int.MaxValue, false, false, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает список известных типов, которые могут присутствовать в графе объекта; максимальное количество сериализуемых элементов графа; параметры, указывающие, пропускать ли непредвиденные данные, использовать ли нестандартные конструкции XML для сохранения данных ссылок на объект в графе и использовать ли суррогат для пользовательской сериализации; а также XML-элемент и пространство имен, в которых находится содержимое.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">XML-элемент, содержащий данные для сериализации или десериализации.</param>
		/// <param name="rootNamespace">Пространство имен XML-элемента, содержащего данные для сериализации или десериализации.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся известные типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="maxItemsInObjectGraph">Максимальное количество элементов в графе для сериализации или десериализации.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать предоставляемые расширением типа данные при сериализации и десериализации; в противном случае — значение <see langword="false" />.</param>
		/// <param name="preserveObjectReferences">Значение <see langword="true" />, если требуется использовать нестандартные конструкции XML для сохранения данных ссылок на объект; в противном случае — значение <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество элементов превышает максимальное значение.</exception>
		// Token: 0x06000B4F RID: 2895 RVA: 0x000303A0 File Offset: 0x0002E5A0
		public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate) : this(type, rootName, rootNamespace, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, preserveObjectReferences, dataContractSurrogate, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает список известных типов, которые могут присутствовать в графе объекта; максимальное количество сериализуемых элементов графа; параметры, указывающие, пропускать ли непредвиденные данные, использовать ли нестандартные конструкции XML для сохранения данных ссылок на объект в графе и использовать ли суррогат для пользовательской сериализации; а также XML-элемент и пространство имен, в которых находится содержимое, и альтернативу для сопоставления объявлений <see langword="xsi:type" /> во время выполнения.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">XML-элемент, содержащий данные для сериализации или десериализации.</param>
		/// <param name="rootNamespace">Пространство имен XML-элемента, содержащего данные для сериализации или десериализации.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся известные типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="maxItemsInObjectGraph">Максимальное количество элементов в графе для сериализации или десериализации.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать предоставляемые расширением типа данные при сериализации и десериализации; в противном случае — значение <see langword="false" />.</param>
		/// <param name="preserveObjectReferences">Значение <see langword="true" />, если требуется использовать нестандартные конструкции XML для сохранения данных ссылок на объект; в противном случае — значение <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <param name="dataContractResolver">Реализация <see cref="T:System.Runtime.Serialization.DataContractResolver" /> для сопоставления объявлений <see langword="xsi:type" /> типам контракта данных.</param>
		// Token: 0x06000B50 RID: 2896 RVA: 0x000303C4 File Offset: 0x0002E5C4
		public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver)
		{
			XmlDictionary xmlDictionary = new XmlDictionary(2);
			this.Initialize(type, xmlDictionary.Add(rootName), xmlDictionary.Add(DataContract.GetNamespace(rootNamespace)), knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, preserveObjectReferences, dataContractSurrogate, dataContractResolver, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для выполнения сериализации или десериализации объекта указанного типа с помощью предоставленных корневых элемента и пространства имен XML, заданных посредством параметров типа <see cref="T:System.Xml.XmlDictionaryString" />.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Объект <see cref="T:System.Xml.XmlDictionaryString" />, содержащий имя корневого элемента содержимого.</param>
		/// <param name="rootNamespace">Объект <see cref="T:System.Xml.XmlDictionaryString" />, содержащий пространство имен корневого элемента.</param>
		// Token: 0x06000B51 RID: 2897 RVA: 0x00030405 File Offset: 0x0002E605
		public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace) : this(type, rootName, rootNamespace, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает корневые XML-элемент и пространство имен в двух параметрах <see cref="T:System.Xml.XmlDictionaryString" />, а также список известных типов, которые могут присутствовать в графе объекта.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Объект <see cref="T:System.Xml.XmlDictionaryString" />, содержащий имя корневого элемента содержимого.</param>
		/// <param name="rootNamespace">Объект <see cref="T:System.Xml.XmlDictionaryString" />, содержащий пространство имен корневого элемента.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся известные типы, которые могут присутствовать в графе объекта.</param>
		// Token: 0x06000B52 RID: 2898 RVA: 0x00030414 File Offset: 0x0002E614
		public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes) : this(type, rootName, rootNamespace, knownTypes, int.MaxValue, false, false, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает список известных типов, которые могут присутствовать в графе объекта; максимальное количество сериализуемых элементов графа; параметры, указывающие, пропускать ли непредвиденные данные, использовать ли нестандартные конструкции XML для сохранения данных ссылок на объект в графе и использовать ли суррогат для пользовательской сериализации; а также параметры <see cref="T:System.Xml.XmlDictionaryString" />, задающие XML-элемент и пространство имен, в которых находится содержимое.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">Объект <see cref="T:System.Xml.XmlDictionaryString" />, указывающий XML-элемент, содержащий данные для сериализации или десериализации.</param>
		/// <param name="rootNamespace">Объект <see cref="T:System.Xml.XmlDictionaryString" />, задающий пространство имен XML корня.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся известные типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="maxItemsInObjectGraph">Максимальное количество элементов в графе для сериализации или десериализации.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать предоставляемые расширением типа данные при сериализации и десериализации; в противном случае — значение <see langword="false" />.</param>
		/// <param name="preserveObjectReferences">Значение <see langword="true" />, если требуется использовать нестандартные конструкции XML для сохранения данных ссылок на объект; в противном случае — значение <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество элементов превышает максимальное значение.</exception>
		// Token: 0x06000B53 RID: 2899 RVA: 0x00030438 File Offset: 0x0002E638
		public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate) : this(type, rootName, rootNamespace, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, preserveObjectReferences, dataContractSurrogate, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа. Этот метод также задает список известных типов, которые могут присутствовать в графе объекта; максимальное количество сериализуемых элементов графа; параметры, указывающие, пропускать ли непредвиденные данные, использовать ли нестандартные конструкции XML для сохранения данных ссылок на объект в графе и использовать ли суррогат для пользовательской сериализации; параметры <see cref="T:System.Xml.XmlDictionaryString" />, задающие XML-элемент и пространство имен, в которых находится содержимое, и альтернативу для сопоставления объявлений <see langword="xsi:type" /> во время выполнения.</summary>
		/// <param name="type">Тип сериализуемых или десериализуемых экземпляров.</param>
		/// <param name="rootName">XML-элемент, содержащий данные для сериализации или десериализации.</param>
		/// <param name="rootNamespace">Пространство имен XML-элемента, содержащего данные для сериализации или десериализации.</param>
		/// <param name="knownTypes">Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, принадлежащий к типу <see cref="T:System.Type" />, в котором содержатся известные типы, которые могут присутствовать в графе объекта.</param>
		/// <param name="maxItemsInObjectGraph">Максимальное количество элементов в графе для сериализации или десериализации.</param>
		/// <param name="ignoreExtensionDataObject">Значение <see langword="true" />, если требуется игнорировать предоставляемые расширением типа данные при сериализации и десериализации; в противном случае — значение <see langword="false" />.</param>
		/// <param name="preserveObjectReferences">Значение <see langword="true" />, если требуется использовать нестандартные конструкции XML для сохранения данных ссылок на объект; в противном случае — значение <see langword="false" />.</param>
		/// <param name="dataContractSurrogate">Реализация объекта <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" /> для настройки процесса сериализации.</param>
		/// <param name="dataContractResolver">Реализация <see cref="T:System.Runtime.Serialization.DataContractResolver" /> для сопоставления объявлений <see langword="xsi:type" /> типам контракта данных.</param>
		// Token: 0x06000B54 RID: 2900 RVA: 0x0003045C File Offset: 0x0002E65C
		public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver)
		{
			this.Initialize(type, rootName, rootNamespace, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, preserveObjectReferences, dataContractSurrogate, dataContractResolver, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> для сериализации или десериализации объекта указанного типа и параметров.</summary>
		/// <param name="type">Тип сериализуемого или десериализуемого экземпляра.</param>
		/// <param name="settings">Параметры сериализатора.</param>
		// Token: 0x06000B55 RID: 2901 RVA: 0x00030488 File Offset: 0x0002E688
		public DataContractSerializer(Type type, DataContractSerializerSettings settings)
		{
			if (settings == null)
			{
				settings = new DataContractSerializerSettings();
			}
			this.Initialize(type, settings.RootName, settings.RootNamespace, settings.KnownTypes, settings.MaxItemsInObjectGraph, settings.IgnoreExtensionDataObject, settings.PreserveObjectReferences, settings.DataContractSurrogate, settings.DataContractResolver, settings.SerializeReadOnlyTypes);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000304E4 File Offset: 0x0002E6E4
		private void Initialize(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver, bool serializeReadOnlyTypes)
		{
			XmlObjectSerializer.CheckNull(type, "type");
			this.rootType = type;
			if (knownTypes != null)
			{
				this.knownTypeList = new List<Type>();
				foreach (Type item in knownTypes)
				{
					this.knownTypeList.Add(item);
				}
			}
			if (maxItemsInObjectGraph < 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("maxItemsInObjectGraph", SR.GetString("The value of this argument must be non-negative.")));
			}
			this.maxItemsInObjectGraph = maxItemsInObjectGraph;
			this.ignoreExtensionDataObject = ignoreExtensionDataObject;
			this.preserveObjectReferences = preserveObjectReferences;
			this.dataContractSurrogate = dataContractSurrogate;
			this.dataContractResolver = dataContractResolver;
			this.serializeReadOnlyTypes = serializeReadOnlyTypes;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000305A0 File Offset: 0x0002E7A0
		private void Initialize(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver, bool serializeReadOnlyTypes)
		{
			this.Initialize(type, knownTypes, maxItemsInObjectGraph, ignoreExtensionDataObject, preserveObjectReferences, dataContractSurrogate, dataContractResolver, serializeReadOnlyTypes);
			this.rootName = rootName;
			this.rootNamespace = rootNamespace;
		}

		/// <summary>Возвращает коллекцию типов, которые могут присутствовать в графе объекта, сериализованном с помощью этого экземпляра класса <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, содержащая ожидаемые типы, переданные в качестве известных типов в конструктор <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</returns>
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x000305D0 File Offset: 0x0002E7D0
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0003060B File Offset: 0x0002E80B
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

		/// <summary>Возвращает максимальное количество элементов в графе объекта для сериализации или десериализации.</summary>
		/// <returns>Максимальное количество элементов для сериализации или десериализации. Значение по умолчанию — <see cref="F:System.Int32.MaxValue" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество элементов превышает максимальное значение.</exception>
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00030634 File Offset: 0x0002E834
		public int MaxItemsInObjectGraph
		{
			get
			{
				return this.maxItemsInObjectGraph;
			}
		}

		/// <summary>Возвращает тип суррогата, который может расширить процесс сериализации или десериализации.</summary>
		/// <returns>Реализация класса <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" />.</returns>
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0003063C File Offset: 0x0002E83C
		public IDataContractSurrogate DataContractSurrogate
		{
			get
			{
				return this.dataContractSurrogate;
			}
		}

		/// <summary>Возвращает значение, указывающее, следует ли использовать нестандартные конструкции XML для сохранения данных ссылок на объект.</summary>
		/// <returns>Значение <see langword="true" />, если требуется сохранить ссылки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00030644 File Offset: 0x0002E844
		public bool PreserveObjectReferences
		{
			get
			{
				return this.preserveObjectReferences;
			}
		}

		/// <summary>Возвращает значение, указывающее, должны ли игнорироваться данные, предоставляемые расширением класса, при сериализации или десериализации класса.</summary>
		/// <returns>Значение <see langword="true" />, если данные расширения опускаются; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0003064C File Offset: 0x0002E84C
		public bool IgnoreExtensionDataObject
		{
			get
			{
				return this.ignoreExtensionDataObject;
			}
		}

		/// <summary>Получает компонент, используемый для динамического сопоставления объявлений <see langword="xsi:type" /> с типами известных контрактов.</summary>
		/// <returns>Реализация класса <see cref="T:System.Runtime.Serialization.DataContractResolver" />.</returns>
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00030654 File Offset: 0x0002E854
		public DataContractResolver DataContractResolver
		{
			get
			{
				return this.dataContractResolver;
			}
		}

		/// <summary>Получает значение, указывающее, сериализованы ли типы, доступные только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если сериализуются типы только для чтения; значение <see langword="false" />, если сериализуются все типы.</returns>
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0003065C File Offset: 0x0002E85C
		public bool SerializeReadOnlyTypes
		{
			get
			{
				return this.serializeReadOnlyTypes;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00030664 File Offset: 0x0002E864
		private DataContract RootContract
		{
			get
			{
				if (this.rootContract == null)
				{
					this.rootContract = DataContract.GetDataContract((this.dataContractSurrogate == null) ? this.rootType : DataContractSerializer.GetSurrogatedType(this.dataContractSurrogate, this.rootType));
					this.needsContractNsAtRoot = base.CheckIfNeedsContractNsAtRoot(this.rootName, this.rootNamespace, this.rootContract);
				}
				return this.rootContract;
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000306C9 File Offset: 0x0002E8C9
		internal override void InternalWriteObject(XmlWriterDelegator writer, object graph)
		{
			this.InternalWriteObject(writer, graph, null);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000306D4 File Offset: 0x0002E8D4
		internal override void InternalWriteObject(XmlWriterDelegator writer, object graph, DataContractResolver dataContractResolver)
		{
			this.InternalWriteStartObject(writer, graph);
			this.InternalWriteObjectContent(writer, graph, dataContractResolver);
			this.InternalWriteEndObject(writer);
		}

		/// <summary>Записывает все данные объекта (начальный XML-элемент, содержимое и закрывающий элемент) в XML-документ или поток с помощью средства записи <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, используемый для записи XML-документа или потока.</param>
		/// <param name="graph">Объект, содержащий данные для записи в поток.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		// Token: 0x06000B63 RID: 2915 RVA: 0x000306EE File Offset: 0x0002E8EE
		public override void WriteObject(XmlWriter writer, object graph)
		{
			base.WriteObjectHandleExceptions(new XmlWriterDelegator(writer), graph);
		}

		/// <summary>Выполняет запись открывающего XML-элемента с помощью модуля записи <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, используемый для записи начального элемента XML.</param>
		/// <param name="graph">Записываемый объект.</param>
		// Token: 0x06000B64 RID: 2916 RVA: 0x000306FD File Offset: 0x0002E8FD
		public override void WriteStartObject(XmlWriter writer, object graph)
		{
			base.WriteStartObjectHandleExceptions(new XmlWriterDelegator(writer), graph);
		}

		/// <summary>Выполняет запись содержимого XML с помощью средства записи <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, используемый для записи потока.</param>
		/// <param name="graph">Объект, записываемый в поток.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		// Token: 0x06000B65 RID: 2917 RVA: 0x0003070C File Offset: 0x0002E90C
		public override void WriteObjectContent(XmlWriter writer, object graph)
		{
			base.WriteObjectContentHandleExceptions(new XmlWriterDelegator(writer), graph);
		}

		/// <summary>Выполняет запись закрывающего XML-элемента с помощью средства записи <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, используемый для записи потока.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		// Token: 0x06000B66 RID: 2918 RVA: 0x0003071B File Offset: 0x0002E91B
		public override void WriteEndObject(XmlWriter writer)
		{
			base.WriteEndObjectHandleExceptions(new XmlWriterDelegator(writer));
		}

		/// <summary>Выполняет запись открывающего XML-элемента с помощью модуля записи <see cref="T:System.Xml.XmlDictionaryWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, используемый для записи начального элемента XML.</param>
		/// <param name="graph">Записываемый объект.</param>
		// Token: 0x06000B67 RID: 2919 RVA: 0x000306FD File Offset: 0x0002E8FD
		public override void WriteStartObject(XmlDictionaryWriter writer, object graph)
		{
			base.WriteStartObjectHandleExceptions(new XmlWriterDelegator(writer), graph);
		}

		/// <summary>Выполняет запись содержимого XML с помощью средства записи <see cref="T:System.Xml.XmlDictionaryWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, используемый для записи потока.</param>
		/// <param name="graph">Объект, записываемый в поток.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		// Token: 0x06000B68 RID: 2920 RVA: 0x0003070C File Offset: 0x0002E90C
		public override void WriteObjectContent(XmlDictionaryWriter writer, object graph)
		{
			base.WriteObjectContentHandleExceptions(new XmlWriterDelegator(writer), graph);
		}

		/// <summary>Выполняет запись закрывающего XML-элемента с помощью средства записи <see cref="T:System.Xml.XmlDictionaryWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlDictionaryWriter" />, используемый для записи потока.</param>
		/// <exception cref="T:System.Runtime.Serialization.InvalidDataContractException">Сериализуемый тип не соответствует правилам контракта данных. Например, к этому типу не применен атрибут <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Возникла проблема с записываемым экземпляром.</exception>
		// Token: 0x06000B69 RID: 2921 RVA: 0x0003071B File Offset: 0x0002E91B
		public override void WriteEndObject(XmlDictionaryWriter writer)
		{
			base.WriteEndObjectHandleExceptions(new XmlWriterDelegator(writer));
		}

		/// <summary>Записывает все данные объекта (начальный XML-элемент, содержимое и включающий элемент) в XML-документ или поток с помощью указанного модуля записи XmlDictionaryWriter. Метод включает сопоставитель для сопоставления объявлений <see langword="xsi:type" /> во время выполнения.</summary>
		/// <param name="writer">Модуль записи XmlDictionaryWriter, используемый для записи содержимого в XML-документ или XML-поток.</param>
		/// <param name="graph">Объект, в котором находится содержимое для записи.</param>
		/// <param name="dataContractResolver">Реализация <see cref="T:System.Runtime.Serialization.DataContractResolver" />, используемая для сопоставления объявлений <see langword="xsi:type" /> с известными контрактами данных.</param>
		// Token: 0x06000B6A RID: 2922 RVA: 0x00030729 File Offset: 0x0002E929
		public void WriteObject(XmlDictionaryWriter writer, object graph, DataContractResolver dataContractResolver)
		{
			base.WriteObjectHandleExceptions(new XmlWriterDelegator(writer), graph, dataContractResolver);
		}

		/// <summary>Считывает XML-поток с помощью средства чтения <see cref="T:System.Xml.XmlReader" /> и возвращает десериализованный объект.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />, используемый для чтения XML-потока.</param>
		/// <returns>Десериализованный объект.</returns>
		// Token: 0x06000B6B RID: 2923 RVA: 0x00030739 File Offset: 0x0002E939
		public override object ReadObject(XmlReader reader)
		{
			return base.ReadObjectHandleExceptions(new XmlReaderDelegator(reader), true);
		}

		/// <summary>Считывает XML-поток с помощью средства чтения <see cref="T:System.Xml.XmlReader" /> и возвращает десериализованный объект; также указывает, была ли выполнена проверка имени объекта перед чтением его значения.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />, используемый для чтения XML-потока.</param>
		/// <param name="verifyObjectName">Значение <see langword="true" />, если требуется проверить соответствие имени объекта предоставленному в конструкторе значению корневого имени; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Десериализованный объект.</returns>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Параметру <paramref name="verifyObjectName" /> задано значение <see langword="true" /> и имя и пространство имен элемента не соответствуют значениям, заданным в конструкторе.</exception>
		// Token: 0x06000B6C RID: 2924 RVA: 0x00030748 File Offset: 0x0002E948
		public override object ReadObject(XmlReader reader, bool verifyObjectName)
		{
			return base.ReadObjectHandleExceptions(new XmlReaderDelegator(reader), verifyObjectName);
		}

		/// <summary>Определяет, расположен ли объект <see cref="T:System.Xml.XmlReader" /> на объекте, который может быть десериализован.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />, используемый для чтения XML-потока.</param>
		/// <returns>Значение <see langword="true" />, если модуль чтения установлен на начальном элементе считываемого потока; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000B6D RID: 2925 RVA: 0x00030757 File Offset: 0x0002E957
		public override bool IsStartObject(XmlReader reader)
		{
			return base.IsStartObjectHandleExceptions(new XmlReaderDelegator(reader));
		}

		/// <summary>Считывает XML-поток с помощью средства чтения <see cref="T:System.Xml.XmlDictionaryReader" /> и возвращает десериализованный объект; также указывает, была ли выполнена проверка имени объекта перед чтением его значения.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlDictionaryReader" />, используемый для чтения XML-потока.</param>
		/// <param name="verifyObjectName">Значение <see langword="true" />, если требуется проверить соответствие имени объекта предоставленному в конструкторе значению корневого имени; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Десериализованный объект.</returns>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Параметру <paramref name="verifyObjectName" /> задано значение <see langword="true" /> и имя и пространство имен элемента не соответствуют значениям, заданным в конструкторе.</exception>
		// Token: 0x06000B6E RID: 2926 RVA: 0x00030748 File Offset: 0x0002E948
		public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName)
		{
			return base.ReadObjectHandleExceptions(new XmlReaderDelegator(reader), verifyObjectName);
		}

		/// <summary>Определяет, расположен ли объект <see cref="T:System.Xml.XmlDictionaryReader" /> на объекте, который может быть десериализован.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlDictionaryReader" />, используемый для чтения XML-потока.</param>
		/// <returns>Значение <see langword="true" />, если модуль чтения установлен на начальном элементе считываемого потока; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000B6F RID: 2927 RVA: 0x00030757 File Offset: 0x0002E957
		public override bool IsStartObject(XmlDictionaryReader reader)
		{
			return base.IsStartObjectHandleExceptions(new XmlReaderDelegator(reader));
		}

		/// <summary>Считывает XML-документ или поток XML-документов и возвращает десериализованный объект.  Метод включает параметр, определяющий, проверяется ли имя объекта, и сопоставитель для сопоставления объявлений <see langword="xsi:type" /> во время выполнения.</summary>
		/// <param name="reader">Модуль чтения XML, используемый для чтения содержимого.</param>
		/// <param name="verifyObjectName">Значение <see langword="true" />, если нужно проверять имя объекта; в противном случае — значение <see langword="false" />.</param>
		/// <param name="dataContractResolver">Реализация <see cref="T:System.Runtime.Serialization.DataContractResolver" /> для сопоставления объявлений <see langword="xsi:type" /> типам контракта данных.</param>
		/// <returns>Десериализованный объект.</returns>
		// Token: 0x06000B70 RID: 2928 RVA: 0x00030765 File Offset: 0x0002E965
		public object ReadObject(XmlDictionaryReader reader, bool verifyObjectName, DataContractResolver dataContractResolver)
		{
			return base.ReadObjectHandleExceptions(new XmlReaderDelegator(reader), verifyObjectName, dataContractResolver);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00030775 File Offset: 0x0002E975
		internal override void InternalWriteStartObject(XmlWriterDelegator writer, object graph)
		{
			base.WriteRootElement(writer, this.RootContract, this.rootName, this.rootNamespace, this.needsContractNsAtRoot);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00030796 File Offset: 0x0002E996
		internal override void InternalWriteObjectContent(XmlWriterDelegator writer, object graph)
		{
			this.InternalWriteObjectContent(writer, graph, null);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000307A4 File Offset: 0x0002E9A4
		internal void InternalWriteObjectContent(XmlWriterDelegator writer, object graph, DataContractResolver dataContractResolver)
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
			if (dataContractResolver == null)
			{
				dataContractResolver = this.DataContractResolver;
			}
			if (graph == null)
			{
				if (base.IsRootXmlAny(this.rootName, dataContract))
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("A null value cannot be serialized at the top level for IXmlSerializable root type '{0}' since its IsAny setting is 'true'. This type must write all its contents including the root element. Verify that the IXmlSerializable implementation is correct.", new object[]
					{
						underlyingType
					})));
				}
				XmlObjectSerializer.WriteNull(writer);
				return;
			}
			else if (underlyingType == type)
			{
				if (dataContract.CanContainReferences)
				{
					XmlObjectSerializerWriteContext xmlObjectSerializerWriteContext = XmlObjectSerializerWriteContext.CreateContext(this, dataContract, dataContractResolver);
					xmlObjectSerializerWriteContext.HandleGraphAtTopLevel(writer, graph, dataContract);
					xmlObjectSerializerWriteContext.SerializeWithoutXsiType(dataContract, writer, graph, underlyingType.TypeHandle);
					return;
				}
				dataContract.WriteXmlValue(writer, graph, null);
				return;
			}
			else
			{
				if (base.IsRootXmlAny(this.rootName, dataContract))
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("An object of type '{0}' cannot be serialized at the top level for IXmlSerializable root type '{1}' since its IsAny setting is 'true'. This type must write all its contents including the root element. Verify that the IXmlSerializable implementation is correct.", new object[]
					{
						type,
						dataContract.UnderlyingType
					})));
				}
				dataContract = DataContractSerializer.GetDataContract(dataContract, underlyingType, type);
				XmlObjectSerializerWriteContext xmlObjectSerializerWriteContext2 = XmlObjectSerializerWriteContext.CreateContext(this, this.RootContract, dataContractResolver);
				if (dataContract.CanContainReferences)
				{
					xmlObjectSerializerWriteContext2.HandleGraphAtTopLevel(writer, graph, dataContract);
				}
				xmlObjectSerializerWriteContext2.OnHandleIsReference(writer, dataContract, graph);
				xmlObjectSerializerWriteContext2.SerializeWithXsiTypeAtTopLevel(dataContract, writer, graph, underlyingType.TypeHandle, type);
				return;
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0003090F File Offset: 0x0002EB0F
		internal static DataContract GetDataContract(DataContract declaredTypeContract, Type declaredType, Type objectType)
		{
			if (declaredType.IsInterface && CollectionDataContract.IsCollectionInterface(declaredType))
			{
				return declaredTypeContract;
			}
			if (declaredType.IsArray)
			{
				return declaredTypeContract;
			}
			return DataContract.GetDataContract(objectType.TypeHandle, objectType, SerializationMode.SharedContract);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0003093A File Offset: 0x0002EB3A
		internal void SetDataContractSurrogate(IDataContractSurrogate adapter)
		{
			this.dataContractSurrogate = adapter;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00030943 File Offset: 0x0002EB43
		internal override void InternalWriteEndObject(XmlWriterDelegator writer)
		{
			if (!base.IsRootXmlAny(this.rootName, this.RootContract))
			{
				writer.WriteEndElement();
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0003095F File Offset: 0x0002EB5F
		internal override object InternalReadObject(XmlReaderDelegator xmlReader, bool verifyObjectName)
		{
			return this.InternalReadObject(xmlReader, verifyObjectName, null);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0003096C File Offset: 0x0002EB6C
		internal override object InternalReadObject(XmlReaderDelegator xmlReader, bool verifyObjectName, DataContractResolver dataContractResolver)
		{
			if (this.MaxItemsInObjectGraph == 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("Maximum number of items that can be serialized or deserialized in an object graph is '{0}'.", new object[]
				{
					this.MaxItemsInObjectGraph
				})));
			}
			if (dataContractResolver == null)
			{
				dataContractResolver = this.DataContractResolver;
			}
			if (verifyObjectName)
			{
				if (!this.InternalIsStartObject(xmlReader))
				{
					XmlDictionaryString topLevelElementName;
					XmlDictionaryString topLevelElementNamespace;
					if (this.rootName == null)
					{
						topLevelElementName = this.RootContract.TopLevelElementName;
						topLevelElementNamespace = this.RootContract.TopLevelElementNamespace;
					}
					else
					{
						topLevelElementName = this.rootName;
						topLevelElementNamespace = this.rootNamespace;
					}
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationExceptionWithReaderDetails(SR.GetString("Expecting element '{1}' from namespace '{0}'.", new object[]
					{
						topLevelElementNamespace,
						topLevelElementName
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
				return dataContract.ReadXmlValue(xmlReader, null);
			}
			if (base.IsRootXmlAny(this.rootName, dataContract))
			{
				return XmlObjectSerializerReadContext.ReadRootIXmlSerializable(xmlReader, dataContract as XmlDataContract, false);
			}
			return XmlObjectSerializerReadContext.CreateContext(this, dataContract, dataContractResolver).InternalDeserialize(xmlReader, this.rootType, dataContract, null, null);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00030AA0 File Offset: 0x0002ECA0
		internal override bool InternalIsStartObject(XmlReaderDelegator reader)
		{
			return base.IsRootElement(reader, this.RootContract, this.rootName, this.rootNamespace);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00030ABB File Offset: 0x0002ECBB
		internal override Type GetSerializeType(object graph)
		{
			if (graph != null)
			{
				return graph.GetType();
			}
			return this.rootType;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00030ACD File Offset: 0x0002ECCD
		internal override Type GetDeserializeType()
		{
			return this.rootType;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		internal static object SurrogateToDataContractType(IDataContractSurrogate dataContractSurrogate, object oldObj, Type surrogatedDeclaredType, ref Type objType)
		{
			object objectToSerialize = DataContractSurrogateCaller.GetObjectToSerialize(dataContractSurrogate, oldObj, objType, surrogatedDeclaredType);
			if (objectToSerialize != oldObj)
			{
				if (objectToSerialize == null)
				{
					objType = Globals.TypeOfObject;
				}
				else
				{
					objType = objectToSerialize.GetType();
				}
			}
			return objectToSerialize;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00030B09 File Offset: 0x0002ED09
		internal static Type GetSurrogatedType(IDataContractSurrogate dataContractSurrogate, Type type)
		{
			return DataContractSurrogateCaller.GetDataContractType(dataContractSurrogate, DataContract.UnwrapNullableType(type));
		}

		// Token: 0x04000495 RID: 1173
		private Type rootType;

		// Token: 0x04000496 RID: 1174
		private DataContract rootContract;

		// Token: 0x04000497 RID: 1175
		private bool needsContractNsAtRoot;

		// Token: 0x04000498 RID: 1176
		private XmlDictionaryString rootName;

		// Token: 0x04000499 RID: 1177
		private XmlDictionaryString rootNamespace;

		// Token: 0x0400049A RID: 1178
		private int maxItemsInObjectGraph;

		// Token: 0x0400049B RID: 1179
		private bool ignoreExtensionDataObject;

		// Token: 0x0400049C RID: 1180
		private bool preserveObjectReferences;

		// Token: 0x0400049D RID: 1181
		private IDataContractSurrogate dataContractSurrogate;

		// Token: 0x0400049E RID: 1182
		private ReadOnlyCollection<Type> knownTypeCollection;

		// Token: 0x0400049F RID: 1183
		internal IList<Type> knownTypeList;

		// Token: 0x040004A0 RID: 1184
		internal Dictionary<XmlQualifiedName, DataContract> knownDataContracts;

		// Token: 0x040004A1 RID: 1185
		private DataContractResolver dataContractResolver;

		// Token: 0x040004A2 RID: 1186
		private bool serializeReadOnlyTypes;
	}
}
