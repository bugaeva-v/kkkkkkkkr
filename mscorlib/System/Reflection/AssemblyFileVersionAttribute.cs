using System;

namespace System.Reflection
{
	/// <summary>Дает компилятору указание использовать определенный номер версии для ресурса версии файла Win32. Версия файла Win32 не обязательно должна совпадать с номером версии сборки.</summary>
	// Token: 0x02000886 RID: 2182
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyFileVersionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyFileVersionAttribute" />, определяющий версию файла.</summary>
		/// <param name="version">Версия файла.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="version" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600485F RID: 18527 RVA: 0x000EE0A5 File Offset: 0x000EC2A5
		public AssemblyFileVersionAttribute(string version)
		{
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			this.Version = version;
		}

		/// <summary>Возвращает имя ресурса версии файла Win32.</summary>
		/// <returns>Строка, содержащая имя ресурса версии файла.</returns>
		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x000EE0C2 File Offset: 0x000EC2C2
		public string Version { get; }
	}
}
