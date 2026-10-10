using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.Odbc
{
	/// <summary>Удобное средство, с помощью которого можно создавать используемые классом <see cref="T:System.Data.Odbc.OdbcConnection" /> строки соединений и управлять их содержимым.</summary>
	// Token: 0x020002DE RID: 734
	public sealed class OdbcConnectionStringBuilder : DbConnectionStringBuilder
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x00096CF0 File Offset: 0x00094EF0
		static OdbcConnectionStringBuilder()
		{
			string[] array = new string[]
			{
				null,
				"Driver"
			};
			array[0] = "Dsn";
			OdbcConnectionStringBuilder.s_validKeywords = array;
			OdbcConnectionStringBuilder.s_keywords = new Dictionary<string, OdbcConnectionStringBuilder.Keywords>(2, StringComparer.OrdinalIgnoreCase)
			{
				{
					"Driver",
					OdbcConnectionStringBuilder.Keywords.Driver
				},
				{
					"Dsn",
					OdbcConnectionStringBuilder.Keywords.Dsn
				}
			};
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" />.</summary>
		// Token: 0x06002060 RID: 8288 RVA: 0x00096D40 File Offset: 0x00094F40
		public OdbcConnectionStringBuilder() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" />. Предоставленная строка подключения содержит данные для сведений о внутреннем подключении экземпляра.</summary>
		/// <param name="connectionString">Основа для сведений о внутреннем подключении объекта. Выполняет анализ пар "ключ/значение".</param>
		/// <exception cref="T:System.ArgumentException">Строка подключения неправильно отформатирована (возможно отсутствует обязательный знак равенства "=" в паре "ключ/значение").</exception>
		// Token: 0x06002061 RID: 8289 RVA: 0x00096D49 File Offset: 0x00094F49
		public OdbcConnectionStringBuilder(string connectionString) : base(true)
		{
			if (!string.IsNullOrEmpty(connectionString))
			{
				base.ConnectionString = connectionString;
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом. В языке C# это свойство является индексатором.</summary>
		/// <param name="keyword">Ключ возвращаемого или задаваемого элемента.</param>
		/// <returns>Значение, связанное с указанным ключом.</returns>
		/// <exception cref="T:System.ArgumentException">Строка подключения неправильно отформатирована (возможно отсутствует обязательный знак равенства "=" в паре "ключ/значение").</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="keyword" /> является неопределенной ссылкой (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x170005C5 RID: 1477
		public override object this[string keyword]
		{
			get
			{
				ADP.CheckArgumentNull(keyword, "keyword");
				OdbcConnectionStringBuilder.Keywords index;
				if (OdbcConnectionStringBuilder.s_keywords.TryGetValue(keyword, out index))
				{
					return this.GetAt(index);
				}
				return base[keyword];
			}
			set
			{
				ADP.CheckArgumentNull(keyword, "keyword");
				if (value == null)
				{
					this.Remove(keyword);
					return;
				}
				OdbcConnectionStringBuilder.Keywords keywords;
				if (!OdbcConnectionStringBuilder.s_keywords.TryGetValue(keyword, out keywords))
				{
					base[keyword] = value;
					base.ClearPropertyDescriptors();
					this._knownKeywords = null;
					return;
				}
				if (keywords == OdbcConnectionStringBuilder.Keywords.Dsn)
				{
					this.Dsn = OdbcConnectionStringBuilder.ConvertToString(value);
					return;
				}
				if (keywords == OdbcConnectionStringBuilder.Keywords.Driver)
				{
					this.Driver = OdbcConnectionStringBuilder.ConvertToString(value);
					return;
				}
				throw ADP.KeywordNotSupported(keyword);
			}
		}

		/// <summary>Возвращает или задает имя драйвера ODBC, связанного с подключением.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.Odbc.OdbcConnectionStringBuilder.Driver" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x00096E20 File Offset: 0x00095020
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x00096E28 File Offset: 0x00095028
		[DisplayName("Driver")]
		public string Driver
		{
			get
			{
				return this._driver;
			}
			set
			{
				this.SetValue("Driver", value);
				this._driver = value;
			}
		}

		/// <summary>Возвращает или задает имя источника данных (DSN), связанного с подключением.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.Odbc.OdbcConnectionStringBuilder.Dsn" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x00096E3D File Offset: 0x0009503D
		// (set) Token: 0x06002067 RID: 8295 RVA: 0x00096E45 File Offset: 0x00095045
		[DisplayName("Dsn")]
		public string Dsn
		{
			get
			{
				return this._dsn;
			}
			set
			{
				this.SetValue("Dsn", value);
				this._dsn = value;
			}
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Collections.ICollection" />, которая содержит ключи из <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, которая содержит ключи из <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" />.</returns>
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x00096E5C File Offset: 0x0009505C
		public override ICollection Keys
		{
			get
			{
				string[] array = this._knownKeywords;
				if (array == null)
				{
					array = OdbcConnectionStringBuilder.s_validKeywords;
					int num = 0;
					foreach (object obj in base.Keys)
					{
						string b = (string)obj;
						bool flag = true;
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							if (array2[i] == b)
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							num++;
						}
					}
					if (0 < num)
					{
						string[] array3 = new string[array.Length + num];
						array.CopyTo(array3, 0);
						int num2 = array.Length;
						foreach (object obj2 in base.Keys)
						{
							string text = (string)obj2;
							bool flag2 = true;
							string[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								if (array2[i] == text)
								{
									flag2 = false;
									break;
								}
							}
							if (flag2)
							{
								array3[num2++] = text;
							}
						}
						array = array3;
					}
					this._knownKeywords = array;
				}
				return new ReadOnlyCollection<string>(array);
			}
		}

		/// <summary>Удаляет содержимое экземпляра <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" />.</summary>
		// Token: 0x06002069 RID: 8297 RVA: 0x00096FAC File Offset: 0x000951AC
		public override void Clear()
		{
			base.Clear();
			for (int i = 0; i < OdbcConnectionStringBuilder.s_validKeywords.Length; i++)
			{
				this.Reset((OdbcConnectionStringBuilder.Keywords)i);
			}
			this._knownKeywords = OdbcConnectionStringBuilder.s_validKeywords;
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" /> указанный ключ.</summary>
		/// <param name="keyword">Ключ, который требуется найти в <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если в <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" /> содержится элемент с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> имеет значение null (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x0600206A RID: 8298 RVA: 0x00096FE3 File Offset: 0x000951E3
		public override bool ContainsKey(string keyword)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			return OdbcConnectionStringBuilder.s_keywords.ContainsKey(keyword) || base.ContainsKey(keyword);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00069B5C File Offset: 0x00067D5C
		private static string ConvertToString(object value)
		{
			return DbConnectionStringBuilderUtil.ConvertToString(value);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00097006 File Offset: 0x00095206
		private object GetAt(OdbcConnectionStringBuilder.Keywords index)
		{
			if (index == OdbcConnectionStringBuilder.Keywords.Dsn)
			{
				return this.Dsn;
			}
			if (index == OdbcConnectionStringBuilder.Keywords.Driver)
			{
				return this.Driver;
			}
			throw ADP.KeywordNotSupported(OdbcConnectionStringBuilder.s_validKeywords[(int)index]);
		}

		/// <summary>Удаляет из экземпляра <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" /> запись с указанным ключом.</summary>
		/// <param name="keyword">Ключ пары «ключ-значение», удаляемой из строки подключения в этом объекте <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если ключ был указан в строке подключения и был удален. Значение <see langword="false" />, если такого ключа не было.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> имеет значение null (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x0600206D RID: 8301 RVA: 0x0009702C File Offset: 0x0009522C
		public override bool Remove(string keyword)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			if (base.Remove(keyword))
			{
				OdbcConnectionStringBuilder.Keywords index;
				if (OdbcConnectionStringBuilder.s_keywords.TryGetValue(keyword, out index))
				{
					this.Reset(index);
				}
				else
				{
					base.ClearPropertyDescriptors();
					this._knownKeywords = null;
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x00097075 File Offset: 0x00095275
		private void Reset(OdbcConnectionStringBuilder.Keywords index)
		{
			if (index == OdbcConnectionStringBuilder.Keywords.Dsn)
			{
				this._dsn = "";
				return;
			}
			if (index == OdbcConnectionStringBuilder.Keywords.Driver)
			{
				this._driver = "";
				return;
			}
			throw ADP.KeywordNotSupported(OdbcConnectionStringBuilder.s_validKeywords[(int)index]);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00069F75 File Offset: 0x00068175
		private void SetValue(string keyword, string value)
		{
			ADP.CheckArgumentNull(value, keyword);
			base[keyword] = value;
		}

		/// <summary>Получает значение, соответствующее заданному ключу, из данного объекта <see cref="T:System.Data.Odbc.OdbcConnectionStringBuilder" />.</summary>
		/// <param name="keyword">Ключ искомого элемента.</param>
		/// <param name="value">Значение, соответствующее <paramref name="keyword" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="keyword" /> найден в строке подключения, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002070 RID: 8304 RVA: 0x000970A4 File Offset: 0x000952A4
		public override bool TryGetValue(string keyword, out object value)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			OdbcConnectionStringBuilder.Keywords index;
			if (OdbcConnectionStringBuilder.s_keywords.TryGetValue(keyword, out index))
			{
				value = this.GetAt(index);
				return true;
			}
			return base.TryGetValue(keyword, out value);
		}

		// Token: 0x04001777 RID: 6007
		private static readonly string[] s_validKeywords;

		// Token: 0x04001778 RID: 6008
		private static readonly Dictionary<string, OdbcConnectionStringBuilder.Keywords> s_keywords;

		// Token: 0x04001779 RID: 6009
		private string[] _knownKeywords;

		// Token: 0x0400177A RID: 6010
		private string _dsn = "";

		// Token: 0x0400177B RID: 6011
		private string _driver = "";

		// Token: 0x020002DF RID: 735
		private enum Keywords
		{
			// Token: 0x0400177D RID: 6013
			Dsn,
			// Token: 0x0400177E RID: 6014
			Driver
		}
	}
}
