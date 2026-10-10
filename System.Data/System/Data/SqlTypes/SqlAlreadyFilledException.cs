using System;
using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.SqlAlreadyFilledException" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200031E RID: 798
	[Serializable]
	public sealed class SqlAlreadyFilledException : SqlTypeException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlAlreadyFilledException" />.</summary>
		// Token: 0x060025EC RID: 9708 RVA: 0x000A9686 File Offset: 0x000A7886
		public SqlAlreadyFilledException() : this(SQLResource.AlreadyFilledMessage, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlAlreadyFilledException" />.</summary>
		/// <param name="message">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060025ED RID: 9709 RVA: 0x000A9694 File Offset: 0x000A7894
		public SqlAlreadyFilledException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlAlreadyFilledException" />.</summary>
		/// <param name="message">Строка, отображаемая при возникновении исключения.</param>
		/// <param name="e">Ссылка на внутреннее исключение.</param>
		// Token: 0x060025EE RID: 9710 RVA: 0x000A95B6 File Offset: 0x000A77B6
		public SqlAlreadyFilledException(string message, Exception e) : base(message, e)
		{
			base.HResult = -2146232015;
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000A967C File Offset: 0x000A787C
		private SqlAlreadyFilledException(SerializationInfo si, StreamingContext sc) : base(si, sc)
		{
		}
	}
}
