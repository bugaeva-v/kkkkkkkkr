using System;

namespace System.Data.Common
{
	/// <summary>Представляет столбец в источнике данных.</summary>
	// Token: 0x0200038A RID: 906
	public abstract class DbColumn
	{
		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, разрешены ли значения <see langword="DBNull" /> в этом столбце, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, разрешены ли значения <see langword="DBNull" /> в этом столбце, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если значения <see langword="DBNull" /> разрешены в этом столбце; в противном случае — <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000BB337 File Offset: 0x000B9537
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x000BB33F File Offset: 0x000B953F
		public bool? AllowDBNull { get; protected set; }

		/// <summary>Получает имя каталога, связанного с источником данных; в противном случае — <see langword="null" />, если значение не задано. Можно задать имя каталога или <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>Имя каталога, связанного с источником данных; в противном случае — пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000BB348 File Offset: 0x000B9548
		// (set) Token: 0x06002B23 RID: 11043 RVA: 0x000BB350 File Offset: 0x000B9550
		public string BaseCatalogName { get; protected set; }

		/// <summary>Возвращает имя базового столбца; в противном случае — <see langword="null" />, если значение не задано. Можно задать имя столбца или <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>Имя базового столбца; в противном случае — пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000BB359 File Offset: 0x000B9559
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x000BB361 File Offset: 0x000B9561
		public string BaseColumnName { get; protected set; }

		/// <summary>Получает имя схемы, связанной с источником данных; в противном случае — <see langword="null" />, если значение не задано. Можно задать имя схемы или <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>Имя схемы, связанной с источником данных; в противном случае — пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000BB36A File Offset: 0x000B956A
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x000BB372 File Offset: 0x000B9572
		public string BaseSchemaName { get; protected set; }

		/// <summary>Получает имя сервера, связанное со столбцом; в противном случае — <see langword="null" />, если значение не задано. Можно задать имя сервера или <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>Имя сервера, связанное со столбцом; в противном случае — пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000BB37B File Offset: 0x000B957B
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x000BB383 File Offset: 0x000B9583
		public string BaseServerName { get; protected set; }

		/// <summary>Возвращает имя таблицы в схеме; в противном случае возвращает <see langword="null" />, если значение не задано. Можно задать имя таблицы или <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>Имя таблицы в схеме; в противном случае — пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000BB38C File Offset: 0x000B958C
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x000BB394 File Offset: 0x000B9594
		public string BaseTableName { get; protected set; }

		/// <summary>Возвращает имя столбца. Можно задать имя столбца при переопределении в производном классе.</summary>
		/// <returns>Имя столбца.</returns>
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000BB39D File Offset: 0x000B959D
		// (set) Token: 0x06002B2D RID: 11053 RVA: 0x000BB3A5 File Offset: 0x000B95A5
		public string ColumnName { get; protected set; }

		/// <summary>Возвращает позицию столбца (порядковый номер) в строке источника данных; в противном случае — <see langword="null" />, если значение не задано. Можно задать либо значение <see langword="int32" />, указывающее позицию столбца, либо <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>Значение <see langword="int32" /> для порядкового номера столбца; в противном случае — пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000BB3AE File Offset: 0x000B95AE
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x000BB3B6 File Offset: 0x000B95B6
		public int? ColumnOrdinal { get; protected set; }

		/// <summary>Возвращает размер столбца; в противном случае — <see langword="null" />, если значение не задано. Можно задать либо значение <see langword="int32" />, указывающее размер столбца, либо <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>
		///   <see langword="int32" /> Значение для размера столбца; в противном случае — пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000BB3BF File Offset: 0x000B95BF
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x000BB3C7 File Offset: 0x000B95C7
		public int? ColumnSize { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, обозначен ли этот столбец псевдонимом, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, обозначен ли этот столбец псевдонимом, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если этот столбец обозначен псевдонимом, в противном случае возвращает <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000BB3D0 File Offset: 0x000B95D0
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x000BB3D8 File Offset: 0x000B95D8
		public bool? IsAliased { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, выполняется ли автоматическое увеличение значений в этом столбце, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, выполняется ли автоматическое увеличение значений в этом столбце, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если выполняется автоматическое увеличение значений в этом столбце; в противном случае — <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x000BB3E1 File Offset: 0x000B95E1
		// (set) Token: 0x06002B35 RID: 11061 RVA: 0x000BB3E9 File Offset: 0x000B95E9
		public bool? IsAutoIncrement { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, является ли этот столбец выражением, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, является ли этот столбец выражением, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если этот столбец является выражением; в противном случае возвращает <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x000BB3F2 File Offset: 0x000B95F2
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x000BB3FA File Offset: 0x000B95FA
		public bool? IsExpression { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, является ли этот столбец скрытым, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, является ли этот столбец скрытым, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если этот столбец является скрытым, в противном случае возвращает <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000BB403 File Offset: 0x000B9603
		// (set) Token: 0x06002B39 RID: 11065 RVA: 0x000BB40B File Offset: 0x000B960B
		public bool? IsHidden { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, является ли этот столбец идентификатором, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, является ли этот столбец идентификатором, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если этот столбец является идентификатором, в противном случае возвращает <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000BB414 File Offset: 0x000B9614
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x000BB41C File Offset: 0x000B961C
		public bool? IsIdentity { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, является ли этот столбец ключом, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, является ли этот столбец ключом, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если этот столбец является ключом, в противном случае возвращает <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000BB425 File Offset: 0x000B9625
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x000BB42D File Offset: 0x000B962D
		public bool? IsKey { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, содержит ли этот столбец данные большого формата, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, содержит ли этот столбец данные большого формата, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если этот столбец содержит данные большого формата; в противном случае — <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000BB436 File Offset: 0x000B9636
		// (set) Token: 0x06002B3F RID: 11071 RVA: 0x000BB43E File Offset: 0x000B963E
		public bool? IsLong { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, доступен ли этот столбец только для чтения, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, доступен ли этот столбец только для чтения, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если этот столбец доступен только для чтения; в противном случае — значение <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x000BB447 File Offset: 0x000B9647
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x000BB44F File Offset: 0x000B964F
		public bool? IsReadOnly { get; protected set; }

		/// <summary>Возвращает логическое значение, допускающее присвоение null, указывающее, применяется ли к этому столбцу уникальное ограничение, или возвращает <see langword="null" />, если значение не задано. Можно задать значение <see langword="true" /> или <see langword="false" />, указывающее, применяется ли к этому столбцу уникальное ограничение, или <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) при переопределении в производном классе.</summary>
		/// <returns>Возвращает <see langword="true" />, если к этому столбцу применяется уникальное ограничение; в противном случае — <see langword="false" />. Если значение не задано, возвратит пустую ссылку (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000BB458 File Offset: 0x000B9658
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x000BB460 File Offset: 0x000B9660
		public bool? IsUnique { get; protected set; }

		/// <summary>Получает точность чисел данных в столбце; в противном случае — <see langword="null" />, если значение не задано. Можно задать либо значение <see langword="int32" />, указывающее точность чисел данных в столбце, либо <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>
		///   <see langword="int32" /> Значение, указывающее точность данных в столбце, в том случае, если данные являются числовыми; в противном случае, пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000BB469 File Offset: 0x000B9669
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x000BB471 File Offset: 0x000B9671
		public int? NumericPrecision { get; protected set; }

		/// <summary>Получает значение <see langword="int32" />, допускающее null, которое возвращает <see langword="null" /> или числовой масштаб данных в столбце. Можно задать значение <see langword="null" /> или <see langword="int32" /> для числового масштаба данных в столбце при переопределении в производном классе.</summary>
		/// <returns>Пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано; в противном случае — значение <see langword="int32" />, указывающее масштаб данных в столбце, если данные являются числовыми.</returns>
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000BB47A File Offset: 0x000B967A
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x000BB482 File Offset: 0x000B9682
		public int? NumericScale { get; protected set; }

		/// <summary>Получает имя с указанием сборки для объекта <see cref="T:System.Type" />, представляющего тип данных в столбце; в противном случае — <see langword="null" />, если значение не задано. Можно задать имя с указанием сборки или <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>Имя с указанием сборки для объекта <see cref="T:System.Type" />, представляющего тип данных в столбце; в противном случае — пустая сборка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000BB48B File Offset: 0x000B968B
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x000BB493 File Offset: 0x000B9693
		public string UdtAssemblyQualifiedName { get; protected set; }

		/// <summary>Возвращает тип данных, хранящихся в столбце. Можно задать объект <see cref="T:System.Type" />, представляющий тип данных в столбце при переопределении в производном классе.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип данных, хранящихся в столбце.</returns>
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x000BB49C File Offset: 0x000B969C
		// (set) Token: 0x06002B4B RID: 11083 RVA: 0x000BB4A4 File Offset: 0x000B96A4
		public Type DataType { get; protected set; }

		/// <summary>Получает имя типа данных; в противном случае — <see langword="null" />, если значение не задано. Можно задать имя типа данных или <see langword="null" /> при переопределении в производном классе.</summary>
		/// <returns>Имя типа данных; в противном случае — пустая ссылка (<see langword="Nothing" /> в Visual Basic), если значение не задано.</returns>
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x000BB4AD File Offset: 0x000B96AD
		// (set) Token: 0x06002B4D RID: 11085 RVA: 0x000BB4B5 File Offset: 0x000B96B5
		public string DataTypeName { get; protected set; }

		/// <summary>Получает объект на основе имени свойства столбца.</summary>
		/// <param name="property">Имя свойства столбца.</param>
		/// <returns>Объект на основе имени свойства столбца.</returns>
		// Token: 0x17000750 RID: 1872
		public virtual object this[string property]
		{
			get
			{
				uint num = <PrivateImplementationDetails>.ComputeStringHash(property);
				if (num <= 2477638934U)
				{
					if (num <= 1067318116U)
					{
						if (num <= 687909556U)
						{
							if (num != 405521230U)
							{
								if (num == 687909556U)
								{
									if (property == "ColumnOrdinal")
									{
										return this.ColumnOrdinal;
									}
								}
							}
							else if (property == "DataTypeName")
							{
								return this.DataTypeName;
							}
						}
						else if (num != 720006947U)
						{
							if (num != 1005639113U)
							{
								if (num == 1067318116U)
								{
									if (property == "ColumnName")
									{
										return this.ColumnName;
									}
								}
							}
							else if (property == "IsHidden")
							{
								return this.IsHidden;
							}
						}
						else if (property == "IsLong")
						{
							return this.IsLong;
						}
					}
					else if (num <= 2215472237U)
					{
						if (num != 1154057342U)
						{
							if (num != 1309233724U)
							{
								if (num == 2215472237U)
								{
									if (property == "DataType")
									{
										return this.DataType;
									}
								}
							}
							else if (property == "IsKey")
							{
								return this.IsKey;
							}
						}
						else if (property == "ColumnSize")
						{
							return this.ColumnSize;
						}
					}
					else if (num != 2239129947U)
					{
						if (num != 2380251540U)
						{
							if (num == 2477638934U)
							{
								if (property == "IsUnique")
								{
									return this.IsUnique;
								}
							}
						}
						else if (property == "NumericPrecision")
						{
							return this.NumericPrecision;
						}
					}
					else if (property == "IsExpression")
					{
						return this.IsExpression;
					}
				}
				else if (num <= 3042527364U)
				{
					if (num <= 2711511624U)
					{
						if (num != 2504653387U)
						{
							if (num != 2586490225U)
							{
								if (num == 2711511624U)
								{
									if (property == "BaseServerName")
									{
										return this.BaseServerName;
									}
								}
							}
							else if (property == "UdtAssemblyQualifiedName")
							{
								return this.UdtAssemblyQualifiedName;
							}
						}
						else if (property == "IsIdentity")
						{
							return this.IsIdentity;
						}
					}
					else if (num != 2741140585U)
					{
						if (num != 2757192823U)
						{
							if (num == 3042527364U)
							{
								if (property == "BaseCatalogName")
								{
									return this.BaseCatalogName;
								}
							}
						}
						else if (property == "BaseTableName")
						{
							return this.BaseTableName;
						}
					}
					else if (property == "BaseColumnName")
					{
						return this.BaseColumnName;
					}
				}
				else if (num <= 3656290791U)
				{
					if (num != 3115085976U)
					{
						if (num != 3173893005U)
						{
							if (num == 3656290791U)
							{
								if (property == "IsReadOnly")
								{
									return this.IsReadOnly;
								}
							}
						}
						else if (property == "AllowDBNull")
						{
							return this.AllowDBNull;
						}
					}
					else if (property == "BaseSchemaName")
					{
						return this.BaseSchemaName;
					}
				}
				else if (num != 3912158903U)
				{
					if (num != 3938522122U)
					{
						if (num == 4233439846U)
						{
							if (property == "IsAliased")
							{
								return this.IsAliased;
							}
						}
					}
					else if (property == "NumericScale")
					{
						return this.NumericScale;
					}
				}
				else if (property == "IsAutoIncrement")
				{
					return this.IsAutoIncrement;
				}
				return null;
			}
		}
	}
}
