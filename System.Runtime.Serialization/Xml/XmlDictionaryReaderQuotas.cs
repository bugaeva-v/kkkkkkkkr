using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Xml
{
	/// <summary>Содержит настраиваемые значения квоты для XmlDictionaryReaders.</summary>
	// Token: 0x02000063 RID: 99
	public sealed class XmlDictionaryReaderQuotas
	{
		/// <summary>Создает новый экземпляр данного класса.</summary>
		// Token: 0x06000537 RID: 1335 RVA: 0x0001861C File Offset: 0x0001681C
		public XmlDictionaryReaderQuotas()
		{
			XmlDictionaryReaderQuotas.defaultQuota.CopyTo(this);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001862F File Offset: 0x0001682F
		private XmlDictionaryReaderQuotas(int maxDepth, int maxStringContentLength, int maxArrayLength, int maxBytesPerRead, int maxNameTableCharCount, XmlDictionaryReaderQuotaTypes modifiedQuotas)
		{
			this.maxDepth = maxDepth;
			this.maxStringContentLength = maxStringContentLength;
			this.maxArrayLength = maxArrayLength;
			this.maxBytesPerRead = maxBytesPerRead;
			this.maxNameTableCharCount = maxNameTableCharCount;
			this.modifiedQuotas = modifiedQuotas;
			this.MakeReadOnly();
		}

		/// <summary>Возвращает экземпляр данного класса с максимальными значениями для всех свойств.</summary>
		/// <returns>Экземпляр <see cref="T:System.Xml.XmlDictionaryReaderQuotas" /> со значениями свойств <see cref="F:System.Int32.MaxValue" />.</returns>
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0001866A File Offset: 0x0001686A
		public static XmlDictionaryReaderQuotas Max
		{
			get
			{
				return XmlDictionaryReaderQuotas.maxQuota;
			}
		}

		/// <summary>Задает свойства для переданного экземпляра квот, основываясь на значениях в данном экземпляре.</summary>
		/// <param name="quotas">Экземпляр <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />, в который следует выполнить копирование значение.</param>
		/// <exception cref="T:System.InvalidOperationException">Попытка <see langword="set" /> значение при доступе только для чтения к значению квоты для переданного экземпляра.</exception>
		/// <exception cref="T:System.ArgumentNullException">Переданные целевые <paramref name="quotas" /> равны <see langword="null" />.</exception>
		// Token: 0x0600053A RID: 1338 RVA: 0x00018671 File Offset: 0x00016871
		public void CopyTo(XmlDictionaryReaderQuotas quotas)
		{
			if (quotas == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("quotas"));
			}
			if (quotas.readOnly)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(System.Runtime.Serialization.SR.GetString("Cannot copy XmlDictionaryReaderQuotas. Target is readonly.")));
			}
			this.InternalCopyTo(quotas);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000186AC File Offset: 0x000168AC
		internal void InternalCopyTo(XmlDictionaryReaderQuotas quotas)
		{
			quotas.maxStringContentLength = this.maxStringContentLength;
			quotas.maxArrayLength = this.maxArrayLength;
			quotas.maxDepth = this.maxDepth;
			quotas.maxNameTableCharCount = this.maxNameTableCharCount;
			quotas.maxBytesPerRead = this.maxBytesPerRead;
			quotas.modifiedQuotas = this.modifiedQuotas;
		}

		/// <summary>Получает или задает максимальную длину строки, возвращаемую модулем чтения.</summary>
		/// <returns>Максимальная длина строки, возвращаемой модулем чтения. Значение по умолчанию — 8192.</returns>
		/// <exception cref="T:System.InvalidOperationException">Попытка <see langword="set" /> значение при доступе только для чтения к значению квоты для данного экземпляра.</exception>
		/// <exception cref="T:System.ArgumentException">Попытка <see langword="set" /> значение меньше нуля.</exception>
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00018701 File Offset: 0x00016901
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0001870C File Offset: 0x0001690C
		[DefaultValue(8192)]
		public int MaxStringContentLength
		{
			get
			{
				return this.maxStringContentLength;
			}
			set
			{
				if (this.readOnly)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(System.Runtime.Serialization.SR.GetString("The '{0}' quota is readonly.", new object[]
					{
						"MaxStringContentLength"
					})));
				}
				if (value <= 0)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(System.Runtime.Serialization.SR.GetString("Quota must be a positive value."), "value"));
				}
				this.maxStringContentLength = value;
				this.modifiedQuotas |= XmlDictionaryReaderQuotaTypes.MaxStringContentLength;
			}
		}

		/// <summary>Получает или задает максимально допустимую длину массива.</summary>
		/// <returns>Максимально допустимая длина массива. Значение по умолчанию — 16384.</returns>
		/// <exception cref="T:System.InvalidOperationException">Попытка <see langword="set" /> значение при доступе только для чтения к значению квоты для данного экземпляра.</exception>
		/// <exception cref="T:System.ArgumentException">Попытка <see langword="set" /> значение меньше нуля.</exception>
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00018777 File Offset: 0x00016977
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00018780 File Offset: 0x00016980
		[DefaultValue(16384)]
		public int MaxArrayLength
		{
			get
			{
				return this.maxArrayLength;
			}
			set
			{
				if (this.readOnly)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(System.Runtime.Serialization.SR.GetString("The '{0}' quota is readonly.", new object[]
					{
						"MaxArrayLength"
					})));
				}
				if (value <= 0)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(System.Runtime.Serialization.SR.GetString("Quota must be a positive value."), "value"));
				}
				this.maxArrayLength = value;
				this.modifiedQuotas |= XmlDictionaryReaderQuotaTypes.MaxArrayLength;
			}
		}

		/// <summary>Получает или задает максимально допустимое число байтов, возвращаемых для каждой операции чтения.</summary>
		/// <returns>Максимально допустимое число байтов, возвращаемых для каждой операции чтения. Значение по умолчанию — 4096.</returns>
		/// <exception cref="T:System.InvalidOperationException">Попытка <see langword="set" /> значение при доступе только для чтения к значению квоты для данного экземпляра.</exception>
		/// <exception cref="T:System.ArgumentException">Попытка <see langword="set" /> значение меньше нуля.</exception>
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x000187EB File Offset: 0x000169EB
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x000187F4 File Offset: 0x000169F4
		[DefaultValue(4096)]
		public int MaxBytesPerRead
		{
			get
			{
				return this.maxBytesPerRead;
			}
			set
			{
				if (this.readOnly)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(System.Runtime.Serialization.SR.GetString("The '{0}' quota is readonly.", new object[]
					{
						"MaxBytesPerRead"
					})));
				}
				if (value <= 0)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(System.Runtime.Serialization.SR.GetString("Quota must be a positive value."), "value"));
				}
				this.maxBytesPerRead = value;
				this.modifiedQuotas |= XmlDictionaryReaderQuotaTypes.MaxBytesPerRead;
			}
		}

		/// <summary>Получает или задает максимальную глубину вложенного узла.</summary>
		/// <returns>Максимальная глубина вложенного узла. Значение по умолчанию — 32.</returns>
		/// <exception cref="T:System.InvalidOperationException">Попытка <see langword="set" /> значение при доступе только для чтения к значению квоты для данного экземпляра.</exception>
		/// <exception cref="T:System.ArgumentException">Попытка <see langword="set" /> значение меньше нуля.</exception>
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001885F File Offset: 0x00016A5F
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00018868 File Offset: 0x00016A68
		[DefaultValue(32)]
		public int MaxDepth
		{
			get
			{
				return this.maxDepth;
			}
			set
			{
				if (this.readOnly)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(System.Runtime.Serialization.SR.GetString("The '{0}' quota is readonly.", new object[]
					{
						"MaxDepth"
					})));
				}
				if (value <= 0)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(System.Runtime.Serialization.SR.GetString("Quota must be a positive value."), "value"));
				}
				this.maxDepth = value;
				this.modifiedQuotas |= XmlDictionaryReaderQuotaTypes.MaxDepth;
			}
		}

		/// <summary>Получает или задает максимальное количество символов в имени таблицы.</summary>
		/// <returns>Максимально допустимое количество символов в имени таблицы. Значение по умолчанию — 16384.</returns>
		/// <exception cref="T:System.InvalidOperationException">Попытка <see langword="set" /> значение при доступе только для чтения к значению квоты для данного экземпляра.</exception>
		/// <exception cref="T:System.ArgumentException">Попытка <see langword="set" /> значение меньше нуля.</exception>
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x000188D3 File Offset: 0x00016AD3
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x000188DC File Offset: 0x00016ADC
		[DefaultValue(16384)]
		public int MaxNameTableCharCount
		{
			get
			{
				return this.maxNameTableCharCount;
			}
			set
			{
				if (this.readOnly)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(System.Runtime.Serialization.SR.GetString("The '{0}' quota is readonly.", new object[]
					{
						"MaxNameTableCharCount"
					})));
				}
				if (value <= 0)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(System.Runtime.Serialization.SR.GetString("Quota must be a positive value."), "value"));
				}
				this.maxNameTableCharCount = value;
				this.modifiedQuotas |= XmlDictionaryReaderQuotaTypes.MaxNameTableCharCount;
			}
		}

		/// <summary>Получает измененные квоты для <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />.</summary>
		/// <returns>Измененные квоты для <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />.</returns>
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00018948 File Offset: 0x00016B48
		public XmlDictionaryReaderQuotaTypes ModifiedQuotas
		{
			get
			{
				return this.modifiedQuotas;
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00018950 File Offset: 0x00016B50
		internal void MakeReadOnly()
		{
			this.readOnly = true;
		}

		// Token: 0x04000283 RID: 643
		private bool readOnly;

		// Token: 0x04000284 RID: 644
		private int maxStringContentLength;

		// Token: 0x04000285 RID: 645
		private int maxArrayLength;

		// Token: 0x04000286 RID: 646
		private int maxDepth;

		// Token: 0x04000287 RID: 647
		private int maxNameTableCharCount;

		// Token: 0x04000288 RID: 648
		private int maxBytesPerRead;

		// Token: 0x04000289 RID: 649
		private XmlDictionaryReaderQuotaTypes modifiedQuotas;

		// Token: 0x0400028A RID: 650
		private const int DefaultMaxDepth = 32;

		// Token: 0x0400028B RID: 651
		private const int DefaultMaxStringContentLength = 8192;

		// Token: 0x0400028C RID: 652
		private const int DefaultMaxArrayLength = 16384;

		// Token: 0x0400028D RID: 653
		private const int DefaultMaxBytesPerRead = 4096;

		// Token: 0x0400028E RID: 654
		private const int DefaultMaxNameTableCharCount = 16384;

		// Token: 0x0400028F RID: 655
		private static XmlDictionaryReaderQuotas defaultQuota = new XmlDictionaryReaderQuotas(32, 8192, 16384, 4096, 16384, (XmlDictionaryReaderQuotaTypes)0);

		// Token: 0x04000290 RID: 656
		private static XmlDictionaryReaderQuotas maxQuota = new XmlDictionaryReaderQuotas(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, XmlDictionaryReaderQuotaTypes.MaxDepth | XmlDictionaryReaderQuotaTypes.MaxStringContentLength | XmlDictionaryReaderQuotaTypes.MaxArrayLength | XmlDictionaryReaderQuotaTypes.MaxBytesPerRead | XmlDictionaryReaderQuotaTypes.MaxNameTableCharCount);
	}
}
