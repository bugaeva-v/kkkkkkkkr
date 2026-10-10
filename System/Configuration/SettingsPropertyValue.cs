using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace System.Configuration
{
	/// <summary>Содержит значение свойства установок, которое может быть загружено и сохранено экземпляром <see cref="T:System.Configuration.SettingsBase" />.</summary>
	// Token: 0x020001D0 RID: 464
	public class SettingsPropertyValue
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyValue" /> на основе предоставленных параметров.</summary>
		/// <param name="property">Определяет объект <see cref="T:System.Configuration.SettingsProperty" />.</param>
		// Token: 0x06000C27 RID: 3111 RVA: 0x000320F2 File Offset: 0x000302F2
		public SettingsPropertyValue(SettingsProperty property)
		{
			this.property = property;
			this.needPropertyValue = true;
			this.needSerializedValue = true;
		}

		/// <summary>Возвращает или устанавливает признак, указывающий может ли значение объекта <see cref="T:System.Configuration.SettingsProperty" /> быть десериализовано.</summary>
		/// <returns>
		///   <see langword="true" />, если значение объекта <see cref="T:System.Configuration.SettingsProperty" /> было десериализовано; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0003210F File Offset: 0x0003030F
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x00032117 File Offset: 0x00030317
		public bool Deserialized
		{
			get
			{
				return this.deserialized;
			}
			set
			{
				this.deserialized = value;
			}
		}

		/// <summary>Возвращает или устанавливает признак, указывающий было ли изменено значение объекта <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>
		///   <see langword="true" />, если значение объекта <see cref="T:System.Configuration.SettingsProperty" /> было изменено; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00032120 File Offset: 0x00030320
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x00032128 File Offset: 0x00030328
		public bool IsDirty
		{
			get
			{
				return this.dirty;
			}
			set
			{
				this.dirty = value;
			}
		}

		/// <summary>Возвращает имя свойства из связанного объекта <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>Имя объекта <see cref="T:System.Configuration.SettingsProperty" />.</returns>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00032131 File Offset: 0x00030331
		public string Name
		{
			get
			{
				return this.property.Name;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.SettingsProperty" />, описывающий объект <see cref="T:System.Configuration.SettingsPropertyValue" />.</returns>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0003213E File Offset: 0x0003033E
		public SettingsProperty Property
		{
			get
			{
				return this.property;
			}
		}

		/// <summary>Возвращает или задает значение объекта <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>Значение объекта <see cref="T:System.Configuration.SettingsProperty" />. Когда значение устанавливается, свойство <see cref="P:System.Configuration.SettingsPropertyValue.IsDirty" /> устанавливается в <see langword="true" /> и <see cref="P:System.Configuration.SettingsPropertyValue.UsingDefaultValue" /> устанавливается в <see langword="false" />.  
		/// Когда в первый раз к значению производится доступ из свойства <see cref="P:System.Configuration.SettingsPropertyValue.PropertyValue" />, и если значение изначально хранилось в объекте <see cref="T:System.Configuration.SettingsPropertyValue" /> как сериализованное представление, используя свойство <see cref="P:System.Configuration.SettingsPropertyValue.SerializedValue" />, то свойство <see cref="P:System.Configuration.SettingsPropertyValue.PropertyValue" /> инициирует десериализацию лежащего в основе значения.  Как побочный эффект, свойство <see cref="P:System.Configuration.SettingsPropertyValue.Deserialized" /> будет установлено в <see langword="true" />.  
		/// Если эта цепочка событий происходит в ASP.NET, и если ошибка случается в процессе десериализации, то ошибка заносится в журнал, используя средства мониторинга состояния оборудования ASP.NET. По умолчанию, это означает, что ошибки десериализации будут показываться в Журнале событий приложения при работе под ASP.NET. Если этот процесс происходит вне ASP.NET, и если ошибка случается во время десериализации, то ошибка подавляется, и реализуется оставшаяся часть процесса десериализации. Если нет сериализованных значений для десериализации при попытке выполнения десериализации, то объект <see cref="T:System.Configuration.SettingsPropertyValue" /> попытается вернуться к значению по умолчанию, если оно было сконфигурировано согласно определению на связанном экземпляре <see cref="T:System.Configuration.SettingsProperty" />. В этом случае, если свойство <see cref="P:System.Configuration.SettingsProperty.DefaultValue" /> установлено либо в <see langword="null" />, либо в строку [null], то объект <see cref="T:System.Configuration.SettingsPropertyValue" /> будет инициализировать свойство <see cref="P:System.Configuration.SettingsPropertyValue.PropertyValue" /> либо в <see langword="null" /> для ссылочных типов, либо в значение по умолчанию для ассоциированного типа значения.  С другой стороны, если свойство <see cref="P:System.Configuration.SettingsProperty.DefaultValue" /> содержит законную ссылку на объект или строковое значение (отличное от "[null]"), то взамен возвращается свойство <see cref="P:System.Configuration.SettingsProperty.DefaultValue" />.  
		/// Если нет сериализованных значений для десериализации при попытке выполнения десериализации, и не определено значение по умолчанию, то для строковых типов будет возвращена пустая строка. Для всех других типов, экземпляр по умолчанию будет возвращаться посредством вызова <see cref="M:System.Activator.CreateInstance(System.Type)" /> — для ссылочных типов это означает, что будет сделана попытка создать экземпляр объекта с использованием конструктора по умолчанию.  Если эта попытка терпит неудачу, то возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка при попытке использовать значение по умолчанию из свойства <see cref="P:System.Configuration.SettingsProperty.DefaultValue" />.  Либо потерпела неудачу попытка преобразовать свойство <see cref="P:System.Configuration.SettingsProperty.DefaultValue" /> в законный тип, или результирующее значение оказалось несовместимым с типом определенным <see cref="P:System.Configuration.SettingsProperty.PropertyType" />.</exception>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00032148 File Offset: 0x00030348
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x000321E0 File Offset: 0x000303E0
		public object PropertyValue
		{
			get
			{
				if (this.needPropertyValue)
				{
					this.propertyValue = this.GetDeserializedValue(this.serializedValue);
					if (this.propertyValue == null)
					{
						this.propertyValue = this.GetDeserializedDefaultValue();
						this.serializedValue = null;
						this.needSerializedValue = true;
						this.defaulted = true;
					}
					this.needPropertyValue = false;
				}
				if (this.propertyValue != null && !(this.propertyValue is string) && !(this.propertyValue is DateTime) && !this.property.PropertyType.IsPrimitive)
				{
					this.dirty = true;
				}
				return this.propertyValue;
			}
			set
			{
				this.propertyValue = value;
				this.dirty = true;
				this.needPropertyValue = false;
				this.needSerializedValue = true;
				this.defaulted = false;
			}
		}

		/// <summary>Возвращает или задает сериализованное значение объекта <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>Сериализованное значение объекта <see cref="T:System.Configuration.SettingsProperty" />.</returns>
		/// <exception cref="T:System.ArgumentException">Опции сериализации для свойства указало на использование преобразователя строкового типа, но преобразователь типа не был доступен.</exception>
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00032208 File Offset: 0x00030408
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x00032313 File Offset: 0x00030513
		public object SerializedValue
		{
			get
			{
				if ((this.needSerializedValue || this.IsDirty) && !this.UsingDefaultValue)
				{
					switch (this.property.SerializeAs)
					{
					case SettingsSerializeAs.String:
						this.serializedValue = TypeDescriptor.GetConverter(this.property.PropertyType).ConvertToInvariantString(this.propertyValue);
						break;
					case SettingsSerializeAs.Xml:
						if (this.propertyValue != null)
						{
							XmlSerializer xmlSerializer = new XmlSerializer(this.propertyValue.GetType());
							StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
							xmlSerializer.Serialize(stringWriter, this.propertyValue);
							this.serializedValue = stringWriter.ToString();
						}
						else
						{
							this.serializedValue = null;
						}
						break;
					case SettingsSerializeAs.Binary:
						if (this.propertyValue != null)
						{
							BinaryFormatter binaryFormatter = new BinaryFormatter();
							MemoryStream memoryStream = new MemoryStream();
							binaryFormatter.Serialize(memoryStream, this.propertyValue);
							this.serializedValue = memoryStream.ToArray();
						}
						else
						{
							this.serializedValue = null;
						}
						break;
					default:
						this.serializedValue = null;
						break;
					}
					this.needSerializedValue = false;
					this.dirty = false;
				}
				return this.serializedValue;
			}
			set
			{
				this.serializedValue = value;
				this.needPropertyValue = true;
				this.needSerializedValue = false;
			}
		}

		/// <summary>Возвращает логическое значение, определяющее, является ли значение объекта <see cref="T:System.Configuration.SettingsPropertyValue" /> значением по умолчанию, как определено значением свойства <see cref="P:System.Configuration.SettingsProperty.DefaultValue" /> на ассоциированном объекте <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>
		///   <see langword="true" />, если значение объекта <see cref="T:System.Configuration.SettingsProperty" /> является значением по умолчанию; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0003232A File Offset: 0x0003052A
		public bool UsingDefaultValue
		{
			get
			{
				return this.defaulted;
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00032332 File Offset: 0x00030532
		internal object Reset()
		{
			this.propertyValue = this.GetDeserializedDefaultValue();
			this.dirty = true;
			this.defaulted = true;
			this.needPropertyValue = true;
			this.needSerializedValue = true;
			return this.propertyValue;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00032364 File Offset: 0x00030564
		private object GetDeserializedDefaultValue()
		{
			if (this.property.DefaultValue == null)
			{
				if (this.property.PropertyType != null && this.property.PropertyType.IsValueType)
				{
					return Activator.CreateInstance(this.property.PropertyType);
				}
				return null;
			}
			else if (this.property.DefaultValue is string && ((string)this.property.DefaultValue).Length == 0)
			{
				if (this.property.PropertyType != typeof(string))
				{
					return Activator.CreateInstance(this.property.PropertyType);
				}
				return string.Empty;
			}
			else
			{
				if (this.property.DefaultValue is string && ((string)this.property.DefaultValue).Length > 0)
				{
					return this.GetDeserializedValue(this.property.DefaultValue);
				}
				if (!this.property.PropertyType.IsAssignableFrom(this.property.DefaultValue.GetType()))
				{
					return TypeDescriptor.GetConverter(this.property.PropertyType).ConvertFrom(null, CultureInfo.InvariantCulture, this.property.DefaultValue);
				}
				return this.property.DefaultValue;
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000324A4 File Offset: 0x000306A4
		private object GetDeserializedValue(object serializedValue)
		{
			if (serializedValue == null)
			{
				return null;
			}
			object result = null;
			try
			{
				switch (this.property.SerializeAs)
				{
				case SettingsSerializeAs.String:
					if (serializedValue is string)
					{
						result = TypeDescriptor.GetConverter(this.property.PropertyType).ConvertFromInvariantString((string)serializedValue);
					}
					break;
				case SettingsSerializeAs.Xml:
				{
					XmlSerializer xmlSerializer = new XmlSerializer(this.property.PropertyType);
					StringReader input = new StringReader((string)serializedValue);
					result = xmlSerializer.Deserialize(XmlReader.Create(input));
					break;
				}
				case SettingsSerializeAs.Binary:
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					MemoryStream serializationStream;
					if (serializedValue is string)
					{
						serializationStream = new MemoryStream(Convert.FromBase64String((string)serializedValue));
					}
					else
					{
						serializationStream = new MemoryStream((byte[])serializedValue);
					}
					result = binaryFormatter.Deserialize(serializationStream);
					break;
				}
				}
			}
			catch (Exception ex)
			{
				if (this.property.ThrowOnErrorDeserializing)
				{
					throw ex;
				}
			}
			return result;
		}

		// Token: 0x040007A8 RID: 1960
		private readonly SettingsProperty property;

		// Token: 0x040007A9 RID: 1961
		private object propertyValue;

		// Token: 0x040007AA RID: 1962
		private object serializedValue;

		// Token: 0x040007AB RID: 1963
		private bool needSerializedValue;

		// Token: 0x040007AC RID: 1964
		private bool needPropertyValue;

		// Token: 0x040007AD RID: 1965
		private bool dirty;

		// Token: 0x040007AE RID: 1966
		private bool defaulted;

		// Token: 0x040007AF RID: 1967
		private bool deserialized;
	}
}
