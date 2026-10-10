using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IBindCtx" />.</summary>
	// Token: 0x0200079F RID: 1951
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000000e-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IBindCtx
	{
		/// <summary>Регистрирует переданный объект как один из объектов, привязка которых была выполнена во время операции моникера и которые необходимо освободить после завершения этой операции.</summary>
		/// <param name="punk">Объект для регистрации с целью освобождения.</param>
		// Token: 0x060044FB RID: 17659
		void RegisterObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);

		/// <summary>Удаляет все объекты из списка зарегистрированных объектов, нуждающихся в освобождении.</summary>
		/// <param name="punk">Объект для удаления регистрации с целью освобождения.</param>
		// Token: 0x060044FC RID: 17660
		void RevokeObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);

		/// <summary>Освобождает все объекты, зарегистрированные в текущий момент с контекстом привязки при помощи метода <see cref="M:System.Runtime.InteropServices.ComTypes.IBindCtx.RegisterObjectBound(System.Object)" />.</summary>
		// Token: 0x060044FD RID: 17661
		void ReleaseBoundObjects();

		/// <summary>Сохраняет блок параметров в контексте привязки. Эти параметры будут применены к последующим операциям <see langword="UCOMIMoniker" />, которые используют этот контекст привязки.</summary>
		/// <param name="pbindopts">Структура, содержащая задаваемые параметры привязки.</param>
		// Token: 0x060044FE RID: 17662
		void SetBindOptions([In] ref BIND_OPTS pbindopts);

		/// <summary>Возвращает параметры текущей привязки, хранящиеся в контексте этой привязки.</summary>
		/// <param name="pbindopts">Указатель на структуру для получения параметров привязки.</param>
		// Token: 0x060044FF RID: 17663
		void GetBindOptions(ref BIND_OPTS pbindopts);

		/// <summary>Возвращает доступ к таблице текущих объектов ROT, относящейся к этому процессу привязки.</summary>
		/// <param name="pprot">При возвращении данного метода содержит ссылку на таблицу текущих объектов (ROT). Этот параметр передается неинициализированным.</param>
		// Token: 0x06004500 RID: 17664
		void GetRunningObjectTable(out IRunningObjectTable pprot);

		/// <summary>Регистрирует заданный указатель для объекта под указанным именем в таблице внутреннего представления указателей объектов.</summary>
		/// <param name="pszKey">Имя, используемое для регистрации <paramref name="punk" />.</param>
		/// <param name="punk">Регистрируемый объект.</param>
		// Token: 0x06004501 RID: 17665
		void RegisterObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [MarshalAs(UnmanagedType.Interface)] object punk);

		/// <summary>Выполняет поиск заданного ключа таблицы внутреннего представления контекстных параметров объекта и возвращает соответствующий объект, если он существует.</summary>
		/// <param name="pszKey">Имя объекта, который нужно найти.</param>
		/// <param name="ppunk">При возвращении данного метода содержит указатель интерфейса объекта. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004502 RID: 17666
		void GetObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [MarshalAs(UnmanagedType.Interface)] out object ppunk);

		/// <summary>Перечисляет строки, являющиеся ключами таблицы внутреннего представления контекстных параметров объекта.</summary>
		/// <param name="ppenum">При возвращении данного метода содержит ссылку на перечислитель параметров объекта. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004503 RID: 17667
		void EnumObjectParam(out IEnumString ppenum);

		/// <summary>Отменяет регистрацию объекта, найденного в данный момент для заданного ключа во внутренней таблице контекстных параметров объекта, если такой ключ зарегистрирован.</summary>
		/// <param name="pszKey">Ключ, регистрацию которого необходимо удалить.</param>
		/// <returns>Значение <see langword="S_OK" /><see langword="HRESULT" />, если заданный ключ был успешно удален из таблицы; в противном случае — значение <see langword="S_FALSE" /><see langword="HRESULT" />.</returns>
		// Token: 0x06004504 RID: 17668
		[PreserveSig]
		int RevokeObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey);
	}
}
