using System;
using System.Configuration.Provider;

namespace System.Configuration
{
	/// <summary>Представляет коллекцию поставщиков установок приложения.</summary>
	// Token: 0x020001D5 RID: 469
	public class SettingsProviderCollection : ProviderCollection
	{
		/// <summary>Добавляет поставщика установок в коллекцию.</summary>
		/// <param name="provider">Объект <see cref="T:System.Configuration.Provider.ProviderBase" /> для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="provider" /> имеет тип, отличный от <see cref="T:System.Configuration.SettingsProvider" />.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Configuration.Provider.ProviderBase.Name" /> параметра параметра равно NULL или пустой строке.  
		///
		/// или - 
		/// Поставщик установок с таким же <see cref="P:System.Configuration.Provider.ProviderBase.Name" /> уже имеется в коллекции.</exception>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="provider" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000C50 RID: 3152 RVA: 0x00032714 File Offset: 0x00030914
		public override void Add(ProviderBase provider)
		{
			if (!(provider is SettingsProvider))
			{
				throw new ArgumentException("SettingsProvider is expected");
			}
			if (string.IsNullOrEmpty(provider.Name))
			{
				throw new ArgumentException("Provider name cannot be null or empty");
			}
			base.Add(provider);
		}

		/// <summary>Возвращает поставщика установок в коллекции, соответствующей указанному имени.</summary>
		/// <param name="name">Строка,<see cref="T:System.String" /> содержащая дружественное имя поставщика установок.</param>
		/// <returns>Если поиск успешен, возвращается объект <see cref="T:System.Configuration.SettingsProvider" /> с именем соответствующим указанному имени; в противном случае — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">При установке этого значения коллекция должна быть доступной только для чтения.</exception>
		// Token: 0x1700021F RID: 543
		public SettingsProvider this[string name]
		{
			get
			{
				return (SettingsProvider)base[name];
			}
		}
	}
}
