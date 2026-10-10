using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Исключение, создаваемое при возникновении ошибки во время использования сетевого протокола.</summary>
	// Token: 0x02000600 RID: 1536
	[Serializable]
	public class ProtocolViolationException : InvalidOperationException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.ProtocolViolationException" />.</summary>
		// Token: 0x06003092 RID: 12434 RVA: 0x000A7186 File Offset: 0x000A5386
		public ProtocolViolationException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.ProtocolViolationException" /> указанным сообщением.</summary>
		/// <param name="message">Строка сообщения об ошибке.</param>
		// Token: 0x06003093 RID: 12435 RVA: 0x000A718E File Offset: 0x000A538E
		public ProtocolViolationException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.ProtocolViolationException" /> из указанных экземпляров <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для десериализации класса <see cref="T:System.Net.ProtocolViolationException" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, который содержит источник сериализованного потока, связанного с новым объектом <see cref="T:System.Net.ProtocolViolationException" />.</param>
		// Token: 0x06003094 RID: 12436 RVA: 0x000A7197 File Offset: 0x000A5397
		protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Сериализует этот экземпляр в указанный объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="serializationInfo">Объект, в который будет сериализован этот экземпляр <see cref="T:System.Net.ProtocolViolationException" />.</param>
		/// <param name="streamingContext">Назначение сериализации.</param>
		// Token: 0x06003095 RID: 12437 RVA: 0x0002975A File Offset: 0x0002795A
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x06003096 RID: 12438 RVA: 0x0002975A File Offset: 0x0002795A
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
}
