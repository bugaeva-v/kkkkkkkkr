using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics
{
	/// <summary>Инкапсулирует единичную запись в журнале событий. Этот класс не наследуется.</summary>
	// Token: 0x0200025A RID: 602
	[DesignTimeVisible(false)]
	[ToolboxItem(false)]
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[Serializable]
	public sealed class EventLogEntry : Component, ISerializable
	{
		// Token: 0x060012C3 RID: 4803 RVA: 0x00050750 File Offset: 0x0004E950
		internal EventLogEntry(string category, short categoryNumber, int index, int eventID, string source, string message, string userName, string machineName, EventLogEntryType entryType, DateTime timeGenerated, DateTime timeWritten, byte[] data, string[] replacementStrings, long instanceId)
		{
			this.category = category;
			this.categoryNumber = categoryNumber;
			this.data = data;
			this.entryType = entryType;
			this.eventID = eventID;
			this.index = index;
			this.machineName = machineName;
			this.message = message;
			this.replacementStrings = replacementStrings;
			this.source = source;
			this.timeGenerated = timeGenerated;
			this.timeWritten = timeWritten;
			this.userName = userName;
			this.instanceId = instanceId;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000507D0 File Offset: 0x0004E9D0
		[MonoTODO]
		private EventLogEntry(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Получает текст, связанный со свойством <see cref="P:System.Diagnostics.EventLogEntry.CategoryNumber" /> для этой записи.</summary>
		/// <returns>Текст категории, связанный с конкретным приложением.</returns>
		/// <exception cref="T:System.Exception">Не удалось выделить пространство для одной из строк вставки, связанных с данной категорией.</exception>
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x000507D8 File Offset: 0x0004E9D8
		[MonitoringDescription("The category of this event entry.")]
		public string Category
		{
			get
			{
				return this.category;
			}
		}

		/// <summary>Получает номер категории для записи в журнале событий.</summary>
		/// <returns>Номер связанной с определенным приложением категории этой записи.</returns>
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x000507E0 File Offset: 0x0004E9E0
		[MonitoringDescription("An ID for the category of this event entry.")]
		public short CategoryNumber
		{
			get
			{
				return this.categoryNumber;
			}
		}

		/// <summary>Получает двоичные данные, связанные с этой записью.</summary>
		/// <returns>Массив байтов, в котором хранятся двоичные данные, связанные с записью.</returns>
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x000507E8 File Offset: 0x0004E9E8
		[MonitoringDescription("Binary data associated with this event entry.")]
		public byte[] Data
		{
			get
			{
				return this.data;
			}
		}

		/// <summary>Получает тип события этой записи.</summary>
		/// <returns>Тип события, связанный с записью в журнале событий.</returns>
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x000507F0 File Offset: 0x0004E9F0
		[MonitoringDescription("The type of this event entry.")]
		public EventLogEntryType EntryType
		{
			get
			{
				return this.entryType;
			}
		}

		/// <summary>Получает идентификатор события конкретного приложения для текущей записи события.</summary>
		/// <returns>Идентификатор сообщения о событии для конкретного приложения.</returns>
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x000507F8 File Offset: 0x0004E9F8
		[MonitoringDescription("An ID number for this event entry.")]
		[Obsolete("Use InstanceId")]
		public int EventID
		{
			get
			{
				return this.eventID;
			}
		}

		/// <summary>Получает индекс данной записи в журнале событий.</summary>
		/// <returns>Индекс записи в журнале событий.</returns>
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x00050800 File Offset: 0x0004EA00
		[MonitoringDescription("Sequence numer of this event entry.")]
		public int Index
		{
			get
			{
				return this.index;
			}
		}

		/// <summary>Получает идентификатор ресурса, определяющий текст сообщения для записи о событии.</summary>
		/// <returns>Идентификатор ресурса, соответствующий определению строки в файле ресурсов сообщения для источника событий.</returns>
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x00050808 File Offset: 0x0004EA08
		[MonitoringDescription("The instance ID for this event entry.")]
		[ComVisible(false)]
		public long InstanceId
		{
			get
			{
				return this.instanceId;
			}
		}

		/// <summary>Получает имя компьютера, на котором было создано данное событие.</summary>
		/// <returns>Имя компьютера, содержащего журнал событий.</returns>
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x00050810 File Offset: 0x0004EA10
		[MonitoringDescription("The Computer on which this event entry occured.")]
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
		}

		/// <summary>Получает локализованное сообщение, связанное с этой записью о событии.</summary>
		/// <returns>Форматированный, локализованный текст сообщения. Включает в себя связанные строки замены.</returns>
		/// <exception cref="T:System.Exception">Не удалось выделить пространство для одной из строк вставки, связанной с сообщением.</exception>
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x00050818 File Offset: 0x0004EA18
		[MonitoringDescription("The message of this event entry.")]
		[Editor("System.ComponentModel.Design.BinaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string Message
		{
			get
			{
				return this.message;
			}
		}

		/// <summary>Получает строки замены, связанные с данной записью в журнале событий.</summary>
		/// <returns>Массив, содержащий строки замены, хранящиеся в записи о событии.</returns>
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00050820 File Offset: 0x0004EA20
		[MonitoringDescription("Application strings for this event entry.")]
		public string[] ReplacementStrings
		{
			get
			{
				return this.replacementStrings;
			}
		}

		/// <summary>Получает имя приложения, создавшего это событие.</summary>
		/// <returns>Имя, зарегистрированное в журнале событий как имя источника этого события.</returns>
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00050828 File Offset: 0x0004EA28
		[MonitoringDescription("The source application of this event entry.")]
		public string Source
		{
			get
			{
				return this.source;
			}
		}

		/// <summary>Получает местное время создания события.</summary>
		/// <returns>Местное время создания события.</returns>
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00050830 File Offset: 0x0004EA30
		[MonitoringDescription("Generation time of this event entry.")]
		public DateTime TimeGenerated
		{
			get
			{
				return this.timeGenerated;
			}
		}

		/// <summary>Получает местное время записи события в журнал.</summary>
		/// <returns>Местное время записи события в журнал.</returns>
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00050838 File Offset: 0x0004EA38
		[MonitoringDescription("The time at which this event entry was written to the logfile.")]
		public DateTime TimeWritten
		{
			get
			{
				return this.timeWritten;
			}
		}

		/// <summary>Получает имя пользователя, который является инициатором этого события.</summary>
		/// <returns>Идентификатор безопасности (SID), однозначно определяющий пользователя или группу.</returns>
		/// <exception cref="T:System.SystemException">Не удалось извлечь сведения об учетной записи для идентификатора безопасности пользователя.</exception>
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00050840 File Offset: 0x0004EA40
		[MonitoringDescription("The name of a user associated with this event entry.")]
		public string UserName
		{
			get
			{
				return this.userName;
			}
		}

		/// <summary>Сравнивает две записи журнала событий.</summary>
		/// <param name="otherEntry">Сравниваемый шаблон <see cref="T:System.Diagnostics.EventLogEntry" />.</param>
		/// <returns>Значение <see langword="true" />, если объекты <see cref="T:System.Diagnostics.EventLogEntry" /> одинаковы; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060012D3 RID: 4819 RVA: 0x00050848 File Offset: 0x0004EA48
		public bool Equals(EventLogEntry otherEntry)
		{
			return otherEntry == this || (otherEntry.Category == this.category && otherEntry.CategoryNumber == this.categoryNumber && otherEntry.Data.Equals(this.data) && otherEntry.EntryType == this.entryType && otherEntry.InstanceId == this.instanceId && otherEntry.Index == this.index && otherEntry.MachineName == this.machineName && otherEntry.Message == this.message && otherEntry.ReplacementStrings.Equals(this.replacementStrings) && otherEntry.Source == this.source && otherEntry.TimeGenerated.Equals(this.timeGenerated) && otherEntry.TimeWritten.Equals(this.timeWritten) && otherEntry.UserName == this.userName);
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Конечный объект (см. <see cref="T:System.Runtime.Serialization.StreamingContext" />) для этой сериализации.</param>
		// Token: 0x060012D4 RID: 4820 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO("Needs serialization support")]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal EventLogEntry()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000AB6 RID: 2742
		private string category;

		// Token: 0x04000AB7 RID: 2743
		private short categoryNumber;

		// Token: 0x04000AB8 RID: 2744
		private byte[] data;

		// Token: 0x04000AB9 RID: 2745
		private EventLogEntryType entryType;

		// Token: 0x04000ABA RID: 2746
		private int eventID;

		// Token: 0x04000ABB RID: 2747
		private int index;

		// Token: 0x04000ABC RID: 2748
		private string machineName;

		// Token: 0x04000ABD RID: 2749
		private string message;

		// Token: 0x04000ABE RID: 2750
		private string[] replacementStrings;

		// Token: 0x04000ABF RID: 2751
		private string source;

		// Token: 0x04000AC0 RID: 2752
		private DateTime timeGenerated;

		// Token: 0x04000AC1 RID: 2753
		private DateTime timeWritten;

		// Token: 0x04000AC2 RID: 2754
		private string userName;

		// Token: 0x04000AC3 RID: 2755
		private long instanceId;
	}
}
