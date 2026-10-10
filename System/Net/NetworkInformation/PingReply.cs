using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения о состоянии и о данных, полученных в результате операции <see cref="Overload:System.Net.NetworkInformation.Ping.Send" /> или <see cref="Overload:System.Net.NetworkInformation.Ping.SendAsync" />.</summary>
	// Token: 0x020006FD RID: 1789
	public class PingReply
	{
		// Token: 0x06003977 RID: 14711 RVA: 0x0000219B File Offset: 0x0000039B
		internal PingReply()
		{
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x000C8B60 File Offset: 0x000C6D60
		internal PingReply(IPStatus ipStatus)
		{
			this.ipStatus = ipStatus;
			this.buffer = new byte[0];
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x000C8B7C File Offset: 0x000C6D7C
		internal PingReply(byte[] data, int dataLength, IPAddress address, int time)
		{
			this.address = address;
			this.rtt = (long)time;
			this.ipStatus = this.GetIPStatus((IcmpV4Type)data[20], (IcmpV4Code)data[21]);
			if (this.ipStatus == IPStatus.Success)
			{
				this.buffer = new byte[dataLength - 28];
				Array.Copy(data, 28, this.buffer, 0, dataLength - 28);
				return;
			}
			this.buffer = new byte[0];
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x000C8BEA File Offset: 0x000C6DEA
		internal PingReply(IPAddress address, byte[] buffer, PingOptions options, long roundtripTime, IPStatus status)
		{
			this.address = address;
			this.buffer = buffer;
			this.options = options;
			this.rtt = roundtripTime;
			this.ipStatus = status;
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x000C8C18 File Offset: 0x000C6E18
		private IPStatus GetIPStatus(IcmpV4Type type, IcmpV4Code code)
		{
			switch (type)
			{
			case IcmpV4Type.ICMP4_ECHO_REPLY:
				return IPStatus.Success;
			case (IcmpV4Type)1:
			case (IcmpV4Type)2:
				break;
			case IcmpV4Type.ICMP4_DST_UNREACH:
				switch (code)
				{
				case IcmpV4Code.ICMP4_UNREACH_NET:
					return IPStatus.DestinationNetworkUnreachable;
				case IcmpV4Code.ICMP4_UNREACH_HOST:
					return IPStatus.DestinationHostUnreachable;
				case IcmpV4Code.ICMP4_UNREACH_PROTOCOL:
					return IPStatus.DestinationProtocolUnreachable;
				case IcmpV4Code.ICMP4_UNREACH_PORT:
					return IPStatus.DestinationPortUnreachable;
				case IcmpV4Code.ICMP4_UNREACH_FRAG_NEEDED:
					return IPStatus.PacketTooBig;
				default:
					return IPStatus.DestinationUnreachable;
				}
				break;
			case IcmpV4Type.ICMP4_SOURCE_QUENCH:
				return IPStatus.SourceQuench;
			default:
				if (type == IcmpV4Type.ICMP4_TIME_EXCEEDED)
				{
					return IPStatus.TtlExpired;
				}
				if (type == IcmpV4Type.ICMP4_PARAM_PROB)
				{
					return IPStatus.ParameterProblem;
				}
				break;
			}
			return IPStatus.Unknown;
		}

		/// <summary>Возвращает состояние попытки отправки запроса проверки связи ICMP и получения соответствующего сообщения ответа проверки связи ICMP.</summary>
		/// <returns>Значение <see cref="T:System.Net.NetworkInformation.IPStatus" />, показывающее результат запроса.</returns>
		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x000C8CA0 File Offset: 0x000C6EA0
		public IPStatus Status
		{
			get
			{
				return this.ipStatus;
			}
		}

		/// <summary>Возвращает адрес узла и отправляет ответ проверки связи ICMP.</summary>
		/// <returns>Объект <see cref="T:System.Net.IPAddress" />, содержащий получателя сообщения проверки связи ICMP.</returns>
		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x000C8CA8 File Offset: 0x000C6EA8
		public IPAddress Address
		{
			get
			{
				return this.address;
			}
		}

		/// <summary>Возвращает время в миллисекундах, затрачиваемое на отправку запроса проверки связи ICMP и получение соответствующего сообщения ответа проверки связи ICMP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее время прохождения пакета "туда и обратно" в миллисекундах.</returns>
		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x000C8CB0 File Offset: 0x000C6EB0
		public long RoundtripTime
		{
			get
			{
				return this.rtt;
			}
		}

		/// <summary>Возвращает параметры, используемые для передачи ответа на запрос проверки связи ICMP.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.PingOptions" />, содержащий срок жизни и директиву фрагментации, которые используются для передачи ответа, если свойство <see cref="P:System.Net.NetworkInformation.PingReply.Status" /> имеет значение <see cref="F:System.Net.NetworkInformation.IPStatus.Success" />; в противном случае — <see langword="null" />.</returns>
		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x000C8CB8 File Offset: 0x000C6EB8
		public PingOptions Options
		{
			get
			{
				return this.options;
			}
		}

		/// <summary>Возвращает буфер данных, полученных в сообщении ответа проверки связи ICMP.</summary>
		/// <returns>Массив <see cref="T:System.Byte" />, в котором содержатся данные, полученные в сообщении ответа проверки связи ICMP, или пустой массив, если ответ не получен.</returns>
		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06003980 RID: 14720 RVA: 0x000C8CC0 File Offset: 0x000C6EC0
		public byte[] Buffer
		{
			get
			{
				return this.buffer;
			}
		}

		// Token: 0x040021AB RID: 8619
		private IPAddress address;

		// Token: 0x040021AC RID: 8620
		private PingOptions options;

		// Token: 0x040021AD RID: 8621
		private IPStatus ipStatus;

		// Token: 0x040021AE RID: 8622
		private long rtt;

		// Token: 0x040021AF RID: 8623
		private byte[] buffer;
	}
}
