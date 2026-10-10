using System;

namespace System.Net.Sockets
{
	/// <summary>Содержит <see cref="T:System.Net.IPAddress" /> значения, используемые для подключения и отключения групп многоадресной рассылки.</summary>
	// Token: 0x020007AA RID: 1962
	public class MulticastOption
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.MulticastOption" /> с заданным IP-адресом группы многоадресной рассылки и локальным IP-адресом, связанным с сетевым интерфейсом.</summary>
		/// <param name="group">Группа <see cref="T:System.Net.IPAddress" />.</param>
		/// <param name="mcint">Локальный адрес <see cref="T:System.Net.IPAddress" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="group" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="mcint" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003EAB RID: 16043 RVA: 0x000D67AC File Offset: 0x000D49AC
		public MulticastOption(IPAddress group, IPAddress mcint)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			if (mcint == null)
			{
				throw new ArgumentNullException("mcint");
			}
			this.Group = group;
			this.LocalAddress = mcint;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.MulticastOption" /> с указанным IP-адресом группы многоадресной рассылки и индексом интерфейса.</summary>
		/// <param name="group">Объект <see cref="T:System.Net.IPAddress" /> группы многоадресной рассылки.</param>
		/// <param name="interfaceIndex">Индекс интерфейса, используемый для отправки и получения пакетов многоадресной рассылки.</param>
		// Token: 0x06003EAC RID: 16044 RVA: 0x000D67DE File Offset: 0x000D49DE
		public MulticastOption(IPAddress group, int interfaceIndex)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			if (interfaceIndex < 0 || interfaceIndex > 16777215)
			{
				throw new ArgumentOutOfRangeException("interfaceIndex");
			}
			this.Group = group;
			this.ifIndex = interfaceIndex;
		}

		/// <summary>Инициализирует новую версию класса <see cref="T:System.Net.Sockets.MulticastOption" /> для указанной группы многоадресной IP-рассылки.</summary>
		/// <param name="group">Объект <see cref="T:System.Net.IPAddress" /> группы многоадресной рассылки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="group" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003EAD RID: 16045 RVA: 0x000D6819 File Offset: 0x000D4A19
		public MulticastOption(IPAddress group)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			this.Group = group;
			this.LocalAddress = IPAddress.Any;
		}

		/// <summary>Возвращает или задает IP-адрес группы многоадресной рассылки.</summary>
		/// <returns>Объект <see cref="T:System.Net.IPAddress" />, содержащий интернет-адрес группы многоадресной рассылки.</returns>
		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x000D6841 File Offset: 0x000D4A41
		// (set) Token: 0x06003EAF RID: 16047 RVA: 0x000D6849 File Offset: 0x000D4A49
		public IPAddress Group
		{
			get
			{
				return this.group;
			}
			set
			{
				this.group = value;
			}
		}

		/// <summary>Возвращает или задает локальный адрес, связанный с группой многоадресной рассылки.</summary>
		/// <returns>Объект <see cref="T:System.Net.IPAddress" />, содержащий локальный адрес, связанный с группой многоадресной рассылки.</returns>
		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x000D6852 File Offset: 0x000D4A52
		// (set) Token: 0x06003EB1 RID: 16049 RVA: 0x000D685A File Offset: 0x000D4A5A
		public IPAddress LocalAddress
		{
			get
			{
				return this.localAddress;
			}
			set
			{
				this.ifIndex = 0;
				this.localAddress = value;
			}
		}

		/// <summary>Возвращает или задает индекс интерфейса, используемый для отправки и получения пакетов многоадресной рассылки.</summary>
		/// <returns>Целое число, представляющее индекс элемента массива <see cref="T:System.Net.NetworkInformation.NetworkInterface" />.</returns>
		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x000D686A File Offset: 0x000D4A6A
		// (set) Token: 0x06003EB3 RID: 16051 RVA: 0x000D6872 File Offset: 0x000D4A72
		public int InterfaceIndex
		{
			get
			{
				return this.ifIndex;
			}
			set
			{
				if (value < 0 || value > 16777215)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.localAddress = null;
				this.ifIndex = value;
			}
		}

		// Token: 0x040024DD RID: 9437
		private IPAddress group;

		// Token: 0x040024DE RID: 9438
		private IPAddress localAddress;

		// Token: 0x040024DF RID: 9439
		private int ifIndex;
	}
}
