using System;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Представляет местозаполнитель (закладку) в потоке событий.
	///          Заполнитель можно использовать для пометки события и возвращения к данной позиции в потоке событий.
	///          Экземпляр этого объекта можно получить из <see cref="T:System.Diagnostics.Eventing.Reader.EventRecord" /> объекта, в этом случае он соответствует позиции записи этого события.
	///       </summary>
	// Token: 0x02000397 RID: 919
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class EventBookmark : ISerializable
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventBookmark" /> из указанных экземпляров <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///       </summary>
		/// <param name="info">
		///           Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> содержащий сведения, необходимые для сериализации нового <see cref="T:System.Diagnostics.Eventing.Reader.EventBookmark" /> объекта.
		///         </param>
		/// <param name="context">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" /> содержащий источник сериализованного потока, связанного с новым <see cref="T:System.Diagnostics.Eventing.Reader.EventBookmark" />.
		///         </param>
		// Token: 0x06001B6F RID: 7023 RVA: 0x0000235B File Offset: 0x0000055B
		protected EventBookmark(SerializationInfo info, StreamingContext context)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Заполняет <see cref="T:System.Runtime.Serialization.SerializationInfo" /> объект с данными, необходимыми для сериализации целевого объекта.
		///       </summary>
		/// <param name="info">
		///           Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который требуется заполнить данными.
		///         </param>
		/// <param name="context">
		///           Целевой объект этой сериализации.
		///         </param>
		// Token: 0x06001B70 RID: 7024 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.
		///       </summary>
		/// <param name="info">
		///           Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который требуется заполнить данными.
		///         </param>
		/// <param name="context">
		///           Целевой объект этой сериализации.
		///         </param>
		// Token: 0x06001B71 RID: 7025 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
