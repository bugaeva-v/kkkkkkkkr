using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, которое выбрасывается, когда значение с плавающей запятой является плюс бесконечностью, минус бесконечностью или не является числовым (NaN).</summary>
	// Token: 0x0200015F RID: 351
	[Serializable]
	public class NotFiniteNumberException : ArithmeticException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotFiniteNumberException" />.</summary>
		// Token: 0x06000DD3 RID: 3539 RVA: 0x00035E7D File Offset: 0x0003407D
		public NotFiniteNumberException() : base("Arg_NotFiniteNumberException = Number encountered was not a finite quantity.")
		{
			this._offendingNumber = 0.0;
			base.HResult = -2146233048;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotFiniteNumberException" /> недопустимым числом.</summary>
		/// <param name="offendingNumber">Значение аргумента, вызвавшего исключение.</param>
		// Token: 0x06000DD4 RID: 3540 RVA: 0x00035EA4 File Offset: 0x000340A4
		public NotFiniteNumberException(double offendingNumber)
		{
			this._offendingNumber = offendingNumber;
			base.HResult = -2146233048;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotFiniteNumberException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000DD5 RID: 3541 RVA: 0x00035EBE File Offset: 0x000340BE
		public NotFiniteNumberException(string message) : base(message)
		{
			this._offendingNumber = 0.0;
			base.HResult = -2146233048;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotFiniteNumberException" /> указанным сообщением об ошибке и недопустимым числом.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		/// <param name="offendingNumber">Значение аргумента, вызвавшего исключение.</param>
		// Token: 0x06000DD6 RID: 3542 RVA: 0x00035EE1 File Offset: 0x000340E1
		public NotFiniteNumberException(string message, double offendingNumber) : base(message)
		{
			this._offendingNumber = offendingNumber;
			base.HResult = -2146233048;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotFiniteNumberException" />, используя указанное сообщение об ошибке и ссылку на внутреннее исключение, которое стало исходной причиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00035EFC File Offset: 0x000340FC
		public NotFiniteNumberException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233048;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotFiniteNumberException" /> указанным сообщением об ошибке, недопустимым числом и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="offendingNumber">Значение аргумента, вызвавшего исключение.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000DD8 RID: 3544 RVA: 0x00035F11 File Offset: 0x00034111
		public NotFiniteNumberException(string message, double offendingNumber, Exception innerException) : base(message, innerException)
		{
			this._offendingNumber = offendingNumber;
			base.HResult = -2146233048;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotFiniteNumberException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000DD9 RID: 3545 RVA: 0x00035F2D File Offset: 0x0003412D
		protected NotFiniteNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._offendingNumber = (double)info.GetInt32("OffendingNumber");
		}

		/// <summary>Задает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с недопустимым числом и дополнительной информацией исключения.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Объект <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000DDA RID: 3546 RVA: 0x00035F49 File Offset: 0x00034149
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("OffendingNumber", this._offendingNumber, typeof(int));
		}

		/// <summary>Возвращает недопустимое число, которое является плюс бесконечностью, минус бесконечностью или не является числовым (NaN).</summary>
		/// <returns>Недопустимое число.</returns>
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00035F73 File Offset: 0x00034173
		public double OffendingNumber
		{
			get
			{
				return this._offendingNumber;
			}
		}

		// Token: 0x04001284 RID: 4740
		private double _offendingNumber;
	}
}
