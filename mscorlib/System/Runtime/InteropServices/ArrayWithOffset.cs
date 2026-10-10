using System;
using System.Security;

namespace System.Runtime.InteropServices
{
	/// <summary>Инкапсулирует массив и смещение в указанный массив.</summary>
	// Token: 0x020006E1 RID: 1761
	[ComVisible(true)]
	[Serializable]
	public struct ArrayWithOffset
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</summary>
		/// <param name="array">Управляемый массив.</param>
		/// <param name="offset">Смещение элемента в байтах, передаваемое с помощью вызова неуправляемого кода.</param>
		/// <exception cref="T:System.ArgumentException">Массив больше 2 гигабайт (ГБ).</exception>
		// Token: 0x06004052 RID: 16466 RVA: 0x000E0E46 File Offset: 0x000DF046
		[SecuritySafeCritical]
		public ArrayWithOffset(object array, int offset)
		{
			this.m_array = array;
			this.m_offset = offset;
			this.m_count = 0;
			this.m_count = this.CalculateCount();
		}

		/// <summary>Возвращает управляемый массив, на который ссылается этот массив <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</summary>
		/// <returns>Управляемый массив, на который ссылается этот экземпляр.</returns>
		// Token: 0x06004053 RID: 16467 RVA: 0x000E0E69 File Offset: 0x000DF069
		public object GetArray()
		{
			return this.m_array;
		}

		/// <summary>Возвращает смещение, предоставленное при создании этого массива <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</summary>
		/// <returns>Смещение для этого экземпляра.</returns>
		// Token: 0x06004054 RID: 16468 RVA: 0x000E0E71 File Offset: 0x000DF071
		public int GetOffset()
		{
			return this.m_offset;
		}

		/// <summary>Возвращает хэш-код для этого типа значения.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x06004055 RID: 16469 RVA: 0x000E0E79 File Offset: 0x000DF079
		public override int GetHashCode()
		{
			return this.m_count + this.m_offset;
		}

		/// <summary>Показывает, соответствует ли указанный объект текущему объекту <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если объект соответствует этому массиву <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004056 RID: 16470 RVA: 0x000E0E88 File Offset: 0x000DF088
		public override bool Equals(object obj)
		{
			return obj is ArrayWithOffset && this.Equals((ArrayWithOffset)obj);
		}

		/// <summary>Показывает, соответствует ли указанный объект <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> текущему экземпляру.</summary>
		/// <param name="obj">Ключ <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />, с которым сравнивается этот экземпляр.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> соответствует текущему экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004057 RID: 16471 RVA: 0x000E0EA0 File Offset: 0x000DF0A0
		public bool Equals(ArrayWithOffset obj)
		{
			return obj.m_array == this.m_array && obj.m_offset == this.m_offset && obj.m_count == this.m_count;
		}

		/// <summary>Определяет, совпадают ли значения двух указанных объектов <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />, сравниваемый с параметром <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />, сравниваемый с параметром <paramref name="a" />.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="a" /> совпадает со значением <paramref name="b" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004058 RID: 16472 RVA: 0x000E0ECE File Offset: 0x000DF0CE
		public static bool operator ==(ArrayWithOffset a, ArrayWithOffset b)
		{
			return a.Equals(b);
		}

		/// <summary>Определяет, равны ли значения двух указанных объектов <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />, сравниваемый с параметром <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />, сравниваемый с параметром <paramref name="a" />.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="a" /> не совпадает со значением <paramref name="b" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004059 RID: 16473 RVA: 0x000E0ED8 File Offset: 0x000DF0D8
		public static bool operator !=(ArrayWithOffset a, ArrayWithOffset b)
		{
			return !(a == b);
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x000E0EE4 File Offset: 0x000DF0E4
		private int CalculateCount()
		{
			Array array = this.m_array as Array;
			if (array == null)
			{
				throw new ArgumentException();
			}
			return array.Rank * array.Length - this.m_offset;
		}

		// Token: 0x04002A23 RID: 10787
		private object m_array;

		// Token: 0x04002A24 RID: 10788
		private int m_offset;

		// Token: 0x04002A25 RID: 10789
		private int m_count;
	}
}
