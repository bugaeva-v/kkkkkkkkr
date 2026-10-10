using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000155 RID: 341
	public class XmlMetadata : IXmlKnownType, IXmlIdentity, IXmlKnownTypeMap, IXmlIncludedType, IXmlIncludedTypeMap
	{
		// Token: 0x060009C6 RID: 2502 RVA: 0x00018650 File Offset: 0x00016850
		public XmlMetadata(DictionaryAdapterMeta meta, IEnumerable<string> reservedNamespaceUris)
		{
			if (meta == null)
			{
				throw Error.ArgumentNull("meta");
			}
			if (reservedNamespaceUris == null)
			{
				throw Error.ArgumentNull("reservedNamespaceUris");
			}
			this.source = meta;
			this.clrType = meta.Type;
			this.context = new XmlContext(this);
			this.includedTypes = new XmlIncludedTypeSet();
			this.reservedNamespaceUris = ((reservedNamespaceUris as HashSet<string>) ?? new HashSet<string>(reservedNamespaceUris));
			XmlRootAttribute xmlRootAttribute = null;
			XmlTypeAttribute xmlTypeAttribute = null;
			XmlDefaultsAttribute xmlDefaultsAttribute = null;
			XmlIncludeAttribute attribute = null;
			XmlNamespaceAttribute attribute2 = null;
			ReferenceAttribute referenceAttribute = null;
			XPathAttribute xpathAttribute = null;
			XPathVariableAttribute attribute3 = null;
			XPathFunctionAttribute attribute4 = null;
			foreach (object obj in meta.Behaviors)
			{
				if (!XmlMetadata.TryCast<XmlRootAttribute>(obj, ref xmlRootAttribute) && !XmlMetadata.TryCast<XmlTypeAttribute>(obj, ref xmlTypeAttribute) && !XmlMetadata.TryCast<XmlDefaultsAttribute>(obj, ref xmlDefaultsAttribute))
				{
					if (XmlMetadata.TryCast<XmlIncludeAttribute>(obj, ref attribute))
					{
						this.AddPendingInclude(attribute);
					}
					else if (XmlMetadata.TryCast<XmlNamespaceAttribute>(obj, ref attribute2))
					{
						this.context.AddNamespace(attribute2);
					}
					else if (!XmlMetadata.TryCast<ReferenceAttribute>(obj, ref referenceAttribute) && !XmlMetadata.TryCast<XPathAttribute>(obj, ref xpathAttribute))
					{
						if (XmlMetadata.TryCast<XPathVariableAttribute>(obj, ref attribute3))
						{
							this.context.AddVariable(attribute3);
						}
						else if (XmlMetadata.TryCast<XPathFunctionAttribute>(obj, ref attribute4))
						{
							this.context.AddFunction(attribute4);
						}
					}
				}
			}
			if (xmlDefaultsAttribute != null)
			{
				this.qualified = new bool?(xmlDefaultsAttribute.Qualified);
				this.isNullable = new bool?(xmlDefaultsAttribute.IsNullable);
			}
			if (referenceAttribute != null)
			{
				this.isReference = new bool?(true);
			}
			object name;
			if ((name = ((!meta.HasXmlType()) ? null : meta.GetXmlType().NonEmpty())) == null)
			{
				name = (((xmlTypeAttribute == null) ? null : xmlTypeAttribute.TypeName.NonEmpty()) ?? this.GetDefaultTypeLocalName(this.clrType));
			}
			this.typeLocalName = XmlConvert.EncodeLocalName(name);
			this.rootLocalName = XmlConvert.EncodeLocalName(((xmlRootAttribute == null) ? null : xmlRootAttribute.ElementName.NonEmpty()) ?? this.typeLocalName);
			this.typeNamespaceUri = ((xmlTypeAttribute == null) ? null : xmlTypeAttribute.Namespace);
			this.rootNamespaceUri = ((xmlRootAttribute == null) ? null : xmlRootAttribute.Namespace);
			this.childNamespaceUri = (this.typeNamespaceUri ?? this.rootNamespaceUri);
			if (xpathAttribute != null)
			{
				this.path = xpathAttribute.GetPath;
				this.path.SetContext(this.context);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00018898 File Offset: 0x00016A98
		public Type ClrType
		{
			get
			{
				return this.clrType;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x000188A0 File Offset: 0x00016AA0
		public bool? Qualified
		{
			get
			{
				return this.qualified;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000188A8 File Offset: 0x00016AA8
		public bool? IsNullable
		{
			get
			{
				return this.isNullable;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000188B0 File Offset: 0x00016AB0
		public bool? IsReference
		{
			get
			{
				return this.isReference;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000188B8 File Offset: 0x00016AB8
		public XmlName Name
		{
			get
			{
				return new XmlName(this.rootLocalName, this.rootNamespaceUri);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x000188CB File Offset: 0x00016ACB
		public XmlName XsiType
		{
			get
			{
				return new XmlName(this.typeLocalName, this.typeNamespaceUri);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x000188DE File Offset: 0x00016ADE
		XmlName IXmlIdentity.XsiType
		{
			get
			{
				return XmlName.Empty;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x000188E5 File Offset: 0x00016AE5
		public string ChildNamespaceUri
		{
			get
			{
				return this.childNamespaceUri;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x000188ED File Offset: 0x00016AED
		public IEnumerable<string> ReservedNamespaceUris
		{
			get
			{
				return this.reservedNamespaceUris.ToArray<string>();
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x000188FA File Offset: 0x00016AFA
		public XmlIncludedTypeSet IncludedTypes
		{
			get
			{
				this.ProcessPendingIncludes();
				return this.includedTypes;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00018908 File Offset: 0x00016B08
		public IXmlContext Context
		{
			get
			{
				return this.context;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00018910 File Offset: 0x00016B10
		public CompiledXPath Path
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00018918 File Offset: 0x00016B18
		IXmlKnownType IXmlKnownTypeMap.Default
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0001891B File Offset: 0x00016B1B
		IXmlIncludedType IXmlIncludedTypeMap.Default
		{
			get
			{
				return this;
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001891E File Offset: 0x00016B1E
		public bool IsReservedNamespaceUri(string namespaceUri)
		{
			return this.reservedNamespaceUris.Contains(namespaceUri);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001892C File Offset: 0x00016B2C
		public IXmlCursor SelectBase(IXmlNode node)
		{
			if (this.path != null)
			{
				return node.Select(this.path, this, this.context, CursorFlags.Elements | CursorFlags.Mutable);
			}
			return node.SelectChildren(this, this.context, CursorFlags.Elements | CursorFlags.Mutable);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0001895C File Offset: 0x00016B5C
		private bool IsMatch(IXmlIdentity xmlIdentity)
		{
			XmlName name = xmlIdentity.Name;
			return XmlMetadata.NameComparer.Equals(this.rootLocalName, name.LocalName) && (this.rootNamespaceUri == null || XmlMetadata.NameComparer.Equals(this.rootNamespaceUri, name.NamespaceUri));
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000189AC File Offset: 0x00016BAC
		private bool IsMatch(Type clrType)
		{
			return clrType == this.clrType;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000189BA File Offset: 0x00016BBA
		public bool TryGet(IXmlIdentity xmlIdentity, out IXmlKnownType knownType)
		{
			if (!this.IsMatch(xmlIdentity))
			{
				return Try.Failure<IXmlKnownType>(out knownType);
			}
			return Try.Success<IXmlKnownType>(out knownType, this);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000189D3 File Offset: 0x00016BD3
		public bool TryGet(Type clrType, out IXmlKnownType knownType)
		{
			if (!this.IsMatch(clrType))
			{
				return Try.Failure<IXmlKnownType>(out knownType);
			}
			return Try.Success<IXmlKnownType>(out knownType, this);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000189EC File Offset: 0x00016BEC
		public bool TryGet(XmlName xsiType, out IXmlIncludedType includedType)
		{
			if (!(xsiType == XmlName.Empty) && !(xsiType == this.XsiType))
			{
				return Try.Failure<IXmlIncludedType>(out includedType);
			}
			return Try.Success<IXmlIncludedType>(out includedType, this);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00018A17 File Offset: 0x00016C17
		public bool TryGet(Type clrType, out IXmlIncludedType includedType)
		{
			if (!(clrType == this.clrType))
			{
				return Try.Failure<IXmlIncludedType>(out includedType);
			}
			return Try.Success<IXmlIncludedType>(out includedType, this);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00018A35 File Offset: 0x00016C35
		private void AddPendingInclude(XmlIncludeAttribute attribute)
		{
			if (this.pendingIncludes == null)
			{
				this.pendingIncludes = new List<Type>();
			}
			this.pendingIncludes.Add(attribute.Type);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00018A5C File Offset: 0x00016C5C
		private void ProcessPendingIncludes()
		{
			List<Type> list = this.pendingIncludes;
			this.pendingIncludes = null;
			if (list == null)
			{
				return;
			}
			foreach (Type type in list)
			{
				XmlIncludedType includedType = new XmlIncludedType(this.GetDefaultXsiType(type), type);
				this.includedTypes.Add(includedType);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00018AD0 File Offset: 0x00016CD0
		public XmlName GetDefaultXsiType(Type clrType)
		{
			if (clrType == this.clrType)
			{
				return this.XsiType;
			}
			IXmlIncludedType xmlIncludedType;
			if (this.includedTypes.TryGet(clrType, out xmlIncludedType))
			{
				return xmlIncludedType.XsiType;
			}
			XmlTypeKind kind = XmlTypeSerializer.For(clrType).Kind;
			if (kind != XmlTypeKind.Complex)
			{
				if (kind == XmlTypeKind.Collection)
				{
					Type collectionItemType = clrType.GetCollectionItemType();
					return new XmlName("ArrayOf" + this.GetDefaultXsiType(collectionItemType).LocalName, null);
				}
			}
			else if (clrType.GetTypeInfo().IsInterface)
			{
				return this.GetXmlMetadata(clrType).XsiType;
			}
			return new XmlName(clrType.Name, null);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00018B6C File Offset: 0x00016D6C
		public IEnumerable<IXmlIncludedType> GetIncludedTypes(Type baseType)
		{
			Queue<XmlMetadata> queue = new Queue<XmlMetadata>();
			HashSet<Type> visited = new HashSet<Type>();
			visited.Add(baseType);
			XmlMetadata xmlMetadata;
			if (this.TryGetXmlMetadata(baseType, out xmlMetadata))
			{
				queue.Enqueue(xmlMetadata);
			}
			xmlMetadata = this;
			for (;;)
			{
				foreach (IXmlIncludedType xmlIncludedType in xmlMetadata.IncludedTypes)
				{
					Type clrType = xmlIncludedType.ClrType;
					if (baseType != clrType && baseType.IsAssignableFrom(clrType) && visited.Add(clrType))
					{
						yield return xmlIncludedType;
						if (this.TryGetXmlMetadata(clrType, out xmlMetadata))
						{
							queue.Enqueue(xmlMetadata);
						}
						clrType = null;
					}
				}
				IEnumerator<IXmlIncludedType> enumerator = null;
				if (queue.Count == 0)
				{
					break;
				}
				xmlMetadata = queue.Dequeue();
			}
			yield break;
			yield break;
			yield break;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00018B83 File Offset: 0x00016D83
		private bool TryGetXmlMetadata(Type clrType, out XmlMetadata metadata)
		{
			if (XmlTypeSerializer.For(clrType).Kind != XmlTypeKind.Complex || !clrType.GetTypeInfo().IsInterface)
			{
				return Try.Failure<XmlMetadata>(out metadata);
			}
			return Try.Success<XmlMetadata>(out metadata, this.GetXmlMetadata(clrType));
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00018BB4 File Offset: 0x00016DB4
		private XmlMetadata GetXmlMetadata(Type clrType)
		{
			return this.source.GetAdapterMeta(clrType).GetXmlMeta();
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00018BC8 File Offset: 0x00016DC8
		private string GetDefaultTypeLocalName(Type clrType)
		{
			string name = clrType.Name;
			if (!XmlMetadata.IsInterfaceName(name))
			{
				return name;
			}
			return name.Substring(1);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00018BED File Offset: 0x00016DED
		private static bool IsInterfaceName(string name)
		{
			return name.Length > 1 && name[0] == 'I' && char.IsUpper(name, 1);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00018C0C File Offset: 0x00016E0C
		private static bool TryCast<T>(object obj, ref T result) where T : class
		{
			T t = obj as T;
			if (t == null)
			{
				return false;
			}
			result = t;
			return true;
		}

		// Token: 0x0400021B RID: 539
		private readonly Type clrType;

		// Token: 0x0400021C RID: 540
		private readonly bool? qualified;

		// Token: 0x0400021D RID: 541
		private readonly bool? isNullable;

		// Token: 0x0400021E RID: 542
		private readonly bool? isReference;

		// Token: 0x0400021F RID: 543
		private readonly string rootLocalName;

		// Token: 0x04000220 RID: 544
		private readonly string rootNamespaceUri;

		// Token: 0x04000221 RID: 545
		private readonly string childNamespaceUri;

		// Token: 0x04000222 RID: 546
		private readonly string typeLocalName;

		// Token: 0x04000223 RID: 547
		private readonly string typeNamespaceUri;

		// Token: 0x04000224 RID: 548
		private readonly HashSet<string> reservedNamespaceUris;

		// Token: 0x04000225 RID: 549
		private List<Type> pendingIncludes;

		// Token: 0x04000226 RID: 550
		private readonly XmlIncludedTypeSet includedTypes;

		// Token: 0x04000227 RID: 551
		private readonly XmlContext context;

		// Token: 0x04000228 RID: 552
		private readonly DictionaryAdapterMeta source;

		// Token: 0x04000229 RID: 553
		private readonly CompiledXPath path;

		// Token: 0x0400022A RID: 554
		protected static readonly StringComparer NameComparer = StringComparer.OrdinalIgnoreCase;

		// Token: 0x0400022B RID: 555
		private const CursorFlags RootFlags = CursorFlags.Elements | CursorFlags.Mutable;
	}
}
