using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет базовый класс, от которого наследуются все модули удаления форматирования асимметричного обмена ключами.</summary>
	// Token: 0x02000479 RID: 1145
	[ComVisible(true)]
	public abstract class AsymmetricKeyExchangeDeformatter
	{
		/// <summary>При переопределении в производном классе получает или задает параметры для обмена асимметричными ключами.</summary>
		/// <returns>XML-строка, содержащая параметры операции обмена асимметричными ключами.</returns>
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002E63 RID: 11875
		// (set) Token: 0x06002E64 RID: 11876
		public abstract string Parameters { get; set; }

		/// <summary>Если переопределено в производном классе, задает закрытый ключ для расшифровки конфиденциальных данных.</summary>
		/// <param name="key">Экземпляр реализации <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />, в котором содержится закрытый ключ.</param>
		// Token: 0x06002E65 RID: 11877
		public abstract void SetKey(AsymmetricAlgorithm key);

		/// <summary>При переопределении в производном классе извлекает конфиденциальные сведения из зашифрованных данных обмена ключами.</summary>
		/// <param name="rgb">Данные обмена ключами, в которых скрыты конфиденциальные сведения.</param>
		/// <returns>Конфиденциальные сведения, извлекаемые из данных обмена ключами.</returns>
		// Token: 0x06002E66 RID: 11878
		public abstract byte[] DecryptKeyExchange(byte[] rgb);
	}
}
