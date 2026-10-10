using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Атрибут <see cref="T:System.ComponentModel.Design.Serialization.DefaultSerializationProviderAttribute" /> размещается в сериализатор для обозначения класса, используемого в качестве поставщика по умолчанию данного типа сериализатора.</summary>
	// Token: 0x02000482 RID: 1154
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class DefaultSerializationProviderAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.DefaultSerializationProviderAttribute" /> с заданным типом поставщика.</summary>
		/// <param name="providerType">Класс <see cref="T:System.Type" /> поставщика сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="providerType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002507 RID: 9479 RVA: 0x00082B85 File Offset: 0x00080D85
		public DefaultSerializationProviderAttribute(Type providerType)
		{
			if (providerType == null)
			{
				throw new ArgumentNullException("providerType");
			}
			this.ProviderTypeName = providerType.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.DefaultSerializationProviderAttribute" /> с именованным типом поставщика.</summary>
		/// <param name="providerTypeName">Имя типа поставщика сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="providerTypeName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002508 RID: 9480 RVA: 0x00082BAD File Offset: 0x00080DAD
		public DefaultSerializationProviderAttribute(string providerTypeName)
		{
			if (providerTypeName == null)
			{
				throw new ArgumentNullException("providerTypeName");
			}
			this.ProviderTypeName = providerTypeName;
		}

		/// <summary>Возвращает имя типа поставщика сериализации.</summary>
		/// <returns>Строка, содержащая название поставщика.</returns>
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x00082BCA File Offset: 0x00080DCA
		public string ProviderTypeName { get; }
	}
}
