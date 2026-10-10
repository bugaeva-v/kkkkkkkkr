using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет лицензионное содержимое этапа разработки, позволяющее поддерживать работу поставщика лицензий во время разработки.</summary>
	// Token: 0x0200044D RID: 1101
	public class DesigntimeLicenseContext : LicenseContext
	{
		/// <summary>Возвращает режим использования лицензии.</summary>
		/// <returns>Свойство <see cref="T:System.ComponentModel.LicenseUsageMode" />, указывающее режим лицензирования для контекста.</returns>
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x0000390E File Offset: 0x00001B0E
		public override LicenseUsageMode UsageMode
		{
			get
			{
				return LicenseUsageMode.Designtime;
			}
		}

		/// <summary>Возвращает сохраненный лицензионный ключ.</summary>
		/// <param name="type">Тип лицензионного ключа.</param>
		/// <param name="resourceAssembly">Сборка, из которой нужно вернуть ключ.</param>
		/// <returns>Сохраненный лицензионный ключ, соответствующий заданному типу.</returns>
		// Token: 0x060023D9 RID: 9177 RVA: 0x00002F6A File Offset: 0x0000116A
		public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			return null;
		}

		/// <summary>Задает сохраненный лицензионный ключ.</summary>
		/// <param name="type">Тип лицензионного ключа.</param>
		/// <param name="key">Лицензионный ключ.</param>
		// Token: 0x060023DA RID: 9178 RVA: 0x00081450 File Offset: 0x0007F650
		public override void SetSavedLicenseKey(Type type, string key)
		{
			this.savedLicenseKeys[type.AssemblyQualifiedName] = key;
		}

		// Token: 0x040010C0 RID: 4288
		internal Hashtable savedLicenseKeys = new Hashtable();
	}
}
