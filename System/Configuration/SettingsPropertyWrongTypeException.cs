using System;
using System.Runtime.Serialization;

namespace System.Configuration
{
	/// <summary>Предоставляет исключение, возникающее, когда недопустимый тип используется с объектом <see cref="T:System.Configuration.SettingsProperty" />.</summary>
	// Token: 0x020001D2 RID: 466
	[Serializable]
	public class SettingsPropertyWrongTypeException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyWrongTypeException" />.</summary>
		// Token: 0x06000C43 RID: 3139 RVA: 0x0000DC12 File Offset: 0x0000BE12
		public SettingsPropertyWrongTypeException()
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Configuration.SettingsPropertyWrongTypeException" /> согласно указанному параметру.</summary>
		/// <param name="message">Строка, содержащая сообщение об исключении.</param>
		// Token: 0x06000C44 RID: 3140 RVA: 0x0000DC2F File Offset: 0x0000BE2F
		public SettingsPropertyWrongTypeException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyWrongTypeException" /> на основе предоставленных параметров.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении сериализованного потока.</param>
		// Token: 0x06000C45 RID: 3141 RVA: 0x0002C42D File Offset: 0x0002A62D
		protected SettingsPropertyWrongTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyWrongTypeException" /> на основе предоставленных параметров.</summary>
		/// <param name="message">Строка, содержащая сообщение об исключении.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x06000C46 RID: 3142 RVA: 0x000320E8 File Offset: 0x000302E8
		public SettingsPropertyWrongTypeException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
