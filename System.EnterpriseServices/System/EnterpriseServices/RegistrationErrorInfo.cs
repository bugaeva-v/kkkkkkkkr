using System;
using Unity;

namespace System.EnterpriseServices
{
	/// <summary>Извлекает расширенные сведения об ошибках для методов, связанных с несколькими объектами COM+. Учитываются также методы, устанавливающие, импортирующие и экспортирующие приложения и компоненты COM+. Этот класс не наследуется.</summary>
	// Token: 0x0200003B RID: 59
	[Serializable]
	public sealed class RegistrationErrorInfo
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002480 File Offset: 0x00000680
		[MonoTODO]
		internal RegistrationErrorInfo(string name, string majorRef, string minorRef, int errorCode)
		{
			this.name = name;
			this.majorRef = majorRef;
			this.minorRef = minorRef;
			this.errorCode = errorCode;
		}

		/// <summary>Возвращает код ошибки для объекта или файла.</summary>
		/// <returns>Код ошибки для объекта или файла.</returns>
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000024A5 File Offset: 0x000006A5
		public int ErrorCode
		{
			get
			{
				return this.errorCode;
			}
		}

		/// <summary>Возвращает описание свойства <see cref="P:System.EnterpriseServices.RegistrationErrorInfo.ErrorCode" />.</summary>
		/// <returns>Описание класса <see cref="P:System.EnterpriseServices.RegistrationErrorInfo.ErrorCode" />.</returns>
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000024AD File Offset: 0x000006AD
		public string ErrorString
		{
			get
			{
				return this.errorString;
			}
		}

		/// <summary>Возвращает значение ключа для объекта, вызвавшего ошибку (если это возможно).</summary>
		/// <returns>Значение ключа для объекта, вызвавшего ошибку (если это возможно).</returns>
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000024B5 File Offset: 0x000006B5
		public string MajorRef
		{
			get
			{
				return this.majorRef;
			}
		}

		/// <summary>Возвращает точную спецификацию элемента, вызвавшего ошибку, например, имя свойства.</summary>
		/// <returns>Точная спецификация элемента, вызвавшего ошибку, например, имя свойства. Если произошло несколько ошибок, или это неприменимо, <see cref="P:System.EnterpriseServices.RegistrationErrorInfo.MinorRef" /> возвращает строку "&lt;недопустимый&gt;«.</returns>
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000024BD File Offset: 0x000006BD
		public string MinorRef
		{
			get
			{
				return this.minorRef;
			}
		}

		/// <summary>Возвращает имя объекта или файла, вызвавшего ошибку.</summary>
		/// <returns>Имя объекта или файла, вызвавшего ошибку.</returns>
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000024C5 File Offset: 0x000006C5
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000024CD File Offset: 0x000006CD
		internal RegistrationErrorInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400007D RID: 125
		private int errorCode;

		// Token: 0x0400007E RID: 126
		private string errorString;

		// Token: 0x0400007F RID: 127
		private string majorRef;

		// Token: 0x04000080 RID: 128
		private string minorRef;

		// Token: 0x04000081 RID: 129
		private string name;
	}
}
