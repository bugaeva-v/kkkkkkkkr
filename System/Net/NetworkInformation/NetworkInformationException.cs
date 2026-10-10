using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation
{
	/// <summary>Это исключение происходит при ошибке во время получения сведений о сети.</summary>
	// Token: 0x020006F4 RID: 1780
	[Serializable]
	public class NetworkInformationException : Win32Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.NetworkInformationException" />.</summary>
		// Token: 0x06003943 RID: 14659 RVA: 0x0007B700 File Offset: 0x00079900
		public NetworkInformationException() : base(Marshal.GetLastWin32Error())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> с указанным кодом ошибки.</summary>
		/// <param name="errorCode">Код ошибки <see langword="Win32" />.</param>
		// Token: 0x06003944 RID: 14660 RVA: 0x000A5C91 File Offset: 0x000A3E91
		public NetworkInformationException(int errorCode) : base(errorCode)
		{
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x000A5C91 File Offset: 0x000A3E91
		internal NetworkInformationException(SocketError socketError) : base((int)socketError)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> с сериализованными данными.</summary>
		/// <param name="serializationInfo">Объект SerializationInfo, содержащий сериализованные данные исключения.</param>
		/// <param name="streamingContext">Объект StreamingContext, содержащий контекстные сведения о сериализованном исключении.</param>
		// Token: 0x06003946 RID: 14662 RVA: 0x000A5CA4 File Offset: 0x000A3EA4
		protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Возвращает код ошибки <see langword="Win32" /> для данного исключения.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, содержащее код ошибки <see langword="Win32" />.</returns>
		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x000A5CAE File Offset: 0x000A3EAE
		public override int ErrorCode
		{
			get
			{
				return base.NativeErrorCode;
			}
		}
	}
}
