using System;
using System.Threading;
using Internal.Cryptography;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9SigningTime" /> определяет дату и время подписи. Объект <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9SigningTime" /> можно использовать в качестве атрибута прохождения аутентификации объекта <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />, если необходимо, чтобы цифровая подпись быть снабжена датой и временем прохождения аутентификации.</summary>
	// Token: 0x0200007E RID: 126
	public sealed class Pkcs9SigningTime : Pkcs9AttributeObject
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.Pkcs9SigningTime.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9SigningTime" />.</summary>
		// Token: 0x06000418 RID: 1048 RVA: 0x00012C0B File Offset: 0x00010E0B
		public Pkcs9SigningTime() : this(DateTime.Now)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.Pkcs9SigningTime.#ctor(System.DateTime)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9SigningTime" />, используя указанное значение даты и времени подписи.</summary>
		/// <param name="signingTime">Структура <see cref="T:System.DateTime" />, представляющая дату и время подписи.</param>
		// Token: 0x06000419 RID: 1049 RVA: 0x00012C18 File Offset: 0x00010E18
		public Pkcs9SigningTime(DateTime signingTime) : base("1.2.840.113549.1.9.5", Pkcs9SigningTime.Encode(signingTime))
		{
			this._lazySigningTime = new DateTime?(signingTime);
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.Pkcs9SigningTime.#ctor(System.Byte[])" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9SigningTime" />, используя указанный массив байтовых значений в качестве закодированных даты и времени подписи содержимого сообщения CMS/PKCS 7.</summary>
		/// <param name="encodedSigningTime">Массив байтовых значений, который определяет закодированное значение даты и времени подписи сообщения CMS/PKCS 7.</param>
		// Token: 0x0600041A RID: 1050 RVA: 0x00012C37 File Offset: 0x00010E37
		public Pkcs9SigningTime(byte[] encodedSigningTime) : base("1.2.840.113549.1.9.5", encodedSigningTime)
		{
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.Pkcs9SigningTime.SigningTime" /> возвращает структуру <see cref="T:System.DateTime" />, представляющую дату и время подписания сообщения.</summary>
		/// <returns>Структура <see cref="T:System.DateTime" />, содержащая дату и время подписания документа.</returns>
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00012C45 File Offset: 0x00010E45
		public DateTime SigningTime
		{
			get
			{
				if (this._lazySigningTime == null)
				{
					this._lazySigningTime = new DateTime?(Pkcs9SigningTime.Decode(base.RawData));
					Interlocked.MemoryBarrier();
				}
				return this._lazySigningTime.Value;
			}
		}

		/// <summary>Копирует информацию из объекта <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</summary>
		/// <param name="asnEncodedData">Объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />, из которого копируется информация.</param>
		// Token: 0x0600041C RID: 1052 RVA: 0x00012C7A File Offset: 0x00010E7A
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			base.CopyFrom(asnEncodedData);
			this._lazySigningTime = null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00012C90 File Offset: 0x00010E90
		private static DateTime Decode(byte[] rawData)
		{
			if (rawData == null)
			{
				return default(DateTime);
			}
			return PkcsPal.Instance.DecodeUtcTime(rawData);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00012CB5 File Offset: 0x00010EB5
		private static byte[] Encode(DateTime signingTime)
		{
			return PkcsPal.Instance.EncodeUtcTime(signingTime);
		}

		// Token: 0x04000296 RID: 662
		private DateTime? _lazySigningTime;
	}
}
