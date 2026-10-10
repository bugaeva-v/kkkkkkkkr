using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Microsoft.Win32;

namespace System.IO.Ports
{
	/// <summary>Представляет ресурс последовательного порта.</summary>
	// Token: 0x02000532 RID: 1330
	[MonitoringDescription("")]
	public class SerialPort : Component
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Ports.SerialPort" />.</summary>
		// Token: 0x06002AA4 RID: 10916 RVA: 0x00092E5F File Offset: 0x0009105F
		public SerialPort() : this(SerialPort.GetDefaultPortName(), 9600, Parity.None, 8, StopBits.One)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Ports.SerialPort" />, используя указанный объект <see cref="T:System.ComponentModel.IContainer" />.</summary>
		/// <param name="container">Интерфейс к контейнеру.</param>
		/// <exception cref="T:System.IO.IOException">Не удается найти или открыть указанный порт.</exception>
		// Token: 0x06002AA5 RID: 10917 RVA: 0x00092E74 File Offset: 0x00091074
		public SerialPort(IContainer container) : this()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Ports.SerialPort" />, используя указанное имя порта.</summary>
		/// <param name="portName">Порт для использования (например, COM1).</param>
		/// <exception cref="T:System.IO.IOException">Не удается найти или открыть указанный порт.</exception>
		// Token: 0x06002AA6 RID: 10918 RVA: 0x00092E7C File Offset: 0x0009107C
		public SerialPort(string portName) : this(portName, 9600, Parity.None, 8, StopBits.One)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Ports.SerialPort" />, используя указанное имя порта и скорость передачи в бодах.</summary>
		/// <param name="portName">Порт для использования (например, COM1).</param>
		/// <param name="baudRate">Скорость в бодах.</param>
		/// <exception cref="T:System.IO.IOException">Не удается найти или открыть указанный порт.</exception>
		// Token: 0x06002AA7 RID: 10919 RVA: 0x00092E8D File Offset: 0x0009108D
		public SerialPort(string portName, int baudRate) : this(portName, baudRate, Parity.None, 8, StopBits.One)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Ports.SerialPort" />, используя указанное имя порта, скорость передачи в бодах и бит четности.</summary>
		/// <param name="portName">Порт для использования (например, COM1).</param>
		/// <param name="baudRate">Скорость в бодах.</param>
		/// <param name="parity">Одно из значений <see cref="P:System.IO.Ports.SerialPort.Parity" />.</param>
		/// <exception cref="T:System.IO.IOException">Не удается найти или открыть указанный порт.</exception>
		// Token: 0x06002AA8 RID: 10920 RVA: 0x00092E9A File Offset: 0x0009109A
		public SerialPort(string portName, int baudRate, Parity parity) : this(portName, baudRate, parity, 8, StopBits.One)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Ports.SerialPort" />, используя указанное имя порта, скорость передачи в бодах, бит четности и биты данных.</summary>
		/// <param name="portName">Порт для использования (например, COM1).</param>
		/// <param name="baudRate">Скорость в бодах.</param>
		/// <param name="parity">Одно из значений <see cref="P:System.IO.Ports.SerialPort.Parity" />.</param>
		/// <param name="dataBits">Число битов данных.</param>
		/// <exception cref="T:System.IO.IOException">Не удается найти или открыть указанный порт.</exception>
		// Token: 0x06002AA9 RID: 10921 RVA: 0x00092EA7 File Offset: 0x000910A7
		public SerialPort(string portName, int baudRate, Parity parity, int dataBits) : this(portName, baudRate, parity, dataBits, StopBits.One)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Ports.SerialPort" />, используя указанное имя порта, скорость передачи в бодах, бит четности, биты данных и стоп-бит.</summary>
		/// <param name="portName">Порт для использования (например, COM1).</param>
		/// <param name="baudRate">Скорость в бодах.</param>
		/// <param name="parity">Одно из значений <see cref="P:System.IO.Ports.SerialPort.Parity" />.</param>
		/// <param name="dataBits">Число битов данных.</param>
		/// <param name="stopBits">Одно из значений <see cref="P:System.IO.Ports.SerialPort.StopBits" />.</param>
		/// <exception cref="T:System.IO.IOException">Не удается найти или открыть указанный порт.</exception>
		// Token: 0x06002AAA RID: 10922 RVA: 0x00092EB8 File Offset: 0x000910B8
		public SerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
		{
			this.port_name = portName;
			this.baud_rate = baudRate;
			this.data_bits = dataBits;
			this.stop_bits = stopBits;
			this.parity = parity;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00092F4C File Offset: 0x0009114C
		private static string GetDefaultPortName()
		{
			string[] portNames = SerialPort.GetPortNames();
			if (portNames.Length != 0)
			{
				return portNames[0];
			}
			int platform = (int)Environment.OSVersion.Platform;
			if (platform == 4 || platform == 128 || platform == 6)
			{
				return "ttyS0";
			}
			return "COM1";
		}

		/// <summary>Возвращает базовый объект <see cref="T:System.IO.Stream" /> для объекта <see cref="T:System.IO.Ports.SerialPort" />.</summary>
		/// <returns>Объект <see cref="T:System.IO.Stream" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток находится в приложении .NET Compact Framework и был вызван один из следующих методов: 
		///  <see cref="M:System.IO.Stream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /><see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /><see cref="M:System.IO.Stream.EndRead(System.IAsyncResult)" /><see cref="M:System.IO.Stream.EndWrite(System.IAsyncResult)" />  
		/// В .NET Compact Framework не поддерживается асинхронная модель с базовыми потоками.</exception>
		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x00092F8D File Offset: 0x0009118D
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Stream BaseStream
		{
			get
			{
				this.CheckOpen();
				return (Stream)this.stream;
			}
		}

		/// <summary>Возвращает или задает скорость передачи для последовательного порта (в бодах).</summary>
		/// <returns>Скорость в бодах.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанная скорость меньше или равна нулю, или больше максимальной допустимой скорости передачи для устройства.</exception>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002AAD RID: 10925 RVA: 0x00092FA0 File Offset: 0x000911A0
		// (set) Token: 0x06002AAE RID: 10926 RVA: 0x00092FA8 File Offset: 0x000911A8
		[Browsable(true)]
		[MonitoringDescription("")]
		[DefaultValue(9600)]
		public int BaudRate
		{
			get
			{
				return this.baud_rate;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (this.is_open)
				{
					this.stream.SetAttributes(value, this.parity, this.data_bits, this.stop_bits, this.handshake);
				}
				this.baud_rate = value;
			}
		}

		/// <summary>Возвращает или задает состояние сигнала разрыва.</summary>
		/// <returns>
		///   <see langword="true" />, если порт находится в состоянии разрыва, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x00092FF7 File Offset: 0x000911F7
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x00092FFF File Offset: 0x000911FF
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool BreakState
		{
			get
			{
				return this.break_state;
			}
			set
			{
				this.CheckOpen();
				if (value == this.break_state)
				{
					return;
				}
				this.stream.SetBreakState(value);
				this.break_state = value;
			}
		}

		/// <summary>Возвращает число байтов данных, находящихся в буфере приема.</summary>
		/// <returns>Число байтов данных, находящихся в буфере приема.</returns>
		/// <exception cref="T:System.InvalidOperationException">Порт не открыт.</exception>
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x00093024 File Offset: 0x00091224
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int BytesToRead
		{
			get
			{
				this.CheckOpen();
				return this.stream.BytesToRead;
			}
		}

		/// <summary>Возвращает число байтов данных, находящихся в буфере отправки.</summary>
		/// <returns>Число байтов данных, находящихся в буфере отправки.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x00093037 File Offset: 0x00091237
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public int BytesToWrite
		{
			get
			{
				this.CheckOpen();
				return this.stream.BytesToWrite;
			}
		}

		/// <summary>Возвращает состояние линии обнаружения несущей для порта.</summary>
		/// <returns>Значение <see langword="true" />, если несущая обнаружена, в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x0009304A File Offset: 0x0009124A
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool CDHolding
		{
			get
			{
				this.CheckOpen();
				return (this.stream.GetSignals() & SerialSignal.Cd) > SerialSignal.None;
			}
		}

		/// <summary>Возвращает состояние линии готовности к приему.</summary>
		/// <returns>Значение <see langword="true" />, если сигнал готовности к приему обнаружен, в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x00093062 File Offset: 0x00091262
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public bool CtsHolding
		{
			get
			{
				this.CheckOpen();
				return (this.stream.GetSignals() & SerialSignal.Cts) > SerialSignal.None;
			}
		}

		/// <summary>Возвращает или задает стандартное число битов данных в байте.</summary>
		/// <returns>Число битов данных.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число битов данных меньше 5 или больше 8.</exception>
		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x0009307A File Offset: 0x0009127A
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x00093084 File Offset: 0x00091284
		[MonitoringDescription("")]
		[Browsable(true)]
		[DefaultValue(8)]
		public int DataBits
		{
			get
			{
				return this.data_bits;
			}
			set
			{
				if (value < 5 || value > 8)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (this.is_open)
				{
					this.stream.SetAttributes(this.baud_rate, this.parity, value, this.stop_bits, this.handshake);
				}
				this.data_bits = value;
			}
		}

		/// <summary>Возвращает или задает значение, показывающее, игнорируются ли пустые байты (NULL), передаваемые между портом и буфером приема.</summary>
		/// <returns>
		///   <see langword="true" />, если байты NULL игнорируются, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x0000829A File Offset: 0x0000649A
		[DefaultValue(false)]
		[MonitoringDescription("")]
		[Browsable(true)]
		[MonoTODO("Not implemented")]
		public bool DiscardNull
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает или задает состояние сигнала готовности данных (DSR).</summary>
		/// <returns>Значение <see langword="true" />, если сигнал готовности данных отправлен в порт, в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x000930D7 File Offset: 0x000912D7
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool DsrHolding
		{
			get
			{
				this.CheckOpen();
				return (this.stream.GetSignals() & SerialSignal.Dsr) > SerialSignal.None;
			}
		}

		/// <summary>Возвращает или задает значение, включающее поддержку сигнала готовности терминала (DTR) в сеансе последовательной связи.</summary>
		/// <returns>
		///   <see langword="true" /> для включения сигнала готовности терминала (DTR), в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x000930EF File Offset: 0x000912EF
		// (set) Token: 0x06002ABB RID: 10939 RVA: 0x000930F7 File Offset: 0x000912F7
		[DefaultValue(false)]
		[MonitoringDescription("")]
		[Browsable(true)]
		public bool DtrEnable
		{
			get
			{
				return this.dtr_enable;
			}
			set
			{
				if (value == this.dtr_enable)
				{
					return;
				}
				if (this.is_open)
				{
					this.stream.SetSignal(SerialSignal.Dtr, value);
				}
				this.dtr_enable = value;
			}
		}

		/// <summary>Возвращает или задает кодировку байтов для преобразования текста до и после передачи.</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoding" />. Значение по умолчанию — <see cref="T:System.Text.ASCIIEncoding" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства <see cref="P:System.IO.Ports.SerialPort.Encoding" /> задано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В качестве свойства <see cref="P:System.IO.Ports.SerialPort.Encoding" /> задана кодировка, отличная от <see cref="T:System.Text.ASCIIEncoding" />, <see cref="T:System.Text.UTF8Encoding" />, <see cref="T:System.Text.UTF32Encoding" />, <see cref="T:System.Text.UnicodeEncoding" /> и любых однобайтовых и двухбайтовых кодировок Windows.</exception>
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x0009311F File Offset: 0x0009131F
		// (set) Token: 0x06002ABD RID: 10941 RVA: 0x00093127 File Offset: 0x00091327
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("")]
		public Encoding Encoding
		{
			get
			{
				return this.encoding;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.encoding = value;
			}
		}

		/// <summary>Возвращает или задает протокол установления связи для передачи данных через последовательный порт с использованием значения <see cref="T:System.IO.Ports.Handshake" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.IO.Ports.Handshake" />. Значение по умолчанию — <see langword="None" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Переданное значение не является допустимым значением перечисления <see cref="T:System.IO.Ports.Handshake" />.</exception>
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x0009313E File Offset: 0x0009133E
		// (set) Token: 0x06002ABF RID: 10943 RVA: 0x00093148 File Offset: 0x00091348
		[Browsable(true)]
		[MonitoringDescription("")]
		[DefaultValue(Handshake.None)]
		public Handshake Handshake
		{
			get
			{
				return this.handshake;
			}
			set
			{
				if (value < Handshake.None || value > Handshake.RequestToSendXOnXOff)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (this.is_open)
				{
					this.stream.SetAttributes(this.baud_rate, this.parity, this.data_bits, this.stop_bits, value);
				}
				this.handshake = value;
			}
		}

		/// <summary>Возвращает значение, указывающее открытое или закрытое состояние объекта <see cref="T:System.IO.Ports.SerialPort" />.</summary>
		/// <returns>Значение <see langword="true" />, если последовательный порт открыт, в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Переданное значение <see cref="P:System.IO.Ports.SerialPort.IsOpen" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Переданное значение <see cref="P:System.IO.Ports.SerialPort.IsOpen" /> является пустой строкой ("").</exception>
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x0009319B File Offset: 0x0009139B
		[Browsable(false)]
		public bool IsOpen
		{
			get
			{
				return this.is_open;
			}
		}

		/// <summary>Возвращает или задает значение, используемое для интерпретации окончания вызова методов <see cref="M:System.IO.Ports.SerialPort.ReadLine" /> и <see cref="M:System.IO.Ports.SerialPort.WriteLine(System.String)" />.</summary>
		/// <returns>Значение, представляющее конец строки. По умолчанию это знак перевода строки (<see cref="P:System.Environment.NewLine" />).</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства не указано.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства — <see langword="null" />.</exception>
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000931A3 File Offset: 0x000913A3
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x000931AB File Offset: 0x000913AB
		[DefaultValue("\n")]
		[MonitoringDescription("")]
		[Browsable(false)]
		public string NewLine
		{
			get
			{
				return this.new_line;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.Length == 0)
				{
					throw new ArgumentException("NewLine cannot be null or empty.", "value");
				}
				this.new_line = value;
			}
		}

		/// <summary>Возвращает или задает протокол контроля четности.</summary>
		/// <returns>Одно из значений перечисления, представляющее протокол контроля четности. Значение по умолчанию — <see cref="F:System.IO.Ports.Parity.None" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Переданное значение <see cref="P:System.IO.Ports.SerialPort.Parity" /> не является допустимым значением перечисления <see cref="T:System.IO.Ports.Parity" />.</exception>
		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000931DA File Offset: 0x000913DA
		// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x000931E4 File Offset: 0x000913E4
		[Browsable(true)]
		[MonitoringDescription("")]
		[DefaultValue(Parity.None)]
		public Parity Parity
		{
			get
			{
				return this.parity;
			}
			set
			{
				if (value < Parity.None || value > Parity.Space)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (this.is_open)
				{
					this.stream.SetAttributes(this.baud_rate, value, this.data_bits, this.stop_bits, this.handshake);
				}
				this.parity = value;
			}
		}

		/// <summary>Возвращает или задает байт, которым заменяются недопустимые байты потока данных при обнаружении ошибок четности.</summary>
		/// <returns>Байт для замены недопустимых байтов.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO("Not implemented")]
		[DefaultValue(63)]
		[MonitoringDescription("")]
		[Browsable(true)]
		public byte ParityReplace
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает или задает последовательный порт, в частности, любой из доступных портов COM.</summary>
		/// <returns>COM-порт. По умолчанию используется порт COM1.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству <see cref="P:System.IO.Ports.SerialPort.PortName" /> присвоено значение нулевой длины.  
		/// -или- 
		/// Свойству <see cref="P:System.IO.Ports.SerialPort.PortName" /> присвоено значение, начинающееся с "\\".  
		/// -или- 
		/// Недопустимое имя порта.</exception>
		/// <exception cref="T:System.ArgumentNullException">Для свойства <see cref="P:System.IO.Ports.SerialPort.PortName" /> задано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт открыт.</exception>
		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x00093237 File Offset: 0x00091437
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x00093240 File Offset: 0x00091440
		[DefaultValue("COM1")]
		[MonitoringDescription("")]
		[Browsable(true)]
		public string PortName
		{
			get
			{
				return this.port_name;
			}
			set
			{
				if (this.is_open)
				{
					throw new InvalidOperationException("Port name cannot be set while port is open.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.Length == 0 || value.StartsWith("\\\\"))
				{
					throw new ArgumentException("value");
				}
				this.port_name = value;
			}
		}

		/// <summary>Возвращает или задает размер входного буфера <see cref="T:System.IO.Ports.SerialPort" />.</summary>
		/// <returns>Размер буфера в байтах. Значение по умолчанию равно 4096; максимальное значение является положительным int или 2147483647.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Задаваемое значение <see cref="P:System.IO.Ports.SerialPort.ReadBufferSize" /> меньше или равно нулю.</exception>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.IO.Ports.SerialPort.ReadBufferSize" /> было установлено при открытом потоке.</exception>
		/// <exception cref="T:System.IO.IOException">Свойству <see cref="P:System.IO.Ports.SerialPort.ReadBufferSize" /> присвоено нечетное значение.</exception>
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x00093295 File Offset: 0x00091495
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0009329D File Offset: 0x0009149D
		[Browsable(true)]
		[MonitoringDescription("")]
		[DefaultValue(4096)]
		public int ReadBufferSize
		{
			get
			{
				return this.readBufferSize;
			}
			set
			{
				if (this.is_open)
				{
					throw new InvalidOperationException();
				}
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (value <= 4096)
				{
					return;
				}
				this.readBufferSize = value;
			}
		}

		/// <summary>Возвращает или задает срок ожидания в миллисекундах для завершения операции чтения.</summary>
		/// <returns>Срок ожидания в миллисекундах для завершения операции чтения.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Срок ожидания чтения меньше нуля и отличен от <see cref="F:System.IO.Ports.SerialPort.InfiniteTimeout" />.</exception>
		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000932CC File Offset: 0x000914CC
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x000932D4 File Offset: 0x000914D4
		[MonitoringDescription("")]
		[Browsable(true)]
		[DefaultValue(-1)]
		public int ReadTimeout
		{
			get
			{
				return this.read_timeout;
			}
			set
			{
				if (value < 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (this.is_open)
				{
					this.stream.ReadTimeout = value;
				}
				this.read_timeout = value;
			}
		}

		/// <summary>Возвращает или задает число байтов во внутреннем входном буфере до возникновения события <see cref="E:System.IO.Ports.SerialPort.DataReceived" />.</summary>
		/// <returns>Число байтов во внутреннем входном буфере до возникновения события <see cref="E:System.IO.Ports.SerialPort.DataReceived" />. Значение по умолчанию — 1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <see cref="P:System.IO.Ports.SerialPort.ReceivedBytesThreshold" /> меньше или равно нулю.</exception>
		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0000829A File Offset: 0x0000649A
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x00093304 File Offset: 0x00091504
		[MonitoringDescription("")]
		[Browsable(true)]
		[MonoTODO("Not implemented")]
		[DefaultValue(1)]
		public int ReceivedBytesThreshold
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает или задает значение, показывающее, включен ли сигнал запроса передачи (RTS) в сеансе последовательной связи.</summary>
		/// <returns>
		///   <see langword="true" /> для включения запроса передачи (RTS), в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.IO.Ports.SerialPort.RtsEnable" /> устанавливается или извлекается, в то время как свойству <see cref="P:System.IO.Ports.SerialPort.Handshake" /> присваивается значение <see cref="F:System.IO.Ports.Handshake.RequestToSend" /> или <see cref="F:System.IO.Ports.Handshake.RequestToSendXOnXOff" />.</exception>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x0009331A File Offset: 0x0009151A
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x00093322 File Offset: 0x00091522
		[DefaultValue(false)]
		[Browsable(true)]
		[MonitoringDescription("")]
		public bool RtsEnable
		{
			get
			{
				return this.rts_enable;
			}
			set
			{
				if (value == this.rts_enable)
				{
					return;
				}
				if (this.is_open)
				{
					this.stream.SetSignal(SerialSignal.Rts, value);
				}
				this.rts_enable = value;
			}
		}

		/// <summary>Возвращает или задает стандартное число стоповых битов в байте.</summary>
		/// <returns>Одно из значений <see cref="T:System.IO.Ports.StopBits" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <see cref="P:System.IO.Ports.SerialPort.StopBits" /> равно <see cref="F:System.IO.Ports.StopBits.None" />.</exception>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x0009334B File Offset: 0x0009154B
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x00093354 File Offset: 0x00091554
		[DefaultValue(StopBits.One)]
		[Browsable(true)]
		[MonitoringDescription("")]
		public StopBits StopBits
		{
			get
			{
				return this.stop_bits;
			}
			set
			{
				if (value < StopBits.One || value > StopBits.OnePointFive)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (this.is_open)
				{
					this.stream.SetAttributes(this.baud_rate, this.parity, this.data_bits, value, this.handshake);
				}
				this.stop_bits = value;
			}
		}

		/// <summary>Возвращает или задает размер выходного буфера последовательного порта.</summary>
		/// <returns>Размер выходного буфера. Значение по умолчанию — 2048.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <see cref="P:System.IO.Ports.SerialPort.WriteBufferSize" /> меньше или равно нулю.</exception>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.IO.Ports.SerialPort.WriteBufferSize" /> было установлено при открытом потоке.</exception>
		/// <exception cref="T:System.IO.IOException">Свойству <see cref="P:System.IO.Ports.SerialPort.WriteBufferSize" /> присвоено нечетное значение.</exception>
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000933A7 File Offset: 0x000915A7
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x000933AF File Offset: 0x000915AF
		[MonitoringDescription("")]
		[DefaultValue(2048)]
		[Browsable(true)]
		public int WriteBufferSize
		{
			get
			{
				return this.writeBufferSize;
			}
			set
			{
				if (this.is_open)
				{
					throw new InvalidOperationException();
				}
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (value <= 2048)
				{
					return;
				}
				this.writeBufferSize = value;
			}
		}

		/// <summary>Возвращает или задает срок ожидания в миллисекундах для завершения операции записи.</summary>
		/// <returns>Количество миллисекунд до истечения времени ожидания. Значение по умолчанию — <see cref="F:System.IO.Ports.SerialPort.InfiniteTimeout" />.</returns>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <see cref="P:System.IO.Ports.SerialPort.WriteTimeout" /> меньше нуля и отлично от <see cref="F:System.IO.Ports.SerialPort.InfiniteTimeout" />.</exception>
		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x000933DE File Offset: 0x000915DE
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x000933E6 File Offset: 0x000915E6
		[Browsable(true)]
		[DefaultValue(-1)]
		[MonitoringDescription("")]
		public int WriteTimeout
		{
			get
			{
				return this.write_timeout;
			}
			set
			{
				if (value < 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (this.is_open)
				{
					this.stream.WriteTimeout = value;
				}
				this.write_timeout = value;
			}
		}

		/// <summary>Закрывает соединение порта, присваивает свойству <see cref="P:System.IO.Ports.SerialPort.IsOpen" /> значение <see langword="false" /> и уничтожает внутренний объект <see cref="T:System.IO.Stream" />.</summary>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		// Token: 0x06002AD7 RID: 10967 RVA: 0x00093416 File Offset: 0x00091616
		public void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.Ports.SerialPort" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		// Token: 0x06002AD8 RID: 10968 RVA: 0x0009341F File Offset: 0x0009161F
		protected override void Dispose(bool disposing)
		{
			if (!this.is_open)
			{
				return;
			}
			this.is_open = false;
			if (disposing)
			{
				this.stream.Close();
			}
			this.stream = null;
		}

		/// <summary>Удаляет данные из буфера приема последовательного драйвера.</summary>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		// Token: 0x06002AD9 RID: 10969 RVA: 0x00093446 File Offset: 0x00091646
		public void DiscardInBuffer()
		{
			this.CheckOpen();
			this.stream.DiscardInBuffer();
		}

		/// <summary>Удаляет данные из буфера передачи последовательного драйвера.</summary>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток закрыт. Это может произойти, если метод <see cref="M:System.IO.Ports.SerialPort.Open" /> не был вызван или же, напротив, вызван метод <see cref="M:System.IO.Ports.SerialPort.Close" />.</exception>
		// Token: 0x06002ADA RID: 10970 RVA: 0x00093459 File Offset: 0x00091659
		public void DiscardOutBuffer()
		{
			this.CheckOpen();
			this.stream.DiscardOutBuffer();
		}

		/// <summary>Возвращает массив имен последовательных портов для текущего компьютера.</summary>
		/// <returns>Массив имен последовательных портов для текущего компьютера.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удалось выполнить запрос имен последовательных портов.</exception>
		// Token: 0x06002ADB RID: 10971 RVA: 0x0009346C File Offset: 0x0009166C
		public static string[] GetPortNames()
		{
			int platform = (int)Environment.OSVersion.Platform;
			List<string> list = new List<string>();
			if (platform == 4 || platform == 128 || platform == 6)
			{
				string[] files = Directory.GetFiles("/dev/", "tty*");
				bool flag = false;
				foreach (string text in files)
				{
					if (text.StartsWith("/dev/ttyS") || text.StartsWith("/dev/ttyUSB") || text.StartsWith("/dev/ttyACM"))
					{
						flag = true;
						break;
					}
				}
				foreach (string text2 in files)
				{
					if (flag)
					{
						if (text2.StartsWith("/dev/ttyS") || text2.StartsWith("/dev/ttyUSB") || text2.StartsWith("/dev/ttyACM"))
						{
							list.Add(text2);
						}
					}
					else if (text2 != "/dev/tty" && text2.StartsWith("/dev/tty") && !text2.StartsWith("/dev/ttyC"))
					{
						list.Add(text2);
					}
				}
			}
			else
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\SERIALCOMM"))
				{
					if (registryKey != null)
					{
						foreach (string name in registryKey.GetValueNames())
						{
							string text3 = registryKey.GetValue(name, "").ToString();
							if (text3 != "")
							{
								list.Add(text3);
							}
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x0009360C File Offset: 0x0009180C
		private static bool IsWindows
		{
			get
			{
				PlatformID platform = Environment.OSVersion.Platform;
				return platform == PlatformID.Win32Windows || platform == PlatformID.Win32NT;
			}
		}

		/// <summary>Открывает новое соединение последовательного порта.</summary>
		/// <exception cref="T:System.UnauthorizedAccessException">Отказ в доступе к порту.  
		/// -или- 
		/// Для текущего процесса или другого процесса в системе уже открыт заданный порт COM — экземпляром <see cref="T:System.IO.Ports.SerialPort" /> или в неуправляемом коде.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Одно или несколько свойств этого экземпляра недопустимы. Например, свойство <see cref="P:System.IO.Ports.SerialPort.Parity" />, <see cref="P:System.IO.Ports.SerialPort.DataBits" /> или <see cref="P:System.IO.Ports.SerialPort.Handshake" /> имеет недопустимое значение, значение <see cref="P:System.IO.Ports.SerialPort.BaudRate" /> меньше или равно нулю, значение <see cref="P:System.IO.Ports.SerialPort.ReadTimeout" /> или <see cref="P:System.IO.Ports.SerialPort.WriteTimeout" /> меньше нуля и отлично от <see cref="F:System.IO.Ports.SerialPort.InfiniteTimeout" />.</exception>
		/// <exception cref="T:System.ArgumentException">Имя порта не начинается с "COM".  
		/// -или- 
		/// Тип файла порта не поддерживается.</exception>
		/// <exception cref="T:System.IO.IOException">Порт находится в недействительном состоянии.  
		/// -или- 
		/// Попытка задать состояние базового порта завершилась неудачей. Например, вследствие недопустимости переданных этим объектом <see cref="T:System.IO.Ports.SerialPort" /> параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Заданный порт текущего экземпляра объекта <see cref="T:System.IO.Ports.SerialPort" /> уже открыт.</exception>
		// Token: 0x06002ADD RID: 10973 RVA: 0x00093630 File Offset: 0x00091830
		public void Open()
		{
			if (this.is_open)
			{
				throw new InvalidOperationException("Port is already open");
			}
			if (SerialPort.IsWindows)
			{
				this.stream = new WinSerialStream(this.port_name, this.baud_rate, this.data_bits, this.parity, this.stop_bits, this.dtr_enable, this.rts_enable, this.handshake, this.read_timeout, this.write_timeout, this.readBufferSize, this.writeBufferSize);
			}
			else
			{
				this.stream = new SerialPortStream(this.port_name, this.baud_rate, this.data_bits, this.parity, this.stop_bits, this.dtr_enable, this.rts_enable, this.handshake, this.read_timeout, this.write_timeout, this.readBufferSize, this.writeBufferSize);
			}
			this.is_open = true;
		}

		/// <summary>Считывает из входного буфера <see cref="T:System.IO.Ports.SerialPort" /> определенное число байтов и записывает их в байтовый массив, начиная с указанной позиции.</summary>
		/// <param name="buffer">Массив байтов, в который записываются входные данные.</param>
		/// <param name="offset">Смещение в <paramref name="buffer" />, с которым следует записывать байты.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения. Считывается меньшее число байтов, если <paramref name="count" /> больше числа байтов во входном буфере.</param>
		/// <returns>Количество прочитанных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Буфер для записи задан значением <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="count" /> выходит за пределы указанного массива <paramref name="buffer" />. Значение параметра <paramref name="offset" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" /> плюс <paramref name="count" /> превышает длину массива <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.TimeoutException">Отсутствуют байты, доступные для чтения.</exception>
		// Token: 0x06002ADE RID: 10974 RVA: 0x00093708 File Offset: 0x00091908
		public int Read(byte[] buffer, int offset, int count)
		{
			this.CheckOpen();
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException("offset or count less than zero.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("offset+count", "The size of the buffer is less than offset + count.");
			}
			return this.stream.Read(buffer, offset, count);
		}

		/// <summary>Считывает из входного буфера <see cref="T:System.IO.Ports.SerialPort" /> определенное число символов и записывает их в символьный массив, начиная с указанной позиции.</summary>
		/// <param name="buffer">Массив символов, в который записываются входные данные.</param>
		/// <param name="offset">Смещение в <paramref name="buffer" />, с которым следует записывать знаки.</param>
		/// <param name="count">Максимальное число считываемых символов. Считывается меньшее число знаков, если <paramref name="count" /> больше числа знаков во входном буфере.</param>
		/// <returns>Число прочитанных знаков.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" /> плюс <paramref name="count" /> превышает длину буфера.  
		/// -или- 
		///  <paramref name="count" /> равно 1 и в буфере имеется символ-суррогат.</exception>
		/// <exception cref="T:System.ArgumentNullException">В качестве <paramref name="buffer" /> передано <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="count" /> выходит за пределы указанного массива <paramref name="buffer" />. Значение параметра <paramref name="offset" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.TimeoutException">Отсутствуют символы, доступные для чтения.</exception>
		// Token: 0x06002ADF RID: 10975 RVA: 0x00093764 File Offset: 0x00091964
		public int Read(char[] buffer, int offset, int count)
		{
			this.CheckOpen();
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException("offset or count less than zero.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("offset+count", "The size of the buffer is less than offset + count.");
			}
			int num = 0;
			int num2;
			while (num < count && (num2 = this.ReadChar()) != -1)
			{
				buffer[offset + num] = (char)num2;
				num++;
			}
			return num;
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000937D0 File Offset: 0x000919D0
		internal int read_byte()
		{
			byte[] array = new byte[1];
			if (this.stream.Read(array, 0, 1) > 0)
			{
				return (int)array[0];
			}
			return -1;
		}

		/// <summary>Считывает из входного буфера <see cref="T:System.IO.Ports.SerialPort" /> один байт в синхронном режиме.</summary>
		/// <returns>Байт, приведенный к типу <see cref="T:System.Int32" />, или -1, если достигнут конец потока.</returns>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">Операция не была завершена до истечения срока ожидания.  
		/// -или- 
		/// Не считано ни одного байта.</exception>
		// Token: 0x06002AE1 RID: 10977 RVA: 0x000937FA File Offset: 0x000919FA
		public int ReadByte()
		{
			this.CheckOpen();
			return this.read_byte();
		}

		/// <summary>Считывает из входного буфера <see cref="T:System.IO.Ports.SerialPort" /> один символ в синхронном режиме.</summary>
		/// <returns>Прочитанный символ.</returns>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">Операция не была завершена до истечения срока ожидания.  
		/// -или- 
		/// В течение отведенного срока ожидания не было доступно ни одного символа.</exception>
		// Token: 0x06002AE2 RID: 10978 RVA: 0x00093808 File Offset: 0x00091A08
		public int ReadChar()
		{
			this.CheckOpen();
			byte[] array = new byte[16];
			int num = 0;
			char[] chars;
			for (;;)
			{
				int num2 = this.read_byte();
				if (num2 == -1)
				{
					break;
				}
				array[num++] = (byte)num2;
				chars = this.encoding.GetChars(array, 0, 1);
				if (chars.Length != 0)
				{
					goto Block_2;
				}
				if (num >= array.Length)
				{
					return -1;
				}
			}
			return -1;
			Block_2:
			return (int)chars[0];
		}

		/// <summary>Считывает все непосредственно доступные байты в соответствии с кодировкой из потока и из входного буфера объекта <see cref="T:System.IO.Ports.SerialPort" />.</summary>
		/// <returns>Содержимое потока и входного буфера объекта <see cref="T:System.IO.Ports.SerialPort" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		// Token: 0x06002AE3 RID: 10979 RVA: 0x0009385C File Offset: 0x00091A5C
		public string ReadExisting()
		{
			this.CheckOpen();
			int bytesToRead = this.BytesToRead;
			byte[] array = new byte[bytesToRead];
			int count = this.stream.Read(array, 0, bytesToRead);
			return new string(this.encoding.GetChars(array, 0, count));
		}

		/// <summary>Считывает данные из входного буфера до значения <see cref="P:System.IO.Ports.SerialPort.NewLine" />.</summary>
		/// <returns>Содержимое входного буфера до первого появления значения <see cref="P:System.IO.Ports.SerialPort.NewLine" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.TimeoutException">Операция не была завершена до истечения срока ожидания.  
		/// -или- 
		/// Не считано ни одного байта.</exception>
		// Token: 0x06002AE4 RID: 10980 RVA: 0x0009389F File Offset: 0x00091A9F
		public string ReadLine()
		{
			return this.ReadTo(this.new_line);
		}

		/// <summary>Считывает из входного буфера строку до указанного значения <paramref name="value" />.</summary>
		/// <param name="value">Значение, указывающее место прекращения операции чтения.</param>
		/// <returns>Содержимое входного буфера до указанного <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="value" /> равна 0.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.TimeoutException">Операция не была завершена до истечения срока ожидания.</exception>
		// Token: 0x06002AE5 RID: 10981 RVA: 0x000938B0 File Offset: 0x00091AB0
		public string ReadTo(string value)
		{
			this.CheckOpen();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException("value");
			}
			byte[] bytes = this.encoding.GetBytes(value);
			int num = 0;
			List<byte> list = new List<byte>();
			for (;;)
			{
				int num2 = this.read_byte();
				if (num2 == -1)
				{
					goto IL_89;
				}
				list.Add((byte)num2);
				if (num2 == (int)bytes[num])
				{
					num++;
					if (num == bytes.Length)
					{
						break;
					}
				}
				else
				{
					num = (((int)bytes[0] == num2) ? 1 : 0);
				}
			}
			return this.encoding.GetString(list.ToArray(), 0, list.Count - bytes.Length);
			IL_89:
			return this.encoding.GetString(list.ToArray());
		}

		/// <summary>Записывает указанную строку в последовательный порт.</summary>
		/// <param name="text">Строка для вывода.</param>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="text" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">Операция не была завершена до истечения срока ожидания.</exception>
		// Token: 0x06002AE6 RID: 10982 RVA: 0x00093958 File Offset: 0x00091B58
		public void Write(string text)
		{
			this.CheckOpen();
			if (text == null)
			{
				throw new ArgumentNullException("text");
			}
			byte[] bytes = this.encoding.GetBytes(text);
			this.Write(bytes, 0, bytes.Length);
		}

		/// <summary>Записывает указанное число байтов в последовательный порт, используя данные из буфера.</summary>
		/// <param name="buffer">Массив байтов, данные из которого записываются в порт.</param>
		/// <param name="offset">Отсчитываемое от нуля смещение в массиве <paramref name="buffer" /> (в байтах), с которого начинается копирование байтов в порт.</param>
		/// <param name="count">Количество записываемых байтов.</param>
		/// <exception cref="T:System.ArgumentNullException">В качестве <paramref name="buffer" /> передано <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="count" /> выходит за пределы указанного массива <paramref name="buffer" />. Значение параметра <paramref name="offset" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" /> плюс <paramref name="count" /> превышает длину массива <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">Операция не была завершена до истечения срока ожидания.</exception>
		// Token: 0x06002AE7 RID: 10983 RVA: 0x00093994 File Offset: 0x00091B94
		public void Write(byte[] buffer, int offset, int count)
		{
			this.CheckOpen();
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("offset+count", "The size of the buffer is less than offset + count.");
			}
			this.stream.Write(buffer, offset, count);
		}

		/// <summary>Записывает указанное число символов в последовательный порт, используя данные из буфера.</summary>
		/// <param name="buffer">Массив символов, данные из которого записываются в порт.</param>
		/// <param name="offset">Отсчитываемое от нуля смещение в массиве <paramref name="buffer" /> (в байтах), с которого начинается копирование байтов в порт.</param>
		/// <param name="count">Количество символов для записи.</param>
		/// <exception cref="T:System.ArgumentNullException">В качестве <paramref name="buffer" /> передано <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="count" /> выходит за пределы указанного массива <paramref name="buffer" />. Значение параметра <paramref name="offset" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" /> плюс <paramref name="count" /> превышает длину массива <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">Операция не была завершена до истечения срока ожидания.</exception>
		// Token: 0x06002AE8 RID: 10984 RVA: 0x000939EC File Offset: 0x00091BEC
		public void Write(char[] buffer, int offset, int count)
		{
			this.CheckOpen();
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("offset+count", "The size of the buffer is less than offset + count.");
			}
			byte[] bytes = this.encoding.GetBytes(buffer, offset, count);
			this.stream.Write(bytes, 0, bytes.Length);
		}

		/// <summary>Записывает указанную строку и значение <see cref="P:System.IO.Ports.SerialPort.NewLine" /> в выходной буфер.</summary>
		/// <param name="text">Строка для записи в выходной буфер.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="text" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Указанный порт не открыт.</exception>
		/// <exception cref="T:System.TimeoutException">Метод <see cref="M:System.IO.Ports.SerialPort.WriteLine(System.String)" /> не выполнил запись в поток.</exception>
		// Token: 0x06002AE9 RID: 10985 RVA: 0x00093A52 File Offset: 0x00091C52
		public void WriteLine(string text)
		{
			this.Write(text + this.new_line);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x00093A66 File Offset: 0x00091C66
		private void CheckOpen()
		{
			if (!this.is_open)
			{
				throw new InvalidOperationException("Specified port is not open.");
			}
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x00093A7C File Offset: 0x00091C7C
		internal void OnErrorReceived(SerialErrorReceivedEventArgs args)
		{
			SerialErrorReceivedEventHandler serialErrorReceivedEventHandler = (SerialErrorReceivedEventHandler)base.Events[this.error_received];
			if (serialErrorReceivedEventHandler != null)
			{
				serialErrorReceivedEventHandler(this, args);
			}
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00093AAC File Offset: 0x00091CAC
		internal void OnDataReceived(SerialDataReceivedEventArgs args)
		{
			SerialDataReceivedEventHandler serialDataReceivedEventHandler = (SerialDataReceivedEventHandler)base.Events[this.data_received];
			if (serialDataReceivedEventHandler != null)
			{
				serialDataReceivedEventHandler(this, args);
			}
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00093ADC File Offset: 0x00091CDC
		internal void OnDataReceived(SerialPinChangedEventArgs args)
		{
			SerialPinChangedEventHandler serialPinChangedEventHandler = (SerialPinChangedEventHandler)base.Events[this.pin_changed];
			if (serialPinChangedEventHandler != null)
			{
				serialPinChangedEventHandler(this, args);
			}
		}

		/// <summary>Указывает, что произошла ошибка с портом, представленным объектом <see cref="T:System.IO.Ports.SerialPort" />.</summary>
		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06002AEE RID: 10990 RVA: 0x00093B0B File Offset: 0x00091D0B
		// (remove) Token: 0x06002AEF RID: 10991 RVA: 0x00093B1F File Offset: 0x00091D1F
		[MonitoringDescription("")]
		public event SerialErrorReceivedEventHandler ErrorReceived
		{
			add
			{
				base.Events.AddHandler(this.error_received, value);
			}
			remove
			{
				base.Events.RemoveHandler(this.error_received, value);
			}
		}

		/// <summary>Указывает, что для порта, представленного объектом <see cref="T:System.IO.Ports.SerialPort" />, возникло событие сигнала, не связанного с данными.</summary>
		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06002AF0 RID: 10992 RVA: 0x00093B33 File Offset: 0x00091D33
		// (remove) Token: 0x06002AF1 RID: 10993 RVA: 0x00093B47 File Offset: 0x00091D47
		[MonitoringDescription("")]
		public event SerialPinChangedEventHandler PinChanged
		{
			add
			{
				base.Events.AddHandler(this.pin_changed, value);
			}
			remove
			{
				base.Events.RemoveHandler(this.pin_changed, value);
			}
		}

		/// <summary>Указывает, что данные были получены через порт, представленный объектом <see cref="T:System.IO.Ports.SerialPort" />.</summary>
		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06002AF2 RID: 10994 RVA: 0x00093B5B File Offset: 0x00091D5B
		// (remove) Token: 0x06002AF3 RID: 10995 RVA: 0x00093B6F File Offset: 0x00091D6F
		[MonitoringDescription("")]
		public event SerialDataReceivedEventHandler DataReceived
		{
			add
			{
				base.Events.AddHandler(this.data_received, value);
			}
			remove
			{
				base.Events.RemoveHandler(this.data_received, value);
			}
		}

		/// <summary>Указывает, что отсчет времени ожидания не производится.</summary>
		// Token: 0x04001720 RID: 5920
		public const int InfiniteTimeout = -1;

		// Token: 0x04001721 RID: 5921
		private const int DefaultReadBufferSize = 4096;

		// Token: 0x04001722 RID: 5922
		private const int DefaultWriteBufferSize = 2048;

		// Token: 0x04001723 RID: 5923
		private const int DefaultBaudRate = 9600;

		// Token: 0x04001724 RID: 5924
		private const int DefaultDataBits = 8;

		// Token: 0x04001725 RID: 5925
		private const Parity DefaultParity = Parity.None;

		// Token: 0x04001726 RID: 5926
		private const StopBits DefaultStopBits = StopBits.One;

		// Token: 0x04001727 RID: 5927
		private bool is_open;

		// Token: 0x04001728 RID: 5928
		private int baud_rate;

		// Token: 0x04001729 RID: 5929
		private Parity parity;

		// Token: 0x0400172A RID: 5930
		private StopBits stop_bits;

		// Token: 0x0400172B RID: 5931
		private Handshake handshake;

		// Token: 0x0400172C RID: 5932
		private int data_bits;

		// Token: 0x0400172D RID: 5933
		private bool break_state;

		// Token: 0x0400172E RID: 5934
		private bool dtr_enable;

		// Token: 0x0400172F RID: 5935
		private bool rts_enable;

		// Token: 0x04001730 RID: 5936
		private ISerialStream stream;

		// Token: 0x04001731 RID: 5937
		private Encoding encoding = Encoding.ASCII;

		// Token: 0x04001732 RID: 5938
		private string new_line = Environment.NewLine;

		// Token: 0x04001733 RID: 5939
		private string port_name;

		// Token: 0x04001734 RID: 5940
		private int read_timeout = -1;

		// Token: 0x04001735 RID: 5941
		private int write_timeout = -1;

		// Token: 0x04001736 RID: 5942
		private int readBufferSize = 4096;

		// Token: 0x04001737 RID: 5943
		private int writeBufferSize = 2048;

		// Token: 0x04001738 RID: 5944
		private object error_received = new object();

		// Token: 0x04001739 RID: 5945
		private object data_received = new object();

		// Token: 0x0400173A RID: 5946
		private object pin_changed = new object();
	}
}
