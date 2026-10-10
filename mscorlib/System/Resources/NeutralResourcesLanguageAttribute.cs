using System;

namespace System.Resources
{
	/// <summary>Информирует диспетчер ресурсов о языке и региональных параметрах приложения по умолчанию. Этот класс не наследуется.</summary>
	// Token: 0x0200085C RID: 2140
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class NeutralResourcesLanguageAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" />.</summary>
		/// <param name="cultureName">Имя языка и региональных параметров, в которые записаны нейтральные ресурсы текущей сборки.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="cultureName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004740 RID: 18240 RVA: 0x000E8104 File Offset: 0x000E6304
		public NeutralResourcesLanguageAttribute(string cultureName)
		{
			if (cultureName == null)
			{
				throw new ArgumentNullException("cultureName");
			}
			this.CultureName = cultureName;
			this.Location = 0;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> с использованием заданного конечного местоположения резерва ресурса</summary>
		/// <param name="cultureName">Имя языка и региональных параметров, в которые записаны нейтральные ресурсы текущей сборки.</param>
		/// <param name="location">Одно из значений перечисления, указывающее местоположение, из которого извлекаются нейтральные резервные ресурсы.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="cultureName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="location" /> не является членом <see cref="T:System.Resources.UltimateResourceFallbackLocation" />.</exception>
		// Token: 0x06004741 RID: 18241 RVA: 0x000E8128 File Offset: 0x000E6328
		public NeutralResourcesLanguageAttribute(string cultureName, UltimateResourceFallbackLocation location)
		{
			if (cultureName == null)
			{
				throw new ArgumentNullException("cultureName");
			}
			if (!Enum.IsDefined(typeof(UltimateResourceFallbackLocation), location))
			{
				throw new ArgumentException(SR.Format("The NeutralResourcesLanguageAttribute specifies an invalid or unrecognized ultimate resource fallback location: \"{0}\".", location));
			}
			this.CultureName = cultureName;
			this.Location = location;
		}

		/// <summary>Возвращает имя языка и региональных параметров.</summary>
		/// <returns>Имя языка и региональных параметров по умолчанию для главной сборки.</returns>
		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x000E8184 File Offset: 0x000E6384
		public string CultureName { get; }

		/// <summary>Возвращает расположение класса <see cref="T:System.Resources.ResourceManager" />, применяемого для извлечения нейтральных ресурсов с помощью процесса использования резервных ресурсов.</summary>
		/// <returns>Одно из значений перечисления, указывающее на расположение (главной или вспомогательной сборки), из которого следует извлекать нейтральные ресурсы.</returns>
		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x000E818C File Offset: 0x000E638C
		public UltimateResourceFallbackLocation Location { get; }
	}
}
