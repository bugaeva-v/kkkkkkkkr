using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.BIND_OPTS" />.</summary>
	// Token: 0x02000755 RID: 1877
	[Obsolete]
	[Guid("0000000e-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMIBindCtx
	{
		/// <summary>Регистрирует переданный объект как один из объектов, привязка которых была выполнена в процессе работы моникера и которые необходимо освободить после завершения этой работы.</summary>
		/// <param name="punk">Объект для регистрации с целью освобождения.</param>
		// Token: 0x06004249 RID: 16969
		void RegisterObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);

		/// <summary>Удаляет все объекты из списка зарегистрированных объектов, нуждающихся в освобождении.</summary>
		/// <param name="punk">Объект для удаления регистрации с целью освобождения.</param>
		// Token: 0x0600424A RID: 16970
		void RevokeObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);

		/// <summary>Освобождает все объекты, зарегистрированные в текущий момент с контекстом привязки при помощи <see cref="M:System.Runtime.InteropServices.UCOMIBindCtx.RegisterObjectBound(System.Object)" />.</summary>
		// Token: 0x0600424B RID: 16971
		void ReleaseBoundObjects();

		/// <summary>Сохраняет в контексте привязки блок параметров, применяющийся к более поздним операциям <see langword="UCOMIMoniker" />, использующих этот контекст привязки.</summary>
		/// <param name="pbindopts">Структура, содержащая задаваемые параметры привязки.</param>
		// Token: 0x0600424C RID: 16972
		void SetBindOptions([In] ref BIND_OPTS pbindopts);

		/// <summary>Возвращает параметры текущей привязки, хранящиеся в контексте этой привязки.</summary>
		/// <param name="pbindopts">Указатель на структуру для получения параметров привязки.</param>
		// Token: 0x0600424D RID: 16973
		void GetBindOptions(ref BIND_OPTS pbindopts);

		/// <summary>Возвращает доступ к таблице текущих объектов ROT, относящейся к этому процессу привязки.</summary>
		/// <param name="pprot">При успешном возвращении — ссылка на таблицу текущих объектов ROT.</param>
		// Token: 0x0600424E RID: 16974
		void GetRunningObjectTable(out UCOMIRunningObjectTable pprot);

		/// <summary>Регистрирует заданный указатель для объекта под указанным именем в таблице внутреннего представления указателей объектов.</summary>
		/// <param name="pszKey">Имя, используемое для регистрации <paramref name="punk" />.</param>
		/// <param name="punk">Регистрируемый объект.</param>
		// Token: 0x0600424F RID: 16975
		void RegisterObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [MarshalAs(UnmanagedType.Interface)] object punk);

		/// <summary>Выполняет поиск заданного ключа таблицы внутреннего представления контекстных параметров объекта и возвращает соответствующий объект, если он существует.</summary>
		/// <param name="pszKey">Имя объекта, который нужно найти.</param>
		/// <param name="ppunk">При удачном возвращении — указатель на интерфейс объекта.</param>
		// Token: 0x06004250 RID: 16976
		void GetObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [MarshalAs(UnmanagedType.Interface)] out object ppunk);

		/// <summary>Перечисляет строки, являющиеся ключами таблицы внутреннего представления контекстных параметров объекта.</summary>
		/// <param name="ppenum">При успешном возвращении — ссылка на перечислитель параметров объекта.</param>
		// Token: 0x06004251 RID: 16977
		void EnumObjectParam(out UCOMIEnumString ppenum);

		/// <summary>Отменяет регистрацию объекта, найденного в данный момент для этого ключа во внутренней таблице контекстных параметров объекта, если зарегистрирован хотя бы один такой ключ.</summary>
		/// <param name="pszKey">Ключ, регистрацию которого необходимо удалить.</param>
		// Token: 0x06004252 RID: 16978
		void RevokeObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey);
	}
}
