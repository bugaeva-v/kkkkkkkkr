using System;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет объекты <see cref="T:Microsoft.Win32.RegistryKey" />, представляющие корневые разделы в реестре Windows, и методы <see langword="static" /> для доступа к парам "раздел-значение".</summary>
	// Token: 0x020000A1 RID: 161
	public static class Registry
	{
		/// <summary>Извлекает значение, связанное с указанным именем, в указанном разделе реестра. Если имя не найдено в указанном разделе, возвращает предоставленное значение по умолчанию или значение <see langword="null" />, если указанный раздел не существует.</summary>
		/// <param name="keyName">Полный путь к разделу реестра, начинающийся с правильного корневого раздела реестра, такого как HKEY_CURRENT_USER.</param>
		/// <param name="valueName">Имя в паре "имя-значение".</param>
		/// <param name="defaultValue">Возвращаемое значение, если параметр <paramref name="valueName" /> не существует.</param>
		/// <returns>Значение <see langword="null" />, если вложенный раздел, заданный параметром <paramref name="keyName" />, не существует; в противном случае — значение, связанное с параметром <paramref name="valueName" />, или <paramref name="defaultValue" />, если значение параметра <paramref name="valueName" /> не найдено.</returns>
		/// <exception cref="T:System.Security.SecurityException">У пользователя отсутствуют разрешения, необходимые для чтения из раздела реестра.</exception>
		/// <exception cref="T:System.IO.IOException">Раздел <see cref="T:Microsoft.Win32.RegistryKey" />, содержащий заданное значение, был помечен для удаления.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="keyName" /> не начинается с правильного корневого раздела реестра.</exception>
		// Token: 0x06000404 RID: 1028 RVA: 0x00015948 File Offset: 0x00013B48
		public static object GetValue(string keyName, string valueName, object defaultValue)
		{
			string name;
			object result;
			using (RegistryKey registryKey = Registry.GetBaseKeyFromKeyName(keyName, out name).OpenSubKey(name))
			{
				result = ((registryKey != null) ? registryKey.GetValue(valueName, defaultValue) : null);
			}
			return result;
		}

		/// <summary>Задает указанное значение пары "имя-значение" для указанного раздела реестра. Если указанный раздел не существует, он будет создан.</summary>
		/// <param name="keyName">Полный путь к разделу реестра, начинающийся с правильного корневого раздела реестра, такого как HKEY_CURRENT_USER.</param>
		/// <param name="valueName">Имя в паре "имя-значение".</param>
		/// <param name="value">Сохраняемое значение.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="keyName" /> не начинается с правильного корневого раздела реестра.  
		/// -или- 
		///  Значение параметра <paramref name="keyName" /> длиннее максимально допустимой длины (255 знаков).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Раздел <see cref="T:Microsoft.Win32.RegistryKey" /> является разделом только для чтения и запись в него невозможна, например, если это узел корневого уровня.</exception>
		/// <exception cref="T:System.Security.SecurityException">У пользователя отсутствуют разрешения, необходимые для изменения разделов реестра.</exception>
		// Token: 0x06000405 RID: 1029 RVA: 0x00015990 File Offset: 0x00013B90
		public static void SetValue(string keyName, string valueName, object value)
		{
			Registry.SetValue(keyName, valueName, value, RegistryValueKind.Unknown);
		}

		/// <summary>Задает пару "имя-значение" для указанного раздела реестра, используя указанный тип данных реестра. Если указанный раздел не существует, он будет создан.</summary>
		/// <param name="keyName">Полный путь к разделу реестра, начинающийся с правильного корневого раздела реестра, такого как HKEY_CURRENT_USER.</param>
		/// <param name="valueName">Имя в паре "имя-значение".</param>
		/// <param name="value">Сохраняемое значение.</param>
		/// <param name="valueKind">Тип данных реестра, используемый при сохранении данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="keyName" /> не начинается с правильного корневого раздела реестра.  
		/// -или- 
		///  Значение параметра <paramref name="keyName" /> длиннее максимально допустимой длины (255 знаков).  
		/// -или- 
		/// Тип параметра <paramref name="value" /> не соответствует типу данных реестра, заданному параметром <paramref name="valueKind" />, поэтому данные не удалось правильно преобразовать.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Раздел <see cref="T:Microsoft.Win32.RegistryKey" /> доступен только для чтения, и, следовательно, запись в него невозможна (например, это узел корневого уровня или раздел не был открыт с доступом для записи).</exception>
		/// <exception cref="T:System.Security.SecurityException">У пользователя отсутствуют разрешения, необходимые для изменения разделов реестра.</exception>
		// Token: 0x06000406 RID: 1030 RVA: 0x0001599C File Offset: 0x00013B9C
		public static void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind)
		{
			string subkey;
			using (RegistryKey registryKey = Registry.GetBaseKeyFromKeyName(keyName, out subkey).CreateSubKey(subkey))
			{
				registryKey.SetValue(valueName, value, valueKind);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000159E0 File Offset: 0x00013BE0
		private static RegistryKey GetBaseKeyFromKeyName(string keyName, out string subKeyName)
		{
			if (keyName == null)
			{
				throw new ArgumentNullException("keyName");
			}
			int num = keyName.IndexOf('\\');
			int num2 = (num != -1) ? num : keyName.Length;
			RegistryKey registryKey = null;
			if (num2 != 10)
			{
				switch (num2)
				{
				case 17:
					registryKey = ((char.ToUpperInvariant(keyName[6]) == 'L') ? Registry.ClassesRoot : Registry.CurrentUser);
					break;
				case 18:
					registryKey = Registry.LocalMachine;
					break;
				case 19:
					registryKey = Registry.CurrentConfig;
					break;
				case 21:
					registryKey = Registry.PerformanceData;
					break;
				}
			}
			else
			{
				registryKey = Registry.Users;
			}
			if (registryKey != null && keyName.StartsWith(registryKey.Name, StringComparison.OrdinalIgnoreCase))
			{
				subKeyName = ((num == -1 || num == keyName.Length) ? string.Empty : keyName.Substring(num + 1, keyName.Length - num - 1));
				return registryKey;
			}
			throw new ArgumentException(SR.Format("Registry key name must start with a valid base key name.", "keyName"), "keyName");
		}

		/// <summary>Содержит сведения о текущих пользовательских параметрах. Это поле считывает базовый раздел реестра Windows HKEY_CURRENT_USER.</summary>
		// Token: 0x04000F46 RID: 3910
		public static readonly RegistryKey CurrentUser = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);

		/// <summary>Содержит данные о конфигурации для локального компьютера. Это поле считывает базовый раздел реестра Windows HKEY_LOCAL_MACHINE.</summary>
		// Token: 0x04000F47 RID: 3911
		public static readonly RegistryKey LocalMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);

		/// <summary>Определяет типы (или классы) документов и свойства, связанные с этими типами. Это поле считывает базовый раздел реестра Windows HKEY_CLASSES_ROOT.</summary>
		// Token: 0x04000F48 RID: 3912
		public static readonly RegistryKey ClassesRoot = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Default);

		/// <summary>Содержит сведения о стандартной пользовательской конфигурации. Это поле считывает базовый раздел реестра Windows HKEY_USERS.</summary>
		// Token: 0x04000F49 RID: 3913
		public static readonly RegistryKey Users = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Default);

		/// <summary>Содержит сведения о производительности для компонентов программного обеспечения. Это поле считывает базовый раздел реестра Windows HKEY_PERFORMANCE_DATA.</summary>
		// Token: 0x04000F4A RID: 3914
		public static readonly RegistryKey PerformanceData = RegistryKey.OpenBaseKey(RegistryHive.PerformanceData, RegistryView.Default);

		/// <summary>Содержит сведения о конфигурации, относящиеся к оборудованию, не связанному с конкретным пользователем. Это поле считывает базовый раздел реестра Windows HKEY_CURRENT_CONFIG.</summary>
		// Token: 0x04000F4B RID: 3915
		public static readonly RegistryKey CurrentConfig = RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, RegistryView.Default);

		/// <summary>Содержит динамические данные реестра. Это поле считывает базовый раздел реестра Windows HKEY_DYN_DATA.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Операционная система не поддерживает платформу динамических данных, то есть она не может быть Windows 98, Windows 98 Second Edition или Windows Millennium Edition (Windows Me).</exception>
		// Token: 0x04000F4C RID: 3916
		[Obsolete("Use PerformanceData instead")]
		public static readonly RegistryKey DynData = RegistryKey.OpenBaseKey(RegistryHive.DynData, RegistryView.Default);
	}
}
