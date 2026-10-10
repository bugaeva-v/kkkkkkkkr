using System;

namespace System.Globalization
{
	/// <summary>Предоставляет сведения о версии Юникода, используемой для сравнения и сортировки строк.</summary>
	// Token: 0x0200096E RID: 2414
	[Serializable]
	public sealed class SortVersion : IEquatable<SortVersion>
	{
		/// <summary>Получает полный номер версии объекта <see cref="T:System.Globalization.SortVersion" />.</summary>
		/// <returns>Номер версии данного объекта <see cref="T:System.Globalization.SortVersion" />.</returns>
		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x0011E38D File Offset: 0x0011C58D
		public int FullVersion
		{
			get
			{
				return this.m_NlsVersion;
			}
		}

		/// <summary>Получает глобальный уникальный идентификатор для этого объекта <see cref="T:System.Globalization.SortVersion" />.</summary>
		/// <returns>Глобальный уникальный идентификатор для этого объекта <see cref="T:System.Globalization.SortVersion" />.</returns>
		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x0600554A RID: 21834 RVA: 0x0011E395 File Offset: 0x0011C595
		public Guid SortId
		{
			get
			{
				return this.m_SortId;
			}
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Globalization.SortVersion" />.</summary>
		/// <param name="fullVersion">Номер версии.</param>
		/// <param name="sortId">Идентификатор сортировки</param>
		// Token: 0x0600554B RID: 21835 RVA: 0x0011E39D File Offset: 0x0011C59D
		public SortVersion(int fullVersion, Guid sortId)
		{
			this.m_SortId = sortId;
			this.m_NlsVersion = fullVersion;
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x0011E3B4 File Offset: 0x0011C5B4
		internal SortVersion(int nlsVersion, int effectiveId, Guid customVersion)
		{
			this.m_NlsVersion = nlsVersion;
			if (customVersion == Guid.Empty)
			{
				byte h = (byte)(effectiveId >> 24);
				byte i = (byte)((effectiveId & 16711680) >> 16);
				byte j = (byte)((effectiveId & 65280) >> 8);
				byte k = (byte)(effectiveId & 255);
				customVersion = new Guid(0, 0, 0, 0, 0, 0, 0, h, i, j, k);
			}
			this.m_SortId = customVersion;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр <see cref="T:System.Globalization.SortVersion" /> указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является объектом <see cref="T:System.Globalization.SortVersion" />, представляющим такую же версию, что и данный экземпляр; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600554D RID: 21837 RVA: 0x0011E41C File Offset: 0x0011C61C
		public override bool Equals(object obj)
		{
			SortVersion sortVersion = obj as SortVersion;
			return sortVersion != null && this.Equals(sortVersion);
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр <see cref="T:System.Globalization.SortVersion" /> указанному объекту <see cref="T:System.Globalization.SortVersion" />.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="other" /> представляет ту же версию, что и данный экземпляр; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600554E RID: 21838 RVA: 0x0011E442 File Offset: 0x0011C642
		public bool Equals(SortVersion other)
		{
			return !(other == null) && this.m_NlsVersion == other.m_NlsVersion && this.m_SortId == other.m_SortId;
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600554F RID: 21839 RVA: 0x0011E470 File Offset: 0x0011C670
		public override int GetHashCode()
		{
			return this.m_NlsVersion * 7 | this.m_SortId.GetHashCode();
		}

		/// <summary>Указывает, равны ли два экземпляра <see cref="T:System.Globalization.SortVersion" />.</summary>
		/// <param name="left">Первый экземпляр для сравнения.</param>
		/// <param name="right">Второй экземпляр для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005550 RID: 21840 RVA: 0x0011E48C File Offset: 0x0011C68C
		public static bool operator ==(SortVersion left, SortVersion right)
		{
			if (left != null)
			{
				return left.Equals(right);
			}
			return right == null || right.Equals(left);
		}

		/// <summary>Показывает, являются ли два экземпляра <see cref="T:System.Globalization.SortVersion" /> неравными.</summary>
		/// <param name="left">Первый экземпляр для сравнения.</param>
		/// <param name="right">Второй экземпляр для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005551 RID: 21841 RVA: 0x0011E4A5 File Offset: 0x0011C6A5
		public static bool operator !=(SortVersion left, SortVersion right)
		{
			return !(left == right);
		}

		// Token: 0x040034E2 RID: 13538
		private int m_NlsVersion;

		// Token: 0x040034E3 RID: 13539
		private Guid m_SortId;
	}
}
