using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200018E RID: 398
	public abstract class XmlCollectionSerializer : XmlTypeSerializer
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0001E61C File Offset: 0x0001C81C
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Collection;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0001E61F File Offset: 0x0001C81F
		public override bool CanGetStub
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000C91 RID: 3217
		public abstract Type ListTypeConstructor { get; }

		// Token: 0x06000C92 RID: 3218 RVA: 0x0001E622 File Offset: 0x0001C822
		public override object GetStub(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			return this.GetValueCore(node, parent, accessor);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0001E62D File Offset: 0x0001C82D
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			return this.GetValueCore(node.Save(), parent, accessor);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0001E640 File Offset: 0x0001C840
		private object GetValueCore(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			Type type = node.ClrType.GetGenericArguments()[0];
			Type type2 = this.ListTypeConstructor.MakeGenericType(new Type[]
			{
				type
			});
			IXmlCollectionAccessor collectionAccessor = accessor.GetCollectionAccessor(type);
			return Activator.CreateInstance(type2, new object[]
			{
				node,
				parent,
				collectionAccessor
			});
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0001E690 File Offset: 0x0001C890
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			IXmlNodeSource xmlNodeSource = value as IXmlNodeSource;
			if (xmlNodeSource != null && xmlNodeSource.Node.PositionEquals(node))
			{
				return;
			}
			IEnumerable enumerable = value as IEnumerable;
			if (enumerable == null)
			{
				throw Error.NotSupported();
			}
			ICollectionProjection collectionProjection = oldValue as ICollectionProjection;
			if (collectionProjection != null)
			{
				collectionProjection.ClearReferences();
			}
			ICollectionProjection collectionProjection2 = (ICollectionProjection)this.GetValue(node, parent, accessor);
			collectionProjection2.Replace(enumerable);
			value = collectionProjection2;
		}
	}
}
