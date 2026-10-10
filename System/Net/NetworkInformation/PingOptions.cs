using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Используется для управления передачей пакетов данных <see cref="T:System.Net.NetworkInformation.Ping" />.</summary>
	// Token: 0x020006FC RID: 1788
	public class PingOptions
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.PingOptions" /> и задает значения срока жизни и фрагментации.</summary>
		/// <param name="ttl">Значение типа <see cref="T:System.Int32" /> больше нуля, указывающее, сколько раз могут быть переадресованы пакеты данных <see cref="T:System.Net.NetworkInformation.Ping" />.</param>
		/// <param name="dontFragment">Значение <see langword="true" />, чтобы данные, отправляемые на удаленный узел, не фрагментировались; в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="ttl" /> меньше или равно нулю.</exception>
		// Token: 0x06003971 RID: 14705 RVA: 0x000C8AEC File Offset: 0x000C6CEC
		public PingOptions(int ttl, bool dontFragment)
		{
			if (ttl <= 0)
			{
				throw new ArgumentOutOfRangeException("ttl");
			}
			this.ttl = ttl;
			this.dontFragment = dontFragment;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.PingOptions" />.</summary>
		// Token: 0x06003972 RID: 14706 RVA: 0x000C8B1C File Offset: 0x000C6D1C
		public PingOptions()
		{
		}

		/// <summary>Получает или задает число узелов маршрутизации, которые могут переадресовывать пакет <see cref="T:System.Net.NetworkInformation.Ping" />, прежде чем он будет удален.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, указывающее, сколько раз могут быть переадресованы пакеты данных <see cref="T:System.Net.NetworkInformation.Ping" />. Значение по умолчанию — 128.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции задания, меньше или равно нулю.</exception>
		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x000C8B2F File Offset: 0x000C6D2F
		// (set) Token: 0x06003974 RID: 14708 RVA: 0x000C8B37 File Offset: 0x000C6D37
		public int Ttl
		{
			get
			{
				return this.ttl;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.ttl = value;
			}
		}

		/// <summary>Получает или задает значение типа <see cref="T:System.Boolean" />, которое управляет фрагментацией данных, отправляемых на удаленный узел.</summary>
		/// <returns>Значение <see langword="true" />, если данные нельзя отправлять несколькими пакетами; в противном случае — <see langword="false" />. Значение по умолчанию: <see langword="false" />.</returns>
		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x000C8B4F File Offset: 0x000C6D4F
		// (set) Token: 0x06003976 RID: 14710 RVA: 0x000C8B57 File Offset: 0x000C6D57
		public bool DontFragment
		{
			get
			{
				return this.dontFragment;
			}
			set
			{
				this.dontFragment = value;
			}
		}

		// Token: 0x040021A8 RID: 8616
		private const int DontFragmentFlag = 2;

		// Token: 0x040021A9 RID: 8617
		private int ttl = 128;

		// Token: 0x040021AA RID: 8618
		private bool dontFragment;
	}
}
