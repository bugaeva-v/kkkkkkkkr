using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Исключение, которое выдается в том случае, если количество параметров для вызова не совпадает с ожидаемым. Этот класс не наследуется.</summary>
	// Token: 0x020008CC RID: 2252
	[Serializable]
	public sealed class TargetParameterCountException : ApplicationException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TargetParameterCountException" /> пустой строкой сообщения и корневой причиной исключения.</summary>
		// Token: 0x06004AEC RID: 19180 RVA: 0x000EFDCE File Offset: 0x000EDFCE
		public TargetParameterCountException() : base("Number of parameters specified does not match the expected number.")
		{
			base.HResult = -2147352562;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TargetParameterCountException" /> заданной строкой сообщения и корневой причиной исключения.</summary>
		/// <param name="message">Объект <see langword="String" />, содержащий описание причины выдачи исключения.</param>
		// Token: 0x06004AED RID: 19181 RVA: 0x000EFDE6 File Offset: 0x000EDFE6
		public TargetParameterCountException(string message) : base(message)
		{
			base.HResult = -2147352562;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TargetParameterCountException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004AEE RID: 19182 RVA: 0x000EFDFA File Offset: 0x000EDFFA
		public TargetParameterCountException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147352562;
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x0006E7BD File Offset: 0x0006C9BD
		internal TargetParameterCountException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
