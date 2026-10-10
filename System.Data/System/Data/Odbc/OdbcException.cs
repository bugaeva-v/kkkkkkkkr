using System;
using System.Data.Common;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using Unity;

namespace System.Data.Odbc
{
	/// <summary>Исключение, которое генерируется в тех случаях, когда источником данных ODBC возвращается предупреждение или ошибка. Этот класс не наследуется.</summary>
	// Token: 0x020002E9 RID: 745
	[Serializable]
	public sealed class OdbcException : DbException
	{
		// Token: 0x0600210C RID: 8460 RVA: 0x0009A600 File Offset: 0x00098800
		internal static OdbcException CreateException(OdbcErrorCollection errors, ODBC32.RetCode retcode)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (object obj in errors)
			{
				OdbcError odbcError = (OdbcError)obj;
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				stringBuilder.Append(SR.GetString("{0} [{1}] {2}", new object[]
				{
					ODBC32.RetcodeToString(retcode),
					odbcError.SQLState,
					odbcError.Message
				}));
			}
			return new OdbcException(stringBuilder.ToString(), errors);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0009A6A8 File Offset: 0x000988A8
		internal OdbcException(string message, OdbcErrorCollection errors)
		{
			this._odbcErrors = new OdbcErrorCollection();
			base..ctor(message);
			this._odbcErrors = errors;
			base.HResult = -2146232009;
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0009A6CE File Offset: 0x000988CE
		private OdbcException(SerializationInfo si, StreamingContext sc)
		{
			this._odbcErrors = new OdbcErrorCollection();
			base..ctor(si, sc);
			this._odbcErrors = (OdbcErrorCollection)si.GetValue("odbcErrors", typeof(OdbcErrorCollection));
			base.HResult = -2146232009;
		}

		/// <summary>Получает коллекцию из одного или нескольких объектов <see cref="T:System.Data.Odbc.OdbcError" />, которые предоставляют подробные сведения об исключениях, выдаваемых поставщиком данных .NET Framework для ODBC.</summary>
		/// <returns>Накопленные экземпляры класса <see cref="T:System.Data.Odbc.OdbcError" />.</returns>
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x0009A70E File Offset: 0x0009890E
		public OdbcErrorCollection Errors
		{
			get
			{
				return this._odbcErrors;
			}
		}

		/// <summary>Этот элемент переопределяет метод <see cref="M:System.Exception.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" />.</summary>
		/// <param name="si">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Значением параметра <paramref name="si" /> является пустая ссылка (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06002110 RID: 8464 RVA: 0x0009A716 File Offset: 0x00098916
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo si, StreamingContext context)
		{
			base.GetObjectData(si, context);
			si.AddValue("odbcRetcode", ODBC32.RETCODE.SUCCESS, typeof(ODBC32.RETCODE));
			si.AddValue("odbcErrors", this._odbcErrors, typeof(OdbcErrorCollection));
		}

		/// <summary>Получает имя драйвера ODBC, который сгенерировал ошибку.</summary>
		/// <returns>Имя драйвера ODBC, который сгенерировал ошибку.</returns>
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x0009A758 File Offset: 0x00098958
		public override string Source
		{
			get
			{
				if (0 >= this.Errors.Count)
				{
					return "";
				}
				string source = this.Errors[0].Source;
				if (!string.IsNullOrEmpty(source))
				{
					return source;
				}
				return "";
			}
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal OdbcException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040017BB RID: 6075
		private OdbcErrorCollection _odbcErrors;
	}
}
