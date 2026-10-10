using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000154 RID: 340
	public class XmlAdapter : DictionaryBehaviorAttribute, IDictionaryInitializer, IDictionaryBehavior, IDictionaryPropertyGetter, IDictionaryPropertySetter, IDictionaryCreateStrategy, IDictionaryCopyStrategy, IDictionaryReferenceManager, IVirtual, IXmlNodeSource
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x00017C8F File Offset: 0x00015E8F
		public XmlAdapter() : this(new XmlDocument())
		{
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00017C9C File Offset: 0x00015E9C
		public XmlAdapter(XmlNode node)
		{
			if (node == null)
			{
				throw Error.ArgumentNull("node");
			}
			this.source = node;
			this.isRoot = true;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00017CC0 File Offset: 0x00015EC0
		public XmlAdapter(IXmlNode node, XmlReferenceManager references)
		{
			if (node == null)
			{
				throw Error.ArgumentNull("node");
			}
			if (references == null)
			{
				throw Error.ArgumentNull("references");
			}
			this.node = node;
			this.references = references;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00017CF2 File Offset: 0x00015EF2
		public bool IsReal
		{
			get
			{
				return this.node != null && this.node.IsReal;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00017D09 File Offset: 0x00015F09
		public IXmlNode Node
		{
			get
			{
				return this.node;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00017D11 File Offset: 0x00015F11
		internal XmlReferenceManager References
		{
			get
			{
				return this.references;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00017D1C File Offset: 0x00015F1C
		object IDictionaryCreateStrategy.Create(IDictionaryAdapter parent, Type type, IDictionary dictionary)
		{
			XmlAdapter adapter = new XmlAdapter(new XmlDocument());
			return parent.CreateChildAdapter(type, adapter, dictionary);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00017D40 File Offset: 0x00015F40
		void IDictionaryInitializer.Initialize(IDictionaryAdapter dictionaryAdapter, object[] behaviors)
		{
			DictionaryAdapterMeta meta = dictionaryAdapter.Meta;
			if (this.primaryXmlMeta == null)
			{
				this.InitializePrimary(meta, dictionaryAdapter);
			}
			else
			{
				this.InitializeSecondary(meta);
			}
			this.InitializeBaseTypes(meta);
			this.InitializeStrategies(dictionaryAdapter);
			this.InitializeReference(dictionaryAdapter);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00017D84 File Offset: 0x00015F84
		private void InitializePrimary(DictionaryAdapterMeta meta, IDictionaryAdapter dictionaryAdapter)
		{
			XmlAdapter.RequireXmlMeta(meta);
			this.primaryXmlMeta = meta.GetXmlMeta();
			if (this.node == null)
			{
				this.node = this.GetBaseNode();
			}
			if (!this.node.IsReal)
			{
				this.node.Realized += this.HandleNodeRealized;
			}
			if (this.references == null)
			{
				this.references = new XmlReferenceManager(this.node, DefaultXmlReferenceFormat.Instance);
			}
			this.InitializeReference(this);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00017E00 File Offset: 0x00016000
		private void InitializeSecondary(DictionaryAdapterMeta meta)
		{
			this.AddSecondaryXmlMeta(meta);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00017E0C File Offset: 0x0001600C
		private void InitializeBaseTypes(DictionaryAdapterMeta meta)
		{
			foreach (Type type in meta.Type.GetInterfaces())
			{
				string @namespace = type.Namespace;
				if (!(@namespace == "Castle.Components.DictionaryAdapter") && !(@namespace == "System.ComponentModel"))
				{
					DictionaryAdapterMeta adapterMeta = meta.GetAdapterMeta(type);
					this.AddSecondaryXmlMeta(adapterMeta);
				}
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00017E6C File Offset: 0x0001606C
		private void InitializeStrategies(IDictionaryAdapter dictionaryAdapter)
		{
			DictionaryAdapterInstance this2 = dictionaryAdapter.This;
			if (this2.CreateStrategy == null)
			{
				this2.CreateStrategy = this;
				this2.AddCopyStrategy(this);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00017E96 File Offset: 0x00016096
		private void InitializeReference(object value)
		{
			if (this.isRoot)
			{
				this.references.Add(this.node, this, value, true);
			}
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00017EB4 File Offset: 0x000160B4
		private void AddSecondaryXmlMeta(DictionaryAdapterMeta meta)
		{
			if (this.secondaryXmlMetas == null)
			{
				this.secondaryXmlMetas = new Dictionary<Type, XmlMetadata>();
			}
			else if (this.secondaryXmlMetas.ContainsKey(meta.Type))
			{
				return;
			}
			XmlAdapter.RequireXmlMeta(meta);
			this.secondaryXmlMetas[meta.Type] = meta.GetXmlMeta();
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00017F07 File Offset: 0x00016107
		private static void RequireXmlMeta(DictionaryAdapterMeta meta)
		{
			if (!meta.HasXmlMeta())
			{
				throw Error.XmlMetadataNotAvailable(meta.Type);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00017F20 File Offset: 0x00016120
		bool IDictionaryCopyStrategy.Copy(IDictionaryAdapter source, IDictionaryAdapter target, ref Func<PropertyDescriptor, bool> selector)
		{
			if (selector == null)
			{
				selector = ((PropertyDescriptor property) => this.HasProperty(property.PropertyName, source));
			}
			return false;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00017F54 File Offset: 0x00016154
		object IDictionaryPropertyGetter.GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor property, bool ifExists)
		{
			XmlAccessor xmlAccessor;
			if (this.TryGetAccessor(key, property, storedValue != null, out xmlAccessor))
			{
				storedValue = xmlAccessor.GetPropertyValue(this.node, dictionaryAdapter, this.references, !ifExists);
				if (storedValue != null)
				{
					this.AttachObservers(storedValue, dictionaryAdapter, property);
					dictionaryAdapter.StoreProperty(property, key, storedValue);
				}
			}
			return storedValue;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00017FA4 File Offset: 0x000161A4
		bool IDictionaryPropertySetter.SetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, ref object value, PropertyDescriptor property)
		{
			XmlAccessor xmlAccessor;
			if (this.TryGetAccessor(key, property, false, out xmlAccessor))
			{
				if (value != null && dictionaryAdapter.ShouldClearProperty(property, value))
				{
					value = null;
				}
				object oldValue = dictionaryAdapter.ReadProperty(key);
				xmlAccessor.SetPropertyValue(this.node, dictionaryAdapter, this.references, oldValue, ref value);
			}
			return true;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00017FF0 File Offset: 0x000161F0
		private static string EnsureKey(string key, PropertyDescriptor property)
		{
			if (!string.IsNullOrEmpty(key))
			{
				return key;
			}
			return property.PropertyName;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00018004 File Offset: 0x00016204
		private IXmlNode GetBaseNode()
		{
			IXmlNode sourceNode = this.GetSourceNode();
			if (sourceNode.IsElement)
			{
				return sourceNode;
			}
			if (sourceNode.IsAttribute)
			{
				throw Error.NotSupported();
			}
			IXmlCursor xmlCursor = this.primaryXmlMeta.SelectBase(sourceNode);
			if (!xmlCursor.MoveNext())
			{
				return xmlCursor;
			}
			return xmlCursor.Save();
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00018050 File Offset: 0x00016250
		private IXmlNode GetSourceNode()
		{
			XmlNode xmlNode = this.source as XmlNode;
			if (xmlNode != null)
			{
				return new SysXmlNode(xmlNode, this.primaryXmlMeta.ClrType, this.primaryXmlMeta.Context);
			}
			throw Error.NotSupported();
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00018090 File Offset: 0x00016290
		private bool TryGetAccessor(string key, PropertyDescriptor property, bool requireVolatile, out XmlAccessor accessor)
		{
			accessor = (property.HasAccessor() ? property.GetAccessor() : this.CreateAccessor(key, property));
			if (accessor.IsIgnored)
			{
				return Try.Failure<XmlAccessor>(out accessor);
			}
			return !requireVolatile || accessor.IsVolatile || Try.Failure<XmlAccessor>(out accessor);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x000180E0 File Offset: 0x000162E0
		private XmlAccessor CreateAccessor(string key, PropertyDescriptor property)
		{
			XmlAccessor xmlAccessor = null;
			bool isVolatile = false;
			bool isReference = false;
			if (string.IsNullOrEmpty(key))
			{
				xmlAccessor = this.CreateAccessor<XmlSelfAccessor>(key, property, XmlSelfAccessor.Factory);
			}
			foreach (object behavior in property.Annotations)
			{
				if (XmlAdapter.IsIgnoreBehavior(behavior))
				{
					return XmlIgnoreBehaviorAccessor.Instance;
				}
				if (XmlAdapter.IsVolatileBehavior(behavior))
				{
					isVolatile = true;
				}
				else if (XmlAdapter.IsReferenceBehavior(behavior))
				{
					isReference = true;
				}
				else
				{
					this.TryApplyBehavior(key, property, behavior, ref xmlAccessor);
				}
			}
			if (xmlAccessor == null)
			{
				xmlAccessor = this.CreateAccessor<XmlDefaultBehaviorAccessor>(key, property, XmlDefaultBehaviorAccessor.Factory);
			}
			xmlAccessor.ConfigureVolatile(isVolatile);
			xmlAccessor.ConfigureReference(isReference);
			xmlAccessor.Prepare();
			property.SetAccessor(xmlAccessor);
			return xmlAccessor;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0001818C File Offset: 0x0001638C
		private bool TryApplyBehavior(string key, PropertyDescriptor property, object behavior, ref XmlAccessor accessor)
		{
			return this.TryApplyBehavior<XmlElementAttribute, XmlElementBehaviorAccessor>(key, property, behavior, ref accessor, XmlElementBehaviorAccessor.Factory) || this.TryApplyBehavior<XmlArrayAttribute, XmlArrayBehaviorAccessor>(key, property, behavior, ref accessor, XmlArrayBehaviorAccessor.Factory) || this.TryApplyBehavior<XmlArrayItemAttribute, XmlArrayBehaviorAccessor>(key, property, behavior, ref accessor, XmlArrayBehaviorAccessor.Factory) || this.TryApplyBehavior<XmlAttributeAttribute, XmlAttributeBehaviorAccessor>(key, property, behavior, ref accessor, XmlAttributeBehaviorAccessor.Factory) || this.TryApplyBehavior<XPathAttribute, XPathBehaviorAccessor>(key, property, behavior, ref accessor, XPathBehaviorAccessor.Factory) || this.TryApplyBehavior<XPathVariableAttribute, XPathBehaviorAccessor>(key, property, behavior, ref accessor, XPathBehaviorAccessor.Factory) || this.TryApplyBehavior<XPathFunctionAttribute, XPathBehaviorAccessor>(key, property, behavior, ref accessor, XPathBehaviorAccessor.Factory);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00018218 File Offset: 0x00016418
		private bool TryApplyBehavior<TBehavior, TAccessor>(string key, PropertyDescriptor property, object behavior, ref XmlAccessor accessor, XmlAccessorFactory<TAccessor> factory) where TBehavior : class where TAccessor : XmlAccessor, IConfigurable<TBehavior>
		{
			TBehavior tbehavior = behavior as TBehavior;
			if (tbehavior == null)
			{
				return false;
			}
			if (accessor == null)
			{
				accessor = this.CreateAccessor<TAccessor>(key, property, factory);
			}
			TAccessor taccessor = accessor as TAccessor;
			if (taccessor == null)
			{
				throw Error.AttributeConflict(key);
			}
			taccessor.Configure(tbehavior);
			return true;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0001827C File Offset: 0x0001647C
		private TAccessor CreateAccessor<TAccessor>(string key, PropertyDescriptor property, XmlAccessorFactory<TAccessor> factory) where TAccessor : XmlAccessor
		{
			XmlMetadata xmlMetadata = this.GetXmlMetadata(property.Property.DeclaringType);
			TAccessor taccessor = factory(key, property.PropertyType, xmlMetadata.Context);
			if (xmlMetadata.IsNullable != null)
			{
				taccessor.ConfigureNillable(xmlMetadata.IsNullable.Value);
			}
			if (xmlMetadata.IsReference != null)
			{
				taccessor.ConfigureReference(xmlMetadata.IsReference.Value);
			}
			return taccessor;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00018304 File Offset: 0x00016504
		private XmlMetadata GetXmlMetadata(Type type)
		{
			if (type == this.primaryXmlMeta.ClrType)
			{
				return this.primaryXmlMeta;
			}
			XmlMetadata result;
			if (this.secondaryXmlMetas.TryGetValue(type, out result))
			{
				return result;
			}
			throw Error.XmlMetadataNotAvailable(type);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00018343 File Offset: 0x00016543
		private static bool IsIgnoreBehavior(object behavior)
		{
			return behavior is XmlIgnoreAttribute;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0001834E File Offset: 0x0001654E
		private static bool IsVolatileBehavior(object behavior)
		{
			return behavior is VolatileAttribute;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00018359 File Offset: 0x00016559
		private static bool IsReferenceBehavior(object behavior)
		{
			return behavior is ReferenceAttribute;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00018364 File Offset: 0x00016564
		void IVirtual.Realize()
		{
			throw new NotSupportedException("XmlAdapter does not support realization via IVirtual.Realize().");
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060009B8 RID: 2488 RVA: 0x00018370 File Offset: 0x00016570
		// (remove) Token: 0x060009B9 RID: 2489 RVA: 0x000183A8 File Offset: 0x000165A8
		public event EventHandler Realized;

		// Token: 0x060009BA RID: 2490 RVA: 0x000183DD File Offset: 0x000165DD
		protected virtual void OnRealized()
		{
			if (this.Realized != null)
			{
				this.Realized(this, EventArgs.Empty);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000183F8 File Offset: 0x000165F8
		private void HandleNodeRealized(object sender, EventArgs e)
		{
			this.OnRealized();
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00018400 File Offset: 0x00016600
		private void AttachObservers(object value, IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property)
		{
			IBindingList bindingList = value as IBindingList;
			if (bindingList != null)
			{
				bindingList.ListChanged += delegate(object s, ListChangedEventArgs e)
				{
					this.HandleListChanged(s, e, dictionaryAdapter, property);
				};
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00018444 File Offset: 0x00016644
		private void HandleListChanged(object value, ListChangedEventArgs args, IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property)
		{
			ListChangedType listChangedType = args.ListChangedType;
			if ((listChangedType == ListChangedType.ItemAdded || listChangedType == ListChangedType.ItemDeleted || listChangedType == ListChangedType.ItemMoved || listChangedType == ListChangedType.Reset) && dictionaryAdapter.ShouldClearProperty(property, value))
			{
				value = null;
				dictionaryAdapter.SetProperty(property.PropertyName, ref value);
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0001848C File Offset: 0x0001668C
		bool IDictionaryReferenceManager.IsReferenceProperty(IDictionaryAdapter dictionaryAdapter, string propertyName)
		{
			XmlAdapter xmlAdapter = XmlAdapter.For(dictionaryAdapter, false);
			if (xmlAdapter == null)
			{
				return false;
			}
			DictionaryAdapterInstance this2 = dictionaryAdapter.This;
			PropertyDescriptor propertyDescriptor;
			if (!this2.Properties.TryGetValue(propertyName, out propertyDescriptor))
			{
				return false;
			}
			string key = propertyDescriptor.GetKey(dictionaryAdapter, propertyName, this2.Descriptor);
			XmlAccessor xmlAccessor;
			return xmlAdapter.TryGetAccessor(key, propertyDescriptor, false, out xmlAccessor) && xmlAccessor.IsReference;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000184E4 File Offset: 0x000166E4
		bool IDictionaryReferenceManager.TryGetReference(object keyObject, out object inGraphObject)
		{
			return this.references.TryGet(keyObject, out inGraphObject);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000184F3 File Offset: 0x000166F3
		void IDictionaryReferenceManager.AddReference(object keyObject, object relatedObject, bool isInGraph)
		{
			this.references.Add(null, keyObject, relatedObject, isInGraph);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00018504 File Offset: 0x00016704
		public override IDictionaryBehavior Copy()
		{
			return null;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00018507 File Offset: 0x00016707
		public static XmlAdapter For(object obj)
		{
			return XmlAdapter.For(obj, true);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00018510 File Offset: 0x00016710
		public static XmlAdapter For(object obj, bool required)
		{
			if (obj == null)
			{
				if (!required)
				{
					return null;
				}
				throw Error.ArgumentNull("obj");
			}
			else
			{
				IDictionaryAdapter dictionaryAdapter = obj as IDictionaryAdapter;
				if (dictionaryAdapter == null)
				{
					if (!required)
					{
						return null;
					}
					throw Error.NotDictionaryAdapter("obj");
				}
				else
				{
					PropertyDescriptor descriptor = dictionaryAdapter.This.Descriptor;
					if (descriptor == null)
					{
						if (!required)
						{
							return null;
						}
						throw Error.NoInstanceDescriptor("obj");
					}
					else
					{
						IEnumerable<IDictionaryPropertyGetter> getters = descriptor.Getters;
						if (getters != null)
						{
							foreach (IDictionaryPropertyGetter dictionaryPropertyGetter in getters)
							{
								XmlAdapter result;
								if ((result = (dictionaryPropertyGetter as XmlAdapter)) != null)
								{
									return result;
								}
							}
							if (!required)
							{
								return null;
							}
							throw Error.NoXmlAdapter("obj");
						}
						if (!required)
						{
							return null;
						}
						throw Error.NoXmlAdapter("obj");
					}
				}
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000185E0 File Offset: 0x000167E0
		public static bool IsPropertyDefined(string propertyName, IDictionaryAdapter dictionaryAdapter)
		{
			XmlAdapter xmlAdapter = XmlAdapter.For(dictionaryAdapter, true);
			return xmlAdapter != null && xmlAdapter.HasProperty(propertyName, dictionaryAdapter);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00018604 File Offset: 0x00016804
		public bool HasProperty(string propertyName, IDictionaryAdapter dictionaryAdapter)
		{
			string key = dictionaryAdapter.GetKey(propertyName);
			PropertyDescriptor property;
			XmlAccessor xmlAccessor;
			return key != null && (dictionaryAdapter.This.Properties.TryGetValue(propertyName, out property) && this.TryGetAccessor(key, property, false, out xmlAccessor)) && xmlAccessor.IsPropertyDefined(this.node);
		}

		// Token: 0x04000214 RID: 532
		private IXmlNode node;

		// Token: 0x04000215 RID: 533
		private object source;

		// Token: 0x04000216 RID: 534
		private XmlReferenceManager references;

		// Token: 0x04000217 RID: 535
		private XmlMetadata primaryXmlMeta;

		// Token: 0x04000218 RID: 536
		private Dictionary<Type, XmlMetadata> secondaryXmlMetas;

		// Token: 0x04000219 RID: 537
		private readonly bool isRoot;
	}
}
