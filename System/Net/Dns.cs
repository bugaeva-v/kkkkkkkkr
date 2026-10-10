using System;
using System.Collections;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Mono.Net.Dns;

namespace System.Net
{
	/// <summary>Предоставляет простые функциональные возможности разрешения доменных имен.</summary>
	// Token: 0x02000677 RID: 1655
	public static class Dns
	{
		// Token: 0x06003416 RID: 13334 RVA: 0x000B5C04 File Offset: 0x000B3E04
		static Dns()
		{
			if (Environment.GetEnvironmentVariable("MONO_DNS") != null)
			{
				Dns.resolver = new SimpleResolver();
				Dns.use_mono_dns = true;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x000B5C22 File Offset: 0x000B3E22
		internal static bool UseMonoDns
		{
			get
			{
				return Dns.use_mono_dns;
			}
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x000B5C2C File Offset: 0x000B3E2C
		private static void OnCompleted(object sender, SimpleResolverEventArgs e)
		{
			DnsAsyncResult dnsAsyncResult = (DnsAsyncResult)e.UserToken;
			IPHostEntry hostEntry = e.HostEntry;
			if (hostEntry == null || e.ResolverError != ResolverError.NoError)
			{
				dnsAsyncResult.SetCompleted(false, new Exception("Error: " + e.ResolverError.ToString()));
				return;
			}
			dnsAsyncResult.SetCompleted(false, hostEntry);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x000B5C8C File Offset: 0x000B3E8C
		private static IAsyncResult BeginAsyncCallAddresses(string host, AsyncCallback callback, object state)
		{
			SimpleResolverEventArgs simpleResolverEventArgs = new SimpleResolverEventArgs();
			simpleResolverEventArgs.Completed += Dns.OnCompleted;
			simpleResolverEventArgs.HostName = host;
			DnsAsyncResult dnsAsyncResult = new DnsAsyncResult(callback, state);
			simpleResolverEventArgs.UserToken = dnsAsyncResult;
			if (!Dns.resolver.GetHostAddressesAsync(simpleResolverEventArgs))
			{
				dnsAsyncResult.SetCompleted(true, simpleResolverEventArgs.HostEntry);
			}
			return dnsAsyncResult;
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000B5CE4 File Offset: 0x000B3EE4
		private static IAsyncResult BeginAsyncCall(string host, AsyncCallback callback, object state)
		{
			SimpleResolverEventArgs simpleResolverEventArgs = new SimpleResolverEventArgs();
			simpleResolverEventArgs.Completed += Dns.OnCompleted;
			simpleResolverEventArgs.HostName = host;
			DnsAsyncResult dnsAsyncResult = new DnsAsyncResult(callback, state);
			simpleResolverEventArgs.UserToken = dnsAsyncResult;
			if (!Dns.resolver.GetHostEntryAsync(simpleResolverEventArgs))
			{
				dnsAsyncResult.SetCompleted(true, simpleResolverEventArgs.HostEntry);
			}
			return dnsAsyncResult;
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000B5D3C File Offset: 0x000B3F3C
		private static IPHostEntry EndAsyncCall(DnsAsyncResult ares)
		{
			if (ares == null)
			{
				throw new ArgumentException("Invalid asyncResult");
			}
			if (!ares.IsCompleted)
			{
				ares.AsyncWaitHandle.WaitOne();
			}
			if (ares.Exception != null)
			{
				throw ares.Exception;
			}
			IPHostEntry hostEntry = ares.HostEntry;
			if (hostEntry == null || hostEntry.AddressList == null || hostEntry.AddressList.Length == 0)
			{
				Dns.Error_11001(hostEntry.HostName);
			}
			return hostEntry;
		}

		/// <summary>Начинает асинхронный запрос сведений <see cref="T:System.Net.IPHostEntry" /> об указанном DNS-имени узла.</summary>
		/// <param name="hostName">DNS-имя узла.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="stateObject">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Экземпляр <see cref="T:System.IAsyncResult" />, который ссылается на асинхронный запрос.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="hostName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При выполнении запроса DNS произошла ошибка.</exception>
		// Token: 0x0600341C RID: 13340 RVA: 0x000B5DA1 File Offset: 0x000B3FA1
		[Obsolete("Use BeginGetHostEntry instead")]
		public static IAsyncResult BeginGetHostByName(string hostName, AsyncCallback requestCallback, object stateObject)
		{
			if (hostName == null)
			{
				throw new ArgumentNullException("hostName");
			}
			if (Dns.use_mono_dns)
			{
				return Dns.BeginAsyncCall(hostName, requestCallback, stateObject);
			}
			return new Dns.GetHostByNameCallback(Dns.GetHostByName).BeginInvoke(hostName, requestCallback, stateObject);
		}

		/// <summary>Начинает асинхронный запрос для разрешения DNS-имени узла или IP-адреса в экземпляр <see cref="T:System.Net.IPAddress" />.</summary>
		/// <param name="hostName">DNS-имя узла.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="stateObject">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Экземпляр <see cref="T:System.IAsyncResult" />, который ссылается на асинхронный запрос.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="hostName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Вызывающий код не имеет разрешения на доступ к сведениям DNS.</exception>
		// Token: 0x0600341D RID: 13341 RVA: 0x000B5DD5 File Offset: 0x000B3FD5
		[Obsolete("Use BeginGetHostEntry instead")]
		public static IAsyncResult BeginResolve(string hostName, AsyncCallback requestCallback, object stateObject)
		{
			if (hostName == null)
			{
				throw new ArgumentNullException("hostName");
			}
			if (Dns.use_mono_dns)
			{
				return Dns.BeginAsyncCall(hostName, requestCallback, stateObject);
			}
			return new Dns.ResolveCallback(Dns.Resolve).BeginInvoke(hostName, requestCallback, stateObject);
		}

		/// <summary>Асинхронно возвращает IP-адреса для указанного узла.</summary>
		/// <param name="hostNameOrAddress">Разрешаемое имя узла или IP-адрес.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Экземпляр <see cref="T:System.IAsyncResult" />, который ссылается на асинхронный запрос.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="hostNameOrAddress" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="hostNameOrAddress" /> превышает 255 символов.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="hostNameOrAddress" /> возникает ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hostNameOrAddress" /> является недопустимым IP-адресом.</exception>
		// Token: 0x0600341E RID: 13342 RVA: 0x000B5E0C File Offset: 0x000B400C
		public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state)
		{
			if (hostNameOrAddress == null)
			{
				throw new ArgumentNullException("hostName");
			}
			if (hostNameOrAddress == "0.0.0.0" || hostNameOrAddress == "::0")
			{
				throw new ArgumentException("Addresses 0.0.0.0 (IPv4) and ::0 (IPv6) are unspecified addresses. You cannot use them as target address.", "hostNameOrAddress");
			}
			if (Dns.use_mono_dns)
			{
				return Dns.BeginAsyncCallAddresses(hostNameOrAddress, requestCallback, state);
			}
			return new Dns.GetHostAddressesCallback(Dns.GetHostAddresses).BeginInvoke(hostNameOrAddress, requestCallback, state);
		}

		/// <summary>Асинхронно разрешает имя узла или IP-адрес экземпляра <see cref="T:System.Net.IPHostEntry" />.</summary>
		/// <param name="hostNameOrAddress">Разрешаемое имя узла или IP-адрес.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="stateObject">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Экземпляр <see cref="T:System.IAsyncResult" />, который ссылается на асинхронный запрос.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="hostNameOrAddress" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="hostNameOrAddress" /> превышает 255 символов.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="hostNameOrAddress" /> возникает ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hostNameOrAddress" /> является недопустимым IP-адресом.</exception>
		// Token: 0x0600341F RID: 13343 RVA: 0x000B5E78 File Offset: 0x000B4078
		public static IAsyncResult BeginGetHostEntry(string hostNameOrAddress, AsyncCallback requestCallback, object stateObject)
		{
			if (hostNameOrAddress == null)
			{
				throw new ArgumentNullException("hostName");
			}
			if (hostNameOrAddress == "0.0.0.0" || hostNameOrAddress == "::0")
			{
				throw new ArgumentException("Addresses 0.0.0.0 (IPv4) and ::0 (IPv6) are unspecified addresses. You cannot use them as target address.", "hostNameOrAddress");
			}
			if (Dns.use_mono_dns)
			{
				return Dns.BeginAsyncCall(hostNameOrAddress, requestCallback, stateObject);
			}
			return new Dns.GetHostEntryNameCallback(Dns.GetHostEntry).BeginInvoke(hostNameOrAddress, requestCallback, stateObject);
		}

		/// <summary>Асинхронно разрешает IP-адрес в экземпляр <see cref="T:System.Net.IPHostEntry" />.</summary>
		/// <param name="address">IP-адрес, который следует разрешить.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="stateObject">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Экземпляр <see cref="T:System.IAsyncResult" />, который ссылается на асинхронный запрос.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="address" /> возникает ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> является недопустимым IP-адресом.</exception>
		// Token: 0x06003420 RID: 13344 RVA: 0x000B5EE1 File Offset: 0x000B40E1
		public static IAsyncResult BeginGetHostEntry(IPAddress address, AsyncCallback requestCallback, object stateObject)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (Dns.use_mono_dns)
			{
				return Dns.BeginAsyncCall(address.ToString(), requestCallback, stateObject);
			}
			return new Dns.GetHostEntryIPCallback(Dns.GetHostEntry).BeginInvoke(address, requestCallback, stateObject);
		}

		/// <summary>Завершает асинхронный запрос сведений DNS.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="M:System.Net.Dns.BeginGetHostByName(System.String,System.AsyncCallback,System.Object)" />.</param>
		/// <returns>Объект <see cref="T:System.Net.IPHostEntry" />, содержащий сведения DNS об узле.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		// Token: 0x06003421 RID: 13345 RVA: 0x000B5F1A File Offset: 0x000B411A
		[Obsolete("Use EndGetHostEntry instead")]
		public static IPHostEntry EndGetHostByName(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (Dns.use_mono_dns)
			{
				return Dns.EndAsyncCall(asyncResult as DnsAsyncResult);
			}
			return ((Dns.GetHostByNameCallback)((AsyncResult)asyncResult).AsyncDelegate).EndInvoke(asyncResult);
		}

		/// <summary>Завершает асинхронный запрос сведений DNS.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="M:System.Net.Dns.BeginResolve(System.String,System.AsyncCallback,System.Object)" />.</param>
		/// <returns>Объект <see cref="T:System.Net.IPHostEntry" />, содержащий сведения DNS об узле.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		// Token: 0x06003422 RID: 13346 RVA: 0x000B5F53 File Offset: 0x000B4153
		[Obsolete("Use EndGetHostEntry instead")]
		public static IPHostEntry EndResolve(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (Dns.use_mono_dns)
			{
				return Dns.EndAsyncCall(asyncResult as DnsAsyncResult);
			}
			return ((Dns.ResolveCallback)((AsyncResult)asyncResult).AsyncDelegate).EndInvoke(asyncResult);
		}

		/// <summary>Завершает асинхронный запрос сведений DNS.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="M:System.Net.Dns.BeginGetHostAddresses(System.String,System.AsyncCallback,System.Object)" />.</param>
		/// <returns>Массив типа <see cref="T:System.Net.IPAddress" />, в котором содержатся IP-адреса для узла, указанного в параметре <paramref name="hostNameOrAddress" /> объекта <see cref="M:System.Net.Dns.BeginGetHostAddresses(System.String,System.AsyncCallback,System.Object)" />.</returns>
		// Token: 0x06003423 RID: 13347 RVA: 0x000B5F8C File Offset: 0x000B418C
		public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!Dns.use_mono_dns)
			{
				return ((Dns.GetHostAddressesCallback)((AsyncResult)asyncResult).AsyncDelegate).EndInvoke(asyncResult);
			}
			IPHostEntry iphostEntry = Dns.EndAsyncCall(asyncResult as DnsAsyncResult);
			if (iphostEntry == null)
			{
				return null;
			}
			return iphostEntry.AddressList;
		}

		/// <summary>Завершает асинхронный запрос сведений DNS.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="Overload:System.Net.Dns.BeginGetHostEntry" />.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.IPHostEntry" />, содержащий сведения об адресе, относящиеся к узлу.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		// Token: 0x06003424 RID: 13348 RVA: 0x000B5FDC File Offset: 0x000B41DC
		public static IPHostEntry EndGetHostEntry(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (Dns.use_mono_dns)
			{
				return Dns.EndAsyncCall(asyncResult as DnsAsyncResult);
			}
			AsyncResult asyncResult2 = (AsyncResult)asyncResult;
			if (asyncResult2.AsyncDelegate is Dns.GetHostEntryIPCallback)
			{
				return ((Dns.GetHostEntryIPCallback)asyncResult2.AsyncDelegate).EndInvoke(asyncResult);
			}
			return ((Dns.GetHostEntryNameCallback)asyncResult2.AsyncDelegate).EndInvoke(asyncResult);
		}

		// Token: 0x06003425 RID: 13349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint);

		// Token: 0x06003426 RID: 13350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint);

		// Token: 0x06003427 RID: 13351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetHostName_icall(out string h_name);

		// Token: 0x06003428 RID: 13352 RVA: 0x000B6041 File Offset: 0x000B4241
		private static void Error_11001(string hostName)
		{
			throw new SocketException(11001, string.Format("Could not resolve host '{0}'", hostName));
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000B6058 File Offset: 0x000B4258
		private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist)
		{
			IPHostEntry iphostEntry = new IPHostEntry();
			ArrayList arrayList = new ArrayList();
			iphostEntry.HostName = h_name;
			iphostEntry.Aliases = h_aliases;
			for (int i = 0; i < h_addrlist.Length; i++)
			{
				try
				{
					IPAddress ipaddress = IPAddress.Parse(h_addrlist[i]);
					if ((Socket.OSSupportsIPv6 && ipaddress.AddressFamily == AddressFamily.InterNetworkV6) || (Socket.OSSupportsIPv4 && ipaddress.AddressFamily == AddressFamily.InterNetwork))
					{
						arrayList.Add(ipaddress);
					}
				}
				catch (ArgumentNullException)
				{
				}
			}
			if (arrayList.Count == 0)
			{
				Dns.Error_11001(originalHostName);
			}
			iphostEntry.AddressList = (arrayList.ToArray(typeof(IPAddress)) as IPAddress[]);
			return iphostEntry;
		}

		/// <summary>Создает экземпляр <see cref="T:System.Net.IPHostEntry" /> из указанного объекта <see cref="T:System.Net.IPAddress" />.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.IPAddress" />.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.IPHostEntry" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="address" /> возникает ошибка.</exception>
		// Token: 0x0600342A RID: 13354 RVA: 0x000B6100 File Offset: 0x000B4300
		[Obsolete("Use GetHostEntry instead")]
		public static IPHostEntry GetHostByAddress(IPAddress address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return Dns.GetHostByAddressFromString(address.ToString(), false);
		}

		/// <summary>Создает экземпляр <see cref="T:System.Net.IPHostEntry" /> из IP-адреса.</summary>
		/// <param name="address">IP-адрес.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.IPHostEntry" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="address" /> возникает ошибка.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="address" /> не является допустимым IP-адресом.</exception>
		// Token: 0x0600342B RID: 13355 RVA: 0x000B611C File Offset: 0x000B431C
		[Obsolete("Use GetHostEntry instead")]
		public static IPHostEntry GetHostByAddress(string address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return Dns.GetHostByAddressFromString(address, true);
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000B6134 File Offset: 0x000B4334
		private static IPHostEntry GetHostByAddressFromString(string address, bool parse)
		{
			if (address.Equals("0.0.0.0"))
			{
				address = "127.0.0.1";
				parse = false;
			}
			if (parse)
			{
				IPAddress.Parse(address);
			}
			string h_name;
			string[] h_aliases;
			string[] h_addrlist;
			if (!Dns.GetHostByAddr_icall(address, out h_name, out h_aliases, out h_addrlist, Socket.FamilyHint))
			{
				Dns.Error_11001(address);
			}
			return Dns.hostent_to_IPHostEntry(address, h_name, h_aliases, h_addrlist);
		}

		/// <summary>Разрешает имя узла или IP-адрес в экземпляр <see cref="T:System.Net.IPHostEntry" />.</summary>
		/// <param name="hostNameOrAddress">Разрешаемое имя узла или IP-адрес.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.IPHostEntry" />, содержащий сведения об адресе, относящиеся к узлу, указанному в параметре <paramref name="hostNameOrAddress" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hostNameOrAddress" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина параметра <paramref name="hostNameOrAddress" /> превышает 255 символов.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При попытке разрешения параметра <paramref name="hostNameOrAddress" /> произошла ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="hostNameOrAddress" /> является недопустимым IP-адресом.</exception>
		// Token: 0x0600342D RID: 13357 RVA: 0x000B6184 File Offset: 0x000B4384
		public static IPHostEntry GetHostEntry(string hostNameOrAddress)
		{
			if (hostNameOrAddress == null)
			{
				throw new ArgumentNullException("hostNameOrAddress");
			}
			if (hostNameOrAddress == "0.0.0.0" || hostNameOrAddress == "::0")
			{
				throw new ArgumentException("Addresses 0.0.0.0 (IPv4) and ::0 (IPv6) are unspecified addresses. You cannot use them as target address.", "hostNameOrAddress");
			}
			IPAddress address;
			if (hostNameOrAddress.Length > 0 && IPAddress.TryParse(hostNameOrAddress, out address))
			{
				return Dns.GetHostEntry(address);
			}
			return Dns.GetHostByName(hostNameOrAddress);
		}

		/// <summary>Разрешает IP-адрес в экземпляр <see cref="T:System.Net.IPHostEntry" />.</summary>
		/// <param name="address">IP-адрес.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.IPHostEntry" />, содержащий сведения об адресе, относящиеся к узлу, указанному в параметре <paramref name="address" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="address" /> возникает ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> является недопустимым IP-адресом.</exception>
		// Token: 0x0600342E RID: 13358 RVA: 0x000B6100 File Offset: 0x000B4300
		public static IPHostEntry GetHostEntry(IPAddress address)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			return Dns.GetHostByAddressFromString(address.ToString(), false);
		}

		/// <summary>Возвращает IP-адреса для указанного узла.</summary>
		/// <param name="hostNameOrAddress">Разрешаемое имя узла или IP-адрес.</param>
		/// <returns>Массив типа <see cref="T:System.Net.IPAddress" />, в котором содержатся IP-адреса для узла, указанного в параметре <paramref name="hostNameOrAddress" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="hostNameOrAddress" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="hostNameOrAddress" /> превышает 255 символов.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="hostNameOrAddress" /> возникает ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hostNameOrAddress" /> является недопустимым IP-адресом.</exception>
		// Token: 0x0600342F RID: 13359 RVA: 0x000B61EC File Offset: 0x000B43EC
		public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
		{
			if (hostNameOrAddress == null)
			{
				throw new ArgumentNullException("hostNameOrAddress");
			}
			if (hostNameOrAddress == "0.0.0.0" || hostNameOrAddress == "::0")
			{
				throw new ArgumentException("Addresses 0.0.0.0 (IPv4) and ::0 (IPv6) are unspecified addresses. You cannot use them as target address.", "hostNameOrAddress");
			}
			IPAddress ipaddress;
			if (hostNameOrAddress.Length > 0 && IPAddress.TryParse(hostNameOrAddress, out ipaddress))
			{
				return new IPAddress[]
				{
					ipaddress
				};
			}
			return Dns.GetHostEntry(hostNameOrAddress).AddressList;
		}

		/// <summary>Возвращает сведения DNS для указанного DNS-имени узла.</summary>
		/// <param name="hostName">DNS-имя узла.</param>
		/// <returns>Объект <see cref="T:System.Net.IPHostEntry" />, содержащий сведения об узле для адреса, указанного в <paramref name="hostName" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="hostName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="hostName" /> превышает 255 символов.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="hostName" /> возникает ошибка.</exception>
		// Token: 0x06003430 RID: 13360 RVA: 0x000B625C File Offset: 0x000B445C
		[Obsolete("Use GetHostEntry instead")]
		public static IPHostEntry GetHostByName(string hostName)
		{
			if (hostName == null)
			{
				throw new ArgumentNullException("hostName");
			}
			string h_name;
			string[] h_aliases;
			string[] h_addrlist;
			if (!Dns.GetHostByName_icall(hostName, out h_name, out h_aliases, out h_addrlist, Socket.FamilyHint))
			{
				Dns.Error_11001(hostName);
			}
			return Dns.hostent_to_IPHostEntry(hostName, h_name, h_aliases, h_addrlist);
		}

		/// <summary>Возвращает имя узла локального компьютера.</summary>
		/// <returns>Строка, содержащая DNS-имя узла локального компьютера.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">При преобразовании имени локального узла возникает ошибка.</exception>
		// Token: 0x06003431 RID: 13361 RVA: 0x000B629C File Offset: 0x000B449C
		public static string GetHostName()
		{
			string text;
			if (!Dns.GetHostName_icall(out text))
			{
				Dns.Error_11001(text);
			}
			return text;
		}

		/// <summary>Разрешает DNS-имя узла или IP-адрес в экземпляр <see cref="T:System.Net.IPHostEntry" />.</summary>
		/// <param name="hostName">DNS-имя узла или IP-адрес.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.IPHostEntry" />, содержащий сведения об адресе, относящиеся к узлу, указанному в параметре <paramref name="hostName" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="hostName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="hostName" /> превышает 255 символов.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="hostName" /> возникает ошибка.</exception>
		// Token: 0x06003432 RID: 13362 RVA: 0x000B62BC File Offset: 0x000B44BC
		[Obsolete("Use GetHostEntry instead")]
		public static IPHostEntry Resolve(string hostName)
		{
			if (hostName == null)
			{
				throw new ArgumentNullException("hostName");
			}
			IPHostEntry iphostEntry = null;
			try
			{
				iphostEntry = Dns.GetHostByAddress(hostName);
			}
			catch
			{
			}
			if (iphostEntry == null)
			{
				iphostEntry = Dns.GetHostByName(hostName);
			}
			return iphostEntry;
		}

		/// <summary>Возвращает IP-адреса для указанного узла как асинхронная операция.</summary>
		/// <param name="hostNameOrAddress">Разрешаемое имя узла или IP-адрес.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию. Свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> объекта задачи возвращает Массив типа <see cref="T:System.Net.IPAddress" />, в котором содержатся IP-адреса для узла, указанного в параметре <paramref name="hostNameOrAddress" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="hostNameOrAddress" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="hostNameOrAddress" /> превышает 255 символов.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="hostNameOrAddress" /> возникает ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hostNameOrAddress" /> является недопустимым IP-адресом.</exception>
		// Token: 0x06003433 RID: 13363 RVA: 0x000B6300 File Offset: 0x000B4500
		public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress)
		{
			return Task<IPAddress[]>.Factory.FromAsync<string>(new Func<string, AsyncCallback, object, IAsyncResult>(Dns.BeginGetHostAddresses), new Func<IAsyncResult, IPAddress[]>(Dns.EndGetHostAddresses), hostNameOrAddress, null);
		}

		/// <summary>Разрешает IP-адрес экземпляра <see cref="T:System.Net.IPHostEntry" /> как асинхронная операция.</summary>
		/// <param name="address">IP-адрес.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию. Свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> в объекте задачи возвращает экземпляр <see cref="T:System.Net.IPHostEntry" />, содержащий информацию адреса об узле, указанного в <paramref name="address" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При разрешении <paramref name="address" /> возникает ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> является недопустимым IP-адресом.</exception>
		// Token: 0x06003434 RID: 13364 RVA: 0x000B6326 File Offset: 0x000B4526
		public static Task<IPHostEntry> GetHostEntryAsync(IPAddress address)
		{
			return Task<IPHostEntry>.Factory.FromAsync<IPAddress>(new Func<IPAddress, AsyncCallback, object, IAsyncResult>(Dns.BeginGetHostEntry), new Func<IAsyncResult, IPHostEntry>(Dns.EndGetHostEntry), address, null);
		}

		/// <summary>Разрешает имя узла или IP-адрес экземпляра <see cref="T:System.Net.IPHostEntry" /> как асинхронная операция.</summary>
		/// <param name="hostNameOrAddress">Разрешаемое имя узла или IP-адрес.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию. Свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> в объекте задачи возвращает экземпляр <see cref="T:System.Net.IPHostEntry" />, содержащий информацию адреса об узле, указанного в <paramref name="hostNameOrAddress" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hostNameOrAddress" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина параметра <paramref name="hostNameOrAddress" /> превышает 255 символов.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При попытке разрешения параметра <paramref name="hostNameOrAddress" /> произошла ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="hostNameOrAddress" /> является недопустимым IP-адресом.</exception>
		// Token: 0x06003435 RID: 13365 RVA: 0x000B634C File Offset: 0x000B454C
		public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress)
		{
			return Task<IPHostEntry>.Factory.FromAsync<string>(new Func<string, AsyncCallback, object, IAsyncResult>(Dns.BeginGetHostEntry), new Func<IAsyncResult, IPHostEntry>(Dns.EndGetHostEntry), hostNameOrAddress, null);
		}

		// Token: 0x04001E83 RID: 7811
		private static bool use_mono_dns;

		// Token: 0x04001E84 RID: 7812
		private static SimpleResolver resolver;

		// Token: 0x02000678 RID: 1656
		// (Invoke) Token: 0x06003437 RID: 13367
		private delegate IPHostEntry GetHostByNameCallback(string hostName);

		// Token: 0x02000679 RID: 1657
		// (Invoke) Token: 0x0600343B RID: 13371
		private delegate IPHostEntry ResolveCallback(string hostName);

		// Token: 0x0200067A RID: 1658
		// (Invoke) Token: 0x0600343F RID: 13375
		private delegate IPHostEntry GetHostEntryNameCallback(string hostName);

		// Token: 0x0200067B RID: 1659
		// (Invoke) Token: 0x06003443 RID: 13379
		private delegate IPHostEntry GetHostEntryIPCallback(IPAddress hostAddress);

		// Token: 0x0200067C RID: 1660
		// (Invoke) Token: 0x06003447 RID: 13383
		private delegate IPAddress[] GetHostAddressesCallback(string hostName);
	}
}
