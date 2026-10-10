using System;

namespace System.Security.Cryptography
{
	/// <summary>Содержит тип и коллекцию значений, связанных с этим типом.</summary>
	// Token: 0x0200000D RID: 13
	public sealed class CryptographicAttributeObject
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />, используя атрибут, представленный заданным объектом <see cref="T:System.Security.Cryptography.Oid" />.</summary>
		/// <param name="oid">Атрибут, сохраняемый в данном объекте <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />.</param>
		// Token: 0x06000029 RID: 41 RVA: 0x00002628 File Offset: 0x00000828
		public CryptographicAttributeObject(Oid oid) : this(oid, new AsnEncodedDataCollection())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />, используя атрибут, представленный заданным объектом <see cref="T:System.Security.Cryptography.Oid" />, и множество связанных с этим атрибутом значений, которое представлено заданной коллекцией <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <param name="oid">Атрибут, сохраняемый в данном объекте <see cref="T:System.Security.Cryptography.CryptographicAttributeObject" />.</param>
		/// <param name="values">Набор значений, связанный с атрибутом, представленным параметром <paramref name="oid" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Коллекция содержит повторяющиеся элементы.</exception>
		// Token: 0x0600002A RID: 42 RVA: 0x00002638 File Offset: 0x00000838
		public CryptographicAttributeObject(Oid oid, AsnEncodedDataCollection values)
		{
			this._oid = new Oid(oid);
			if (values == null)
			{
				this.Values = new AsnEncodedDataCollection();
				return;
			}
			foreach (AsnEncodedData asnEncodedData in values)
			{
				if (!string.Equals(asnEncodedData.Oid.Value, oid.Value, StringComparison.Ordinal))
				{
					throw new InvalidOperationException(SR.Format("AsnEncodedData element in the collection has wrong Oid value: expected = '{0}', actual = '{1}'.", oid.Value, asnEncodedData.Oid.Value));
				}
			}
			this.Values = values;
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.Oid" />, задающий идентификатор объекта для атрибута.</summary>
		/// <returns>Идентификатор объекта для атрибута.</returns>
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000026BF File Offset: 0x000008BF
		public Oid Oid
		{
			get
			{
				return new Oid(this._oid);
			}
		}

		/// <summary>Получает коллекцию <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />, в которой содержится множество значений, связанных с атрибутом.</summary>
		/// <returns>Набор значений, связанный с атрибутом.</returns>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000026CC File Offset: 0x000008CC
		public AsnEncodedDataCollection Values { get; }

		// Token: 0x04000081 RID: 129
		private readonly Oid _oid;
	}
}
