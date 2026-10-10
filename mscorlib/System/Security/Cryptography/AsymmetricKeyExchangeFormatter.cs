using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет базовый класс, от которого наследуют все модули форматирования асимметричного обмена ключами.</summary>
	// Token: 0x0200047A RID: 1146
	[ComVisible(true)]
	public abstract class AsymmetricKeyExchangeFormatter
	{
		/// <summary>При переопределении в производном классе получает параметры для обмена асимметричными ключами.</summary>
		/// <returns>XML-строка, содержащая параметры операции обмена асимметричными ключами.</returns>
		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002E68 RID: 11880
		public abstract string Parameters { get; }

		/// <summary>При переопределении в производном классе задает открытый ключ, используемый для шифрования секретных данных.</summary>
		/// <param name="key">Экземпляр реализации <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />, в котором содержится открытый ключ.</param>
		// Token: 0x06002E69 RID: 11881
		public abstract void SetKey(AsymmetricAlgorithm key);

		/// <summary>При переопределении в производном классе создает зашифрованные данные обмена ключами из указанных входных данных.</summary>
		/// <param name="data">Секретные сведения, которые будут переданы при обмене ключами.</param>
		/// <returns>Зашифрованные данные обмена ключами для отправки предполагаемому получателю.</returns>
		// Token: 0x06002E6A RID: 11882
		public abstract byte[] CreateKeyExchange(byte[] data);

		/// <summary>При переопределении в производном классе создает зашифрованные данные обмена ключами из указанных входных данных.</summary>
		/// <param name="data">Секретные сведения, которые будут переданы при обмене ключами.</param>
		/// <param name="symAlgType">Этот параметр не используется в текущей версии.</param>
		/// <returns>Зашифрованные данные обмена ключами для отправки предполагаемому получателю.</returns>
		// Token: 0x06002E6B RID: 11883
		public abstract byte[] CreateKeyExchange(byte[] data, Type symAlgType);
	}
}
