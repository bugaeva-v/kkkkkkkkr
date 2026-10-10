using System;

namespace System.Resources
{
	/// <summary>Предписывает объекту <see cref="T:System.Resources.ResourceManager" /> запросить определенную версию вспомогательной сборки.</summary>
	// Token: 0x02000861 RID: 2145
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.SatelliteContractVersionAttribute" />.</summary>
		/// <param name="version">Строка, указывающая версию вспомогательных сборок для загрузки.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="version" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004759 RID: 18265 RVA: 0x000E87B8 File Offset: 0x000E69B8
		public SatelliteContractVersionAttribute(string version)
		{
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			this.Version = version;
		}

		/// <summary>Получает версию вспомогательных сборок, содержащих требуемые ресурсы.</summary>
		/// <returns>Строка, содержащая версию вспомогательных сборок с требуемыми ресурсами.</returns>
		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x000E87D5 File Offset: 0x000E69D5
		public string Version { get; }
	}
}
