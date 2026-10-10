using System;
using System.Globalization;
using System.Resources;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет конструкторам интерфейс для получения доступа к устройствам чтения и записи ресурсов для определенных типов ресурсов класса <see cref="T:System.Globalization.CultureInfo" />.</summary>
	// Token: 0x02000467 RID: 1127
	public interface IResourceService
	{
		/// <summary>Осуществляет поиск устройства чтения ресурсов для заданной культуры.</summary>
		/// <param name="info">Класс <see cref="T:System.Globalization.CultureInfo" /> ресурса, для которого необходимо загрузить устройство чтения ресурсов.</param>
		/// <returns>Интерфейс <see cref="T:System.Resources.IResourceReader" />, содержащий ресурсы для культуры, или значение <see langword="null" />, если для нее не существует ресурсов.</returns>
		// Token: 0x06002466 RID: 9318
		IResourceReader GetResourceReader(CultureInfo info);

		/// <summary>Осуществляет поиск устройства записи ресурсов для заданной культуры.</summary>
		/// <param name="info">Класс <see cref="T:System.Globalization.CultureInfo" /> ресурса, для которого необходимо создать устройство записи ресурсов.</param>
		/// <returns>Интерфейс <see cref="T:System.Resources.IResourceWriter" /> для заданной культуры.</returns>
		// Token: 0x06002467 RID: 9319
		IResourceWriter GetResourceWriter(CultureInfo info);
	}
}
