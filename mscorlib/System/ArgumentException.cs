using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Это исключение выбрасывается, если один из передаваемых методу аргументов является недопустимым.</summary>
	// Token: 0x020000F3 RID: 243
	[Serializable]
	public class ArgumentException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentException" />.</summary>
		// Token: 0x060006FE RID: 1790 RVA: 0x00020FB1 File Offset: 0x0001F1B1
		public ArgumentException() : base("Value does not fall within the expected range.")
		{
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x060006FF RID: 1791 RVA: 0x00020FC9 File Offset: 0x0001F1C9
		public ArgumentException(string message) : base(message)
		{
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000700 RID: 1792 RVA: 0x00020FDD File Offset: 0x0001F1DD
		public ArgumentException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentException" /> с указанным сообщением об ошибке, именем параметра и ссылкой на внутреннее исключение, которое стало причиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="paramName">Имя параметра, вызвавшего текущее исключение.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000701 RID: 1793 RVA: 0x00020FF2 File Offset: 0x0001F1F2
		public ArgumentException(string message, string paramName, Exception innerException) : base(message, innerException)
		{
			this._paramName = paramName;
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentException" /> с указанным сообщением об ошибке и именем параметра, ставшего причиной этого исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="paramName">Имя параметра, вызвавшего текущее исключение.</param>
		// Token: 0x06000702 RID: 1794 RVA: 0x0002100E File Offset: 0x0001F20E
		public ArgumentException(string message, string paramName) : base(message)
		{
			this._paramName = paramName;
			base.HResult = -2147024809;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000703 RID: 1795 RVA: 0x00021029 File Offset: 0x0001F229
		protected ArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._paramName = info.GetString("ParamName");
		}

		/// <summary>Задает объекту <see cref="T:System.Runtime.Serialization.SerializationInfo" /> имя параметра и дополнительную информацию об исключении.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Объект <paramref name="info" /> является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06000704 RID: 1796 RVA: 0x00021044 File Offset: 0x0001F244
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ParamName", this._paramName, typeof(string));
		}

		/// <summary>Возвращает сообщение об ошибке и имя параметра или только сообщение об ошибке, если не задан ни один параметр.</summary>
		/// <returns>Текстовая строка с подробным описанием исключения. Значение этого свойства может принимать одну из следующих форм: 
		///   Условие 
		///   Значение 
		///   Параметр <paramref name="paramName" /> является указателем NULL (<see langword="Nothing" /> в Visual Basic) или имеет нулевую длину.  
		///   Строка <paramref name="message" />, переданная конструктору.  
		///   Параметр <paramref name="paramName" /> не является указателем NULL (<see langword="Nothing" /> в Visual Basic), а его длина большее нуля.  
		///   Строка <paramref name="message" />, дополненная именем недопустимого параметра.</returns>
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0002106C File Offset: 0x0001F26C
		public override string Message
		{
			get
			{
				string message = base.Message;
				if (!string.IsNullOrEmpty(this._paramName))
				{
					string str = SR.Format("Parameter name: {0}", this._paramName);
					return message + Environment.NewLine + str;
				}
				return message;
			}
		}

		/// <summary>Возвращает имя параметра, ставшего причиной этого исключения.</summary>
		/// <returns>Имя параметра.</returns>
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x000210AC File Offset: 0x0001F2AC
		public virtual string ParamName
		{
			get
			{
				return this._paramName;
			}
		}

		// Token: 0x04001048 RID: 4168
		private string _paramName;
	}
}
