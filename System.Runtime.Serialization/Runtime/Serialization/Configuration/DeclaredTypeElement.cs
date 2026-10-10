using System;
using System.Configuration;
using System.Security;

namespace System.Runtime.Serialization.Configuration
{
	/// <summary>Обрабатывает XML-элементы, используемые для добавления известных типов, применяемых для сериализации с помощью <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
	// Token: 0x020001A1 RID: 417
	public sealed class DeclaredTypeElement : ConfigurationElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Configuration.DeclaredTypeElement" />.</summary>
		// Token: 0x0600151F RID: 5407 RVA: 0x00053E2E File Offset: 0x0005202E
		public DeclaredTypeElement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Configuration.DeclaredTypeElement" /> с указанным именем типа.</summary>
		/// <param name="typeName">Имя типа, для которого требуется коллекция известных типов.</param>
		// Token: 0x06001520 RID: 5408 RVA: 0x00053E36 File Offset: 0x00052036
		public DeclaredTypeElement(string typeName) : this()
		{
			if (string.IsNullOrEmpty(typeName))
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("typeName");
			}
			this.Type = typeName;
		}

		/// <summary>Возвращает коллекцию известных типов.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Serialization.Configuration.TypeElementCollection" />, содержащий известные типы.</returns>
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x00053E58 File Offset: 0x00052058
		[ConfigurationProperty("", DefaultValue = null, Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public TypeElementCollection KnownTypes
		{
			get
			{
				return (TypeElementCollection)base[""];
			}
		}

		/// <summary>Возвращает или задает объявленный тип, для которого требуется коллекция известных типов.</summary>
		/// <returns>Имя объявленного типа.</returns>
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x00053E6A File Offset: 0x0005206A
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x00053E7C File Offset: 0x0005207C
		[DeclaredTypeValidator]
		[ConfigurationProperty("type", DefaultValue = "", Options = ConfigurationPropertyOptions.IsKey)]
		public string Type
		{
			get
			{
				return (string)base["type"];
			}
			set
			{
				base["type"] = value;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00053E8A File Offset: 0x0005208A
		[SecuritySafeCritical]
		protected override void PostDeserialize()
		{
			if (base.EvaluationContext.IsMachineLevel)
			{
				return;
			}
			if (!PartialTrustHelpers.IsInFullTrust())
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ConfigurationErrorsException(SR.GetString("Failed to load configuration section for dataContractSerializer.")));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x00053EB8 File Offset: 0x000520B8
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				if (this.properties == null)
				{
					this.properties = new ConfigurationPropertyCollection
					{
						new ConfigurationProperty("", typeof(TypeElementCollection), null, null, null, ConfigurationPropertyOptions.IsDefaultCollection),
						new ConfigurationProperty("type", typeof(string), string.Empty, null, new DeclaredTypeValidator(), ConfigurationPropertyOptions.IsKey)
					};
				}
				return this.properties;
			}
		}

		// Token: 0x04000A84 RID: 2692
		private ConfigurationPropertyCollection properties;
	}
}
