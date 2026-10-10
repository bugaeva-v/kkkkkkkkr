using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Globalization
{
	/// <summary>Содержит сведения о стране или регионе.</summary>
	// Token: 0x020009AD RID: 2477
	[ComVisible(true)]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class RegionInfo
	{
		/// <summary>Возвращает объект <see cref="T:System.Globalization.RegionInfo" />, представляющий страну/регион, используемые текущим потоком.</summary>
		/// <returns>Объект <see cref="T:System.Globalization.RegionInfo" />, представляющий страну или регион, которые используются текущим потоком.</returns>
		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06005973 RID: 22899 RVA: 0x00132C4C File Offset: 0x00130E4C
		public static RegionInfo CurrentRegion
		{
			get
			{
				RegionInfo regionInfo = RegionInfo.currentRegion;
				if (regionInfo == null)
				{
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					if (currentCulture != null)
					{
						regionInfo = new RegionInfo(currentCulture);
					}
					if (Interlocked.CompareExchange<RegionInfo>(ref RegionInfo.currentRegion, regionInfo, null) != null)
					{
						regionInfo = RegionInfo.currentRegion;
					}
				}
				return regionInfo;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.RegionInfo" />, на основе страны или региона, которые связаны с заданным идентификатором языка и региональных параметров.</summary>
		/// <param name="culture">Идентификатор языка и региональных параметров.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="culture" /> указывает инвариантный, пользовательский или нейтральный язык и региональные параметры.</exception>
		// Token: 0x06005974 RID: 22900 RVA: 0x00132C87 File Offset: 0x00130E87
		public RegionInfo(int culture)
		{
			if (!this.GetByTerritory(CultureInfo.GetCultureInfo(culture)))
			{
				throw new ArgumentException(string.Format("Region ID {0} (0x{0:X4}) is not a supported region.", culture), "culture");
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.RegionInfo" />, основанный на стране или регионе или определенном языке и региональных параметрах, указанных по имени.</summary>
		/// <param name="name">Строка, содержащая код из двух букв, определенный в формате ISO 3166 для страны или региона.  
		/// -или- 
		/// Строка, содержащая имя языка и региональных параметров для определенного языка и региональных параметров, пользовательского языка или региональных параметров или языка и региональных параметров, свойственных только для ОС Windows. Если имя языка и региональных параметров не указано в формате RFC 4646, в приложении должно быть указано имя языка и региональных параметров полностью, а не только название страны или региона.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="name" /> не является допустимым названием страны, региона или определенного языка и региональных параметров.</exception>
		// Token: 0x06005975 RID: 22901 RVA: 0x00132CB8 File Offset: 0x00130EB8
		public RegionInfo(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException();
			}
			if (this.construct_internal_region_from_name(name.ToUpperInvariant()))
			{
				return;
			}
			if (!this.GetByTerritory(CultureInfo.GetCultureInfo(name)))
			{
				throw new ArgumentException(string.Format("Region name {0} is not supported.", name), "name");
			}
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00132D08 File Offset: 0x00130F08
		private RegionInfo(CultureInfo ci)
		{
			if (ci.LCID == 127)
			{
				this.regionId = 244;
				this.iso2Name = "IV";
				this.iso3Name = "ivc";
				this.win3Name = "IVC";
				this.nativeName = (this.englishName = "Invariant Country");
				this.currencySymbol = "¤";
				this.isoCurrencySymbol = "XDR";
				this.currencyEnglishName = (this.currencyNativeName = "International Monetary Fund");
				return;
			}
			if (ci.Territory == null)
			{
				throw new NotImplementedException("Neutral region info");
			}
			this.construct_internal_region_from_name(ci.Territory.ToUpperInvariant());
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00132DB5 File Offset: 0x00130FB5
		private bool GetByTerritory(CultureInfo ci)
		{
			if (ci == null)
			{
				throw new Exception("INTERNAL ERROR: should not happen.");
			}
			return !ci.IsNeutralCulture && ci.Territory != null && this.construct_internal_region_from_name(ci.Territory.ToUpperInvariant());
		}

		// Token: 0x06005978 RID: 22904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool construct_internal_region_from_name(string name);

		/// <summary>Возвращает имя денежной единицы, используемой в стране или регионе, на английском языке.</summary>
		/// <returns>Имя денежной единицы, используемой в стране или регионе, на английском языке.</returns>
		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06005979 RID: 22905 RVA: 0x00132DE8 File Offset: 0x00130FE8
		[ComVisible(false)]
		public virtual string CurrencyEnglishName
		{
			get
			{
				return this.currencyEnglishName;
			}
		}

		/// <summary>Возвращает символ денежной единицы, связанной со страной или регионом.</summary>
		/// <returns>Символ денежной единицы, связанной со страной или регионом.</returns>
		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x0600597A RID: 22906 RVA: 0x00132DF0 File Offset: 0x00130FF0
		public virtual string CurrencySymbol
		{
			get
			{
				return this.currencySymbol;
			}
		}

		/// <summary>Возвращает полное имя страны или региона на языке локализованной версии .NET Framework.</summary>
		/// <returns>Полное имя страны или региона на языке локализованной версии .NET Framework.</returns>
		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x0600597B RID: 22907 RVA: 0x00132DF8 File Offset: 0x00130FF8
		[MonoTODO("DisplayName currently only returns the EnglishName")]
		public virtual string DisplayName
		{
			get
			{
				return this.englishName;
			}
		}

		/// <summary>Возвращает полное имя страны или региона на английском языке.</summary>
		/// <returns>Полное название страны или региона на английском языке.</returns>
		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x0600597C RID: 22908 RVA: 0x00132DF8 File Offset: 0x00130FF8
		public virtual string EnglishName
		{
			get
			{
				return this.englishName;
			}
		}

		/// <summary>Получает уникальный номер идентификации географического региона, страны, города или местности.</summary>
		/// <returns>32-битный номер со знаком, который служит для уникального определения географического местоположения.</returns>
		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x0600597D RID: 22909 RVA: 0x00132E00 File Offset: 0x00131000
		[ComVisible(false)]
		public virtual int GeoId
		{
			get
			{
				return this.regionId;
			}
		}

		/// <summary>Возвращает значение, указывающее, использует ли страна или регион метрическую систему.</summary>
		/// <returns>Значение <see langword="true" />, если страна или регион использует метрическую систему мер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x0600597E RID: 22910 RVA: 0x00132E08 File Offset: 0x00131008
		public virtual bool IsMetric
		{
			get
			{
				string a = this.iso2Name;
				return !(a == "US") && !(a == "UK");
			}
		}

		/// <summary>Возвращает трехзначный символ денежной единицы в формате ISO 4217, связанный со страной или регионом.</summary>
		/// <returns>Трехзначный символ денежной единицы в формате ISO 4217, связанный со страной или регионом.</returns>
		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x0600597F RID: 22911 RVA: 0x00132E39 File Offset: 0x00131039
		public virtual string ISOCurrencySymbol
		{
			get
			{
				return this.isoCurrencySymbol;
			}
		}

		/// <summary>Получает название страны или региона, отформатированное в соответствии с родным языком страны или региона.</summary>
		/// <returns>Собственное имя страны и региона отформатировано в соответствии с правилами языка, связанными с кодом страны региона по стандарту ISO 3166.</returns>
		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06005980 RID: 22912 RVA: 0x00132E41 File Offset: 0x00131041
		[ComVisible(false)]
		public virtual string NativeName
		{
			get
			{
				return this.nativeName;
			}
		}

		/// <summary>Получает имя денежной единицы, используемой в стране или регионе, отформатированное в соответствии с родным языком страны или региона.</summary>
		/// <returns>Собственное имя валюты, используемое в стране или регионе и отформатированное в соответствии с правилами языка, связанными с кодом страны региона по стандарту ISO 3166.</returns>
		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06005981 RID: 22913 RVA: 0x00132E49 File Offset: 0x00131049
		[ComVisible(false)]
		public virtual string CurrencyNativeName
		{
			get
			{
				return this.currencyNativeName;
			}
		}

		/// <summary>Возвращает или задает имя или двухбуквенный код страны или региона в формате ISO 639-1 для текущего объекта <see cref="T:System.Globalization.RegionInfo" />.</summary>
		/// <returns>Значение, заданное в параметре <paramref name="name" /> конструктора <see cref="M:System.Globalization.RegionInfo.#ctor(System.String)" />. Возвращается значение в верхнем регистре.  
		/// -или- 
		/// Двухбуквенный код, указанный в формате ISO 3166 для страны или региона, определяется параметром <paramref name="culture" /> конструктора <see cref="M:System.Globalization.RegionInfo.#ctor(System.Int32)" />. Возвращается значение в верхнем регистре.</returns>
		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06005982 RID: 22914 RVA: 0x00132E51 File Offset: 0x00131051
		public virtual string Name
		{
			get
			{
				return this.iso2Name;
			}
		}

		/// <summary>Возвращает код из трех букв, определенный в формате ISO 3166 для страны или региона.</summary>
		/// <returns>Код из трех букв, определенный в формате ISO 3166 для страны или региона.</returns>
		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06005983 RID: 22915 RVA: 0x00132E59 File Offset: 0x00131059
		public virtual string ThreeLetterISORegionName
		{
			get
			{
				return this.iso3Name;
			}
		}

		/// <summary>Возвращает код из трех букв, присвоенный операционной системой Windows стране/региону, представленный этим <see cref="T:System.Globalization.RegionInfo" />.</summary>
		/// <returns>Код из трех букв, присвоенный операционной системой Windows стране/региону, представленный этим <see cref="T:System.Globalization.RegionInfo" />.</returns>
		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06005984 RID: 22916 RVA: 0x00132E61 File Offset: 0x00131061
		public virtual string ThreeLetterWindowsRegionName
		{
			get
			{
				return this.win3Name;
			}
		}

		/// <summary>Возвращает код из двух букв, определенный в формате ISO 3166 для страны или региона.</summary>
		/// <returns>Код из двух букв, определенный в формате ISO 3166 для страны или региона.</returns>
		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06005985 RID: 22917 RVA: 0x00132E51 File Offset: 0x00131051
		public virtual string TwoLetterISORegionName
		{
			get
			{
				return this.iso2Name;
			}
		}

		/// <summary>Определяет, является ли заданный объект тем же экземпляром, что и текущий <see cref="T:System.Globalization.RegionInfo" />.</summary>
		/// <param name="value">Объект для сравнения с текущим объектом <see cref="T:System.Globalization.RegionInfo" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> является объектом <see cref="T:System.Globalization.RegionInfo" />, а его свойство <see cref="P:System.Globalization.RegionInfo.Name" /> равно свойству <see cref="P:System.Globalization.RegionInfo.Name" /> текущего объекта <see cref="T:System.Globalization.RegionInfo" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005986 RID: 22918 RVA: 0x00132E6C File Offset: 0x0013106C
		public override bool Equals(object value)
		{
			RegionInfo regionInfo = value as RegionInfo;
			return regionInfo != null && this.Name == regionInfo.Name;
		}

		/// <summary>Служит хэш-функцией текущего класса <see cref="T:System.Globalization.RegionInfo" /> для использования в алгоритмах и структурах данных хеширования, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Globalization.RegionInfo" />.</returns>
		// Token: 0x06005987 RID: 22919 RVA: 0x00132E96 File Offset: 0x00131096
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		/// <summary>Возвращает строку, содержащую имя языка и региональных параметров или двухбуквенные коды, определенные в формате ISO 3166, для текущего <see cref="T:System.Globalization.RegionInfo" />.</summary>
		/// <returns>Строка, содержащая имя языка и региональных параметров или двухбуквенные коды страны или региона в формате ISO 3166 для текущего объекта <see cref="T:System.Globalization.RegionInfo" />.</returns>
		// Token: 0x06005988 RID: 22920 RVA: 0x00132EA3 File Offset: 0x001310A3
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00132EAB File Offset: 0x001310AB
		internal static void ClearCachedData()
		{
			RegionInfo.currentRegion = null;
		}

		// Token: 0x04003761 RID: 14177
		private static RegionInfo currentRegion;

		// Token: 0x04003762 RID: 14178
		private int regionId;

		// Token: 0x04003763 RID: 14179
		private string iso2Name;

		// Token: 0x04003764 RID: 14180
		private string iso3Name;

		// Token: 0x04003765 RID: 14181
		private string win3Name;

		// Token: 0x04003766 RID: 14182
		private string englishName;

		// Token: 0x04003767 RID: 14183
		private string nativeName;

		// Token: 0x04003768 RID: 14184
		private string currencySymbol;

		// Token: 0x04003769 RID: 14185
		private string isoCurrencySymbol;

		// Token: 0x0400376A RID: 14186
		private string currencyEnglishName;

		// Token: 0x0400376B RID: 14187
		private string currencyNativeName;
	}
}
