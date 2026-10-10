using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов <see cref="T:System.Globalization.CultureInfo" /> в прочие представления и обратно.</summary>
	// Token: 0x02000390 RID: 912
	public class CultureInfoConverter : TypeConverter
	{
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00069EA8 File Offset: 0x000680A8
		private string DefaultCultureString
		{
			get
			{
				return "(Default)";
			}
		}

		/// <summary>Извлекает имя заданного языка и региональных параметров.</summary>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий язык и региональные параметры, для которых необходимо получить имя.</param>
		/// <returns>Имя заданного языка и региональных параметров.</returns>
		// Token: 0x06001DF1 RID: 7665 RVA: 0x00069EAF File Offset: 0x000680AF
		protected virtual string GetCultureName(CultureInfo culture)
		{
			return culture.Name;
		}

		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь выполнить преобразование объекта заданного исходного типа в <see cref="T:System.Globalization.CultureInfo" />, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001DF2 RID: 7666 RVA: 0x00069EB7 File Offset: 0x000680B7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который необходимо выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001DF3 RID: 7667 RVA: 0x00069ED5 File Offset: 0x000680D5
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует указанный объект-значение в <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий язык и региональные параметры для преобразования.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentException">В параметре <paramref name="value" /> указаны неправильные язык и региональные параметры.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001DF4 RID: 7668 RVA: 0x00069EF4 File Offset: 0x000680F4
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (!(value is string))
			{
				return base.ConvertFrom(context, culture, value);
			}
			string text = (string)value;
			if (this.GetCultureName(CultureInfo.InvariantCulture).Equals(""))
			{
				text = CultureInfoConverter.CultureInfoMapper.GetCultureInfoName((string)value);
			}
			CultureInfo cultureInfo = null;
			string strB = this.DefaultCultureString;
			if (culture != null && culture.Equals(CultureInfo.InvariantCulture))
			{
				strB = "(Default)";
			}
			if (text == null || text.Length == 0 || string.Compare(text, strB, StringComparison.Ordinal) == 0)
			{
				cultureInfo = CultureInfo.InvariantCulture;
			}
			if (cultureInfo == null)
			{
				foreach (object obj in this.GetStandardValues(context))
				{
					CultureInfo cultureInfo2 = (CultureInfo)obj;
					if (cultureInfo2 != null && string.Compare(this.GetCultureName(cultureInfo2), text, StringComparison.Ordinal) == 0)
					{
						cultureInfo = cultureInfo2;
						break;
					}
				}
			}
			if (cultureInfo == null)
			{
				try
				{
					cultureInfo = new CultureInfo(text);
				}
				catch
				{
				}
			}
			if (cultureInfo == null)
			{
				text = text.ToLower(CultureInfo.CurrentCulture);
				foreach (object obj2 in this._values)
				{
					CultureInfo cultureInfo3 = (CultureInfo)obj2;
					if (cultureInfo3 != null && this.GetCultureName(cultureInfo3).ToLower(CultureInfo.CurrentCulture).StartsWith(text))
					{
						cultureInfo = cultureInfo3;
						break;
					}
				}
			}
			if (cultureInfo == null)
			{
				throw new ArgumentException(SR.Format("The {0} culture cannot be converted to a CultureInfo object on this computer.", (string)value));
			}
			return cultureInfo;
		}

		/// <summary>Преобразовывает указанное значение объекта в указанный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий язык и региональные параметры для преобразования.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, к которому следует привести значение.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованное значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001DF5 RID: 7669 RVA: 0x0006A090 File Offset: 0x00068290
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string))
			{
				string text = this.DefaultCultureString;
				if (culture != null && culture.Equals(CultureInfo.InvariantCulture))
				{
					text = "(Default)";
				}
				string result;
				if (value == null || value == CultureInfo.InvariantCulture)
				{
					result = text;
				}
				else
				{
					result = this.GetCultureName((CultureInfo)value);
				}
				return result;
			}
			if (destinationType == typeof(InstanceDescriptor) && value is CultureInfo)
			{
				CultureInfo cultureInfo = (CultureInfo)value;
				ConstructorInfo constructor = typeof(CultureInfo).GetConstructor(new Type[]
				{
					typeof(string)
				});
				if (constructor != null)
				{
					return new InstanceDescriptor(constructor, new object[]
					{
						cultureInfo.Name
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Возвращает коллекцию стандартных значений для объекта <see cref="T:System.Globalization.CultureInfo" />, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, содержащая стандартный набор допустимых значений, или <see langword="null" />, если этот тип данных не поддерживает стандартный набор значений.</returns>
		// Token: 0x06001DF6 RID: 7670 RVA: 0x0006A170 File Offset: 0x00068370
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (this._values == null)
			{
				CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures | CultureTypes.SpecificCultures);
				int num = Array.IndexOf<CultureInfo>(cultures, CultureInfo.InvariantCulture);
				CultureInfo[] array;
				if (num != -1)
				{
					cultures[num] = null;
					array = new CultureInfo[cultures.Length];
				}
				else
				{
					array = new CultureInfo[cultures.Length + 1];
				}
				Array.Copy(cultures, array, cultures.Length);
				Array.Sort(array, new CultureInfoConverter.CultureComparer(this));
				if (array[0] == null)
				{
					array[0] = CultureInfo.InvariantCulture;
				}
				this._values = new TypeConverter.StandardValuesCollection(array);
			}
			return this._values;
		}

		/// <summary>Возвращает значение, показывающее, является ли список стандартных значений, возвращенных из <see cref="M:System.ComponentModel.CultureInfoConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />, исчерпывающим.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="false" />, так как коллекция <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, возвращенная методом <see cref="M:System.ComponentModel.CultureInfoConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />, не является исчерпывающим списком возможных значений, (то есть возможны другие значения). Этот метод никогда не возвращает значение <see langword="true" />.</returns>
		// Token: 0x06001DF7 RID: 7671 RVA: 0x00003062 File Offset: 0x00001262
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли этот объект стандартный набор значений, которые можно выбрать из списка, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, поскольку для поиска набора значений, поддерживаемых объектом, необходимо вызвать метод <see cref="M:System.ComponentModel.CultureInfoConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />. Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x06001DF8 RID: 7672 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x04000F01 RID: 3841
		private TypeConverter.StandardValuesCollection _values;

		// Token: 0x04000F02 RID: 3842
		private const string DefaultInvariantCultureString = "(Default)";

		// Token: 0x02000391 RID: 913
		private class CultureComparer : IComparer
		{
			// Token: 0x06001DFA RID: 7674 RVA: 0x0006A1EB File Offset: 0x000683EB
			public CultureComparer(CultureInfoConverter cultureConverter)
			{
				this._converter = cultureConverter;
			}

			// Token: 0x06001DFB RID: 7675 RVA: 0x0006A1FC File Offset: 0x000683FC
			public int Compare(object item1, object item2)
			{
				if (item1 == null)
				{
					if (item2 == null)
					{
						return 0;
					}
					return -1;
				}
				else
				{
					if (item2 == null)
					{
						return 1;
					}
					string cultureName = this._converter.GetCultureName((CultureInfo)item1);
					string cultureName2 = this._converter.GetCultureName((CultureInfo)item2);
					return CultureInfo.CurrentCulture.CompareInfo.Compare(cultureName, cultureName2, CompareOptions.StringSort);
				}
			}

			// Token: 0x04000F03 RID: 3843
			private CultureInfoConverter _converter;
		}

		// Token: 0x02000392 RID: 914
		private static class CultureInfoMapper
		{
			// Token: 0x06001DFC RID: 7676 RVA: 0x0006A254 File Offset: 0x00068454
			private static Dictionary<string, string> CreateMap()
			{
				return new Dictionary<string, string>(274)
				{
					{
						"Afrikaans",
						"af"
					},
					{
						"Afrikaans (South Africa)",
						"af-ZA"
					},
					{
						"Albanian",
						"sq"
					},
					{
						"Albanian (Albania)",
						"sq-AL"
					},
					{
						"Alsatian (France)",
						"gsw-FR"
					},
					{
						"Amharic (Ethiopia)",
						"am-ET"
					},
					{
						"Arabic",
						"ar"
					},
					{
						"Arabic (Algeria)",
						"ar-DZ"
					},
					{
						"Arabic (Bahrain)",
						"ar-BH"
					},
					{
						"Arabic (Egypt)",
						"ar-EG"
					},
					{
						"Arabic (Iraq)",
						"ar-IQ"
					},
					{
						"Arabic (Jordan)",
						"ar-JO"
					},
					{
						"Arabic (Kuwait)",
						"ar-KW"
					},
					{
						"Arabic (Lebanon)",
						"ar-LB"
					},
					{
						"Arabic (Libya)",
						"ar-LY"
					},
					{
						"Arabic (Morocco)",
						"ar-MA"
					},
					{
						"Arabic (Oman)",
						"ar-OM"
					},
					{
						"Arabic (Qatar)",
						"ar-QA"
					},
					{
						"Arabic (Saudi Arabia)",
						"ar-SA"
					},
					{
						"Arabic (Syria)",
						"ar-SY"
					},
					{
						"Arabic (Tunisia)",
						"ar-TN"
					},
					{
						"Arabic (U.A.E.)",
						"ar-AE"
					},
					{
						"Arabic (Yemen)",
						"ar-YE"
					},
					{
						"Armenian",
						"hy"
					},
					{
						"Armenian (Armenia)",
						"hy-AM"
					},
					{
						"Assamese (India)",
						"as-IN"
					},
					{
						"Azeri",
						"az"
					},
					{
						"Azeri (Cyrillic, Azerbaijan)",
						"az-Cyrl-AZ"
					},
					{
						"Azeri (Latin, Azerbaijan)",
						"az-Latn-AZ"
					},
					{
						"Bashkir (Russia)",
						"ba-RU"
					},
					{
						"Basque",
						"eu"
					},
					{
						"Basque (Basque)",
						"eu-ES"
					},
					{
						"Belarusian",
						"be"
					},
					{
						"Belarusian (Belarus)",
						"be-BY"
					},
					{
						"Bengali (Bangladesh)",
						"bn-BD"
					},
					{
						"Bengali (India)",
						"bn-IN"
					},
					{
						"Bosnian (Cyrillic, Bosnia and Herzegovina)",
						"bs-Cyrl-BA"
					},
					{
						"Bosnian (Latin, Bosnia and Herzegovina)",
						"bs-Latn-BA"
					},
					{
						"Breton (France)",
						"br-FR"
					},
					{
						"Bulgarian",
						"bg"
					},
					{
						"Bulgarian (Bulgaria)",
						"bg-BG"
					},
					{
						"Catalan",
						"ca"
					},
					{
						"Catalan (Catalan)",
						"ca-ES"
					},
					{
						"Chinese (Hong Kong S.A.R.)",
						"zh-HK"
					},
					{
						"Chinese (Macao S.A.R.)",
						"zh-MO"
					},
					{
						"Chinese (People's Republic of China)",
						"zh-CN"
					},
					{
						"Chinese (Simplified)",
						"zh-CHS"
					},
					{
						"Chinese (Singapore)",
						"zh-SG"
					},
					{
						"Chinese (Taiwan)",
						"zh-TW"
					},
					{
						"Chinese (Traditional)",
						"zh-CHT"
					},
					{
						"Corsican (France)",
						"co-FR"
					},
					{
						"Croatian",
						"hr"
					},
					{
						"Croatian (Croatia)",
						"hr-HR"
					},
					{
						"Croatian (Latin, Bosnia and Herzegovina)",
						"hr-BA"
					},
					{
						"Czech",
						"cs"
					},
					{
						"Czech (Czech Republic)",
						"cs-CZ"
					},
					{
						"Danish",
						"da"
					},
					{
						"Danish (Denmark)",
						"da-DK"
					},
					{
						"Dari (Afghanistan)",
						"prs-AF"
					},
					{
						"Divehi",
						"dv"
					},
					{
						"Divehi (Maldives)",
						"dv-MV"
					},
					{
						"Dutch",
						"nl"
					},
					{
						"Dutch (Belgium)",
						"nl-BE"
					},
					{
						"Dutch (Netherlands)",
						"nl-NL"
					},
					{
						"English",
						"en"
					},
					{
						"English (Australia)",
						"en-AU"
					},
					{
						"English (Belize)",
						"en-BZ"
					},
					{
						"English (Canada)",
						"en-CA"
					},
					{
						"English (Caribbean)",
						"en-029"
					},
					{
						"English (India)",
						"en-IN"
					},
					{
						"English (Ireland)",
						"en-IE"
					},
					{
						"English (Jamaica)",
						"en-JM"
					},
					{
						"English (Malaysia)",
						"en-MY"
					},
					{
						"English (New Zealand)",
						"en-NZ"
					},
					{
						"English (Republic of the Philippines)",
						"en-PH"
					},
					{
						"English (Singapore)",
						"en-SG"
					},
					{
						"English (South Africa)",
						"en-ZA"
					},
					{
						"English (Trinidad and Tobago)",
						"en-TT"
					},
					{
						"English (United Kingdom)",
						"en-GB"
					},
					{
						"English (United States)",
						"en-US"
					},
					{
						"English (Zimbabwe)",
						"en-ZW"
					},
					{
						"Estonian",
						"et"
					},
					{
						"Estonian (Estonia)",
						"et-EE"
					},
					{
						"Faroese",
						"fo"
					},
					{
						"Faroese (Faroe Islands)",
						"fo-FO"
					},
					{
						"Filipino (Philippines)",
						"fil-PH"
					},
					{
						"Finnish",
						"fi"
					},
					{
						"Finnish (Finland)",
						"fi-FI"
					},
					{
						"French",
						"fr"
					},
					{
						"French (Belgium)",
						"fr-BE"
					},
					{
						"French (Canada)",
						"fr-CA"
					},
					{
						"French (France)",
						"fr-FR"
					},
					{
						"French (Luxembourg)",
						"fr-LU"
					},
					{
						"French (Principality of Monaco)",
						"fr-MC"
					},
					{
						"French (Switzerland)",
						"fr-CH"
					},
					{
						"Frisian (Netherlands)",
						"fy-NL"
					},
					{
						"Galician",
						"gl"
					},
					{
						"Galician (Galician)",
						"gl-ES"
					},
					{
						"Georgian",
						"ka"
					},
					{
						"Georgian (Georgia)",
						"ka-GE"
					},
					{
						"German",
						"de"
					},
					{
						"German (Austria)",
						"de-AT"
					},
					{
						"German (Germany)",
						"de-DE"
					},
					{
						"German (Liechtenstein)",
						"de-LI"
					},
					{
						"German (Luxembourg)",
						"de-LU"
					},
					{
						"German (Switzerland)",
						"de-CH"
					},
					{
						"Greek",
						"el"
					},
					{
						"Greek (Greece)",
						"el-GR"
					},
					{
						"Greenlandic (Greenland)",
						"kl-GL"
					},
					{
						"Gujarati",
						"gu"
					},
					{
						"Gujarati (India)",
						"gu-IN"
					},
					{
						"Hausa (Latin, Nigeria)",
						"ha-Latn-NG"
					},
					{
						"Hebrew",
						"he"
					},
					{
						"Hebrew (Israel)",
						"he-IL"
					},
					{
						"Hindi",
						"hi"
					},
					{
						"Hindi (India)",
						"hi-IN"
					},
					{
						"Hungarian",
						"hu"
					},
					{
						"Hungarian (Hungary)",
						"hu-HU"
					},
					{
						"Icelandic",
						"is"
					},
					{
						"Icelandic (Iceland)",
						"is-IS"
					},
					{
						"Igbo (Nigeria)",
						"ig-NG"
					},
					{
						"Indonesian",
						"id"
					},
					{
						"Indonesian (Indonesia)",
						"id-ID"
					},
					{
						"Inuktitut (Latin, Canada)",
						"iu-Latn-CA"
					},
					{
						"Inuktitut (Syllabics, Canada)",
						"iu-Cans-CA"
					},
					{
						"Invariant Language (Invariant Country)",
						""
					},
					{
						"Irish (Ireland)",
						"ga-IE"
					},
					{
						"isiXhosa (South Africa)",
						"xh-ZA"
					},
					{
						"isiZulu (South Africa)",
						"zu-ZA"
					},
					{
						"Italian",
						"it"
					},
					{
						"Italian (Italy)",
						"it-IT"
					},
					{
						"Italian (Switzerland)",
						"it-CH"
					},
					{
						"Japanese",
						"ja"
					},
					{
						"Japanese (Japan)",
						"ja-JP"
					},
					{
						"K'iche (Guatemala)",
						"qut-GT"
					},
					{
						"Kannada",
						"kn"
					},
					{
						"Kannada (India)",
						"kn-IN"
					},
					{
						"Kazakh",
						"kk"
					},
					{
						"Kazakh (Kazakhstan)",
						"kk-KZ"
					},
					{
						"Khmer (Cambodia)",
						"km-KH"
					},
					{
						"Kinyarwanda (Rwanda)",
						"rw-RW"
					},
					{
						"Kiswahili",
						"sw"
					},
					{
						"Kiswahili (Kenya)",
						"sw-KE"
					},
					{
						"Konkani",
						"kok"
					},
					{
						"Konkani (India)",
						"kok-IN"
					},
					{
						"Korean",
						"ko"
					},
					{
						"Korean (Korea)",
						"ko-KR"
					},
					{
						"Kyrgyz",
						"ky"
					},
					{
						"Kyrgyz (Kyrgyzstan)",
						"ky-KG"
					},
					{
						"Lao (Lao P.D.R.)",
						"lo-LA"
					},
					{
						"Latvian",
						"lv"
					},
					{
						"Latvian (Latvia)",
						"lv-LV"
					},
					{
						"Lithuanian",
						"lt"
					},
					{
						"Lithuanian (Lithuania)",
						"lt-LT"
					},
					{
						"Lower Sorbian (Germany)",
						"dsb-DE"
					},
					{
						"Luxembourgish (Luxembourg)",
						"lb-LU"
					},
					{
						"Macedonian",
						"mk"
					},
					{
						"Macedonian (Former Yugoslav Republic of Macedonia)",
						"mk-MK"
					},
					{
						"Malay",
						"ms"
					},
					{
						"Malay (Brunei Darussalam)",
						"ms-BN"
					},
					{
						"Malay (Malaysia)",
						"ms-MY"
					},
					{
						"Malayalam (India)",
						"ml-IN"
					},
					{
						"Maltese (Malta)",
						"mt-MT"
					},
					{
						"Maori (New Zealand)",
						"mi-NZ"
					},
					{
						"Mapudungun (Chile)",
						"arn-CL"
					},
					{
						"Marathi",
						"mr"
					},
					{
						"Marathi (India)",
						"mr-IN"
					},
					{
						"Mohawk (Mohawk)",
						"moh-CA"
					},
					{
						"Mongolian",
						"mn"
					},
					{
						"Mongolian (Cyrillic, Mongolia)",
						"mn-MN"
					},
					{
						"Mongolian (Traditional Mongolian, PRC)",
						"mn-Mong-CN"
					},
					{
						"Nepali (Nepal)",
						"ne-NP"
					},
					{
						"Norwegian",
						"no"
					},
					{
						"Norwegian, Bokmål (Norway)",
						"nb-NO"
					},
					{
						"Norwegian, Nynorsk (Norway)",
						"nn-NO"
					},
					{
						"Occitan (France)",
						"oc-FR"
					},
					{
						"Oriya (India)",
						"or-IN"
					},
					{
						"Pashto (Afghanistan)",
						"ps-AF"
					},
					{
						"Persian",
						"fa"
					},
					{
						"Persian (Iran)",
						"fa-IR"
					},
					{
						"Polish",
						"pl"
					},
					{
						"Polish (Poland)",
						"pl-PL"
					},
					{
						"Portuguese",
						"pt"
					},
					{
						"Portuguese (Brazil)",
						"pt-BR"
					},
					{
						"Portuguese (Portugal)",
						"pt-PT"
					},
					{
						"Punjabi",
						"pa"
					},
					{
						"Punjabi (India)",
						"pa-IN"
					},
					{
						"Quechua (Bolivia)",
						"quz-BO"
					},
					{
						"Quechua (Ecuador)",
						"quz-EC"
					},
					{
						"Quechua (Peru)",
						"quz-PE"
					},
					{
						"Romanian",
						"ro"
					},
					{
						"Romanian (Romania)",
						"ro-RO"
					},
					{
						"Romansh (Switzerland)",
						"rm-CH"
					},
					{
						"Russian",
						"ru"
					},
					{
						"Russian (Russia)",
						"ru-RU"
					},
					{
						"Sami, Inari (Finland)",
						"smn-FI"
					},
					{
						"Sami, Lule (Norway)",
						"smj-NO"
					},
					{
						"Sami, Lule (Sweden)",
						"smj-SE"
					},
					{
						"Sami, Northern (Finland)",
						"se-FI"
					},
					{
						"Sami, Northern (Norway)",
						"se-NO"
					},
					{
						"Sami, Northern (Sweden)",
						"se-SE"
					},
					{
						"Sami, Skolt (Finland)",
						"sms-FI"
					},
					{
						"Sami, Southern (Norway)",
						"sma-NO"
					},
					{
						"Sami, Southern (Sweden)",
						"sma-SE"
					},
					{
						"Sanskrit",
						"sa"
					},
					{
						"Sanskrit (India)",
						"sa-IN"
					},
					{
						"Serbian",
						"sr"
					},
					{
						"Serbian (Cyrillic, Bosnia and Herzegovina)",
						"sr-Cyrl-BA"
					},
					{
						"Serbian (Cyrillic, Serbia)",
						"sr-Cyrl-CS"
					},
					{
						"Serbian (Latin, Bosnia and Herzegovina)",
						"sr-Latn-BA"
					},
					{
						"Serbian (Latin, Serbia)",
						"sr-Latn-CS"
					},
					{
						"Sesotho sa Leboa (South Africa)",
						"nso-ZA"
					},
					{
						"Setswana (South Africa)",
						"tn-ZA"
					},
					{
						"Sinhala (Sri Lanka)",
						"si-LK"
					},
					{
						"Slovak",
						"sk"
					},
					{
						"Slovak (Slovakia)",
						"sk-SK"
					},
					{
						"Slovenian",
						"sl"
					},
					{
						"Slovenian (Slovenia)",
						"sl-SI"
					},
					{
						"Spanish",
						"es"
					},
					{
						"Spanish (Argentina)",
						"es-AR"
					},
					{
						"Spanish (Bolivia)",
						"es-BO"
					},
					{
						"Spanish (Chile)",
						"es-CL"
					},
					{
						"Spanish (Colombia)",
						"es-CO"
					},
					{
						"Spanish (Costa Rica)",
						"es-CR"
					},
					{
						"Spanish (Dominican Republic)",
						"es-DO"
					},
					{
						"Spanish (Ecuador)",
						"es-EC"
					},
					{
						"Spanish (El Salvador)",
						"es-SV"
					},
					{
						"Spanish (Guatemala)",
						"es-GT"
					},
					{
						"Spanish (Honduras)",
						"es-HN"
					},
					{
						"Spanish (Mexico)",
						"es-MX"
					},
					{
						"Spanish (Nicaragua)",
						"es-NI"
					},
					{
						"Spanish (Panama)",
						"es-PA"
					},
					{
						"Spanish (Paraguay)",
						"es-PY"
					},
					{
						"Spanish (Peru)",
						"es-PE"
					},
					{
						"Spanish (Puerto Rico)",
						"es-PR"
					},
					{
						"Spanish (Spain)",
						"es-ES"
					},
					{
						"Spanish (United States)",
						"es-US"
					},
					{
						"Spanish (Uruguay)",
						"es-UY"
					},
					{
						"Spanish (Venezuela)",
						"es-VE"
					},
					{
						"Swedish",
						"sv"
					},
					{
						"Swedish (Finland)",
						"sv-FI"
					},
					{
						"Swedish (Sweden)",
						"sv-SE"
					},
					{
						"Syriac",
						"syr"
					},
					{
						"Syriac (Syria)",
						"syr-SY"
					},
					{
						"Tajik (Cyrillic, Tajikistan)",
						"tg-Cyrl-TJ"
					},
					{
						"Tamazight (Latin, Algeria)",
						"tzm-Latn-DZ"
					},
					{
						"Tamil",
						"ta"
					},
					{
						"Tamil (India)",
						"ta-IN"
					},
					{
						"Tatar",
						"tt"
					},
					{
						"Tatar (Russia)",
						"tt-RU"
					},
					{
						"Telugu",
						"te"
					},
					{
						"Telugu (India)",
						"te-IN"
					},
					{
						"Thai",
						"th"
					},
					{
						"Thai (Thailand)",
						"th-TH"
					},
					{
						"Tibetan (PRC)",
						"bo-CN"
					},
					{
						"Turkish",
						"tr"
					},
					{
						"Turkish (Turkey)",
						"tr-TR"
					},
					{
						"Turkmen (Turkmenistan)",
						"tk-TM"
					},
					{
						"Uighur (PRC)",
						"ug-CN"
					},
					{
						"Ukrainian",
						"uk"
					},
					{
						"Ukrainian (Ukraine)",
						"uk-UA"
					},
					{
						"Upper Sorbian (Germany)",
						"hsb-DE"
					},
					{
						"Urdu",
						"ur"
					},
					{
						"Urdu (Islamic Republic of Pakistan)",
						"ur-PK"
					},
					{
						"Uzbek",
						"uz"
					},
					{
						"Uzbek (Cyrillic, Uzbekistan)",
						"uz-Cyrl-UZ"
					},
					{
						"Uzbek (Latin, Uzbekistan)",
						"uz-Latn-UZ"
					},
					{
						"Vietnamese",
						"vi"
					},
					{
						"Vietnamese (Vietnam)",
						"vi-VN"
					},
					{
						"Welsh (United Kingdom)",
						"cy-GB"
					},
					{
						"Wolof (Senegal)",
						"wo-SN"
					},
					{
						"Yakut (Russia)",
						"sah-RU"
					},
					{
						"Yi (PRC)",
						"ii-CN"
					},
					{
						"Yoruba (Nigeria)",
						"yo-NG"
					}
				};
			}

			// Token: 0x06001DFD RID: 7677 RVA: 0x0006B38C File Offset: 0x0006958C
			public static string GetCultureInfoName(string cultureInfoDisplayName)
			{
				string result;
				if (!CultureInfoConverter.CultureInfoMapper.s_cultureInfoNameMap.TryGetValue(cultureInfoDisplayName, out result))
				{
					return cultureInfoDisplayName;
				}
				return result;
			}

			// Token: 0x04000F04 RID: 3844
			private static readonly Dictionary<string, string> s_cultureInfoNameMap = CultureInfoConverter.CultureInfoMapper.CreateMap();
		}
	}
}
