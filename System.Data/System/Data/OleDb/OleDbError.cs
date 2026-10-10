using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Собирает сведения, имеющие отношение к предупреждению или ошибке, возвращенной источником данных.</summary>
	// Token: 0x02000164 RID: 356
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbError
	{
		// Token: 0x06001355 RID: 4949 RVA: 0x00003D93 File Offset: 0x00001F93
		internal OleDbError()
		{
		}

		/// <summary>Получает краткое описание ошибки.</summary>
		/// <returns>Краткое описание ошибки.</returns>
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public string Message
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает сведения об ошибке, выдаваемые конкретной базой данных.</summary>
		/// <returns>Сведения об ошибке, выдаваемые конкретной базой данных.</returns>
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public int NativeError
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает имя вызвавшего ошибку поставщика.</summary>
		/// <returns>Имя вызвавшего ошибку поставщика.</returns>
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public string Source
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает пятизначный код ошибки, соответствующий стандарту ANSI SQL для базы данных.</summary>
		/// <returns>Пятизначный код ошибки, определяющий ее источник, если такая ошибка могла возникнуть в нескольких местах.</returns>
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public string SQLState
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает полный текст сообщения об ошибке.</summary>
		/// <returns>Полный текст сообщения об ошибке.</returns>
		// Token: 0x0600135A RID: 4954 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string ToString()
		{
			throw ADP.OleDb();
		}
	}
}
