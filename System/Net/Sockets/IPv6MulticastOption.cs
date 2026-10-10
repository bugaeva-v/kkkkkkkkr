using System;

namespace System.Net.Sockets
{
	/// <summary>Содержит значения параметров для присоединения к группе многоадресной рассылки IPv6.</summary>
	// Token: 0x020007AB RID: 1963
	public class IPv6MulticastOption
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.IPv6MulticastOption" /> с указанной IP-группой многоадресной рассылки и адресом локального интерфейса.</summary>
		/// <param name="group">Группа <see cref="T:System.Net.IPAddress" />.</param>
		/// <param name="ifindex">Адрес локального интерфейса.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="ifindex" /> меньше 0.  
		///
		/// или - 
		/// Значение параметра <paramref name="ifindex" /> больше 0x00000000FFFFFFFF.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="group" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003EB4 RID: 16052 RVA: 0x000D6899 File Offset: 0x000D4A99
		public IPv6MulticastOption(IPAddress group, long ifindex)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			if (ifindex < 0L || ifindex > (long)((ulong)-1))
			{
				throw new ArgumentOutOfRangeException("ifindex");
			}
			this.Group = group;
			this.InterfaceIndex = ifindex;
		}

		/// <summary>Инициализирует новую версию класса <see cref="T:System.Net.Sockets.IPv6MulticastOption" /> для указанной группы многоадресной IP-рассылки.</summary>
		/// <param name="group">Объект <see cref="T:System.Net.IPAddress" /> группы многоадресной рассылки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="group" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003EB5 RID: 16053 RVA: 0x000D68D2 File Offset: 0x000D4AD2
		public IPv6MulticastOption(IPAddress group)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			this.Group = group;
			this.InterfaceIndex = 0L;
		}

		/// <summary>Возвращает или задает IP-адрес группы многоадресной рассылки.</summary>
		/// <returns>Объект <see cref="T:System.Net.IPAddress" />, содержащий интернет-адрес группы многоадресной рассылки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="group" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x000D68F7 File Offset: 0x000D4AF7
		// (set) Token: 0x06003EB7 RID: 16055 RVA: 0x000D68FF File Offset: 0x000D4AFF
		public IPAddress Group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.m_Group = value;
			}
		}

		/// <summary>Получает или задает индекс интерфейса, связанный с группой многоадресной рассылки.</summary>
		/// <returns>Значение <see cref="T:System.UInt64" />, указывающее адрес интерфейса.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции задания, или меньше нуля, или больше 0x00000000FFFFFFFF.</exception>
		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x000D6916 File Offset: 0x000D4B16
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x000D691E File Offset: 0x000D4B1E
		public long InterfaceIndex
		{
			get
			{
				return this.m_Interface;
			}
			set
			{
				if (value < 0L || value > (long)((ulong)-1))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.m_Interface = value;
			}
		}

		// Token: 0x040024E0 RID: 9440
		private IPAddress m_Group;

		// Token: 0x040024E1 RID: 9441
		private long m_Interface;
	}
}
