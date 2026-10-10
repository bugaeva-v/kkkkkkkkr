using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net.Sockets
{
	/// <summary>Исключение, которое создается при возникновении ошибки на сокете.</summary>
	// Token: 0x020007A4 RID: 1956
	[Serializable]
	public class SocketException : Win32Exception
	{
		// Token: 0x06003E94 RID: 16020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int WSAGetLastError_icall();

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SocketException" /> с кодом последней ошибки операционной системы.</summary>
		// Token: 0x06003E95 RID: 16021 RVA: 0x000D6669 File Offset: 0x000D4869
		public SocketException() : base(SocketException.WSAGetLastError_icall())
		{
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x000A5C9A File Offset: 0x000A3E9A
		internal SocketException(int error, string message) : base(error, message)
		{
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x000D6676 File Offset: 0x000D4876
		internal SocketException(EndPoint endPoint) : base(Marshal.GetLastWin32Error())
		{
			this.m_EndPoint = endPoint;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SocketException" /> с указанным кодом ошибки.</summary>
		/// <param name="errorCode">Код ошибки, указывающий на возникшую ошибку.</param>
		// Token: 0x06003E98 RID: 16024 RVA: 0x000A5C91 File Offset: 0x000A3E91
		public SocketException(int errorCode) : base(errorCode)
		{
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x000D668A File Offset: 0x000D488A
		internal SocketException(int errorCode, EndPoint endPoint) : base(errorCode)
		{
			this.m_EndPoint = endPoint;
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x000A5C91 File Offset: 0x000A3E91
		internal SocketException(SocketError socketError) : base((int)socketError)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.SocketException" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, необходимые для сериализации нового экземпляра класса <see cref="T:System.Net.Sockets.SocketException" />.</param>
		/// <param name="streamingContext">Экземпляр класса <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий источник сериализованного потока, связанного с новым экземпляром класса <see cref="T:System.Net.Sockets.SocketException" />.</param>
		// Token: 0x06003E9B RID: 16027 RVA: 0x000A5CA4 File Offset: 0x000A3EA4
		protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Получает код ошибки, связанной с этим исключением.</summary>
		/// <returns>Целочисленный код ошибки, связанной с этим исключением.</returns>
		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06003E9C RID: 16028 RVA: 0x000A5CAE File Offset: 0x000A3EAE
		public override int ErrorCode
		{
			get
			{
				return base.NativeErrorCode;
			}
		}

		/// <summary>Получает сообщение об ошибке, связанное с этим исключением.</summary>
		/// <returns>Строка, содержащая сообщение об ошибке.</returns>
		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x000D669A File Offset: 0x000D489A
		public override string Message
		{
			get
			{
				if (this.m_EndPoint == null)
				{
					return base.Message;
				}
				return base.Message + " " + this.m_EndPoint.ToString();
			}
		}

		/// <summary>Получает код ошибки, связанной с этим исключением.</summary>
		/// <returns>Целочисленный код ошибки, связанной с этим исключением.</returns>
		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06003E9E RID: 16030 RVA: 0x000A5CAE File Offset: 0x000A3EAE
		public SocketError SocketErrorCode
		{
			get
			{
				return (SocketError)base.NativeErrorCode;
			}
		}

		// Token: 0x04002490 RID: 9360
		[NonSerialized]
		private EndPoint m_EndPoint;
	}
}
