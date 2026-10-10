using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace System.Security.Claims
{
	/// <summary>Представляет утверждение.</summary>
	// Token: 0x020004F0 RID: 1264
	[Serializable]
	public class Claim
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Claims.Claim" /> с указанным <see cref="T:System.IO.BinaryReader" />.</summary>
		/// <param name="reader">Объект <see cref="T:System.IO.BinaryReader" />, указывающий на <see cref="T:System.Security.Claims.Claim" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="reader" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003283 RID: 12931 RVA: 0x000B9B54 File Offset: 0x000B7D54
		public Claim(BinaryReader reader) : this(reader, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.Claim" /> заданным модулем чтения и субъектом.</summary>
		/// <param name="reader">Модуль чтения двоичных данных.</param>
		/// <param name="subject">Субъект, который описывает данное утверждение.</param>
		// Token: 0x06003284 RID: 12932 RVA: 0x000B9B5E File Offset: 0x000B7D5E
		public Claim(BinaryReader reader, ClaimsIdentity subject)
		{
			this.m_propertyLock = new object();
			base..ctor();
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			this.Initialize(reader, subject);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.Claim" /> с указанным типом утверждения и значением.</summary>
		/// <param name="type">Тип утверждения.</param>
		/// <param name="value">Значение утверждения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003285 RID: 12933 RVA: 0x000B9B87 File Offset: 0x000B7D87
		public Claim(string type, string value) : this(type, value, "http://www.w3.org/2001/XMLSchema#string", "LOCAL AUTHORITY", "LOCAL AUTHORITY", null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.Claim" /> указанным типом утверждения, значением и типом значения.</summary>
		/// <param name="type">Тип утверждения.</param>
		/// <param name="value">Значение утверждения.</param>
		/// <param name="valueType">Тип значения утверждения. Если этот параметр имеет значение <see langword="null" />, используется <see cref="F:System.Security.Claims.ClaimValueTypes.String" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003286 RID: 12934 RVA: 0x000B9BA1 File Offset: 0x000B7DA1
		public Claim(string type, string value, string valueType) : this(type, value, valueType, "LOCAL AUTHORITY", "LOCAL AUTHORITY", null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.Claim" /> указанным типом утверждения, значением, типом значения и издателем.</summary>
		/// <param name="type">Тип утверждения.</param>
		/// <param name="value">Значение утверждения.</param>
		/// <param name="valueType">Тип значения утверждения. Если этот параметр имеет значение <see langword="null" />, используется <see cref="F:System.Security.Claims.ClaimValueTypes.String" />.</param>
		/// <param name="issuer">Издатель утверждения. Если этот параметр пуст или имеет значение <see langword="null" />, используется <see cref="F:System.Security.Claims.ClaimsIdentity.DefaultIssuer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003287 RID: 12935 RVA: 0x000B9BB7 File Offset: 0x000B7DB7
		public Claim(string type, string value, string valueType, string issuer) : this(type, value, valueType, issuer, issuer, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.Claim" /> с заданным типом утверждения, значением, типом значения, издателем и первоначальным издателем.</summary>
		/// <param name="type">Тип утверждения.</param>
		/// <param name="value">Значение утверждения.</param>
		/// <param name="valueType">Тип значения утверждения. Если этот параметр имеет значение <see langword="null" />, используется <see cref="F:System.Security.Claims.ClaimValueTypes.String" />.</param>
		/// <param name="issuer">Издатель утверждения. Если этот параметр пуст или имеет значение <see langword="null" />, используется <see cref="F:System.Security.Claims.ClaimsIdentity.DefaultIssuer" />.</param>
		/// <param name="originalIssuer">Первоначальный издатель утверждения. Если этот параметр пуст или имеет значение <see langword="null" />, то для свойства <see cref="P:System.Security.Claims.Claim.OriginalIssuer" /> задается значение свойства <see cref="P:System.Security.Claims.Claim.Issuer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003288 RID: 12936 RVA: 0x000B9BC7 File Offset: 0x000B7DC7
		public Claim(string type, string value, string valueType, string issuer, string originalIssuer) : this(type, value, valueType, issuer, originalIssuer, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.Claim" /> с заданным типом утверждения, значением, типом значения, издателем, первоначальным издателем и темой.</summary>
		/// <param name="type">Тип утверждения.</param>
		/// <param name="value">Значение утверждения.</param>
		/// <param name="valueType">Тип значения утверждения. Если этот параметр имеет значение <see langword="null" />, используется <see cref="F:System.Security.Claims.ClaimValueTypes.String" />.</param>
		/// <param name="issuer">Издатель утверждения. Если этот параметр пуст или имеет значение <see langword="null" />, используется <see cref="F:System.Security.Claims.ClaimsIdentity.DefaultIssuer" />.</param>
		/// <param name="originalIssuer">Первоначальный издатель утверждения. Если этот параметр пуст или имеет значение <see langword="null" />, то <see cref="P:System.Security.Claims.Claim.OriginalIssuer" /> свойству задается значение свойства <see cref="P:System.Security.Claims.Claim.Issuer" />.</param>
		/// <param name="subject">Субъект, который описывает данное утверждение.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003289 RID: 12937 RVA: 0x000B9BD8 File Offset: 0x000B7DD8
		public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) : this(type, value, valueType, issuer, originalIssuer, subject, null, null)
		{
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
		internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
		{
			this.m_propertyLock = new object();
			base..ctor();
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.m_type = type;
			this.m_value = value;
			if (string.IsNullOrEmpty(valueType))
			{
				this.m_valueType = "http://www.w3.org/2001/XMLSchema#string";
			}
			else
			{
				this.m_valueType = valueType;
			}
			if (string.IsNullOrEmpty(issuer))
			{
				this.m_issuer = "LOCAL AUTHORITY";
			}
			else
			{
				this.m_issuer = issuer;
			}
			if (string.IsNullOrEmpty(originalIssuer))
			{
				this.m_originalIssuer = this.m_issuer;
			}
			else
			{
				this.m_originalIssuer = originalIssuer;
			}
			this.m_subject = subject;
			if (propertyKey != null)
			{
				this.Properties.Add(propertyKey, propertyValue);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.Claim" />.</summary>
		/// <param name="other">Утверждение безопасности.</param>
		// Token: 0x0600328B RID: 12939 RVA: 0x000B9CB4 File Offset: 0x000B7EB4
		protected Claim(Claim other) : this(other, (other == null) ? null : other.m_subject)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.Claim" /> указанным утверждением безопасности и субъектом.</summary>
		/// <param name="other">Утверждение безопасности.</param>
		/// <param name="subject">Субъект, который описывает данное утверждение.</param>
		// Token: 0x0600328C RID: 12940 RVA: 0x000B9CCC File Offset: 0x000B7ECC
		protected Claim(Claim other, ClaimsIdentity subject)
		{
			this.m_propertyLock = new object();
			base..ctor();
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.m_issuer = other.m_issuer;
			this.m_originalIssuer = other.m_originalIssuer;
			this.m_subject = subject;
			this.m_type = other.m_type;
			this.m_value = other.m_value;
			this.m_valueType = other.m_valueType;
			if (other.m_properties != null)
			{
				this.m_properties = new Dictionary<string, string>();
				foreach (string key in other.m_properties.Keys)
				{
					this.m_properties.Add(key, other.m_properties[key]);
				}
			}
			if (other.m_userSerializationData != null)
			{
				this.m_userSerializationData = (other.m_userSerializationData.Clone() as byte[]);
			}
		}

		/// <summary>Содержит дополнительные данные, предоставленные производным типом.</summary>
		/// <returns>Объект <see cref="T:System.Byte" /> массив, представляющий дополнительный сериализованных данных.</returns>
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x000B9DC8 File Offset: 0x000B7FC8
		protected virtual byte[] CustomSerializationData
		{
			get
			{
				return this.m_userSerializationData;
			}
		}

		/// <summary>Возвращает издатель утверждения.</summary>
		/// <returns>Имя, которое ссылается на издатель утверждения.</returns>
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x000B9DD0 File Offset: 0x000B7FD0
		public string Issuer
		{
			get
			{
				return this.m_issuer;
			}
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000B9DD8 File Offset: 0x000B7FD8
		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context)
		{
			this.m_propertyLock = new object();
		}

		/// <summary>Возвращает исходный издатель утверждения.</summary>
		/// <returns>Имя, которое ссылается на исходный издатель утверждения.</returns>
		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x000B9DE5 File Offset: 0x000B7FE5
		public string OriginalIssuer
		{
			get
			{
				return this.m_originalIssuer;
			}
		}

		/// <summary>Возвращает словарь, содержащий дополнительные свойства, связанные с этим утверждением.</summary>
		/// <returns>Словарь, содержащий дополнительные свойства, связанные с этим утверждением. Свойства представлены в виде пар "имя-значение".</returns>
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x000B9DF0 File Offset: 0x000B7FF0
		public IDictionary<string, string> Properties
		{
			get
			{
				if (this.m_properties == null)
				{
					object propertyLock = this.m_propertyLock;
					lock (propertyLock)
					{
						if (this.m_properties == null)
						{
							this.m_properties = new Dictionary<string, string>();
						}
					}
				}
				return this.m_properties;
			}
		}

		/// <summary>Получает субъект утверждения.</summary>
		/// <returns>Субъект утверждения.</returns>
		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x000B9E4C File Offset: 0x000B804C
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x000B9E54 File Offset: 0x000B8054
		public ClaimsIdentity Subject
		{
			get
			{
				return this.m_subject;
			}
			internal set
			{
				this.m_subject = value;
			}
		}

		/// <summary>Получает тип утверждения.</summary>
		/// <returns>Тип утверждения.</returns>
		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x000B9E5D File Offset: 0x000B805D
		public string Type
		{
			get
			{
				return this.m_type;
			}
		}

		/// <summary>Возвращает значение утверждения.</summary>
		/// <returns>Значение утверждения.</returns>
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x000B9E65 File Offset: 0x000B8065
		public string Value
		{
			get
			{
				return this.m_value;
			}
		}

		/// <summary>Возвращает тип значения утверждения.</summary>
		/// <returns>Тип значения утверждения.</returns>
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x000B9E6D File Offset: 0x000B806D
		public string ValueType
		{
			get
			{
				return this.m_valueType;
			}
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Security.Claims.Claim" />, скопированный из этого объекта. Новое утверждение не имеет субъекта.</summary>
		/// <returns>Новый объект утверждения.</returns>
		// Token: 0x06003297 RID: 12951 RVA: 0x000B9E75 File Offset: 0x000B8075
		public virtual Claim Clone()
		{
			return this.Clone(null);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Security.Claims.Claim" />, скопированный из этого объекта. Субъект нового утверждения имеет значение указанного ClaimsIdentity.</summary>
		/// <param name="identity">Предполагаемый субъект нового утверждения.</param>
		/// <returns>Новый объект утверждения.</returns>
		// Token: 0x06003298 RID: 12952 RVA: 0x000B9E7E File Offset: 0x000B807E
		public virtual Claim Clone(ClaimsIdentity identity)
		{
			return new Claim(this, identity);
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000B9E88 File Offset: 0x000B8088
		private void Initialize(BinaryReader reader, ClaimsIdentity subject)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			this.m_subject = subject;
			Claim.SerializationMask serializationMask = (Claim.SerializationMask)reader.ReadInt32();
			int num = 1;
			int num2 = reader.ReadInt32();
			this.m_value = reader.ReadString();
			if ((serializationMask & Claim.SerializationMask.NameClaimType) == Claim.SerializationMask.NameClaimType)
			{
				this.m_type = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			}
			else if ((serializationMask & Claim.SerializationMask.RoleClaimType) == Claim.SerializationMask.RoleClaimType)
			{
				this.m_type = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			}
			else
			{
				this.m_type = reader.ReadString();
				num++;
			}
			if ((serializationMask & Claim.SerializationMask.StringType) == Claim.SerializationMask.StringType)
			{
				this.m_valueType = reader.ReadString();
				num++;
			}
			else
			{
				this.m_valueType = "http://www.w3.org/2001/XMLSchema#string";
			}
			if ((serializationMask & Claim.SerializationMask.Issuer) == Claim.SerializationMask.Issuer)
			{
				this.m_issuer = reader.ReadString();
				num++;
			}
			else
			{
				this.m_issuer = "LOCAL AUTHORITY";
			}
			if ((serializationMask & Claim.SerializationMask.OriginalIssuerEqualsIssuer) == Claim.SerializationMask.OriginalIssuerEqualsIssuer)
			{
				this.m_originalIssuer = this.m_issuer;
			}
			else if ((serializationMask & Claim.SerializationMask.OriginalIssuer) == Claim.SerializationMask.OriginalIssuer)
			{
				this.m_originalIssuer = reader.ReadString();
				num++;
			}
			else
			{
				this.m_originalIssuer = "LOCAL AUTHORITY";
			}
			if ((serializationMask & Claim.SerializationMask.HasProperties) == Claim.SerializationMask.HasProperties)
			{
				int num3 = reader.ReadInt32();
				for (int i = 0; i < num3; i++)
				{
					this.Properties.Add(reader.ReadString(), reader.ReadString());
				}
			}
			if ((serializationMask & Claim.SerializationMask.UserData) == Claim.SerializationMask.UserData)
			{
				int count = reader.ReadInt32();
				this.m_userSerializationData = reader.ReadBytes(count);
				num++;
			}
			for (int j = num; j < num2; j++)
			{
				reader.ReadString();
			}
		}

		/// <summary>Записывает это утверждение <see cref="T:System.Security.Claims.Claim" /> в модуль записи.</summary>
		/// <param name="writer">Модуль записи, используемый для хранения данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="writer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600329A RID: 12954 RVA: 0x000B9FF2 File Offset: 0x000B81F2
		public virtual void WriteTo(BinaryWriter writer)
		{
			this.WriteTo(writer, null);
		}

		/// <summary>Записывает это утверждение <see cref="T:System.Security.Claims.Claim" /> в модуль записи.</summary>
		/// <param name="writer">Модуль записи, в который производится запись этого утверждения.</param>
		/// <param name="userData">Данные пользователя для утверждения.</param>
		// Token: 0x0600329B RID: 12955 RVA: 0x000B9FFC File Offset: 0x000B81FC
		protected virtual void WriteTo(BinaryWriter writer, byte[] userData)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			int num = 1;
			Claim.SerializationMask serializationMask = Claim.SerializationMask.None;
			if (string.Equals(this.m_type, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"))
			{
				serializationMask |= Claim.SerializationMask.NameClaimType;
			}
			else if (string.Equals(this.m_type, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"))
			{
				serializationMask |= Claim.SerializationMask.RoleClaimType;
			}
			else
			{
				num++;
			}
			if (!string.Equals(this.m_valueType, "http://www.w3.org/2001/XMLSchema#string", StringComparison.Ordinal))
			{
				num++;
				serializationMask |= Claim.SerializationMask.StringType;
			}
			if (!string.Equals(this.m_issuer, "LOCAL AUTHORITY", StringComparison.Ordinal))
			{
				num++;
				serializationMask |= Claim.SerializationMask.Issuer;
			}
			if (string.Equals(this.m_originalIssuer, this.m_issuer, StringComparison.Ordinal))
			{
				serializationMask |= Claim.SerializationMask.OriginalIssuerEqualsIssuer;
			}
			else if (!string.Equals(this.m_originalIssuer, "LOCAL AUTHORITY", StringComparison.Ordinal))
			{
				num++;
				serializationMask |= Claim.SerializationMask.OriginalIssuer;
			}
			if (this.Properties.Count > 0)
			{
				num++;
				serializationMask |= Claim.SerializationMask.HasProperties;
			}
			if (userData != null && userData.Length != 0)
			{
				num++;
				serializationMask |= Claim.SerializationMask.UserData;
			}
			writer.Write((int)serializationMask);
			writer.Write(num);
			writer.Write(this.m_value);
			if ((serializationMask & Claim.SerializationMask.NameClaimType) != Claim.SerializationMask.NameClaimType && (serializationMask & Claim.SerializationMask.RoleClaimType) != Claim.SerializationMask.RoleClaimType)
			{
				writer.Write(this.m_type);
			}
			if ((serializationMask & Claim.SerializationMask.StringType) == Claim.SerializationMask.StringType)
			{
				writer.Write(this.m_valueType);
			}
			if ((serializationMask & Claim.SerializationMask.Issuer) == Claim.SerializationMask.Issuer)
			{
				writer.Write(this.m_issuer);
			}
			if ((serializationMask & Claim.SerializationMask.OriginalIssuer) == Claim.SerializationMask.OriginalIssuer)
			{
				writer.Write(this.m_originalIssuer);
			}
			if ((serializationMask & Claim.SerializationMask.HasProperties) == Claim.SerializationMask.HasProperties)
			{
				writer.Write(this.Properties.Count);
				foreach (string text in this.Properties.Keys)
				{
					writer.Write(text);
					writer.Write(this.Properties[text]);
				}
			}
			if ((serializationMask & Claim.SerializationMask.UserData) == Claim.SerializationMask.UserData)
			{
				writer.Write(userData.Length);
				writer.Write(userData);
			}
			writer.Flush();
		}

		/// <summary>Возвращает строковое представление этого объекта <see cref="T:System.Security.Claims.Claim" />.</summary>
		/// <returns>Строковое представление конкретного объекта <see cref="T:System.Security.Claims.Claim" />.</returns>
		// Token: 0x0600329C RID: 12956 RVA: 0x000BA1E4 File Offset: 0x000B83E4
		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}: {1}", this.m_type, this.m_value);
		}

		// Token: 0x04002381 RID: 9089
		private string m_issuer;

		// Token: 0x04002382 RID: 9090
		private string m_originalIssuer;

		// Token: 0x04002383 RID: 9091
		private string m_type;

		// Token: 0x04002384 RID: 9092
		private string m_value;

		// Token: 0x04002385 RID: 9093
		private string m_valueType;

		// Token: 0x04002386 RID: 9094
		[NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04002387 RID: 9095
		private Dictionary<string, string> m_properties;

		// Token: 0x04002388 RID: 9096
		[NonSerialized]
		private object m_propertyLock;

		// Token: 0x04002389 RID: 9097
		[NonSerialized]
		private ClaimsIdentity m_subject;

		// Token: 0x020004F1 RID: 1265
		private enum SerializationMask
		{
			// Token: 0x0400238B RID: 9099
			None,
			// Token: 0x0400238C RID: 9100
			NameClaimType,
			// Token: 0x0400238D RID: 9101
			RoleClaimType,
			// Token: 0x0400238E RID: 9102
			StringType = 4,
			// Token: 0x0400238F RID: 9103
			Issuer = 8,
			// Token: 0x04002390 RID: 9104
			OriginalIssuerEqualsIssuer = 16,
			// Token: 0x04002391 RID: 9105
			OriginalIssuer = 32,
			// Token: 0x04002392 RID: 9106
			HasProperties = 64,
			// Token: 0x04002393 RID: 9107
			UserData = 128
		}
	}
}
