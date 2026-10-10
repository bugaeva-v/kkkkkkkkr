using System;
using System.Configuration.Provider;
using System.Reflection;
using Unity;

namespace System.Configuration
{
	/// <summary>Поддерживает коллекцию объектов <see cref="T:System.Configuration.ConfigurationBuilder" /> по имени.</summary>
	// Token: 0x0200008D RID: 141
	[DefaultMember("Item")]
	public class ConfigurationBuilderCollection : ProviderCollection
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationBuilderCollection" />.</summary>
		// Token: 0x06000492 RID: 1170 RVA: 0x00003518 File Offset: 0x00001718
		public ConfigurationBuilderCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
