using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, которое выбрасывается как оболочка для исключения, выброшенного инициализатором класса. Этот класс не наследуется.</summary>
	// Token: 0x020001A4 RID: 420
	[Serializable]
	public sealed class TypeInitializationException : SystemException
	{
		// Token: 0x060011E9 RID: 4585 RVA: 0x00047C80 File Offset: 0x00045E80
		private TypeInitializationException() : base("Type constructor threw an exception.")
		{
			base.HResult = -2146233036;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeInitializationException" /> используемым по умолчанию сообщением об ошибке, указанным именем типа и ссылкой на внутреннее исключение, которое является основной причиной возникновения данного исключения.</summary>
		/// <param name="fullTypeName">Полное имя типа, который не удалось инициализировать.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060011EA RID: 4586 RVA: 0x00047C98 File Offset: 0x00045E98
		public TypeInitializationException(string fullTypeName, Exception innerException) : this(fullTypeName, SR.Format("The type initializer for '{0}' threw an exception.", fullTypeName), innerException)
		{
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00047CAD File Offset: 0x00045EAD
		internal TypeInitializationException(string message) : base(message)
		{
			base.HResult = -2146233036;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00047CC1 File Offset: 0x00045EC1
		internal TypeInitializationException(string fullTypeName, string message, Exception innerException) : base(message, innerException)
		{
			this._typeName = fullTypeName;
			base.HResult = -2146233036;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00047CDD File Offset: 0x00045EDD
		internal TypeInitializationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._typeName = info.GetString("TypeName");
		}

		/// <summary>Задает имя типа и дополнительные сведения об исключении для объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060011EE RID: 4590 RVA: 0x00047CF8 File Offset: 0x00045EF8
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("TypeName", this.TypeName, typeof(string));
		}

		/// <summary>Возвращает полное имя типа, который не удалось инициализировать.</summary>
		/// <returns>Полное имя типа, который не удалось инициализировать.</returns>
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00047D1D File Offset: 0x00045F1D
		public string TypeName
		{
			get
			{
				if (this._typeName == null)
				{
					return string.Empty;
				}
				return this._typeName;
			}
		}

		// Token: 0x0400135A RID: 4954
		private string _typeName;
	}
}
