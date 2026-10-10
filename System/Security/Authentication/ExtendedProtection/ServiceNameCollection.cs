using System;
using System.Collections;
using System.Globalization;

namespace System.Security.Authentication.ExtendedProtection
{
	/// <summary>Класс <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" /> является доступной только для чтения коллекцией имен субъектов-служб.</summary>
	// Token: 0x020002A1 RID: 673
	[Serializable]
	public class ServiceNameCollection : ReadOnlyCollectionBase
	{
		/// <summary>Инициализирует новый, доступный только для чтения экземпляр класса <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" /> на основе существующего <see cref="T:System.Collections.ICollection" />.</summary>
		/// <param name="items">Экземпляр класса <see cref="T:System.Collections.ICollection" />, содержащий указанные значения имен служб, которые будут использоваться для инициализации класса.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="item" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="item" /> пуст.</exception>
		// Token: 0x06001520 RID: 5408 RVA: 0x00055778 File Offset: 0x00053978
		public ServiceNameCollection(ICollection items)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			foreach (object obj in items)
			{
				string serviceName = (string)obj;
				ServiceNameCollection.AddIfNew(base.InnerList, serviceName);
			}
		}

		/// <summary>Объединяет текущую коллекцию <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" /> с указанными значениями, чтобы создать новую коллекцию <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, содержащую объединение.</summary>
		/// <param name="serviceName">Строка, содержащая указанные значения имен служб, которые будут использоваться для инициализации класса.</param>
		/// <returns>Новый экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, который содержит объединение существующего экземпляра <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, объединенного с указанными значениями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serviceNames" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="serviceNames" /> пуст.</exception>
		// Token: 0x06001521 RID: 5409 RVA: 0x000557E8 File Offset: 0x000539E8
		public ServiceNameCollection Merge(string serviceName)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.AddRange(base.InnerList);
			ServiceNameCollection.AddIfNew(arrayList, serviceName);
			return new ServiceNameCollection(arrayList);
		}

		/// <summary>Объединяет текущую коллекцию <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" /> с указанными значениями, чтобы создать новую коллекцию <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, содержащую объединение.</summary>
		/// <param name="serviceNames">Экземпляр класса <see cref="T:System.Collections.IEnumerable" />, содержащий указанные значения имен служб, которые будут объединены.</param>
		/// <returns>Новый экземпляр <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, который содержит объединение существующего экземпляра <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, объединенного с указанными значениями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serviceNames" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="serviceNames" /> пуст.</exception>
		// Token: 0x06001522 RID: 5410 RVA: 0x00055808 File Offset: 0x00053A08
		public ServiceNameCollection Merge(IEnumerable serviceNames)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.AddRange(base.InnerList);
			foreach (object obj in serviceNames)
			{
				ServiceNameCollection.AddIfNew(arrayList, obj as string);
			}
			return new ServiceNameCollection(arrayList);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00055874 File Offset: 0x00053A74
		private static void AddIfNew(ArrayList newServiceNames, string serviceName)
		{
			if (string.IsNullOrEmpty(serviceName))
			{
				throw new ArgumentException(SR.GetString("A service name must not be null or empty."));
			}
			serviceName = ServiceNameCollection.NormalizeServiceName(serviceName);
			if (!ServiceNameCollection.Contains(serviceName, newServiceNames))
			{
				newServiceNames.Add(serviceName);
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000558A8 File Offset: 0x00053AA8
		internal static bool Contains(string searchServiceName, ICollection serviceNames)
		{
			using (IEnumerator enumerator = serviceNames.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (ServiceNameCollection.Match((string)enumerator.Current, searchServiceName))
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>Возвращает значение, указывающее, встречается ли указанная строка внутри этого экземпляра <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />.</summary>
		/// <param name="searchServiceName">Строка для поиска.</param>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.  
		///  Значение <see langword="true" />, если параметр <paramref name="searchServiceName" /> встречается в этом экземпляре <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001525 RID: 5413 RVA: 0x00055904 File Offset: 0x00053B04
		public bool Contains(string searchServiceName)
		{
			return ServiceNameCollection.Contains(ServiceNameCollection.NormalizeServiceName(searchServiceName), base.InnerList);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00055918 File Offset: 0x00053B18
		internal static string NormalizeServiceName(string inputServiceName)
		{
			if (string.IsNullOrWhiteSpace(inputServiceName))
			{
				return inputServiceName;
			}
			int num = inputServiceName.IndexOf('/');
			if (num < 0)
			{
				return inputServiceName;
			}
			string text = inputServiceName.Substring(0, num + 1);
			string text2 = inputServiceName.Substring(num + 1);
			if (string.IsNullOrWhiteSpace(text2))
			{
				return inputServiceName;
			}
			string text3 = text2;
			string text4 = string.Empty;
			string text5 = string.Empty;
			UriHostNameType uriHostNameType = Uri.CheckHostName(text2);
			if (uriHostNameType == UriHostNameType.Unknown)
			{
				string text6 = text2;
				int num2 = text2.IndexOf('/');
				if (num2 >= 0)
				{
					text6 = text2.Substring(0, num2);
					text5 = text2.Substring(num2);
					text3 = text6;
				}
				int num3 = text6.LastIndexOf(':');
				if (num3 >= 0)
				{
					text3 = text6.Substring(0, num3);
					text4 = text6.Substring(num3 + 1);
					ushort num4;
					if (!ushort.TryParse(text4, NumberStyles.Integer, CultureInfo.InvariantCulture, out num4))
					{
						return inputServiceName;
					}
					text4 = text6.Substring(num3);
				}
				uriHostNameType = Uri.CheckHostName(text3);
			}
			if (uriHostNameType != UriHostNameType.Dns)
			{
				return inputServiceName;
			}
			Uri uri;
			if (!Uri.TryCreate(Uri.UriSchemeHttp + Uri.SchemeDelimiter + text3, UriKind.Absolute, out uri))
			{
				return inputServiceName;
			}
			string components = uri.GetComponents(UriComponents.NormalizedHost, UriFormat.SafeUnescaped);
			string text7 = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}", new object[]
			{
				text,
				components,
				text4,
				text5
			});
			if (ServiceNameCollection.Match(inputServiceName, text7))
			{
				return inputServiceName;
			}
			return text7;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00055A5B File Offset: 0x00053C5B
		internal static bool Match(string serviceName1, string serviceName2)
		{
			return string.Compare(serviceName1, serviceName2, StringComparison.OrdinalIgnoreCase) == 0;
		}
	}
}
