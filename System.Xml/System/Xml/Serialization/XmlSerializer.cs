using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Сериализует и десериализует объекты в XML-документы и из них.
	///         <see cref="T:System.Xml.Serialization.XmlSerializer" /> Позволяет управлять процессом кодировки объектов в XML.
	///       </summary>
	// Token: 0x02000302 RID: 770
	public class XmlSerializer
	{
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x000CF4B0 File Offset: 0x000CD6B0
		private static XmlSerializerNamespaces DefaultNamespaces
		{
			get
			{
				if (XmlSerializer.defaultNamespaces == null)
				{
					XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
					xmlSerializerNamespaces.AddInternal("xsi", "http://www.w3.org/2001/XMLSchema-instance");
					xmlSerializerNamespaces.AddInternal("xsd", "http://www.w3.org/2001/XMLSchema");
					if (XmlSerializer.defaultNamespaces == null)
					{
						XmlSerializer.defaultNamespaces = xmlSerializerNamespaces;
					}
				}
				return XmlSerializer.defaultNamespaces;
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </summary>
		// Token: 0x06001FEB RID: 8171 RVA: 0x0000216B File Offset: 0x0000036B
		protected XmlSerializer()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс, который может сериализовать объекты типа <see cref="T:System.Object" /> в XML документов экземпляров и десериализовать экземпляры документов XML в объекты типа <see cref="T:System.Object" />.
		///          Каждый сериализуемый объект может сам содержать экземпляры классов, которые данная перегрузка переопределяет с другими классами.
		///          Данная перегрузка также указывает пространство имен по умолчанию для всех элементов XML и класс для использования в качестве корневого элемента XML.
		///       </summary>
		/// <param name="type">
		///           Тип объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		/// <param name="overrides">
		///           <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> Расширяющий или переопределяющий класс, указанный в <paramref name="type" /> параметр.
		///         </param>
		/// <param name="extraTypes">
		///           A <see cref="T:System.Type" /> массив дополнительные типы объектов для сериализации.
		///         </param>
		/// <param name="root">
		///           <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> Определяющий свойства корневого элемента XML.
		///         </param>
		/// <param name="defaultNamespace">
		///           Пространство имен по умолчанию всех элементов XML в XML-документе.
		///         </param>
		// Token: 0x06001FEC RID: 8172 RVA: 0x000CF504 File Offset: 0x000CD704
		public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) : this(type, overrides, extraTypes, root, defaultNamespace, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс, который может сериализовать объекты заданного типа в документы XML и десериализации документа XML в объект заданного типа.
		///          Он также указывает класс для использования в качестве корневого элемента XML.
		///       </summary>
		/// <param name="type">
		///           Тип объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		/// <param name="root">
		///           <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> Представляющий корневой элемент XML.
		///         </param>
		// Token: 0x06001FED RID: 8173 RVA: 0x000CF514 File Offset: 0x000CD714
		public XmlSerializer(Type type, XmlRootAttribute root) : this(type, null, new Type[0], root, null, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> документов класс, который может сериализовать объекты заданного типа в XML-документов, а также десериализовать XML в объект заданного типа.
		///          Если свойство или поле возвращает массив, <paramref name="extraTypes" /> определяет объекты, которые могут быть вставлены в массив.
		///       </summary>
		/// <param name="type">
		///           Тип объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		/// <param name="extraTypes">
		///           A <see cref="T:System.Type" /> массив дополнительные типы объектов для сериализации.
		///         </param>
		// Token: 0x06001FEE RID: 8174 RVA: 0x000CF527 File Offset: 0x000CD727
		public XmlSerializer(Type type, Type[] extraTypes) : this(type, null, extraTypes, null, null, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> документов класс, который может сериализовать объекты заданного типа в XML-документов, а также десериализовать XML в объекты заданного типа.
		///          Каждый сериализуемый объект может сам содержать экземпляры классов, которые данная перегрузка позволяет переопределить с другими классами.
		///       </summary>
		/// <param name="type">
		///           Тип объекта для сериализации.
		///         </param>
		/// <param name="overrides">
		///           Объект <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" />.
		///         </param>
		// Token: 0x06001FEF RID: 8175 RVA: 0x000CF535 File Offset: 0x000CD735
		public XmlSerializer(Type type, XmlAttributeOverrides overrides) : this(type, overrides, new Type[0], null, null, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlSerializer" /> с использованием объекта, сопоставляющего одного типа в другой.
		///       </summary>
		/// <param name="xmlTypeMapping">
		///           <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> Сопоставляет один тип в другой.
		///         </param>
		// Token: 0x06001FF0 RID: 8176 RVA: 0x000CF548 File Offset: 0x000CD748
		public XmlSerializer(XmlTypeMapping xmlTypeMapping)
		{
			this.tempAssembly = XmlSerializer.GenerateTempAssembly(xmlTypeMapping);
			this.mapping = xmlTypeMapping;
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> документов класс, который может сериализовать объекты заданного типа в XML-документов, а также десериализовать XML в объекты заданного типа.
		///       </summary>
		/// <param name="type">
		///           Тип объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		// Token: 0x06001FF1 RID: 8177 RVA: 0x000CF563 File Offset: 0x000CD763
		public XmlSerializer(Type type) : this(type, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> документов класс, который может сериализовать объекты заданного типа в XML-документов, а также десериализовать XML в объекты заданного типа.
		///          Задает пространство имен по умолчанию для всех элементов XML.
		///       </summary>
		/// <param name="type">
		///           Тип объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		/// <param name="defaultNamespace">
		///           Пространство имен по умолчанию для всех элементов XML.
		///         </param>
		// Token: 0x06001FF2 RID: 8178 RVA: 0x000CF570 File Offset: 0x000CD770
		public XmlSerializer(Type type, string defaultNamespace)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.mapping = XmlSerializer.GetKnownMapping(type, defaultNamespace);
			if (this.mapping != null)
			{
				this.primitiveType = type;
				return;
			}
			this.tempAssembly = XmlSerializer.cache[defaultNamespace, type];
			if (this.tempAssembly == null)
			{
				TempAssemblyCache obj = XmlSerializer.cache;
				lock (obj)
				{
					this.tempAssembly = XmlSerializer.cache[defaultNamespace, type];
					if (this.tempAssembly == null)
					{
						XmlSerializerImplementation contract;
						Assembly assembly = TempAssembly.LoadGeneratedAssembly(type, defaultNamespace, out contract);
						if (assembly == null)
						{
							XmlReflectionImporter xmlReflectionImporter = new XmlReflectionImporter(defaultNamespace);
							this.mapping = xmlReflectionImporter.ImportTypeMapping(type, null, defaultNamespace);
							this.tempAssembly = XmlSerializer.GenerateTempAssembly(this.mapping, type, defaultNamespace);
						}
						else
						{
							this.mapping = XmlReflectionImporter.GetTopLevelMapping(type, defaultNamespace);
							this.tempAssembly = new TempAssembly(new XmlMapping[]
							{
								this.mapping
							}, assembly, contract);
						}
					}
					XmlSerializer.cache.Add(defaultNamespace, type, this.tempAssembly);
				}
			}
			if (this.mapping == null)
			{
				this.mapping = XmlReflectionImporter.GetTopLevelMapping(type, defaultNamespace);
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс, который может сериализовать объекты типа <see cref="T:System.Object" /> в XML документов экземпляров и десериализовать экземпляры документов XML в объекты типа <see cref="T:System.Object" />.
		///          Каждый сериализуемый объект может сам содержать экземпляры классов, которые данная перегрузка переопределяет с другими классами.
		///          Данная перегрузка также указывает пространство имен по умолчанию для всех элементов XML и класс для использования в качестве корневого элемента XML.
		///       </summary>
		/// <param name="type">
		///           Тип объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		/// <param name="overrides">
		///           <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> Расширяющий или переопределяющий класс, указанный в <paramref name="type" /> параметр.
		///         </param>
		/// <param name="extraTypes">
		///           A <see cref="T:System.Type" /> массив дополнительные типы объектов для сериализации.
		///         </param>
		/// <param name="root">
		///           <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> Определяющий свойства корневого элемента XML.
		///         </param>
		/// <param name="defaultNamespace">
		///           Пространство имен по умолчанию всех элементов XML в XML-документе.
		///         </param>
		/// <param name="location">
		///           Размещение типов.
		///         </param>
		// Token: 0x06001FF3 RID: 8179 RVA: 0x000CF6A8 File Offset: 0x000CD8A8
		public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location) : this(type, overrides, extraTypes, root, defaultNamespace, location, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс, который может сериализовать объекты заданного типа в XML-документы и десериализовать экземпляры документов XML в объекты заданного типа.
		///          Эта перегрузка позволяет предоставить другие типы, которые могут быть обнаружены во время операции сериализации или десериализации, а также пространство имен по умолчанию для всех элементов XML, класс для использования в качестве корневого элемента XML, его расположение и учетные данные, необходимые для доступа.
		///       </summary>
		/// <param name="type">
		///           Тип объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		/// <param name="overrides">
		///           <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> Расширяющий или переопределяющий класс, указанный в <paramref name="type" /> параметр.
		///         </param>
		/// <param name="extraTypes">
		///           A <see cref="T:System.Type" /> массив дополнительные типы объектов для сериализации.
		///         </param>
		/// <param name="root">
		///           <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> Определяющий свойства корневого элемента XML.
		///         </param>
		/// <param name="defaultNamespace">
		///           Пространство имен по умолчанию всех элементов XML в XML-документе.
		///         </param>
		/// <param name="location">
		///           Размещение типов.
		///         </param>
		/// <param name="evidence">
		///           Экземпляр <see cref="T:System.Security.Policy.Evidence" /> класс, который содержит учетные данные, необходимые для доступа к типам.
		///         </param>
		// Token: 0x06001FF4 RID: 8180 RVA: 0x000CF6BC File Offset: 0x000CD8BC
		[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use a XmlSerializer constructor overload which does not take an Evidence parameter. See http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
		public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location, Evidence evidence)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			XmlReflectionImporter xmlReflectionImporter = new XmlReflectionImporter(overrides, defaultNamespace);
			if (extraTypes != null)
			{
				for (int i = 0; i < extraTypes.Length; i++)
				{
					xmlReflectionImporter.IncludeType(extraTypes[i]);
				}
			}
			this.mapping = xmlReflectionImporter.ImportTypeMapping(type, root, defaultNamespace);
			if (location != null || evidence != null)
			{
				this.DemandForUserLocationOrEvidence();
			}
			this.tempAssembly = XmlSerializer.GenerateTempAssembly(this.mapping, type, defaultNamespace, location, evidence);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0000B528 File Offset: 0x00009728
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		private void DemandForUserLocationOrEvidence()
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000CF73D File Offset: 0x000CD93D
		internal static TempAssembly GenerateTempAssembly(XmlMapping xmlMapping)
		{
			return XmlSerializer.GenerateTempAssembly(xmlMapping, null, null);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000CF747 File Offset: 0x000CD947
		internal static TempAssembly GenerateTempAssembly(XmlMapping xmlMapping, Type type, string defaultNamespace)
		{
			if (xmlMapping == null)
			{
				throw new ArgumentNullException("xmlMapping");
			}
			return new TempAssembly(new XmlMapping[]
			{
				xmlMapping
			}, new Type[]
			{
				type
			}, defaultNamespace, null, null);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000CF773 File Offset: 0x000CD973
		internal static TempAssembly GenerateTempAssembly(XmlMapping xmlMapping, Type type, string defaultNamespace, string location, Evidence evidence)
		{
			return new TempAssembly(new XmlMapping[]
			{
				xmlMapping
			}, new Type[]
			{
				type
			}, defaultNamespace, location, evidence);
		}

		/// <summary>
		///         Выполняет сериализацию заданного <see cref="T:System.Object" /> и записывает XML-документ в файл, используя заданный <see cref="T:System.IO.TextWriter" />.
		///       </summary>
		/// <param name="textWriter">
		///           <see cref="T:System.IO.TextWriter" /> Используется для записи XML-документа.
		///         </param>
		/// <param name="o">
		///           Экземпляр <see cref="T:System.Object" /> для сериализации.
		///         </param>
		// Token: 0x06001FF9 RID: 8185 RVA: 0x000CF792 File Offset: 0x000CD992
		public void Serialize(TextWriter textWriter, object o)
		{
			this.Serialize(textWriter, o, null);
		}

		/// <summary>
		///         Выполняет сериализацию заданного <see cref="T:System.Object" /> и записывает XML-документ в файл, используя заданный <see cref="T:System.IO.TextWriter" /> и ссылки на указанных пространств имен.
		///       </summary>
		/// <param name="textWriter">
		///           <see cref="T:System.IO.TextWriter" /> Используется для записи XML-документа.
		///         </param>
		/// <param name="o">
		///           Экземпляр <see cref="T:System.Object" /> для сериализации.
		///         </param>
		/// <param name="namespaces">
		///           <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> Содержащий пространства имен для созданного XML-документа.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время сериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06001FFA RID: 8186 RVA: 0x000CF7A0 File Offset: 0x000CD9A0
		public void Serialize(TextWriter textWriter, object o, XmlSerializerNamespaces namespaces)
		{
			this.Serialize(new XmlTextWriter(textWriter)
			{
				Formatting = Formatting.Indented,
				Indentation = 2
			}, o, namespaces);
		}

		/// <summary>
		///         Выполняет сериализацию заданного <see cref="T:System.Object" /> и записывает XML-документ в файл, используя заданный <see cref="T:System.IO.Stream" />.
		///       </summary>
		/// <param name="stream">
		///           <see cref="T:System.IO.Stream" /> Используется для записи XML-документа.
		///         </param>
		/// <param name="o">
		///           Экземпляр <see cref="T:System.Object" /> для сериализации.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время сериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06001FFB RID: 8187 RVA: 0x000CF7CB File Offset: 0x000CD9CB
		public void Serialize(Stream stream, object o)
		{
			this.Serialize(stream, o, null);
		}

		/// <summary>
		///         Выполняет сериализацию заданного <see cref="T:System.Object" /> и записывает XML-документ в файл, используя заданный <see cref="T:System.IO.Stream" />ссылается на указанных пространств имен.
		///       </summary>
		/// <param name="stream">
		///           <see cref="T:System.IO.Stream" /> Используется для записи XML-документа.
		///         </param>
		/// <param name="o">
		///           Экземпляр <see cref="T:System.Object" /> для сериализации.
		///         </param>
		/// <param name="namespaces">
		///           <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> Ссылается объект.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время сериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06001FFC RID: 8188 RVA: 0x000CF7D8 File Offset: 0x000CD9D8
		public void Serialize(Stream stream, object o, XmlSerializerNamespaces namespaces)
		{
			this.Serialize(new XmlTextWriter(stream, null)
			{
				Formatting = Formatting.Indented,
				Indentation = 2
			}, o, namespaces);
		}

		/// <summary>
		///         Выполняет сериализацию заданного <see cref="T:System.Object" /> и записывает XML-документ в файл, используя заданный <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="xmlWriter">
		///           <see cref="T:System.Xml.XmlWriter" /> Используется для записи XML-документа.
		///         </param>
		/// <param name="o">
		///           Экземпляр <see cref="T:System.Object" /> для сериализации.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время сериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06001FFD RID: 8189 RVA: 0x000CF804 File Offset: 0x000CDA04
		public void Serialize(XmlWriter xmlWriter, object o)
		{
			this.Serialize(xmlWriter, o, null);
		}

		/// <summary>
		///         Выполняет сериализацию заданного <see cref="T:System.Object" /> и записывает XML-документ в файл, используя заданный <see cref="T:System.Xml.XmlWriter" /> и ссылки на указанных пространств имен.
		///       </summary>
		/// <param name="xmlWriter">
		///           <see cref="T:System.Xml.XmlWriter" /> Используется для записи XML-документа.
		///         </param>
		/// <param name="o">
		///           Экземпляр <see cref="T:System.Object" /> для сериализации.
		///         </param>
		/// <param name="namespaces">
		///           <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> Ссылается объект.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время сериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06001FFE RID: 8190 RVA: 0x000CF80F File Offset: 0x000CDA0F
		public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces)
		{
			this.Serialize(xmlWriter, o, namespaces, null);
		}

		/// <summary>
		///         Сериализует указанный объект и записывает XML-документ в файл, используя заданный <see cref="T:System.Xml.XmlWriter" /> и ссылается на заданные пространства имен и стиль кодирования.
		///       </summary>
		/// <param name="xmlWriter">
		///           <see cref="T:System.Xml.XmlWriter" /> Используется для записи XML-документа.
		///         </param>
		/// <param name="o">
		///           Объект для сериализации.
		///         </param>
		/// <param name="namespaces">
		///           <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> Ссылается объект.
		///         </param>
		/// <param name="encodingStyle">
		///           Стиль кодирования сериализованного XML.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время сериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06001FFF RID: 8191 RVA: 0x000CF81B File Offset: 0x000CDA1B
		public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces, string encodingStyle)
		{
			this.Serialize(xmlWriter, o, namespaces, encodingStyle, null);
		}

		/// <summary>
		///         Выполняет сериализацию заданного <see cref="T:System.Object" /> и записывает XML-документ в файл, используя заданный <see cref="T:System.Xml.XmlWriter" />, пространств имен XML и кодировки.
		///       </summary>
		/// <param name="xmlWriter">
		///           <see cref="T:System.Xml.XmlWriter" /> Используется для записи XML-документа.
		///         </param>
		/// <param name="o">
		///           Объект для сериализации.
		///         </param>
		/// <param name="namespaces">
		///           Экземпляр <see langword="XmlSerializaerNamespaces" /> содержащий пространства имен и префиксы, используемые.
		///         </param>
		/// <param name="encodingStyle">
		///           Кодировка, используемая в документе.
		///         </param>
		/// <param name="id">
		///           Для кодированных сообщений SOAP, используется база для генерирования атрибутов идентификатора.
		///         </param>
		// Token: 0x06002000 RID: 8192 RVA: 0x000CF82C File Offset: 0x000CDA2C
		public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces, string encodingStyle, string id)
		{
			try
			{
				if (this.primitiveType != null)
				{
					if (encodingStyle != null && encodingStyle.Length > 0)
					{
						throw new InvalidOperationException(Res.GetString("The encoding style '{0}' is not valid for this call because this XmlSerializer instance does not support encoding. Use the SoapReflectionImporter to initialize an XmlSerializer that supports encoding.", new object[]
						{
							encodingStyle
						}));
					}
					this.SerializePrimitive(xmlWriter, o, namespaces);
				}
				else
				{
					if (this.tempAssembly == null || this.typedSerializer)
					{
						XmlSerializationWriter xmlSerializationWriter = this.CreateWriter();
						xmlSerializationWriter.Init(xmlWriter, (namespaces == null || namespaces.Count == 0) ? XmlSerializer.DefaultNamespaces : namespaces, encodingStyle, id, this.tempAssembly);
						try
						{
							this.Serialize(o, xmlSerializationWriter);
							goto IL_B8;
						}
						finally
						{
							xmlSerializationWriter.Dispose();
						}
					}
					this.tempAssembly.InvokeWriter(this.mapping, xmlWriter, o, (namespaces == null || namespaces.Count == 0) ? XmlSerializer.DefaultNamespaces : namespaces, encodingStyle, id);
				}
				IL_B8:;
			}
			catch (Exception innerException)
			{
				if (innerException is ThreadAbortException || innerException is StackOverflowException || innerException is OutOfMemoryException)
				{
					throw;
				}
				if (innerException is TargetInvocationException)
				{
					innerException = innerException.InnerException;
				}
				throw new InvalidOperationException(Res.GetString("There was an error generating the XML document."), innerException);
			}
			xmlWriter.Flush();
		}

		/// <summary>
		///         Десериализует XML-документ, содержащийся в указанном <see cref="T:System.IO.Stream" />.
		///       </summary>
		/// <param name="stream">
		///           <see cref="T:System.IO.Stream" /> Содержащий XML-документ для десериализации.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Object" /> Был десериализован.
		///       </returns>
		// Token: 0x06002001 RID: 8193 RVA: 0x000CF950 File Offset: 0x000CDB50
		public object Deserialize(Stream stream)
		{
			return this.Deserialize(new XmlTextReader(stream)
			{
				WhitespaceHandling = WhitespaceHandling.Significant,
				Normalization = true,
				XmlResolver = null
			}, null);
		}

		/// <summary>
		///         Десериализует XML-документ, содержащийся в указанном <see cref="T:System.IO.TextReader" />.
		///       </summary>
		/// <param name="textReader">
		///           <see cref="T:System.IO.TextReader" /> Содержащий XML-документ для десериализации.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Object" /> Был десериализован.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время десериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06002002 RID: 8194 RVA: 0x000CF984 File Offset: 0x000CDB84
		public object Deserialize(TextReader textReader)
		{
			return this.Deserialize(new XmlTextReader(textReader)
			{
				WhitespaceHandling = WhitespaceHandling.Significant,
				Normalization = true,
				XmlResolver = null
			}, null);
		}

		/// <summary>
		///         Десериализует XML-документ, содержащийся в указанном <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="xmlReader">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий XML-документ для десериализации.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Object" /> Был десериализован.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время десериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06002003 RID: 8195 RVA: 0x000CF9B5 File Offset: 0x000CDBB5
		public object Deserialize(XmlReader xmlReader)
		{
			return this.Deserialize(xmlReader, null);
		}

		/// <summary>
		///         Десериализует XML-документ, содержащийся в указанном <see cref="T:System.Xml.XmlReader" /> и позволяет переопределять события, происходящие во время десериализации.
		///       </summary>
		/// <param name="xmlReader">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий документ для десериализации.
		///         </param>
		/// <param name="events">
		///           Экземпляр класса <see cref="T:System.Xml.Serialization.XmlDeserializationEvents" />.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Object" /> Был десериализован.
		///       </returns>
		// Token: 0x06002004 RID: 8196 RVA: 0x000CF9BF File Offset: 0x000CDBBF
		public object Deserialize(XmlReader xmlReader, XmlDeserializationEvents events)
		{
			return this.Deserialize(xmlReader, null, events);
		}

		/// <summary>
		///         Десериализует XML-документ, содержащийся в указанном <see cref="T:System.Xml.XmlReader" /> и стиль кодирования.
		///       </summary>
		/// <param name="xmlReader">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий XML-документ для десериализации.
		///         </param>
		/// <param name="encodingStyle">
		///           Стиль кодирования сериализованного XML.
		///         </param>
		/// <returns>
		///         Десериализованный объект.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Произошла ошибка во время десериализации.
		///              Исходное исключение доступны с помощью <see cref="P:System.Exception.InnerException" /> свойство.
		///           </exception>
		// Token: 0x06002005 RID: 8197 RVA: 0x000CF9CA File Offset: 0x000CDBCA
		public object Deserialize(XmlReader xmlReader, string encodingStyle)
		{
			return this.Deserialize(xmlReader, encodingStyle, this.events);
		}

		/// <summary>
		///         Выполняет десериализацию объекта с использованием данных, содержащийся в указанном <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="xmlReader">
		///           Экземпляр <see cref="T:System.Xml.XmlReader" /> класс, используемый для чтения документа.
		///         </param>
		/// <param name="encodingStyle">
		///           Кодировка, используемая.
		///         </param>
		/// <param name="events">
		///           Экземпляр класса <see cref="T:System.Xml.Serialization.XmlDeserializationEvents" />.
		///         </param>
		/// <returns>
		///         Десериализуемый объект.
		///       </returns>
		// Token: 0x06002006 RID: 8198 RVA: 0x000CF9DC File Offset: 0x000CDBDC
		public object Deserialize(XmlReader xmlReader, string encodingStyle, XmlDeserializationEvents events)
		{
			events.sender = this;
			object result;
			try
			{
				if (this.primitiveType != null)
				{
					if (encodingStyle != null && encodingStyle.Length > 0)
					{
						throw new InvalidOperationException(Res.GetString("The encoding style '{0}' is not valid for this call because this XmlSerializer instance does not support encoding. Use the SoapReflectionImporter to initialize an XmlSerializer that supports encoding.", new object[]
						{
							encodingStyle
						}));
					}
					result = this.DeserializePrimitive(xmlReader, events);
				}
				else
				{
					if (this.tempAssembly == null || this.typedSerializer)
					{
						XmlSerializationReader xmlSerializationReader = this.CreateReader();
						xmlSerializationReader.Init(xmlReader, events, encodingStyle, this.tempAssembly);
						try
						{
							return this.Deserialize(xmlSerializationReader);
						}
						finally
						{
							xmlSerializationReader.Dispose();
						}
					}
					result = this.tempAssembly.InvokeReader(this.mapping, xmlReader, events, encodingStyle);
				}
			}
			catch (Exception innerException)
			{
				if (innerException is ThreadAbortException || innerException is StackOverflowException || innerException is OutOfMemoryException)
				{
					throw;
				}
				if (innerException is TargetInvocationException)
				{
					innerException = innerException.InnerException;
				}
				if (xmlReader is IXmlLineInfo)
				{
					IXmlLineInfo xmlLineInfo = (IXmlLineInfo)xmlReader;
					throw new InvalidOperationException(Res.GetString("There is an error in XML document ({0}, {1}).", new object[]
					{
						xmlLineInfo.LineNumber.ToString(CultureInfo.InvariantCulture),
						xmlLineInfo.LinePosition.ToString(CultureInfo.InvariantCulture)
					}), innerException);
				}
				throw new InvalidOperationException(Res.GetString("There is an error in the XML document."), innerException);
			}
			return result;
		}

		/// <summary>
		///         Возвращает значение, указывающее, является ли это <see cref="T:System.Xml.Serialization.XmlSerializer" /> может десериализовать указанного XML-документа.
		///       </summary>
		/// <param name="xmlReader">
		///           <see cref="T:System.Xml.XmlReader" /> Указывающий на документ для десериализации.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если этот <see cref="T:System.Xml.Serialization.XmlSerializer" /> может десериализовать объект, <see cref="T:System.Xml.XmlReader" /> указывает; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06002007 RID: 8199 RVA: 0x000CFB34 File Offset: 0x000CDD34
		public virtual bool CanDeserialize(XmlReader xmlReader)
		{
			if (this.primitiveType != null)
			{
				TypeDesc typeDesc = (TypeDesc)TypeScope.PrimtiveTypes[this.primitiveType];
				return xmlReader.IsStartElement(typeDesc.DataType.Name, string.Empty);
			}
			return this.tempAssembly != null && this.tempAssembly.CanRead(this.mapping, xmlReader);
		}

		/// <summary>
		///         Возвращает массив <see cref="T:System.Xml.Serialization.XmlSerializer" /> объекты, созданные из массива <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> объектов.
		///       </summary>
		/// <param name="mappings">
		///           Массив <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> сопоставляет один тип в другой.
		///         </param>
		/// <returns>
		///         Массив объектов <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x06002008 RID: 8200 RVA: 0x000CFB98 File Offset: 0x000CDD98
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		public static XmlSerializer[] FromMappings(XmlMapping[] mappings)
		{
			return XmlSerializer.FromMappings(mappings, null);
		}

		/// <summary>
		///         Возвращает экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс из указанных сопоставлений.
		///       </summary>
		/// <param name="mappings">
		///           Массив объектов <see cref="T:System.Xml.Serialization.XmlMapping" />.
		///         </param>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Десериализованного объекта.
		///         </param>
		/// <returns>
		///         Экземпляр класса <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x06002009 RID: 8201 RVA: 0x000CFBA4 File Offset: 0x000CDDA4
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		public static XmlSerializer[] FromMappings(XmlMapping[] mappings, Type type)
		{
			if (mappings == null || mappings.Length == 0)
			{
				return new XmlSerializer[0];
			}
			XmlSerializerImplementation xmlSerializerImplementation = null;
			if (!(((type == null) ? null : TempAssembly.LoadGeneratedAssembly(type, null, out xmlSerializerImplementation)) == null))
			{
				XmlSerializer[] array = new XmlSerializer[mappings.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (XmlSerializer)xmlSerializerImplementation.TypedSerializers[mappings[i].Key];
				}
				return array;
			}
			if (XmlMapping.IsShallow(mappings))
			{
				return new XmlSerializer[0];
			}
			if (type == null)
			{
				TempAssembly tempAssembly = new TempAssembly(mappings, new Type[]
				{
					type
				}, null, null, null);
				XmlSerializer[] array2 = new XmlSerializer[mappings.Length];
				xmlSerializerImplementation = tempAssembly.Contract;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = (XmlSerializer)xmlSerializerImplementation.TypedSerializers[mappings[j].Key];
					array2[j].SetTempAssembly(tempAssembly, mappings[j]);
				}
				return array2;
			}
			return XmlSerializer.GetSerializersFromCache(mappings, type);
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x000CFC98 File Offset: 0x000CDE98
		private static XmlSerializer[] GetSerializersFromCache(XmlMapping[] mappings, Type type)
		{
			XmlSerializer[] array = new XmlSerializer[mappings.Length];
			Hashtable hashtable = null;
			Hashtable obj = XmlSerializer.xmlSerializerTable;
			lock (obj)
			{
				hashtable = (XmlSerializer.xmlSerializerTable[type] as Hashtable);
				if (hashtable == null)
				{
					hashtable = new Hashtable();
					XmlSerializer.xmlSerializerTable[type] = hashtable;
				}
			}
			obj = hashtable;
			lock (obj)
			{
				Hashtable hashtable2 = new Hashtable();
				for (int i = 0; i < mappings.Length; i++)
				{
					XmlSerializer.XmlSerializerMappingKey key = new XmlSerializer.XmlSerializerMappingKey(mappings[i]);
					array[i] = (hashtable[key] as XmlSerializer);
					if (array[i] == null)
					{
						hashtable2.Add(key, i);
					}
				}
				if (hashtable2.Count > 0)
				{
					XmlMapping[] array2 = new XmlMapping[hashtable2.Count];
					int num = 0;
					foreach (object obj2 in hashtable2.Keys)
					{
						XmlSerializer.XmlSerializerMappingKey xmlSerializerMappingKey = (XmlSerializer.XmlSerializerMappingKey)obj2;
						array2[num++] = xmlSerializerMappingKey.Mapping;
					}
					TempAssembly tempAssembly = new TempAssembly(array2, new Type[]
					{
						type
					}, null, null, null);
					XmlSerializerImplementation contract = tempAssembly.Contract;
					foreach (object obj3 in hashtable2.Keys)
					{
						XmlSerializer.XmlSerializerMappingKey xmlSerializerMappingKey2 = (XmlSerializer.XmlSerializerMappingKey)obj3;
						num = (int)hashtable2[xmlSerializerMappingKey2];
						array[num] = (XmlSerializer)contract.TypedSerializers[xmlSerializerMappingKey2.Mapping.Key];
						array[num].SetTempAssembly(tempAssembly, xmlSerializerMappingKey2.Mapping);
						hashtable[xmlSerializerMappingKey2] = array[num];
					}
				}
			}
			return array;
		}

		/// <summary>
		///         Возвращает экземпляр <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс, созданный из сопоставления один тип XML в другой.
		///       </summary>
		/// <param name="mappings">
		///           Массив <see cref="T:System.Xml.Serialization.XmlMapping" /> объекты, используемые для сопоставления одного типа в другой.
		///         </param>
		/// <param name="evidence">
		///           Экземпляр <see cref="T:System.Security.Policy.Evidence" /> класс, содержащий данные хоста и сборки, представленные в системе политики среды выполнения.
		///         </param>
		/// <returns>
		///         Экземпляр класса <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x0600200B RID: 8203 RVA: 0x000CFED4 File Offset: 0x000CE0D4
		[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of FromMappings which does not take an Evidence parameter. See http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		public static XmlSerializer[] FromMappings(XmlMapping[] mappings, Evidence evidence)
		{
			if (mappings == null || mappings.Length == 0)
			{
				return new XmlSerializer[0];
			}
			if (XmlMapping.IsShallow(mappings))
			{
				return new XmlSerializer[0];
			}
			XmlSerializerImplementation contract = new TempAssembly(mappings, new Type[0], null, null, evidence).Contract;
			XmlSerializer[] array = new XmlSerializer[mappings.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (XmlSerializer)contract.TypedSerializers[mappings[i].Key];
			}
			return array;
		}

		/// <summary>
		///         Возвращает сборку, содержащую клиентские сериализаторы, используемые для сериализации или десериализации указанного типа или типов с помощью указанных сопоставлений.
		///       </summary>
		/// <param name="types">
		///           Коллекция типов.
		///         </param>
		/// <param name="mappings">
		///           Коллекция <see cref="T:System.Xml.Serialization.XmlMapping" /> объекты, используемые для преобразования одного типа в другой.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Reflection.Assembly" /> Объект, содержащий сериализаторы для предоставленных типов и сопоставлений.
		///       </returns>
		// Token: 0x0600200C RID: 8204 RVA: 0x000CFF48 File Offset: 0x000CE148
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		public static Assembly GenerateSerializer(Type[] types, XmlMapping[] mappings)
		{
			return XmlSerializer.GenerateSerializer(types, mappings, new CompilerParameters
			{
				TempFiles = new TempFileCollection(),
				GenerateInMemory = false,
				IncludeDebugInformation = false
			});
		}

		/// <summary>
		///         Возвращает сборку, содержащую клиентские сериализаторы, используемые для сериализации или десериализации указанного типа или типов с помощью указанных сопоставлений и параметры компилятора и параметров.
		///       </summary>
		/// <param name="types">
		///           Массив объектов типа <see cref="T:System.Type" /> содержащий объекты, используемые для сериализации и десериализации данных.
		///         </param>
		/// <param name="mappings">
		///           Массив объектов типа <see cref="T:System.Xml.Serialization.XmlMapping" /> сопоставляемый тип данных XML-данных.
		///         </param>
		/// <param name="parameters">
		///           Экземпляр <see cref="T:System.CodeDom.Compiler.CompilerParameters" /> класс, представляющий параметры, используемые для вызова компилятора.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Reflection.Assembly" /> Содержащий специальные версии <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x0600200D RID: 8205 RVA: 0x000CFF7C File Offset: 0x000CE17C
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public static Assembly GenerateSerializer(Type[] types, XmlMapping[] mappings, CompilerParameters parameters)
		{
			if (types == null || types.Length == 0)
			{
				return null;
			}
			if (mappings == null)
			{
				throw new ArgumentNullException("mappings");
			}
			if (XmlMapping.IsShallow(mappings))
			{
				throw new InvalidOperationException(Res.GetString("This mapping was not crated by reflection importer and cannot be used in this context."));
			}
			Assembly assembly = null;
			foreach (Type type in types)
			{
				if (DynamicAssemblies.IsTypeDynamic(type))
				{
					throw new InvalidOperationException(Res.GetString("Cannot pre-generate serialization assembly for type '{0}'. Pre-generation of serialization assemblies is not supported for dynamic types. Save the assembly and load it from disk to use it with XmlSerialization.", new object[]
					{
						type.FullName
					}));
				}
				if (assembly == null)
				{
					assembly = type.Assembly;
				}
				else if (type.Assembly != assembly)
				{
					throw new ArgumentException(Res.GetString("Cannot pre-generate serializer for multiple assemblies. Type '{0}' does not belong to assembly {1}.", new object[]
					{
						type.FullName,
						assembly.Location
					}), "types");
				}
			}
			return TempAssembly.GenerateAssembly(mappings, types, null, null, XmlSerializerCompilerParameters.Create(parameters, true), assembly, new Hashtable());
		}

		/// <summary>
		///         Возвращает массив <see cref="T:System.Xml.Serialization.XmlSerializer" /> объекты, созданные из массива типов.
		///       </summary>
		/// <param name="types">
		///           Массив объектов <see cref="T:System.Type" />.
		///         </param>
		/// <returns>
		///         Массив объектов <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x0600200E RID: 8206 RVA: 0x000D005C File Offset: 0x000CE25C
		public static XmlSerializer[] FromTypes(Type[] types)
		{
			if (types == null)
			{
				return new XmlSerializer[0];
			}
			XmlReflectionImporter xmlReflectionImporter = new XmlReflectionImporter();
			XmlTypeMapping[] array = new XmlTypeMapping[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				array[i] = xmlReflectionImporter.ImportTypeMapping(types[i]);
			}
			XmlMapping[] mappings = array;
			return XmlSerializer.FromMappings(mappings);
		}

		/// <summary>
		///         Возвращает имя сборки, содержащей один или несколько версий <see cref="T:System.Xml.Serialization.XmlSerializer" /> особенно созданный для сериализации или десериализации указанного типа.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Десериализации.
		///         </param>
		/// <returns>
		///         Имя сборки, содержащей <see cref="T:System.Xml.Serialization.XmlSerializer" /> для типа.
		///       </returns>
		// Token: 0x0600200F RID: 8207 RVA: 0x000D00A4 File Offset: 0x000CE2A4
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public static string GetXmlSerializerAssemblyName(Type type)
		{
			return XmlSerializer.GetXmlSerializerAssemblyName(type, null);
		}

		/// <summary>
		///         Возвращает имя сборки, содержащей сериализатор для указанного типа в указанном пространстве имен.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Вас интересуют.
		///         </param>
		/// <param name="defaultNamespace">
		///           Пространство имен типа.
		///         </param>
		/// <returns>
		///         Имя сборки, содержащей специально собранные сериализаторы.
		///       </returns>
		// Token: 0x06002010 RID: 8208 RVA: 0x000D00AD File Offset: 0x000CE2AD
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public static string GetXmlSerializerAssemblyName(Type type, string defaultNamespace)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return Compiler.GetTempAssemblyName(type.Assembly.GetName(), defaultNamespace);
		}

		/// <summary>
		///         Происходит при <see cref="T:System.Xml.Serialization.XmlSerializer" /> находит при десериализации узел XML неизвестного типа.
		///       </summary>
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06002011 RID: 8209 RVA: 0x000D00D4 File Offset: 0x000CE2D4
		// (remove) Token: 0x06002012 RID: 8210 RVA: 0x000D00F2 File Offset: 0x000CE2F2
		public event XmlNodeEventHandler UnknownNode
		{
			add
			{
				this.events.OnUnknownNode = (XmlNodeEventHandler)Delegate.Combine(this.events.OnUnknownNode, value);
			}
			remove
			{
				this.events.OnUnknownNode = (XmlNodeEventHandler)Delegate.Remove(this.events.OnUnknownNode, value);
			}
		}

		/// <summary>
		///         Происходит при <see cref="T:System.Xml.Serialization.XmlSerializer" /> находит при десериализации атрибут XML неизвестного типа.
		///       </summary>
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06002013 RID: 8211 RVA: 0x000D0110 File Offset: 0x000CE310
		// (remove) Token: 0x06002014 RID: 8212 RVA: 0x000D012E File Offset: 0x000CE32E
		public event XmlAttributeEventHandler UnknownAttribute
		{
			add
			{
				this.events.OnUnknownAttribute = (XmlAttributeEventHandler)Delegate.Combine(this.events.OnUnknownAttribute, value);
			}
			remove
			{
				this.events.OnUnknownAttribute = (XmlAttributeEventHandler)Delegate.Remove(this.events.OnUnknownAttribute, value);
			}
		}

		/// <summary>
		///         Происходит при <see cref="T:System.Xml.Serialization.XmlSerializer" /> встречает элемент XML неизвестного типа во время десериализации.
		///       </summary>
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06002015 RID: 8213 RVA: 0x000D014C File Offset: 0x000CE34C
		// (remove) Token: 0x06002016 RID: 8214 RVA: 0x000D016A File Offset: 0x000CE36A
		public event XmlElementEventHandler UnknownElement
		{
			add
			{
				this.events.OnUnknownElement = (XmlElementEventHandler)Delegate.Combine(this.events.OnUnknownElement, value);
			}
			remove
			{
				this.events.OnUnknownElement = (XmlElementEventHandler)Delegate.Remove(this.events.OnUnknownElement, value);
			}
		}

		/// <summary>
		///         Происходит во время десериализации потока XML с кодировкой SOAP, когда <see cref="T:System.Xml.Serialization.XmlSerializer" /> обнаруживает распознаваемым типом, который не используется или без ссылки.
		///       </summary>
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06002017 RID: 8215 RVA: 0x000D0188 File Offset: 0x000CE388
		// (remove) Token: 0x06002018 RID: 8216 RVA: 0x000D01A6 File Offset: 0x000CE3A6
		public event UnreferencedObjectEventHandler UnreferencedObject
		{
			add
			{
				this.events.OnUnreferencedObject = (UnreferencedObjectEventHandler)Delegate.Combine(this.events.OnUnreferencedObject, value);
			}
			remove
			{
				this.events.OnUnreferencedObject = (UnreferencedObjectEventHandler)Delegate.Remove(this.events.OnUnreferencedObject, value);
			}
		}

		/// <summary>
		///         Возвращает объект, используемый для чтения документа XML для сериализации.
		///       </summary>
		/// <returns>
		///         Средство чтения <see cref="T:System.Xml.Serialization.XmlSerializationReader" />, используемое для чтения документа XML.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Все возможные попытки доступа к методу, если метод не переопределен в производном классе.
		///           </exception>
		// Token: 0x06002019 RID: 8217 RVA: 0x0000349C File Offset: 0x0000169C
		protected virtual XmlSerializationReader CreateReader()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Десериализует XML-документ, содержащийся в указанном <see cref="T:System.Xml.Serialization.XmlSerializationReader" />.
		///       </summary>
		/// <param name="reader">
		///           <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> Содержащий XML-документ для десериализации.
		///         </param>
		/// <returns>
		///         Десериализованный объект.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Все возможные попытки доступа к методу, если метод не переопределен в производном классе.
		///           </exception>
		// Token: 0x0600201A RID: 8218 RVA: 0x0000349C File Offset: 0x0000169C
		protected virtual object Deserialize(XmlSerializationReader reader)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         При переопределении в производном классе, возвращает записи, используемые для сериализации объекта.
		///       </summary>
		/// <returns>
		///         Экземпляр, который реализует <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> класса.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Все возможные попытки доступа к методу, если метод не переопределен в производном классе.
		///           </exception>
		// Token: 0x0600201B RID: 8219 RVA: 0x0000349C File Offset: 0x0000169C
		protected virtual XmlSerializationWriter CreateWriter()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Выполняет сериализацию заданного <see cref="T:System.Object" /> и записывает XML-документ в файл, используя заданный <see cref="T:System.Xml.Serialization.XmlSerializationWriter" />.
		///       </summary>
		/// <param name="o">
		///           Экземпляр <see cref="T:System.Object" /> для сериализации.
		///         </param>
		/// <param name="writer">
		///           <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> Используется для записи XML-документа.
		///         </param>
		/// <exception cref="T:System.NotImplementedException">
		///             Все возможные попытки доступа к методу, если метод не переопределен в производном классе.
		///           </exception>
		// Token: 0x0600201C RID: 8220 RVA: 0x0000349C File Offset: 0x0000169C
		protected virtual void Serialize(object o, XmlSerializationWriter writer)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000D01C4 File Offset: 0x000CE3C4
		internal void SetTempAssembly(TempAssembly tempAssembly, XmlMapping mapping)
		{
			this.tempAssembly = tempAssembly;
			this.mapping = mapping;
			this.typedSerializer = true;
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000D01DC File Offset: 0x000CE3DC
		private static XmlTypeMapping GetKnownMapping(Type type, string ns)
		{
			if (ns != null && ns != string.Empty)
			{
				return null;
			}
			TypeDesc typeDesc = (TypeDesc)TypeScope.PrimtiveTypes[type];
			if (typeDesc == null)
			{
				return null;
			}
			XmlTypeMapping xmlTypeMapping = new XmlTypeMapping(null, new ElementAccessor
			{
				Name = typeDesc.DataType.Name
			});
			xmlTypeMapping.SetKeyInternal(XmlMapping.GenerateKey(type, null, null));
			return xmlTypeMapping;
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000D0240 File Offset: 0x000CE440
		private void SerializePrimitive(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces)
		{
			XmlSerializationPrimitiveWriter xmlSerializationPrimitiveWriter = new XmlSerializationPrimitiveWriter();
			xmlSerializationPrimitiveWriter.Init(xmlWriter, namespaces, null, null, null);
			switch (Type.GetTypeCode(this.primitiveType))
			{
			case TypeCode.Boolean:
				xmlSerializationPrimitiveWriter.Write_boolean(o);
				return;
			case TypeCode.Char:
				xmlSerializationPrimitiveWriter.Write_char(o);
				return;
			case TypeCode.SByte:
				xmlSerializationPrimitiveWriter.Write_byte(o);
				return;
			case TypeCode.Byte:
				xmlSerializationPrimitiveWriter.Write_unsignedByte(o);
				return;
			case TypeCode.Int16:
				xmlSerializationPrimitiveWriter.Write_short(o);
				return;
			case TypeCode.UInt16:
				xmlSerializationPrimitiveWriter.Write_unsignedShort(o);
				return;
			case TypeCode.Int32:
				xmlSerializationPrimitiveWriter.Write_int(o);
				return;
			case TypeCode.UInt32:
				xmlSerializationPrimitiveWriter.Write_unsignedInt(o);
				return;
			case TypeCode.Int64:
				xmlSerializationPrimitiveWriter.Write_long(o);
				return;
			case TypeCode.UInt64:
				xmlSerializationPrimitiveWriter.Write_unsignedLong(o);
				return;
			case TypeCode.Single:
				xmlSerializationPrimitiveWriter.Write_float(o);
				return;
			case TypeCode.Double:
				xmlSerializationPrimitiveWriter.Write_double(o);
				return;
			case TypeCode.Decimal:
				xmlSerializationPrimitiveWriter.Write_decimal(o);
				return;
			case TypeCode.DateTime:
				xmlSerializationPrimitiveWriter.Write_dateTime(o);
				return;
			case TypeCode.String:
				xmlSerializationPrimitiveWriter.Write_string(o);
				return;
			}
			if (this.primitiveType == typeof(XmlQualifiedName))
			{
				xmlSerializationPrimitiveWriter.Write_QName(o);
				return;
			}
			if (this.primitiveType == typeof(byte[]))
			{
				xmlSerializationPrimitiveWriter.Write_base64Binary(o);
				return;
			}
			if (this.primitiveType == typeof(Guid))
			{
				xmlSerializationPrimitiveWriter.Write_guid(o);
				return;
			}
			if (this.primitiveType == typeof(TimeSpan))
			{
				xmlSerializationPrimitiveWriter.Write_TimeSpan(o);
				return;
			}
			throw new InvalidOperationException(Res.GetString("The type {0} was not expected. Use the XmlInclude or SoapInclude attribute to specify types that are not known statically.", new object[]
			{
				this.primitiveType.FullName
			}));
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000D03CC File Offset: 0x000CE5CC
		private object DeserializePrimitive(XmlReader xmlReader, XmlDeserializationEvents events)
		{
			XmlSerializationPrimitiveReader xmlSerializationPrimitiveReader = new XmlSerializationPrimitiveReader();
			xmlSerializationPrimitiveReader.Init(xmlReader, events, null, null);
			switch (Type.GetTypeCode(this.primitiveType))
			{
			case TypeCode.Boolean:
				return xmlSerializationPrimitiveReader.Read_boolean();
			case TypeCode.Char:
				return xmlSerializationPrimitiveReader.Read_char();
			case TypeCode.SByte:
				return xmlSerializationPrimitiveReader.Read_byte();
			case TypeCode.Byte:
				return xmlSerializationPrimitiveReader.Read_unsignedByte();
			case TypeCode.Int16:
				return xmlSerializationPrimitiveReader.Read_short();
			case TypeCode.UInt16:
				return xmlSerializationPrimitiveReader.Read_unsignedShort();
			case TypeCode.Int32:
				return xmlSerializationPrimitiveReader.Read_int();
			case TypeCode.UInt32:
				return xmlSerializationPrimitiveReader.Read_unsignedInt();
			case TypeCode.Int64:
				return xmlSerializationPrimitiveReader.Read_long();
			case TypeCode.UInt64:
				return xmlSerializationPrimitiveReader.Read_unsignedLong();
			case TypeCode.Single:
				return xmlSerializationPrimitiveReader.Read_float();
			case TypeCode.Double:
				return xmlSerializationPrimitiveReader.Read_double();
			case TypeCode.Decimal:
				return xmlSerializationPrimitiveReader.Read_decimal();
			case TypeCode.DateTime:
				return xmlSerializationPrimitiveReader.Read_dateTime();
			case TypeCode.String:
				return xmlSerializationPrimitiveReader.Read_string();
			}
			object result;
			if (this.primitiveType == typeof(XmlQualifiedName))
			{
				result = xmlSerializationPrimitiveReader.Read_QName();
			}
			else if (this.primitiveType == typeof(byte[]))
			{
				result = xmlSerializationPrimitiveReader.Read_base64Binary();
			}
			else if (this.primitiveType == typeof(Guid))
			{
				result = xmlSerializationPrimitiveReader.Read_guid();
			}
			else
			{
				if (!(this.primitiveType == typeof(TimeSpan)) || !LocalAppContextSwitches.EnableTimeSpanSerialization)
				{
					throw new InvalidOperationException(Res.GetString("The type {0} was not expected. Use the XmlInclude or SoapInclude attribute to specify types that are not known statically.", new object[]
					{
						this.primitiveType.FullName
					}));
				}
				result = xmlSerializationPrimitiveReader.Read_TimeSpan();
			}
			return result;
		}

		// Token: 0x04001B14 RID: 6932
		private TempAssembly tempAssembly;

		// Token: 0x04001B15 RID: 6933
		private bool typedSerializer;

		// Token: 0x04001B16 RID: 6934
		private Type primitiveType;

		// Token: 0x04001B17 RID: 6935
		private XmlMapping mapping;

		// Token: 0x04001B18 RID: 6936
		private XmlDeserializationEvents events;

		// Token: 0x04001B19 RID: 6937
		private static TempAssemblyCache cache = new TempAssemblyCache();

		// Token: 0x04001B1A RID: 6938
		private static volatile XmlSerializerNamespaces defaultNamespaces;

		// Token: 0x04001B1B RID: 6939
		private static Hashtable xmlSerializerTable = new Hashtable();

		// Token: 0x02000303 RID: 771
		private class XmlSerializerMappingKey
		{
			// Token: 0x06002022 RID: 8226 RVA: 0x000D05BB File Offset: 0x000CE7BB
			public XmlSerializerMappingKey(XmlMapping mapping)
			{
				this.Mapping = mapping;
			}

			// Token: 0x06002023 RID: 8227 RVA: 0x000D05CC File Offset: 0x000CE7CC
			public override bool Equals(object obj)
			{
				XmlSerializer.XmlSerializerMappingKey xmlSerializerMappingKey = obj as XmlSerializer.XmlSerializerMappingKey;
				return xmlSerializerMappingKey != null && !(this.Mapping.Key != xmlSerializerMappingKey.Mapping.Key) && !(this.Mapping.ElementName != xmlSerializerMappingKey.Mapping.ElementName) && !(this.Mapping.Namespace != xmlSerializerMappingKey.Mapping.Namespace) && this.Mapping.IsSoap == xmlSerializerMappingKey.Mapping.IsSoap;
			}

			// Token: 0x06002024 RID: 8228 RVA: 0x000D0660 File Offset: 0x000CE860
			public override int GetHashCode()
			{
				int num = this.Mapping.IsSoap ? 0 : 1;
				if (this.Mapping.Key != null)
				{
					num ^= this.Mapping.Key.GetHashCode();
				}
				if (this.Mapping.ElementName != null)
				{
					num ^= this.Mapping.ElementName.GetHashCode();
				}
				if (this.Mapping.Namespace != null)
				{
					num ^= this.Mapping.Namespace.GetHashCode();
				}
				return num;
			}

			// Token: 0x04001B1C RID: 6940
			public XmlMapping Mapping;
		}
	}
}
