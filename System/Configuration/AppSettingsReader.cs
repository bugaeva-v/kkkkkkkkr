using System;
using System.Collections.Specialized;
using System.Reflection;

namespace System.Configuration
{
	/// <summary>Предоставляет метод для чтения значений определенного типа из конфигурации.</summary>
	// Token: 0x02000197 RID: 407
	public class AppSettingsReader
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.AppSettingsReader" />.</summary>
		// Token: 0x06000AA8 RID: 2728 RVA: 0x0002DC3A File Offset: 0x0002BE3A
		public AppSettingsReader()
		{
			this.appSettings = ConfigurationSettings.AppSettings;
		}

		/// <summary>Возвращает значение для указанного ключа из свойства <see cref="P:System.Configuration.ConfigurationSettings.AppSettings" /> и возвращает объект заданного типа, который содержит значение из конфигурации.</summary>
		/// <param name="key">Ключ, для которого необходимо вернуть значение.</param>
		/// <param name="type">Тип возвращаемого объекта.</param>
		/// <returns>Значение заданного ключа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="key" /> отсутствует в разделе конфигурации <see langword="&lt;appSettings&gt;" />.  
		/// -или- 
		/// Значение в разделе конфигурации <see langword="&lt;appSettings&gt;" /> для параметра <paramref name="key" /> имеет тип, отличный от <paramref name="type" />.</exception>
		// Token: 0x06000AA9 RID: 2729 RVA: 0x0002DC50 File Offset: 0x0002BE50
		public object GetValue(string key, Type type)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			string text = this.appSettings[key];
			if (text == null)
			{
				throw new InvalidOperationException("'" + key + "' could not be found.");
			}
			if (type == typeof(string))
			{
				return text;
			}
			MethodInfo method = type.GetMethod("Parse", new Type[]
			{
				typeof(string)
			});
			if (method == null)
			{
				throw new InvalidOperationException("Type " + ((type != null) ? type.ToString() : null) + " does not have a Parse method");
			}
			object result = null;
			try
			{
				result = method.Invoke(null, new object[]
				{
					text
				});
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("Parse error.", innerException);
			}
			return result;
		}

		// Token: 0x04000722 RID: 1826
		private NameValueCollection appSettings;
	}
}
