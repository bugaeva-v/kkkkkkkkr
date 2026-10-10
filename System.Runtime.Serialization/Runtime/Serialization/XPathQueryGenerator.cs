using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Xml;

namespace System.Runtime.Serialization
{
	/// <summary>Если заданы класс, представляющий контракт данных, и метаданные, представляющие участника контракта, создает запрос XPath для участника.</summary>
	// Token: 0x02000130 RID: 304
	public static class XPathQueryGenerator
	{
		/// <summary>Создает XPath из контракта данных, используя заданный тип контракта данных, массив элементов метаданных и пространства имен.</summary>
		/// <param name="type">Тип, представляющий контракт данных.</param>
		/// <param name="pathToMember">Метаданные, сформированные с использованием метода <see cref="Overload:System.Type.GetMember" /> класса <see cref="T:System.Type" />, указывающего определенный элемент данных, использованный для формирования запроса.</param>
		/// <param name="namespaces">Пространства имен XML и их префиксы, встречающиеся в контракте данных.</param>
		/// <returns>
		///   <see cref="T:System.String" />  
		///
		/// XPath, созданный из типа и данных члена.</returns>
		// Token: 0x06000F02 RID: 3842 RVA: 0x0003CD5C File Offset: 0x0003AF5C
		public static string CreateFromDataContractSerializer(Type type, MemberInfo[] pathToMember, out XmlNamespaceManager namespaces)
		{
			return XPathQueryGenerator.CreateFromDataContractSerializer(type, pathToMember, null, out namespaces);
		}

		/// <summary>Создает XPath из контракта данных, используя заданный тип контракта данных, массив элементов метаданных, элемент верхнего уровня и пространства имен.</summary>
		/// <param name="type">Тип, представляющий контракт данных.</param>
		/// <param name="pathToMember">Метаданные, сформированные с использованием метода <see cref="Overload:System.Type.GetMember" /> класса <see cref="T:System.Type" />, указывающего определенный элемент данных, использованный для формирования запроса.</param>
		/// <param name="rootElementXpath">Элемент верхнего уровня в xpath.</param>
		/// <param name="namespaces">Пространства имен XML и их префиксы, встречающиеся в контракте данных.</param>
		/// <returns>
		///   <see cref="T:System.String" />  
		///
		/// XPath, созданный из типа и данных члена.</returns>
		// Token: 0x06000F03 RID: 3843 RVA: 0x0003CD68 File Offset: 0x0003AF68
		public static string CreateFromDataContractSerializer(Type type, MemberInfo[] pathToMember, StringBuilder rootElementXpath, out XmlNamespaceManager namespaces)
		{
			if (type == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("type"));
			}
			if (pathToMember == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("pathToMember"));
			}
			DataContract dataContract = DataContract.GetDataContract(type);
			XPathQueryGenerator.ExportContext exportContext;
			if (rootElementXpath == null)
			{
				exportContext = new XPathQueryGenerator.ExportContext(dataContract);
			}
			else
			{
				exportContext = new XPathQueryGenerator.ExportContext(rootElementXpath);
			}
			for (int i = 0; i < pathToMember.Length; i++)
			{
				dataContract = XPathQueryGenerator.ProcessDataContract(dataContract, exportContext, pathToMember[i]);
			}
			namespaces = exportContext.Namespaces;
			return exportContext.XPath;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0003CDE2 File Offset: 0x0003AFE2
		private static DataContract ProcessDataContract(DataContract contract, XPathQueryGenerator.ExportContext context, MemberInfo memberNode)
		{
			if (contract is ClassDataContract)
			{
				return XPathQueryGenerator.ProcessClassDataContract((ClassDataContract)contract, context, memberNode);
			}
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("The path to member was not found for XPath query generator.")));
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0003CE10 File Offset: 0x0003B010
		private static DataContract ProcessClassDataContract(ClassDataContract contract, XPathQueryGenerator.ExportContext context, MemberInfo memberNode)
		{
			string prefix = context.SetNamespace(contract.Namespace.Value);
			foreach (DataMember dataMember in XPathQueryGenerator.GetDataMembers(contract))
			{
				if (dataMember.MemberInfo.Name == memberNode.Name && dataMember.MemberInfo.DeclaringType.IsAssignableFrom(memberNode.DeclaringType))
				{
					context.WriteChildToContext(dataMember, prefix);
					return dataMember.MemberTypeContract;
				}
			}
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("The path to member was not found for XPath query generator.")));
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0003CEC0 File Offset: 0x0003B0C0
		private static IEnumerable<DataMember> GetDataMembers(ClassDataContract contract)
		{
			if (contract.BaseContract != null)
			{
				foreach (DataMember dataMember in XPathQueryGenerator.GetDataMembers(contract.BaseContract))
				{
					yield return dataMember;
				}
				IEnumerator<DataMember> enumerator = null;
			}
			if (contract.Members != null)
			{
				foreach (DataMember dataMember2 in contract.Members)
				{
					yield return dataMember2;
				}
				List<DataMember>.Enumerator enumerator2 = default(List<DataMember>.Enumerator);
			}
			yield break;
			yield break;
		}

		// Token: 0x04000685 RID: 1669
		private const string XPathSeparator = "/";

		// Token: 0x04000686 RID: 1670
		private const string NsSeparator = ":";

		// Token: 0x02000131 RID: 305
		private class ExportContext
		{
			// Token: 0x06000F07 RID: 3847 RVA: 0x0003CED0 File Offset: 0x0003B0D0
			public ExportContext(DataContract rootContract)
			{
				this.namespaces = new XmlNamespaceManager(new NameTable());
				string str = this.SetNamespace(rootContract.TopLevelElementNamespace.Value);
				this.xPathBuilder = new StringBuilder("/" + str + ":" + rootContract.TopLevelElementName.Value);
			}

			// Token: 0x06000F08 RID: 3848 RVA: 0x0003CF2B File Offset: 0x0003B12B
			public ExportContext(StringBuilder rootContractXPath)
			{
				this.namespaces = new XmlNamespaceManager(new NameTable());
				this.xPathBuilder = rootContractXPath;
			}

			// Token: 0x06000F09 RID: 3849 RVA: 0x0003CF4A File Offset: 0x0003B14A
			public void WriteChildToContext(DataMember contextMember, string prefix)
			{
				this.xPathBuilder.Append("/" + prefix + ":" + contextMember.Name);
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0003CF6E File Offset: 0x0003B16E
			public XmlNamespaceManager Namespaces
			{
				get
				{
					return this.namespaces;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0003CF76 File Offset: 0x0003B176
			public string XPath
			{
				get
				{
					return this.xPathBuilder.ToString();
				}
			}

			// Token: 0x06000F0C RID: 3852 RVA: 0x0003CF84 File Offset: 0x0003B184
			public string SetNamespace(string ns)
			{
				string text = this.namespaces.LookupPrefix(ns);
				if (text == null || text.Length == 0)
				{
					string str = "xg";
					int num = this.nextPrefix;
					this.nextPrefix = num + 1;
					text = str + num.ToString(NumberFormatInfo.InvariantInfo);
					this.Namespaces.AddNamespace(text, ns);
				}
				return text;
			}

			// Token: 0x04000687 RID: 1671
			private XmlNamespaceManager namespaces;

			// Token: 0x04000688 RID: 1672
			private int nextPrefix;

			// Token: 0x04000689 RID: 1673
			private StringBuilder xPathBuilder;
		}
	}
}
