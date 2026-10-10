using System;

namespace System.Net.Sockets
{
	/// <summary>Представляет полученные результаты UDP из вызова метода <see cref="M:System.Net.Sockets.UdpClient.ReceiveAsync" />.</summary>
	// Token: 0x020007BF RID: 1983
	public struct UdpReceiveResult : IEquatable<UdpReceiveResult>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.UdpReceiveResult" />.</summary>
		/// <param name="buffer">Буфер для данных, которые необходимо получить в пакете UDP.</param>
		/// <param name="remoteEndPoint">Удаленная конечная точка пакета UDP.</param>
		// Token: 0x06003F4E RID: 16206 RVA: 0x000D8651 File Offset: 0x000D6851
		public UdpReceiveResult(byte[] buffer, IPEndPoint remoteEndPoint)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (remoteEndPoint == null)
			{
				throw new ArgumentNullException("remoteEndPoint");
			}
			this.m_buffer = buffer;
			this.m_remoteEndPoint = remoteEndPoint;
		}

		/// <summary>Возвращает буфер с данными, полученными в пакете UDP.</summary>
		/// <returns>Массив <see cref="T:System.Byte" /> с данными, полученными в пакете UDP.</returns>
		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x000D867D File Offset: 0x000D687D
		public byte[] Buffer
		{
			get
			{
				return this.m_buffer;
			}
		}

		/// <summary>Возвращает удаленную конечную точку, из которой был получен пакет UDP.</summary>
		/// <returns>Удаленная конечная точку, от которой получен пакет UDP.</returns>
		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06003F50 RID: 16208 RVA: 0x000D8685 File Offset: 0x000D6885
		public IPEndPoint RemoteEndPoint
		{
			get
			{
				return this.m_remoteEndPoint;
			}
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код.</returns>
		// Token: 0x06003F51 RID: 16209 RVA: 0x000D868D File Offset: 0x000D688D
		public override int GetHashCode()
		{
			if (this.m_buffer == null)
			{
				return 0;
			}
			return this.m_buffer.GetHashCode() ^ this.m_remoteEndPoint.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром класса <see cref="T:System.Net.Sockets.UdpReceiveResult" /> и равен значению этого экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003F52 RID: 16210 RVA: 0x000D86B0 File Offset: 0x000D68B0
		public override bool Equals(object obj)
		{
			return obj is UdpReceiveResult && this.Equals((UdpReceiveResult)obj);
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="other">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="other" /> является экземпляром класса <see cref="T:System.Net.Sockets.UdpReceiveResult" /> и равен значению этого экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003F53 RID: 16211 RVA: 0x000D86C8 File Offset: 0x000D68C8
		public bool Equals(UdpReceiveResult other)
		{
			return object.Equals(this.m_buffer, other.m_buffer) && object.Equals(this.m_remoteEndPoint, other.m_remoteEndPoint);
		}

		/// <summary>Проверяет, эквивалентны ли два указанные экземпляра <see cref="T:System.Net.Sockets.UdpReceiveResult" />.</summary>
		/// <param name="left">Экземпляр <see cref="T:System.Net.Sockets.UdpReceiveResult" />, который находится слева от оператора равенства.</param>
		/// <param name="right">Экземпляр класса <see cref="T:System.Net.Sockets.UdpReceiveResult" />, который находится справа от оператора равенства.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003F54 RID: 16212 RVA: 0x000D86F0 File Offset: 0x000D68F0
		public static bool operator ==(UdpReceiveResult left, UdpReceiveResult right)
		{
			return left.Equals(right);
		}

		/// <summary>Проверяет, являются дли два заданных экземпляра <see cref="T:System.Net.Sockets.UdpReceiveResult" /> неравными.</summary>
		/// <param name="left">Экземпляр <see cref="T:System.Net.Sockets.UdpReceiveResult" />, который находится слева от оператора неравенства.</param>
		/// <param name="right">Экземпляр класса <see cref="T:System.Net.Sockets.UdpReceiveResult" />, который находится справа от оператора неравенства.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003F55 RID: 16213 RVA: 0x000D86FA File Offset: 0x000D68FA
		public static bool operator !=(UdpReceiveResult left, UdpReceiveResult right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040025D2 RID: 9682
		private byte[] m_buffer;

		// Token: 0x040025D3 RID: 9683
		private IPEndPoint m_remoteEndPoint;
	}
}
