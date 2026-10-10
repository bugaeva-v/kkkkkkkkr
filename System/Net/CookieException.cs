using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Исключение, возникающее, когда происходит ошибка при добавлении <see cref="T:System.Net.Cookie" /> к <see cref="T:System.Net.CookieContainer" />.</summary>
	// Token: 0x02000656 RID: 1622
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.CookieException" />.</summary>
		// Token: 0x06003318 RID: 13080 RVA: 0x00029735 File Offset: 0x00027935
		public CookieException()
		{
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x0002973D File Offset: 0x0002793D
		internal CookieException(string message) : base(message)
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x00029746 File Offset: 0x00027946
		internal CookieException(string message, Exception inner) : base(message, inner)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.CookieException" /> с определенными значениями <paramref name="serializationInfo" /> и <paramref name="streamingContext" />.</summary>
		/// <param name="serializationInfo">Используемые данные о сериализации <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="streamingContext">Используемые данные о сериализации <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x0600331B RID: 13083 RVA: 0x00029750 File Offset: 0x00027950
		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации экземпляра <see cref="T:System.Net.CookieException" />.</summary>
		/// <param name="serializationInfo">Используемые данные о сериализации <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="streamingContext">Используемые данные о сериализации <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x0600331C RID: 13084 RVA: 0x0002975A File Offset: 0x0002795A
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации экземпляра <see cref="T:System.Net.CookieException" />.</summary>
		/// <param name="serializationInfo">Объект, содержащий сериализованные данные объекта. Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекстные сведения об источнике или назначении. Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x0600331D RID: 13085 RVA: 0x0002975A File Offset: 0x0002795A
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
}
