using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, которое выдается, если значение аргумента не соответствует допустимому диапазону значений, установленному вызванным методом.</summary>
	// Token: 0x020000F5 RID: 245
	[Serializable]
	public class ArgumentOutOfRangeException : ArgumentException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentOutOfRangeException" />.</summary>
		// Token: 0x0600070C RID: 1804 RVA: 0x00021119 File Offset: 0x0001F319
		public ArgumentOutOfRangeException() : base("Specified argument was out of the range of valid values.")
		{
			base.HResult = -2146233086;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentOutOfRangeException" /> именем параметра, вызвавшего исключение.</summary>
		/// <param name="paramName">Имя параметра, ставшего причиной этого исключения.</param>
		// Token: 0x0600070D RID: 1805 RVA: 0x00021131 File Offset: 0x0001F331
		public ArgumentOutOfRangeException(string paramName) : base("Specified argument was out of the range of valid values.", paramName)
		{
			base.HResult = -2146233086;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentOutOfRangeException" /> с именем параметра, ставшего причиной этого исключения, и указанным сообщением об ошибке.</summary>
		/// <param name="paramName">Имя параметра, вызвавшего данное исключение.</param>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x0600070E RID: 1806 RVA: 0x0002114A File Offset: 0x0001F34A
		public ArgumentOutOfRangeException(string paramName, string message) : base(message, paramName)
		{
			base.HResult = -2146233086;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentOutOfRangeException" /> с заданным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x0600070F RID: 1807 RVA: 0x0002115F File Offset: 0x0001F35F
		public ArgumentOutOfRangeException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233086;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentOutOfRangeException" /> с именем параметра, значением аргумента и указанным сообщением об ошибке.</summary>
		/// <param name="paramName">Имя параметра, вызвавшего данное исключение.</param>
		/// <param name="actualValue">Значение аргумента, вызвавшего данное исключение.</param>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000710 RID: 1808 RVA: 0x00021174 File Offset: 0x0001F374
		public ArgumentOutOfRangeException(string paramName, object actualValue, string message) : base(message, paramName)
		{
			this._actualValue = actualValue;
			base.HResult = -2146233086;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentOutOfRangeException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Объект, описывающий источник или цель сериализованных данных.</param>
		// Token: 0x06000711 RID: 1809 RVA: 0x00021190 File Offset: 0x0001F390
		protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._actualValue = info.GetValue("ActualValue", typeof(object));
		}

		/// <summary>Задает в объекте <see cref="T:System.Runtime.Serialization.SerializationInfo" /> недопустимое значение аргумента и дополнительные сведения об исключении.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Объект, описывающий источник или цель сериализованных данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Объект <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000712 RID: 1810 RVA: 0x000211B5 File Offset: 0x0001F3B5
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ActualValue", this._actualValue, typeof(object));
		}

		/// <summary>Возвращает сообщение об ошибке и строковое представление недопустимого значения аргумента или только сообщение об ошибке, если значение аргумента равно null.</summary>
		/// <returns>Текстовое сообщение для этого исключения. Значение этого свойства принимает одну из двух следующих форм:  
		///   Условие 
		///   Значение 
		///   Значение параметра <paramref name="actualValue" /> — <see langword="null" />.  
		///
		///   Строка <paramref name="message" />, переданная конструктору.  
		///
		///   Свойство <paramref name="actualValue" /> не является методом <see langword="null" />.  
		///
		///   Строка <paramref name="message" />, дополненная строковым представлением недопустимого значения аргумента.</returns>
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x000211DC File Offset: 0x0001F3DC
		public override string Message
		{
			get
			{
				string message = base.Message;
				if (this._actualValue == null)
				{
					return message;
				}
				string text = SR.Format("Actual value was {0}.", this._actualValue.ToString());
				if (message == null)
				{
					return text;
				}
				return message + Environment.NewLine + text;
			}
		}

		/// <summary>Возвращает значение аргумента, вызвавшего это исключение.</summary>
		/// <returns>Объект <see langword="Object" />, содержащий значение параметра, вызвавшего текущее исключение <see cref="T:System.Exception" />.</returns>
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00021221 File Offset: 0x0001F421
		public virtual object ActualValue
		{
			get
			{
				return this._actualValue;
			}
		}

		// Token: 0x04001049 RID: 4169
		private object _actualValue;
	}
}
