using System;
using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Базовый класс исключений для <see cref="N:System.Data.SqlTypes" />.</summary>
	// Token: 0x0200031A RID: 794
	[Serializable]
	public class SqlTypeException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlTypeException" />.</summary>
		// Token: 0x060025D9 RID: 9689 RVA: 0x000A953B File Offset: 0x000A773B
		public SqlTypeException() : this("SqlType error.", null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlTypeException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x060025DA RID: 9690 RVA: 0x000A9549 File Offset: 0x000A7749
		public SqlTypeException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlTypeException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="e">Исключение, которое является причиной текущего исключения. Если значение параметра innerException не равно <see langword="null" />, текущее исключение возникает в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060025DB RID: 9691 RVA: 0x000A9553 File Offset: 0x000A7753
		public SqlTypeException(string message, Exception e) : base(message, e)
		{
			base.HResult = -2146232016;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlTypeException" /> с сериализованными данными.</summary>
		/// <param name="si">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="sc">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060025DC RID: 9692 RVA: 0x000A9568 File Offset: 0x000A7768
		protected SqlTypeException(SerializationInfo si, StreamingContext sc) : base(SqlTypeException.SqlTypeExceptionSerialization(si, sc), sc)
		{
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x000A9578 File Offset: 0x000A7778
		private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			if (si != null && 1 == si.MemberCount)
			{
				new SqlTypeException(si.GetString("SqlTypeExceptionMessage")).GetObjectData(si, sc);
			}
			return si;
		}
	}
}
