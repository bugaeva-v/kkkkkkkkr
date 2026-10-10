using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	/// <summary>Этот класс содержит методы расширения для класса <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x020007C7 RID: 1991
	public static class SocketTaskExtensions
	{
		/// <summary>Выполняет асинхронную операцию для приема попыток входящего подключения через сокет.</summary>
		/// <param name="socket">Сокет, ожидающий передачи данных для подключений.</param>
		/// <returns>Асинхронная задача, которая завершается <see cref="T:System.Net.Sockets.Socket" /> для обработки подключения к удаленному узлу.</returns>
		// Token: 0x06003FAA RID: 16298 RVA: 0x000D92EC File Offset: 0x000D74EC
		public static Task<Socket> AcceptAsync(this Socket socket)
		{
			return Task<Socket>.Factory.FromAsync((AsyncCallback callback, object state) => ((Socket)state).BeginAccept(callback, state), (IAsyncResult asyncResult) => ((Socket)asyncResult.AsyncState).EndAccept(asyncResult), socket);
		}

		/// <summary>Выполняет асинхронную операцию для приема попыток входящего подключения через сокет.</summary>
		/// <param name="socket">Сокет, ожидающий передачи данных для входящих подключений.</param>
		/// <param name="acceptSocket">Принятый объект <see cref="T:System.Net.Sockets.Socket" />. Это значение может быть равно <see langword="null" />.</param>
		/// <returns>Асинхронная задача, которая завершается <see cref="T:System.Net.Sockets.Socket" /> для обработки подключения к удаленному узлу.</returns>
		// Token: 0x06003FAB RID: 16299 RVA: 0x000D9344 File Offset: 0x000D7544
		public static Task<Socket> AcceptAsync(this Socket socket, Socket acceptSocket)
		{
			return Task<Socket>.Factory.FromAsync<Socket, int>((Socket socketForAccept, int receiveSize, AsyncCallback callback, object state) => ((Socket)state).BeginAccept(socketForAccept, receiveSize, callback, state), (IAsyncResult asyncResult) => ((Socket)asyncResult.AsyncState).EndAccept(asyncResult), acceptSocket, 0, socket);
		}

		/// <summary>Устанавливает подключение к удаленному узлу.</summary>
		/// <param name="socket">Сокет, который используется для установления подключения.</param>
		/// <param name="remoteEP">Конечная точка, представляющая удаленное устройство.</param>
		/// <returns>Асинхронная задача.</returns>
		// Token: 0x06003FAC RID: 16300 RVA: 0x000D939C File Offset: 0x000D759C
		public static Task ConnectAsync(this Socket socket, EndPoint remoteEP)
		{
			return Task.Factory.FromAsync<EndPoint>((EndPoint targetEndPoint, AsyncCallback callback, object state) => ((Socket)state).BeginConnect(targetEndPoint, callback, state), delegate(IAsyncResult asyncResult)
			{
				((Socket)asyncResult.AsyncState).EndConnect(asyncResult);
			}, remoteEP, socket);
		}

		/// <summary>Устанавливает подключение к удаленному узлу. Узел задается IP-адресом и номером порта.</summary>
		/// <param name="socket">Сокет для выполнения операции подключения.</param>
		/// <param name="address">IP-адрес удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		// Token: 0x06003FAD RID: 16301 RVA: 0x000D93F4 File Offset: 0x000D75F4
		public static Task ConnectAsync(this Socket socket, IPAddress address, int port)
		{
			return Task.Factory.FromAsync<IPAddress, int>((IPAddress targetAddress, int targetPort, AsyncCallback callback, object state) => ((Socket)state).BeginConnect(targetAddress, targetPort, callback, state), delegate(IAsyncResult asyncResult)
			{
				((Socket)asyncResult.AsyncState).EndConnect(asyncResult);
			}, address, port, socket);
		}

		/// <summary>Устанавливает подключение к удаленному узлу. Узел задается массивом IP-адресов и номером порта.</summary>
		/// <param name="socket">Сокет, в котором выполняется операция подключения.</param>
		/// <param name="addresses">IP-адрес удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <returns>Задача, представляющая асинхронную операцию подключения.</returns>
		// Token: 0x06003FAE RID: 16302 RVA: 0x000D944C File Offset: 0x000D764C
		public static Task ConnectAsync(this Socket socket, IPAddress[] addresses, int port)
		{
			return Task.Factory.FromAsync<IPAddress[], int>((IPAddress[] targetAddresses, int targetPort, AsyncCallback callback, object state) => ((Socket)state).BeginConnect(targetAddresses, targetPort, callback, state), delegate(IAsyncResult asyncResult)
			{
				((Socket)asyncResult.AsyncState).EndConnect(asyncResult);
			}, addresses, port, socket);
		}

		/// <summary>Устанавливает подключение к удаленному узлу. Узел задается именем узла и номером порта.</summary>
		/// <param name="socket">Сокет для выполнения операции подключения.</param>
		/// <param name="host">Имя удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <returns>Асинхронная задача.</returns>
		// Token: 0x06003FAF RID: 16303 RVA: 0x000D94A4 File Offset: 0x000D76A4
		public static Task ConnectAsync(this Socket socket, string host, int port)
		{
			return Task.Factory.FromAsync<string, int>((string targetHost, int targetPort, AsyncCallback callback, object state) => ((Socket)state).BeginConnect(targetHost, targetPort, callback, state), delegate(IAsyncResult asyncResult)
			{
				((Socket)asyncResult.AsyncState).EndConnect(asyncResult);
			}, host, port, socket);
		}

		/// <summary>Получает данные из подключенного сокета.</summary>
		/// <param name="socket">Сокет для выполнения операции получения.</param>
		/// <param name="buffer">Массив, который является местом хранения полученных данных.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию получения. Значение параметра <paramref name="TResult" /> содержит число полученных байтов.</returns>
		// Token: 0x06003FB0 RID: 16304 RVA: 0x000D94FC File Offset: 0x000D76FC
		public static Task<int> ReceiveAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags)
		{
			return Task<int>.Factory.FromAsync<ArraySegment<byte>, SocketFlags>((ArraySegment<byte> targetBuffer, SocketFlags flags, AsyncCallback callback, object state) => ((Socket)state).BeginReceive(targetBuffer.Array, targetBuffer.Offset, targetBuffer.Count, flags, callback, state), (IAsyncResult asyncResult) => ((Socket)asyncResult.AsyncState).EndReceive(asyncResult), buffer, socketFlags, socket);
		}

		/// <summary>Получает данные из подключенного сокета.</summary>
		/// <param name="socket">Сокет для выполнения операции получения.</param>
		/// <param name="buffers">Массив, который является местом хранения полученных данных.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию получения. Значение параметра <paramref name="TResult" /> содержит число полученных байтов.</returns>
		// Token: 0x06003FB1 RID: 16305 RVA: 0x000D9554 File Offset: 0x000D7754
		public static Task<int> ReceiveAsync(this Socket socket, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return Task<int>.Factory.FromAsync<IList<ArraySegment<byte>>, SocketFlags>((IList<ArraySegment<byte>> targetBuffers, SocketFlags flags, AsyncCallback callback, object state) => ((Socket)state).BeginReceive(targetBuffers, flags, callback, state), (IAsyncResult asyncResult) => ((Socket)asyncResult.AsyncState).EndReceive(asyncResult), buffers, socketFlags, socket);
		}

		/// <summary>Получает данные из указанного сетевого устройства.</summary>
		/// <param name="socket">Сокет для выполнения операции ReceiveFrom.</param>
		/// <param name="buffer">Массив байтового типа, который является местом хранения полученных данных.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEndPoint">Конечная точка, представляющая источник данных.</param>
		/// <returns>Асинхронная задача, выполняющая со структурой SocketReceiveFromResult.</returns>
		// Token: 0x06003FB2 RID: 16306 RVA: 0x000D95AC File Offset: 0x000D77AC
		public static Task<SocketReceiveFromResult> ReceiveFromAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
		{
			object[] state2 = new object[]
			{
				socket,
				remoteEndPoint
			};
			return Task<SocketReceiveFromResult>.Factory.FromAsync<ArraySegment<byte>, SocketFlags>(delegate(ArraySegment<byte> targetBuffer, SocketFlags flags, AsyncCallback callback, object state)
			{
				object[] array = (object[])state;
				Socket socket2 = (Socket)array[0];
				EndPoint endPoint = (EndPoint)array[1];
				IAsyncResult result = socket2.BeginReceiveFrom(targetBuffer.Array, targetBuffer.Offset, targetBuffer.Count, flags, ref endPoint, callback, state);
				array[1] = endPoint;
				return result;
			}, delegate(IAsyncResult asyncResult)
			{
				object[] array = (object[])asyncResult.AsyncState;
				Socket socket2 = (Socket)array[0];
				EndPoint remoteEndPoint2 = (EndPoint)array[1];
				int receivedBytes = socket2.EndReceiveFrom(asyncResult, ref remoteEndPoint2);
				return new SocketReceiveFromResult
				{
					ReceivedBytes = receivedBytes,
					RemoteEndPoint = remoteEndPoint2
				};
			}, buffer, socketFlags, state2);
		}

		/// <summary>Получает указанное число байтов данных в указанное расположение буфера данных с помощью заданного <see cref="T:System.Net.Sockets.SocketFlags" /> и сохраняет конечную точку и сведения о пакете.</summary>
		/// <param name="socket">Сокет для выполнения операции.</param>
		/// <param name="buffer">Массив, который является местом хранения полученных данных.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEndPoint">
		///   <see cref="T:System.Net.EndPoint" />, который представляет удаленный сервер.</param>
		/// <returns>Асинхронная задача, результатом выполнения которой является структура <see cref="T:System.Net.Sockets.SocketReceiveMessageFromResult" />.</returns>
		// Token: 0x06003FB3 RID: 16307 RVA: 0x000D9614 File Offset: 0x000D7814
		public static Task<SocketReceiveMessageFromResult> ReceiveMessageFromAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
		{
			object[] state2 = new object[]
			{
				socket,
				socketFlags,
				remoteEndPoint
			};
			return Task<SocketReceiveMessageFromResult>.Factory.FromAsync<ArraySegment<byte>>(delegate(ArraySegment<byte> targetBuffer, AsyncCallback callback, object state)
			{
				object[] array = (object[])state;
				Socket socket2 = (Socket)array[0];
				SocketFlags socketFlags2 = (SocketFlags)array[1];
				EndPoint endPoint = (EndPoint)array[2];
				IAsyncResult result = socket2.BeginReceiveMessageFrom(targetBuffer.Array, targetBuffer.Offset, targetBuffer.Count, socketFlags2, ref endPoint, callback, state);
				array[2] = endPoint;
				return result;
			}, delegate(IAsyncResult asyncResult)
			{
				object[] array = (object[])asyncResult.AsyncState;
				Socket socket2 = (Socket)array[0];
				SocketFlags socketFlags2 = (SocketFlags)array[1];
				EndPoint remoteEndPoint2 = (EndPoint)array[2];
				IPPacketInformation packetInformation;
				int receivedBytes = socket2.EndReceiveMessageFrom(asyncResult, ref socketFlags2, ref remoteEndPoint2, out packetInformation);
				return new SocketReceiveMessageFromResult
				{
					PacketInformation = packetInformation,
					ReceivedBytes = receivedBytes,
					RemoteEndPoint = remoteEndPoint2,
					SocketFlags = socketFlags2
				};
			}, buffer, state2);
		}

		/// <summary>Отправляет данные в подключенный сокет.</summary>
		/// <param name="socket">Сокет для выполнения операции.</param>
		/// <param name="buffer">Массив байтового типа, содержащий данные для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Асинхронная задача, выполнение которой дает число байт, отправленных в сокет, если операция выполнена успешно. В противном случае задача завершится ошибкой недопустимого сокета.</returns>
		// Token: 0x06003FB4 RID: 16308 RVA: 0x000D9684 File Offset: 0x000D7884
		public static Task<int> SendAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags)
		{
			return Task<int>.Factory.FromAsync<ArraySegment<byte>, SocketFlags>((ArraySegment<byte> targetBuffer, SocketFlags flags, AsyncCallback callback, object state) => ((Socket)state).BeginSend(targetBuffer.Array, targetBuffer.Offset, targetBuffer.Count, flags, callback, state), (IAsyncResult asyncResult) => ((Socket)asyncResult.AsyncState).EndSend(asyncResult), buffer, socketFlags, socket);
		}

		/// <summary>Отправляет данные в подключенный сокет.</summary>
		/// <param name="socket">Сокет для выполнения операции.</param>
		/// <param name="buffers">Массив, содержащий отправляемые данные.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Асинхронная задача, выполнение которой дает число байт, отправленных в сокет, если операция выполнена успешно. В противном случае задача завершится ошибкой недопустимого сокета.</returns>
		// Token: 0x06003FB5 RID: 16309 RVA: 0x000D96DC File Offset: 0x000D78DC
		public static Task<int> SendAsync(this Socket socket, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return Task<int>.Factory.FromAsync<IList<ArraySegment<byte>>, SocketFlags>((IList<ArraySegment<byte>> targetBuffers, SocketFlags flags, AsyncCallback callback, object state) => ((Socket)state).BeginSend(targetBuffers, flags, callback, state), (IAsyncResult asyncResult) => ((Socket)asyncResult.AsyncState).EndSend(asyncResult), buffers, socketFlags, socket);
		}

		/// <summary>Асинхронно передает данные на конкретный удаленный узел.</summary>
		/// <param name="socket">Сокет для выполнения операции.</param>
		/// <param name="buffer">Массив, содержащий отправляемые данные.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий удаленное устройство.</param>
		/// <returns>Асинхронная задача, выполнение которой дает число отправленных байт, если операция выполнена успешно. В противном случае задача завершится ошибкой недопустимого сокета.</returns>
		// Token: 0x06003FB6 RID: 16310 RVA: 0x000D9734 File Offset: 0x000D7934
		public static Task<int> SendToAsync(this Socket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return Task<int>.Factory.FromAsync<ArraySegment<byte>, SocketFlags, EndPoint>((ArraySegment<byte> targetBuffer, SocketFlags flags, EndPoint endPoint, AsyncCallback callback, object state) => ((Socket)state).BeginSendTo(targetBuffer.Array, targetBuffer.Offset, targetBuffer.Count, flags, endPoint, callback, state), (IAsyncResult asyncResult) => ((Socket)asyncResult.AsyncState).EndSendTo(asyncResult), buffer, socketFlags, remoteEP, socket);
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x000D978D File Offset: 0x000D798D
		public static ValueTask<int> SendAsync(this Socket socket, ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken = default(CancellationToken))
		{
			return socket.SendAsync(buffer, socketFlags, cancellationToken);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x000D9798 File Offset: 0x000D7998
		public static ValueTask<int> ReceiveAsync(this Socket socket, Memory<byte> memory, SocketFlags socketFlags, CancellationToken cancellationToken = default(CancellationToken))
		{
			TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(socket);
			byte[] buffer = memory.ToArray();
			socket.BeginReceive(buffer, 0, memory.Length, socketFlags, delegate(IAsyncResult iar)
			{
				cancellationToken.ThrowIfCancellationRequested();
				Memory<byte> memory2 = new Memory<byte>(buffer);
				memory2.CopyTo(memory);
				TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
				Socket socket2 = (Socket)taskCompletionSource2.Task.AsyncState;
				try
				{
					taskCompletionSource2.TrySetResult(socket2.EndReceive(iar));
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			cancellationToken.ThrowIfCancellationRequested();
			return new ValueTask<int>(taskCompletionSource.Task);
		}
	}
}
