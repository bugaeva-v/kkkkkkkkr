using System;
using System.Security.Permissions;
using System.Security.Policy;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Создает типизированные версии <see cref="T:System.Xml.Serialization.XmlSerializer" /> для более эффективной сериализации.
	///       </summary>
	// Token: 0x02000305 RID: 773
	public class XmlSerializerFactory
	{
		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса, который может сериализовать объекты заданного типа в XML-документы, и наоборот.
		///          Каждый сериализуемый объект может сам содержать экземпляры классов, которые данная перегрузка позволяет переопределить с другими классами.
		///          Данная перегрузка также указывает пространство имен по умолчанию для всех элементов XML и класс для использования в качестве корневого элемента XML.
		///       </summary>
		/// <param name="type">
		///           Экземпляр <see cref="T:System.Type" /> для сериализации.
		///         </param>
		/// <param name="overrides">
		///           <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> Содержащий поля, которые переопределяют сериализация по умолчанию.
		///         </param>
		/// <param name="extraTypes">
		///           A <see cref="T:System.Type" /> массив дополнительные типы объектов для сериализации.
		///         </param>
		/// <param name="root">
		///           <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> Представляющий корневой элемент XML.
		///         </param>
		/// <param name="defaultNamespace">
		///           Пространство имен по умолчанию всех элементов XML в XML-документе.
		///         </param>
		/// <returns>
		///         Производным от <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x0600202C RID: 8236 RVA: 0x000D072C File Offset: 0x000CE92C
		public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace)
		{
			return this.CreateSerializer(type, overrides, extraTypes, root, defaultNamespace, null);
		}

		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса, который может сериализовать объекты заданного типа в документы XML и наоборот.
		///          Указывает объект, представляющий корневой элемент XML.
		///       </summary>
		/// <param name="type">
		///           Экземпляр <see cref="T:System.Type" /> для сериализации.
		///         </param>
		/// <param name="root">
		///           <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> Представляющий корневой элемент XML.
		///         </param>
		/// <returns>
		///         Производным от <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x0600202D RID: 8237 RVA: 0x000D073C File Offset: 0x000CE93C
		public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root)
		{
			return this.CreateSerializer(type, null, new Type[0], root, null, null);
		}

		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializerFactory" /> класс, используемый для сериализации указанного типа.
		///          Если свойство или поле возвращает массив, <paramref name="extraTypes" /> определяет объекты, которые могут быть вставлены в массив.
		///       </summary>
		/// <param name="type">
		///           Экземпляр <see cref="T:System.Type" /> для сериализации.
		///         </param>
		/// <param name="extraTypes">
		///           A <see cref="T:System.Type" /> массив дополнительные типы объектов для сериализации.
		///         </param>
		/// <returns>
		///         Производным от <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x0600202E RID: 8238 RVA: 0x000D074F File Offset: 0x000CE94F
		public XmlSerializer CreateSerializer(Type type, Type[] extraTypes)
		{
			return this.CreateSerializer(type, null, extraTypes, null, null, null);
		}

		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса, который может сериализовать объекты заданного типа в документы XML и наоборот.
		///          Каждый сериализуемый объект может сам содержать экземпляры классов, которые данная перегрузка позволяет переопределить с другими классами.
		///       </summary>
		/// <param name="type">
		///           Экземпляр <see cref="T:System.Type" /> для сериализации.
		///         </param>
		/// <param name="overrides">
		///           <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> Содержащий поля, которые переопределяют сериализация по умолчанию.
		///         </param>
		/// <returns>
		///         Производным от <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x0600202F RID: 8239 RVA: 0x000D075D File Offset: 0x000CE95D
		public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides)
		{
			return this.CreateSerializer(type, overrides, new Type[0], null, null, null);
		}

		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializerFactory" /> класса объекта, который отображает один тип в другой.
		///       </summary>
		/// <param name="xmlTypeMapping">
		///           <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> Сопоставляет один тип в другой.
		///         </param>
		/// <returns>
		///         Наследование из <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс, созданный специально для сериализации сопоставленный тип.
		///       </returns>
		// Token: 0x06002030 RID: 8240 RVA: 0x000D0770 File Offset: 0x000CE970
		public XmlSerializer CreateSerializer(XmlTypeMapping xmlTypeMapping)
		{
			return (XmlSerializer)XmlSerializer.GenerateTempAssembly(xmlTypeMapping).Contract.TypedSerializers[xmlTypeMapping.Key];
		}

		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializerFactory" /> класс, используемый для сериализации указанного типа.
		///       </summary>
		/// <param name="type">
		///           Экземпляр <see cref="T:System.Type" /> для сериализации.
		///         </param>
		/// <returns>
		///         Наследование из <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс, созданный специально для сериализации указанного типа.
		///       </returns>
		// Token: 0x06002031 RID: 8241 RVA: 0x000D0792 File Offset: 0x000CE992
		public XmlSerializer CreateSerializer(Type type)
		{
			return this.CreateSerializer(type, null);
		}

		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializerFactory" /> класс, используемый для сериализации указанного типа и пространство имен.
		///       </summary>
		/// <param name="type">
		///           Экземпляр <see cref="T:System.Type" /> для сериализации.
		///         </param>
		/// <param name="defaultNamespace">
		///           Пространство имен по умолчанию для всех элементов XML.
		///         </param>
		/// <returns>
		///         Наследование из <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс, созданный специально для сериализации указанного типа.
		///       </returns>
		// Token: 0x06002032 RID: 8242 RVA: 0x000D079C File Offset: 0x000CE99C
		public XmlSerializer CreateSerializer(Type type, string defaultNamespace)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			TempAssembly tempAssembly = XmlSerializerFactory.cache[defaultNamespace, type];
			XmlTypeMapping xmlTypeMapping = null;
			if (tempAssembly == null)
			{
				TempAssemblyCache obj = XmlSerializerFactory.cache;
				lock (obj)
				{
					tempAssembly = XmlSerializerFactory.cache[defaultNamespace, type];
					if (tempAssembly == null)
					{
						XmlSerializerImplementation contract;
						if (TempAssembly.LoadGeneratedAssembly(type, defaultNamespace, out contract) == null)
						{
							xmlTypeMapping = new XmlReflectionImporter(defaultNamespace).ImportTypeMapping(type, null, defaultNamespace);
							tempAssembly = XmlSerializer.GenerateTempAssembly(xmlTypeMapping, type, defaultNamespace);
						}
						else
						{
							tempAssembly = new TempAssembly(contract);
						}
						XmlSerializerFactory.cache.Add(defaultNamespace, type, tempAssembly);
					}
				}
			}
			if (xmlTypeMapping == null)
			{
				xmlTypeMapping = XmlReflectionImporter.GetTopLevelMapping(type, defaultNamespace);
			}
			return tempAssembly.Contract.GetSerializer(type);
		}

		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса, который может сериализовать объекты заданного типа в XML-документы, и наоборот.
		///          Каждый сериализуемый объект может сам содержать экземпляры классов, которые данная перегрузка позволяет переопределить с другими классами.
		///          Данная перегрузка также указывает пространство имен по умолчанию для всех элементов XML и класс для использования в качестве корневого элемента XML.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		/// <param name="overrides">
		///           <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> Расширяющий или переопределения поведения класса, указанного в параметре типа.
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
		///           Путь, указывающий расположение типов.
		///         </param>
		/// <returns>
		///         Производным от <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x06002033 RID: 8243 RVA: 0x000D0864 File Offset: 0x000CEA64
		public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location)
		{
			return this.CreateSerializer(type, overrides, extraTypes, root, defaultNamespace, location, null);
		}

		/// <summary>
		///         Возвращает производным от <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса, который может сериализовать объекты заданного типа в XML-документы, и наоборот.
		///          Каждый сериализуемый объект может сам содержать экземпляры классов, которые данная перегрузка позволяет переопределить с другими классами.
		///          Данная перегрузка также указывает пространство имен по умолчанию для всех элементов XML и класс для использования в качестве корневого элемента XML.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта, <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно сериализовать.
		///         </param>
		/// <param name="overrides">
		///           <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> Расширяющий или переопределения поведения класса, указанного в параметре типа.
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
		///           Путь, указывающий расположение типов.
		///         </param>
		/// <param name="evidence">
		///           Экземпляр <see cref="T:System.Security.Policy.Evidence" /> класс, который содержит учетные данные, необходимые для доступа к типам.
		///         </param>
		/// <returns>
		///         Производным от <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x06002034 RID: 8244 RVA: 0x000D0878 File Offset: 0x000CEA78
		[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateSerializer which does not take an Evidence parameter. See http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
		public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location, Evidence evidence)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (location != null || evidence != null)
			{
				this.DemandForUserLocationOrEvidence();
			}
			XmlReflectionImporter xmlReflectionImporter = new XmlReflectionImporter(overrides, defaultNamespace);
			for (int i = 0; i < extraTypes.Length; i++)
			{
				xmlReflectionImporter.IncludeType(extraTypes[i]);
			}
			XmlTypeMapping xmlTypeMapping = xmlReflectionImporter.ImportTypeMapping(type, root, defaultNamespace);
			return (XmlSerializer)XmlSerializer.GenerateTempAssembly(xmlTypeMapping, type, defaultNamespace, location, evidence).Contract.TypedSerializers[xmlTypeMapping.Key];
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0000B528 File Offset: 0x00009728
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		private void DemandForUserLocationOrEvidence()
		{
		}

		// Token: 0x04001B1F RID: 6943
		private static TempAssemblyCache cache = new TempAssemblyCache();
	}
}
