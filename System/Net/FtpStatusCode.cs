using System;

namespace System.Net
{
	/// <summary>Указывает коды состояния, возвращаемые для FTP-операции.</summary>
	// Token: 0x020005CC RID: 1484
	public enum FtpStatusCode
	{
		/// <summary>Включен для полноценного списка. Это значение никогда не возвращается серверами.</summary>
		// Token: 0x04001A78 RID: 6776
		Undefined,
		/// <summary>Указывает, что ответ содержит ответ маркера перезапуска. Текст описания, сопутствующего этому состоянию, содержит маркер потока данных пользователя и маркер сервера.</summary>
		// Token: 0x04001A79 RID: 6777
		RestartMarker = 110,
		/// <summary>Указывает, что служба в настоящий момент недоступна; повторите попытку позже.</summary>
		// Token: 0x04001A7A RID: 6778
		ServiceTemporarilyNotAvailable = 120,
		/// <summary>Указывает, что подключение к данным уже открыто и запрошенная передача уже началась.</summary>
		// Token: 0x04001A7B RID: 6779
		DataAlreadyOpen = 125,
		/// <summary>Указывает, что сервер открывает подключение к данным.</summary>
		// Token: 0x04001A7C RID: 6780
		OpeningData = 150,
		/// <summary>Указывает, что команда была завершена успешно.</summary>
		// Token: 0x04001A7D RID: 6781
		CommandOK = 200,
		/// <summary>Указывает, что команда не реализована на сервере, так как в ней нет потребности.</summary>
		// Token: 0x04001A7E RID: 6782
		CommandExtraneous = 202,
		/// <summary>Указывает состояние каталога.</summary>
		// Token: 0x04001A7F RID: 6783
		DirectoryStatus = 212,
		/// <summary>Указывает состояние файла.</summary>
		// Token: 0x04001A80 RID: 6784
		FileStatus,
		/// <summary>Указывает имя типа системы с использованием системных имен, опубликованных в документе, посвященном назначенным номерам, изданном IANA (Internet Assigned Numbers Authority).</summary>
		// Token: 0x04001A81 RID: 6785
		SystemType = 215,
		/// <summary>Указывает, что сервер готов к операции входа пользователя.</summary>
		// Token: 0x04001A82 RID: 6786
		SendUserCommand = 220,
		/// <summary>Указывает, что сервер закрывает управляющее подключение.</summary>
		// Token: 0x04001A83 RID: 6787
		ClosingControl,
		/// <summary>Указывает, что сервер закрывает подключение к данным и что запрошенное действие с файлом завершилось успешно.</summary>
		// Token: 0x04001A84 RID: 6788
		ClosingData = 226,
		/// <summary>Указывает на то, что сервер переходит в пассивный режим.</summary>
		// Token: 0x04001A85 RID: 6789
		EnteringPassive,
		/// <summary>Указывает, что пользователь вошел в систему и может отправлять команды.</summary>
		// Token: 0x04001A86 RID: 6790
		LoggedInProceed = 230,
		/// <summary>Указывает, что сервер принимает механизм проверки пользователи, указанный клиентом, и обмен данными безопасности завершен.</summary>
		// Token: 0x04001A87 RID: 6791
		ServerWantsSecureSession = 234,
		/// <summary>Указывает, что запрошенное действие с файлом завершено успешно.</summary>
		// Token: 0x04001A88 RID: 6792
		FileActionOK = 250,
		/// <summary>Указывает, что было создано запрошенное имя пути.</summary>
		// Token: 0x04001A89 RID: 6793
		PathnameCreated = 257,
		/// <summary>Указывает, что сервер ожидает предоставления пароля.</summary>
		// Token: 0x04001A8A RID: 6794
		SendPasswordCommand = 331,
		/// <summary>Указывает, что сервер требует предоставления учетной записи для входа.</summary>
		// Token: 0x04001A8B RID: 6795
		NeedLoginAccount,
		/// <summary>Указывает, что для выполнения запрошенного действия с файлом требуются дополнительные сведения.</summary>
		// Token: 0x04001A8C RID: 6796
		FileCommandPending = 350,
		/// <summary>Указывает, что служба недоступна.</summary>
		// Token: 0x04001A8D RID: 6797
		ServiceNotAvailable = 421,
		/// <summary>Указывает, что подключение к данным не может быть открыто.</summary>
		// Token: 0x04001A8E RID: 6798
		CantOpenData = 425,
		/// <summary>Указывает, что подключение было закрыто.</summary>
		// Token: 0x04001A8F RID: 6799
		ConnectionClosed,
		/// <summary>Указывает, что запрошенное действие не может быть выполнено с указанным файлом, потому что файл недоступен или используется.</summary>
		// Token: 0x04001A90 RID: 6800
		ActionNotTakenFileUnavailableOrBusy = 450,
		/// <summary>Указывает, что произошла ошибка, препятствующая завершению запрошенной операции.</summary>
		// Token: 0x04001A91 RID: 6801
		ActionAbortedLocalProcessingError,
		/// <summary>Указывает, что запрошенное действие не может быть выполнено, потому что на сервере недостаточно свободного пространства.</summary>
		// Token: 0x04001A92 RID: 6802
		ActionNotTakenInsufficientSpace,
		/// <summary>Указывает, что команда содержит синтаксическую ошибку или не является командой, распознаваемой сервером.</summary>
		// Token: 0x04001A93 RID: 6803
		CommandSyntaxError = 500,
		/// <summary>Указывает, что один или несколько аргументов команды содержат синтаксическую ошибку.</summary>
		// Token: 0x04001A94 RID: 6804
		ArgumentSyntaxError,
		/// <summary>Указывает, что команда не реализована на FTP-сервере.</summary>
		// Token: 0x04001A95 RID: 6805
		CommandNotImplemented,
		/// <summary>Указывает, что последовательность команд находится в неправильном порядке.</summary>
		// Token: 0x04001A96 RID: 6806
		BadCommandSequence,
		/// <summary>Указывает, что сведения для входа на сервер должны быть предоставлены серверу.</summary>
		// Token: 0x04001A97 RID: 6807
		NotLoggedIn = 530,
		/// <summary>Указывает, что сервер требует предоставления учетной записи пользователя.</summary>
		// Token: 0x04001A98 RID: 6808
		AccountNeeded = 532,
		/// <summary>Указывает, что запрошенное действие не может быть выполнено с указанным файлом, потому что файл недоступен.</summary>
		// Token: 0x04001A99 RID: 6809
		ActionNotTakenFileUnavailable = 550,
		/// <summary>Указывает, что запрошенное действие не может быть выполнено, потому что неизвестен указанный тип страницы. Типы страниц описаны в разделе 3.1.2.3 документа RFC 959</summary>
		// Token: 0x04001A9A RID: 6810
		ActionAbortedUnknownPageType,
		/// <summary>Указывает, что запрошенное действие выполнить невозможно.</summary>
		// Token: 0x04001A9B RID: 6811
		FileActionAborted,
		/// <summary>Указывает, что запрошенное действие не может быть выполнено с указанным файлом.</summary>
		// Token: 0x04001A9C RID: 6812
		ActionNotTakenFilenameNotAllowed
	}
}
