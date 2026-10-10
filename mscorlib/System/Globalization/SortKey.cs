using System;
using System.Runtime.InteropServices;
using Unity;

namespace System.Globalization
{
	/// <summary>Представляет результат сопоставления строки ее ключу сортировки.</summary>
	// Token: 0x0200099D RID: 2461
	[ComVisible(true)]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class SortKey
	{
		/// <summary>Сравнивает два ключа сортировки.</summary>
		/// <param name="sortkey1">Сравнивается первый ключ сортировки.</param>
		/// <param name="sortkey2">Сравнивается второй ключ сортировки.</param>
		/// <returns>Целое число со знаком, указывающее на соотношение <paramref name="sortkey1" /> и <paramref name="sortkey2" />.  
		///   Значение 
		///   Условие 
		///   Меньше нуля 
		///  Значение <paramref name="sortkey1" /> меньше <paramref name="sortkey2" />.  
		///
		///   Нуль 
		///  <paramref name="sortkey1" /> равно <paramref name="sortkey2" />.  
		///
		///   Больше нуля 
		///  Значение <paramref name="sortkey1" /> больше значения <paramref name="sortkey2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sortkey1" /> или <paramref name="sortkey2" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005899 RID: 22681 RVA: 0x0012AA88 File Offset: 0x00128C88
		public static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			if (sortkey1 == null)
			{
				throw new ArgumentNullException("sortkey1");
			}
			if (sortkey2 == null)
			{
				throw new ArgumentNullException("sortkey2");
			}
			if (sortkey1 == sortkey2 || sortkey1.OriginalString == sortkey2.OriginalString)
			{
				return 0;
			}
			byte[] keyData = sortkey1.KeyData;
			byte[] keyData2 = sortkey2.KeyData;
			int num = (keyData.Length > keyData2.Length) ? keyData2.Length : keyData.Length;
			int i = 0;
			while (i < num)
			{
				if (keyData[i] != keyData2[i])
				{
					if (keyData[i] >= keyData2[i])
					{
						return 1;
					}
					return -1;
				}
				else
				{
					i++;
				}
			}
			if (keyData.Length == keyData2.Length)
			{
				return 0;
			}
			if (keyData.Length >= keyData2.Length)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x0012AB1C File Offset: 0x00128D1C
		internal SortKey(int lcid, string source, CompareOptions opt)
		{
			this.lcid = lcid;
			this.source = source;
			this.options = opt;
			int length = source.Length;
			byte[] array = new byte[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = (byte)source[i];
			}
			this.key = array;
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x0012AB70 File Offset: 0x00128D70
		internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
		{
			this.lcid = lcid;
			this.source = source;
			this.key = buffer;
			this.options = opt;
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x0012AB95 File Offset: 0x00128D95
		internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает исходную строку, используемую для создания текущего объекта <see cref="T:System.Globalization.SortKey" />.</summary>
		/// <returns>Исходная строка, используемая для создания текущего объекта <see cref="T:System.Globalization.SortKey" />.</returns>
		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x0600589D RID: 22685 RVA: 0x0012ABA2 File Offset: 0x00128DA2
		public virtual string OriginalString
		{
			get
			{
				return this.source;
			}
		}

		/// <summary>Возвращает массив байтов, представляющий текущий объект <see cref="T:System.Globalization.SortKey" />.</summary>
		/// <returns>Массив байтов, представляющий текущий объект <see cref="T:System.Globalization.SortKey" />.</returns>
		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x0600589E RID: 22686 RVA: 0x0012ABAA File Offset: 0x00128DAA
		public virtual byte[] KeyData
		{
			get
			{
				return this.key;
			}
		}

		/// <summary>Определяет, равен ли заданный объект текущему объекту <see cref="T:System.Globalization.SortKey" />.</summary>
		/// <param name="value">Объект, который требуется сравнить с текущим объектом <see cref="T:System.Globalization.SortKey" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="value" /> равно текущему объекту <see cref="T:System.Globalization.SortKey" />, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600589F RID: 22687 RVA: 0x0012ABB4 File Offset: 0x00128DB4
		public override bool Equals(object value)
		{
			SortKey sortKey = value as SortKey;
			return sortKey != null && this.lcid == sortKey.lcid && this.options == sortKey.options && SortKey.Compare(this, sortKey) == 0;
		}

		/// <summary>Служит хэш-функцией текущего объекта <see cref="T:System.Globalization.SortKey" /> для использования в алгоритмах и структурах данных хеширования, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Globalization.SortKey" />.</returns>
		// Token: 0x060058A0 RID: 22688 RVA: 0x0012ABF4 File Offset: 0x00128DF4
		public override int GetHashCode()
		{
			if (this.key.Length == 0)
			{
				return 0;
			}
			int num = (int)this.key[0];
			for (int i = 1; i < this.key.Length; i++)
			{
				num ^= (int)this.key[i] << (i & 3);
			}
			return num;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Globalization.SortKey" />.</summary>
		/// <returns>Строка, представляющая текущий объект <see cref="T:System.Globalization.SortKey" />.</returns>
		// Token: 0x060058A1 RID: 22689 RVA: 0x0012AC3C File Offset: 0x00128E3C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"SortKey - ",
				this.lcid.ToString(),
				", ",
				this.options.ToString(),
				", ",
				this.source
			});
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x000173AD File Offset: 0x000155AD
		internal SortKey()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040036C7 RID: 14023
		private readonly string source;

		// Token: 0x040036C8 RID: 14024
		private readonly byte[] key;

		// Token: 0x040036C9 RID: 14025
		private readonly CompareOptions options;

		// Token: 0x040036CA RID: 14026
		private readonly int lcid;
	}
}
