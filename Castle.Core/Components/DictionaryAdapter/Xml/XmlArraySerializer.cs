using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200018D RID: 397
	public class XmlArraySerializer : XmlTypeSerializer
	{
		// Token: 0x06000C86 RID: 3206 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
		protected XmlArraySerializer()
		{
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0001E4AC File Offset: 0x0001C6AC
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Collection;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0001E4AF File Offset: 0x0001C6AF
		public override bool CanGetStub
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0001E4B2 File Offset: 0x0001C6B2
		public override object GetStub(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			return Array.CreateInstance(node.ClrType.GetElementType(), 0);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			ArrayList arrayList = new ArrayList();
			Type elementType = node.ClrType.GetElementType();
			XmlReferenceManager references = XmlAdapter.For(parent).References;
			accessor.GetCollectionAccessor(elementType).GetCollectionItems(node, parent, references, arrayList);
			return arrayList.ToArray(elementType);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0001E50C File Offset: 0x0001C70C
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			Array array = (Array)value;
			Array array2 = null;
			Array array3 = (Array)oldValue;
			Type elementType = array.GetType().GetElementType();
			IXmlCollectionAccessor collectionAccessor = accessor.GetCollectionAccessor(elementType);
			IXmlCursor xmlCursor = collectionAccessor.SelectCollectionItems(node, true);
			XmlTypeSerializer serializer = collectionAccessor.Serializer;
			XmlReferenceManager references = XmlAdapter.For(parent).References;
			for (int i = 0; i < array.Length; i++)
			{
				object itemSafe = XmlArraySerializer.GetItemSafe(array3, i);
				object value2 = array.GetValue(i);
				object obj = value2;
				collectionAccessor.SetValue(xmlCursor, parent, references, xmlCursor.MoveNext(), itemSafe, ref obj);
				if (array2 != null)
				{
					array2.SetValue(obj, i);
				}
				else if (!object.Equals(obj, value2))
				{
					array2 = Array.CreateInstance(elementType, array.Length);
					Array.Copy(array, array2, i);
					array2.SetValue(obj, i);
				}
			}
			xmlCursor.RemoveAllNext();
			if (array2 != null)
			{
				value = array2;
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0001E5ED File Offset: 0x0001C7ED
		private static object GetItemSafe(Array array, int index)
		{
			if (array == null || index < 0 || index >= array.Length)
			{
				return null;
			}
			return array.GetValue(index);
		}

		// Token: 0x040002AA RID: 682
		public static readonly XmlArraySerializer Instance = new XmlArraySerializer();
	}
}
