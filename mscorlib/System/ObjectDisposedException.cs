using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, которое выбрасывается при выполнении операции над удаленным объектом.</summary>
	// Token: 0x02000168 RID: 360
	[Serializable]
	public class ObjectDisposedException : InvalidOperationException
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x0003AC51 File Offset: 0x00038E51
		private ObjectDisposedException() : this(null, "Cannot access a disposed object.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ObjectDisposedException" /> строкой, содержащей имя удаленного объекта.</summary>
		/// <param name="objectName">Строка, содержащая имя удаленного объекта.</param>
		// Token: 0x06000E59 RID: 3673 RVA: 0x0003AC5F File Offset: 0x00038E5F
		public ObjectDisposedException(string objectName) : this(objectName, "Cannot access a disposed object.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ObjectDisposedException" /> указанными именем объекта и сообщением.</summary>
		/// <param name="objectName">Имя удаленного объекта.</param>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06000E5A RID: 3674 RVA: 0x0003AC6D File Offset: 0x00038E6D
		public ObjectDisposedException(string objectName, string message) : base(message)
		{
			base.HResult = -2146232798;
			this._objectName = objectName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ObjectDisposedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значением параметра <paramref name="innerException" /> не является <see langword="null" />, текущее исключение выдается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000E5B RID: 3675 RVA: 0x0003AC88 File Offset: 0x00038E88
		public ObjectDisposedException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232798;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ObjectDisposedException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000E5C RID: 3676 RVA: 0x0003AC9D File Offset: 0x00038E9D
		protected ObjectDisposedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._objectName = info.GetString("ObjectName");
		}

		/// <summary>Извлекает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с именем параметра и дополнительной информацией об исключении.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000E5D RID: 3677 RVA: 0x0003ACB8 File Offset: 0x00038EB8
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ObjectName", this.ObjectName, typeof(string));
		}

		/// <summary>Возвращает сообщение с описанием ошибки.</summary>
		/// <returns>Строка с описанием ошибки.</returns>
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0003ACE0 File Offset: 0x00038EE0
		public override string Message
		{
			get
			{
				string objectName = this.ObjectName;
				if (objectName == null || objectName.Length == 0)
				{
					return base.Message;
				}
				string str = SR.Format("Object name: '{0}'.", objectName);
				return base.Message + Environment.NewLine + str;
			}
		}

		/// <summary>Возвращает имя удаленного объекта.</summary>
		/// <returns>Строка, содержащая имя удаленного объекта.</returns>
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0003AD23 File Offset: 0x00038F23
		public string ObjectName
		{
			get
			{
				if (this._objectName == null)
				{
					return string.Empty;
				}
				return this._objectName;
			}
		}

		// Token: 0x040012A4 RID: 4772
		private string _objectName;
	}
}
