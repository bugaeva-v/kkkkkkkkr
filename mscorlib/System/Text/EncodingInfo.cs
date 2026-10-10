using System;
using Unity;

namespace System.Text
{
	/// <summary>Предоставляет базовые сведения о кодировке.</summary>
	// Token: 0x020003A6 RID: 934
	[Serializable]
	public sealed class EncodingInfo
	{
		// Token: 0x06002648 RID: 9800 RVA: 0x00087B38 File Offset: 0x00085D38
		internal EncodingInfo(int codePage, string name, string displayName)
		{
			this.iCodePage = codePage;
			this.strEncodingName = name;
			this.strDisplayName = displayName;
		}

		/// <summary>Получает идентификатор кодовой страницы кодировки.</summary>
		/// <returns>Идентификатор кодовой страницы кодировки.</returns>
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x00087B55 File Offset: 0x00085D55
		public int CodePage
		{
			get
			{
				return this.iCodePage;
			}
		}

		/// <summary>Получает имя, зарегистрированное в центральном координаторе по присвоению уникальных параметров протоколов Internet (IANA) для данной кодировки.</summary>
		/// <returns>Имя IANA для данной кодировки. Дополнительные сведения о протоколах IANA см. на веб-узле по адресу www.iana.org.</returns>
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x00087B5D File Offset: 0x00085D5D
		public string Name
		{
			get
			{
				return this.strEncodingName;
			}
		}

		/// <summary>Получает удобное для восприятия описание кодировки.</summary>
		/// <returns>Удобное для восприятия описание кодировки.</returns>
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x00087B65 File Offset: 0x00085D65
		public string DisplayName
		{
			get
			{
				return this.strDisplayName;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Text.Encoding" />, соответствующий текущему объекту <see cref="T:System.Text.EncodingInfo" />.</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoding" />, соответствующий текущему объекту <see cref="T:System.Text.EncodingInfo" />.</returns>
		// Token: 0x0600264C RID: 9804 RVA: 0x00087B6D File Offset: 0x00085D6D
		public Encoding GetEncoding()
		{
			return Encoding.GetEncoding(this.iCodePage);
		}

		/// <summary>Возвращает значение, позволяющее определить, равен ли указанный объект текущему объекту <see cref="T:System.Text.EncodingInfo" />.</summary>
		/// <param name="value">Объект, который требуется сравнить с текущим объектом <see cref="T:System.Text.EncodingInfo" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> является объектом <see cref="T:System.Text.EncodingInfo" /> и равен текущему объекту <see cref="T:System.Text.EncodingInfo" />. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600264D RID: 9805 RVA: 0x00087B7C File Offset: 0x00085D7C
		public override bool Equals(object value)
		{
			EncodingInfo encodingInfo = value as EncodingInfo;
			return encodingInfo != null && this.CodePage == encodingInfo.CodePage;
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Text.EncodingInfo" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600264E RID: 9806 RVA: 0x00087BA3 File Offset: 0x00085DA3
		public override int GetHashCode()
		{
			return this.CodePage;
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000173AD File Offset: 0x000155AD
		internal EncodingInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001DC4 RID: 7620
		private int iCodePage;

		// Token: 0x04001DC5 RID: 7621
		private string strEncodingName;

		// Token: 0x04001DC6 RID: 7622
		private string strDisplayName;
	}
}
