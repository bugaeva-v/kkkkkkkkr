using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный класс, от которого должны наследоваться все алгоритмы создания масок.</summary>
	// Token: 0x0200049C RID: 1180
	[ComVisible(true)]
	public abstract class MaskGenerationMethod
	{
		/// <summary>При переопределении в производном классе создает маску указанной длины с помощью заданного случайного начального значения.</summary>
		/// <param name="rgbSeed">Случайное начальное значение, используемое для вычисления маски.</param>
		/// <param name="cbReturn">Длина создаваемой маски в байтах.</param>
		/// <returns>Созданная случайным образом маска, длина которой равна значению параметра <paramref name="cbReturn" />.</returns>
		// Token: 0x06002F42 RID: 12098
		[ComVisible(true)]
		public abstract byte[] GenerateMask(byte[] rgbSeed, int cbReturn);
	}
}
