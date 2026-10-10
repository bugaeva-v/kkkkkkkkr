using System;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Drawing.Printing
{
	/// <summary>Представляет исключение, возникающее при попытке доступа к принтеру с использованием недопустимых параметров.</summary>
	// Token: 0x020000B8 RID: 184
	[Serializable]
	public class InvalidPrinterException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.InvalidPrinterException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Имя класса — <see langword="null" /> или <see cref="P:System.Exception.HResult" /> равно 0.</exception>
		// Token: 0x06000A6E RID: 2670 RVA: 0x00017CEF File Offset: 0x00015EEF
		protected InvalidPrinterException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._settings = (PrinterSettings)info.GetValue("settings", typeof(PrinterSettings));
		}

		/// <summary>Переопределенный. Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> сведениями об исключении.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000A6F RID: 2671 RVA: 0x00017D19 File Offset: 0x00015F19
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("settings", this._settings);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.InvalidPrinterException" />.</summary>
		/// <param name="settings">Объект <see cref="T:System.Drawing.Printing.PrinterSettings" />, задающий параметры принтера.</param>
		// Token: 0x06000A70 RID: 2672 RVA: 0x00017D34 File Offset: 0x00015F34
		public InvalidPrinterException(PrinterSettings settings) : base(InvalidPrinterException.GenerateMessage(settings))
		{
			this._settings = settings;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00017D4C File Offset: 0x00015F4C
		private static string GenerateMessage(PrinterSettings settings)
		{
			if (settings.IsDefaultPrinter)
			{
				return SR.Format("No printers are installed.", Array.Empty<object>());
			}
			string result;
			try
			{
				result = SR.Format("Settings to access printer '{0}' are not valid.", new object[]
				{
					settings.PrinterName
				});
			}
			catch (SecurityException)
			{
				result = SR.Format("Settings to access printer '{0}' are not valid.", new object[]
				{
					SR.Format("(printer name protected due to security restrictions)", Array.Empty<object>())
				});
			}
			return result;
		}

		// Token: 0x04000662 RID: 1634
		private PrinterSettings _settings;
	}
}
