using System;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Создает файл Web.config для приложения COM+ с включенным SOAP. Позволяет также добавлять записи компонентов в файл для COM-интерфейсов, публикуемых в приложении.</summary>
	// Token: 0x0200006A RID: 106
	public class ServerWebConfig : IServerWebConfig
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.ServerWebConfig" />.</summary>
		// Token: 0x0600019C RID: 412 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public ServerWebConfig()
		{
			throw new NotImplementedException();
		}

		/// <summary>Добавляет в файл Web.config XML-элементы для COM-интерфейса, публикуемого в приложении COM+ с включенным SOAP.</summary>
		/// <param name="FilePath">Путь к существующему файлу Web.config.</param>
		/// <param name="AssemblyName">Имя сборки, содержащей добавляемый тип.</param>
		/// <param name="TypeName">Имя добавляемого типа.</param>
		/// <param name="ProgId">Программный идентификатор добавляемого типа.</param>
		/// <param name="WkoMode">Строковая константа, которая соответствует имени члена перечисления <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> и показывает, как активируется известный объект.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		// Token: 0x0600019D RID: 413 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void AddElement(string FilePath, string AssemblyName, string TypeName, string ProgId, string WkoMode, out string Error)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает для приложения COM+ с включенным SOAP файл Web.config, готовый к добавлению в него XML-элементов для публикуемых COM-интерфейсов.</summary>
		/// <param name="FilePath">Папка, в которой должен быть создан файл конфигурации.</param>
		/// <param name="FilePrefix">Строковое значение "Web", к которому добавляется расширение config.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		// Token: 0x0600019E RID: 414 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void Create(string FilePath, string FilePrefix, out string Error)
		{
			throw new NotImplementedException();
		}
	}
}
