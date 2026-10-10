using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Исключение, создаваемое, когда привязка члена приводит к тому, что критерию связывания соответствуют несколько членов. Этот класс не наследуется.</summary>
	// Token: 0x0200087C RID: 2172
	[Serializable]
	public sealed class AmbiguousMatchException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AmbiguousMatchException" /> пустой строкой сообщения и корневым исключением-причиной, равным <see langword="null" />.</summary>
		// Token: 0x0600484A RID: 18506 RVA: 0x000EDFAC File Offset: 0x000EC1AC
		public AmbiguousMatchException() : base("Ambiguous match found.")
		{
			base.HResult = -2147475171;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AmbiguousMatchException" /> заданным сообщением в качестве строки сообщения и корневым исключением-причиной, равным <see langword="null" />.</summary>
		/// <param name="message">Строка, показывающая причину создания исключения.</param>
		// Token: 0x0600484B RID: 18507 RVA: 0x000EDFC4 File Offset: 0x000EC1C4
		public AmbiguousMatchException(string message) : base(message)
		{
			base.HResult = -2147475171;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AmbiguousMatchException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600484C RID: 18508 RVA: 0x000EDFD8 File Offset: 0x000EC1D8
		public AmbiguousMatchException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147475171;
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal AmbiguousMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
