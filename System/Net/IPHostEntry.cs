using System;

namespace System.Net
{
	/// <summary>Предоставляет класс контейнеров для сведений об адресе веб-узла.</summary>
	// Token: 0x020005D8 RID: 1496
	public class IPHostEntry
	{
		/// <summary>Возвращает или задает DNS-имя узла.</summary>
		/// <returns>Строка, содержащая главное имя узла сервера.</returns>
		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x000A642E File Offset: 0x000A462E
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x000A6436 File Offset: 0x000A4636
		public string HostName
		{
			get
			{
				return this.hostName;
			}
			set
			{
				this.hostName = value;
			}
		}

		/// <summary>Возвращает или задает список псевдонимов, связанных с узелом.</summary>
		/// <returns>Массив строк, содержащих DNS-имена, которые разрешаются в IP-адреса, содержащиеся в свойства распределяются по IP-адресам в свойстве <see cref="P:System.Net.IPHostEntry.AddressList" />.</returns>
		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x000A643F File Offset: 0x000A463F
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x000A6447 File Offset: 0x000A4647
		public string[] Aliases
		{
			get
			{
				return this.aliases;
			}
			set
			{
				this.aliases = value;
			}
		}

		/// <summary>Возвращает или задает список IP-адресов, связанных с узелом.</summary>
		/// <returns>Массив свойств типа <see cref="T:System.Net.IPAddress" />, содержащий IP-адреса, которые разрешаются в имена узелов, содержащихся в свойстве <see cref="P:System.Net.IPHostEntry.Aliases" />.</returns>
		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x000A6450 File Offset: 0x000A4650
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x000A6458 File Offset: 0x000A4658
		public IPAddress[] AddressList
		{
			get
			{
				return this.addressList;
			}
			set
			{
				this.addressList = value;
			}
		}

		// Token: 0x04001AF9 RID: 6905
		private string hostName;

		// Token: 0x04001AFA RID: 6906
		private string[] aliases;

		// Token: 0x04001AFB RID: 6907
		private IPAddress[] addressList;

		// Token: 0x04001AFC RID: 6908
		internal bool isTrustedHost = true;
	}
}
