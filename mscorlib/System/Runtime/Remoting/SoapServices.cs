using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting
{
	/// <summary>Обеспечивает несколько методов для использования и публикации удаленных объектов в SOAP-формате.</summary>
	// Token: 0x02000574 RID: 1396
	[ComVisible(true)]
	public class SoapServices
	{
		// Token: 0x060036CE RID: 14030 RVA: 0x0000259F File Offset: 0x0000079F
		private SoapServices()
		{
		}

		/// <summary>Получает XML-префикс пространства имен для типов общеязыковой среды выполнения.</summary>
		/// <returns>XML-префикс пространства имен для типов общеязыковой среды выполнения.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060036CF RID: 14031 RVA: 0x000C5DD4 File Offset: 0x000C3FD4
		public static string XmlNsForClrType
		{
			get
			{
				return "http://schemas.microsoft.com/clr/";
			}
		}

		/// <summary>Получает префикс пространства имен XML по умолчанию, который используется для XML-кодировки класса общеязыковой среды выполнения, имеющего сборку, но не присущее данному объекту пространство имен.</summary>
		/// <returns>Префикс пространства имен XML по умолчанию, который используется для XML-кодировки класса общеязыковой среды выполнения, имеющего сборку, но не присущее данному объекту пространство имен.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x000C5DDB File Offset: 0x000C3FDB
		public static string XmlNsForClrTypeWithAssembly
		{
			get
			{
				return "http://schemas.microsoft.com/clr/assem/";
			}
		}

		/// <summary>Получает префикс пространства имен XML по умолчанию, который следует использовать для XML-кодировки класса общеязыковой среды выполнения, являющегося частью файла mscorlib.dll.</summary>
		/// <returns>Префикс пространства имен XML по умолчанию, который следует использовать для XML-кодировки класса общеязыковой среды выполнения, являющегося частью файла mscorlib.dll.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x000C5DE2 File Offset: 0x000C3FE2
		public static string XmlNsForClrTypeWithNs
		{
			get
			{
				return "http://schemas.microsoft.com/clr/ns/";
			}
		}

		/// <summary>Получает префикс пространства имен XML по умолчанию, который используется для XML-кодировки класса общеязыковой среды выполнения, имеющего сборку и пространство имен общеязыковой среды выполнения.</summary>
		/// <returns>Префикс пространства имен XML по умолчанию, который используется для XML-кодировки класса общеязыковой среды выполнения, имеющего сборку и пространство имен общеязыковой среды выполнения.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x000C5DE9 File Offset: 0x000C3FE9
		public static string XmlNsForClrTypeWithNsAndAssembly
		{
			get
			{
				return "http://schemas.microsoft.com/clr/nsassem/";
			}
		}

		/// <summary>Возвращает имя пространства имен типа общеязыковой среды выполнения из предоставленных имен сборки и пространства имен.</summary>
		/// <param name="typeNamespace">Кодируемое пространство имен.</param>
		/// <param name="assemblyName">Кодируемое имя сборки.</param>
		/// <returns>Имя пространства имен типа общеязыковой среды выполнения из предоставленных имен сборки и пространства имен.</returns>
		/// <exception cref="T:System.ArgumentNullException">Оба параметра <paramref name="assemblyName" /> и <paramref name="typeNamespace" /> пусты или <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036D3 RID: 14035 RVA: 0x000C5DF0 File Offset: 0x000C3FF0
		public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
		{
			if (assemblyName == string.Empty)
			{
				return SoapServices.XmlNsForClrTypeWithNs + typeNamespace;
			}
			if (typeNamespace == string.Empty)
			{
				return SoapServices.EncodeNs(SoapServices.XmlNsForClrTypeWithAssembly + assemblyName);
			}
			return SoapServices.EncodeNs(SoapServices.XmlNsForClrTypeWithNsAndAssembly + typeNamespace + "/" + assemblyName);
		}

		/// <summary>Декодирует имена пространства имен XML и сборки из пространства имен общеязыковой среды выполнения.</summary>
		/// <param name="inNamespace">Пространство имен общеязыковой среды выполнения.</param>
		/// <param name="typeNamespace">Когда возвращается этот метод, он содержит <see cref="T:System.String" />, в которой указано декодированное имя пространства имен. Этот параметр передается неинициализированным.</param>
		/// <param name="assemblyName">Когда возвращается этот метод, он содержит <see cref="T:System.String" />, в которой указано декодированное имя сборки. Этот параметр передается неинициализированным.</param>
		/// <returns>
		///   <see langword="true" />, если имена пространства имен и сборки декодированы успешно; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="inNamespace" /> имеет значение <see langword="null" /> или является пустым.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036D4 RID: 14036 RVA: 0x000C5E4C File Offset: 0x000C404C
		public static bool DecodeXmlNamespaceForClrTypeNamespace(string inNamespace, out string typeNamespace, out string assemblyName)
		{
			if (inNamespace == null)
			{
				throw new ArgumentNullException("inNamespace");
			}
			inNamespace = SoapServices.DecodeNs(inNamespace);
			typeNamespace = null;
			assemblyName = null;
			if (inNamespace.StartsWith(SoapServices.XmlNsForClrTypeWithNsAndAssembly))
			{
				int length = SoapServices.XmlNsForClrTypeWithNsAndAssembly.Length;
				if (length >= inNamespace.Length)
				{
					return false;
				}
				int num = inNamespace.IndexOf('/', length + 1);
				if (num == -1)
				{
					return false;
				}
				typeNamespace = inNamespace.Substring(length, num - length);
				assemblyName = inNamespace.Substring(num + 1);
				return true;
			}
			else
			{
				if (inNamespace.StartsWith(SoapServices.XmlNsForClrTypeWithNs))
				{
					int length2 = SoapServices.XmlNsForClrTypeWithNs.Length;
					typeNamespace = inNamespace.Substring(length2);
					return true;
				}
				if (inNamespace.StartsWith(SoapServices.XmlNsForClrTypeWithAssembly))
				{
					int length3 = SoapServices.XmlNsForClrTypeWithAssembly.Length;
					assemblyName = inNamespace.Substring(length3);
					return true;
				}
				return false;
			}
		}

		/// <summary>Извлекает тип поля из XML имени атрибута, пространства имен и типа <see cref="T:System.Type" />, содержащего объект.</summary>
		/// <param name="containingType">
		///   <see cref="T:System.Type" /> объекта, содержащего поле.</param>
		/// <param name="xmlAttribute">Имя XML-атрибута типа поля.</param>
		/// <param name="xmlNamespace">Пространство имен XML типа поля.</param>
		/// <param name="type">Когда возвращается этот метод, он содержит <see cref="T:System.Type" /> поля. Этот параметр передается неинициализированным.</param>
		/// <param name="name">Когда возвращается этот метод, он содержит <see cref="T:System.String" />, в котором находится имя поля. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036D5 RID: 14037 RVA: 0x000C5F0C File Offset: 0x000C410C
		public static void GetInteropFieldTypeAndNameFromXmlAttribute(Type containingType, string xmlAttribute, string xmlNamespace, out Type type, out string name)
		{
			SoapServices.TypeInfo typeInfo = (SoapServices.TypeInfo)SoapServices._typeInfos[containingType];
			SoapServices.GetInteropFieldInfo((typeInfo != null) ? typeInfo.Attributes : null, xmlAttribute, xmlNamespace, out type, out name);
		}

		/// <summary>Извлекает тип <see cref="T:System.Type" /> и имя поля из предоставленного имени элемента XML, пространства имен и содержащегося типа.</summary>
		/// <param name="containingType">
		///   <see cref="T:System.Type" /> объекта, содержащего поле.</param>
		/// <param name="xmlElement">Имя поля XML-элемента.</param>
		/// <param name="xmlNamespace">Пространство имен XML типа поля.</param>
		/// <param name="type">Когда возвращается этот метод, он содержит <see cref="T:System.Type" /> поля. Этот параметр передается неинициализированным.</param>
		/// <param name="name">Когда возвращается этот метод, он содержит <see cref="T:System.String" />, в котором находится имя поля. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036D6 RID: 14038 RVA: 0x000C5F40 File Offset: 0x000C4140
		public static void GetInteropFieldTypeAndNameFromXmlElement(Type containingType, string xmlElement, string xmlNamespace, out Type type, out string name)
		{
			SoapServices.TypeInfo typeInfo = (SoapServices.TypeInfo)SoapServices._typeInfos[containingType];
			SoapServices.GetInteropFieldInfo((typeInfo != null) ? typeInfo.Elements : null, xmlElement, xmlNamespace, out type, out name);
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x000C5F74 File Offset: 0x000C4174
		private static void GetInteropFieldInfo(Hashtable fields, string xmlName, string xmlNamespace, out Type type, out string name)
		{
			if (fields != null)
			{
				FieldInfo fieldInfo = (FieldInfo)fields[SoapServices.GetNameKey(xmlName, xmlNamespace)];
				if (fieldInfo != null)
				{
					type = fieldInfo.FieldType;
					name = fieldInfo.Name;
					return;
				}
			}
			type = null;
			name = null;
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x000C5FB9 File Offset: 0x000C41B9
		private static string GetNameKey(string name, string namspace)
		{
			if (namspace == null)
			{
				return name;
			}
			return name + " " + namspace;
		}

		/// <summary>Извлекает тип <see cref="T:System.Type" />, который следует использовать во время десериализации нераспознанного типа объекта с данным именем элемента XML и пространством имен.</summary>
		/// <param name="xmlElement">Имя элемента XML неизвестного типа объекта.</param>
		/// <param name="xmlNamespace">Пространство имен XML неизвестного типа объекта.</param>
		/// <returns>Тип <see cref="T:System.Type" /> объекта, связанный с указанным именем элемента XML и пространством имен.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036D9 RID: 14041 RVA: 0x000C5FCC File Offset: 0x000C41CC
		public static Type GetInteropTypeFromXmlElement(string xmlElement, string xmlNamespace)
		{
			object syncRoot = SoapServices._xmlElements.SyncRoot;
			Type result;
			lock (syncRoot)
			{
				result = (Type)SoapServices._xmlElements[xmlElement + " " + xmlNamespace];
			}
			return result;
		}

		/// <summary>Извлекает тип <see cref="T:System.Type" />, который следует использовать во время десериализации нераспознанного типа объекта с данным именем типа XML и пространством имен.</summary>
		/// <param name="xmlType">XML-тип неизвестного типа объекта.</param>
		/// <param name="xmlTypeNamespace">Пространство имен типа XML неизвестного типа объекта.</param>
		/// <returns>Тип <see cref="T:System.Type" /> объекта, связанный с указанным именем типа XML и пространством имен.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036DA RID: 14042 RVA: 0x000C6028 File Offset: 0x000C4228
		public static Type GetInteropTypeFromXmlType(string xmlType, string xmlTypeNamespace)
		{
			object syncRoot = SoapServices._xmlTypes.SyncRoot;
			Type result;
			lock (syncRoot)
			{
				result = (Type)SoapServices._xmlTypes[xmlType + " " + xmlTypeNamespace];
			}
			return result;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x000C6084 File Offset: 0x000C4284
		private static string GetAssemblyName(MethodBase mb)
		{
			if (mb.DeclaringType.Assembly == typeof(object).Assembly)
			{
				return string.Empty;
			}
			return mb.DeclaringType.Assembly.GetName().Name;
		}

		/// <summary>Возвращает значение SOAPAction, связанное с методом, указанным в данном <see cref="T:System.Reflection.MethodBase" />.</summary>
		/// <param name="mb">
		///   <see cref="T:System.Reflection.MethodBase" /> содержащий метод для которого запрашивается SOAPAction.</param>
		/// <returns>Значение SOAPAction, связанное с методом, указанным в данном <see cref="T:System.Reflection.MethodBase" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036DC RID: 14044 RVA: 0x000C60C2 File Offset: 0x000C42C2
		public static string GetSoapActionFromMethodBase(MethodBase mb)
		{
			return SoapServices.InternalGetSoapAction(mb);
		}

		/// <summary>Определяет тип и имя метода, связанного с указанным значением SOAPAction.</summary>
		/// <param name="soapAction">SOAPAction метода, для которого запрошены тип и имя метода.</param>
		/// <param name="typeName">Когда возвращается этот метод, он содержит <see cref="T:System.String" />, в которой находится имя типа метода в вопросе. Этот параметр передается неинициализированным.</param>
		/// <param name="methodName">Когда возвращается этот метод, он содержит <see cref="T:System.String" />, в которой находится имя метода в вопросе. Этот параметр передается неинициализированным.</param>
		/// <returns>
		///   <see langword="true" />, если тип и имя метода восстановлены успешно; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Значение SOAPAction не начинается и не заканчивается кавычками.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036DD RID: 14045 RVA: 0x000C60CC File Offset: 0x000C42CC
		public static bool GetTypeAndMethodNameFromSoapAction(string soapAction, out string typeName, out string methodName)
		{
			object syncRoot = SoapServices._soapActions.SyncRoot;
			lock (syncRoot)
			{
				MethodBase methodBase = (MethodBase)SoapServices._soapActionsMethods[soapAction];
				if (methodBase != null)
				{
					typeName = methodBase.DeclaringType.AssemblyQualifiedName;
					methodName = methodBase.Name;
					return true;
				}
			}
			typeName = null;
			methodName = null;
			int num = soapAction.LastIndexOf('#');
			if (num == -1)
			{
				return false;
			}
			methodName = soapAction.Substring(num + 1);
			string str;
			string text;
			if (!SoapServices.DecodeXmlNamespaceForClrTypeNamespace(soapAction.Substring(0, num), out str, out text))
			{
				return false;
			}
			if (text == null)
			{
				typeName = str + ", " + typeof(object).Assembly.GetName().Name;
			}
			else
			{
				typeName = str + ", " + text;
			}
			return true;
		}

		/// <summary>Возвращается сведения об XML-элементе, который следует использовать при упорядочении данного типа.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, для которого запрашиваются имена XML-элементов и пространства имен.</param>
		/// <param name="xmlElement">Когда этот метод возвращается, то он содержит <see cref="T:System.String" />, в котором находится имя XML-элемента указанного типа объекта. Этот параметр передается неинициализированным.</param>
		/// <param name="xmlNamespace">Когда этот метод возвращается, то он содержит <see cref="T:System.String" />, в котором находится имя XML пространства имен указанного типа объекта. Этот параметр передается неинициализированным.</param>
		/// <returns>
		///   <see langword="true" />, если запрошенные значения маркированы <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036DE RID: 14046 RVA: 0x000C61B8 File Offset: 0x000C43B8
		public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace)
		{
			SoapTypeAttribute soapTypeAttribute = (SoapTypeAttribute)InternalRemotingServices.GetCachedSoapAttribute(type);
			if (!soapTypeAttribute.IsInteropXmlElement)
			{
				xmlElement = null;
				xmlNamespace = null;
				return false;
			}
			xmlElement = soapTypeAttribute.XmlElementName;
			xmlNamespace = soapTypeAttribute.XmlNamespace;
			return true;
		}

		/// <summary>Извлекает пространство имен XML, используемое во время удаленных вызовов, указанных в данном <see cref="T:System.Reflection.MethodBase" />.</summary>
		/// <param name="mb">
		///   <see cref="T:System.Reflection.MethodBase" /> метода, для которого запрашивается пространство имен XML.</param>
		/// <returns>Пространство имен XML используется во время удаленных вызовов указанного метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036DF RID: 14047 RVA: 0x000C61F2 File Offset: 0x000C43F2
		public static string GetXmlNamespaceForMethodCall(MethodBase mb)
		{
			return SoapServices.CodeXmlNamespaceForClrTypeNamespace(mb.DeclaringType.FullName, SoapServices.GetAssemblyName(mb));
		}

		/// <summary>Извлекает пространство имен XML, используемое во время создания ответов на удаленный вызов метода, указанный в данном <see cref="T:System.Reflection.MethodBase" />.</summary>
		/// <param name="mb">
		///   <see cref="T:System.Reflection.MethodBase" /> метода, для которого запрашивается пространство имен XML.</param>
		/// <returns>XML пространство имен используется во время создания ответов на вызов удаленного метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E0 RID: 14048 RVA: 0x000C61F2 File Offset: 0x000C43F2
		public static string GetXmlNamespaceForMethodResponse(MethodBase mb)
		{
			return SoapServices.CodeXmlNamespaceForClrTypeNamespace(mb.DeclaringType.FullName, SoapServices.GetAssemblyName(mb));
		}

		/// <summary>Возвращает сведения о XML-типе, который следует использовать при упорядочении данного <see cref="T:System.Type" />.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, для которого запрашиваются имена XML-элементов и пространства имен.</param>
		/// <param name="xmlType">XML-тип указанного объекта <see cref="T:System.Type" />.</param>
		/// <param name="xmlTypeNamespace">Пространство имен XML-типа указанного объекта <see cref="T:System.Type" />.</param>
		/// <returns>
		///   <see langword="true" />, если запрошенные значения маркированы <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E1 RID: 14049 RVA: 0x000C620C File Offset: 0x000C440C
		public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace)
		{
			SoapTypeAttribute soapTypeAttribute = (SoapTypeAttribute)InternalRemotingServices.GetCachedSoapAttribute(type);
			if (!soapTypeAttribute.IsInteropXmlType)
			{
				xmlType = null;
				xmlTypeNamespace = null;
				return false;
			}
			xmlType = soapTypeAttribute.XmlTypeName;
			xmlTypeNamespace = soapTypeAttribute.XmlTypeNamespace;
			return true;
		}

		/// <summary>Возвращает логическое значение, указывающее, является ли пространство имен присущим данному объекту для общеязыковой среды выполнения.</summary>
		/// <param name="namespaceString">Проверяемое пространство имен общеязыковой среды выполнения.</param>
		/// <returns>
		///   <see langword="true" />, если данное пространство имен является присущим данному объекту для общеязыковой среды выполнения; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E2 RID: 14050 RVA: 0x000C6246 File Offset: 0x000C4446
		public static bool IsClrTypeNamespace(string namespaceString)
		{
			return namespaceString.StartsWith(SoapServices.XmlNsForClrType);
		}

		/// <summary>Определяет, приемлем ли SOAPAction для данного <see cref="T:System.Reflection.MethodBase" />.</summary>
		/// <param name="soapAction">SOAPAction, проверяемый по <see cref="T:System.Reflection.MethodBase" />.</param>
		/// <param name="mb">
		///   <see cref="T:System.Reflection.MethodBase" />, по которому проверяется SOAPAction.</param>
		/// <returns>
		///   <see langword="true" />, если указанный SOAPAction приемлем для данного <see cref="T:System.Reflection.MethodBase" />; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E3 RID: 14051 RVA: 0x000C6254 File Offset: 0x000C4454
		public static bool IsSoapActionValidForMethodBase(string soapAction, MethodBase mb)
		{
			string a;
			string a2;
			SoapServices.GetTypeAndMethodNameFromSoapAction(soapAction, out a, out a2);
			if (a2 != mb.Name)
			{
				return false;
			}
			string assemblyQualifiedName = mb.DeclaringType.AssemblyQualifiedName;
			return a == assemblyQualifiedName;
		}

		/// <summary>Предварительно загружает каждый тип <see cref="T:System.Type" />, найденный в указанной сборке <see cref="T:System.Reflection.Assembly" /> из сведений, указанных в <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />, связанном с каждым типом.</summary>
		/// <param name="assembly">
		///   <see cref="T:System.Reflection.Assembly" />, для каждого типа, который вызывается <see cref="M:System.Runtime.Remoting.SoapServices.PreLoad(System.Type)" />.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E4 RID: 14052 RVA: 0x000C6290 File Offset: 0x000C4490
		public static void PreLoad(Assembly assembly)
		{
			Type[] types = assembly.GetTypes();
			for (int i = 0; i < types.Length; i++)
			{
				SoapServices.PreLoad(types[i]);
			}
		}

		/// <summary>Предварительно загружает данный тип <see cref="T:System.Type" />, основанный на значениях, заданных в <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" /> на типе.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> для предварительной загрузки.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E5 RID: 14053 RVA: 0x000C62BC File Offset: 0x000C44BC
		public static void PreLoad(Type type)
		{
			SoapServices.TypeInfo typeInfo = SoapServices._typeInfos[type] as SoapServices.TypeInfo;
			if (typeInfo != null)
			{
				return;
			}
			string text;
			string text2;
			if (SoapServices.GetXmlTypeForInteropType(type, out text, out text2))
			{
				SoapServices.RegisterInteropXmlType(text, text2, type);
			}
			if (SoapServices.GetXmlElementForInteropType(type, out text, out text2))
			{
				SoapServices.RegisterInteropXmlElement(text, text2, type);
			}
			object syncRoot = SoapServices._typeInfos.SyncRoot;
			lock (syncRoot)
			{
				typeInfo = new SoapServices.TypeInfo();
				foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
				{
					SoapFieldAttribute soapFieldAttribute = (SoapFieldAttribute)InternalRemotingServices.GetCachedSoapAttribute(fieldInfo);
					if (soapFieldAttribute.IsInteropXmlElement())
					{
						string nameKey = SoapServices.GetNameKey(soapFieldAttribute.XmlElementName, soapFieldAttribute.XmlNamespace);
						if (soapFieldAttribute.UseAttribute)
						{
							if (typeInfo.Attributes == null)
							{
								typeInfo.Attributes = new Hashtable();
							}
							typeInfo.Attributes[nameKey] = fieldInfo;
						}
						else
						{
							if (typeInfo.Elements == null)
							{
								typeInfo.Elements = new Hashtable();
							}
							typeInfo.Elements[nameKey] = fieldInfo;
						}
					}
				}
				SoapServices._typeInfos[type] = typeInfo;
			}
		}

		/// <summary>Связывает данное имя элемента XML и пространство имен с типом среды выполнения, который следует использовать при десериализации.</summary>
		/// <param name="xmlElement">Имя XML-элемента, используемое при десериализации.</param>
		/// <param name="xmlNamespace">Пространство имен XML, используемое при десериализации.</param>
		/// <param name="type">Тип <see cref="T:System.Type" /> среды выполнения, используемый при десериализации.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E6 RID: 14054 RVA: 0x000C63F0 File Offset: 0x000C45F0
		public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
		{
			object syncRoot = SoapServices._xmlElements.SyncRoot;
			lock (syncRoot)
			{
				SoapServices._xmlElements[xmlElement + " " + xmlNamespace] = type;
			}
		}

		/// <summary>Связывает данное имя XML-типа и пространство имен с типом среды выполнения, который следует использовать при десериализации.</summary>
		/// <param name="xmlType">XML-тип, используемый при десериализации.</param>
		/// <param name="xmlTypeNamespace">Пространство имен XML, используемое при десериализации.</param>
		/// <param name="type">Тип <see cref="T:System.Type" /> среды выполнения, используемый при десериализации.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E7 RID: 14055 RVA: 0x000C6448 File Offset: 0x000C4648
		public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
		{
			object syncRoot = SoapServices._xmlTypes.SyncRoot;
			lock (syncRoot)
			{
				SoapServices._xmlTypes[xmlType + " " + xmlTypeNamespace] = type;
			}
		}

		/// <summary>Связывает указанный <see cref="T:System.Reflection.MethodBase" /> с кэшированным в нем SOAPAction.</summary>
		/// <param name="mb">
		///   <see cref="T:System.Reflection.MethodBase" /> метода, чтобы установить с SOAPAction, кэшированного с ним.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036E8 RID: 14056 RVA: 0x000C64A0 File Offset: 0x000C46A0
		public static void RegisterSoapActionForMethodBase(MethodBase mb)
		{
			SoapServices.InternalGetSoapAction(mb);
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x000C64AC File Offset: 0x000C46AC
		private static string InternalGetSoapAction(MethodBase mb)
		{
			object syncRoot = SoapServices._soapActions.SyncRoot;
			string result;
			lock (syncRoot)
			{
				string text = (string)SoapServices._soapActions[mb];
				if (text == null)
				{
					text = ((SoapMethodAttribute)InternalRemotingServices.GetCachedSoapAttribute(mb)).SoapAction;
					SoapServices._soapActions[mb] = text;
					SoapServices._soapActionsMethods[text] = mb;
				}
				result = text;
			}
			return result;
		}

		/// <summary>Связывает обеспеченное значение SOAPAction с заданным <see cref="T:System.Reflection.MethodBase" /> для использования в приемниках каналов.</summary>
		/// <param name="mb">
		///   <see cref="T:System.Reflection.MethodBase" /> для установления связи с предоставленным SOAPAction.</param>
		/// <param name="soapAction">Значение SOAPAction для связи с заданным <see cref="T:System.Reflection.MethodBase" />.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060036EA RID: 14058 RVA: 0x000C652C File Offset: 0x000C472C
		public static void RegisterSoapActionForMethodBase(MethodBase mb, string soapAction)
		{
			object syncRoot = SoapServices._soapActions.SyncRoot;
			lock (syncRoot)
			{
				SoapServices._soapActions[mb] = soapAction;
				SoapServices._soapActionsMethods[soapAction] = mb;
			}
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x000C6584 File Offset: 0x000C4784
		private static string EncodeNs(string ns)
		{
			ns = ns.Replace(",", "%2C");
			ns = ns.Replace(" ", "%20");
			return ns.Replace("=", "%3D");
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x000C65BA File Offset: 0x000C47BA
		private static string DecodeNs(string ns)
		{
			ns = ns.Replace("%2C", ",");
			ns = ns.Replace("%20", " ");
			return ns.Replace("%3D", "=");
		}

		// Token: 0x04002561 RID: 9569
		private static Hashtable _xmlTypes = new Hashtable();

		// Token: 0x04002562 RID: 9570
		private static Hashtable _xmlElements = new Hashtable();

		// Token: 0x04002563 RID: 9571
		private static Hashtable _soapActions = new Hashtable();

		// Token: 0x04002564 RID: 9572
		private static Hashtable _soapActionsMethods = new Hashtable();

		// Token: 0x04002565 RID: 9573
		private static Hashtable _typeInfos = new Hashtable();

		// Token: 0x02000575 RID: 1397
		private class TypeInfo
		{
			// Token: 0x04002566 RID: 9574
			public Hashtable Attributes;

			// Token: 0x04002567 RID: 9575
			public Hashtable Elements;
		}
	}
}
