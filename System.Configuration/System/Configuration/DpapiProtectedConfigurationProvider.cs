using System;
using System.Collections.Specialized;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Предоставляет объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" />, который использует API-интерфейс защиты данных Windows (DPAPI) для шифрования и расшифровки данных конфигурации.</summary>
	// Token: 0x0200003E RID: 62
	public sealed class DpapiProtectedConfigurationProvider : ProtectedConfigurationProvider
	{
		/// <summary>Расшифровывает переданный объект <see cref="T:System.Xml.XmlNode" />.</summary>
		/// <param name="encryptedNode">Объект <see cref="T:System.Xml.XmlNode" /> для расшифровки.</param>
		/// <returns>Расшифрованный объект <see cref="T:System.Xml.XmlNode" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">
		///   <paramref name="encryptedNode" /> не имеет <see cref="P:System.Xml.XmlNode.Name" />, установленный в "EncryptedData", и <see cref="T:System.Xml.XmlNodeType" />, установленный в <see cref="F:System.Xml.XmlNodeType.Element" />.  
		/// -или- 
		///  <paramref name="encryptedNode" /> не имеет дочернего узла с именем "CipherData" с дочерним узелом "CipherValue".  
		/// -или- 
		/// Дочерний узел с именем CipherData является пустым узелом.</exception>
		// Token: 0x06000222 RID: 546 RVA: 0x0000774D File Offset: 0x0000594D
		[MonoNotSupported("DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.")]
		public override XmlNode Decrypt(XmlNode encryptedNode)
		{
			throw new NotSupportedException("DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.");
		}

		/// <summary>Зашифровывает переданный объект <see cref="T:System.Xml.XmlNode" />.</summary>
		/// <param name="node">Объект <see cref="T:System.Xml.XmlNode" /> для шифровки.</param>
		/// <returns>Зашифрованный объект <see cref="T:System.Xml.XmlNode" />.</returns>
		// Token: 0x06000223 RID: 547 RVA: 0x0000774D File Offset: 0x0000594D
		[MonoNotSupported("DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.")]
		public override XmlNode Encrypt(XmlNode node)
		{
			throw new NotSupportedException("DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.");
		}

		/// <summary>Выполняет инициализацию поставщика параметрами по умолчанию.</summary>
		/// <param name="name">Имя используемого поставщика для объекта.</param>
		/// <param name="configurationValues">Коллекция значений <see cref="T:System.Collections.Specialized.NameValueCollection" />, используемая при инициализации объекта.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">
		///   <paramref name="configurationValues" /> содержит неопознанные установки конфигурации.</exception>
		// Token: 0x06000224 RID: 548 RVA: 0x0000775C File Offset: 0x0000595C
		[MonoTODO]
		public override void Initialize(string name, NameValueCollection configurationValues)
		{
			base.Initialize(name, configurationValues);
			string text = configurationValues["useMachineProtection"];
			if (text != null && text.ToLowerInvariant() == "true")
			{
				this.useMachineProtection = true;
			}
		}

		/// <summary>Возвращает значение, указывающее, использует ли объект <see cref="T:System.Configuration.DpapiProtectedConfigurationProvider" /> защиту на уровне машины или учетной записи пользователя.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Configuration.DpapiProtectedConfigurationProvider" /> использует защиту на уровне машины; <see langword="false" />, если используется защита на уровне учетной записи пользователя.</returns>
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00007799 File Offset: 0x00005999
		public bool UseMachineProtection
		{
			get
			{
				return this.useMachineProtection;
			}
		}

		// Token: 0x040000E0 RID: 224
		private bool useMachineProtection;

		// Token: 0x040000E1 RID: 225
		private const string NotSupportedReason = "DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.";
	}
}
