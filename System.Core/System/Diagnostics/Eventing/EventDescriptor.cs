using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing
{
	/// <summary>
	///         Содержит метаданные, определяющие событие.
	///       </summary>
	// Token: 0x02000393 RID: 915
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	public struct EventDescriptor
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.EventDescriptor" />.
		///       </summary>
		/// <param name="id">
		///           Идентификатор события.
		///         </param>
		/// <param name="version">
		///           Версия события.
		///            Эта версия указывает редакцию для определения события.
		///            Этот элемент и его идентификатор можно использовать для определения уникального события.
		///         </param>
		/// <param name="channel">
		///           Определяет потенциальный целевой объект для события.
		///         </param>
		/// <param name="level">
		///           Задает уровень детализации сведений, включенных в событие.
		///         </param>
		/// <param name="opcode">
		///           Операция, выполняемая в момент создания события.
		///         </param>
		/// <param name="task">
		///           Идентифицирует логический компонент приложения, выполняющего запись события.
		///         </param>
		/// <param name="keywords">
		///           Битовая маска, указывающая категорию события.
		///            Ключевое слово может содержать одно или несколько определяемых поставщиком или стандартных ключевых слов либо их сочетание.
		///         </param>
		// Token: 0x06001B50 RID: 6992 RVA: 0x0000235B File Offset: 0x0000055B
		public EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Получает значение канала из дескриптора событий.
		///       </summary>
		/// <returns>
		///         Канал, который определяет потенциальную цель для события.
		///       </returns>
		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0005A33C File Offset: 0x0005853C
		public byte Channel
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает значение идентификатора события из дескриптора событий.
		///       </summary>
		/// <returns>
		///         Идентификатор события.
		///       </returns>
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0005A358 File Offset: 0x00058558
		public int EventId
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Получает значение ключевого слова из дескриптора событий.
		///       </summary>
		/// <returns>
		///         Ключевое слово, которое является битовой маской, указывающее категорию событий.
		///       </returns>
		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0005A374 File Offset: 0x00058574
		public long Keywords
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0L;
			}
		}

		/// <summary>
		///         Получает значение уровня из дескриптора событий.
		///       </summary>
		/// <returns>
		///         Уровень детализации сведений, включаемых в событие.
		///       </returns>
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0005A390 File Offset: 0x00058590
		public byte Level
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Получает значение кода операции из дескриптора событий.
		///       </summary>
		/// <returns>
		///         Операция, выполняемая во время записи события.
		///       </returns>
		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x0005A3AC File Offset: 0x000585AC
		public byte Opcode
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Получает значение задачи из дескриптора событий.
		///       </summary>
		/// <returns>
		///         Задача, которая определяет логический компонент приложения, записывающего событие.
		///       </returns>
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0005A3C8 File Offset: 0x000585C8
		public int Task
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Получает значение версии из дескриптора событий.
		///       </summary>
		/// <returns>
		///         Версия события.
		///       </returns>
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0005A3E4 File Offset: 0x000585E4
		public byte Version
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}
	}
}
