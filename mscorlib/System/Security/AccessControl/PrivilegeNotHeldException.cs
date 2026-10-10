using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Security.AccessControl
{
	/// <summary>Исключение вызывается, когда метод в пространстве имен <see cref="N:System.Security.AccessControl" /> пытается использовать отсутствующую у него привилегию.</summary>
	// Token: 0x020004FE RID: 1278
	[Serializable]
	public sealed class PrivilegeNotHeldException : UnauthorizedAccessException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.PrivilegeNotHeldException" />.</summary>
		// Token: 0x06003335 RID: 13109 RVA: 0x000BC760 File Offset: 0x000BA960
		public PrivilegeNotHeldException() : base("The process does not possess some privilege required for this operation.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.PrivilegeNotHeldException" /> с использованием заданного права.</summary>
		/// <param name="privilege">Отсутствующее право.</param>
		// Token: 0x06003336 RID: 13110 RVA: 0x000BC76D File Offset: 0x000BA96D
		public PrivilegeNotHeldException(string privilege) : base(string.Format(CultureInfo.CurrentCulture, "The process does not possess the '{0}' privilege which is required for this operation.", privilege))
		{
			this._privilegeName = privilege;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.PrivilegeNotHeldException" /> с использованием указанного исключения.</summary>
		/// <param name="privilege">Отсутствующее право.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр innerException не является пустой ссылкой (<see langword="Nothing" /> в Visual Basic), текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06003337 RID: 13111 RVA: 0x000BC78C File Offset: 0x000BA98C
		public PrivilegeNotHeldException(string privilege, Exception inner) : base(string.Format(CultureInfo.CurrentCulture, "The process does not possess the '{0}' privilege which is required for this operation.", privilege), inner)
		{
			this._privilegeName = privilege;
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x000BC7AC File Offset: 0x000BA9AC
		private PrivilegeNotHeldException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._privilegeName = info.GetString("PrivilegeName");
		}

		/// <summary>Задает в параметре <paramref name="info" /> информацию об исключении.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06003339 RID: 13113 RVA: 0x000BC7C7 File Offset: 0x000BA9C7
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("PrivilegeName", this._privilegeName, typeof(string));
		}

		/// <summary>Получает имя отсутствующего права.</summary>
		/// <returns>Имя права, которым не удалось воспользоваться методу.</returns>
		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600333A RID: 13114 RVA: 0x000BC7EC File Offset: 0x000BA9EC
		public string PrivilegeName
		{
			get
			{
				return this._privilegeName;
			}
		}

		// Token: 0x040023F8 RID: 9208
		private readonly string _privilegeName;
	}
}
