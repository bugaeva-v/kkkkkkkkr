using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Означает, что код был создан с помощью инфраструктуры сериализации и может быть повторно использован для повышения производительности, когда этот атрибут применяется к сборке.
	///       </summary>
	// Token: 0x02000307 RID: 775
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class XmlSerializerVersionAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlSerializerVersionAttribute" />.
		///       </summary>
		// Token: 0x06002043 RID: 8259 RVA: 0x000021EA File Offset: 0x000003EA
		public XmlSerializerVersionAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializerVersionAttribute" /> класса для указанного типа.
		///       </summary>
		/// <param name="type">
		///           Сериализуемый тип.
		///         </param>
		// Token: 0x06002044 RID: 8260 RVA: 0x000D0B2C File Offset: 0x000CED2C
		public XmlSerializerVersionAttribute(Type type)
		{
			this.type = type;
		}

		/// <summary>
		///         Возвращает или задает идентификатор родительской сборки.
		///       </summary>
		/// <returns>
		///         Версия родительской сборки.
		///       </returns>
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x000D0B3B File Offset: 0x000CED3B
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x000D0B43 File Offset: 0x000CED43
		public string ParentAssemblyId
		{
			get
			{
				return this.mvid;
			}
			set
			{
				this.mvid = value;
			}
		}

		/// <summary>
		///         Возвращает или задает номер версии сборки.
		///       </summary>
		/// <returns>
		///         Версия сборки.
		///       </returns>
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x000D0B4C File Offset: 0x000CED4C
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x000D0B54 File Offset: 0x000CED54
		public string Version
		{
			get
			{
				return this.serializerVersion;
			}
			set
			{
				this.serializerVersion = value;
			}
		}

		/// <summary>
		///         Возвращает или задает имен среды CLR (CLR) сборки.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.String" /> содержащий имен среды CLR (CLR) сборки.
		///       </returns>
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x000D0B5D File Offset: 0x000CED5D
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x000D0B65 File Offset: 0x000CED65
		public string Namespace
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
			}
		}

		/// <summary>
		///         Возвращает или задает тип, с которым работает сериализатор.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" /> для сериализации.
		///       </returns>
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x000D0B6E File Offset: 0x000CED6E
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x000D0B76 File Offset: 0x000CED76
		public Type Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		// Token: 0x04001B21 RID: 6945
		private string mvid;

		// Token: 0x04001B22 RID: 6946
		private string serializerVersion;

		// Token: 0x04001B23 RID: 6947
		private string ns;

		// Token: 0x04001B24 RID: 6948
		private Type type;
	}
}
