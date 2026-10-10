using System;
using System.Runtime.Serialization;
using Unity;

namespace System.Xml.Linq
{
	/// <summary>Представляет имя XML-элемента или атрибута.</summary>
	// Token: 0x0200004D RID: 77
	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable
	{
		// Token: 0x0600027B RID: 635 RVA: 0x0000CC00 File Offset: 0x0000AE00
		internal XName(XNamespace ns, string localName)
		{
			this._ns = ns;
			this._localName = XmlConvert.VerifyNCName(localName);
			this._hashCode = (ns.GetHashCode() ^ localName.GetHashCode());
		}

		/// <summary>Вызывает локальную (неопределенную) часть имени.</summary>
		/// <returns>
		///   <see cref="T:System.String" />, содержащий локальную (неопределенную) часть имени.</returns>
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000CC2E File Offset: 0x0000AE2E
		public string LocalName
		{
			get
			{
				return this._localName;
			}
		}

		/// <summary>Вызывает часть пространства имен полностью определенного имени.</summary>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XNamespace" />, содержит часть имени пространства имен.</returns>
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000CC36 File Offset: 0x0000AE36
		public XNamespace Namespace
		{
			get
			{
				return this._ns;
			}
		}

		/// <summary>Возвращает URI <see cref="T:System.Xml.Linq.XNamespace" /> для этого <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <returns>Возвращает URI <see cref="T:System.Xml.Linq.XNamespace" /> для этого <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000CC3E File Offset: 0x0000AE3E
		public string NamespaceName
		{
			get
			{
				return this._ns.NamespaceName;
			}
		}

		/// <summary>Возвращает развернутое имя XML в формате {пространство_имен}локальное_имя.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит развернутое имя XML в формате {пространство_имен}локальное_имя.</returns>
		// Token: 0x0600027F RID: 639 RVA: 0x0000CC4B File Offset: 0x0000AE4B
		public override string ToString()
		{
			if (this._ns.NamespaceName.Length == 0)
			{
				return this._localName;
			}
			return "{" + this._ns.NamespaceName + "}" + this._localName;
		}

		/// <summary>Вызывает объект <see cref="T:System.Xml.Linq.XName" /> из развернутого имени.</summary>
		/// <param name="expandedName">Строка <see cref="T:System.String" />, которая содержит развернутое имя XML в формате {пространство_имен}локальное_имя.</param>
		/// <returns>Объект <see cref="T:System.Xml.Linq.XName" /> сконструирован из развернутого имени.</returns>
		// Token: 0x06000280 RID: 640 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public static XName Get(string expandedName)
		{
			if (expandedName == null)
			{
				throw new ArgumentNullException("expandedName");
			}
			if (expandedName.Length == 0)
			{
				throw new ArgumentException(SR.Format("'{0}' is an invalid expanded name.", expandedName));
			}
			if (expandedName[0] != '{')
			{
				return XNamespace.None.GetName(expandedName);
			}
			int num = expandedName.LastIndexOf('}');
			if (num <= 1 || num == expandedName.Length - 1)
			{
				throw new ArgumentException(SR.Format("'{0}' is an invalid expanded name.", expandedName));
			}
			return XNamespace.Get(expandedName, 1, num - 1).GetName(expandedName, num + 1, expandedName.Length - num - 1);
		}

		/// <summary>Вызывает объект <see cref="T:System.Xml.Linq.XName" /> из локального имени и пространства имен.</summary>
		/// <param name="localName">Локальное (неопределенное) имя.</param>
		/// <param name="namespaceName">Пространство имен XML.</param>
		/// <returns>Объект <see cref="T:System.Xml.Linq.XName" />, созданный из указанного локального имени и пространства имен.</returns>
		// Token: 0x06000281 RID: 641 RVA: 0x0000CD19 File Offset: 0x0000AF19
		public static XName Get(string localName, string namespaceName)
		{
			return XNamespace.Get(namespaceName).GetName(localName);
		}

		/// <summary>Преобразует строку, отформатированную как развернутое имя XML (то есть {пространство_имен}локальное_имя), в объект <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="expandedName">Строка, которая содержит развернутое имя XML в формате {пространство_имен}локальное_имя.</param>
		/// <returns>Объект <see cref="T:System.Xml.Linq.XName" /> сконструирован из развернутого имени.</returns>
		// Token: 0x06000282 RID: 642 RVA: 0x0000CD27 File Offset: 0x0000AF27
		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName)
		{
			if (expandedName == null)
			{
				return null;
			}
			return XName.Get(expandedName);
		}

		/// <summary>Определяет, является ли указанное <see cref="T:System.Xml.Linq.XName" /> равным данному <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Xml.Linq.XName" /> для сравнения с текущим объектом <see cref="T:System.Xml.Linq.XName" />.</param>
		/// <returns>
		///   <see langword="true" />, если указанный <see cref="T:System.Xml.Linq.XName" /> равен текущему <see cref="T:System.Xml.Linq.XName" />; в ином случае — <see langword="false" />.</returns>
		// Token: 0x06000283 RID: 643 RVA: 0x0000CD34 File Offset: 0x0000AF34
		public override bool Equals(object obj)
		{
			return this == obj;
		}

		/// <summary>Возвращает хэш-код для данного объекта <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <returns>
		///   <see cref="T:System.Int32" /> содержит хэш-код для <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x06000284 RID: 644 RVA: 0x0000CD3A File Offset: 0x0000AF3A
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		/// <summary>Возвращает значение, указывающее, равны ли два экземпляра <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="left">Первый экземпляр <see cref="T:System.Xml.Linq.XName" /> для сравнения.</param>
		/// <param name="right">Второй экземпляр <see cref="T:System.Xml.Linq.XName" /> для сравнения.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в ином случае — <see langword="false" />.</returns>
		// Token: 0x06000285 RID: 645 RVA: 0x0000CD34 File Offset: 0x0000AF34
		public static bool operator ==(XName left, XName right)
		{
			return left == right;
		}

		/// <summary>Возвращает значение, указывающее, являются ли два экземпляра <see cref="T:System.Xml.Linq.XName" /> неравными.</summary>
		/// <param name="left">Первый экземпляр <see cref="T:System.Xml.Linq.XName" /> для сравнения.</param>
		/// <param name="right">Второй экземпляр <see cref="T:System.Xml.Linq.XName" /> для сравнения.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны; в ином случае — <see langword="false" />.</returns>
		// Token: 0x06000286 RID: 646 RVA: 0x0000CD42 File Offset: 0x0000AF42
		public static bool operator !=(XName left, XName right)
		{
			return left != right;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000CD34 File Offset: 0x0000AF34
		bool IEquatable<XName>.Equals(XName other)
		{
			return this == other;
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Конечный объект (см. <see cref="T:System.Runtime.Serialization.StreamingContext" />) для этой сериализации.</param>
		// Token: 0x06000288 RID: 648 RVA: 0x0000CD4B File Offset: 0x0000AF4B
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000CD52 File Offset: 0x0000AF52
		internal XName()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000182 RID: 386
		private XNamespace _ns;

		// Token: 0x04000183 RID: 387
		private string _localName;

		// Token: 0x04000184 RID: 388
		private int _hashCode;
	}
}
