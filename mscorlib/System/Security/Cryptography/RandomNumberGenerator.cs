using System;
using System.Buffers;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный класс, из которого создаются все реализации криптографических генераторов случайных чисел.</summary>
	// Token: 0x020004A0 RID: 1184
	[ComVisible(true)]
	public abstract class RandomNumberGenerator : IDisposable
	{
		/// <summary>Создает экземпляр реализации по умолчанию криптографического генератора случайных чисел, позволяющего генерировать случайные данные.</summary>
		/// <returns>Новый экземпляр криптографического генератора случайных чисел.</returns>
		// Token: 0x06002F61 RID: 12129 RVA: 0x000A8C96 File Offset: 0x000A6E96
		public static RandomNumberGenerator Create()
		{
			return RandomNumberGenerator.Create("System.Security.Cryptography.RandomNumberGenerator");
		}

		/// <summary>Создает экземпляр указанной реализации криптографического генератора случайных чисел.</summary>
		/// <param name="rngName">Имя реализации генератора случайных чисел, которую необходимо использовать.</param>
		/// <returns>Новый экземпляр криптографического генератора случайных чисел.</returns>
		// Token: 0x06002F62 RID: 12130 RVA: 0x000A8CA2 File Offset: 0x000A6EA2
		public static RandomNumberGenerator Create(string rngName)
		{
			return (RandomNumberGenerator)CryptoConfig.CreateFromName(rngName);
		}

		/// <summary>При переопределении в производном классе освобождает все ресурсы, используемые текущим объектом <see cref="T:System.Security.Cryptography.RandomNumberGenerator" />.</summary>
		// Token: 0x06002F63 RID: 12131 RVA: 0x000A8CAF File Offset: 0x000A6EAF
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>При переопределении в производном классе освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.RandomNumberGenerator" />, и при необходимости также освобождает управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x06002F64 RID: 12132 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>При переопределении в производном классе заполняет массив байтов криптостойкой случайной последовательностью значений.</summary>
		/// <param name="data">Массив, который заполняется криптостойкими случайными байтами.</param>
		// Token: 0x06002F65 RID: 12133
		public abstract void GetBytes(byte[] data);

		/// <summary>Заполняет указанный массив байтов криптостойкой случайной последовательностью значений.</summary>
		/// <param name="data">Массив, который заполняется криптостойкими случайными байтами.</param>
		/// <param name="offset">Индекс в массиве, с которого требуется начать заполнение.</param>
		/// <param name="count">Число байтов, которые требуется заполнить.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="count" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма значений <paramref name="offset" /> и <paramref name="count" /> превышает длину <paramref name="data" />.</exception>
		// Token: 0x06002F66 RID: 12134 RVA: 0x000A8CC0 File Offset: 0x000A6EC0
		public virtual void GetBytes(byte[] data, int offset, int count)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("Non-negative number required."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (offset + count > data.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			if (count > 0)
			{
				byte[] array = new byte[count];
				this.GetBytes(array);
				Array.Copy(array, 0, data, offset, count);
			}
		}

		/// <summary>При переопределении в производном классе заполняет массив байтов криптостойкой случайной последовательностью ненулевых значений.</summary>
		/// <param name="data">Массив, который заполняется криптостойкими случайными ненулевыми байтами.</param>
		// Token: 0x06002F67 RID: 12135 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual void GetNonZeroBytes(byte[] data)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000A8D41 File Offset: 0x000A6F41
		public static void Fill(Span<byte> data)
		{
			RandomNumberGenerator.FillSpan(data);
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000A8D4C File Offset: 0x000A6F4C
		internal unsafe static void FillSpan(Span<byte> data)
		{
			if (data.Length > 0)
			{
				fixed (byte* pinnableReference = data.GetPinnableReference())
				{
					Interop.GetRandomBytes(pinnableReference, data.Length);
				}
			}
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x000A8D7C File Offset: 0x000A6F7C
		public virtual void GetBytes(Span<byte> data)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(data.Length);
			try
			{
				this.GetBytes(array, 0, data.Length);
				new ReadOnlySpan<byte>(array, 0, data.Length).CopyTo(data);
			}
			finally
			{
				Array.Clear(array, 0, data.Length);
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000A8DF0 File Offset: 0x000A6FF0
		public virtual void GetNonZeroBytes(Span<byte> data)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(data.Length);
			try
			{
				this.GetNonZeroBytes(array);
				new ReadOnlySpan<byte>(array, 0, data.Length).CopyTo(data);
			}
			finally
			{
				Array.Clear(array, 0, data.Length);
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000A8E5C File Offset: 0x000A705C
		public unsafe static int GetInt32(int fromInclusive, int toExclusive)
		{
			if (fromInclusive >= toExclusive)
			{
				throw new ArgumentException("Range of random number does not contain at least one possibility.");
			}
			uint num = (uint)(toExclusive - fromInclusive - 1);
			if (num == 0U)
			{
				return fromInclusive;
			}
			uint num2 = num;
			num2 |= num2 >> 1;
			num2 |= num2 >> 2;
			num2 |= num2 >> 4;
			num2 |= num2 >> 8;
			num2 |= num2 >> 16;
			Span<uint> span = new Span<uint>(stackalloc byte[(UIntPtr)4], 1);
			uint num3;
			do
			{
				RandomNumberGenerator.FillSpan(MemoryMarshal.AsBytes<uint>(span));
				num3 = (num2 & *span[0]);
			}
			while (num3 > num);
			return (int)(num3 + (uint)fromInclusive);
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000A8ECD File Offset: 0x000A70CD
		public static int GetInt32(int toExclusive)
		{
			if (toExclusive <= 0)
			{
				throw new ArgumentOutOfRangeException("toExclusive", "Positive number required.");
			}
			return RandomNumberGenerator.GetInt32(0, toExclusive);
		}
	}
}
