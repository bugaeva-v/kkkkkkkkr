using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200015C RID: 348
	public abstract class XmlAccessor : IXmlPropertyAccessor, IXmlAccessor, IXmlCollectionAccessor
	{
		// Token: 0x06000A1A RID: 2586 RVA: 0x00019688 File Offset: 0x00017888
		protected XmlAccessor(Type clrType, IXmlContext context)
		{
			if (clrType == null)
			{
				throw Error.ArgumentNull("clrType");
			}
			if (context == null)
			{
				throw Error.ArgumentNull("context");
			}
			clrType = clrType.NonNullable();
			this.clrType = clrType;
			this.xsiType = context.GetDefaultXsiType(clrType);
			this.serializer = XmlTypeSerializer.For(clrType);
			this.context = context;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x000196EC File Offset: 0x000178EC
		public Type ClrType
		{
			get
			{
				return this.clrType;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000196F4 File Offset: 0x000178F4
		public XmlName XsiType
		{
			get
			{
				return this.xsiType;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000196FC File Offset: 0x000178FC
		public XmlTypeSerializer Serializer
		{
			get
			{
				return this.serializer;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00019704 File Offset: 0x00017904
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0001970C File Offset: 0x0001790C
		public IXmlContext Context
		{
			get
			{
				return this.context;
			}
			protected set
			{
				this.SetContext(value);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00019715 File Offset: 0x00017915
		public bool IsCollection
		{
			get
			{
				return this.serializer.Kind == XmlTypeKind.Collection;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00019725 File Offset: 0x00017925
		public virtual bool IsIgnored
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00019728 File Offset: 0x00017928
		public bool IsNillable
		{
			get
			{
				return (this.state & XmlAccessor.States.Nillable) > (XmlAccessor.States)0;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00019735 File Offset: 0x00017935
		public bool IsVolatile
		{
			get
			{
				return (this.state & XmlAccessor.States.Volatile) > (XmlAccessor.States)0;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00019742 File Offset: 0x00017942
		public bool IsReference
		{
			get
			{
				return (this.state & XmlAccessor.States.Reference) > (XmlAccessor.States)0;
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0001974F File Offset: 0x0001794F
		public virtual void ConfigureNillable(bool nillable)
		{
			if (nillable)
			{
				this.state |= XmlAccessor.States.Nillable;
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00019762 File Offset: 0x00017962
		public void ConfigureVolatile(bool isVolatile)
		{
			if (isVolatile)
			{
				this.state |= XmlAccessor.States.Volatile;
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00019775 File Offset: 0x00017975
		public virtual void ConfigureReference(bool isReference)
		{
			if (isReference)
			{
				this.state |= XmlAccessor.States.Reference;
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00019788 File Offset: 0x00017988
		public virtual void Prepare()
		{
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0001978A File Offset: 0x0001798A
		protected IXmlContext CloneContext()
		{
			if ((this.state & XmlAccessor.States.ConfiguredContext) == (XmlAccessor.States)0)
			{
				this.context = this.context.Clone();
				this.state |= XmlAccessor.States.ConfiguredContext;
			}
			return this.context;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000197BB File Offset: 0x000179BB
		private void SetContext(IXmlContext value)
		{
			if (value == null)
			{
				throw Error.ArgumentNull("value");
			}
			this.context = value;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000197D2 File Offset: 0x000179D2
		public virtual bool IsPropertyDefined(IXmlNode parentNode)
		{
			return (this.IsCollection ? this.SelectCollectionNode(parentNode, false) : this.SelectPropertyNode(parentNode, false)).MoveNext();
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000197F4 File Offset: 0x000179F4
		public virtual object GetPropertyValue(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, bool orStub)
		{
			if (orStub)
			{
				orStub &= this.serializer.CanGetStub;
			}
			IXmlCursor xmlCursor = this.IsCollection ? this.SelectCollectionNode(parentNode, orStub) : this.SelectPropertyNode(parentNode, orStub);
			return this.GetValue(xmlCursor, parentObject, references, xmlCursor.MoveNext(), orStub);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00019844 File Offset: 0x00017A44
		public object GetValue(IXmlNode node, IDictionaryAdapter parentObject, XmlReferenceManager references, bool nodeExists, bool orStub)
		{
			object obj;
			if ((nodeExists || orStub) && this.IsReference)
			{
				obj = null;
				object token;
				if (references.OnGetStarting(ref node, ref obj, out token))
				{
					obj = this.GetValueCore(node, parentObject, nodeExists, orStub);
					references.OnGetCompleted(node, obj, token);
				}
			}
			else
			{
				obj = this.GetValueCore(node, parentObject, nodeExists, orStub);
			}
			return obj;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00019896 File Offset: 0x00017A96
		private object GetValueCore(IXmlNode node, IDictionaryAdapter parentObject, bool nodeExists, bool orStub)
		{
			if (nodeExists)
			{
				if (!node.IsNil)
				{
					return this.serializer.GetValue(node, parentObject, this);
				}
				if (this.IsNillable)
				{
					return null;
				}
			}
			if (!orStub)
			{
				return null;
			}
			return this.serializer.GetStub(node, parentObject, this);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000198D0 File Offset: 0x00017AD0
		public virtual void SetPropertyValue(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, object oldValue, ref object value)
		{
			IXmlCursor xmlCursor = this.IsCollection ? this.SelectCollectionNode(parentNode, true) : this.SelectPropertyNode(parentNode, true);
			this.SetValue(xmlCursor, parentObject, references, xmlCursor.MoveNext(), oldValue, ref value);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001990C File Offset: 0x00017B0C
		public virtual void SetValue(IXmlCursor cursor, IDictionaryAdapter parentObject, XmlReferenceManager references, bool hasCurrent, object oldValue, ref object newValue)
		{
			bool flag = newValue != null;
			bool isNillable = this.IsNillable;
			bool isReference = this.IsReference;
			Type type = flag ? newValue.GetComponentType() : this.clrType;
			if (flag || isNillable)
			{
				if (hasCurrent)
				{
					this.Coerce(cursor, type, !flag && cursor.IsAttribute);
				}
				else
				{
					cursor.Create(type);
				}
			}
			else if (!hasCurrent)
			{
				return;
			}
			object token = null;
			if (isReference && !references.OnAssigningValue(cursor, oldValue, ref newValue, out token))
			{
				return;
			}
			object givenValue = newValue;
			if (flag)
			{
				this.serializer.SetValue(cursor, parentObject, this, oldValue, ref newValue);
			}
			else if (isNillable)
			{
				cursor.IsNil = true;
			}
			else
			{
				cursor.Remove();
				cursor.RemoveAllNext();
			}
			if (isReference)
			{
				references.OnAssignedValue(cursor, givenValue, newValue, token);
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000199CA File Offset: 0x00017BCA
		private void Coerce(IXmlCursor cursor, Type clrType, bool replace)
		{
			if (replace)
			{
				cursor.Remove();
				cursor.MoveNext();
				cursor.Create(this.ClrType);
				return;
			}
			cursor.Coerce(clrType);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000199F0 File Offset: 0x00017BF0
		public void GetCollectionItems(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, IList values)
		{
			IXmlCursor xmlCursor = this.SelectCollectionItems(parentNode, false);
			while (xmlCursor.MoveNext())
			{
				object value;
				if (this.IsReference)
				{
					IXmlNode node = xmlCursor;
					value = null;
					object token;
					if (references.OnGetStarting(ref node, ref value, out token))
					{
						value = this.serializer.GetValue(node, parentObject, this);
						references.OnGetCompleted(node, value, token);
					}
				}
				else
				{
					value = this.serializer.GetValue(xmlCursor, parentObject, this);
				}
				values.Add(value);
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00019A5C File Offset: 0x00017C5C
		protected void RemoveCollectionItems(IXmlNode parentNode, XmlReferenceManager references, object value)
		{
			ICollectionProjection collectionProjection = value as ICollectionProjection;
			if (collectionProjection != null)
			{
				collectionProjection.Clear();
				return;
			}
			Type collectionItemType = this.clrType.GetCollectionItemType();
			IXmlCursor xmlCursor = this.GetCollectionAccessor(collectionItemType).SelectCollectionItems(parentNode, true);
			bool isReference = this.IsReference;
			IEnumerable enumerable = value as IEnumerable;
			if (enumerable != null)
			{
				foreach (object oldValue in enumerable)
				{
					if (!xmlCursor.MoveNext())
					{
						break;
					}
					if (isReference)
					{
						references.OnAssigningNull(xmlCursor, oldValue);
					}
				}
			}
			xmlCursor.Reset();
			xmlCursor.RemoveAllNext();
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00019B10 File Offset: 0x00017D10
		public virtual IXmlCollectionAccessor GetCollectionAccessor(Type itemType)
		{
			return this.GetDefaultCollectionAccessor(itemType);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00019B19 File Offset: 0x00017D19
		protected IXmlCollectionAccessor GetDefaultCollectionAccessor(Type itemType)
		{
			XmlDefaultBehaviorAccessor xmlDefaultBehaviorAccessor = new XmlDefaultBehaviorAccessor(itemType, this.Context);
			xmlDefaultBehaviorAccessor.ConfigureNillable(true);
			xmlDefaultBehaviorAccessor.ConfigureReference(this.IsReference);
			return xmlDefaultBehaviorAccessor;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00019B3A File Offset: 0x00017D3A
		public virtual IXmlCursor SelectPropertyNode(IXmlNode parentNode, bool mutable)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00019B41 File Offset: 0x00017D41
		public virtual IXmlCursor SelectCollectionNode(IXmlNode parentNode, bool mutable)
		{
			return this.SelectPropertyNode(parentNode, mutable);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00019B4B File Offset: 0x00017D4B
		public virtual IXmlCursor SelectCollectionItems(IXmlNode parentNode, bool mutable)
		{
			throw Error.NotSupported();
		}

		// Token: 0x04000234 RID: 564
		private readonly Type clrType;

		// Token: 0x04000235 RID: 565
		private readonly XmlName xsiType;

		// Token: 0x04000236 RID: 566
		private readonly XmlTypeSerializer serializer;

		// Token: 0x04000237 RID: 567
		private IXmlContext context;

		// Token: 0x04000238 RID: 568
		protected XmlAccessor.States state;

		// Token: 0x02000214 RID: 532
		[Flags]
		protected enum States
		{
			// Token: 0x04000416 RID: 1046
			Nillable = 1,
			// Token: 0x04000417 RID: 1047
			Volatile = 2,
			// Token: 0x04000418 RID: 1048
			Reference = 4,
			// Token: 0x04000419 RID: 1049
			ConfiguredContext = 8,
			// Token: 0x0400041A RID: 1050
			ConfiguredLocalName = 16,
			// Token: 0x0400041B RID: 1051
			ConfiguredNamespaceUri = 32,
			// Token: 0x0400041C RID: 1052
			ConfiguredKnownTypes = 64
		}
	}
}
