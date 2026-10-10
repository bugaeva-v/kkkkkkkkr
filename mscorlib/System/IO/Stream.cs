using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Предоставляет универсальное представление последовательности байтов. Этот класс является абстрактным.</summary>
	// Token: 0x02000B4A RID: 2890
	[Serializable]
	public abstract class Stream : MarshalByRefObject, IDisposable, IAsyncDisposable
	{
		// Token: 0x06006850 RID: 26704 RVA: 0x00164C6A File Offset: 0x00162E6A
		internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			return LazyInitializer.EnsureInitialized<SemaphoreSlim>(ref this._asyncActiveSemaphore, () => new SemaphoreSlim(1, 1));
		}

		/// <summary>При переопределении в производном классе возвращает значение, показывающее, поддерживает ли текущий поток возможность чтения.</summary>
		/// <returns>Значение <see langword="true" />, если поток поддерживает чтение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x06006851 RID: 26705
		public abstract bool CanRead { get; }

		/// <summary>При переопределении в производном классе возвращает значение, которое показывает, поддерживается ли в текущем потоке возможность поиска.</summary>
		/// <returns>Значение <see langword="true" />, если поток поддерживает поиск; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x06006852 RID: 26706
		public abstract bool CanSeek { get; }

		/// <summary>Возвращает значение, которое показывает, может ли для данного потока истечь время ожидания.</summary>
		/// <returns>Значение, которое показывает, может ли для данного потока истечь время ожидания.</returns>
		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x06006853 RID: 26707 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool CanTimeout
		{
			get
			{
				return false;
			}
		}

		/// <summary>При переопределении в производном классе возвращает значение, которое показывает, поддерживает ли текущий поток возможность записи.</summary>
		/// <returns>Значение <see langword="true" />, если поток поддерживает запись; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06006854 RID: 26708
		public abstract bool CanWrite { get; }

		/// <summary>При переопределении в производном классе получает длину потока в байтах.</summary>
		/// <returns>Длинное значение, представляющее длину потока в байтах.</returns>
		/// <exception cref="T:System.NotSupportedException">Класс, созданный на основе класса <see langword="Stream" />, не поддерживает возможность поиска.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06006855 RID: 26709
		public abstract long Length { get; }

		/// <summary>При переопределении в производном классе получает или задает позицию в текущем потоке.</summary>
		/// <returns>Текущее положение в потоке.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает поиск.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06006856 RID: 26710
		// (set) Token: 0x06006857 RID: 26711
		public abstract long Position { get; set; }

		/// <summary>Возвращает или задает значение в миллисекундах, определяющее период, в течение которого поток будет пытаться выполнить операцию чтения, прежде чем истечет время ожидания.</summary>
		/// <returns>Значение в миллисекундах, определяющее период, в течение которого поток будет пытаться выполнить операцию чтения, прежде чем истечет время ожидания.</returns>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="P:System.IO.Stream.ReadTimeout" /> всегда создает исключение <see cref="T:System.InvalidOperationException" />.</exception>
		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x06006858 RID: 26712 RVA: 0x00164C96 File Offset: 0x00162E96
		// (set) Token: 0x06006859 RID: 26713 RVA: 0x00164C96 File Offset: 0x00162E96
		public virtual int ReadTimeout
		{
			get
			{
				throw new InvalidOperationException("Timeouts are not supported on this stream.");
			}
			set
			{
				throw new InvalidOperationException("Timeouts are not supported on this stream.");
			}
		}

		/// <summary>Возвращает или задает значение в миллисекундах, определяющее период, в течение которого поток будет пытаться выполнить операцию записи, прежде чем истечет время ожидания.</summary>
		/// <returns>Значение в миллисекундах, определяющее период, в течение которого поток будет пытаться выполнить операцию записи, прежде чем истечет время ожидания.</returns>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="P:System.IO.Stream.WriteTimeout" /> всегда создает исключение <see cref="T:System.InvalidOperationException" />.</exception>
		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x00164C96 File Offset: 0x00162E96
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x00164C96 File Offset: 0x00162E96
		public virtual int WriteTimeout
		{
			get
			{
				throw new InvalidOperationException("Timeouts are not supported on this stream.");
			}
			set
			{
				throw new InvalidOperationException("Timeouts are not supported on this stream.");
			}
		}

		/// <summary>Асинхронно считывает байты из текущего потока и записывает их в другой поток.</summary>
		/// <param name="destination">Поток, в который будет скопировано содержимое текущего потока.</param>
		/// <returns>Задача, представляющая асинхронную операцию копирования.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destination" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток или поток назначения удаляется.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий поток не поддерживает чтение или поток назначения не поддерживает запись.</exception>
		// Token: 0x0600685C RID: 26716 RVA: 0x00164CA4 File Offset: 0x00162EA4
		public Task CopyToAsync(Stream destination)
		{
			int copyBufferSize = this.GetCopyBufferSize();
			return this.CopyToAsync(destination, copyBufferSize);
		}

		/// <summary>Асинхронно считывает байты из текущего потока и записывает их в другой поток, используя указанный размер буфера.</summary>
		/// <param name="destination">Поток, в который будет скопировано содержимое текущего потока.</param>
		/// <param name="bufferSize">Размер (в байтах) буфера. Это значение должно быть больше нуля. Размер по умолчанию — 81920.</param>
		/// <returns>Задача, представляющая асинхронную операцию копирования.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destination" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="buffersize" /> имеет отрицательное значение или равен нулю.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток или поток назначения удаляется.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий поток не поддерживает чтение или поток назначения не поддерживает запись.</exception>
		// Token: 0x0600685D RID: 26717 RVA: 0x00164CC0 File Offset: 0x00162EC0
		public Task CopyToAsync(Stream destination, int bufferSize)
		{
			return this.CopyToAsync(destination, bufferSize, CancellationToken.None);
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x00164CD0 File Offset: 0x00162ED0
		public Task CopyToAsync(Stream destination, CancellationToken cancellationToken)
		{
			int copyBufferSize = this.GetCopyBufferSize();
			return this.CopyToAsync(destination, copyBufferSize, cancellationToken);
		}

		/// <summary>Асинхронно считывает байты из текущего потока и записывает их в другой поток, используя указанный размер буфера и токен отмены.</summary>
		/// <param name="destination">Поток, в который будет скопировано содержимое текущего потока.</param>
		/// <param name="bufferSize">Размер (в байтах) буфера. Это значение должно быть больше нуля. Размер по умолчанию — 81920.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию копирования.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destination" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="buffersize" /> имеет отрицательное значение или равен нулю.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток или поток назначения удаляется.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий поток не поддерживает чтение или поток назначения не поддерживает запись.</exception>
		// Token: 0x0600685F RID: 26719 RVA: 0x00164CED File Offset: 0x00162EED
		public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			return this.CopyToAsyncInternal(destination, bufferSize, cancellationToken);
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00164D00 File Offset: 0x00162F00
		private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			Stream.<CopyToAsyncInternal>d__28 <CopyToAsyncInternal>d__;
			<CopyToAsyncInternal>d__.<>4__this = this;
			<CopyToAsyncInternal>d__.destination = destination;
			<CopyToAsyncInternal>d__.bufferSize = bufferSize;
			<CopyToAsyncInternal>d__.cancellationToken = cancellationToken;
			<CopyToAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncInternal>d__.<>1__state = -1;
			<CopyToAsyncInternal>d__.<>t__builder.Start<Stream.<CopyToAsyncInternal>d__28>(ref <CopyToAsyncInternal>d__);
			return <CopyToAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Считывает байты из текущего потока и записывает их в другой поток.</summary>
		/// <param name="destination">Поток, в который будет скопировано содержимое текущего потока.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destination" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий поток не поддерживает чтение.  
		///
		/// или - 
		/// Параметр <paramref name="destination" /> не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток или параметр <paramref name="destination" /> был закрыт до вызова метода <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" />.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06006861 RID: 26721 RVA: 0x00164D5C File Offset: 0x00162F5C
		public void CopyTo(Stream destination)
		{
			int copyBufferSize = this.GetCopyBufferSize();
			this.CopyTo(destination, copyBufferSize);
		}

		/// <summary>Считывает байты из текущего потока и записывает их в другой поток, используя указанный размер буфера.</summary>
		/// <param name="destination">Поток, в который будет скопировано содержимое текущего потока.</param>
		/// <param name="bufferSize">Размер буфера. Это значение должно быть больше нуля. Размер по умолчанию — 81920.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destination" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="bufferSize" /> имеет отрицательное значение или равен нулю.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий поток не поддерживает чтение.  
		///
		/// или - 
		/// Параметр <paramref name="destination" /> не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток или параметр <paramref name="destination" /> был закрыт до вызова метода <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" />.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06006862 RID: 26722 RVA: 0x00164D78 File Offset: 0x00162F78
		public virtual void CopyTo(Stream destination, int bufferSize)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			byte[] array = ArrayPool<byte>.Shared.Rent(bufferSize);
			try
			{
				int count;
				while ((count = this.Read(array, 0, array.Length)) != 0)
				{
					destination.Write(array, 0, count);
				}
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00164DD4 File Offset: 0x00162FD4
		private int GetCopyBufferSize()
		{
			int num = 81920;
			if (this.CanSeek)
			{
				long length = this.Length;
				long position = this.Position;
				if (length <= position)
				{
					num = 1;
				}
				else
				{
					long num2 = length - position;
					if (num2 > 0L)
					{
						num = (int)Math.Min((long)num, num2);
					}
				}
			}
			return num;
		}

		/// <summary>Закрывает текущий поток и отключает все ресурсы (например, сокеты и файловые дескрипторы), связанные с текущим потоком. Вместо вызова данного метода, убедитесь в том, что поток надлежащим образом ликвидирован.</summary>
		// Token: 0x06006864 RID: 26724 RVA: 0x00164E19 File Offset: 0x00163019
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.IO.Stream" />.</summary>
		// Token: 0x06006865 RID: 26725 RVA: 0x000A4735 File Offset: 0x000A2935
		public void Dispose()
		{
			this.Close();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.Stream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06006866 RID: 26726 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>При переопределении в производном классе очищает все буферы данного потока и вызывает запись данных буферов в базовое устройство.</summary>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006867 RID: 26727
		public abstract void Flush();

		/// <summary>Асинхронно очищает все буферы для этого потока и вызывает запись всех буферизованных данных в базовое устройство.</summary>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		// Token: 0x06006868 RID: 26728 RVA: 0x00164E28 File Offset: 0x00163028
		public Task FlushAsync()
		{
			return this.FlushAsync(CancellationToken.None);
		}

		/// <summary>Асинхронно очищает все буферы данного потока, вызывает запись буферизованных данных в базовое устройство и отслеживает запросы отмены.</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		// Token: 0x06006869 RID: 26729 RVA: 0x00164E35 File Offset: 0x00163035
		public virtual Task FlushAsync(CancellationToken cancellationToken)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				((Stream)state).Flush();
			}, this, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Выделяет объект <see cref="T:System.Threading.WaitHandle" />.</summary>
		/// <returns>Ссылка на выделенный объект <see langword="WaitHandle" />.</returns>
		// Token: 0x0600686A RID: 26730 RVA: 0x00164E68 File Offset: 0x00163068
		[Obsolete("CreateWaitHandle will be removed eventually.  Please use \"new ManualResetEvent(false)\" instead.")]
		protected virtual WaitHandle CreateWaitHandle()
		{
			return new ManualResetEvent(false);
		}

		/// <summary>Начинает операцию асинхронного чтения. (Рекомендуется использовать <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="buffer">Буфер, в который необходимо считать данные.</param>
		/// <param name="offset">Смещение байтов в буфере <paramref name="buffer" />, с которого начинается запись данных, считанных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="callback">Дополнительный асинхронный обратный вызов по завершении чтения.</param>
		/// <param name="state">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронное чтение от других запросов.</param>
		/// <returns>
		///   <see cref="T:System.IAsyncResult" /> представляет асинхронное чтение, которое все еще может быть отложено.</returns>
		/// <exception cref="T:System.IO.IOException">Попытка выполнить чтение в асинхронном режиме за пределами конца потока или ошибка диска.</exception>
		/// <exception cref="T:System.ArgumentException">Один или несколько аргументов являются недопустимыми.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущая реализация класса <see langword="Stream" /> не поддерживает операцию чтения.</exception>
		// Token: 0x0600686B RID: 26731 RVA: 0x00164E70 File Offset: 0x00163070
		public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this.BeginReadInternal(buffer, offset, count, callback, state, false, true);
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x00164E84 File Offset: 0x00163084
		internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			if (!this.CanRead)
			{
				throw Error.GetReadNotSupported();
			}
			SemaphoreSlim semaphoreSlim = this.EnsureAsyncActiveSemaphoreInitialized();
			Task task = null;
			if (serializeAsynchronously)
			{
				task = semaphoreSlim.WaitAsync();
			}
			else
			{
				semaphoreSlim.Wait();
			}
			Stream.ReadWriteTask readWriteTask = new Stream.ReadWriteTask(true, apm, delegate(object <p0>)
			{
				Stream.ReadWriteTask readWriteTask2 = Task.InternalCurrent as Stream.ReadWriteTask;
				int result;
				try
				{
					result = readWriteTask2._stream.Read(readWriteTask2._buffer, readWriteTask2._offset, readWriteTask2._count);
				}
				finally
				{
					if (!readWriteTask2._apm)
					{
						readWriteTask2._stream.FinishTrackingAsyncOperation();
					}
					readWriteTask2.ClearBeginState();
				}
				return result;
			}, state, this, buffer, offset, count, callback);
			if (task != null)
			{
				this.RunReadWriteTaskWhenReady(task, readWriteTask);
			}
			else
			{
				this.RunReadWriteTask(readWriteTask);
			}
			return readWriteTask;
		}

		/// <summary>Ожидает завершения отложенного асинхронного чтения. (Рекомендуется использовать <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="asyncResult">Ссылка на отложенный асинхронный запрос, который необходимо завершить.</param>
		/// <returns>Количество байтов, считанных из потока, от нуля (0) до количества запрошенных байтов. Потоки возвращают нуль (0) только в конце. В противном случае они должны блокироваться до тех пор, пока доступен хотя бы один байт.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Обработчик отложенной операции считывания не доступен.  
		///
		/// или - 
		/// Ожидающая операция не поддерживает чтение.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="asyncResult" /> не происходит из метода <see cref="M:System.IO.Stream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> в текущем потоке.</exception>
		/// <exception cref="T:System.IO.IOException">Поток закрыт, или произошла внутренняя ошибка.</exception>
		// Token: 0x0600686D RID: 26733 RVA: 0x00164F00 File Offset: 0x00163100
		public virtual int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			Stream.ReadWriteTask activeReadWriteTask = this._activeReadWriteTask;
			if (activeReadWriteTask == null)
			{
				throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.");
			}
			if (activeReadWriteTask != asyncResult)
			{
				throw new InvalidOperationException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.");
			}
			if (!activeReadWriteTask._isRead)
			{
				throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.");
			}
			int result;
			try
			{
				result = activeReadWriteTask.GetAwaiter().GetResult();
			}
			finally
			{
				this.FinishTrackingAsyncOperation();
			}
			return result;
		}

		/// <summary>Асинхронно считывает последовательность байтов из текущего потока и перемещает позицию внутри потока на число считанных байтов.</summary>
		/// <param name="buffer">Буфер, в который записываются данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="buffer" />, с которого начинается запись данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число доступных в данный момент байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x0600686E RID: 26734 RVA: 0x00164F7C File Offset: 0x0016317C
		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return this.ReadAsync(buffer, offset, count, CancellationToken.None);
		}

		/// <summary>Асинхронно считывает последовательность байтов из текущего потока, перемещает позицию в потоке на число считанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, в который записываются данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="buffer" />, с которого начинается запись данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число доступных в данный момент байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x0600686F RID: 26735 RVA: 0x00164F8C File Offset: 0x0016318C
		public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.BeginEndReadAsync(buffer, offset, count);
			}
			return Task.FromCanceled<int>(cancellationToken);
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x00164FA8 File Offset: 0x001631A8
		public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				return new ValueTask<int>(this.ReadAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count, cancellationToken));
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			return Stream.<ReadAsync>g__FinishReadAsync|44_0(this.ReadAsync(array, 0, buffer.Length, cancellationToken), array, buffer);
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x00165010 File Offset: 0x00163210
		private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count)
		{
			if (!this.HasOverriddenBeginEndRead())
			{
				return (Task<int>)this.BeginReadInternal(buffer, offset, count, null, null, true, false);
			}
			return TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>(this, new Stream.ReadWriteParameters
			{
				Buffer = buffer,
				Offset = offset,
				Count = count
			}, (Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) => stream.BeginRead(args.Buffer, args.Offset, args.Count, callback, state), (Stream stream, IAsyncResult asyncResult) => stream.EndRead(asyncResult));
		}

		/// <summary>Начинает операцию асинхронной записи. (Рекомендуется использовать <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="callback">Дополнительный асинхронный обратный вызов по завершении записи.</param>
		/// <param name="state">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронную запись от других запросов.</param>
		/// <returns>
		///   <see langword="IAsyncResult" /> представляет асинхронную запись, которая все еще может быть отложена.</returns>
		/// <exception cref="T:System.IO.IOException">Попытка выполнить запись в асинхронном режиме за пределами конца потока или ошибка диска.</exception>
		/// <exception cref="T:System.ArgumentException">Один или несколько аргументов являются недопустимыми.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущая реализация класса <see langword="Stream" /> не поддерживает операцию записи.</exception>
		// Token: 0x06006872 RID: 26738 RVA: 0x0016509D File Offset: 0x0016329D
		public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this.BeginWriteInternal(buffer, offset, count, callback, state, false, true);
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x001650B0 File Offset: 0x001632B0
		internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
			SemaphoreSlim semaphoreSlim = this.EnsureAsyncActiveSemaphoreInitialized();
			Task task = null;
			if (serializeAsynchronously)
			{
				task = semaphoreSlim.WaitAsync();
			}
			else
			{
				semaphoreSlim.Wait();
			}
			Stream.ReadWriteTask readWriteTask = new Stream.ReadWriteTask(false, apm, delegate(object <p0>)
			{
				Stream.ReadWriteTask readWriteTask2 = Task.InternalCurrent as Stream.ReadWriteTask;
				int result;
				try
				{
					readWriteTask2._stream.Write(readWriteTask2._buffer, readWriteTask2._offset, readWriteTask2._count);
					result = 0;
				}
				finally
				{
					if (!readWriteTask2._apm)
					{
						readWriteTask2._stream.FinishTrackingAsyncOperation();
					}
					readWriteTask2.ClearBeginState();
				}
				return result;
			}, state, this, buffer, offset, count, callback);
			if (task != null)
			{
				this.RunReadWriteTaskWhenReady(task, readWriteTask);
			}
			else
			{
				this.RunReadWriteTask(readWriteTask);
			}
			return readWriteTask;
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x0016512C File Offset: 0x0016332C
		private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
			if (asyncWaiter.IsCompleted)
			{
				this.RunReadWriteTask(readWriteTask);
				return;
			}
			asyncWaiter.ContinueWith(delegate(Task t, object state)
			{
				Stream.ReadWriteTask readWriteTask2 = (Stream.ReadWriteTask)state;
				readWriteTask2._stream.RunReadWriteTask(readWriteTask2);
			}, readWriteTask, default(CancellationToken), TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x00165183 File Offset: 0x00163383
		private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
			this._activeReadWriteTask = readWriteTask;
			readWriteTask.m_taskScheduler = TaskScheduler.Default;
			readWriteTask.ScheduleAndStart(false);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x0016519E File Offset: 0x0016339E
		private void FinishTrackingAsyncOperation()
		{
			this._activeReadWriteTask = null;
			this._asyncActiveSemaphore.Release();
		}

		/// <summary>Заканчивает операцию асинхронной записи. (Рекомендуется использовать <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="asyncResult">Ссылка на невыполненный асинхронный запрос ввода-вывода.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Обработчик отложенной операции записи не доступен.  
		///
		/// или - 
		/// Ожидающая операция не поддерживает запись.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="asyncResult" /> не происходит из метода <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> в текущем потоке.</exception>
		/// <exception cref="T:System.IO.IOException">Поток закрыт, или произошла внутренняя ошибка.</exception>
		// Token: 0x06006877 RID: 26743 RVA: 0x001651B4 File Offset: 0x001633B4
		public virtual void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			Stream.ReadWriteTask activeReadWriteTask = this._activeReadWriteTask;
			if (activeReadWriteTask == null)
			{
				throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult.");
			}
			if (activeReadWriteTask != asyncResult)
			{
				throw new InvalidOperationException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult.");
			}
			if (activeReadWriteTask._isRead)
			{
				throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult.");
			}
			try
			{
				activeReadWriteTask.GetAwaiter().GetResult();
			}
			finally
			{
				this.FinishTrackingAsyncOperation();
			}
		}

		/// <summary>Асинхронно записывает последовательность байтов в текущий поток и перемещает текущую позицию внутри потока на число записанных байтов.</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в объекте <paramref name="buffer" />, с которого начинается копирование байтов в поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06006878 RID: 26744 RVA: 0x00165230 File Offset: 0x00163430
		public Task WriteAsync(byte[] buffer, int offset, int count)
		{
			return this.WriteAsync(buffer, offset, count, CancellationToken.None);
		}

		/// <summary>Асинхронно записывает последовательность байтов в текущий поток, перемещает текущую позицию внутри потока на число записанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в объекте <paramref name="buffer" />, с которого начинается копирование байтов в поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06006879 RID: 26745 RVA: 0x00165240 File Offset: 0x00163440
		public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.BeginEndWriteAsync(buffer, offset, count);
			}
			return Task.FromCanceled(cancellationToken);
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x0016525C File Offset: 0x0016345C
		public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				return new ValueTask(this.WriteAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count, cancellationToken));
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			buffer.Span.CopyTo(array);
			return new ValueTask(this.FinishWriteAsync(this.WriteAsync(array, 0, buffer.Length, cancellationToken), array));
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x001652D8 File Offset: 0x001634D8
		private Task FinishWriteAsync(Task writeTask, byte[] localBuffer)
		{
			Stream.<FinishWriteAsync>d__57 <FinishWriteAsync>d__;
			<FinishWriteAsync>d__.writeTask = writeTask;
			<FinishWriteAsync>d__.localBuffer = localBuffer;
			<FinishWriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishWriteAsync>d__.<>1__state = -1;
			<FinishWriteAsync>d__.<>t__builder.Start<Stream.<FinishWriteAsync>d__57>(ref <FinishWriteAsync>d__);
			return <FinishWriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00165324 File Offset: 0x00163524
		private Task BeginEndWriteAsync(byte[] buffer, int offset, int count)
		{
			if (!this.HasOverriddenBeginEndWrite())
			{
				return (Task)this.BeginWriteInternal(buffer, offset, count, null, null, true, false);
			}
			return TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>(this, new Stream.ReadWriteParameters
			{
				Buffer = buffer,
				Offset = offset,
				Count = count
			}, (Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) => stream.BeginWrite(args.Buffer, args.Offset, args.Count, callback, state), delegate(Stream stream, IAsyncResult asyncResult)
			{
				stream.EndWrite(asyncResult);
				return default(VoidTaskResult);
			});
		}

		/// <summary>При переопределении в производном классе задает позицию в текущем потоке.</summary>
		/// <param name="offset">Смещение в байтах относительно параметра <paramref name="origin" />.</param>
		/// <param name="origin">Значение типа <see cref="T:System.IO.SeekOrigin" />, указывающее точку ссылки, которая используется для получения новой позиции.</param>
		/// <returns>Новая позиция в текущем потоке.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает поиск, если поток создан на основе канала или вывода консоли.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x0600687D RID: 26749
		public abstract long Seek(long offset, SeekOrigin origin);

		/// <summary>При переопределении в производном классе задает длину текущего потока.</summary>
		/// <param name="value">Нужная длина текущего потока в байтах.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает ни поиск, ни запись, например, если поток создан на основе канала или вывода консоли.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x0600687E RID: 26750
		public abstract void SetLength(long value);

		/// <summary>При переопределении в производном классе считывает последовательность байтов из текущего потока и перемещает позицию в потоке на число считанных байтов.</summary>
		/// <param name="buffer">Массив байтов. После завершения выполнения данного метода буфер содержит указанный массив байтов, в котором значения в интервале между <paramref name="offset" /> и (<paramref name="offset" /> + <paramref name="count" /> - 1) заменены байтами, считанными из текущего источника.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в <paramref name="buffer" />, с которого начинается сохранение данных, считанных из текущего потока.</param>
		/// <param name="count">Максимальное количество байтов, которое должно быть считано из текущего потока.</param>
		/// <returns>Общее количество байтов, считанных в буфер. Это число может быть меньше количества запрошенных байтов, если столько байтов в настоящее время недоступно, а также равняться нулю (0), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x0600687F RID: 26751
		public abstract int Read(byte[] buffer, int offset, int count);

		// Token: 0x06006880 RID: 26752 RVA: 0x001653B4 File Offset: 0x001635B4
		public virtual int Read(Span<byte> buffer)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			int result;
			try
			{
				int num = this.Read(array, 0, buffer.Length);
				if ((ulong)num > (ulong)((long)buffer.Length))
				{
					throw new IOException("Stream was too long.");
				}
				new Span<byte>(array, 0, num).CopyTo(buffer);
				result = num;
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		/// <summary>Считывает байт из потока и перемещает позицию в потоке на один байт или возвращает -1, если достигнут конец потока.</summary>
		/// <returns>Байт без знака, приведенный к <see langword="Int32" />, или значение -1, если достигнут конец потока.</returns>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x06006881 RID: 26753 RVA: 0x00165430 File Offset: 0x00163630
		public virtual int ReadByte()
		{
			byte[] array = new byte[1];
			if (this.Read(array, 0, 1) == 0)
			{
				return -1;
			}
			return (int)array[0];
		}

		/// <summary>При переопределении в производном классе записывает последовательность байтов в текущий поток и перемещает текущую позицию в нем вперед на число записанных байтов.</summary>
		/// <param name="buffer">Массив байтов. Этот метод копирует байты <paramref name="count" /> из <paramref name="buffer" /> в текущий поток.</param>
		/// <param name="offset">Отсчитываемое от нуля смещение байтов в буфере <paramref name="buffer" />, с которого начинается копирование байтов в текущий поток.</param>
		/// <param name="count">Количество байтов, которое необходимо записать в текущий поток.</param>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например, связанная с тем, что не удается найти указанный файл.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Метод <see cref="M:System.IO.Stream.Write(System.Byte[],System.Int32,System.Int32)" /> был вызван после закрытия потока.</exception>
		// Token: 0x06006882 RID: 26754
		public abstract void Write(byte[] buffer, int offset, int count);

		// Token: 0x06006883 RID: 26755 RVA: 0x00165454 File Offset: 0x00163654
		public virtual void Write(ReadOnlySpan<byte> buffer)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			try
			{
				buffer.CopyTo(array);
				this.Write(array, 0, buffer.Length);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		/// <summary>Записывает байт в текущее положение в потоке и перемещает позицию в потоке вперед на один байт.</summary>
		/// <param name="value">Байт, записываемый в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись или был закрыт до начала операции.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x06006884 RID: 26756 RVA: 0x001654B0 File Offset: 0x001636B0
		public virtual void WriteByte(byte value)
		{
			this.Write(new byte[]
			{
				value
			}, 0, 1);
		}

		/// <summary>Создает потокобезопасную (синхронизированную) оболочку для заданного объекта <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="stream">Синхронизируемый объект <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Потокобезопасный объект <see cref="T:System.IO.Stream" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006885 RID: 26757 RVA: 0x001654D1 File Offset: 0x001636D1
		public static Stream Synchronized(Stream stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			if (stream is Stream.SyncStream)
			{
				return stream;
			}
			return new Stream.SyncStream(stream);
		}

		/// <summary>Обеспечивает поддержку для <see cref="T:System.Diagnostics.Contracts.Contract" />.</summary>
		// Token: 0x06006886 RID: 26758 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[Obsolete("Do not call or override this method.")]
		protected virtual void ObjectInvariant()
		{
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x001654F4 File Offset: 0x001636F4
		internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			Stream.SynchronousAsyncResult synchronousAsyncResult;
			try
			{
				synchronousAsyncResult = new Stream.SynchronousAsyncResult(this.Read(buffer, offset, count), state);
			}
			catch (IOException ex)
			{
				synchronousAsyncResult = new Stream.SynchronousAsyncResult(ex, state, false);
			}
			if (callback != null)
			{
				callback(synchronousAsyncResult);
			}
			return synchronousAsyncResult;
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x0016553C File Offset: 0x0016373C
		internal static int BlockingEndRead(IAsyncResult asyncResult)
		{
			return Stream.SynchronousAsyncResult.EndRead(asyncResult);
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x00165544 File Offset: 0x00163744
		internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			Stream.SynchronousAsyncResult synchronousAsyncResult;
			try
			{
				this.Write(buffer, offset, count);
				synchronousAsyncResult = new Stream.SynchronousAsyncResult(state);
			}
			catch (IOException ex)
			{
				synchronousAsyncResult = new Stream.SynchronousAsyncResult(ex, state, true);
			}
			if (callback != null)
			{
				callback(synchronousAsyncResult);
			}
			return synchronousAsyncResult;
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x0016558C File Offset: 0x0016378C
		internal static void BlockingEndWrite(IAsyncResult asyncResult)
		{
			Stream.SynchronousAsyncResult.EndWrite(asyncResult);
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x000040F7 File Offset: 0x000022F7
		private bool HasOverriddenBeginEndRead()
		{
			return true;
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x000040F7 File Offset: 0x000022F7
		private bool HasOverriddenBeginEndWrite()
		{
			return true;
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x00165594 File Offset: 0x00163794
		public virtual ValueTask DisposeAsync()
		{
			ValueTask valueTask;
			try
			{
				this.Dispose();
				valueTask = default(ValueTask);
				valueTask = valueTask;
			}
			catch (Exception exception)
			{
				valueTask = new ValueTask(Task.FromException(exception));
			}
			return valueTask;
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x001655E0 File Offset: 0x001637E0
		[CompilerGenerated]
		internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|44_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination)
		{
			Stream.<<ReadAsync>g__FinishReadAsync|44_0>d <<ReadAsync>g__FinishReadAsync|44_0>d;
			<<ReadAsync>g__FinishReadAsync|44_0>d.readTask = readTask;
			<<ReadAsync>g__FinishReadAsync|44_0>d.localBuffer = localBuffer;
			<<ReadAsync>g__FinishReadAsync|44_0>d.localDestination = localDestination;
			<<ReadAsync>g__FinishReadAsync|44_0>d.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<<ReadAsync>g__FinishReadAsync|44_0>d.<>1__state = -1;
			<<ReadAsync>g__FinishReadAsync|44_0>d.<>t__builder.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>(ref <<ReadAsync>g__FinishReadAsync|44_0>d);
			return <<ReadAsync>g__FinishReadAsync|44_0>d.<>t__builder.Task;
		}

		/// <summary>Объект <see langword="Stream" /> без резервного хранилища.</summary>
		// Token: 0x04003CD1 RID: 15569
		public static readonly Stream Null = new Stream.NullStream();

		// Token: 0x04003CD2 RID: 15570
		private const int DefaultCopyBufferSize = 81920;

		// Token: 0x04003CD3 RID: 15571
		[NonSerialized]
		private Stream.ReadWriteTask _activeReadWriteTask;

		// Token: 0x04003CD4 RID: 15572
		[NonSerialized]
		private SemaphoreSlim _asyncActiveSemaphore;

		// Token: 0x02000B4B RID: 2891
		private struct ReadWriteParameters
		{
			// Token: 0x04003CD5 RID: 15573
			internal byte[] Buffer;

			// Token: 0x04003CD6 RID: 15574
			internal int Offset;

			// Token: 0x04003CD7 RID: 15575
			internal int Count;
		}

		// Token: 0x02000B4C RID: 2892
		private sealed class ReadWriteTask : Task<int>, ITaskCompletionAction
		{
			// Token: 0x06006891 RID: 26769 RVA: 0x00165633 File Offset: 0x00163833
			internal void ClearBeginState()
			{
				this._stream = null;
				this._buffer = null;
			}

			// Token: 0x06006892 RID: 26770 RVA: 0x00165644 File Offset: 0x00163844
			public ReadWriteTask(bool isRead, bool apm, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) : base(function, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach)
			{
				this._isRead = isRead;
				this._apm = apm;
				this._stream = stream;
				this._buffer = buffer;
				this._offset = offset;
				this._count = count;
				if (callback != null)
				{
					this._callback = callback;
					this._context = ExecutionContext.Capture();
					base.AddCompletionAction(this);
				}
			}

			// Token: 0x06006893 RID: 26771 RVA: 0x001656AC File Offset: 0x001638AC
			private static void InvokeAsyncCallback(object completedTask)
			{
				Stream.ReadWriteTask readWriteTask = (Stream.ReadWriteTask)completedTask;
				AsyncCallback callback = readWriteTask._callback;
				readWriteTask._callback = null;
				callback(readWriteTask);
			}

			// Token: 0x06006894 RID: 26772 RVA: 0x001656D4 File Offset: 0x001638D4
			void ITaskCompletionAction.Invoke(Task completingTask)
			{
				ExecutionContext context = this._context;
				if (context == null)
				{
					AsyncCallback callback = this._callback;
					this._callback = null;
					callback(completingTask);
					return;
				}
				this._context = null;
				ContextCallback contextCallback = Stream.ReadWriteTask.s_invokeAsyncCallback;
				if (contextCallback == null)
				{
					contextCallback = (Stream.ReadWriteTask.s_invokeAsyncCallback = new ContextCallback(Stream.ReadWriteTask.InvokeAsyncCallback));
				}
				ExecutionContext.RunInternal(context, contextCallback, this);
			}

			// Token: 0x17001213 RID: 4627
			// (get) Token: 0x06006895 RID: 26773 RVA: 0x000040F7 File Offset: 0x000022F7
			bool ITaskCompletionAction.InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x04003CD8 RID: 15576
			internal readonly bool _isRead;

			// Token: 0x04003CD9 RID: 15577
			internal readonly bool _apm;

			// Token: 0x04003CDA RID: 15578
			internal Stream _stream;

			// Token: 0x04003CDB RID: 15579
			internal byte[] _buffer;

			// Token: 0x04003CDC RID: 15580
			internal readonly int _offset;

			// Token: 0x04003CDD RID: 15581
			internal readonly int _count;

			// Token: 0x04003CDE RID: 15582
			private AsyncCallback _callback;

			// Token: 0x04003CDF RID: 15583
			private ExecutionContext _context;

			// Token: 0x04003CE0 RID: 15584
			private static ContextCallback s_invokeAsyncCallback;
		}

		// Token: 0x02000B4D RID: 2893
		private sealed class NullStream : Stream
		{
			// Token: 0x06006896 RID: 26774 RVA: 0x0016572A File Offset: 0x0016392A
			internal NullStream()
			{
			}

			// Token: 0x17001214 RID: 4628
			// (get) Token: 0x06006897 RID: 26775 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool CanRead
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001215 RID: 4629
			// (get) Token: 0x06006898 RID: 26776 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool CanWrite
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001216 RID: 4630
			// (get) Token: 0x06006899 RID: 26777 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool CanSeek
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001217 RID: 4631
			// (get) Token: 0x0600689A RID: 26778 RVA: 0x0005CD46 File Offset: 0x0005AF46
			public override long Length
			{
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001218 RID: 4632
			// (get) Token: 0x0600689B RID: 26779 RVA: 0x0005CD46 File Offset: 0x0005AF46
			// (set) Token: 0x0600689C RID: 26780 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override long Position
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			// Token: 0x0600689D RID: 26781 RVA: 0x00165732 File Offset: 0x00163932
			public override void CopyTo(Stream destination, int bufferSize)
			{
				StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			}

			// Token: 0x0600689E RID: 26782 RVA: 0x0016573C File Offset: 0x0016393C
			public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
			{
				StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				return Task.FromCanceled(cancellationToken);
			}

			// Token: 0x0600689F RID: 26783 RVA: 0x00004BF9 File Offset: 0x00002DF9
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060068A0 RID: 26784 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void Flush()
			{
			}

			// Token: 0x060068A1 RID: 26785 RVA: 0x0016575B File Offset: 0x0016395B
			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				return Task.FromCanceled(cancellationToken);
			}

			// Token: 0x060068A2 RID: 26786 RVA: 0x00165772 File Offset: 0x00163972
			public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				if (!this.CanRead)
				{
					throw Error.GetReadNotSupported();
				}
				return base.BlockingBeginRead(buffer, offset, count, callback, state);
			}

			// Token: 0x060068A3 RID: 26787 RVA: 0x0016578F File Offset: 0x0016398F
			public override int EndRead(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				return Stream.BlockingEndRead(asyncResult);
			}

			// Token: 0x060068A4 RID: 26788 RVA: 0x001657A5 File Offset: 0x001639A5
			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				if (!this.CanWrite)
				{
					throw Error.GetWriteNotSupported();
				}
				return base.BlockingBeginWrite(buffer, offset, count, callback, state);
			}

			// Token: 0x060068A5 RID: 26789 RVA: 0x001657C2 File Offset: 0x001639C2
			public override void EndWrite(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				Stream.BlockingEndWrite(asyncResult);
			}

			// Token: 0x060068A6 RID: 26790 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			// Token: 0x060068A7 RID: 26791 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			public override int Read(Span<byte> buffer)
			{
				return 0;
			}

			// Token: 0x060068A8 RID: 26792 RVA: 0x001657D8 File Offset: 0x001639D8
			public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				return Stream.NullStream.s_zeroTask;
			}

			// Token: 0x060068A9 RID: 26793 RVA: 0x001657DF File Offset: 0x001639DF
			public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				return new ValueTask<int>(0);
			}

			// Token: 0x060068AA RID: 26794 RVA: 0x00122772 File Offset: 0x00120972
			public override int ReadByte()
			{
				return -1;
			}

			// Token: 0x060068AB RID: 26795 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			// Token: 0x060068AC RID: 26796 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void Write(ReadOnlySpan<byte> buffer)
			{
			}

			// Token: 0x060068AD RID: 26797 RVA: 0x001657E7 File Offset: 0x001639E7
			public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				return Task.FromCanceled(cancellationToken);
			}

			// Token: 0x060068AE RID: 26798 RVA: 0x00165800 File Offset: 0x00163A00
			public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return default(ValueTask);
				}
				return new ValueTask(Task.FromCanceled(cancellationToken));
			}

			// Token: 0x060068AF RID: 26799 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void WriteByte(byte value)
			{
			}

			// Token: 0x060068B0 RID: 26800 RVA: 0x0005CD46 File Offset: 0x0005AF46
			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x060068B1 RID: 26801 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void SetLength(long length)
			{
			}

			// Token: 0x04003CE1 RID: 15585
			private static readonly Task<int> s_zeroTask = Task.FromResult<int>(0);
		}

		// Token: 0x02000B4E RID: 2894
		private sealed class SynchronousAsyncResult : IAsyncResult
		{
			// Token: 0x060068B3 RID: 26803 RVA: 0x00165838 File Offset: 0x00163A38
			internal SynchronousAsyncResult(int bytesRead, object asyncStateObject)
			{
				this._bytesRead = bytesRead;
				this._stateObject = asyncStateObject;
			}

			// Token: 0x060068B4 RID: 26804 RVA: 0x0016584E File Offset: 0x00163A4E
			internal SynchronousAsyncResult(object asyncStateObject)
			{
				this._stateObject = asyncStateObject;
				this._isWrite = true;
			}

			// Token: 0x060068B5 RID: 26805 RVA: 0x00165864 File Offset: 0x00163A64
			internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite)
			{
				this._exceptionInfo = ExceptionDispatchInfo.Capture(ex);
				this._stateObject = asyncStateObject;
				this._isWrite = isWrite;
			}

			// Token: 0x17001219 RID: 4633
			// (get) Token: 0x060068B6 RID: 26806 RVA: 0x000040F7 File Offset: 0x000022F7
			public bool IsCompleted
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700121A RID: 4634
			// (get) Token: 0x060068B7 RID: 26807 RVA: 0x00165886 File Offset: 0x00163A86
			public WaitHandle AsyncWaitHandle
			{
				get
				{
					return LazyInitializer.EnsureInitialized<ManualResetEvent>(ref this._waitHandle, () => new ManualResetEvent(true));
				}
			}

			// Token: 0x1700121B RID: 4635
			// (get) Token: 0x060068B8 RID: 26808 RVA: 0x001658B2 File Offset: 0x00163AB2
			public object AsyncState
			{
				get
				{
					return this._stateObject;
				}
			}

			// Token: 0x1700121C RID: 4636
			// (get) Token: 0x060068B9 RID: 26809 RVA: 0x000040F7 File Offset: 0x000022F7
			public bool CompletedSynchronously
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060068BA RID: 26810 RVA: 0x001658BA File Offset: 0x00163ABA
			internal void ThrowIfError()
			{
				if (this._exceptionInfo != null)
				{
					this._exceptionInfo.Throw();
				}
			}

			// Token: 0x060068BB RID: 26811 RVA: 0x001658D0 File Offset: 0x00163AD0
			internal static int EndRead(IAsyncResult asyncResult)
			{
				Stream.SynchronousAsyncResult synchronousAsyncResult = asyncResult as Stream.SynchronousAsyncResult;
				if (synchronousAsyncResult == null || synchronousAsyncResult._isWrite)
				{
					throw new ArgumentException("IAsyncResult object did not come from the corresponding async method on this type.");
				}
				if (synchronousAsyncResult._endXxxCalled)
				{
					throw new ArgumentException("EndRead can only be called once for each asynchronous operation.");
				}
				synchronousAsyncResult._endXxxCalled = true;
				synchronousAsyncResult.ThrowIfError();
				return synchronousAsyncResult._bytesRead;
			}

			// Token: 0x060068BC RID: 26812 RVA: 0x00165920 File Offset: 0x00163B20
			internal static void EndWrite(IAsyncResult asyncResult)
			{
				Stream.SynchronousAsyncResult synchronousAsyncResult = asyncResult as Stream.SynchronousAsyncResult;
				if (synchronousAsyncResult == null || !synchronousAsyncResult._isWrite)
				{
					throw new ArgumentException("IAsyncResult object did not come from the corresponding async method on this type.");
				}
				if (synchronousAsyncResult._endXxxCalled)
				{
					throw new ArgumentException("EndWrite can only be called once for each asynchronous operation.");
				}
				synchronousAsyncResult._endXxxCalled = true;
				synchronousAsyncResult.ThrowIfError();
			}

			// Token: 0x04003CE2 RID: 15586
			private readonly object _stateObject;

			// Token: 0x04003CE3 RID: 15587
			private readonly bool _isWrite;

			// Token: 0x04003CE4 RID: 15588
			private ManualResetEvent _waitHandle;

			// Token: 0x04003CE5 RID: 15589
			private ExceptionDispatchInfo _exceptionInfo;

			// Token: 0x04003CE6 RID: 15590
			private bool _endXxxCalled;

			// Token: 0x04003CE7 RID: 15591
			private int _bytesRead;
		}

		// Token: 0x02000B50 RID: 2896
		private sealed class SyncStream : Stream, IDisposable
		{
			// Token: 0x060068C0 RID: 26816 RVA: 0x0016597E File Offset: 0x00163B7E
			internal SyncStream(Stream stream)
			{
				if (stream == null)
				{
					throw new ArgumentNullException("stream");
				}
				this._stream = stream;
			}

			// Token: 0x1700121D RID: 4637
			// (get) Token: 0x060068C1 RID: 26817 RVA: 0x0016599B File Offset: 0x00163B9B
			public override bool CanRead
			{
				get
				{
					return this._stream.CanRead;
				}
			}

			// Token: 0x1700121E RID: 4638
			// (get) Token: 0x060068C2 RID: 26818 RVA: 0x001659A8 File Offset: 0x00163BA8
			public override bool CanWrite
			{
				get
				{
					return this._stream.CanWrite;
				}
			}

			// Token: 0x1700121F RID: 4639
			// (get) Token: 0x060068C3 RID: 26819 RVA: 0x001659B5 File Offset: 0x00163BB5
			public override bool CanSeek
			{
				get
				{
					return this._stream.CanSeek;
				}
			}

			// Token: 0x17001220 RID: 4640
			// (get) Token: 0x060068C4 RID: 26820 RVA: 0x001659C2 File Offset: 0x00163BC2
			public override bool CanTimeout
			{
				get
				{
					return this._stream.CanTimeout;
				}
			}

			// Token: 0x17001221 RID: 4641
			// (get) Token: 0x060068C5 RID: 26821 RVA: 0x001659D0 File Offset: 0x00163BD0
			public override long Length
			{
				get
				{
					Stream stream = this._stream;
					long length;
					lock (stream)
					{
						length = this._stream.Length;
					}
					return length;
				}
			}

			// Token: 0x17001222 RID: 4642
			// (get) Token: 0x060068C6 RID: 26822 RVA: 0x00165A18 File Offset: 0x00163C18
			// (set) Token: 0x060068C7 RID: 26823 RVA: 0x00165A60 File Offset: 0x00163C60
			public override long Position
			{
				get
				{
					Stream stream = this._stream;
					long position;
					lock (stream)
					{
						position = this._stream.Position;
					}
					return position;
				}
				set
				{
					Stream stream = this._stream;
					lock (stream)
					{
						this._stream.Position = value;
					}
				}
			}

			// Token: 0x17001223 RID: 4643
			// (get) Token: 0x060068C8 RID: 26824 RVA: 0x00165AA8 File Offset: 0x00163CA8
			// (set) Token: 0x060068C9 RID: 26825 RVA: 0x00165AB5 File Offset: 0x00163CB5
			public override int ReadTimeout
			{
				get
				{
					return this._stream.ReadTimeout;
				}
				set
				{
					this._stream.ReadTimeout = value;
				}
			}

			// Token: 0x17001224 RID: 4644
			// (get) Token: 0x060068CA RID: 26826 RVA: 0x00165AC3 File Offset: 0x00163CC3
			// (set) Token: 0x060068CB RID: 26827 RVA: 0x00165AD0 File Offset: 0x00163CD0
			public override int WriteTimeout
			{
				get
				{
					return this._stream.WriteTimeout;
				}
				set
				{
					this._stream.WriteTimeout = value;
				}
			}

			// Token: 0x060068CC RID: 26828 RVA: 0x00165AE0 File Offset: 0x00163CE0
			public override void Close()
			{
				Stream stream = this._stream;
				lock (stream)
				{
					try
					{
						this._stream.Close();
					}
					finally
					{
						base.Dispose(true);
					}
				}
			}

			// Token: 0x060068CD RID: 26829 RVA: 0x00165B3C File Offset: 0x00163D3C
			protected override void Dispose(bool disposing)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					try
					{
						if (disposing)
						{
							((IDisposable)this._stream).Dispose();
						}
					}
					finally
					{
						base.Dispose(disposing);
					}
				}
			}

			// Token: 0x060068CE RID: 26830 RVA: 0x00165B98 File Offset: 0x00163D98
			public override void Flush()
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.Flush();
				}
			}

			// Token: 0x060068CF RID: 26831 RVA: 0x00165BE0 File Offset: 0x00163DE0
			public override int Read(byte[] bytes, int offset, int count)
			{
				Stream stream = this._stream;
				int result;
				lock (stream)
				{
					result = this._stream.Read(bytes, offset, count);
				}
				return result;
			}

			// Token: 0x060068D0 RID: 26832 RVA: 0x00165C2C File Offset: 0x00163E2C
			public override int Read(Span<byte> buffer)
			{
				Stream stream = this._stream;
				int result;
				lock (stream)
				{
					result = this._stream.Read(buffer);
				}
				return result;
			}

			// Token: 0x060068D1 RID: 26833 RVA: 0x00165C74 File Offset: 0x00163E74
			public override int ReadByte()
			{
				Stream stream = this._stream;
				int result;
				lock (stream)
				{
					result = this._stream.ReadByte();
				}
				return result;
			}

			// Token: 0x060068D2 RID: 26834 RVA: 0x00165CBC File Offset: 0x00163EBC
			public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				bool flag = this._stream.HasOverriddenBeginEndRead();
				Stream stream = this._stream;
				IAsyncResult result;
				lock (stream)
				{
					result = (flag ? this._stream.BeginRead(buffer, offset, count, callback, state) : this._stream.BeginReadInternal(buffer, offset, count, callback, state, true, true));
				}
				return result;
			}

			// Token: 0x060068D3 RID: 26835 RVA: 0x00165D30 File Offset: 0x00163F30
			public override int EndRead(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				Stream stream = this._stream;
				int result;
				lock (stream)
				{
					result = this._stream.EndRead(asyncResult);
				}
				return result;
			}

			// Token: 0x060068D4 RID: 26836 RVA: 0x00165D88 File Offset: 0x00163F88
			public override long Seek(long offset, SeekOrigin origin)
			{
				Stream stream = this._stream;
				long result;
				lock (stream)
				{
					result = this._stream.Seek(offset, origin);
				}
				return result;
			}

			// Token: 0x060068D5 RID: 26837 RVA: 0x00165DD4 File Offset: 0x00163FD4
			public override void SetLength(long length)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.SetLength(length);
				}
			}

			// Token: 0x060068D6 RID: 26838 RVA: 0x00165E1C File Offset: 0x0016401C
			public override void Write(byte[] bytes, int offset, int count)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.Write(bytes, offset, count);
				}
			}

			// Token: 0x060068D7 RID: 26839 RVA: 0x00165E64 File Offset: 0x00164064
			public override void Write(ReadOnlySpan<byte> buffer)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.Write(buffer);
				}
			}

			// Token: 0x060068D8 RID: 26840 RVA: 0x00165EAC File Offset: 0x001640AC
			public override void WriteByte(byte b)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.WriteByte(b);
				}
			}

			// Token: 0x060068D9 RID: 26841 RVA: 0x00165EF4 File Offset: 0x001640F4
			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				bool flag = this._stream.HasOverriddenBeginEndWrite();
				Stream stream = this._stream;
				IAsyncResult result;
				lock (stream)
				{
					result = (flag ? this._stream.BeginWrite(buffer, offset, count, callback, state) : this._stream.BeginWriteInternal(buffer, offset, count, callback, state, true, true));
				}
				return result;
			}

			// Token: 0x060068DA RID: 26842 RVA: 0x00165F68 File Offset: 0x00164168
			public override void EndWrite(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.EndWrite(asyncResult);
				}
			}

			// Token: 0x04003CEA RID: 15594
			private Stream _stream;
		}
	}
}
