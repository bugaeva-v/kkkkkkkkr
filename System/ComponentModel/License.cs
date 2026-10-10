using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет абстрактный (<see langword="abstract" />) базовый класс для всех лицензий. Лицензия предоставляется конкретному экземпляру компонента.</summary>
	// Token: 0x020003C6 RID: 966
	public abstract class License : IDisposable
	{
		/// <summary>При переопределении в производном классе возвращает ключ лицензии, предоставленной для этого компонента.</summary>
		/// <returns>Ключ лицензии, предоставленной для этого компонента.</returns>
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001F46 RID: 8006
		public abstract string LicenseKey { get; }

		/// <summary>При переопределении в производном классе уничтожает используемые лицензией ресурсы.</summary>
		// Token: 0x06001F47 RID: 8007
		public abstract void Dispose();
	}
}
