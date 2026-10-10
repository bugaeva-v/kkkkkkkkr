using System;
using System.Runtime.Serialization;

namespace System.Resources
{
	/// <summary>Исключение возникает при отсутствии вспомогательной сборки для ресурсов языка и региональных параметров по умолчанию.</summary>
	// Token: 0x0200085B RID: 2139
	[Serializable]
	public class MissingSatelliteAssemblyException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> стандартными свойствами.</summary>
		// Token: 0x0600473A RID: 18234 RVA: 0x000E80A0 File Offset: 0x000E62A0
		public MissingSatelliteAssemblyException() : base("Resource lookup fell back to the ultimate fallback resources in a satellite assembly, but that satellite either was not found or could not be loaded. Please consider reinstalling or repairing the application.")
		{
			base.HResult = -2146233034;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x0600473B RID: 18235 RVA: 0x000E80B8 File Offset: 0x000E62B8
		public MissingSatelliteAssemblyException(string message) : base(message)
		{
			base.HResult = -2146233034;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> с заданным сообщением об ошибке и именем нейтрального языка и региональных параметров.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="cultureName">Имя нейтрального языка и региональных параметров.</param>
		// Token: 0x0600473C RID: 18236 RVA: 0x000E80CC File Offset: 0x000E62CC
		public MissingSatelliteAssemblyException(string message, string cultureName) : base(message)
		{
			base.HResult = -2146233034;
			this._cultureName = cultureName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600473D RID: 18237 RVA: 0x000E80E7 File Offset: 0x000E62E7
		public MissingSatelliteAssemblyException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233034;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> из сериализованных данных.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении исключения.</param>
		// Token: 0x0600473E RID: 18238 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Получает имя языка и региональных параметров по умолчанию.</summary>
		/// <returns>Имя языка и региональных параметров по умолчанию.</returns>
		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x000E80FC File Offset: 0x000E62FC
		public string CultureName
		{
			get
			{
				return this._cultureName;
			}
		}

		// Token: 0x04002DA1 RID: 11681
		private string _cultureName;
	}
}
