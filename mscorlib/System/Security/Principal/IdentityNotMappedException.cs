using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Principal
{
	/// <summary>Представляет исключение для участника, удостоверение которого не может быть сопоставлено с известным удостоверением.</summary>
	// Token: 0x020004E3 RID: 1251
	[ComVisible(false)]
	[Serializable]
	public sealed class IdentityNotMappedException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.IdentityNotMappedException" />.</summary>
		// Token: 0x060031ED RID: 12781 RVA: 0x000B7B83 File Offset: 0x000B5D83
		public IdentityNotMappedException() : base(Locale.GetText("Couldn't translate some identities."))
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Principal.IdentityNotMappedException" /> с помощью заданного сообщения об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x060031EE RID: 12782 RVA: 0x0006E6A5 File Offset: 0x0006C8A5
		public IdentityNotMappedException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.IdentityNotMappedException" />, используя указанное сообщение об ошибке и внутреннее исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно NULL, текущее исключение вызывается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060031EF RID: 12783 RVA: 0x0006E6AE File Offset: 0x0006C8AE
		public IdentityNotMappedException(string message, Exception inner) : base(message, inner)
		{
		}

		/// <summary>Представляет коллекцию несопоставленных удостоверений для исключения <see cref="T:System.Security.Principal.IdentityNotMappedException" />.</summary>
		/// <returns>Коллекция несопоставленных удостоверений.</returns>
		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x000B7B95 File Offset: 0x000B5D95
		public IdentityReferenceCollection UnmappedIdentities
		{
			get
			{
				if (this._coll == null)
				{
					this._coll = new IdentityReferenceCollection();
				}
				return this._coll;
			}
		}

		/// <summary>Возвращает сведения сериализации с данными, необходимыми для создания экземпляра этого объекта <see cref="T:System.Security.Principal.IdentityNotMappedException" />.</summary>
		/// <param name="serializationInfo">Объект, содержащий сериализованные данные объекта о возникающем исключении.</param>
		/// <param name="streamingContext">Объект, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060031F1 RID: 12785 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[SecurityCritical]
		[MonoTODO("not implemented")]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x040022BF RID: 8895
		private IdentityReferenceCollection _coll;
	}
}
