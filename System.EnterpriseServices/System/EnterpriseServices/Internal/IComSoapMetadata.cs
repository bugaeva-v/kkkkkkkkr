using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Задает метод генерации метаданных среды CLR для компонента COM+.</summary>
	// Token: 0x02000061 RID: 97
	[Guid("d8013ff0-730b-45e2-ba24-874b7242c425")]
	public interface IComSoapMetadata
	{
		/// <summary>Генерирует сборку, содержащую метаданные среды CLR для компонента COM+, представленного указанной библиотекой типов.</summary>
		/// <param name="SrcTypeLibFileName">Имя библиотеки типов, для которой создается сборка.</param>
		/// <param name="OutPath">Папка, в которой генерируется сборка.</param>
		/// <returns>Имя сгенерированной сборки.</returns>
		// Token: 0x06000171 RID: 369
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string Generate([MarshalAs(UnmanagedType.BStr)] string SrcTypeLibFileName, [MarshalAs(UnmanagedType.BStr)] string OutPath);

		/// <summary>Генерирует сборку, содержащую метаданные среды CLR для компонента COM+, представленного указанной библиотекой типов, подписывает сборку парой ключей, образующих строгое имя, и устанавливает ее в глобальный кэш сборок.</summary>
		/// <param name="SrcTypeLibFileName">Имя библиотеки типов, для которой создается сборка.</param>
		/// <param name="OutPath">Папка, в которой генерируется сборка.</param>
		/// <param name="InstallGac">Флаг, показывающий, следует ли устанавливать сборку в глобальный кэш сборок.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		/// <returns>Имя сгенерированной сборки.</returns>
		// Token: 0x06000172 RID: 370
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GenerateSigned([MarshalAs(UnmanagedType.BStr)] string SrcTypeLibFileName, [MarshalAs(UnmanagedType.BStr)] string OutPath, [MarshalAs(UnmanagedType.Bool)] bool InstallGac, [MarshalAs(UnmanagedType.BStr)] out string Error);
	}
}
