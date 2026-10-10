using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Определяет базовые операции криптографических преобразований.</summary>
	// Token: 0x02000498 RID: 1176
	[ComVisible(true)]
	public interface ICryptoTransform : IDisposable
	{
		/// <summary>Возвращает размер входного блока.</summary>
		/// <returns>Размер входного блока данных в байтах.</returns>
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002F1E RID: 12062
		int InputBlockSize { get; }

		/// <summary>Возвращает размер выходного блока.</summary>
		/// <returns>Размер выходного блока данных в байтах.</returns>
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002F1F RID: 12063
		int OutputBlockSize { get; }

		/// <summary>Получает значение, указывающее на возможность преобразования нескольких блоков.</summary>
		/// <returns>Значение <see langword="true" />, если возможно преобразование нескольких блоков; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002F20 RID: 12064
		bool CanTransformMultipleBlocks { get; }

		/// <summary>Возвращает значение, указывающее, возможно ли повторное использование текущего преобразования.</summary>
		/// <returns>Значение <see langword="true" />, если возможно повторное использование текущего преобразования; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002F21 RID: 12065
		bool CanReuseTransform { get; }

		/// <summary>Преобразует заданную область входного массива байтов и копирует результат в заданную область выходного массива байтов.</summary>
		/// <param name="inputBuffer">Входные данные, для которых вычисляется преобразование.</param>
		/// <param name="inputOffset">Смещение во входном массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="inputCount">Число байтов во входном массиве для использования в качестве данных.</param>
		/// <param name="outputBuffer">Выходной массив, в который записывается результат преобразования.</param>
		/// <param name="outputOffset">Смещение в выходном массиве байтов, начиная с которого следует записывать данные.</param>
		/// <returns>Число записанных байтов.</returns>
		// Token: 0x06002F22 RID: 12066
		int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

		/// <summary>Преобразует заданную область заданного массива байтов.</summary>
		/// <param name="inputBuffer">Входные данные, для которых вычисляется преобразование.</param>
		/// <param name="inputOffset">Смещение в массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="inputCount">Число байтов в массиве для использования в качестве данных.</param>
		/// <returns>Вычисленное преобразование.</returns>
		// Token: 0x06002F23 RID: 12067
		byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
	}
}
