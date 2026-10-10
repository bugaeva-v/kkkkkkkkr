using System;
using System.Text;
using Unity;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Обеспечивает сопоставление между методами службы веб-.NET Framework и сообщений языка описания веб-служб (WSDL), определенные для веб-служб SOAP.
	///       </summary>
	// Token: 0x020002D8 RID: 728
	public class XmlMembersMapping : XmlMapping
	{
		// Token: 0x06001C23 RID: 7203 RVA: 0x0009E9A8 File Offset: 0x0009CBA8
		internal XmlMembersMapping(TypeScope scope, ElementAccessor accessor, XmlMappingAccess access) : base(scope, accessor, access)
		{
			MembersMapping membersMapping = (MembersMapping)accessor.Mapping;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(":");
			this.mappings = new XmlMemberMapping[membersMapping.Members.Length];
			for (int i = 0; i < this.mappings.Length; i++)
			{
				if (membersMapping.Members[i].TypeDesc.Type != null)
				{
					stringBuilder.Append(XmlMapping.GenerateKey(membersMapping.Members[i].TypeDesc.Type, null, null));
					stringBuilder.Append(":");
				}
				this.mappings[i] = new XmlMemberMapping(membersMapping.Members[i]);
			}
			base.SetKeyInternal(stringBuilder.ToString());
		}

		/// <summary>
		///         Возвращает имя типа .NET Framework, сопоставляемого в тип данных элемента схемы XML, представляющего сообщение SOAP.
		///       </summary>
		/// <returns>
		///         Имя типа .NET Framework.
		///       </returns>
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0009EA69 File Offset: 0x0009CC69
		public string TypeName
		{
			get
			{
				return base.Accessor.Mapping.TypeName;
			}
		}

		/// <summary>
		///         Получает пространство имен типа платформы .NET Framework, сопоставляемого в тип данных элемента схемы XML, представляющего сообщение SOAP.
		///       </summary>
		/// <returns>
		///         Пространство имен .NET Framework сопоставления.
		///       </returns>
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0009EA7B File Offset: 0x0009CC7B
		public string TypeNamespace
		{
			get
			{
				return base.Accessor.Mapping.Namespace;
			}
		}

		/// <summary>
		///         Возвращает элемент, содержащий внутренний тип сопоставления сведения для сущности кода .NET Framework, принадлежащего методу веб-службы, который сопоставляется сообщение SOAP.
		///       </summary>
		/// <param name="index">
		///           Индекс сопоставления для возврата.
		///         </param>
		/// <returns>
		///         Запрошенный <see cref="T:System.Xml.Serialization.XmlMemberMapping" />.
		///       </returns>
		// Token: 0x170005A5 RID: 1445
		public XmlMemberMapping this[int index]
		{
			get
			{
				return this.mappings[index];
			}
		}

		/// <summary>
		///         Получает число сущностей кода .NET Framework, принадлежащих методу веб-службы, с которым сопоставляется сообщение SOAP.
		///       </summary>
		/// <returns>
		///         Число сопоставлений в коллекции.
		///       </returns>
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0009EA97 File Offset: 0x0009CC97
		public int Count
		{
			get
			{
				return this.mappings.Length;
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00067344 File Offset: 0x00065544
		internal XmlMembersMapping()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001A01 RID: 6657
		private XmlMemberMapping[] mappings;
	}
}
