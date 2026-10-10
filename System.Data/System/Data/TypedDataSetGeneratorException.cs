using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Data
{
	/// <summary>Это исключение создается в случае конфликта имен при создании объекта <see cref="T:System.Data.DataSet" /> со строгой типизацией.</summary>
	// Token: 0x02000155 RID: 341
	[Serializable]
	public class TypedDataSetGeneratorException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.TypedDataSetGeneratorException" />, используя заданную информацию сериализации и контекст потоков.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="context">Структура <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x06001218 RID: 4632 RVA: 0x0005563C File Offset: 0x0005383C
		protected TypedDataSetGeneratorException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			int num = (int)info.GetValue(this.KEY_ARRAYCOUNT, typeof(int));
			if (num > 0)
			{
				this.errorList = new ArrayList();
				for (int i = 0; i < num; i++)
				{
					this.errorList.Add(info.GetValue(this.KEY_ARRAYVALUES + i.ToString(), typeof(string)));
				}
				return;
			}
			this.errorList = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.TypedDataSetGeneratorException" />.</summary>
		// Token: 0x06001219 RID: 4633 RVA: 0x000556D4 File Offset: 0x000538D4
		public TypedDataSetGeneratorException()
		{
			this.errorList = null;
			base.HResult = -2146232021;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.TypedDataSetGeneratorException" /> с заданной строкой.</summary>
		/// <param name="message">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x0600121A RID: 4634 RVA: 0x00055704 File Offset: 0x00053904
		public TypedDataSetGeneratorException(string message) : base(message)
		{
			base.HResult = -2146232021;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.TypedDataSetGeneratorException" />, используя заданную строку и внутреннее исключение.</summary>
		/// <param name="message">Строка, отображаемая при возникновении исключения.</param>
		/// <param name="innerException">Ссылка на внутреннее исключение.</param>
		// Token: 0x0600121B RID: 4635 RVA: 0x0005572E File Offset: 0x0005392E
		public TypedDataSetGeneratorException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232021;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.TypedDataSetGeneratorException" />.</summary>
		/// <param name="list">Объект <see cref="T:System.Collections.ArrayList" />, содержащий динамический список исключений.</param>
		// Token: 0x0600121C RID: 4636 RVA: 0x00055759 File Offset: 0x00053959
		public TypedDataSetGeneratorException(ArrayList list) : this()
		{
			this.errorList = list;
			base.HResult = -2146232021;
		}

		/// <summary>Получает динамический список созданных ошибок.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x00055773 File Offset: 0x00053973
		public ArrayList ErrorList
		{
			get
			{
				return this.errorList;
			}
		}

		/// <summary>Реализует интерфейс <see langword="ISerializable" /> и возвращает данные, необходимые для сериализации объекта <see cref="T:System.Data.TypedDataSetGeneratorException" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="context">Структура <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x0600121E RID: 4638 RVA: 0x0005577C File Offset: 0x0005397C
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (this.errorList != null)
			{
				info.AddValue(this.KEY_ARRAYCOUNT, this.errorList.Count);
				for (int i = 0; i < this.errorList.Count; i++)
				{
					info.AddValue(this.KEY_ARRAYVALUES + i.ToString(), this.errorList[i].ToString());
				}
				return;
			}
			info.AddValue(this.KEY_ARRAYCOUNT, 0);
		}

		// Token: 0x04000B99 RID: 2969
		private ArrayList errorList;

		// Token: 0x04000B9A RID: 2970
		private string KEY_ARRAYCOUNT = "KEY_ARRAYCOUNT";

		// Token: 0x04000B9B RID: 2971
		private string KEY_ARRAYVALUES = "KEY_ARRAYVALUES";
	}
}
