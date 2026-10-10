using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000163 RID: 355
	public abstract class XmlNodeAccessor : XmlAccessor, IXmlKnownType, IXmlIdentity, IXmlKnownTypeMap
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00019E90 File Offset: 0x00018090
		protected XmlNodeAccessor(Type type, IXmlContext context) : this(context.GetDefaultXsiType(type).LocalName, type, context)
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00019EB4 File Offset: 0x000180B4
		protected XmlNodeAccessor(string name, Type type, IXmlContext context) : base(type, context)
		{
			if (name == null)
			{
				throw Error.ArgumentNull("name");
			}
			if (name == string.Empty)
			{
				throw Error.InvalidLocalName();
			}
			this.localName = XmlConvert.EncodeLocalName(name);
			this.namespaceUri = context.ChildNamespaceUri;
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00019F02 File Offset: 0x00018102
		public XmlName Name
		{
			get
			{
				return new XmlName(this.localName, this.namespaceUri);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00019F15 File Offset: 0x00018115
		XmlName IXmlIdentity.XsiType
		{
			get
			{
				return XmlName.Empty;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00019F1C File Offset: 0x0001811C
		protected IXmlKnownTypeMap KnownTypes
		{
			get
			{
				if (this.knownTypes != null)
				{
					return this.knownTypes;
				}
				return this;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00019F2E File Offset: 0x0001812E
		IXmlKnownType IXmlKnownTypeMap.Default
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00019F31 File Offset: 0x00018131
		public bool TryGet(IXmlIdentity xmlName, out IXmlKnownType knownType)
		{
			if (!this.IsMatch(xmlName))
			{
				return Try.Failure<IXmlKnownType>(out knownType);
			}
			return Try.Success<IXmlKnownType>(out knownType, this);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00019F4A File Offset: 0x0001814A
		public bool TryGet(Type clrType, out IXmlKnownType knownType)
		{
			if (!this.IsMatch(clrType))
			{
				return Try.Failure<IXmlKnownType>(out knownType);
			}
			return Try.Success<IXmlKnownType>(out knownType, this);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00019F64 File Offset: 0x00018164
		protected virtual bool IsMatch(IXmlIdentity xmlIdentity)
		{
			return XmlNodeAccessor.NameComparer.Equals(this.localName, xmlIdentity.Name.LocalName) && this.IsMatchOnNamespaceUri(xmlIdentity) && this.IsMatchOnXsiType(xmlIdentity);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00019FA4 File Offset: 0x000181A4
		private bool IsMatchOnNamespaceUri(IXmlIdentity xmlIdentity)
		{
			string y = xmlIdentity.Name.NamespaceUri;
			if (base.Context.IsReservedNamespaceUri(y))
			{
				return XmlNodeAccessor.NameComparer.Equals(this.namespaceUri, y);
			}
			return this.namespaceUri == null || this.ShouldIgnoreAttributeNamespaceUri(xmlIdentity) || XmlNodeAccessor.NameComparer.Equals(this.namespaceUri, y);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0001A004 File Offset: 0x00018204
		private bool IsMatchOnXsiType(IXmlIdentity xmlIdentity)
		{
			XmlName xsiType = xmlIdentity.XsiType;
			return xsiType == XmlName.Empty || xsiType == base.XsiType;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0001A034 File Offset: 0x00018234
		private bool ShouldIgnoreAttributeNamespaceUri(IXmlIdentity xmlName)
		{
			IXmlNode xmlNode = xmlName as IXmlNode;
			return xmlNode != null && xmlNode.IsAttribute && (this.state & XmlAccessor.States.ConfiguredNamespaceUri) == (XmlAccessor.States)0;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0001A061 File Offset: 0x00018261
		protected virtual bool IsMatch(Type clrType)
		{
			return clrType == base.ClrType || (base.Serializer.Kind == XmlTypeKind.Collection && typeof(IEnumerable).IsAssignableFrom(clrType));
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0001A093 File Offset: 0x00018293
		protected void ConfigureLocalName(string localName)
		{
			this.ConfigureField(ref this.localName, localName, XmlAccessor.States.ConfiguredLocalName);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0001A0A4 File Offset: 0x000182A4
		protected void ConfigureNamespaceUri(string namespaceUri)
		{
			this.ConfigureField(ref this.namespaceUri, namespaceUri, XmlAccessor.States.ConfiguredNamespaceUri);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0001A0B5 File Offset: 0x000182B5
		private void ConfigureField(ref string field, string value, XmlAccessor.States mask)
		{
			if (string.IsNullOrEmpty(value))
			{
				return;
			}
			if ((this.state & mask) != (XmlAccessor.States)0)
			{
				throw Error.AttributeConflict(this.localName);
			}
			field = value;
			this.state |= mask;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0001A0E7 File Offset: 0x000182E7
		protected void ConfigureKnownTypesFromParent(XmlNodeAccessor accessor)
		{
			if (this.knownTypes != null)
			{
				throw Error.AttributeConflict(this.localName);
			}
			this.knownTypes = accessor.knownTypes;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001A10C File Offset: 0x0001830C
		protected void ConfigureKnownTypesFromAttributes<T>(IEnumerable<T> attributes, IXmlBehaviorSemantics<T> semantics)
		{
			foreach (T behavior in attributes)
			{
				Type clrType = semantics.GetClrType(behavior);
				if (clrType != null)
				{
					XmlName defaultXsiType = base.Context.GetDefaultXsiType(clrType);
					XmlName name = new XmlName(semantics.GetLocalName(behavior).NonEmpty() ?? defaultXsiType.LocalName, semantics.GetNamespaceUri(behavior) ?? this.namespaceUri);
					this.AddKnownType(name, defaultXsiType, clrType, true);
				}
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0001A1A8 File Offset: 0x000183A8
		public override void Prepare()
		{
			if (this.knownTypes == null)
			{
				this.ConfigureIncludedTypes(this);
				return;
			}
			this.ConfigureDefaultAndIncludedTypes();
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0001A1C0 File Offset: 0x000183C0
		private void ConfigureDefaultAndIncludedTypes()
		{
			IXmlKnownType[] array = this.knownTypes.ToArray();
			this.knownTypes.AddXsiTypeDefaults();
			foreach (IXmlKnownType knownType in array)
			{
				this.ConfigureIncludedTypes(knownType);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0001A200 File Offset: 0x00018400
		private void ConfigureIncludedTypes(IXmlKnownType knownType)
		{
			foreach (IXmlIncludedType xmlIncludedType in base.Context.GetIncludedTypes(knownType.ClrType))
			{
				this.AddKnownType(knownType.Name, xmlIncludedType.XsiType, xmlIncludedType.ClrType, false);
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0001A26C File Offset: 0x0001846C
		private void AddKnownType(XmlName name, XmlName xsiType, Type clrType, bool overwrite)
		{
			if (this.knownTypes == null)
			{
				this.knownTypes = new XmlKnownTypeSet(base.ClrType);
				this.AddSelfAsKnownType();
			}
			this.knownTypes.Add(new XmlKnownType(name, xsiType, clrType), overwrite);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0001A2A4 File Offset: 0x000184A4
		private void AddSelfAsKnownType()
		{
			XmlAccessor.States states = XmlAccessor.States.ConfiguredLocalName | XmlAccessor.States.ConfiguredNamespaceUri | XmlAccessor.States.ConfiguredKnownTypes;
			if ((this.state & states) != XmlAccessor.States.ConfiguredKnownTypes)
			{
				this.knownTypes.Add(new XmlKnownType(this.Name, base.XsiType, base.ClrType), true);
				this.knownTypes.Add(new XmlKnownType(this.Name, XmlName.Empty, base.ClrType), true);
			}
		}

		// Token: 0x04000243 RID: 579
		private string localName;

		// Token: 0x04000244 RID: 580
		private string namespaceUri;

		// Token: 0x04000245 RID: 581
		private XmlKnownTypeSet knownTypes;

		// Token: 0x04000246 RID: 582
		protected static readonly StringComparer NameComparer = StringComparer.OrdinalIgnoreCase;
	}
}
