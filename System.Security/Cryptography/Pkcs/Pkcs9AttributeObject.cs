using System;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Представляет атрибут, который используется для операций CMS/PKCS 7 и PKCS 9.</summary>
	// Token: 0x02000079 RID: 121
	public class Pkcs9AttributeObject : AsnEncodedData
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9AttributeObject" />.</summary>
		// Token: 0x060003FA RID: 1018 RVA: 0x000128BC File Offset: 0x00010ABC
		public Pkcs9AttributeObject()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9AttributeObject" />, используя в качестве типа атрибута указанное строковое представление идентификатора объекта (OID), а в качестве значения атрибута указанные данные в формате ASN.1.</summary>
		/// <param name="oid">Строковое представление OID, представляющее тип атрибута PKCS #9.</param>
		/// <param name="encodedData">Массив байтовых значений, содержащий значение атрибута PKCS 9.</param>
		// Token: 0x060003FB RID: 1019 RVA: 0x000128C4 File Offset: 0x00010AC4
		public Pkcs9AttributeObject(string oid, byte[] encodedData) : this(new AsnEncodedData(oid, encodedData))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9AttributeObject" />, используя в качестве типа атрибута указанный объект <see cref="T:System.Security.Cryptography.Oid" />, а в качестве значения атрибута указанные данные в формате ASN.1.</summary>
		/// <param name="oid">Объект, которые представляет тип атрибута PKCS 9.</param>
		/// <param name="encodedData">Массив байтовых значений, представляющий значение атрибута PKCS 9.</param>
		// Token: 0x060003FC RID: 1020 RVA: 0x000128D3 File Offset: 0x00010AD3
		public Pkcs9AttributeObject(Oid oid, byte[] encodedData) : this(new AsnEncodedData(oid, encodedData))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9AttributeObject" />, используя в качестве типа и значения атрибута указанный объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</summary>
		/// <param name="asnEncodedData">Объект, который содержит тип и значение атрибута PKCS 9.</param>
		/// <exception cref="T:System.ArgumentException">Длина элемента <paramref name="Value" /> элемента <paramref name="Oid" /> в составе <paramref name="asnEncodedData" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">Элемент <paramref name="Oid" /> объекта <paramref name="asnEncodedData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Элемент <paramref name="Value" /> элемента <paramref name="Oid" /> класса <paramref name="asnEncodedData" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060003FD RID: 1021 RVA: 0x000128E4 File Offset: 0x00010AE4
		public Pkcs9AttributeObject(AsnEncodedData asnEncodedData) : base(asnEncodedData)
		{
			if (asnEncodedData.Oid == null)
			{
				throw new ArgumentNullException("Oid");
			}
			string value = base.Oid.Value;
			if (value == null)
			{
				throw new ArgumentNullException("oid.Value");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException("String cannot be empty or null.", "oid.Value");
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001293B File Offset: 0x00010B3B
		internal Pkcs9AttributeObject(Oid oid)
		{
			base.Oid = oid;
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.Oid" />, который представляет тип атрибута, связанного с данным объектом <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9AttributeObject" />.</summary>
		/// <returns>Объект, который представляет тип атрибута, связанного с данным объектом <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9AttributeObject" />.</returns>
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0001294A File Offset: 0x00010B4A
		public new Oid Oid
		{
			get
			{
				return base.Oid;
			}
		}

		/// <summary>Копирует тип и значение атрибута PKCS 9 для данного объекта <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9AttributeObject" /> из указанного объекта <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</summary>
		/// <param name="asnEncodedData">Объект, который содержит тип и значение атрибута PKCS 9.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asnEncodeData" /> не представляет совместимый тип атрибута.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asnEncodedData" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000400 RID: 1024 RVA: 0x00012952 File Offset: 0x00010B52
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("asnEncodedData");
			}
			if (!(asnEncodedData is Pkcs9AttributeObject))
			{
				throw new ArgumentException("The parameter should be a PKCS 9 attribute.");
			}
			base.CopyFrom(asnEncodedData);
		}
	}
}
