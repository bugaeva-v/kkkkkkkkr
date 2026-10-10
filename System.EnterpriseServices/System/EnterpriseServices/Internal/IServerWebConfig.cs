using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Создает файл Web.config для приложения COM+ с включенным SOAP и добавляет в файл записи компонентов для COM-интерфейсов, публикуемых в приложении.</summary>
	// Token: 0x02000064 RID: 100
	[Guid("6261e4b5-572a-4142-a2f9-1fe1a0c97097")]
	public interface IServerWebConfig
	{
		/// <summary>Добавляет в файл Web.config XML-элементы для COM-интерфейса, публикуемого в приложении COM+ с включенным SOAP.</summary>
		/// <param name="FilePath">Путь к существующему файлу Web.config.</param>
		/// <param name="AssemblyName">Имя сборки, содержащей добавляемый тип.</param>
		/// <param name="TypeName">Имя добавляемого типа.</param>
		/// <param name="ProgId">Программный идентификатор добавляемого типа.</param>
		/// <param name="Mode">Строковая константа, которая соответствует имени члена перечисления <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> и показывает, как активируется известный объект.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		// Token: 0x06000182 RID: 386
		[DispId(1)]
		void AddElement([MarshalAs(UnmanagedType.BStr)] string FilePath, [MarshalAs(UnmanagedType.BStr)] string AssemblyName, [MarshalAs(UnmanagedType.BStr)] string TypeName, [MarshalAs(UnmanagedType.BStr)] string ProgId, [MarshalAs(UnmanagedType.BStr)] string Mode, [MarshalAs(UnmanagedType.BStr)] out string Error);

		/// <summary>Создает для приложения COM+ с включенным SOAP файл Web.config, готовый к добавлению в него XML-элементов для публикуемых COM-интерфейсов.</summary>
		/// <param name="FilePath">Папка, в которой создается файл конфигурации.</param>
		/// <param name="FileRootName">Строковое значение, к которому может быть добавлено расширение config (например, Web для Web.config).</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		// Token: 0x06000183 RID: 387
		[DispId(2)]
		void Create([MarshalAs(UnmanagedType.BStr)] string FilePath, [MarshalAs(UnmanagedType.BStr)] string FileRootName, [MarshalAs(UnmanagedType.BStr)] out string Error);
	}
}
