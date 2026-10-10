using System;
using System.Configuration.Provider;

namespace System.Configuration
{
	/// <summary>Предоставляет коллекцию объектов <see cref="T:System.Configuration.ProtectedConfigurationProvider" />.</summary>
	// Token: 0x0200005E RID: 94
	public class ProtectedConfigurationProviderCollection : ProviderCollection
	{
		/// <summary>Возвращает объект в коллекцию <see cref="T:System.Configuration.ProtectedConfigurationProvider" /> с указанным именем.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Configuration.ProtectedConfigurationProvider" /> в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" /> с заданным именем или значение <see langword="null" />, если объекты с именем отсутствуют.</returns>
		// Token: 0x170000E5 RID: 229
		[MonoTODO]
		public ProtectedConfigurationProvider this[string name]
		{
			get
			{
				return (ProtectedConfigurationProvider)base[name];
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" /> в коллекцию.</summary>
		/// <param name="provider">Объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" /> для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="provider" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="provider" /> не является объектом <see cref="T:System.Configuration.ProtectedConfigurationProvider" />.</exception>
		/// <exception cref="T:System.Configuration.ConfigurationException">Добавляемый объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" /> уже имеется в коллекции.  
		/// -или- 
		/// Коллекция только для чтения.</exception>
		// Token: 0x06000311 RID: 785 RVA: 0x00008B40 File Offset: 0x00006D40
		[MonoTODO]
		public override void Add(ProviderBase provider)
		{
			base.Add(provider);
		}
	}
}
