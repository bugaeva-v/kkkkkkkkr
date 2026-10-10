using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace System.Net.Mail
{
	/// <summary>Хранит адреса электронной почты, которые связаны с сообщением электронной почты.</summary>
	// Token: 0x0200081E RID: 2078
	public class MailAddressCollection : Collection<MailAddress>
	{
		/// <summary>Добавляет список адресов электронной почты в коллекцию.</summary>
		/// <param name="addresses">Адреса электронной почты, добавляемые в коллекцию <see cref="T:System.Net.Mail.MailAddressCollection" />. Несколько адресов электронной почты необходимо разделять запятыми (",").</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="addresses" /> имеет значение null.</exception>
		/// <exception cref="T:System.ArgumentException">Параметром <paramref name="addresses" /> является пустая строка.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="addresses" /> содержит недопустимый или неподдерживаемый адрес электронной почты.</exception>
		// Token: 0x06004229 RID: 16937 RVA: 0x000E4A28 File Offset: 0x000E2C28
		public void Add(string addresses)
		{
			if (addresses == null)
			{
				throw new ArgumentNullException("addresses");
			}
			if (addresses == string.Empty)
			{
				throw new ArgumentException(SR.Format("The parameter '{0}' cannot be an empty string.", "addresses"), "addresses");
			}
			this.ParseValue(addresses);
		}

		/// <summary>Заменяет элемент по указанному индексу.</summary>
		/// <param name="index">Индекс заменяемого элемента адреса электронной почты.</param>
		/// <param name="item">Адрес электронной почты, который заменит элемент коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="item" /> имеет значение null.</exception>
		// Token: 0x0600422A RID: 16938 RVA: 0x000E4A66 File Offset: 0x000E2C66
		protected override void SetItem(int index, MailAddress item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
			base.SetItem(index, item);
		}

		/// <summary>Вставляет адрес электронной почты в коллекцию <see cref="T:System.Net.Mail.MailAddressCollection" /> в указанном месте.</summary>
		/// <param name="index">Место вставки адреса электронной почты, заданного параметром <paramref name="item" />.</param>
		/// <param name="item">Адрес электронной почты для вставки в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="item" /> имеет значение null.</exception>
		// Token: 0x0600422B RID: 16939 RVA: 0x000E4A7E File Offset: 0x000E2C7E
		protected override void InsertItem(int index, MailAddress item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
			base.InsertItem(index, item);
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x000E4A98 File Offset: 0x000E2C98
		internal void ParseValue(string addresses)
		{
			IList<MailAddress> list = MailAddressParser.ParseMultipleAddresses(addresses);
			for (int i = 0; i < list.Count; i++)
			{
				base.Add(list[i]);
			}
		}

		/// <summary>Возвращает строковое представление адресов электронной почты из данного объекта <see cref="T:System.Net.Mail.MailAddressCollection" />.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее адреса электронной почты из данной коллекции.</returns>
		// Token: 0x0600422D RID: 16941 RVA: 0x000E4ACC File Offset: 0x000E2CCC
		public override string ToString()
		{
			bool flag = true;
			StringBuilder stringBuilder = new StringBuilder();
			foreach (MailAddress mailAddress in this)
			{
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(mailAddress.ToString());
				flag = false;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x000E4B3C File Offset: 0x000E2D3C
		internal string Encode(int charsConsumed, bool allowUnicode)
		{
			string text = string.Empty;
			foreach (MailAddress mailAddress in this)
			{
				if (string.IsNullOrEmpty(text))
				{
					text = mailAddress.Encode(charsConsumed, allowUnicode);
				}
				else
				{
					text = text + ", " + mailAddress.Encode(1, allowUnicode);
				}
			}
			return text;
		}
	}
}
