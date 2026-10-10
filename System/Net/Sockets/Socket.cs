using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Mono;

namespace System.Net.Sockets
{
	/// <summary>Реализует интерфейс сокетов Беркли.</summary>
	// Token: 0x02000793 RID: 1939
	public class Socket : IDisposable
	{
		// Token: 0x06003D1D RID: 15645 RVA: 0x000D0224 File Offset: 0x000CE424
		internal Task<Socket> AcceptAsync(Socket acceptSocket)
		{
			Socket.TaskSocketAsyncEventArgs<Socket> taskSocketAsyncEventArgs = Interlocked.Exchange<Socket.TaskSocketAsyncEventArgs<Socket>>(ref LazyInitializer.EnsureInitialized<Socket.CachedEventArgs>(ref this._cachedTaskEventArgs, () => new Socket.CachedEventArgs()).TaskAccept, Socket.s_rentedSocketSentinel);
			if (taskSocketAsyncEventArgs == Socket.s_rentedSocketSentinel)
			{
				return this.AcceptAsyncApm(acceptSocket);
			}
			if (taskSocketAsyncEventArgs == null)
			{
				taskSocketAsyncEventArgs = new Socket.TaskSocketAsyncEventArgs<Socket>();
				taskSocketAsyncEventArgs.Completed += Socket.AcceptCompletedHandler;
			}
			taskSocketAsyncEventArgs.AcceptSocket = acceptSocket;
			Task<Socket> result;
			if (this.AcceptAsync(taskSocketAsyncEventArgs))
			{
				bool flag;
				result = taskSocketAsyncEventArgs.GetCompletionResponsibility(out flag).Task;
				if (flag)
				{
					this.ReturnSocketAsyncEventArgs(taskSocketAsyncEventArgs);
				}
			}
			else
			{
				result = ((taskSocketAsyncEventArgs.SocketError == SocketError.Success) ? Task.FromResult<Socket>(taskSocketAsyncEventArgs.AcceptSocket) : Task.FromException<Socket>(Socket.GetException(taskSocketAsyncEventArgs.SocketError, false)));
				this.ReturnSocketAsyncEventArgs(taskSocketAsyncEventArgs);
			}
			return result;
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x000D02EC File Offset: 0x000CE4EC
		private Task<Socket> AcceptAsyncApm(Socket acceptSocket)
		{
			TaskCompletionSource<Socket> taskCompletionSource = new TaskCompletionSource<Socket>(this);
			this.BeginAccept(acceptSocket, 0, delegate(IAsyncResult iar)
			{
				TaskCompletionSource<Socket> taskCompletionSource2 = (TaskCompletionSource<Socket>)iar.AsyncState;
				try
				{
					taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndAccept(iar));
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			return taskCompletionSource.Task;
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x000D0330 File Offset: 0x000CE530
		internal Task ConnectAsync(EndPoint remoteEP)
		{
			TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(this);
			this.BeginConnect(remoteEP, delegate(IAsyncResult iar)
			{
				TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
				try
				{
					((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
					taskCompletionSource2.TrySetResult(true);
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			return taskCompletionSource.Task;
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x000D0374 File Offset: 0x000CE574
		internal Task ConnectAsync(IPAddress address, int port)
		{
			TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(this);
			this.BeginConnect(address, port, delegate(IAsyncResult iar)
			{
				TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
				try
				{
					((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
					taskCompletionSource2.TrySetResult(true);
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			return taskCompletionSource.Task;
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x000D03B8 File Offset: 0x000CE5B8
		internal Task ConnectAsync(IPAddress[] addresses, int port)
		{
			TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(this);
			this.BeginConnect(addresses, port, delegate(IAsyncResult iar)
			{
				TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
				try
				{
					((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
					taskCompletionSource2.TrySetResult(true);
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			return taskCompletionSource.Task;
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x000D03FC File Offset: 0x000CE5FC
		internal Task ConnectAsync(string host, int port)
		{
			TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(this);
			this.BeginConnect(host, port, delegate(IAsyncResult iar)
			{
				TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
				try
				{
					((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
					taskCompletionSource2.TrySetResult(true);
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			return taskCompletionSource.Task;
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x000D0440 File Offset: 0x000CE640
		internal Task<int> ReceiveAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream)
		{
			Socket.ValidateBuffer(buffer);
			return this.ReceiveAsync(buffer, socketFlags, fromNetworkStream, default(CancellationToken)).AsTask();
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x000D0474 File Offset: 0x000CE674
		internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs = LazyInitializer.EnsureInitialized<Socket.AwaitableSocketAsyncEventArgs>(ref LazyInitializer.EnsureInitialized<Socket.CachedEventArgs>(ref this._cachedTaskEventArgs, () => new Socket.CachedEventArgs()).ValueTaskReceive, () => new Socket.AwaitableSocketAsyncEventArgs());
			if (awaitableSocketAsyncEventArgs.Reserve())
			{
				awaitableSocketAsyncEventArgs.SetBuffer(buffer);
				awaitableSocketAsyncEventArgs.SocketFlags = socketFlags;
				awaitableSocketAsyncEventArgs.WrapExceptionsInIOExceptions = fromNetworkStream;
				return awaitableSocketAsyncEventArgs.ReceiveAsync(this);
			}
			return new ValueTask<int>(this.ReceiveAsyncApm(buffer, socketFlags));
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x000D0520 File Offset: 0x000CE720
		private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
				this.BeginReceive(arraySegment.Array, arraySegment.Offset, arraySegment.Count, socketFlags, delegate(IAsyncResult iar)
				{
					TaskCompletionSource<int> taskCompletionSource3 = (TaskCompletionSource<int>)iar.AsyncState;
					try
					{
						taskCompletionSource3.TrySetResult(((Socket)taskCompletionSource3.Task.AsyncState).EndReceive(iar));
					}
					catch (Exception exception)
					{
						taskCompletionSource3.TrySetException(exception);
					}
				}, taskCompletionSource);
				return taskCompletionSource.Task;
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			TaskCompletionSource<int> taskCompletionSource2 = new TaskCompletionSource<int>(this);
			this.BeginReceive(array, 0, buffer.Length, socketFlags, delegate(IAsyncResult iar)
			{
				Tuple<TaskCompletionSource<int>, Memory<byte>, byte[]> tuple = (Tuple<TaskCompletionSource<int>, Memory<byte>, byte[]>)iar.AsyncState;
				try
				{
					int num = ((Socket)tuple.Item1.Task.AsyncState).EndReceive(iar);
					new ReadOnlyMemory<byte>(tuple.Item3, 0, num).Span.CopyTo(tuple.Item2.Span);
					tuple.Item1.TrySetResult(num);
				}
				catch (Exception exception)
				{
					tuple.Item1.TrySetException(exception);
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(tuple.Item3, false);
				}
			}, Tuple.Create<TaskCompletionSource<int>, Memory<byte>, byte[]>(taskCompletionSource2, buffer, array));
			return taskCompletionSource2.Task;
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x000D05E0 File Offset: 0x000CE7E0
		internal Task<int> ReceiveAsync(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			Socket.ValidateBuffersList(buffers);
			Socket.Int32TaskSocketAsyncEventArgs int32TaskSocketAsyncEventArgs = this.RentSocketAsyncEventArgs(true);
			if (int32TaskSocketAsyncEventArgs != null)
			{
				Socket.ConfigureBufferList(int32TaskSocketAsyncEventArgs, buffers, socketFlags);
				return this.GetTaskForSendReceive(this.ReceiveAsync(int32TaskSocketAsyncEventArgs), int32TaskSocketAsyncEventArgs, false, true);
			}
			return this.ReceiveAsyncApm(buffers, socketFlags);
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x000D0620 File Offset: 0x000CE820
		private Task<int> ReceiveAsyncApm(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
			this.BeginReceive(buffers, socketFlags, delegate(IAsyncResult iar)
			{
				TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
				try
				{
					taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndReceive(iar));
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			return taskCompletionSource.Task;
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x000D0664 File Offset: 0x000CE864
		internal Task<SocketReceiveFromResult> ReceiveFromAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
		{
			Socket.StateTaskCompletionSource<EndPoint, SocketReceiveFromResult> stateTaskCompletionSource = new Socket.StateTaskCompletionSource<EndPoint, SocketReceiveFromResult>(this)
			{
				_field1 = remoteEndPoint
			};
			this.BeginReceiveFrom(buffer.Array, buffer.Offset, buffer.Count, socketFlags, ref stateTaskCompletionSource._field1, delegate(IAsyncResult iar)
			{
				Socket.StateTaskCompletionSource<EndPoint, SocketReceiveFromResult> stateTaskCompletionSource2 = (Socket.StateTaskCompletionSource<EndPoint, SocketReceiveFromResult>)iar.AsyncState;
				try
				{
					int receivedBytes = ((Socket)stateTaskCompletionSource2.Task.AsyncState).EndReceiveFrom(iar, ref stateTaskCompletionSource2._field1);
					stateTaskCompletionSource2.TrySetResult(new SocketReceiveFromResult
					{
						ReceivedBytes = receivedBytes,
						RemoteEndPoint = stateTaskCompletionSource2._field1
					});
				}
				catch (Exception exception)
				{
					stateTaskCompletionSource2.TrySetException(exception);
				}
			}, stateTaskCompletionSource);
			return stateTaskCompletionSource.Task;
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x000D06C8 File Offset: 0x000CE8C8
		internal Task<SocketReceiveMessageFromResult> ReceiveMessageFromAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
		{
			Socket.StateTaskCompletionSource<SocketFlags, EndPoint, SocketReceiveMessageFromResult> stateTaskCompletionSource = new Socket.StateTaskCompletionSource<SocketFlags, EndPoint, SocketReceiveMessageFromResult>(this)
			{
				_field1 = socketFlags,
				_field2 = remoteEndPoint
			};
			this.BeginReceiveMessageFrom(buffer.Array, buffer.Offset, buffer.Count, socketFlags, ref stateTaskCompletionSource._field2, delegate(IAsyncResult iar)
			{
				Socket.StateTaskCompletionSource<SocketFlags, EndPoint, SocketReceiveMessageFromResult> stateTaskCompletionSource2 = (Socket.StateTaskCompletionSource<SocketFlags, EndPoint, SocketReceiveMessageFromResult>)iar.AsyncState;
				try
				{
					IPPacketInformation packetInformation;
					int receivedBytes = ((Socket)stateTaskCompletionSource2.Task.AsyncState).EndReceiveMessageFrom(iar, ref stateTaskCompletionSource2._field1, ref stateTaskCompletionSource2._field2, out packetInformation);
					stateTaskCompletionSource2.TrySetResult(new SocketReceiveMessageFromResult
					{
						ReceivedBytes = receivedBytes,
						RemoteEndPoint = stateTaskCompletionSource2._field2,
						SocketFlags = stateTaskCompletionSource2._field1,
						PacketInformation = packetInformation
					});
				}
				catch (Exception exception)
				{
					stateTaskCompletionSource2.TrySetException(exception);
				}
			}, stateTaskCompletionSource);
			return stateTaskCompletionSource.Task;
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x000D0734 File Offset: 0x000CE934
		internal Task<int> SendAsync(ArraySegment<byte> buffer, SocketFlags socketFlags)
		{
			Socket.ValidateBuffer(buffer);
			return this.SendAsync(buffer, socketFlags, default(CancellationToken)).AsTask();
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x000D0768 File Offset: 0x000CE968
		internal ValueTask<int> SendAsync(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs = LazyInitializer.EnsureInitialized<Socket.AwaitableSocketAsyncEventArgs>(ref LazyInitializer.EnsureInitialized<Socket.CachedEventArgs>(ref this._cachedTaskEventArgs, () => new Socket.CachedEventArgs()).ValueTaskSend, () => new Socket.AwaitableSocketAsyncEventArgs());
			if (awaitableSocketAsyncEventArgs.Reserve())
			{
				awaitableSocketAsyncEventArgs.SetBuffer(MemoryMarshal.AsMemory<byte>(buffer));
				awaitableSocketAsyncEventArgs.SocketFlags = socketFlags;
				awaitableSocketAsyncEventArgs.WrapExceptionsInIOExceptions = false;
				return awaitableSocketAsyncEventArgs.SendAsync(this);
			}
			return new ValueTask<int>(this.SendAsyncApm(buffer, socketFlags));
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x000D0818 File Offset: 0x000CEA18
		internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask(Task.FromCanceled(cancellationToken));
			}
			Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs = LazyInitializer.EnsureInitialized<Socket.AwaitableSocketAsyncEventArgs>(ref LazyInitializer.EnsureInitialized<Socket.CachedEventArgs>(ref this._cachedTaskEventArgs, () => new Socket.CachedEventArgs()).ValueTaskSend, () => new Socket.AwaitableSocketAsyncEventArgs());
			if (awaitableSocketAsyncEventArgs.Reserve())
			{
				awaitableSocketAsyncEventArgs.SetBuffer(MemoryMarshal.AsMemory<byte>(buffer));
				awaitableSocketAsyncEventArgs.SocketFlags = socketFlags;
				awaitableSocketAsyncEventArgs.WrapExceptionsInIOExceptions = true;
				return awaitableSocketAsyncEventArgs.SendAsyncForNetworkStream(this);
			}
			return new ValueTask(this.SendAsyncApm(buffer, socketFlags));
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x000D08C8 File Offset: 0x000CEAC8
		private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
				this.BeginSend(arraySegment.Array, arraySegment.Offset, arraySegment.Count, socketFlags, delegate(IAsyncResult iar)
				{
					TaskCompletionSource<int> taskCompletionSource3 = (TaskCompletionSource<int>)iar.AsyncState;
					try
					{
						taskCompletionSource3.TrySetResult(((Socket)taskCompletionSource3.Task.AsyncState).EndSend(iar));
					}
					catch (Exception exception)
					{
						taskCompletionSource3.TrySetException(exception);
					}
				}, taskCompletionSource);
				return taskCompletionSource.Task;
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			buffer.Span.CopyTo(array);
			TaskCompletionSource<int> taskCompletionSource2 = new TaskCompletionSource<int>(this);
			this.BeginSend(array, 0, buffer.Length, socketFlags, delegate(IAsyncResult iar)
			{
				Tuple<TaskCompletionSource<int>, byte[]> tuple = (Tuple<TaskCompletionSource<int>, byte[]>)iar.AsyncState;
				try
				{
					tuple.Item1.TrySetResult(((Socket)tuple.Item1.Task.AsyncState).EndSend(iar));
				}
				catch (Exception exception)
				{
					tuple.Item1.TrySetException(exception);
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(tuple.Item2, false);
				}
			}, Tuple.Create<TaskCompletionSource<int>, byte[]>(taskCompletionSource2, array));
			return taskCompletionSource2.Task;
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x000D0998 File Offset: 0x000CEB98
		internal Task<int> SendAsync(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			Socket.ValidateBuffersList(buffers);
			Socket.Int32TaskSocketAsyncEventArgs int32TaskSocketAsyncEventArgs = this.RentSocketAsyncEventArgs(false);
			if (int32TaskSocketAsyncEventArgs != null)
			{
				Socket.ConfigureBufferList(int32TaskSocketAsyncEventArgs, buffers, socketFlags);
				return this.GetTaskForSendReceive(this.SendAsync(int32TaskSocketAsyncEventArgs), int32TaskSocketAsyncEventArgs, false, false);
			}
			return this.SendAsyncApm(buffers, socketFlags);
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x000D09D8 File Offset: 0x000CEBD8
		private Task<int> SendAsyncApm(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
			this.BeginSend(buffers, socketFlags, delegate(IAsyncResult iar)
			{
				TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
				try
				{
					taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndSend(iar));
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			return taskCompletionSource.Task;
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x000D0A1C File Offset: 0x000CEC1C
		internal Task<int> SendToAsync(ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP)
		{
			TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
			this.BeginSendTo(buffer.Array, buffer.Offset, buffer.Count, socketFlags, remoteEP, delegate(IAsyncResult iar)
			{
				TaskCompletionSource<int> taskCompletionSource2 = (TaskCompletionSource<int>)iar.AsyncState;
				try
				{
					taskCompletionSource2.TrySetResult(((Socket)taskCompletionSource2.Task.AsyncState).EndSendTo(iar));
				}
				catch (Exception exception)
				{
					taskCompletionSource2.TrySetException(exception);
				}
			}, taskCompletionSource);
			return taskCompletionSource.Task;
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x000D0A74 File Offset: 0x000CEC74
		private static void ValidateBuffer(ArraySegment<byte> buffer)
		{
			if (buffer.Array == null)
			{
				throw new ArgumentNullException("Array");
			}
			if (buffer.Offset < 0 || buffer.Offset > buffer.Array.Length)
			{
				throw new ArgumentOutOfRangeException("Offset");
			}
			if (buffer.Count < 0 || buffer.Count > buffer.Array.Length - buffer.Offset)
			{
				throw new ArgumentOutOfRangeException("Count");
			}
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x000D0AEB File Offset: 0x000CECEB
		private static void ValidateBuffersList(IList<ArraySegment<byte>> buffers)
		{
			if (buffers == null)
			{
				throw new ArgumentNullException("buffers");
			}
			if (buffers.Count == 0)
			{
				throw new ArgumentException(SR.Format("The parameter {0} must contain one or more elements.", "buffers"), "buffers");
			}
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x000D0B20 File Offset: 0x000CED20
		private static void ConfigureBufferList(Socket.Int32TaskSocketAsyncEventArgs saea, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			if (!saea.MemoryBuffer.Equals(default(Memory<byte>)))
			{
				saea.SetBuffer(default(Memory<byte>));
			}
			saea.BufferList = buffers;
			saea.SocketFlags = socketFlags;
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x000D0B64 File Offset: 0x000CED64
		private Task<int> GetTaskForSendReceive(bool pending, Socket.Int32TaskSocketAsyncEventArgs saea, bool fromNetworkStream, bool isReceive)
		{
			Task<int> result;
			if (pending)
			{
				bool flag;
				result = saea.GetCompletionResponsibility(out flag).Task;
				if (flag)
				{
					this.ReturnSocketAsyncEventArgs(saea, isReceive);
				}
			}
			else
			{
				if (saea.SocketError == SocketError.Success)
				{
					int bytesTransferred = saea.BytesTransferred;
					if (bytesTransferred == 0 || (fromNetworkStream & !isReceive))
					{
						result = Socket.s_zeroTask;
					}
					else
					{
						result = Task.FromResult<int>(bytesTransferred);
					}
				}
				else
				{
					result = Task.FromException<int>(Socket.GetException(saea.SocketError, fromNetworkStream));
				}
				this.ReturnSocketAsyncEventArgs(saea, isReceive);
			}
			return result;
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x000D0BDC File Offset: 0x000CEDDC
		private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			SocketError socketError = saea.SocketError;
			Socket acceptSocket = saea.AcceptSocket;
			bool flag;
			AsyncTaskMethodBuilder<Socket> completionResponsibility = saea.GetCompletionResponsibility(out flag);
			if (flag)
			{
				s.ReturnSocketAsyncEventArgs(saea);
			}
			if (socketError == SocketError.Success)
			{
				completionResponsibility.SetResult(acceptSocket);
				return;
			}
			completionResponsibility.SetException(Socket.GetException(socketError, false));
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x000D0C24 File Offset: 0x000CEE24
		private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			SocketError socketError = saea.SocketError;
			int bytesTransferred = saea.BytesTransferred;
			bool wrapExceptionsInIOExceptions = saea._wrapExceptionsInIOExceptions;
			bool flag;
			AsyncTaskMethodBuilder<int> completionResponsibility = saea.GetCompletionResponsibility(out flag);
			if (flag)
			{
				s.ReturnSocketAsyncEventArgs(saea, isReceive);
			}
			if (socketError == SocketError.Success)
			{
				completionResponsibility.SetResult(bytesTransferred);
				return;
			}
			completionResponsibility.SetException(Socket.GetException(socketError, wrapExceptionsInIOExceptions));
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x000D0C78 File Offset: 0x000CEE78
		private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
		{
			Exception ex = new SocketException((int)error);
			if (!wrapExceptionsInIOExceptions)
			{
				return ex;
			}
			return new IOException(SR.Format("Unable to transfer data on the transport connection: {0}.", ex.Message), ex);
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x000D0CA8 File Offset: 0x000CEEA8
		private Socket.Int32TaskSocketAsyncEventArgs RentSocketAsyncEventArgs(bool isReceive)
		{
			Socket.CachedEventArgs cachedEventArgs = LazyInitializer.EnsureInitialized<Socket.CachedEventArgs>(ref this._cachedTaskEventArgs, () => new Socket.CachedEventArgs());
			Socket.Int32TaskSocketAsyncEventArgs int32TaskSocketAsyncEventArgs = isReceive ? Interlocked.Exchange<Socket.Int32TaskSocketAsyncEventArgs>(ref cachedEventArgs.TaskReceive, Socket.s_rentedInt32Sentinel) : Interlocked.Exchange<Socket.Int32TaskSocketAsyncEventArgs>(ref cachedEventArgs.TaskSend, Socket.s_rentedInt32Sentinel);
			if (int32TaskSocketAsyncEventArgs == Socket.s_rentedInt32Sentinel)
			{
				return null;
			}
			if (int32TaskSocketAsyncEventArgs == null)
			{
				int32TaskSocketAsyncEventArgs = new Socket.Int32TaskSocketAsyncEventArgs();
				int32TaskSocketAsyncEventArgs.Completed += (isReceive ? Socket.ReceiveCompletedHandler : Socket.SendCompletedHandler);
			}
			return int32TaskSocketAsyncEventArgs;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x000D0D30 File Offset: 0x000CEF30
		private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			saea._accessed = false;
			saea._builder = default(AsyncTaskMethodBuilder<int>);
			saea._wrapExceptionsInIOExceptions = false;
			if (isReceive)
			{
				Volatile.Write<Socket.Int32TaskSocketAsyncEventArgs>(ref this._cachedTaskEventArgs.TaskReceive, saea);
				return;
			}
			Volatile.Write<Socket.Int32TaskSocketAsyncEventArgs>(ref this._cachedTaskEventArgs.TaskSend, saea);
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x000D0D7D File Offset: 0x000CEF7D
		private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			saea.AcceptSocket = null;
			saea._accessed = false;
			saea._builder = default(AsyncTaskMethodBuilder<Socket>);
			Volatile.Write<Socket.TaskSocketAsyncEventArgs<Socket>>(ref this._cachedTaskEventArgs.TaskAccept, saea);
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x000D0DAC File Offset: 0x000CEFAC
		private void DisposeCachedTaskSocketAsyncEventArgs()
		{
			Socket.CachedEventArgs cachedTaskEventArgs = this._cachedTaskEventArgs;
			if (cachedTaskEventArgs != null)
			{
				Socket.TaskSocketAsyncEventArgs<Socket> taskSocketAsyncEventArgs = Interlocked.Exchange<Socket.TaskSocketAsyncEventArgs<Socket>>(ref cachedTaskEventArgs.TaskAccept, Socket.s_rentedSocketSentinel);
				if (taskSocketAsyncEventArgs != null)
				{
					taskSocketAsyncEventArgs.Dispose();
				}
				Socket.Int32TaskSocketAsyncEventArgs int32TaskSocketAsyncEventArgs = Interlocked.Exchange<Socket.Int32TaskSocketAsyncEventArgs>(ref cachedTaskEventArgs.TaskReceive, Socket.s_rentedInt32Sentinel);
				if (int32TaskSocketAsyncEventArgs != null)
				{
					int32TaskSocketAsyncEventArgs.Dispose();
				}
				Socket.Int32TaskSocketAsyncEventArgs int32TaskSocketAsyncEventArgs2 = Interlocked.Exchange<Socket.Int32TaskSocketAsyncEventArgs>(ref cachedTaskEventArgs.TaskSend, Socket.s_rentedInt32Sentinel);
				if (int32TaskSocketAsyncEventArgs2 != null)
				{
					int32TaskSocketAsyncEventArgs2.Dispose();
				}
				Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs = Interlocked.Exchange<Socket.AwaitableSocketAsyncEventArgs>(ref cachedTaskEventArgs.ValueTaskReceive, Socket.AwaitableSocketAsyncEventArgs.Reserved);
				if (awaitableSocketAsyncEventArgs != null)
				{
					awaitableSocketAsyncEventArgs.Dispose();
				}
				Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs2 = Interlocked.Exchange<Socket.AwaitableSocketAsyncEventArgs>(ref cachedTaskEventArgs.ValueTaskSend, Socket.AwaitableSocketAsyncEventArgs.Reserved);
				if (awaitableSocketAsyncEventArgs2 == null)
				{
					return;
				}
				awaitableSocketAsyncEventArgs2.Dispose();
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.Socket" />, используя указанный тип сокетов и протокол.</summary>
		/// <param name="socketType">Одно из значений <see cref="T:System.Net.Sockets.SocketType" />.</param>
		/// <param name="protocolType">Одно из значений <see cref="T:System.Net.Sockets.ProtocolType" />.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Сочетание параметров <paramref name="socketType" /> и <paramref name="protocolType" /> приводит к недопустимому сокету.</exception>
		// Token: 0x06003D3C RID: 15676 RVA: 0x000D0E4C File Offset: 0x000CF04C
		public Socket(SocketType socketType, ProtocolType protocolType) : this(AddressFamily.InterNetworkV6, socketType, protocolType)
		{
			this.DualMode = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.Socket" />, используя заданные семейство адресов, тип сокета и протокол.</summary>
		/// <param name="addressFamily">Одно из значений <see cref="T:System.Net.Sockets.AddressFamily" />.</param>
		/// <param name="socketType">Одно из значений <see cref="T:System.Net.Sockets.SocketType" />.</param>
		/// <param name="protocolType">Одно из значений <see cref="T:System.Net.Sockets.ProtocolType" />.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Сочетание параметров <paramref name="addressFamily" />, <paramref name="socketType" /> и <paramref name="protocolType" /> приводит к неработоспособному сокету.</exception>
		// Token: 0x06003D3D RID: 15677 RVA: 0x000D0E60 File Offset: 0x000CF060
		public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		{
			this.ReadSem = new SemaphoreSlim(1, 1);
			this.WriteSem = new SemaphoreSlim(1, 1);
			this.is_blocking = true;
			base..ctor();
			Socket.s_LoggingEnabled = Logging.On;
			bool flag = Socket.s_LoggingEnabled;
			Socket.InitializeSockets();
			int num;
			this.m_Handle = new SafeSocketHandle(Socket.Socket_icall(addressFamily, socketType, protocolType, out num), true);
			if (this.m_Handle.IsInvalid)
			{
				throw new SocketException();
			}
			this.addressFamily = addressFamily;
			this.socketType = socketType;
			this.protocolType = protocolType;
			IPProtectionLevel ipprotectionLevel = SettingsSectionInternal.Section.IPProtectionLevel;
			if (ipprotectionLevel != IPProtectionLevel.Unspecified)
			{
				this.SetIPProtectionLevel(ipprotectionLevel);
			}
			this.SocketDefaults();
			bool flag2 = Socket.s_LoggingEnabled;
		}

		/// <summary>Возвращает значение, указывающее, доступна ли на текущем узле поддержка протокола IPv4 и включена ли эта функция.</summary>
		/// <returns>Значение <see langword="true" />, если текущий узел поддерживает протокол IPv4; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x000D0F0F File Offset: 0x000CF10F
		[Obsolete("SupportsIPv4 is obsoleted for this type, please use OSSupportsIPv4 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static bool SupportsIPv4
		{
			get
			{
				Socket.InitializeSockets();
				return Socket.s_SupportsIPv4;
			}
		}

		/// <summary>Указывает, поддерживают ли основная операционная система и сетевые адаптеры протокол IPv4.</summary>
		/// <returns>Значение <see langword="true" />, если основная операционная система и сетевые адаптеры поддерживают протокол IPv4; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06003D3F RID: 15679 RVA: 0x000D0F0F File Offset: 0x000CF10F
		public static bool OSSupportsIPv4
		{
			get
			{
				Socket.InitializeSockets();
				return Socket.s_SupportsIPv4;
			}
		}

		/// <summary>Получает значение, указывающее, поддерживает ли Framework протокол IPv6 для определенных устаревших членов <see cref="T:System.Net.Dns" />.</summary>
		/// <returns>Значение <see langword="true" />, если Framework поддерживает протокол IPv6 для определенных устаревших методов <see cref="T:System.Net.Dns" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x000D0F1D File Offset: 0x000CF11D
		[Obsolete("SupportsIPv6 is obsoleted for this type, please use OSSupportsIPv6 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static bool SupportsIPv6
		{
			get
			{
				Socket.InitializeSockets();
				return Socket.s_SupportsIPv6;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x000D0F1D File Offset: 0x000CF11D
		internal static bool LegacySupportsIPv6
		{
			get
			{
				Socket.InitializeSockets();
				return Socket.s_SupportsIPv6;
			}
		}

		/// <summary>Указывает, поддерживают ли основная операционная система и сетевые адаптеры протокол IPv6.</summary>
		/// <returns>Значение <see langword="true" />, если основная операционная система и сетевые адаптеры поддерживают протокол IPv6; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06003D42 RID: 15682 RVA: 0x000D0F2B File Offset: 0x000CF12B
		public static bool OSSupportsIPv6
		{
			get
			{
				Socket.InitializeSockets();
				return Socket.s_OSSupportsIPv6;
			}
		}

		/// <summary>Возвращает дескриптор операционной системы для объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Объект <see cref="T:System.IntPtr" />, представляющий дескриптор операционной системы для <see cref="T:System.Net.Sockets.Socket" />.</returns>
		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x000D0F39 File Offset: 0x000CF139
		public IntPtr Handle
		{
			get
			{
				return this.m_Handle.DangerousGetHandle();
			}
		}

		/// <summary>Указывает, должен ли сокет использовать только режим ввода-вывода Overlapped.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> использует только режим перекрывающего ввода-вывода; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Сокет привязан к порту завершения.</exception>
		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06003D44 RID: 15684 RVA: 0x000D0F46 File Offset: 0x000CF146
		// (set) Token: 0x06003D45 RID: 15685 RVA: 0x000D0F4E File Offset: 0x000CF14E
		public bool UseOnlyOverlappedIO
		{
			get
			{
				return this.useOverlappedIO;
			}
			set
			{
				this.useOverlappedIO = value;
			}
		}

		/// <summary>Получает семейство адресов объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Net.Sockets.AddressFamily" />.</returns>
		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06003D46 RID: 15686 RVA: 0x000D0F57 File Offset: 0x000CF157
		public AddressFamily AddressFamily
		{
			get
			{
				return this.addressFamily;
			}
		}

		/// <summary>Возвращает тип службы <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Net.Sockets.SocketType" />.</returns>
		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x000D0F5F File Offset: 0x000CF15F
		public SocketType SocketType
		{
			get
			{
				return this.socketType;
			}
		}

		/// <summary>Получает тип протокола объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Net.Sockets.ProtocolType" />.</returns>
		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003D48 RID: 15688 RVA: 0x000D0F67 File Offset: 0x000CF167
		public ProtocolType ProtocolType
		{
			get
			{
				return this.protocolType;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, разрешает ли объект <see cref="T:System.Net.Sockets.Socket" /> привязку к порту только одного процесса.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> разрешает привязку только одного сокета к определенному порту; в противном случае — значение <see langword="false" />. По умолчанию используется <see langword="true" /> для Windows Server 2003 и Windows XP с пакетом обновления 2 и <see langword="false" /> для всех остальных версий.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> вызван для этого объекта <see cref="T:System.Net.Sockets.Socket" />.</exception>
		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x000D0F6F File Offset: 0x000CF16F
		// (set) Token: 0x06003D4A RID: 15690 RVA: 0x000D0F88 File Offset: 0x000CF188
		public bool ExclusiveAddressUse
		{
			get
			{
				return (int)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse) != 0;
			}
			set
			{
				if (this.IsBound)
				{
					throw new InvalidOperationException(SR.GetString("The socket must not be bound or connected."));
				}
				this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, value ? 1 : 0);
			}
		}

		/// <summary>Получает или задает значение, задающее размер приемного буфера объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, который содержит значение размера приемного буфера в байтах. Значение по умолчанию — 8192.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции установки, меньше 0.</exception>
		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x000D0FB6 File Offset: 0x000CF1B6
		// (set) Token: 0x06003D4C RID: 15692 RVA: 0x000D0FCD File Offset: 0x000CF1CD
		public int ReceiveBufferSize
		{
			get
			{
				return (int)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer);
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, value);
			}
		}

		/// <summary>Получает или задает значение, определяющее размер буфера передачи объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, который содержит значение размера буфера передачи в байтах. Значение по умолчанию — 8192.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции установки, меньше 0.</exception>
		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x000D0FEF File Offset: 0x000CF1EF
		// (set) Token: 0x06003D4E RID: 15694 RVA: 0x000D1006 File Offset: 0x000CF206
		public int SendBufferSize
		{
			get
			{
				return (int)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer);
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, value);
			}
		}

		/// <summary>Получает или устанавливает значение, указывающее промежуток времени, после которого для синхронного вызова <see cref="Overload:System.Net.Sockets.Socket.Receive" /> истечет время тайм-аута.</summary>
		/// <returns>Значение времени ожидания в миллисекундах. По умолчанию используется значение 0, указывающее на бесконечное значение интервала для тайм-аута Задание значения -1 также указывает на бесконечное значение интервала для тайм-аута.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции задания, меньше –1.</exception>
		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x000D1028 File Offset: 0x000CF228
		// (set) Token: 0x06003D50 RID: 15696 RVA: 0x000D103F File Offset: 0x000CF23F
		public int ReceiveTimeout
		{
			get
			{
				return (int)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (value == -1)
				{
					value = 0;
				}
				this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, value);
			}
		}

		/// <summary>Получает или устанавливает значение, указывающее промежуток времени, после которого для синхронного вызова <see cref="Overload:System.Net.Sockets.Socket.Send" /> истечет время тайм-аута.</summary>
		/// <returns>Значение времени ожидания в миллисекундах. Если для этого свойства задать значение от 1 до 499, значение будет изменено на 500. По умолчанию используется значение 0, указывающее на бесконечное значение интервала для тайм-аута Задание значения -1 также указывает на бесконечное значение интервала для тайм-аута.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции задания, меньше –1.</exception>
		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x000D1068 File Offset: 0x000CF268
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x000D107F File Offset: 0x000CF27F
		public int SendTimeout
		{
			get
			{
				return (int)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (value == -1)
				{
					value = 0;
				}
				this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, value);
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, будет ли объект <see cref="T:System.Net.Sockets.Socket" /> задерживать закрытие сокета при попытке отправки всех отложенных данных.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.LingerOption" />, указывающий задержку при закрытии сокета.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x000D10A8 File Offset: 0x000CF2A8
		// (set) Token: 0x06003D54 RID: 15700 RVA: 0x000D10BF File Offset: 0x000CF2BF
		public LingerOption LingerState
		{
			get
			{
				return (LingerOption)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger);
			}
			set
			{
				this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, value);
			}
		}

		/// <summary>Получает или задает значение, задающее время существования (TTL) IP-пакетов, отправленных объектом <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Значение времени существования TTL.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">В качестве величины срока жизни нельзя задать отрицательное число.</exception>
		/// <exception cref="T:System.NotSupportedException">Это свойство может быть установлено только для сокетов в семействах <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. Эта ошибка также возвращается при попытке задать срок жизни больше, чем 255.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06003D55 RID: 15701 RVA: 0x000D10D4 File Offset: 0x000CF2D4
		// (set) Token: 0x06003D56 RID: 15702 RVA: 0x000D1124 File Offset: 0x000CF324
		public short Ttl
		{
			get
			{
				if (this.addressFamily == AddressFamily.InterNetwork)
				{
					return (short)((int)this.GetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress));
				}
				if (this.addressFamily == AddressFamily.InterNetworkV6)
				{
					return (short)((int)this.GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.ReuseAddress));
				}
				throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
			}
			set
			{
				if (value < 0 || value > 255)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (this.addressFamily == AddressFamily.InterNetwork)
				{
					this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, (int)value);
					return;
				}
				if (this.addressFamily == AddressFamily.InterNetworkV6)
				{
					this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.ReuseAddress, (int)value);
					return;
				}
				throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, разрешает ли объект <see cref="T:System.Net.Sockets.Socket" /> выполнение фрагментации датаграмм протокола IP.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> разрешает фрагментацию датаграмм; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Это свойство может быть установлено только для сокетов в семействах <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x000D117F File Offset: 0x000CF37F
		// (set) Token: 0x06003D58 RID: 15704 RVA: 0x000D11AD File Offset: 0x000CF3AD
		public bool DontFragment
		{
			get
			{
				if (this.addressFamily == AddressFamily.InterNetwork)
				{
					return (int)this.GetSocketOption(SocketOptionLevel.IP, SocketOptionName.DontFragment) != 0;
				}
				throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
			}
			set
			{
				if (this.addressFamily == AddressFamily.InterNetwork)
				{
					this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.DontFragment, value ? 1 : 0);
					return;
				}
				throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, является ли <see cref="T:System.Net.Sockets.Socket" /> сокетом с двойным режимом, используемым для IPv4 и IPv6.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Net.Sockets.Socket" /> — сокет с двойным режимом. В противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x000D11D8 File Offset: 0x000CF3D8
		// (set) Token: 0x06003D5A RID: 15706 RVA: 0x000D1206 File Offset: 0x000CF406
		public bool DualMode
		{
			get
			{
				if (this.AddressFamily != AddressFamily.InterNetworkV6)
				{
					throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
				}
				return (int)this.GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only) == 0;
			}
			set
			{
				if (this.AddressFamily != AddressFamily.InterNetworkV6)
				{
					throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
				}
				this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, value ? 0 : 1);
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x000D1233 File Offset: 0x000CF433
		private bool IsDualMode
		{
			get
			{
				return this.AddressFamily == AddressFamily.InterNetworkV6 && this.DualMode;
			}
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x000D1247 File Offset: 0x000CF447
		internal bool CanTryAddressFamily(AddressFamily family)
		{
			return family == this.addressFamily || (family == AddressFamily.InterNetwork && this.IsDualMode);
		}

		/// <summary>Устанавливает подключение к удаленному узлу. Узел задается массивом IP-адресов и номером порта.</summary>
		/// <param name="addresses">IP-адрес удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="addresses" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод допустим для сокетов в семействах <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="address" /> равна нулю.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сокет <see cref="T:System.Net.Sockets.Socket" /> был переведен в состояние прослушивания путем вызова <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />.</exception>
		// Token: 0x06003D5D RID: 15709 RVA: 0x000D1260 File Offset: 0x000CF460
		public void Connect(IPAddress[] addresses, int port)
		{
			bool flag = Socket.s_LoggingEnabled;
			if (this.CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (addresses == null)
			{
				throw new ArgumentNullException("addresses");
			}
			if (addresses.Length == 0)
			{
				throw new ArgumentException(SR.GetString("The number of specified IP addresses has to be greater than 0."), "addresses");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			if (this.addressFamily != AddressFamily.InterNetwork && this.addressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
			}
			Exception ex = null;
			foreach (IPAddress ipaddress in addresses)
			{
				if (this.CanTryAddressFamily(ipaddress.AddressFamily))
				{
					try
					{
						this.Connect(new IPEndPoint(ipaddress, port));
						ex = null;
						break;
					}
					catch (Exception ex2)
					{
						if (NclUtilities.IsFatal(ex2))
						{
							throw;
						}
						ex = ex2;
					}
				}
			}
			if (ex != null)
			{
				throw ex;
			}
			if (!this.Connected)
			{
				throw new ArgumentException(SR.GetString("None of the discovered or specified addresses match the socket address family."), "addresses");
			}
			bool flag2 = Socket.s_LoggingEnabled;
		}

		/// <summary>Посылает указанное число байтов данных на подключенный объект <see cref="T:System.Net.Sockets.Socket" />, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <param name="size">Количество байтов для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Количество байтов, отправленных в <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="size" /> меньше 0 или превышает размер буфера.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Сбой операционной системы при доступе к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D5E RID: 15710 RVA: 0x000D1368 File Offset: 0x000CF568
		public int Send(byte[] buffer, int size, SocketFlags socketFlags)
		{
			return this.Send(buffer, 0, size, socketFlags);
		}

		/// <summary>Передает данные в подключенный объект <see cref="T:System.Net.Sockets.Socket" />, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Количество байтов, отправленных в <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D5F RID: 15711 RVA: 0x000D1374 File Offset: 0x000CF574
		public int Send(byte[] buffer, SocketFlags socketFlags)
		{
			return this.Send(buffer, 0, (buffer != null) ? buffer.Length : 0, socketFlags);
		}

		/// <summary>Передает данные в подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <returns>Количество байтов, отправленных в <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D60 RID: 15712 RVA: 0x000D1388 File Offset: 0x000CF588
		public int Send(byte[] buffer)
		{
			return this.Send(buffer, 0, (buffer != null) ? buffer.Length : 0, SocketFlags.None);
		}

		/// <summary>Отправляет набор буферов в список на подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffers">Список объектов <see cref="T:System.ArraySegment`1" /> типа <see cref="T:System.Byte" />, содержащих данные для отправки.</param>
		/// <returns>Количество байтов, отправленных в <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffers" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="buffers" /> пуст.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. ниже примeчания к данному разделу.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D61 RID: 15713 RVA: 0x000D139C File Offset: 0x000CF59C
		public int Send(IList<ArraySegment<byte>> buffers)
		{
			return this.Send(buffers, SocketFlags.None);
		}

		/// <summary>Отправляет набор буферов в список на подключенный объект <see cref="T:System.Net.Sockets.Socket" />, используя указанный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffers">Список объектов <see cref="T:System.ArraySegment`1" /> типа <see cref="T:System.Byte" />, содержащих данные для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Количество байтов, отправленных в <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffers" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="buffers" /> пуст.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D62 RID: 15714 RVA: 0x000D13A8 File Offset: 0x000CF5A8
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			SocketError socketError;
			int result = this.Send(buffers, socketFlags, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Отправляет файл <paramref name="fileName" /> на подключенный объект <see cref="T:System.Net.Sockets.Socket" />, используя флаг передачи <see cref="F:System.Net.Sockets.TransmitFileOptions.UseDefaultWorkerThread" />.</summary>
		/// <param name="fileName">Параметр типа <see cref="T:System.String" />, содержащий имя отправляемого файла и путь к нему. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">Сокет не подключен к удаленному узлу.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Net.Sockets.Socket" /> не находится в режиме блокировки и не может принять этот синхронный вызов.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="fileName" /> не найден.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003D63 RID: 15715 RVA: 0x000D13C9 File Offset: 0x000CF5C9
		public void SendFile(string fileName)
		{
			this.SendFile(fileName, null, null, TransmitFileOptions.UseDefaultWorkerThread);
		}

		/// <summary>Отправляет указанное количество байтов данных в подключенный <see cref="T:System.Net.Sockets.Socket" />, начиная с заданного смещения и используя заданный параметр <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <param name="offset">Положение в буфере данных, с которого начинается отправка данных.</param>
		/// <param name="size">Количество байтов для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Количество байтов, отправленных в <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Произошла ошибка операционной системы при доступе к <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D64 RID: 15716 RVA: 0x000D13D8 File Offset: 0x000CF5D8
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			SocketError socketError;
			int result = this.Send(buffer, offset, size, socketFlags, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Посылает указанное число байтов данных на указанную конечную точку, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <param name="size">Количество байтов для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий пункт назначения для данных.</param>
		/// <returns>Число отправленных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Заданное значение <paramref name="size" /> превышает размер параметра <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D65 RID: 15717 RVA: 0x000D13FC File Offset: 0x000CF5FC
		public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return this.SendTo(buffer, 0, size, socketFlags, remoteEP);
		}

		/// <summary>Передает данные на указанную конечную точку, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий пункт назначения для данных.</param>
		/// <returns>Число отправленных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D66 RID: 15718 RVA: 0x000D140A File Offset: 0x000CF60A
		public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return this.SendTo(buffer, 0, (buffer != null) ? buffer.Length : 0, socketFlags, remoteEP);
		}

		/// <summary>Посылает данные на указанную конечную точку.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий пункт назначения для данных.</param>
		/// <returns>Число отправленных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D67 RID: 15719 RVA: 0x000D141F File Offset: 0x000CF61F
		public int SendTo(byte[] buffer, EndPoint remoteEP)
		{
			return this.SendTo(buffer, 0, (buffer != null) ? buffer.Length : 0, SocketFlags.None, remoteEP);
		}

		/// <summary>Получает указанное число байтов данных из связанного объекта <see cref="T:System.Net.Sockets.Socket" /> в приемный буфер, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="size" /> превышает размер параметра <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003D68 RID: 15720 RVA: 0x000D1434 File Offset: 0x000CF634
		public int Receive(byte[] buffer, int size, SocketFlags socketFlags)
		{
			return this.Receive(buffer, 0, size, socketFlags);
		}

		/// <summary>Получает данные из связанного объекта <see cref="T:System.Net.Sockets.Socket" /> в приемный буфер, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003D69 RID: 15721 RVA: 0x000D1440 File Offset: 0x000CF640
		public int Receive(byte[] buffer, SocketFlags socketFlags)
		{
			return this.Receive(buffer, 0, (buffer != null) ? buffer.Length : 0, socketFlags);
		}

		/// <summary>Возвращает данные из связанного объекта <see cref="T:System.Net.Sockets.Socket" /> в приемный буфер.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003D6A RID: 15722 RVA: 0x000D1454 File Offset: 0x000CF654
		public int Receive(byte[] buffer)
		{
			return this.Receive(buffer, 0, (buffer != null) ? buffer.Length : 0, SocketFlags.None);
		}

		/// <summary>Получает указанное число байтов данных из связанного объекта <see cref="T:System.Net.Sockets.Socket" /> в приемный буфер с указанной позиции смещения, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив объекта типа <see cref="T:System.Byte" />, который является местом хранения полученных данных.</param>
		/// <param name="offset">Место в объекте <paramref name="buffer" />, выделенное для хранения принимаемых данных.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Свойство <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> не задано.  
		/// -или- 
		/// Произошла ошибка операционной системы при доступе к <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003D6B RID: 15723 RVA: 0x000D1468 File Offset: 0x000CF668
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			SocketError socketError;
			int result = this.Receive(buffer, offset, size, socketFlags, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Получает данные из связанного объекта <see cref="T:System.Net.Sockets.Socket" /> в список приемных буферов.</summary>
		/// <param name="buffers">Список объектов <see cref="T:System.ArraySegment`1" /> типа <see cref="T:System.Byte" />, содержащих полученные данные.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D6C RID: 15724 RVA: 0x000D148C File Offset: 0x000CF68C
		public int Receive(IList<ArraySegment<byte>> buffers)
		{
			return this.Receive(buffers, SocketFlags.None);
		}

		/// <summary>Получает данные из связанного объекта <see cref="T:System.Net.Sockets.Socket" /> в список приемных буферов, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffers">Список объектов <see cref="T:System.ArraySegment`1" /> типа <see cref="T:System.Byte" />, содержащих полученные данные.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffers" /> — <see langword="null" />.  
		/// -или- 
		///  Значение <paramref name="buffers" />. Отсчет равен нулю.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D6D RID: 15725 RVA: 0x000D1498 File Offset: 0x000CF698
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			SocketError socketError;
			int result = this.Receive(buffers, socketFlags, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Получает указанное число байтов во входной буфер, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />, и сохраняет конечную точку.</summary>
		/// <param name="buffer">Массив объекта типа <see cref="T:System.Byte" />, который является местом хранения полученных данных.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Переданный по ссылке объект <see cref="T:System.Net.EndPoint" />, представляющий удаленный сервер.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает длину <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Свойство <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> не задано.  
		/// -или- 
		/// Произошла ошибка операционной системы при доступе к <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003D6E RID: 15726 RVA: 0x000D14B9 File Offset: 0x000CF6B9
		public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return this.ReceiveFrom(buffer, 0, size, socketFlags, ref remoteEP);
		}

		/// <summary>Принимает датаграмму в буфер данных, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />, и сохраняет конечную точку.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Переданный по ссылке объект <see cref="T:System.Net.EndPoint" />, представляющий удаленный сервер.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003D6F RID: 15727 RVA: 0x000D14C7 File Offset: 0x000CF6C7
		public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return this.ReceiveFrom(buffer, 0, (buffer != null) ? buffer.Length : 0, socketFlags, ref remoteEP);
		}

		/// <summary>Принимает датаграмму в буфер данных и сохраняет конечную точку.</summary>
		/// <param name="buffer">Массив объекта типа <see cref="T:System.Byte" />, который является местом хранения полученных данных.</param>
		/// <param name="remoteEP">Переданный по ссылке объект <see cref="T:System.Net.EndPoint" />, представляющий удаленный сервер.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003D70 RID: 15728 RVA: 0x000D14DC File Offset: 0x000CF6DC
		public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP)
		{
			return this.ReceiveFrom(buffer, 0, (buffer != null) ? buffer.Length : 0, SocketFlags.None, ref remoteEP);
		}

		/// <summary>Задает низкоуровневые операционные режимы для объекта <see cref="T:System.Net.Sockets.Socket" />, используя перечисление <see cref="T:System.Net.Sockets.IOControlCode" />, чтобы указать коды элементов управления.</summary>
		/// <param name="ioControlCode">Значение <see cref="T:System.Net.Sockets.IOControlCode" />, задающее код элемента управления для выполняемой операции.</param>
		/// <param name="optionInValue">Массив типа <see cref="T:System.Byte" />, который содержит входные данные, необходимые для операции.</param>
		/// <param name="optionOutValue">Массив типа <see cref="T:System.Byte" />, который содержит выходные данные, возвращенные операцией.</param>
		/// <returns>Число байтов в параметре <paramref name="optionOutValue" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Была сделана попытка изменения блокирующего режима без использования свойства <see cref="P:System.Net.Sockets.Socket.Blocking" />.</exception>
		// Token: 0x06003D71 RID: 15729 RVA: 0x000D14F1 File Offset: 0x000CF6F1
		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return this.IOControl((int)ioControlCode, optionInValue, optionOutValue);
		}

		/// <summary>Задается стандартный уровень защиты IP для сокета.</summary>
		/// <param name="level">Уровень защиты IP, который надо установить для сокета.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="level" /> не может иметь значение <see cref="F:System.Net.Sockets.IPProtectionLevel.Unspecified" />. Уровень защиты IP не может быть неопределенным.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <see cref="T:System.Net.Sockets.AddressFamily" /> сокета должен быть либо <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />, либо <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />.</exception>
		// Token: 0x06003D72 RID: 15730 RVA: 0x000D1500 File Offset: 0x000CF700
		public void SetIPProtectionLevel(IPProtectionLevel level)
		{
			if (level == IPProtectionLevel.Unspecified)
			{
				throw new ArgumentException(SR.GetString("The specified value is not valid."), "level");
			}
			if (this.addressFamily == AddressFamily.InterNetworkV6)
			{
				this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPProtectionLevel, (int)level);
				return;
			}
			if (this.addressFamily == AddressFamily.InterNetwork)
			{
				this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.IPProtectionLevel, (int)level);
				return;
			}
			throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
		}

		/// <summary>Отправляет файл <paramref name="fileName" /> на подключенный объект <see cref="T:System.Net.Sockets.Socket" />, используя флаг <see cref="F:System.Net.Sockets.TransmitFileOptions.UseDefaultWorkerThread" />.</summary>
		/// <param name="fileName">Строка, содержащая путь и имя отправляемого файла. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который представляет асинхронную передачу.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Сокет не подключен к удаленному узлу.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="fileName" /> не найден.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. ниже примeчания к данному разделу.</exception>
		// Token: 0x06003D73 RID: 15731 RVA: 0x000D155F File Offset: 0x000CF75F
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginSendFile(string fileName, AsyncCallback callback, object state)
		{
			return this.BeginSendFile(fileName, null, null, TransmitFileOptions.UseDefaultWorkerThread, callback, state);
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу. Узел задается объектом <see cref="T:System.Net.IPAddress" /> и номером порта.</summary>
		/// <param name="address">Адрес <see cref="T:System.Net.IPAddress" /> удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении операции подключения.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции подключения. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное подключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Net.Sockets.Socket" /> не входит в семейство сокетов.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="address" /> равна нулю.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сокет <see cref="T:System.Net.Sockets.Socket" /> был переведен в состояние прослушивания путем вызова <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />, либо асинхронная операция уже выполняется.</exception>
		// Token: 0x06003D74 RID: 15732 RVA: 0x000D1570 File Offset: 0x000CF770
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
		{
			bool flag = Socket.s_LoggingEnabled;
			if (this.CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			if (!this.CanTryAddressFamily(address.AddressFamily))
			{
				throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
			}
			IAsyncResult result = this.BeginConnect(new IPEndPoint(address, port), requestCallback, state);
			bool flag2 = Socket.s_LoggingEnabled;
			return result;
		}

		/// <summary>Выполняет асинхронную передачу данных на подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который содержит передаваемые данные.</param>
		/// <param name="offset">Отсчитываемая с нуля позиция в параметре <paramref name="buffer" />, с которой начинается отправка данных.</param>
		/// <param name="size">Количество байтов для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную передачу.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. ниже примeчания к данному разделу.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="offset" /> меньше значения длины, указанного в параметре <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D75 RID: 15733 RVA: 0x000D15F8 File Offset: 0x000CF7F8
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			SocketError socketError;
			IAsyncResult result = this.BeginSend(buffer, offset, size, socketFlags, out socketError, callback, state);
			if (socketError != SocketError.Success && socketError != SocketError.IOPending)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Выполняет асинхронную передачу данных на подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffers">Массив типа <see cref="T:System.Byte" />, который содержит передаваемые данные.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную передачу.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffers" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="buffers" /> пуст.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. ниже примeчания к данному разделу.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D76 RID: 15734 RVA: 0x000D1628 File Offset: 0x000CF828
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			SocketError socketError;
			IAsyncResult result = this.BeginSend(buffers, socketFlags, out socketError, callback, state);
			if (socketError != SocketError.Success && socketError != SocketError.IOPending)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Завершает отложенную операцию асинхронной передачи.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, хранящий сведения о состоянии этой асинхронной операции.</param>
		/// <returns>Если операция завершилась успешно — значение количества байтов, переданных в объект <see cref="T:System.Net.Sockets.Socket" />; в противном случае — ошибка, указывающая на недопустимость объекта <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> был ранее вызван для асинхронной передачи.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D77 RID: 15735 RVA: 0x000D1654 File Offset: 0x000CF854
		public int EndSend(IAsyncResult asyncResult)
		{
			SocketError socketError;
			int result = this.EndSend(asyncResult, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Начинает выполнение асинхронного приема данных с подключенного объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="offset">Отсчитываемая с нуля позиция в параметре <paramref name="buffer" />, начиная с которой хранятся принятые данные.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции приема. Этот объект передается делегату <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное чтение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		// Token: 0x06003D78 RID: 15736 RVA: 0x000D1674 File Offset: 0x000CF874
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			SocketError socketError;
			IAsyncResult result = this.BeginReceive(buffer, offset, size, socketFlags, out socketError, callback, state);
			if (socketError != SocketError.Success && socketError != SocketError.IOPending)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Начинает выполнение асинхронного приема данных с подключенного объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffers">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции приема. Этот объект передается делегату <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное чтение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		// Token: 0x06003D79 RID: 15737 RVA: 0x000D16A4 File Offset: 0x000CF8A4
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			SocketError socketError;
			IAsyncResult result = this.BeginReceive(buffers, socketFlags, out socketError, callback, state);
			if (socketError != SocketError.Success && socketError != SocketError.IOPending)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Завершает отложенное асинхронное чтение.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии и любые данные, определенные пользователем, для этой асинхронной операции.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> был ранее вызван для асинхронного чтения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003D7A RID: 15738 RVA: 0x000D16D0 File Offset: 0x000CF8D0
		public int EndReceive(IAsyncResult asyncResult)
		{
			SocketError socketError;
			int result = this.EndReceive(asyncResult, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Начинает асинхронную операцию, чтобы принять попытку входящего подключения и получить первый блок данных, посланных клиентским приложением.</summary>
		/// <param name="receiveSize">Число байтов, которые необходимо принять от отправителя.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное создание объекта <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows NT.</exception>
		/// <exception cref="T:System.InvalidOperationException">Принимающий сокет не производит прослушивание подключений. Необходимо вызвать <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> и <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> до вызова объекта <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.  
		/// -или- 
		/// Производится связывание принимающего сокета.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="receiveSize" /> меньше 0.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003D7B RID: 15739 RVA: 0x000D16F0 File Offset: 0x000CF8F0
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginAccept(int receiveSize, AsyncCallback callback, object state)
		{
			return this.BeginAccept(null, receiveSize, callback, state);
		}

		/// <summary>Асинхронно принимает входящие попытки подключения и создает новый объект <see cref="T:System.Net.Sockets.Socket" /> для связи с удаленным узлом. Этот метод возвращает буфер, который содержит начальные данные для передачи.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который содержит переданные байты.</param>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии для этой асинхронной операции, а также любые данные, определенные пользователем.</param>
		/// <returns>Объект <see cref="T:System.Net.Sockets.Socket" /> для связи с удаленным узлом.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows NT.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="asyncResult" /> пуст.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Ранее был вызван метод <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к объекту <see cref="T:System.Net.Sockets.Socket" />.</exception>
		// Token: 0x06003D7C RID: 15740 RVA: 0x000D16FC File Offset: 0x000CF8FC
		public Socket EndAccept(out byte[] buffer, IAsyncResult asyncResult)
		{
			byte[] sourceArray;
			int num;
			Socket result = this.EndAccept(out sourceArray, out num, asyncResult);
			buffer = new byte[num];
			Array.Copy(sourceArray, buffer, num);
			return result;
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x000D1728 File Offset: 0x000CF928
		private static object InternalSyncObject
		{
			get
			{
				if (Socket.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange(ref Socket.s_InternalSyncObject, value, null);
				}
				return Socket.s_InternalSyncObject;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06003D7E RID: 15742 RVA: 0x000D1754 File Offset: 0x000CF954
		internal bool CleanedUp
		{
			get
			{
				return this.m_IntCleanedUp == 1;
			}
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x000D1760 File Offset: 0x000CF960
		internal static void InitializeSockets()
		{
			if (!Socket.s_Initialized)
			{
				object internalSyncObject = Socket.InternalSyncObject;
				lock (internalSyncObject)
				{
					if (!Socket.s_Initialized)
					{
						bool flag2 = Socket.IsProtocolSupported(NetworkInterfaceComponent.IPv4);
						bool flag3 = Socket.IsProtocolSupported(NetworkInterfaceComponent.IPv6);
						if (flag3)
						{
							Socket.s_OSSupportsIPv6 = true;
							flag3 = SettingsSectionInternal.Section.Ipv6Enabled;
						}
						Socket.s_SupportsIPv4 = flag2;
						Socket.s_SupportsIPv6 = flag3;
						Socket.s_Initialized = true;
					}
				}
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x06003D80 RID: 15744 RVA: 0x000D17E8 File Offset: 0x000CF9E8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает ресурсы, используемые классом <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x06003D81 RID: 15745 RVA: 0x000D17F8 File Offset: 0x000CF9F8
		~Socket()
		{
			this.Dispose(false);
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу.</summary>
		/// <param name="socketType">Одно из значений <see cref="T:System.Net.Sockets.SocketType" />.</param>
		/// <param name="protocolType">Одно из значений <see cref="T:System.Net.Sockets.ProtocolType" />.</param>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент является недопустимым. Это исключение возникает, если задано несколько буферов, свойство <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> не имеет значение "null".</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> и <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> не могут иметь значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="T:System.Net.Sockets.Socket" /> ведет прослушивание или работа с сокетом уже выполняется с использованием объекта <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, указанного параметром <paramref name="e" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях. Это исключение возникает также в том случае, если локальная конечная точка и объект <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> не принадлежат к одному семейству адресов.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		// Token: 0x06003D82 RID: 15746 RVA: 0x000D1828 File Offset: 0x000CFA28
		public static bool ConnectAsync(SocketType socketType, ProtocolType protocolType, SocketAsyncEventArgs e)
		{
			bool flag = Socket.s_LoggingEnabled;
			if (e.BufferList != null)
			{
				throw new ArgumentException(SR.GetString("Multiple buffers cannot be used with this method."), "BufferList");
			}
			if (e.RemoteEndPoint == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			EndPoint remoteEndPoint = e.RemoteEndPoint;
			DnsEndPoint dnsEndPoint = remoteEndPoint as DnsEndPoint;
			bool result;
			if (dnsEndPoint != null)
			{
				Socket socket = null;
				MultipleConnectAsync multipleConnectAsync;
				if (dnsEndPoint.AddressFamily == AddressFamily.Unspecified)
				{
					multipleConnectAsync = new DualSocketMultipleConnectAsync(socketType, protocolType);
				}
				else
				{
					socket = new Socket(dnsEndPoint.AddressFamily, socketType, protocolType);
					multipleConnectAsync = new SingleSocketMultipleConnectAsync(socket, false);
				}
				e.StartOperationCommon(socket);
				e.StartOperationWrapperConnect(multipleConnectAsync);
				try
				{
					result = multipleConnectAsync.StartConnectAsync(e, dnsEndPoint);
					goto IL_B7;
				}
				catch
				{
					Interlocked.Exchange(ref e.in_progress, 0);
					throw;
				}
			}
			result = new Socket(remoteEndPoint.AddressFamily, socketType, protocolType).ConnectAsync(e);
			IL_B7:
			bool flag2 = Socket.s_LoggingEnabled;
			return result;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x000D1908 File Offset: 0x000CFB08
		internal void InternalShutdown(SocketShutdown how)
		{
			if (!this.is_connected || this.CleanedUp)
			{
				return;
			}
			int num;
			Socket.Shutdown_internal(this.m_Handle, how, out num);
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x000D1934 File Offset: 0x000CFB34
		internal IAsyncResult UnsafeBeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
		{
			return this.BeginConnect(remoteEP, callback, state);
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x000D193F File Offset: 0x000CFB3F
		internal IAsyncResult UnsafeBeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			return this.BeginSend(buffer, offset, size, socketFlags, callback, state);
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x000D1950 File Offset: 0x000CFB50
		internal IAsyncResult UnsafeBeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			return this.BeginReceive(buffer, offset, size, socketFlags, callback, state);
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x000D1964 File Offset: 0x000CFB64
		internal IAsyncResult BeginMultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			ArraySegment<byte>[] array = new ArraySegment<byte>[buffers.Length];
			for (int i = 0; i < buffers.Length; i++)
			{
				array[i] = new ArraySegment<byte>(buffers[i].Buffer, buffers[i].Offset, buffers[i].Size);
			}
			return this.BeginSend(array, socketFlags, callback, state);
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x000D19B7 File Offset: 0x000CFBB7
		internal IAsyncResult UnsafeBeginMultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			return this.BeginMultipleSend(buffers, socketFlags, callback, state);
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x000D19C4 File Offset: 0x000CFBC4
		internal int EndMultipleSend(IAsyncResult asyncResult)
		{
			return this.EndSend(asyncResult);
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x000D19D0 File Offset: 0x000CFBD0
		internal void MultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags)
		{
			ArraySegment<byte>[] array = new ArraySegment<byte>[buffers.Length];
			for (int i = 0; i < buffers.Length; i++)
			{
				array[i] = new ArraySegment<byte>(buffers[i].Buffer, buffers[i].Offset, buffers[i].Size);
			}
			this.Send(array, socketFlags);
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x000D1A24 File Offset: 0x000CFC24
		internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
			if (this.CleanedUp && this.is_closed)
			{
				if (silent)
				{
					return;
				}
				throw new ObjectDisposedException(base.GetType().ToString());
			}
			else
			{
				int num;
				Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, null, null, optionValue, out num);
				if (!silent && num != 0)
				{
					throw new SocketException(num);
				}
				return;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.Socket" /> с помощью указанного значения, возвращенного из объекта <see cref="M:System.Net.Sockets.Socket.DuplicateAndClose(System.Int32)" />.</summary>
		/// <param name="socketInformation">Информация сокета, возвращенная объектом <see cref="M:System.Net.Sockets.Socket.DuplicateAndClose(System.Int32)" />.</param>
		// Token: 0x06003D8C RID: 15756 RVA: 0x000D1A78 File Offset: 0x000CFC78
		public Socket(SocketInformation socketInformation)
		{
			this.ReadSem = new SemaphoreSlim(1, 1);
			this.WriteSem = new SemaphoreSlim(1, 1);
			this.is_blocking = true;
			base..ctor();
			this.is_listening = ((socketInformation.Options & SocketInformationOptions.Listening) > (SocketInformationOptions)0);
			this.is_connected = ((socketInformation.Options & SocketInformationOptions.Connected) > (SocketInformationOptions)0);
			this.is_blocking = ((socketInformation.Options & SocketInformationOptions.NonBlocking) == (SocketInformationOptions)0);
			this.useOverlappedIO = ((socketInformation.Options & SocketInformationOptions.UseOnlyOverlappedIO) > (SocketInformationOptions)0);
			IList list = DataConverter.Unpack("iiiil", socketInformation.ProtocolInformation, 0);
			this.addressFamily = (AddressFamily)((int)list[0]);
			this.socketType = (SocketType)((int)list[1]);
			this.protocolType = (ProtocolType)((int)list[2]);
			this.is_bound = ((int)list[3] != 0);
			this.m_Handle = new SafeSocketHandle((IntPtr)((long)list[4]), true);
			Socket.InitializeSockets();
			this.SocketDefaults();
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x000D1B7C File Offset: 0x000CFD7C
		internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
		{
			this.ReadSem = new SemaphoreSlim(1, 1);
			this.WriteSem = new SemaphoreSlim(1, 1);
			this.is_blocking = true;
			base..ctor();
			this.addressFamily = family;
			this.socketType = type;
			this.protocolType = proto;
			this.m_Handle = safe_handle;
			this.is_connected = true;
			Socket.InitializeSockets();
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x000D1BDC File Offset: 0x000CFDDC
		private void SocketDefaults()
		{
			try
			{
				if (this.addressFamily == AddressFamily.InterNetwork)
				{
					this.DontFragment = false;
					if (this.protocolType == ProtocolType.Tcp)
					{
						this.NoDelay = false;
					}
				}
				else if (this.addressFamily == AddressFamily.InterNetworkV6 && this.socketType != SocketType.Raw)
				{
					this.DualMode = true;
				}
			}
			catch (SocketException)
			{
			}
		}

		// Token: 0x06003D8F RID: 15759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error);

		/// <summary>Возвращает значение, указывающее количество полученных из сети и доступных для чтения данных.</summary>
		/// <returns>Количество байтов данных, полученных из сети и доступных для чтения.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06003D90 RID: 15760 RVA: 0x000D1C3C File Offset: 0x000CFE3C
		public int Available
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				int num;
				int result = Socket.Available_internal(this.m_Handle, out num);
				if (num != 0)
				{
					throw new SocketException(num);
				}
				return result;
			}
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x000D1C68 File Offset: 0x000CFE68
		private static int Available_internal(SafeSocketHandle safeHandle, out int error)
		{
			bool flag = false;
			int result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.Available_icall(safeHandle.DangerousGetHandle(), out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06003D92 RID: 15762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Available_icall(IntPtr socket, out int error);

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, может ли объект <see cref="T:System.Net.Sockets.Socket" /> производить отправку или прием широковещательных пакетов.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> разрешает использование широковещательных пакетов; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Эта функция применима только для сокета датаграмм.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06003D93 RID: 15763 RVA: 0x000D1CAC File Offset: 0x000CFEAC
		// (set) Token: 0x06003D94 RID: 15764 RVA: 0x000D1CDE File Offset: 0x000CFEDE
		public bool EnableBroadcast
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				if (this.protocolType != ProtocolType.Udp)
				{
					throw new SocketException(10042);
				}
				return (int)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast) != 0;
			}
			set
			{
				this.ThrowIfDisposedAndClosed();
				if (this.protocolType != ProtocolType.Udp)
				{
					throw new SocketException(10042);
				}
				this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, value ? 1 : 0);
			}
		}

		/// <summary>Получает значение, указывающее, привязан ли объект <see cref="T:System.Net.Sockets.Socket" /> к конкретному локальному порту.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> привязан к локальному порту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x000D1D0F File Offset: 0x000CFF0F
		public bool IsBound
		{
			get
			{
				return this.is_bound;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, могут ли доставляться исходящие пакеты многоадресной рассылки в передающем приложении.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> получает исходящие пакеты многоадресной рассылки; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06003D96 RID: 15766 RVA: 0x000D1D18 File Offset: 0x000CFF18
		// (set) Token: 0x06003D97 RID: 15767 RVA: 0x000D1D80 File Offset: 0x000CFF80
		public bool MulticastLoopback
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				if (this.protocolType == ProtocolType.Tcp)
				{
					throw new SocketException(10042);
				}
				AddressFamily addressFamily = this.addressFamily;
				if (addressFamily == AddressFamily.InterNetwork)
				{
					return (int)this.GetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback) != 0;
				}
				if (addressFamily != AddressFamily.InterNetworkV6)
				{
					throw new NotSupportedException("This property is only valid for InterNetwork and InterNetworkV6 sockets");
				}
				return (int)this.GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.MulticastLoopback) != 0;
			}
			set
			{
				this.ThrowIfDisposedAndClosed();
				if (this.protocolType == ProtocolType.Tcp)
				{
					throw new SocketException(10042);
				}
				AddressFamily addressFamily = this.addressFamily;
				if (addressFamily == AddressFamily.InterNetwork)
				{
					this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback, value ? 1 : 0);
					return;
				}
				if (addressFamily != AddressFamily.InterNetworkV6)
				{
					throw new NotSupportedException("This property is only valid for InterNetwork and InterNetworkV6 sockets");
				}
				this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.MulticastLoopback, value ? 1 : 0);
			}
		}

		/// <summary>Возвращает локальную конечную точку.</summary>
		/// <returns>Объект <see cref="T:System.Net.EndPoint" />, который объект <see cref="T:System.Net.Sockets.Socket" /> использует для взаимодействий.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x000D1DE8 File Offset: 0x000CFFE8
		public EndPoint LocalEndPoint
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				if (this.seed_endpoint == null)
				{
					return null;
				}
				int num;
				SocketAddress socketAddress = Socket.LocalEndPoint_internal(this.m_Handle, (int)this.addressFamily, out num);
				if (num != 0)
				{
					throw new SocketException(num);
				}
				return this.seed_endpoint.Create(socketAddress);
			}
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x000D1E30 File Offset: 0x000D0030
		private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			bool flag = false;
			SocketAddress result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.LocalEndPoint_icall(safeHandle.DangerousGetHandle(), family, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06003D9A RID: 15770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error);

		/// <summary>Возвращает или задает значение, определяющее, находится ли объект <see cref="T:System.Net.Sockets.Socket" /> в заблокированном режиме.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> будет заблокирован; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x000D1E74 File Offset: 0x000D0074
		// (set) Token: 0x06003D9C RID: 15772 RVA: 0x000D1E7C File Offset: 0x000D007C
		public bool Blocking
		{
			get
			{
				return this.is_blocking;
			}
			set
			{
				this.ThrowIfDisposedAndClosed();
				int num;
				Socket.Blocking_internal(this.m_Handle, value, out num);
				if (num != 0)
				{
					throw new SocketException(num);
				}
				this.is_blocking = value;
			}
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x000D1EB0 File Offset: 0x000D00B0
		private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Blocking_icall(safeHandle.DangerousGetHandle(), block, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06003D9E RID: 15774
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Blocking_icall(IntPtr socket, bool block, out int error);

		/// <summary>Получает значение, указывающее, подключается ли объект <see cref="T:System.Net.Sockets.Socket" /> к удаленному узлу в результате последней операции <see cref="Overload:System.Net.Sockets.Socket.Send" /> или <see cref="Overload:System.Net.Sockets.Socket.Receive" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> в результате последней операции был подключен к удаленному ресурсу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x000D1EF0 File Offset: 0x000D00F0
		// (set) Token: 0x06003DA0 RID: 15776 RVA: 0x000D1EF8 File Offset: 0x000D00F8
		public bool Connected
		{
			get
			{
				return this.is_connected;
			}
			internal set
			{
				this.is_connected = value;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, используется ли поток <see cref="T:System.Net.Sockets.Socket" /> в алгоритме Nagle.</summary>
		/// <returns>Значение <see langword="false" />, если объект <see cref="T:System.Net.Sockets.Socket" /> использует алгоритм Nagle; в противном случае — значение <see langword="true" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к объекту <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06003DA1 RID: 15777 RVA: 0x000D1F01 File Offset: 0x000D0101
		// (set) Token: 0x06003DA2 RID: 15778 RVA: 0x000D1F1F File Offset: 0x000D011F
		public bool NoDelay
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				this.ThrowIfUdp();
				return (int)this.GetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug) != 0;
			}
			set
			{
				this.ThrowIfDisposedAndClosed();
				this.ThrowIfUdp();
				this.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, value ? 1 : 0);
			}
		}

		/// <summary>Возвращает удаленную конечную точку.</summary>
		/// <returns>Объект <see cref="T:System.Net.EndPoint" />, с которым взаимодействует объект <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x000D1F3C File Offset: 0x000D013C
		public EndPoint RemoteEndPoint
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				if (!this.is_connected || this.seed_endpoint == null)
				{
					return null;
				}
				int num;
				SocketAddress socketAddress = Socket.RemoteEndPoint_internal(this.m_Handle, (int)this.addressFamily, out num);
				if (num != 0)
				{
					throw new SocketException(num);
				}
				return this.seed_endpoint.Create(socketAddress);
			}
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x000D1F8C File Offset: 0x000D018C
		private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			bool flag = false;
			SocketAddress result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.RemoteEndPoint_icall(safeHandle.DangerousGetHandle(), family, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06003DA5 RID: 15781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error);

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x000D1FD0 File Offset: 0x000D01D0
		internal SafeHandle SafeHandle
		{
			get
			{
				return this.m_Handle;
			}
		}

		/// <summary>Определяет состояние одного или нескольких сокетов.</summary>
		/// <param name="checkRead">
		///   <see cref="T:System.Collections.IList" /> экземпляров <see cref="T:System.Net.Sockets.Socket" /> для проверки удобства чтения.</param>
		/// <param name="checkWrite">
		///   <see cref="T:System.Collections.IList" /> экземпляров <see cref="T:System.Net.Sockets.Socket" /> для проверки удобства ведения записи.</param>
		/// <param name="checkError">
		///   <see cref="T:System.Collections.IList" /> экземпляров <see cref="T:System.Net.Sockets.Socket" /> для проверки ошибок.</param>
		/// <param name="microSeconds">Значение времени ожидания в миллисекундах. Значение -1 указывает на бесконечное время ожидания.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="checkRead" /> имеет значение <see langword="null" /> или является пустым.  
		///
		/// и - 
		/// Параметр <paramref name="checkWrite" /> имеет значение <see langword="null" /> или является пустым. 
		/// и - 
		/// Параметр <paramref name="checkError" /> имеет значение <see langword="null" /> или является пустым.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DA7 RID: 15783 RVA: 0x000D1FD8 File Offset: 0x000D01D8
		public static void Select(IList checkRead, IList checkWrite, IList checkError, int microSeconds)
		{
			List<Socket> list = new List<Socket>();
			Socket.AddSockets(list, checkRead, "checkRead");
			Socket.AddSockets(list, checkWrite, "checkWrite");
			Socket.AddSockets(list, checkError, "checkError");
			if (list.Count == 3)
			{
				throw new ArgumentNullException("checkRead, checkWrite, checkError", "All the lists are null or empty.");
			}
			Socket[] array = list.ToArray();
			int num;
			Socket.Select_icall(ref array, microSeconds, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			if (array == null)
			{
				if (checkRead != null)
				{
					checkRead.Clear();
				}
				if (checkWrite != null)
				{
					checkWrite.Clear();
				}
				if (checkError != null)
				{
					checkError.Clear();
				}
				return;
			}
			int num2 = 0;
			int num3 = array.Length;
			IList list2 = checkRead;
			int num4 = 0;
			for (int i = 0; i < num3; i++)
			{
				Socket socket = array[i];
				if (socket == null)
				{
					if (list2 != null)
					{
						int num5 = list2.Count - num4;
						for (int j = 0; j < num5; j++)
						{
							list2.RemoveAt(num4);
						}
					}
					list2 = ((num2 == 0) ? checkWrite : checkError);
					num4 = 0;
					num2++;
				}
				else
				{
					if (num2 == 1 && list2 == checkWrite && !socket.is_connected && (int)socket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error) == 0)
					{
						socket.is_connected = true;
					}
					while ((Socket)list2[num4] != socket)
					{
						list2.RemoveAt(num4);
					}
					num4++;
				}
			}
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x000D2120 File Offset: 0x000D0320
		private static void AddSockets(List<Socket> sockets, IList list, string name)
		{
			if (list != null)
			{
				foreach (object obj in list)
				{
					Socket socket = (Socket)obj;
					if (socket == null)
					{
						throw new ArgumentNullException(name, "Contains a null element");
					}
					sockets.Add(socket);
				}
			}
			sockets.Add(null);
		}

		// Token: 0x06003DA9 RID: 15785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Select_icall(ref Socket[] sockets, int microSeconds, out int error);

		/// <summary>Определяет состояние объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="microSeconds">Время ожидания ответа, заданное в микросекундах.</param>
		/// <param name="mode">Одно из значений <see cref="T:System.Net.Sockets.SelectMode" />.</param>
		/// <returns>Состояние объекта <see cref="T:System.Net.Sockets.Socket" />, основанное на значении режима опроса, переданного в параметре <paramref name="mode" />.  
		///   Режим 
		///   Возвращаемое значение 
		///  <see cref="F:System.Net.Sockets.SelectMode.SelectRead" />Значение <see langword="true" />, если был вызван метод <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> и подключение отложено; 
		/// -или- 
		///  Значение <see langword="true" />, если данные доступны для чтения; 
		/// -или- 
		///  Значение <see langword="true" />, если подключение закрыто, сброшено или завершено. 
		/// В противном случае, возвращает значение <see langword="false" />.  
		///
		///  <see cref="F:System.Net.Sockets.SelectMode.SelectWrite" />Значение <see langword="true" />, если обработка метода <see cref="M:System.Net.Sockets.Socket.Connect(System.Net.EndPoint)" /> и подключения завершились успешно; 
		/// -или- 
		///  Значение <see langword="true" />, если данные могут быть посланы; 
		/// В противном случае, возвращает значение <see langword="false" />.  
		///
		///  <see cref="F:System.Net.Sockets.SelectMode.SelectError" />Значение <see langword="true" />, если не блокируется обработка метода <see cref="M:System.Net.Sockets.Socket.Connect(System.Net.EndPoint)" /> и попытка подключения завершилась неудачей; 
		/// -или- 
		///  Значение <see langword="true" />, если не установлен объект <see cref="F:System.Net.Sockets.SocketOptionName.OutOfBandInline" /> и доступны экстренные данные; 
		/// В противном случае, возвращает значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="mode" /> не является одним из значений <see cref="T:System.Net.Sockets.SelectMode" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. примечания ниже.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DAA RID: 15786 RVA: 0x000D2190 File Offset: 0x000D0390
		public bool Poll(int microSeconds, SelectMode mode)
		{
			this.ThrowIfDisposedAndClosed();
			if (mode != SelectMode.SelectRead && mode != SelectMode.SelectWrite && mode != SelectMode.SelectError)
			{
				throw new NotSupportedException("'mode' parameter is not valid.");
			}
			int num;
			bool flag = Socket.Poll_internal(this.m_Handle, mode, microSeconds, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			if (mode == SelectMode.SelectWrite && flag && !this.is_connected && (int)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error) == 0)
			{
				this.is_connected = true;
			}
			return flag;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x000D2204 File Offset: 0x000D0404
		private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
		{
			bool flag = false;
			bool result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.Poll_icall(safeHandle.DangerousGetHandle(), mode, timeout, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06003DAC RID: 15788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error);

		/// <summary>Создает новый объект <see cref="T:System.Net.Sockets.Socket" /> для заново созданного подключения.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.Socket" /> для заново созданного подключения.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Принимающий сокет не производит прослушивание подключений. Необходимо вызвать <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> и <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> до вызова объекта <see cref="M:System.Net.Sockets.Socket.Accept" />.</exception>
		// Token: 0x06003DAD RID: 15789 RVA: 0x000D2248 File Offset: 0x000D0448
		public Socket Accept()
		{
			this.ThrowIfDisposedAndClosed();
			int num = 0;
			SafeSocketHandle safe_handle = Socket.Accept_internal(this.m_Handle, out num, this.is_blocking);
			if (num != 0)
			{
				if (this.is_closed)
				{
					num = 10004;
				}
				throw new SocketException(num);
			}
			return new Socket(this.AddressFamily, this.SocketType, this.ProtocolType, safe_handle)
			{
				seed_endpoint = this.seed_endpoint,
				Blocking = this.Blocking
			};
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x000D22BC File Offset: 0x000D04BC
		internal void Accept(Socket acceptSocket)
		{
			this.ThrowIfDisposedAndClosed();
			int num = 0;
			SafeSocketHandle handle = Socket.Accept_internal(this.m_Handle, out num, this.is_blocking);
			if (num != 0)
			{
				if (this.is_closed)
				{
					num = 10004;
				}
				throw new SocketException(num);
			}
			acceptSocket.addressFamily = this.AddressFamily;
			acceptSocket.socketType = this.SocketType;
			acceptSocket.protocolType = this.ProtocolType;
			acceptSocket.m_Handle = handle;
			acceptSocket.is_connected = true;
			acceptSocket.seed_endpoint = this.seed_endpoint;
			acceptSocket.Blocking = this.Blocking;
		}

		/// <summary>Начинает асинхронную операцию, чтобы принять попытку входящего подключения.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. Событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не произойдет и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент является недопустимым. Это исключение возникает, если обеспечиваемый буфер имеет недостаточный размер. Буфер должен иметь размер, равный, по крайней мере, 2 * (размер(SOCKADDR_STORAGE + 16) байт.  
		/// Это исключение также возникает, если задано несколько буферов, свойство <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> не имеет значение "null".</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент вне диапазона. Исключение возникает, если объект <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Count" /> имеет значение меньше 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">Предпринят запрос выполнения недопустимой операции. Это исключение возникает, если принимающий объект <see cref="T:System.Net.Sockets.Socket" /> не производит прослушивание подключений или принимающий сокет является связанным.  
		/// Требуется вызвать объект <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> и метод <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> перед вызовом метода <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.  
		/// Это исключение также происходит, если сокет уже подключен или работа с сокетом уже выполнялась с использованием указанного параметра <paramref name="e" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DAF RID: 15791 RVA: 0x000D2348 File Offset: 0x000D0548
		public bool AcceptAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			if (!this.is_bound)
			{
				throw new InvalidOperationException("You must call the Bind method before performing this operation.");
			}
			if (!this.is_listening)
			{
				throw new InvalidOperationException("You must call the Listen method before performing this operation.");
			}
			if (e.BufferList != null)
			{
				throw new ArgumentException("Multiple buffers cannot be used with this method.");
			}
			if (e.Count < 0)
			{
				throw new ArgumentOutOfRangeException("e.Count");
			}
			Socket acceptSocket = e.AcceptSocket;
			if (acceptSocket != null && (acceptSocket.is_bound || acceptSocket.is_connected))
			{
				throw new InvalidOperationException("AcceptSocket: The socket must not be bound or connected.");
			}
			this.InitSocketAsyncEventArgs(e, Socket.AcceptAsyncCallback, e, SocketOperation.Accept);
			this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginAcceptCallback, e.socket_async_result));
			return true;
		}

		/// <summary>Начинает асинхронную операцию, чтобы принять попытку входящего подключения.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное создание объекта <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows NT.</exception>
		/// <exception cref="T:System.InvalidOperationException">Принимающий сокет не производит прослушивание подключений. Необходимо вызвать <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> и <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> до вызова объекта <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.  
		/// -или- 
		/// Производится связывание принимающего сокета.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="receiveSize" /> меньше 0.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DB0 RID: 15792 RVA: 0x000D2404 File Offset: 0x000D0604
		public IAsyncResult BeginAccept(AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (!this.is_bound || !this.is_listening)
			{
				throw new InvalidOperationException();
			}
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Accept);
			this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginAcceptCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Начинает асинхронную операцию, чтобы принять попытку входящего подключения с указанного сокета и получить первый блок данных, посланных клиентским приложением.</summary>
		/// <param name="acceptSocket">Принятый объект <see cref="T:System.Net.Sockets.Socket" />. Это значение может быть равно <see langword="null" />.</param>
		/// <param name="receiveSize">Максимальное число принимаемых байтов.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное создание объекта <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows NT.</exception>
		/// <exception cref="T:System.InvalidOperationException">Принимающий сокет не производит прослушивание подключений. Необходимо вызвать <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> и <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> до вызова объекта <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.  
		/// -или- 
		/// Производится связывание принимающего сокета.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="receiveSize" /> меньше 0.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DB1 RID: 15793 RVA: 0x000D2458 File Offset: 0x000D0658
		public IAsyncResult BeginAccept(Socket acceptSocket, int receiveSize, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (receiveSize < 0)
			{
				throw new ArgumentOutOfRangeException("receiveSize", "receiveSize is less than zero");
			}
			if (acceptSocket != null)
			{
				this.ThrowIfDisposedAndClosed(acceptSocket);
				if (acceptSocket.IsBound)
				{
					throw new InvalidOperationException();
				}
				if (acceptSocket.ProtocolType != ProtocolType.Tcp)
				{
					throw new SocketException(10022);
				}
			}
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.AcceptReceive)
			{
				Buffer = new byte[receiveSize],
				Offset = 0,
				Size = receiveSize,
				SockFlags = SocketFlags.None,
				AcceptSocket = acceptSocket
			};
			this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginAcceptReceiveCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Асинхронно принимает входящие попытки подключения и создает новый объект <see cref="T:System.Net.Sockets.Socket" /> для связи с удаленным узлом.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии для этой асинхронной операции, а также любые данные, определенные пользователем.</param>
		/// <returns>Объект<see cref="T:System.Net.Sockets.Socket" /> для связи с удаленным узлом.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. Дополнительные сведения см. в разделе "Примечания".</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Ранее был вызван метод <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows NT.</exception>
		// Token: 0x06003DB2 RID: 15794 RVA: 0x000D2504 File Offset: 0x000D0704
		public Socket EndAccept(IAsyncResult asyncResult)
		{
			byte[] array;
			int num;
			return this.EndAccept(out array, out num, asyncResult);
		}

		/// <summary>Асинхронно принимает входящие попытки подключения и создает новый объект <see cref="T:System.Net.Sockets.Socket" /> для связи с удаленным узлом. Этот метод возвращает буфер, который содержит начальные данные и число переданных байтов.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который содержит переданные байты.</param>
		/// <param name="bytesTransferred">Количество переданных байтов.</param>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии для этой асинхронной операции, а также любые данные, определенные пользователем.</param>
		/// <returns>Объект <see cref="T:System.Net.Sockets.Socket" /> для связи с удаленным узлом.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows NT.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="asyncResult" /> пуст.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Ранее был вызван метод <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к объекту <see cref="T:System.Net.Sockets.Socket" />.</exception>
		// Token: 0x06003DB3 RID: 15795 RVA: 0x000D251C File Offset: 0x000D071C
		public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndAccept", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
			buffer = socketAsyncResult.Buffer.ToArray();
			bytesTransferred = socketAsyncResult.Total;
			return socketAsyncResult.AcceptedSocket;
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x000D2578 File Offset: 0x000D0778
		private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
		{
			SafeSocketHandle result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = new SafeSocketHandle(Socket.Accept_icall(safeHandle.DangerousGetHandle(), out error, blocking), true);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06003DB5 RID: 15797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Accept_icall(IntPtr sock, out int error, bool blocking);

		/// <summary>Связывает объект <see cref="T:System.Net.Sockets.Socket" /> с локальной конечной точкой.</summary>
		/// <param name="localEP">Локальный объект <see cref="T:System.Net.EndPoint" />, который необходимо связать с объектом <see cref="T:System.Net.Sockets.Socket" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="localEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		// Token: 0x06003DB6 RID: 15798 RVA: 0x000D25BC File Offset: 0x000D07BC
		public void Bind(EndPoint localEP)
		{
			this.ThrowIfDisposedAndClosed();
			if (localEP == null)
			{
				throw new ArgumentNullException("localEP");
			}
			IPEndPoint ipendPoint = localEP as IPEndPoint;
			if (ipendPoint != null)
			{
				localEP = this.RemapIPEndPoint(ipendPoint);
			}
			int num;
			Socket.Bind_internal(this.m_Handle, localEP.Serialize(), out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			if (num == 0)
			{
				this.is_bound = true;
			}
			this.seed_endpoint = localEP;
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x000D2620 File Offset: 0x000D0820
		private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Bind_icall(safeHandle.DangerousGetHandle(), sa, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06003DB8 RID: 15800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Bind_icall(IntPtr sock, SocketAddress sa, out int error);

		/// <summary>Устанавливает объект <see cref="T:System.Net.Sockets.Socket" /> в состояние прослушивания.</summary>
		/// <param name="backlog">Максимальная длина очереди ожидающих подключений.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DB9 RID: 15801 RVA: 0x000D2660 File Offset: 0x000D0860
		public void Listen(int backlog)
		{
			this.ThrowIfDisposedAndClosed();
			if (!this.is_bound)
			{
				throw new SocketException(10022);
			}
			int num;
			Socket.Listen_internal(this.m_Handle, backlog, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			this.is_listening = true;
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x000D26A8 File Offset: 0x000D08A8
		private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Listen_icall(safeHandle.DangerousGetHandle(), backlog, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06003DBB RID: 15803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Listen_icall(IntPtr sock, int backlog, out int error);

		/// <summary>Устанавливает подключение к удаленному узлу. Узел задается IP-адресом и номером порта.</summary>
		/// <param name="address">IP-адрес удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод допустим для сокетов в семействах <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="address" /> равна нулю.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сокет <see cref="T:System.Net.Sockets.Socket" /> был переведен в состояние прослушивания путем вызова <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />.</exception>
		// Token: 0x06003DBC RID: 15804 RVA: 0x000D26E8 File Offset: 0x000D08E8
		public void Connect(IPAddress address, int port)
		{
			this.Connect(new IPEndPoint(address, port));
		}

		/// <summary>Устанавливает подключение к удаленному узлу. Узел задается именем узла и номером порта.</summary>
		/// <param name="host">Имя удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="host" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод допустим для сокетов в семействах <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сокет <see cref="T:System.Net.Sockets.Socket" /> был переведен в состояние прослушивания путем вызова <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />.</exception>
		// Token: 0x06003DBD RID: 15805 RVA: 0x000D26F7 File Offset: 0x000D08F7
		public void Connect(string host, int port)
		{
			this.Connect(Dns.GetHostAddresses(host), port);
		}

		/// <summary>Устанавливает подключение к удаленному узлу.</summary>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий удаленное устройство.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сокет <see cref="T:System.Net.Sockets.Socket" /> был переведен в состояние прослушивания путем вызова <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />.</exception>
		// Token: 0x06003DBE RID: 15806 RVA: 0x000D2708 File Offset: 0x000D0908
		public void Connect(EndPoint remoteEP)
		{
			this.ThrowIfDisposedAndClosed();
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			IPEndPoint ipendPoint = remoteEP as IPEndPoint;
			if (ipendPoint != null && this.socketType != SocketType.Dgram && (ipendPoint.Address.Equals(IPAddress.Any) || ipendPoint.Address.Equals(IPAddress.IPv6Any)))
			{
				throw new SocketException(10049);
			}
			if (this.is_listening)
			{
				throw new InvalidOperationException();
			}
			if (ipendPoint != null)
			{
				remoteEP = this.RemapIPEndPoint(ipendPoint);
			}
			SocketAddress sa = remoteEP.Serialize();
			int num = 0;
			Socket.Connect_internal(this.m_Handle, sa, out num, this.is_blocking);
			if (num == 0 || num == 10035)
			{
				this.seed_endpoint = remoteEP;
			}
			if (num != 0)
			{
				if (this.is_closed)
				{
					num = 10004;
				}
				throw new SocketException(num);
			}
			this.is_connected = (this.socketType != SocketType.Dgram || ipendPoint == null || (!ipendPoint.Address.Equals(IPAddress.Any) && !ipendPoint.Address.Equals(IPAddress.IPv6Any)));
			this.is_bound = true;
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент является недопустимым. Это исключение возникает, если задано несколько буферов, свойство <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> не имеет значение "null".</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> и <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> не могут иметь значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="T:System.Net.Sockets.Socket" /> ведет прослушивание или работа с сокетом уже выполняется с использованием объекта <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, указанного параметром <paramref name="e" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях. Это исключение возникает также в том случае, если локальная конечная точка и объект <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> не принадлежат к одному семейству адресов.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		// Token: 0x06003DBF RID: 15807 RVA: 0x000D2810 File Offset: 0x000D0A10
		public bool ConnectAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			if (this.is_listening)
			{
				throw new InvalidOperationException("You may not perform this operation after calling the Listen method.");
			}
			if (e.RemoteEndPoint == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			this.InitSocketAsyncEventArgs(e, null, e, SocketOperation.Connect);
			bool result;
			try
			{
				IPAddress[] array;
				SocketAsyncResult socketAsyncResult;
				bool flag;
				if (!this.GetCheckedIPs(e, out array))
				{
					socketAsyncResult = new SocketAsyncResult(this, Socket.ConnectAsyncCallback, e, SocketOperation.Connect)
					{
						EndPoint = e.RemoteEndPoint
					};
					flag = Socket.BeginSConnect(socketAsyncResult);
				}
				else
				{
					DnsEndPoint dnsEndPoint = (DnsEndPoint)e.RemoteEndPoint;
					if (array == null)
					{
						throw new ArgumentNullException("addresses");
					}
					if (array.Length == 0)
					{
						throw new ArgumentException("Empty addresses list");
					}
					if (this.AddressFamily != AddressFamily.InterNetwork && this.AddressFamily != AddressFamily.InterNetworkV6)
					{
						throw new NotSupportedException("This method is only valid for addresses in the InterNetwork or InterNetworkV6 families");
					}
					if (dnsEndPoint.Port <= 0 || dnsEndPoint.Port > 65535)
					{
						throw new ArgumentOutOfRangeException("port", "Must be > 0 and < 65536");
					}
					socketAsyncResult = new SocketAsyncResult(this, Socket.ConnectAsyncCallback, e, SocketOperation.Connect)
					{
						Addresses = array,
						Port = dnsEndPoint.Port
					};
					this.is_connected = false;
					flag = Socket.BeginMConnect(socketAsyncResult);
				}
				if (!flag)
				{
					e.CurrentSocket.EndConnect(socketAsyncResult);
				}
				result = flag;
			}
			catch (SocketException ex)
			{
				e.SocketError = ex.SocketErrorCode;
				e.socket_async_result.Complete(ex, true);
				result = false;
			}
			catch (Exception e2)
			{
				e.socket_async_result.Complete(e2, true);
				result = false;
			}
			return result;
		}

		/// <summary>Отменяет выполнение асинхронного запроса для подключения к удаленному узлу.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, используемый для запроса соединения с удаленным узлом путем вызова одного из методов <see cref="M:System.Net.Sockets.Socket.ConnectAsync(System.Net.Sockets.SocketType,System.Net.Sockets.ProtocolType,System.Net.Sockets.SocketAsyncEventArgs)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> и <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> не могут иметь значение NULL.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		// Token: 0x06003DC0 RID: 15808 RVA: 0x000D298C File Offset: 0x000D0B8C
		public static void CancelConnectAsync(SocketAsyncEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			if (e.in_progress != 0 && e.LastOperation == SocketAsyncOperation.Connect)
			{
				Socket currentSocket = e.CurrentSocket;
				if (currentSocket == null)
				{
					return;
				}
				currentSocket.Close();
			}
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу. Узел задается именем узла и номером порта.</summary>
		/// <param name="host">Имя удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении операции подключения.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции подключения. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное подключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="host" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод допустим для сокетов в семействах <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сокет <see cref="T:System.Net.Sockets.Socket" /> был переведен в состояние прослушивания путем вызова <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />, либо асинхронная операция уже выполняется.</exception>
		// Token: 0x06003DC1 RID: 15809 RVA: 0x000D29C0 File Offset: 0x000D0BC0
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			if (this.addressFamily != AddressFamily.InterNetwork && this.addressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException("This method is valid only for sockets in the InterNetwork and InterNetworkV6 families");
			}
			if (port <= 0 || port > 65535)
			{
				throw new ArgumentOutOfRangeException("port", "Must be > 0 and < 65536");
			}
			if (this.is_listening)
			{
				throw new InvalidOperationException();
			}
			SocketAsyncResult sockares = new SocketAsyncResult(this, callback, state, SocketOperation.Connect)
			{
				Port = port
			};
			Dns.GetHostAddressesAsync(host).ContinueWith(delegate(Task<IPAddress[]> t)
			{
				if (t.IsFaulted)
				{
					sockares.Complete(t.Exception.InnerException);
					return;
				}
				if (t.IsCanceled)
				{
					sockares.Complete(new OperationCanceledException());
					return;
				}
				sockares.Addresses = t.Result;
				Socket.BeginMConnect(sockares);
			}, TaskScheduler.Default);
			return sockares;
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу.</summary>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий удаленный узел.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное подключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сокет <see cref="T:System.Net.Sockets.Socket" /> был переведен в состояние прослушивания путем вызова <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />, либо асинхронная операция уже выполняется.</exception>
		// Token: 0x06003DC2 RID: 15810 RVA: 0x000D2A69 File Offset: 0x000D0C69
		public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			if (this.is_listening)
			{
				throw new InvalidOperationException();
			}
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Connect);
			socketAsyncResult.EndPoint = remoteEP;
			Socket.BeginSConnect(socketAsyncResult);
			return socketAsyncResult;
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу. Узел задается массивом <see cref="T:System.Net.IPAddress" /> и номером порта.</summary>
		/// <param name="addresses">По крайней мере один <see cref="T:System.Net.IPAddress" />, обозначающий удаленный узел.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении операции подключения.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции подключения. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>
		///   <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное подключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="addresses" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод допустим для сокетов, использующих <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="address" /> равна нулю.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сокет <see cref="T:System.Net.Sockets.Socket" /> был переведен в состояние прослушивания путем вызова <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />, либо асинхронная операция уже выполняется.</exception>
		// Token: 0x06003DC3 RID: 15811 RVA: 0x000D2AA4 File Offset: 0x000D0CA4
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (addresses == null)
			{
				throw new ArgumentNullException("addresses");
			}
			if (addresses.Length == 0)
			{
				throw new ArgumentException("Empty addresses list");
			}
			if (this.AddressFamily != AddressFamily.InterNetwork && this.AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException("This method is only valid for addresses in the InterNetwork or InterNetworkV6 families");
			}
			if (port <= 0 || port > 65535)
			{
				throw new ArgumentOutOfRangeException("port", "Must be > 0 and < 65536");
			}
			if (this.is_listening)
			{
				throw new InvalidOperationException();
			}
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, requestCallback, state, SocketOperation.Connect);
			socketAsyncResult.Addresses = addresses;
			socketAsyncResult.Port = port;
			this.is_connected = false;
			Socket.BeginMConnect(socketAsyncResult);
			return socketAsyncResult;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x000D2B44 File Offset: 0x000D0D44
		private static bool BeginMConnect(SocketAsyncResult sockares)
		{
			Exception e = null;
			for (int i = sockares.CurrentAddress; i < sockares.Addresses.Length; i++)
			{
				try
				{
					sockares.CurrentAddress++;
					sockares.EndPoint = new IPEndPoint(sockares.Addresses[i], sockares.Port);
					if (sockares.socket.CanTryAddressFamily(sockares.EndPoint.AddressFamily))
					{
						return Socket.BeginSConnect(sockares);
					}
				}
				catch (Exception e)
				{
				}
			}
			sockares.Complete(e, true);
			return false;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x000D2BD4 File Offset: 0x000D0DD4
		private static bool BeginSConnect(SocketAsyncResult sockares)
		{
			EndPoint endPoint = sockares.EndPoint;
			if (endPoint is IPEndPoint)
			{
				IPEndPoint ipendPoint = (IPEndPoint)endPoint;
				if (ipendPoint.Address.Equals(IPAddress.Any) || ipendPoint.Address.Equals(IPAddress.IPv6Any))
				{
					sockares.Complete(new SocketException(10049), true);
					return false;
				}
				endPoint = (sockares.EndPoint = sockares.socket.RemapIPEndPoint(ipendPoint));
			}
			if (!sockares.socket.CanTryAddressFamily(sockares.EndPoint.AddressFamily))
			{
				sockares.Complete(new ArgumentException("None of the discovered or specified addresses match the socket address family."), true);
				return false;
			}
			int num = 0;
			if (sockares.socket.connect_in_progress)
			{
				sockares.socket.connect_in_progress = false;
				sockares.socket.m_Handle.Dispose();
				sockares.socket.m_Handle = new SafeSocketHandle(Socket.Socket_icall(sockares.socket.addressFamily, sockares.socket.socketType, sockares.socket.protocolType, out num), true);
				if (num != 0)
				{
					sockares.Complete(new SocketException(num), true);
					return false;
				}
			}
			bool flag = sockares.socket.is_blocking;
			if (flag)
			{
				sockares.socket.Blocking = false;
			}
			Socket.Connect_internal(sockares.socket.m_Handle, endPoint.Serialize(), out num, false);
			if (flag)
			{
				sockares.socket.Blocking = true;
			}
			if (num == 0)
			{
				sockares.socket.is_connected = true;
				sockares.socket.is_bound = true;
				sockares.Complete(true);
				return false;
			}
			if (num != 10036 && num != 10035)
			{
				sockares.socket.is_connected = false;
				sockares.socket.is_bound = false;
				sockares.Complete(new SocketException(num), true);
				return false;
			}
			sockares.socket.is_connected = false;
			sockares.socket.is_bound = false;
			sockares.socket.connect_in_progress = true;
			IOSelector.Add(sockares.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginConnectCallback, sockares));
			return true;
		}

		/// <summary>Завершает ожидающий асинхронный запрос на подключение.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии и любые данные, определенные пользователем, для этой асинхронной операции.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginConnect(System.Net.EndPoint,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndConnect(System.IAsyncResult)" /> был ранее вызван для асинхронного подключения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DC6 RID: 15814 RVA: 0x000D2DBC File Offset: 0x000D0FBC
		public void EndConnect(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndConnect", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x000D2DFC File Offset: 0x000D0FFC
		private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
		{
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				Socket.Connect_icall(safeHandle.DangerousGetHandle(), sa, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
		}

		// Token: 0x06003DC8 RID: 15816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking);

		// Token: 0x06003DC9 RID: 15817 RVA: 0x000D2E38 File Offset: 0x000D1038
		private bool GetCheckedIPs(SocketAsyncEventArgs e, out IPAddress[] addresses)
		{
			addresses = null;
			DnsEndPoint dnsEndPoint = e.RemoteEndPoint as DnsEndPoint;
			if (dnsEndPoint == null)
			{
				e.SetConnectByNameError(null);
				return false;
			}
			addresses = Dns.GetHostAddresses(dnsEndPoint.Host);
			if (dnsEndPoint.AddressFamily == AddressFamily.Unspecified)
			{
				return true;
			}
			int num = 0;
			for (int i = 0; i < addresses.Length; i++)
			{
				if (addresses[i].AddressFamily == dnsEndPoint.AddressFamily)
				{
					addresses[num++] = addresses[i];
				}
			}
			if (num != addresses.Length)
			{
				Array.Resize<IPAddress>(ref addresses, num);
			}
			return true;
		}

		/// <summary>Закрывает подключение к сокету и позволяет повторно его использовать.</summary>
		/// <param name="reuseSocket">Значение <see langword="true" />, если этот сокет может быть повторно использован после закрытия текущего подключения; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.PlatformNotSupportedException">Для этого метода необходима операционная система Windows 2000 или более ранняя версия или будет создано исключение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DCA RID: 15818 RVA: 0x000D2EB4 File Offset: 0x000D10B4
		public void Disconnect(bool reuseSocket)
		{
			this.ThrowIfDisposedAndClosed();
			int num = 0;
			Socket.Disconnect_internal(this.m_Handle, reuseSocket, out num);
			if (num == 0)
			{
				this.is_connected = false;
				return;
			}
			if (num == 50)
			{
				throw new PlatformNotSupportedException();
			}
			throw new SocketException(num);
		}

		/// <summary>Начинает выполнение асинхронного запроса для отключения от удаленной конечной точки.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> не может иметь значение null.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция сокета уже выполнялась с использованием объекта <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, указанного в параметре <paramref name="e" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DCB RID: 15819 RVA: 0x000D2EF5 File Offset: 0x000D10F5
		public bool DisconnectAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			this.InitSocketAsyncEventArgs(e, Socket.DisconnectAsyncCallback, e, SocketOperation.Disconnect);
			IOSelector.Add(e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginDisconnectCallback, e.socket_async_result));
			return true;
		}

		/// <summary>Начинает выполнение асинхронного запроса для отключения от удаленной конечной точки.</summary>
		/// <param name="reuseSocket">Значение <see langword="true" />, если этот сокет может быть повторно использован после закрытия подключения; в противном случае — значение <see langword="false" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную операцию.</returns>
		/// <exception cref="T:System.NotSupportedException">Используется операционная система Windows 2000 или более ранняя версия, а для этого метода необходима операционная система Windows XP.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DCC RID: 15820 RVA: 0x000D2F30 File Offset: 0x000D1130
		public IAsyncResult BeginDisconnect(bool reuseSocket, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Disconnect)
			{
				ReuseSocket = reuseSocket
			};
			IOSelector.Add(socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginDisconnectCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Завершает ожидающий асинхронный запрос на разъединение.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии и любые данные, определенные пользователем, для этой асинхронной операции.</param>
		/// <exception cref="T:System.NotSupportedException">Используется операционная система Windows 2000 или более ранняя версия, а для этого метода необходима операционная система Windows XP.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginDisconnect(System.Boolean,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndDisconnect(System.IAsyncResult)" /> был ранее вызван для асинхронного подключения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.Net.WebException">Истекло время ожидания для запроса на разъединение.</exception>
		// Token: 0x06003DCD RID: 15821 RVA: 0x000D2F6C File Offset: 0x000D116C
		public void EndDisconnect(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndDisconnect", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x000D2FAC File Offset: 0x000D11AC
		private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Disconnect_icall(safeHandle.DangerousGetHandle(), reuse, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06003DCF RID: 15823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Disconnect_icall(IntPtr sock, bool reuse, out int error);

		/// <summary>Получает данные из связанного объекта <see cref="T:System.Net.Sockets.Socket" /> в приемный буфер, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="offset">Позиция в параметре <paramref name="buffer" /> для хранения полученных данных.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Свойство <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> не задано.  
		/// -или- 
		/// Произошла ошибка операционной системы при доступе к <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003DD0 RID: 15824 RVA: 0x000D2FEC File Offset: 0x000D11EC
		public unsafe int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			int num;
			int result;
			fixed (byte[] array = buffer)
			{
				byte* ptr;
				if (buffer == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				result = Socket.Receive_internal(this.m_Handle, ptr + offset, size, socketFlags, out num, this.is_blocking);
			}
			errorCode = (SocketError)num;
			if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
			{
				this.is_connected = false;
				this.is_bound = false;
				return result;
			}
			this.is_connected = true;
			return result;
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x000D3078 File Offset: 0x000D1278
		private unsafe int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			int num;
			int result;
			using (MemoryHandle memoryHandle = buffer.Slice(offset, size).Pin())
			{
				result = Socket.Receive_internal(this.m_Handle, (byte*)memoryHandle.Pointer, size, socketFlags, out num, this.is_blocking);
			}
			errorCode = (SocketError)num;
			if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
			{
				this.is_connected = false;
				this.is_bound = false;
			}
			else
			{
				this.is_connected = true;
			}
			return result;
		}

		/// <summary>Получает данные из связанного объекта <see cref="T:System.Net.Sockets.Socket" /> в список приемных буферов, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffers">Список объектов <see cref="T:System.ArraySegment`1" /> типа <see cref="T:System.Byte" />, содержащих полученные данные.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffers" /> — <see langword="null" />.  
		/// -или- 
		///  Значение <paramref name="buffers" />. Отсчет равен нулю.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DD2 RID: 15826 RVA: 0x000D3110 File Offset: 0x000D1310
		[CLSCompliant(false)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			if (buffers == null || buffers.Count == 0)
			{
				throw new ArgumentNullException("buffers");
			}
			int count = buffers.Count;
			GCHandle[] array = new GCHandle[count];
			int num;
			int result;
			try
			{
				try
				{
					Socket.WSABUF[] array2;
					Socket.WSABUF* ptr;
					if ((array2 = new Socket.WSABUF[count]) == null || array2.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array2[0];
					}
					for (int i = 0; i < count; i++)
					{
						ArraySegment<byte> arraySegment = buffers[i];
						if (arraySegment.Offset < 0 || arraySegment.Count < 0 || arraySegment.Count > arraySegment.Array.Length - arraySegment.Offset)
						{
							throw new ArgumentOutOfRangeException("segment");
						}
						try
						{
						}
						finally
						{
							array[i] = GCHandle.Alloc(arraySegment.Array, GCHandleType.Pinned);
						}
						ptr[i].len = arraySegment.Count;
						ptr[i].buf = Marshal.UnsafeAddrOfPinnedArrayElement<byte>(arraySegment.Array, arraySegment.Offset);
					}
					result = Socket.Receive_internal(this.m_Handle, ptr, count, socketFlags, out num, this.is_blocking);
				}
				finally
				{
					Socket.WSABUF[] array2 = null;
				}
			}
			finally
			{
				for (int j = 0; j < count; j++)
				{
					if (array[j].IsAllocated)
					{
						array[j].Free();
					}
				}
			}
			errorCode = (SocketError)num;
			return result;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x000D3290 File Offset: 0x000D1490
		public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			byte[] array = new byte[buffer.Length];
			int result = this.Receive(array, 0, array.Length, socketFlags, out errorCode);
			array.CopyTo(buffer);
			return result;
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x000D32C0 File Offset: 0x000D14C0
		public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			byte[] array = buffer.ToArray();
			return this.Send(array, 0, array.Length, socketFlags, out errorCode);
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x000D32E4 File Offset: 0x000D14E4
		public int Receive(Span<byte> buffer, SocketFlags socketFlags)
		{
			byte[] array = new byte[buffer.Length];
			int result = this.Receive(array, SocketFlags.None);
			array.CopyTo(buffer);
			return result;
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x000D330D File Offset: 0x000D150D
		public int Receive(Span<byte> buffer)
		{
			return this.Receive(buffer, SocketFlags.None);
		}

		/// <summary>Начинает выполнение асинхронного запроса, чтобы получить данные из подключенного объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент был недопустимым. Свойства <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> или <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> на параметре <paramref name="e" /> должны ссылаться на допустимые буферы. Может быть установлено одно из этих свойств, но нельзя одновременно устанавливать оба свойства.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция сокета уже выполнялась с использованием объекта <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, указанного в параметре <paramref name="e" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DD7 RID: 15831 RVA: 0x000D3318 File Offset: 0x000D1518
		public bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			if (e.MemoryBuffer.Equals(default(Memory<byte>)) && e.BufferList == null)
			{
				throw new NullReferenceException("Either e.Buffer or e.BufferList must be valid buffers.");
			}
			if (e.BufferList != null)
			{
				this.InitSocketAsyncEventArgs(e, Socket.ReceiveAsyncCallback, e, SocketOperation.ReceiveGeneric);
				e.socket_async_result.Buffers = e.BufferList;
				this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveGenericCallback, e.socket_async_result));
			}
			else
			{
				this.InitSocketAsyncEventArgs(e, Socket.ReceiveAsyncCallback, e, SocketOperation.Receive);
				e.socket_async_result.Buffer = e.MemoryBuffer;
				e.socket_async_result.Offset = e.Offset;
				e.socket_async_result.Size = e.Count;
				this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveCallback, e.socket_async_result));
			}
			return true;
		}

		/// <summary>Начинает выполнение асинхронного приема данных с подключенного объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="offset">Место в объекте <paramref name="buffer" />, выделенное для хранения принимаемых данных.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции приема. Этот объект передается делегату <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное чтение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		// Token: 0x06003DD8 RID: 15832 RVA: 0x000D3414 File Offset: 0x000D1614
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			errorCode = SocketError.Success;
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Receive)
			{
				Buffer = buffer,
				Offset = offset,
				Size = size,
				SockFlags = socketFlags
			};
			this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Начинает выполнение асинхронного приема данных с подключенного объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffers">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции приема. Этот объект передается делегату <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное чтение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		// Token: 0x06003DD9 RID: 15833 RVA: 0x000D3488 File Offset: 0x000D1688
		[CLSCompliant(false)]
		public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (buffers == null)
			{
				throw new ArgumentNullException("buffers");
			}
			errorCode = SocketError.Success;
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.ReceiveGeneric)
			{
				Buffers = buffers,
				SockFlags = socketFlags
			};
			this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveGenericCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Завершает отложенное асинхронное чтение.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии и любые данные, определенные пользователем, для этой асинхронной операции.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> был ранее вызван для асинхронного чтения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DDA RID: 15834 RVA: 0x000D34E8 File Offset: 0x000D16E8
		public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndReceive", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			errorCode = socketAsyncResult.ErrorCode;
			if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
			{
				this.is_connected = false;
			}
			if (errorCode == SocketError.Success)
			{
				socketAsyncResult.CheckIfThrowDelayedException();
			}
			return socketAsyncResult.Total;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x000D3558 File Offset: 0x000D1758
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.Receive_array_icall(safeHandle.DangerousGetHandle(), bufarray, count, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06003DDC RID: 15836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x06003DDD RID: 15837 RVA: 0x000D3598 File Offset: 0x000D1798
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.Receive_icall(safeHandle.DangerousGetHandle(), buffer, count, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06003DDE RID: 15838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking);

		/// <summary>Получает указанное число байтов данных в заданном расположении буфера данных с использованием определенного параметра <see cref="T:System.Net.Sockets.SocketFlags" /> и сохраняет конечную точку.</summary>
		/// <param name="buffer">Массив объекта типа <see cref="T:System.Byte" />, который является местом хранения полученных данных.</param>
		/// <param name="offset">Позиция в параметре <paramref name="buffer" /> для хранения полученных данных.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Переданный по ссылке объект <see cref="T:System.Net.EndPoint" />, представляющий удаленный сервер.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра смещения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Свойство <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> не задано.  
		/// -или- 
		/// Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DDF RID: 15839 RVA: 0x000D35D8 File Offset: 0x000D17D8
		public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			SocketError socketError;
			int result = this.ReceiveFrom(buffer, offset, size, socketFlags, ref remoteEP, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x000D3624 File Offset: 0x000D1824
		internal unsafe int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			SocketAddress socketAddress = remoteEP.Serialize();
			int num;
			int result;
			fixed (byte[] array = buffer)
			{
				byte* ptr;
				if (buffer == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				result = Socket.ReceiveFrom_internal(this.m_Handle, ptr + offset, size, socketFlags, ref socketAddress, out num, this.is_blocking);
			}
			errorCode = (SocketError)num;
			if (errorCode != SocketError.Success)
			{
				if (errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
				{
					this.is_connected = false;
				}
				else if (errorCode == SocketError.WouldBlock && this.is_blocking)
				{
					errorCode = SocketError.TimedOut;
				}
				return 0;
			}
			this.is_connected = true;
			this.is_bound = true;
			if (socketAddress != null)
			{
				remoteEP = remoteEP.Create(socketAddress);
			}
			this.seed_endpoint = remoteEP;
			return result;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x000D36E0 File Offset: 0x000D18E0
		private unsafe int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			SocketAddress socketAddress = remoteEP.Serialize();
			int num;
			int result;
			using (MemoryHandle memoryHandle = buffer.Slice(offset, size).Pin())
			{
				result = Socket.ReceiveFrom_internal(this.m_Handle, (byte*)memoryHandle.Pointer, size, socketFlags, ref socketAddress, out num, this.is_blocking);
			}
			errorCode = (SocketError)num;
			if (errorCode != SocketError.Success)
			{
				if (errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
				{
					this.is_connected = false;
				}
				else if (errorCode == SocketError.WouldBlock && this.is_blocking)
				{
					errorCode = SocketError.TimedOut;
				}
				return 0;
			}
			this.is_connected = true;
			this.is_bound = true;
			if (socketAddress != null)
			{
				remoteEP = remoteEP.Create(socketAddress);
			}
			this.seed_endpoint = remoteEP;
			return result;
		}

		/// <summary>Начинает выполнение асинхронного приема данных с указанного сетевого устройства.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Объект <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> не может иметь значение "null".</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция сокета уже выполнялась с использованием объекта <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, указанного в параметре <paramref name="e" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DE2 RID: 15842 RVA: 0x000D37B4 File Offset: 0x000D19B4
		public bool ReceiveFromAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			if (e.BufferList != null)
			{
				throw new NotSupportedException("Mono doesn't support using BufferList at this point.");
			}
			if (e.RemoteEndPoint == null)
			{
				throw new ArgumentNullException("remoteEP", "Value cannot be null.");
			}
			this.InitSocketAsyncEventArgs(e, Socket.ReceiveFromAsyncCallback, e, SocketOperation.ReceiveFrom);
			e.socket_async_result.Buffer = e.Buffer;
			e.socket_async_result.Offset = e.Offset;
			e.socket_async_result.Size = e.Count;
			e.socket_async_result.EndPoint = e.RemoteEndPoint;
			e.socket_async_result.SockFlags = e.SocketFlags;
			this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveFromCallback, e.socket_async_result));
			return true;
		}

		/// <summary>Начинает выполнение асинхронного приема данных с указанного сетевого устройства.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="offset">Отсчитываемая с нуля позиция в параметре <paramref name="buffer" />, начиная с которой хранятся данные.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий источник данных.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное чтение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		// Token: 0x06003DE3 RID: 15843 RVA: 0x000D3884 File Offset: 0x000D1A84
		public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.ReceiveFrom)
			{
				Buffer = buffer,
				Offset = offset,
				Size = size,
				SockFlags = socketFlags,
				EndPoint = remoteEP
			};
			this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveFromCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Завершает отложенное асинхронное чтение с определенной конечной точки.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии и любые данные, определенные пользователем, для этой асинхронной операции.</param>
		/// <param name="endPoint">Источник <see cref="T:System.Net.EndPoint" />.</param>
		/// <returns>Количество полученных байтов, если операция успешно выполнена. Возвращает значение 0, если операция завершилась неудачей.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginReceiveFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint@,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndReceiveFrom(System.IAsyncResult,System.Net.EndPoint@)" /> был ранее вызван для асинхронного чтения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DE4 RID: 15844 RVA: 0x000D3910 File Offset: 0x000D1B10
		public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)
		{
			this.ThrowIfDisposedAndClosed();
			if (endPoint == null)
			{
				throw new ArgumentNullException("endPoint");
			}
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndReceiveFrom", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
			endPoint = socketAsyncResult.EndPoint;
			return socketAsyncResult.Total;
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x000D396C File Offset: 0x000D1B6C
		private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
		{
			this.ThrowIfDisposedAndClosed();
			if (Interlocked.CompareExchange(ref sockares.EndCalled, 1, 0) == 1)
			{
				throw new InvalidOperationException("EndReceiveFrom can only be called once per asynchronous operation");
			}
			if (!sockares.IsCompleted)
			{
				sockares.AsyncWaitHandle.WaitOne();
			}
			sockares.CheckIfThrowDelayedException();
			ares.RemoteEndPoint = sockares.EndPoint;
			return sockares.Total;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x000D39C8 File Offset: 0x000D1BC8
		private unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.ReceiveFrom_icall(safeHandle.DangerousGetHandle(), buffer, count, flags, ref sockaddr, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06003DE7 RID: 15847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking);

		/// <summary>Получает указанное число байтов данных в указанное расположение буфера данных с помощью заданного <see cref="T:System.Net.Sockets.SocketFlags" /> и сохраняет конечную точку и сведения о пакете.</summary>
		/// <param name="buffer">Массив объекта типа <see cref="T:System.Byte" />, который является местом хранения полученных данных.</param>
		/// <param name="offset">Позиция в параметре <paramref name="buffer" /> для хранения полученных данных.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Переданный по ссылке объект <see cref="T:System.Net.EndPoint" />, представляющий удаленный сервер.</param>
		/// <param name="ipPacketInformation">
		///   <see cref="T:System.Net.Sockets.IPPacketInformation" /> сохраняет адрес и сведения об интерфейсе.</param>
		/// <returns>Количество полученных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// - или - 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра смещения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Свойство <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> не задано.  
		/// -или- 
		/// Платформа .NET Framework выполняется на 64-разрядном процессоре AMD.  
		/// -или- 
		/// Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Используется операционная система Windows 2000 или более ранняя версия, а для этого метода необходима операционная система Windows XP.</exception>
		// Token: 0x06003DE8 RID: 15848 RVA: 0x000D3A0C File Offset: 0x000D1C0C
		[MonoTODO("Not implemented")]
		public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			throw new NotImplementedException();
		}

		/// <summary>Начинает асинхронный прием заданного числа байтов данных в указанное место буфера данных, используя заданный объект <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.SocketFlags" />, а также сохраняет конечную точку и информацию пакета.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Объект <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> не может иметь значение "null".</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003DE9 RID: 15849 RVA: 0x000D3A39 File Offset: 0x000D1C39
		[MonoTODO("Not implemented")]
		public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			throw new NotImplementedException();
		}

		/// <summary>Начинает асинхронный прием заданного числа байтов данных в указанное место буфера данных, используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />, а также сохраняет конечную точку и информацию пакета.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением памяти для полученных данных.</param>
		/// <param name="offset">Отсчитываемая с нуля позиция в параметре <paramref name="buffer" />, начиная с которой хранятся данные.</param>
		/// <param name="size">Количество байтов, которые необходимо получить.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий источник данных.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное чтение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Используется операционная система Windows 2000 или более ранняя версия, а для этого метода необходима операционная система Windows XP.</exception>
		// Token: 0x06003DEA RID: 15850 RVA: 0x000D3A0C File Offset: 0x000D1C0C
		[MonoTODO]
		public IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			throw new NotImplementedException();
		}

		/// <summary>Завершает отложенное асинхронное чтение с определенной конечной точки. Этот метод также показывает больше информации о пакете, чем метод <see cref="M:System.Net.Sockets.Socket.EndReceiveFrom(System.IAsyncResult,System.Net.EndPoint@)" />.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии и любые данные, определенные пользователем, для этой асинхронной операции.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений перечисления <see cref="T:System.Net.Sockets.SocketFlags" /> для принятого пакета.</param>
		/// <param name="endPoint">Источник <see cref="T:System.Net.EndPoint" />.</param>
		/// <param name="ipPacketInformation">Объект <see cref="T:System.Net.IPAddress" /> и интерфейс полученного пакета.</param>
		/// <returns>Количество полученных байтов, если операция успешно выполнена. Возвращает значение 0, если операция завершилась неудачей.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> равно <see langword="null" />  
		/// -или- 
		///  <paramref name="endPoint" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginReceiveMessageFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint@,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndReceiveMessageFrom(System.IAsyncResult,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" /> был ранее вызван для асинхронного чтения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DEB RID: 15851 RVA: 0x000D3A46 File Offset: 0x000D1C46
		[MonoTODO]
		public int EndReceiveMessageFrom(IAsyncResult asyncResult, ref SocketFlags socketFlags, ref EndPoint endPoint, out IPPacketInformation ipPacketInformation)
		{
			this.ThrowIfDisposedAndClosed();
			if (endPoint == null)
			{
				throw new ArgumentNullException("endPoint");
			}
			this.ValidateEndIAsyncResult(asyncResult, "EndReceiveMessageFrom", "asyncResult");
			throw new NotImplementedException();
		}

		/// <summary>Посылает указанное число байтов данных на подключенный объект <see cref="T:System.Net.Sockets.Socket" />, начиная с указанного смещения и используя заданный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <param name="offset">Положение в буфере данных, с которого начинается отправка данных.</param>
		/// <param name="size">Количество байтов для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <returns>Количество байтов, отправленных в <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Произошла ошибка операционной системы при доступе к <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DEC RID: 15852 RVA: 0x000D3A74 File Offset: 0x000D1C74
		public unsafe int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (size == 0)
			{
				errorCode = SocketError.Success;
				return 0;
			}
			int num = 0;
			for (;;)
			{
				int num2;
				fixed (byte[] array = buffer)
				{
					byte* ptr;
					if (buffer == null || array.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array[0];
					}
					num += Socket.Send_internal(this.m_Handle, ptr + (offset + num), size - num, socketFlags, out num2, this.is_blocking);
				}
				errorCode = (SocketError)num2;
				if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
				{
					break;
				}
				this.is_connected = true;
				if (num >= size)
				{
					return num;
				}
			}
			this.is_connected = false;
			this.is_bound = false;
			return num;
		}

		/// <summary>Отправляет набор буферов в список на подключенный объект <see cref="T:System.Net.Sockets.Socket" />, используя указанный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffers">Список объектов <see cref="T:System.ArraySegment`1" /> типа <see cref="T:System.Byte" />, содержащих данные для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <returns>Количество байтов, отправленных в <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffers" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="buffers" /> пуст.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DED RID: 15853 RVA: 0x000D3B18 File Offset: 0x000D1D18
		[CLSCompliant(false)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			if (buffers == null)
			{
				throw new ArgumentNullException("buffers");
			}
			if (buffers.Count == 0)
			{
				throw new ArgumentException("Buffer is empty", "buffers");
			}
			int count = buffers.Count;
			GCHandle[] array = new GCHandle[count];
			int num;
			int result;
			try
			{
				try
				{
					Socket.WSABUF[] array2;
					Socket.WSABUF* ptr;
					if ((array2 = new Socket.WSABUF[count]) == null || array2.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array2[0];
					}
					for (int i = 0; i < count; i++)
					{
						ArraySegment<byte> arraySegment = buffers[i];
						if (arraySegment.Offset < 0 || arraySegment.Count < 0 || arraySegment.Count > arraySegment.Array.Length - arraySegment.Offset)
						{
							throw new ArgumentOutOfRangeException("segment");
						}
						try
						{
						}
						finally
						{
							array[i] = GCHandle.Alloc(arraySegment.Array, GCHandleType.Pinned);
						}
						ptr[i].len = arraySegment.Count;
						ptr[i].buf = Marshal.UnsafeAddrOfPinnedArrayElement<byte>(arraySegment.Array, arraySegment.Offset);
					}
					result = Socket.Send_internal(this.m_Handle, ptr, count, socketFlags, out num, this.is_blocking);
				}
				finally
				{
					Socket.WSABUF[] array2 = null;
				}
			}
			finally
			{
				for (int j = 0; j < count; j++)
				{
					if (array[j].IsAllocated)
					{
						array[j].Free();
					}
				}
			}
			errorCode = (SocketError)num;
			return result;
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x000D3CA8 File Offset: 0x000D1EA8
		public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags)
		{
			return this.Send(buffer.ToArray(), socketFlags);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x000D3CB8 File Offset: 0x000D1EB8
		public int Send(ReadOnlySpan<byte> buffer)
		{
			return this.Send(buffer, SocketFlags.None);
		}

		/// <summary>Выполняет асинхронную передачу данных на подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentException">Свойства <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> или <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> на параметре <paramref name="e" /> должны ссылаться на допустимые буферы. Может быть установлено одно из этих свойств, но нельзя одновременно устанавливать оба свойства.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция сокета уже выполнялась с использованием объекта <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, указанного в параметре <paramref name="e" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Объект <see cref="T:System.Net.Sockets.Socket" /> уже не подключен или он был получен посредством метода <see cref="M:System.Net.Sockets.Socket.Accept" />, <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> или <see cref="Overload:System.Net.Sockets.Socket.BeginAccept" />.</exception>
		// Token: 0x06003DF0 RID: 15856 RVA: 0x000D3CC4 File Offset: 0x000D1EC4
		public bool SendAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			if (e.MemoryBuffer.Equals(default(Memory<byte>)) && e.BufferList == null)
			{
				throw new NullReferenceException("Either e.Buffer or e.BufferList must be valid buffers.");
			}
			if (e.BufferList != null)
			{
				this.InitSocketAsyncEventArgs(e, Socket.SendAsyncCallback, e, SocketOperation.SendGeneric);
				e.socket_async_result.Buffers = e.BufferList;
				this.QueueIOSelectorJob(this.WriteSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginSendGenericCallback, e.socket_async_result));
			}
			else
			{
				this.InitSocketAsyncEventArgs(e, Socket.SendAsyncCallback, e, SocketOperation.Send);
				e.socket_async_result.Buffer = e.MemoryBuffer;
				e.socket_async_result.Offset = e.Offset;
				e.socket_async_result.Size = e.Count;
				this.QueueIOSelectorJob(this.WriteSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
				{
					Socket.BeginSendCallback((SocketAsyncResult)s, 0);
				}, e.socket_async_result));
			}
			return true;
		}

		/// <summary>Выполняет асинхронную передачу данных на подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который содержит передаваемые данные.</param>
		/// <param name="offset">Отсчитываемая с нуля позиция в параметре <paramref name="buffer" />, с которой начинается отправка данных.</param>
		/// <param name="size">Количество байтов для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную передачу.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. ниже примeчания к данному разделу.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="offset" /> меньше значения длины, указанного в параметре <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DF1 RID: 15857 RVA: 0x000D3DDC File Offset: 0x000D1FDC
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (!this.is_connected)
			{
				errorCode = SocketError.NotConnected;
				return null;
			}
			errorCode = SocketError.Success;
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Send)
			{
				Buffer = buffer,
				Offset = offset,
				Size = size,
				SockFlags = socketFlags
			};
			this.QueueIOSelectorJob(this.WriteSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
			{
				Socket.BeginSendCallback((SocketAsyncResult)s, 0);
			}, socketAsyncResult));
			return socketAsyncResult;
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x000D3E7C File Offset: 0x000D207C
		private unsafe static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			int num = 0;
			try
			{
				using (MemoryHandle memoryHandle = sockares.Buffer.Slice(sockares.Offset, sockares.Size).Pin())
				{
					num = Socket.Send_internal(sockares.socket.m_Handle, (byte*)memoryHandle.Pointer, sockares.Size, sockares.SockFlags, out sockares.error, false);
				}
			}
			catch (Exception e)
			{
				sockares.Complete(e);
				return;
			}
			if (sockares.error == 0)
			{
				sent_so_far += num;
				sockares.Offset += num;
				sockares.Size -= num;
				if (sockares.socket.CleanedUp)
				{
					sockares.Complete(sent_so_far);
					return;
				}
				if (sockares.Size > 0)
				{
					IOSelector.Add(sockares.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
					{
						Socket.BeginSendCallback((SocketAsyncResult)s, sent_so_far);
					}, sockares));
					return;
				}
				sockares.Total = sent_so_far;
			}
			sockares.Complete(sent_so_far);
		}

		/// <summary>Выполняет асинхронную передачу данных на подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffers">Массив типа <see cref="T:System.Byte" />, который содержит передаваемые данные.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную передачу.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffers" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="buffers" /> пуст.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. ниже примeчания к данному разделу.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DF3 RID: 15859 RVA: 0x000D3FAC File Offset: 0x000D21AC
		[CLSCompliant(false)]
		public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (buffers == null)
			{
				throw new ArgumentNullException("buffers");
			}
			if (!this.is_connected)
			{
				errorCode = SocketError.NotConnected;
				return null;
			}
			errorCode = SocketError.Success;
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.SendGeneric)
			{
				Buffers = buffers,
				SockFlags = socketFlags
			};
			this.QueueIOSelectorJob(this.WriteSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginSendGenericCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Завершает отложенную операцию асинхронной передачи.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, хранящий сведения о состоянии этой асинхронной операции.</param>
		/// <param name="errorCode">Объект <see cref="T:System.Net.Sockets.SocketError" />, содержащий ошибку сокета.</param>
		/// <returns>Если операция завершилась успешно — значение количества байтов, переданных в объект <see cref="T:System.Net.Sockets.Socket" />; в противном случае — ошибка, указывающая на недопустимость объекта <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> был ранее вызван для асинхронной передачи.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DF4 RID: 15860 RVA: 0x000D401C File Offset: 0x000D221C
		public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndSend", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			errorCode = socketAsyncResult.ErrorCode;
			if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
			{
				this.is_connected = false;
			}
			if (errorCode == SocketError.Success)
			{
				socketAsyncResult.CheckIfThrowDelayedException();
			}
			return socketAsyncResult.Total;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x000D408C File Offset: 0x000D228C
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.Send_array_icall(safeHandle.DangerousGetHandle(), bufarray, count, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06003DF6 RID: 15862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x06003DF7 RID: 15863 RVA: 0x000D40CC File Offset: 0x000D22CC
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.Send_icall(safeHandle.DangerousGetHandle(), buffer, count, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06003DF8 RID: 15864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking);

		/// <summary>Посылает указанное число байтов данных на указанную конечную точку, начиная с заданной позиции буфера и используя указанный объект <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для отправки.</param>
		/// <param name="offset">Положение в буфере данных, с которого начинается отправка данных.</param>
		/// <param name="size">Количество байтов для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий пункт назначения для данных.</param>
		/// <returns>Число отправленных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <paramref name="socketFlags" /> — недопустимое сочетание значений.  
		/// -или- 
		/// Произошла ошибка операционной системы при доступе к <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003DF9 RID: 15865 RVA: 0x000D410C File Offset: 0x000D230C
		public unsafe int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			int num;
			int result;
			fixed (byte[] array = buffer)
			{
				byte* ptr;
				if (buffer == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				result = Socket.SendTo_internal(this.m_Handle, ptr + offset, size, socketFlags, remoteEP.Serialize(), out num, this.is_blocking);
			}
			SocketError socketError = (SocketError)num;
			if (socketError != SocketError.Success)
			{
				if (socketError != SocketError.WouldBlock && socketError != SocketError.InProgress)
				{
					this.is_connected = false;
				}
				throw new SocketException(num);
			}
			this.is_connected = true;
			this.is_bound = true;
			this.seed_endpoint = remoteEP;
			return result;
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x000D41B4 File Offset: 0x000D23B4
		private unsafe int SendTo(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			this.ThrowIfDisposedAndClosed();
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			int num;
			int result;
			using (MemoryHandle memoryHandle = buffer.Slice(offset, size).Pin())
			{
				result = Socket.SendTo_internal(this.m_Handle, (byte*)memoryHandle.Pointer, size, socketFlags, remoteEP.Serialize(), out num, this.is_blocking);
			}
			SocketError socketError = (SocketError)num;
			if (socketError != SocketError.Success)
			{
				if (socketError != SocketError.WouldBlock && socketError != SocketError.InProgress)
				{
					this.is_connected = false;
				}
				throw new SocketException(num);
			}
			this.is_connected = true;
			this.is_bound = true;
			this.seed_endpoint = remoteEP;
			return result;
		}

		/// <summary>Асинхронно передает данные на конкретный удаленный узел.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Объект <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> не может иметь значение "null".</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция сокета уже выполнялась с использованием объекта <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, указанного в параметре <paramref name="e" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Указанный протокол работает с установлением соединения, но объект <see cref="T:System.Net.Sockets.Socket" /> еще не подключен.</exception>
		// Token: 0x06003DFB RID: 15867 RVA: 0x000D4268 File Offset: 0x000D2468
		public bool SendToAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			if (e.BufferList != null)
			{
				throw new NotSupportedException("Mono doesn't support using BufferList at this point.");
			}
			if (e.RemoteEndPoint == null)
			{
				throw new ArgumentNullException("remoteEP", "Value cannot be null.");
			}
			this.InitSocketAsyncEventArgs(e, Socket.SendToAsyncCallback, e, SocketOperation.SendTo);
			e.socket_async_result.Buffer = e.Buffer;
			e.socket_async_result.Offset = e.Offset;
			e.socket_async_result.Size = e.Count;
			e.socket_async_result.SockFlags = e.SocketFlags;
			e.socket_async_result.EndPoint = e.RemoteEndPoint;
			this.QueueIOSelectorJob(this.WriteSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
			{
				Socket.BeginSendToCallback((SocketAsyncResult)s, 0);
			}, e.socket_async_result));
			return true;
		}

		/// <summary>Асинхронно передает данные на конкретный удаленный узел.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который содержит передаваемые данные.</param>
		/// <param name="offset">Отсчитываемая с нуля позиция в параметре <paramref name="buffer" />, с которой начинается отправка данных.</param>
		/// <param name="size">Количество байтов для отправки.</param>
		/// <param name="socketFlags">Поразрядное сочетание значений <see cref="T:System.Net.Sockets.SocketFlags" />.</param>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.EndPoint" />, представляющий удаленное устройство.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную передачу.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="remoteEP" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="offset" /> превышает длину <paramref name="buffer" />.  
		/// -или- 
		///  Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="size" /> превышает значение, полученное, если отнять от длины <paramref name="buffer" /> значение параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		// Token: 0x06003DFC RID: 15868 RVA: 0x000D4354 File Offset: 0x000D2554
		public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.SendTo)
			{
				Buffer = buffer,
				Offset = offset,
				Size = size,
				SockFlags = socketFlags,
				EndPoint = remoteEP
			};
			this.QueueIOSelectorJob(this.WriteSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
			{
				Socket.BeginSendToCallback((SocketAsyncResult)s, 0);
			}, socketAsyncResult));
			return socketAsyncResult;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x000D43E8 File Offset: 0x000D25E8
		private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			try
			{
				int num = sockares.socket.SendTo(sockares.Buffer, sockares.Offset, sockares.Size, sockares.SockFlags, sockares.EndPoint);
				if (sockares.error == 0)
				{
					sent_so_far += num;
					sockares.Offset += num;
					sockares.Size -= num;
				}
				if (sockares.Size > 0)
				{
					IOSelector.Add(sockares.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
					{
						Socket.BeginSendToCallback((SocketAsyncResult)s, sent_so_far);
					}, sockares));
					return;
				}
				sockares.Total = sent_so_far;
			}
			catch (Exception e)
			{
				sockares.Complete(e);
				return;
			}
			sockares.Complete();
		}

		/// <summary>Завершает отложенную операцию асинхронной отправки в определенное местоположение.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии и любые данные, определенные пользователем, для этой асинхронной операции.</param>
		/// <returns>Если операция завершилась успешно — значение количества отправленных байтов; в противном случае — ошибка, указывающая на недопустимость объекта <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginSendTo(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndSendTo(System.IAsyncResult)" /> был ранее вызван для асинхронной передачи.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003DFE RID: 15870 RVA: 0x000D44B8 File Offset: 0x000D26B8
		public int EndSendTo(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndSendTo", "result");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
			return socketAsyncResult.Total;
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x000D4500 File Offset: 0x000D2700
		private unsafe static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.SendTo_icall(safeHandle.DangerousGetHandle(), buffer, count, flags, sa, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06003E00 RID: 15872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking);

		/// <summary>Отправляет файл <paramref name="fileName" /> и буферы данных в подключенный объект <see cref="T:System.Net.Sockets.Socket" />, используя указанное значение <see cref="T:System.Net.Sockets.TransmitFileOptions" />.</summary>
		/// <param name="fileName">Параметр типа <see cref="T:System.String" />, содержащий имя отправляемого файла и путь к нему. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="preBuffer">Массив <see cref="T:System.Byte" />, содержащий данные, отправляемые перед передачей файла. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="postBuffer">Массив <see cref="T:System.Byte" />, содержащий данные, отправляемые после передачи файла. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="flags">Одно или несколько значений <see cref="T:System.Net.Sockets.TransmitFileOptions" />.</param>
		/// <exception cref="T:System.NotSupportedException">Операционной системой не является Windows NT или более поздняя версия.  
		/// -или- 
		/// Сокет не подключен к удаленному узлу.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Net.Sockets.Socket" /> не находится в режиме блокировки и не может принять этот синхронный вызов.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="fileName" /> не найден.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003E01 RID: 15873 RVA: 0x000D4544 File Offset: 0x000D2744
		public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags)
		{
			this.ThrowIfDisposedAndClosed();
			if (!this.is_connected)
			{
				throw new NotSupportedException();
			}
			if (!this.is_blocking)
			{
				throw new InvalidOperationException();
			}
			int num = 0;
			if (Socket.SendFile_internal(this.m_Handle, fileName, preBuffer, postBuffer, flags, out num, this.is_blocking) && num == 0)
			{
				return;
			}
			SocketException ex = new SocketException(num);
			if (ex.ErrorCode == 2 || ex.ErrorCode == 3)
			{
				throw new FileNotFoundException();
			}
			throw ex;
		}

		/// <summary>Выполняет асинхронную передачу файла и буферов данных на подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="fileName">Строка, содержащая путь и имя отправляемого файла. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="preBuffer">Массив <see cref="T:System.Byte" />, содержащий данные, отправляемые перед передачей файла. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="postBuffer">Массив <see cref="T:System.Byte" />, содержащий данные, отправляемые после передачи файла. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="flags">Побитовое сочетание значений <see cref="T:System.Net.Sockets.TransmitFileOptions" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, который должен быть вызван, когда эта операция завершается. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="state">Определенный пользователем объект, содержащий сведения о состоянии для этого запроса. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную операцию.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. ниже примeчания к данному разделу.</exception>
		/// <exception cref="T:System.NotSupportedException">Операционной системой не является Windows NT или более поздняя версия.  
		/// -или- 
		/// Сокет не подключен к удаленному узлу.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="fileName" /> не найден.</exception>
		// Token: 0x06003E02 RID: 15874 RVA: 0x000D45B4 File Offset: 0x000D27B4
		public IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (!this.is_connected)
			{
				throw new NotSupportedException();
			}
			if (!File.Exists(fileName))
			{
				throw new FileNotFoundException();
			}
			Socket.SendFileHandler handler = new Socket.SendFileHandler(this.SendFile);
			return new Socket.SendFileAsyncResult(handler, handler.BeginInvoke(fileName, preBuffer, postBuffer, flags, delegate(IAsyncResult ar)
			{
				callback(new Socket.SendFileAsyncResult(handler, ar));
			}, state));
		}

		/// <summary>Завершает отложенную операцию асинхронной передачи файла.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, хранящий сведения о состоянии этой асинхронной операции.</param>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows NT.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="asyncResult" /> пуст.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginSendFile(System.String,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndSendFile(System.IAsyncResult)" /> был ранее вызван для асинхронной передачи объекта <see cref="M:System.Net.Sockets.Socket.BeginSendFile(System.String,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету. См. ниже примeчания к данному разделу.</exception>
		// Token: 0x06003E03 RID: 15875 RVA: 0x000D462C File Offset: 0x000D282C
		public void EndSendFile(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			Socket.SendFileAsyncResult sendFileAsyncResult = asyncResult as Socket.SendFileAsyncResult;
			if (sendFileAsyncResult == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			sendFileAsyncResult.Delegate.EndInvoke(sendFileAsyncResult.Original);
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x000D4678 File Offset: 0x000D2878
		private static bool SendFile_internal(SafeSocketHandle safeHandle, string filename, byte[] pre_buffer, byte[] post_buffer, TransmitFileOptions flags, out int error, bool blocking)
		{
			bool result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.SendFile_icall(safeHandle.DangerousGetHandle(), filename, pre_buffer, post_buffer, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06003E05 RID: 15877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SendFile_icall(IntPtr sock, string filename, byte[] pre_buffer, byte[] post_buffer, TransmitFileOptions flags, out int error, bool blocking);

		/// <summary>Выполняет асинхронную передачу набора файла или буферов данных в памяти на подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="e">Объект <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> для использования в данной асинхронной операции сокета.</param>
		/// <returns>
		///   <see langword="true" />, если операция ввода-вывода находится в состоянии ожидания. По завершении операции создается событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> в параметре <paramref name="e" />.  
		///  <see langword="false" />, если операция ввода-вывода завершена синхронно. В данном случае событие <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> на параметре <paramref name="e" /> не будет создано и объект <paramref name="e" />, передаваемый как параметр, можно изучить сразу после получения результатов вызова метода для извлечения результатов операции.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, указанный в свойстве <see cref="P:System.Net.Sockets.SendPacketsElement.FilePath" />, не найден.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция сокета уже выполнялась с использованием объекта <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, указанного в параметре <paramref name="e" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод доступен только в Windows XP и более поздних версиях. Это исключение возникает также в том случае, когда объект <see cref="T:System.Net.Sockets.Socket" /> не подключен к удаленному узлу.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Используется объект <see cref="T:System.Net.Sockets.Socket" />, функционирующий без установления соединения, и размер отправляемого файла превышает максимальный размер пакета основного транспортного средства.</exception>
		// Token: 0x06003E06 RID: 15878 RVA: 0x000D3A39 File Offset: 0x000D1C39
		[MonoTODO("Not implemented")]
		public bool SendPacketsAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			throw new NotImplementedException();
		}

		// Token: 0x06003E07 RID: 15879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Duplicate_icall(IntPtr handle, int targetProcessId, out IntPtr duplicateHandle, out MonoIOError error);

		/// <summary>Дублирует ссылку сокета для конечного процесса и закрывает сокет для этого процесса.</summary>
		/// <param name="targetProcessId">Идентификатор конечного процесса, в котором создается дубликат ссылки сокета.</param>
		/// <returns>Ссылка сокета, передаваемая в конечный процесс.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Параметр <paramref name="targetProcessID" /> не является допустимым идентификатором процесса. 
		/// -или- 
		/// Дубликат ссылки сокета не создан.</exception>
		// Token: 0x06003E08 RID: 15880 RVA: 0x000D46BC File Offset: 0x000D28BC
		[MonoLimitation("We do not support passing sockets across processes, we merely allow this API to pass the socket across AppDomains")]
		public SocketInformation DuplicateAndClose(int targetProcessId)
		{
			SocketInformation result = default(SocketInformation);
			result.Options = ((this.is_listening ? SocketInformationOptions.Listening : ((SocketInformationOptions)0)) | (this.is_connected ? SocketInformationOptions.Connected : ((SocketInformationOptions)0)) | (this.is_blocking ? ((SocketInformationOptions)0) : SocketInformationOptions.NonBlocking) | (this.useOverlappedIO ? SocketInformationOptions.UseOnlyOverlappedIO : ((SocketInformationOptions)0)));
			IntPtr value;
			MonoIOError error;
			if (!Socket.Duplicate_icall(this.Handle, targetProcessId, out value, out error))
			{
				throw MonoIO.GetException(error);
			}
			result.ProtocolInformation = DataConverter.Pack("iiiil", new object[]
			{
				(int)this.addressFamily,
				(int)this.socketType,
				(int)this.protocolType,
				this.is_bound ? 1 : 0,
				(long)value
			});
			this.m_Handle = null;
			return result;
		}

		/// <summary>Возвращает указанное значение параметра <see cref="T:System.Net.Sockets.Socket" />, представленного в виде байтового массива.</summary>
		/// <param name="optionLevel">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionLevel" />.</param>
		/// <param name="optionName">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionName" />.</param>
		/// <param name="optionValue">Массив типа <see cref="T:System.Byte" />, который используется для отправки значения параметра.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.  
		/// -или- 
		/// В приложениях .NET Compact Framework для размера буферного пространства Windows CE установлено по умолчанию значение 32768 байт. Можно изменить размер буферного пространства сокета, вызвав свойство <see cref="Overload:System.Net.Sockets.Socket.SetSocketOption" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003E09 RID: 15881 RVA: 0x000D4790 File Offset: 0x000D2990
		public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
		{
			this.ThrowIfDisposedAndClosed();
			if (optionValue == null)
			{
				throw new SocketException(10014, "Error trying to dereference an invalid pointer");
			}
			int num;
			Socket.GetSocketOption_arr_internal(this.m_Handle, optionLevel, optionName, ref optionValue, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
		}

		/// <summary>Возвращает значение указанного параметра <see cref="T:System.Net.Sockets.Socket" /> в массиве.</summary>
		/// <param name="optionLevel">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionLevel" />.</param>
		/// <param name="optionName">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionName" />.</param>
		/// <param name="optionLength">Длина ожидаемого возвращаемого значения, указанная в байтах.</param>
		/// <returns>Массив типа <see cref="T:System.Byte" />, который содержит значение параметра сокета.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.  
		/// -или- 
		/// В приложениях .NET Compact Framework для размера буферного пространства Windows CE установлено по умолчанию значение 32768 байт. Можно изменить размер буферного пространства сокета, вызвав свойство <see cref="Overload:System.Net.Sockets.Socket.SetSocketOption" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003E0A RID: 15882 RVA: 0x000D47D4 File Offset: 0x000D29D4
		public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength)
		{
			this.ThrowIfDisposedAndClosed();
			byte[] result = new byte[optionLength];
			int num;
			Socket.GetSocketOption_arr_internal(this.m_Handle, optionLevel, optionName, ref result, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			return result;
		}

		/// <summary>Возвращает значение указанного параметра <see cref="T:System.Net.Sockets.Socket" />, представленного в виде объекта.</summary>
		/// <param name="optionLevel">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionLevel" />.</param>
		/// <param name="optionName">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionName" />.</param>
		/// <returns>Объект, который представляет значение параметра. Когда для параметра <paramref name="optionName" /> установлено значение <see cref="F:System.Net.Sockets.SocketOptionName.Linger" />, возвращаемое значение является экземпляром класса <see cref="T:System.Net.Sockets.LingerOption" />. Когда для параметра <paramref name="optionName" /> задано значение <see cref="F:System.Net.Sockets.SocketOptionName.AddMembership" /> или <see cref="F:System.Net.Sockets.SocketOptionName.DropMembership" />, возвращаемое значение является экземпляром класса <see cref="T:System.Net.Sockets.MulticastOption" />. Когда для параметра <paramref name="optionName" /> задано любое другое значение, возвращаемое значение является целым числом.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.  
		/// -или- 
		///  Для параметра <paramref name="optionName" /> было установлено неподдерживаемое значение <see cref="F:System.Net.Sockets.SocketOptionName.MaxConnections" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003E0B RID: 15883 RVA: 0x000D480C File Offset: 0x000D2A0C
		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			this.ThrowIfDisposedAndClosed();
			object obj;
			int num;
			Socket.GetSocketOption_obj_internal(this.m_Handle, optionLevel, optionName, out obj, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			if (optionName == SocketOptionName.Linger)
			{
				return (LingerOption)obj;
			}
			if (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership)
			{
				return (MulticastOption)obj;
			}
			if (obj is int)
			{
				return (int)obj;
			}
			return obj;
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x000D4870 File Offset: 0x000D2A70
		private static void GetSocketOption_arr_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, ref byte[] byte_val, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.GetSocketOption_arr_icall(safeHandle.DangerousGetHandle(), level, name, ref byte_val, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06003E0D RID: 15885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSocketOption_arr_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, ref byte[] byte_val, out int error);

		// Token: 0x06003E0E RID: 15886 RVA: 0x000D48B4 File Offset: 0x000D2AB4
		private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.GetSocketOption_obj_icall(safeHandle.DangerousGetHandle(), level, name, out obj_val, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06003E0F RID: 15887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error);

		/// <summary>Устанавливает для указанного параметра <see cref="T:System.Net.Sockets.Socket" /> заданное значение, представленное в виде байтового массива.</summary>
		/// <param name="optionLevel">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionLevel" />.</param>
		/// <param name="optionName">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionName" />.</param>
		/// <param name="optionValue">Массив типа <see cref="T:System.Byte" />, который представляет значение параметра.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003E10 RID: 15888 RVA: 0x000D48F8 File Offset: 0x000D2AF8
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
		{
			this.ThrowIfDisposedAndClosed();
			if (optionValue == null)
			{
				throw new SocketException(10014, "Error trying to dereference an invalid pointer");
			}
			int num;
			Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, null, optionValue, 0, out num);
			if (num == 0)
			{
				return;
			}
			if (num == 10022)
			{
				throw new ArgumentException();
			}
			throw new SocketException(num);
		}

		/// <summary>Устанавливает для указанного параметра <see cref="T:System.Net.Sockets.Socket" /> заданное значение, представленное в виде объекта.</summary>
		/// <param name="optionLevel">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionLevel" />.</param>
		/// <param name="optionName">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionName" />.</param>
		/// <param name="optionValue">Объект <see cref="T:System.Net.Sockets.LingerOption" /> или <see cref="T:System.Net.Sockets.MulticastOption" />, содержащий значение параметра.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="optionValue" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003E11 RID: 15889 RVA: 0x000D4948 File Offset: 0x000D2B48
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue)
		{
			this.ThrowIfDisposedAndClosed();
			if (optionValue == null)
			{
				throw new ArgumentNullException("optionValue");
			}
			int num;
			if (optionLevel == SocketOptionLevel.Socket && optionName == SocketOptionName.Linger)
			{
				LingerOption lingerOption = optionValue as LingerOption;
				if (lingerOption == null)
				{
					throw new ArgumentException("A 'LingerOption' value must be specified.", "optionValue");
				}
				Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, lingerOption, null, 0, out num);
			}
			else if (optionLevel == SocketOptionLevel.IP && (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership))
			{
				MulticastOption multicastOption = optionValue as MulticastOption;
				if (multicastOption == null)
				{
					throw new ArgumentException("A 'MulticastOption' value must be specified.", "optionValue");
				}
				Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, multicastOption, null, 0, out num);
			}
			else
			{
				if (optionLevel != SocketOptionLevel.IPv6 || (optionName != SocketOptionName.AddMembership && optionName != SocketOptionName.DropMembership))
				{
					throw new ArgumentException("Invalid value specified.", "optionValue");
				}
				IPv6MulticastOption pv6MulticastOption = optionValue as IPv6MulticastOption;
				if (pv6MulticastOption == null)
				{
					throw new ArgumentException("A 'IPv6MulticastOption' value must be specified.", "optionValue");
				}
				Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, pv6MulticastOption, null, 0, out num);
			}
			if (num == 0)
			{
				return;
			}
			if (num == 10022)
			{
				throw new ArgumentException();
			}
			throw new SocketException(num);
		}

		/// <summary>Устанавливает для заданного параметра <see cref="T:System.Net.Sockets.Socket" /> указанное значение <see cref="T:System.Boolean" />.</summary>
		/// <param name="optionLevel">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionLevel" />.</param>
		/// <param name="optionName">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionName" />.</param>
		/// <param name="optionValue">Значение параметра, представленное в виде объекта <see cref="T:System.Boolean" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		// Token: 0x06003E12 RID: 15890 RVA: 0x000D4A4C File Offset: 0x000D2C4C
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue)
		{
			int optionValue2 = optionValue ? 1 : 0;
			this.SetSocketOption(optionLevel, optionName, optionValue2);
		}

		/// <summary>Устанавливает заданное целое значение для указанного параметра <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="optionLevel">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionLevel" />.</param>
		/// <param name="optionName">Одно из значений <see cref="T:System.Net.Sockets.SocketOptionName" />.</param>
		/// <param name="optionValue">Значение параметра.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003E13 RID: 15891 RVA: 0x000D4A6C File Offset: 0x000D2C6C
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			this.ThrowIfDisposedAndClosed();
			int num;
			Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, null, null, optionValue, out num);
			if (num == 0)
			{
				return;
			}
			if (num == 10022)
			{
				throw new ArgumentException();
			}
			throw new SocketException(num);
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x000D4AAC File Offset: 0x000D2CAC
		private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.SetSocketOption_icall(safeHandle.DangerousGetHandle(), level, name, obj_val, byte_val, int_val, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06003E15 RID: 15893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error);

		/// <summary>Задает низкоуровневые операционные режимы для объекта <see cref="T:System.Net.Sockets.Socket" />, используя цифровые коды элементов управления.</summary>
		/// <param name="ioControlCode">Значение <see cref="T:System.Int32" />, задающее код элемента управления для выполняемой операции.</param>
		/// <param name="optionInValue">Массив <see cref="T:System.Byte" />, который содержит входные данные, необходимые для операции.</param>
		/// <param name="optionOutValue">Массив <see cref="T:System.Byte" />, который содержит выходные данные, необходимые для операции.</param>
		/// <returns>Число байтов в параметре <paramref name="optionOutValue" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Была сделана попытка изменения блокирующего режима без использования свойства <see cref="P:System.Net.Sockets.Socket.Blocking" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор в стеке вызовов не имеет необходимых разрешений.</exception>
		// Token: 0x06003E16 RID: 15894 RVA: 0x000D4AF4 File Offset: 0x000D2CF4
		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			if (this.CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
			int num2;
			int num = Socket.IOControl_internal(this.m_Handle, ioControlCode, optionInValue, optionOutValue, out num2);
			if (num2 != 0)
			{
				throw new SocketException(num2);
			}
			if (num == -1)
			{
				throw new InvalidOperationException("Must use Blocking property instead.");
			}
			return num;
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x000D4B44 File Offset: 0x000D2D44
		private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error)
		{
			bool flag = false;
			int result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.IOControl_icall(safeHandle.DangerousGetHandle(), ioctl_code, input, output, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06003E18 RID: 15896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error);

		/// <summary>Закрывает подключение <see cref="T:System.Net.Sockets.Socket" /> и освобождает все связанные ресурсы.</summary>
		// Token: 0x06003E19 RID: 15897 RVA: 0x000D4B8C File Offset: 0x000D2D8C
		public void Close()
		{
			this.linger_timeout = 0;
			this.Dispose();
		}

		/// <summary>Закрывает подключение <see cref="T:System.Net.Sockets.Socket" /> и освобождает все связанные ресурсы с заданным временем ожидания, чтобы разрешить отправку данных в очереди.</summary>
		/// <param name="timeout">Процесс ожидает указанное число секунд <paramref name="timeout" />, прежде чем отправить оставшиеся данные, а затем закрывает сокет.</param>
		// Token: 0x06003E1A RID: 15898 RVA: 0x000D4B9B File Offset: 0x000D2D9B
		public void Close(int timeout)
		{
			this.linger_timeout = timeout;
			this.Dispose();
		}

		// Token: 0x06003E1B RID: 15899
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Close_icall(IntPtr socket, out int error);

		/// <summary>Блокирует передачу и получение данных для объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="how">Одно из значений <see cref="T:System.Net.Sockets.SocketShutdown" />, указывающее на то, что операция более не разрешена.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003E1C RID: 15900 RVA: 0x000D4BAC File Offset: 0x000D2DAC
		public void Shutdown(SocketShutdown how)
		{
			this.ThrowIfDisposedAndClosed();
			if (!this.is_connected)
			{
				throw new SocketException(10057);
			}
			int num;
			Socket.Shutdown_internal(this.m_Handle, how, out num);
			if (num == 10057)
			{
				return;
			}
			if (num != 0)
			{
				throw new SocketException(num);
			}
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x000D4BF4 File Offset: 0x000D2DF4
		private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Shutdown_icall(safeHandle.DangerousGetHandle(), how, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06003E1E RID: 15902
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error);

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Sockets.Socket" />, и при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x06003E1F RID: 15903 RVA: 0x000D4C34 File Offset: 0x000D2E34
		protected virtual void Dispose(bool disposing)
		{
			if (this.CleanedUp)
			{
				return;
			}
			this.m_IntCleanedUp = 1;
			bool flag = this.is_connected;
			this.is_connected = false;
			if (this.m_Handle != null)
			{
				this.is_closed = true;
				IntPtr handle = this.Handle;
				if (flag)
				{
					this.Linger(handle);
				}
				this.m_Handle.Dispose();
			}
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x000D4C8C File Offset: 0x000D2E8C
		private void Linger(IntPtr handle)
		{
			if (!this.is_connected || this.linger_timeout <= 0)
			{
				return;
			}
			int num;
			Socket.Shutdown_icall(handle, SocketShutdown.Receive, out num);
			if (num != 0)
			{
				return;
			}
			int num2 = this.linger_timeout / 1000;
			int num3 = this.linger_timeout % 1000;
			if (num3 > 0)
			{
				Socket.Poll_icall(handle, SelectMode.SelectRead, num3 * 1000, out num);
				if (num != 0)
				{
					return;
				}
			}
			if (num2 > 0)
			{
				LingerOption obj_val = new LingerOption(true, num2);
				Socket.SetSocketOption_icall(handle, SocketOptionLevel.Socket, SocketOptionName.Linger, obj_val, null, 0, out num);
			}
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x000D4D0C File Offset: 0x000D2F0C
		private void ThrowIfDisposedAndClosed(Socket socket)
		{
			if (socket.CleanedUp && socket.is_closed)
			{
				throw new ObjectDisposedException(socket.GetType().ToString());
			}
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x000D4D2F File Offset: 0x000D2F2F
		private void ThrowIfDisposedAndClosed()
		{
			if (this.CleanedUp && this.is_closed)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x000D4D52 File Offset: 0x000D2F52
		private void ThrowIfBufferNull(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x000D4D64 File Offset: 0x000D2F64
		private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size)
		{
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "offset must be >= 0");
			}
			if (offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset", "offset must be <= buffer.Length");
			}
			if (size < 0)
			{
				throw new ArgumentOutOfRangeException("size", "size must be >= 0");
			}
			if (size > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("size", "size must be <= buffer.Length - offset");
			}
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x000D4DC7 File Offset: 0x000D2FC7
		private void ThrowIfUdp()
		{
			if (this.protocolType == ProtocolType.Udp)
			{
				throw new SocketException(10042);
			}
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x000D4DE0 File Offset: 0x000D2FE0
		private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			if (ares == null)
			{
				throw new ArgumentNullException(argName);
			}
			SocketAsyncResult socketAsyncResult = ares as SocketAsyncResult;
			if (socketAsyncResult == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", argName);
			}
			if (Interlocked.CompareExchange(ref socketAsyncResult.EndCalled, 1, 0) == 1)
			{
				throw new InvalidOperationException(methodName + " can only be called once per asynchronous operation");
			}
			return socketAsyncResult;
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x000D4E30 File Offset: 0x000D3030
		private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
		{
			Task task = sem.WaitAsync();
			if (!task.IsCompleted)
			{
				task.ContinueWith(delegate(Task t)
				{
					if (this.CleanedUp)
					{
						job.MarkDisposed();
						return;
					}
					IOSelector.Add(handle, job);
				});
				return;
			}
			if (this.CleanedUp)
			{
				job.MarkDisposed();
				return;
			}
			IOSelector.Add(handle, job);
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x000D4EA0 File Offset: 0x000D30A0
		private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation)
		{
			e.socket_async_result.Init(this, callback, state, operation);
			if (e.AcceptSocket != null)
			{
				e.socket_async_result.AcceptSocket = e.AcceptSocket;
			}
			e.SetCurrentSocket(this);
			e.SetLastOperation(this.SocketOperationToSocketAsyncOperation(operation));
			e.SocketError = SocketError.Success;
			e.SetBytesTransferred(0);
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x000D4EFC File Offset: 0x000D30FC
		private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
		{
			switch (op)
			{
			case SocketOperation.Accept:
				return SocketAsyncOperation.Accept;
			case SocketOperation.Connect:
				return SocketAsyncOperation.Connect;
			case SocketOperation.Receive:
			case SocketOperation.ReceiveGeneric:
				return SocketAsyncOperation.Receive;
			case SocketOperation.ReceiveFrom:
				return SocketAsyncOperation.ReceiveFrom;
			case SocketOperation.Send:
			case SocketOperation.SendGeneric:
				return SocketAsyncOperation.Send;
			case SocketOperation.SendTo:
				return SocketAsyncOperation.SendTo;
			case SocketOperation.Disconnect:
				return SocketAsyncOperation.Disconnect;
			}
			throw new NotImplementedException(string.Format("Operation {0} is not implemented", op));
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x000D4F65 File Offset: 0x000D3165
		private IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			if (this.IsDualMode && input.AddressFamily == AddressFamily.InterNetwork)
			{
				return new IPEndPoint(input.Address.MapToIPv6(), input.Port);
			}
			return input;
		}

		// Token: 0x06003E2B RID: 15915
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void cancel_blocking_socket_operation(Thread thread);

		// Token: 0x06003E2C RID: 15916
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool SupportsPortReuse(ProtocolType proto);

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06003E2D RID: 15917 RVA: 0x000D4F90 File Offset: 0x000D3190
		internal static int FamilyHint
		{
			get
			{
				int num = 0;
				if (Socket.OSSupportsIPv4)
				{
					num = 1;
				}
				if (Socket.OSSupportsIPv6)
				{
					num = ((num == 0) ? 2 : 0);
				}
				return num;
			}
		}

		// Token: 0x06003E2E RID: 15918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface);

		// Token: 0x06003E2F RID: 15919 RVA: 0x000D4FB8 File Offset: 0x000D31B8
		private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
		{
			return Socket.IsProtocolSupported_internal(networkInterface);
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00003917 File Offset: 0x00001B17
		internal void ReplaceHandleIfNecessaryAfterFailedConnect()
		{
		}

		// Token: 0x04002423 RID: 9251
		private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
		{
			Socket.CompleteAccept((Socket)s, (Socket.TaskSocketAsyncEventArgs<Socket>)e);
		};

		// Token: 0x04002424 RID: 9252
		private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
		{
			Socket.CompleteSendReceive((Socket)s, (Socket.Int32TaskSocketAsyncEventArgs)e, true);
		};

		// Token: 0x04002425 RID: 9253
		private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
		{
			Socket.CompleteSendReceive((Socket)s, (Socket.Int32TaskSocketAsyncEventArgs)e, false);
		};

		// Token: 0x04002426 RID: 9254
		private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel = new Socket.TaskSocketAsyncEventArgs<Socket>();

		// Token: 0x04002427 RID: 9255
		private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel = new Socket.Int32TaskSocketAsyncEventArgs();

		// Token: 0x04002428 RID: 9256
		private static readonly Task<int> s_zeroTask = Task.FromResult<int>(0);

		// Token: 0x04002429 RID: 9257
		private Socket.CachedEventArgs _cachedTaskEventArgs;

		// Token: 0x0400242A RID: 9258
		private static object s_InternalSyncObject;

		// Token: 0x0400242B RID: 9259
		internal static volatile bool s_SupportsIPv4;

		// Token: 0x0400242C RID: 9260
		internal static volatile bool s_SupportsIPv6;

		// Token: 0x0400242D RID: 9261
		internal static volatile bool s_OSSupportsIPv6;

		// Token: 0x0400242E RID: 9262
		internal static volatile bool s_Initialized;

		// Token: 0x0400242F RID: 9263
		private static volatile bool s_LoggingEnabled;

		// Token: 0x04002430 RID: 9264
		internal static volatile bool s_PerfCountersEnabled;

		// Token: 0x04002431 RID: 9265
		internal const int DefaultCloseTimeout = -1;

		// Token: 0x04002432 RID: 9266
		private const int SOCKET_CLOSED_CODE = 10004;

		// Token: 0x04002433 RID: 9267
		private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";

		// Token: 0x04002434 RID: 9268
		private bool is_closed;

		// Token: 0x04002435 RID: 9269
		private bool is_listening;

		// Token: 0x04002436 RID: 9270
		private bool useOverlappedIO;

		// Token: 0x04002437 RID: 9271
		private int linger_timeout;

		// Token: 0x04002438 RID: 9272
		private AddressFamily addressFamily;

		// Token: 0x04002439 RID: 9273
		private SocketType socketType;

		// Token: 0x0400243A RID: 9274
		private ProtocolType protocolType;

		// Token: 0x0400243B RID: 9275
		internal SafeSocketHandle m_Handle;

		// Token: 0x0400243C RID: 9276
		internal EndPoint seed_endpoint;

		// Token: 0x0400243D RID: 9277
		internal SemaphoreSlim ReadSem;

		// Token: 0x0400243E RID: 9278
		internal SemaphoreSlim WriteSem;

		// Token: 0x0400243F RID: 9279
		internal bool is_blocking;

		// Token: 0x04002440 RID: 9280
		internal bool is_bound;

		// Token: 0x04002441 RID: 9281
		internal bool is_connected;

		// Token: 0x04002442 RID: 9282
		private int m_IntCleanedUp;

		// Token: 0x04002443 RID: 9283
		internal bool connect_in_progress;

		// Token: 0x04002444 RID: 9284
		internal readonly int ID;

		// Token: 0x04002445 RID: 9285
		private static AsyncCallback AcceptAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.AcceptSocket = socketAsyncEventArgs.CurrentSocket.EndAccept(ares);
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				if (socketAsyncEventArgs.AcceptSocket == null)
				{
					socketAsyncEventArgs.AcceptSocket = new Socket(socketAsyncEventArgs.CurrentSocket.AddressFamily, socketAsyncEventArgs.CurrentSocket.SocketType, socketAsyncEventArgs.CurrentSocket.ProtocolType, null);
				}
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04002446 RID: 9286
		private static IOAsyncCallback BeginAcceptCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			Socket socket = null;
			try
			{
				if (socketAsyncResult.AcceptSocket == null)
				{
					socket = socketAsyncResult.socket.Accept();
				}
				else
				{
					socket = socketAsyncResult.AcceptSocket;
					socketAsyncResult.socket.Accept(socket);
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(socket);
		};

		// Token: 0x04002447 RID: 9287
		private static IOAsyncCallback BeginAcceptReceiveCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			Socket socket = null;
			try
			{
				if (socketAsyncResult.AcceptSocket == null)
				{
					socket = socketAsyncResult.socket.Accept();
				}
				else
				{
					socket = socketAsyncResult.AcceptSocket;
					socketAsyncResult.socket.Accept(socket);
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			int total = 0;
			if (socketAsyncResult.Size > 0)
			{
				try
				{
					SocketError socketError;
					total = socket.Receive(socketAsyncResult.Buffer, socketAsyncResult.Offset, socketAsyncResult.Size, socketAsyncResult.SockFlags, out socketError);
					if (socketError != SocketError.Success)
					{
						socketAsyncResult.Complete(new SocketException((int)socketError));
						return;
					}
				}
				catch (Exception e2)
				{
					socketAsyncResult.Complete(e2);
					return;
				}
			}
			socketAsyncResult.Complete(socket, total);
		};

		// Token: 0x04002448 RID: 9288
		private static AsyncCallback ConnectAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.CurrentSocket.EndConnect(ares);
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04002449 RID: 9289
		private static IOAsyncCallback BeginConnectCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			if (socketAsyncResult.EndPoint == null)
			{
				socketAsyncResult.Complete(new SocketException(10049));
				return;
			}
			try
			{
				int num = (int)socketAsyncResult.socket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error);
				if (num == 0)
				{
					socketAsyncResult.socket.seed_endpoint = socketAsyncResult.EndPoint;
					socketAsyncResult.socket.is_connected = true;
					socketAsyncResult.socket.is_bound = true;
					socketAsyncResult.socket.connect_in_progress = false;
					socketAsyncResult.error = 0;
					socketAsyncResult.Complete();
				}
				else if (socketAsyncResult.Addresses == null)
				{
					socketAsyncResult.socket.connect_in_progress = false;
					socketAsyncResult.Complete(new SocketException(num));
				}
				else if (socketAsyncResult.CurrentAddress >= socketAsyncResult.Addresses.Length)
				{
					socketAsyncResult.Complete(new SocketException(num));
				}
				else
				{
					Socket.BeginMConnect(socketAsyncResult);
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.socket.connect_in_progress = false;
				socketAsyncResult.Complete(e);
			}
		};

		// Token: 0x0400244A RID: 9290
		private static AsyncCallback DisconnectAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.CurrentSocket.EndDisconnect(ares);
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x0400244B RID: 9291
		private static IOAsyncCallback BeginDisconnectCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			try
			{
				socketAsyncResult.socket.Disconnect(socketAsyncResult.ReuseSocket);
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete();
		};

		// Token: 0x0400244C RID: 9292
		private static AsyncCallback ReceiveAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.SetBytesTransferred(socketAsyncEventArgs.CurrentSocket.EndReceive(ares));
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x0400244D RID: 9293
		private static IOAsyncCallback BeginReceiveCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			int total = 0;
			try
			{
				using (MemoryHandle memoryHandle = socketAsyncResult.Buffer.Slice(socketAsyncResult.Offset, socketAsyncResult.Size).Pin())
				{
					total = Socket.Receive_internal(socketAsyncResult.socket.m_Handle, (byte*)memoryHandle.Pointer, socketAsyncResult.Size, socketAsyncResult.SockFlags, out socketAsyncResult.error, socketAsyncResult.socket.is_blocking);
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(total);
		};

		// Token: 0x0400244E RID: 9294
		private static IOAsyncCallback BeginReceiveGenericCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			int total = 0;
			try
			{
				total = socketAsyncResult.socket.Receive(socketAsyncResult.Buffers, socketAsyncResult.SockFlags);
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(total);
		};

		// Token: 0x0400244F RID: 9295
		private static AsyncCallback ReceiveFromAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.SetBytesTransferred(socketAsyncEventArgs.CurrentSocket.EndReceiveFrom_internal((SocketAsyncResult)ares, socketAsyncEventArgs));
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04002450 RID: 9296
		private static IOAsyncCallback BeginReceiveFromCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			int total = 0;
			try
			{
				SocketError socketError;
				total = socketAsyncResult.socket.ReceiveFrom(socketAsyncResult.Buffer, socketAsyncResult.Offset, socketAsyncResult.Size, socketAsyncResult.SockFlags, ref socketAsyncResult.EndPoint, out socketError);
				if (socketError != SocketError.Success)
				{
					socketAsyncResult.Complete(new SocketException(socketError));
					return;
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(total);
		};

		// Token: 0x04002451 RID: 9297
		private static AsyncCallback SendAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.SetBytesTransferred(socketAsyncEventArgs.CurrentSocket.EndSend(ares));
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04002452 RID: 9298
		private static IOAsyncCallback BeginSendGenericCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			int total = 0;
			try
			{
				total = socketAsyncResult.socket.Send(socketAsyncResult.Buffers, socketAsyncResult.SockFlags);
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(total);
		};

		// Token: 0x04002453 RID: 9299
		private static AsyncCallback SendToAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.SetBytesTransferred(socketAsyncEventArgs.CurrentSocket.EndSendTo(ares));
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x02000794 RID: 1940
		private class StateTaskCompletionSource<TField1, TResult> : TaskCompletionSource<TResult>
		{
			// Token: 0x06003E32 RID: 15922 RVA: 0x000D5166 File Offset: 0x000D3366
			public StateTaskCompletionSource(object baseState) : base(baseState)
			{
			}

			// Token: 0x04002454 RID: 9300
			internal TField1 _field1;
		}

		// Token: 0x02000795 RID: 1941
		private class StateTaskCompletionSource<TField1, TField2, TResult> : Socket.StateTaskCompletionSource<TField1, TResult>
		{
			// Token: 0x06003E33 RID: 15923 RVA: 0x000D516F File Offset: 0x000D336F
			public StateTaskCompletionSource(object baseState) : base(baseState)
			{
			}

			// Token: 0x04002455 RID: 9301
			internal TField2 _field2;
		}

		// Token: 0x02000796 RID: 1942
		private sealed class CachedEventArgs
		{
			// Token: 0x04002456 RID: 9302
			public Socket.TaskSocketAsyncEventArgs<Socket> TaskAccept;

			// Token: 0x04002457 RID: 9303
			public Socket.Int32TaskSocketAsyncEventArgs TaskReceive;

			// Token: 0x04002458 RID: 9304
			public Socket.Int32TaskSocketAsyncEventArgs TaskSend;

			// Token: 0x04002459 RID: 9305
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;

			// Token: 0x0400245A RID: 9306
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;
		}

		// Token: 0x02000797 RID: 1943
		private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
		{
			// Token: 0x06003E35 RID: 15925 RVA: 0x000D5178 File Offset: 0x000D3378
			internal TaskSocketAsyncEventArgs() : base(false)
			{
			}

			// Token: 0x06003E36 RID: 15926 RVA: 0x000D5184 File Offset: 0x000D3384
			internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
			{
				AsyncTaskMethodBuilder<TResult> builder;
				lock (this)
				{
					responsibleForReturningToPool = this._accessed;
					this._accessed = true;
					Task<TResult> task = this._builder.Task;
					builder = this._builder;
				}
				return builder;
			}

			// Token: 0x0400245B RID: 9307
			internal AsyncTaskMethodBuilder<TResult> _builder;

			// Token: 0x0400245C RID: 9308
			internal bool _accessed;
		}

		// Token: 0x02000798 RID: 1944
		private sealed class Int32TaskSocketAsyncEventArgs : Socket.TaskSocketAsyncEventArgs<int>
		{
			// Token: 0x0400245D RID: 9309
			internal bool _wrapExceptionsInIOExceptions;
		}

		// Token: 0x02000799 RID: 1945
		internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int>
		{
			// Token: 0x06003E38 RID: 15928 RVA: 0x000D51E4 File Offset: 0x000D33E4
			public AwaitableSocketAsyncEventArgs() : base(false)
			{
			}

			// Token: 0x17000E25 RID: 3621
			// (get) Token: 0x06003E39 RID: 15929 RVA: 0x000D51F8 File Offset: 0x000D33F8
			// (set) Token: 0x06003E3A RID: 15930 RVA: 0x000D5200 File Offset: 0x000D3400
			public bool WrapExceptionsInIOExceptions { get; set; }

			// Token: 0x06003E3B RID: 15931 RVA: 0x000D5209 File Offset: 0x000D3409
			public bool Reserve()
			{
				return Interlocked.CompareExchange<Action<object>>(ref this._continuation, null, Socket.AwaitableSocketAsyncEventArgs.s_availableSentinel) == Socket.AwaitableSocketAsyncEventArgs.s_availableSentinel;
			}

			// Token: 0x06003E3C RID: 15932 RVA: 0x000D5223 File Offset: 0x000D3423
			private void Release()
			{
				this._token += 1;
				Volatile.Write<Action<object>>(ref this._continuation, Socket.AwaitableSocketAsyncEventArgs.s_availableSentinel);
			}

			// Token: 0x06003E3D RID: 15933 RVA: 0x000D5244 File Offset: 0x000D3444
			protected override void OnCompleted(SocketAsyncEventArgs _)
			{
				Action<object> action = this._continuation;
				if (action != null || (action = Interlocked.CompareExchange<Action<object>>(ref this._continuation, Socket.AwaitableSocketAsyncEventArgs.s_completedSentinel, null)) != null)
				{
					object userToken = base.UserToken;
					base.UserToken = null;
					this._continuation = Socket.AwaitableSocketAsyncEventArgs.s_completedSentinel;
					ExecutionContext executionContext = this._executionContext;
					if (executionContext == null)
					{
						this.InvokeContinuation(action, userToken, false);
						return;
					}
					this._executionContext = null;
					ExecutionContext.Run(executionContext, delegate(object runState)
					{
						Tuple<Socket.AwaitableSocketAsyncEventArgs, Action<object>, object> tuple = (Tuple<Socket.AwaitableSocketAsyncEventArgs, Action<object>, object>)runState;
						tuple.Item1.InvokeContinuation(tuple.Item2, tuple.Item3, false);
					}, Tuple.Create<Socket.AwaitableSocketAsyncEventArgs, Action<object>, object>(this, action, userToken));
				}
			}

			// Token: 0x06003E3E RID: 15934 RVA: 0x000D52D4 File Offset: 0x000D34D4
			public ValueTask<int> ReceiveAsync(Socket socket)
			{
				if (socket.ReceiveAsync(this))
				{
					return new ValueTask<int>(this, this._token);
				}
				int bytesTransferred = base.BytesTransferred;
				SocketError socketError = base.SocketError;
				this.Release();
				if (socketError != SocketError.Success)
				{
					return new ValueTask<int>(Task.FromException<int>(this.CreateException(socketError)));
				}
				return new ValueTask<int>(bytesTransferred);
			}

			// Token: 0x06003E3F RID: 15935 RVA: 0x000D5328 File Offset: 0x000D3528
			public ValueTask<int> SendAsync(Socket socket)
			{
				if (socket.SendAsync(this))
				{
					return new ValueTask<int>(this, this._token);
				}
				int bytesTransferred = base.BytesTransferred;
				SocketError socketError = base.SocketError;
				this.Release();
				if (socketError != SocketError.Success)
				{
					return new ValueTask<int>(Task.FromException<int>(this.CreateException(socketError)));
				}
				return new ValueTask<int>(bytesTransferred);
			}

			// Token: 0x06003E40 RID: 15936 RVA: 0x000D537C File Offset: 0x000D357C
			public ValueTask SendAsyncForNetworkStream(Socket socket)
			{
				if (socket.SendAsync(this))
				{
					return new ValueTask(this, this._token);
				}
				SocketError socketError = base.SocketError;
				this.Release();
				if (socketError != SocketError.Success)
				{
					return new ValueTask(Task.FromException(this.CreateException(socketError)));
				}
				return default(ValueTask);
			}

			// Token: 0x06003E41 RID: 15937 RVA: 0x000D53CA File Offset: 0x000D35CA
			public ValueTaskSourceStatus GetStatus(short token)
			{
				if (token != this._token)
				{
					this.ThrowIncorrectTokenException();
				}
				if (this._continuation != Socket.AwaitableSocketAsyncEventArgs.s_completedSentinel)
				{
					return ValueTaskSourceStatus.Pending;
				}
				if (base.SocketError != SocketError.Success)
				{
					return ValueTaskSourceStatus.Faulted;
				}
				return ValueTaskSourceStatus.Succeeded;
			}

			// Token: 0x06003E42 RID: 15938 RVA: 0x000D53F8 File Offset: 0x000D35F8
			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				if (token != this._token)
				{
					this.ThrowIncorrectTokenException();
				}
				if ((flags & ValueTaskSourceOnCompletedFlags.FlowExecutionContext) != ValueTaskSourceOnCompletedFlags.None)
				{
					this._executionContext = ExecutionContext.Capture();
				}
				if ((flags & ValueTaskSourceOnCompletedFlags.UseSchedulingContext) != ValueTaskSourceOnCompletedFlags.None)
				{
					SynchronizationContext synchronizationContext = SynchronizationContext.Current;
					if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
					{
						this._scheduler = synchronizationContext;
					}
					else
					{
						TaskScheduler taskScheduler = TaskScheduler.Current;
						if (taskScheduler != TaskScheduler.Default)
						{
							this._scheduler = taskScheduler;
						}
					}
				}
				base.UserToken = state;
				Action<object> action = Interlocked.CompareExchange<Action<object>>(ref this._continuation, continuation, null);
				if (action == Socket.AwaitableSocketAsyncEventArgs.s_completedSentinel)
				{
					this._executionContext = null;
					base.UserToken = null;
					this.InvokeContinuation(continuation, state, true);
					return;
				}
				if (action != null)
				{
					this.ThrowMultipleContinuationsException();
				}
			}

			// Token: 0x06003E43 RID: 15939 RVA: 0x000D54A8 File Offset: 0x000D36A8
			private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync)
			{
				object scheduler = this._scheduler;
				this._scheduler = null;
				if (scheduler != null)
				{
					SynchronizationContext synchronizationContext = scheduler as SynchronizationContext;
					if (synchronizationContext != null)
					{
						synchronizationContext.Post(delegate(object s)
						{
							Tuple<Action<object>, object> tuple = (Tuple<Action<object>, object>)s;
							tuple.Item1(tuple.Item2);
						}, Tuple.Create<Action<object>, object>(continuation, state));
						return;
					}
					Task.Factory.StartNew(continuation, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, (TaskScheduler)scheduler);
					return;
				}
				else
				{
					if (forceAsync)
					{
						ThreadPool.QueueUserWorkItem<object>(continuation, state, true);
						return;
					}
					continuation(state);
					return;
				}
			}

			// Token: 0x06003E44 RID: 15940 RVA: 0x000D552C File Offset: 0x000D372C
			public int GetResult(short token)
			{
				if (token != this._token)
				{
					this.ThrowIncorrectTokenException();
				}
				SocketError socketError = base.SocketError;
				int bytesTransferred = base.BytesTransferred;
				this.Release();
				if (socketError != SocketError.Success)
				{
					this.ThrowException(socketError);
				}
				return bytesTransferred;
			}

			// Token: 0x06003E45 RID: 15941 RVA: 0x000D5568 File Offset: 0x000D3768
			void IValueTaskSource.GetResult(short token)
			{
				if (token != this._token)
				{
					this.ThrowIncorrectTokenException();
				}
				SocketError socketError = base.SocketError;
				this.Release();
				if (socketError != SocketError.Success)
				{
					this.ThrowException(socketError);
				}
			}

			// Token: 0x06003E46 RID: 15942 RVA: 0x000D559B File Offset: 0x000D379B
			private void ThrowIncorrectTokenException()
			{
				throw new InvalidOperationException("The result of the operation was already consumed and may not be used again.");
			}

			// Token: 0x06003E47 RID: 15943 RVA: 0x000D55A7 File Offset: 0x000D37A7
			private void ThrowMultipleContinuationsException()
			{
				throw new InvalidOperationException("Another continuation was already registered.");
			}

			// Token: 0x06003E48 RID: 15944 RVA: 0x000D55B3 File Offset: 0x000D37B3
			private void ThrowException(SocketError error)
			{
				throw this.CreateException(error);
			}

			// Token: 0x06003E49 RID: 15945 RVA: 0x000D55BC File Offset: 0x000D37BC
			private Exception CreateException(SocketError error)
			{
				SocketException ex = new SocketException((int)error);
				if (!this.WrapExceptionsInIOExceptions)
				{
					return ex;
				}
				return new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}

			// Token: 0x0400245E RID: 9310
			internal static readonly Socket.AwaitableSocketAsyncEventArgs Reserved = new Socket.AwaitableSocketAsyncEventArgs
			{
				_continuation = null
			};

			// Token: 0x0400245F RID: 9311
			private static readonly Action<object> s_completedSentinel = delegate(object state)
			{
				throw new Exception("s_completedSentinel");
			};

			// Token: 0x04002460 RID: 9312
			private static readonly Action<object> s_availableSentinel = delegate(object state)
			{
				throw new Exception("s_availableSentinel");
			};

			// Token: 0x04002461 RID: 9313
			private Action<object> _continuation = Socket.AwaitableSocketAsyncEventArgs.s_availableSentinel;

			// Token: 0x04002462 RID: 9314
			private ExecutionContext _executionContext;

			// Token: 0x04002463 RID: 9315
			private object _scheduler;

			// Token: 0x04002464 RID: 9316
			private short _token;
		}

		// Token: 0x0200079B RID: 1947
		// (Invoke) Token: 0x06003E52 RID: 15954
		private delegate void SendFileHandler(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags);

		// Token: 0x0200079C RID: 1948
		private sealed class SendFileAsyncResult : IAsyncResult
		{
			// Token: 0x06003E55 RID: 15957 RVA: 0x000D56A5 File Offset: 0x000D38A5
			public SendFileAsyncResult(Socket.SendFileHandler d, IAsyncResult ares)
			{
				this.d = d;
				this.ares = ares;
			}

			// Token: 0x17000E26 RID: 3622
			// (get) Token: 0x06003E56 RID: 15958 RVA: 0x000D56BB File Offset: 0x000D38BB
			public object AsyncState
			{
				get
				{
					return this.ares.AsyncState;
				}
			}

			// Token: 0x17000E27 RID: 3623
			// (get) Token: 0x06003E57 RID: 15959 RVA: 0x000D56C8 File Offset: 0x000D38C8
			public WaitHandle AsyncWaitHandle
			{
				get
				{
					return this.ares.AsyncWaitHandle;
				}
			}

			// Token: 0x17000E28 RID: 3624
			// (get) Token: 0x06003E58 RID: 15960 RVA: 0x000D56D5 File Offset: 0x000D38D5
			public bool CompletedSynchronously
			{
				get
				{
					return this.ares.CompletedSynchronously;
				}
			}

			// Token: 0x17000E29 RID: 3625
			// (get) Token: 0x06003E59 RID: 15961 RVA: 0x000D56E2 File Offset: 0x000D38E2
			public bool IsCompleted
			{
				get
				{
					return this.ares.IsCompleted;
				}
			}

			// Token: 0x17000E2A RID: 3626
			// (get) Token: 0x06003E5A RID: 15962 RVA: 0x000D56EF File Offset: 0x000D38EF
			public Socket.SendFileHandler Delegate
			{
				get
				{
					return this.d;
				}
			}

			// Token: 0x17000E2B RID: 3627
			// (get) Token: 0x06003E5B RID: 15963 RVA: 0x000D56F7 File Offset: 0x000D38F7
			public IAsyncResult Original
			{
				get
				{
					return this.ares;
				}
			}

			// Token: 0x04002469 RID: 9321
			private IAsyncResult ares;

			// Token: 0x0400246A RID: 9322
			private Socket.SendFileHandler d;
		}

		// Token: 0x0200079D RID: 1949
		private struct WSABUF
		{
			// Token: 0x0400246B RID: 9323
			public int len;

			// Token: 0x0400246C RID: 9324
			public IntPtr buf;
		}
	}
}
