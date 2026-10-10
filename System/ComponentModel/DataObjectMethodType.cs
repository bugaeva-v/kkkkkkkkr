using System;

namespace System.ComponentModel
{
	/// <summary>Определяет тип операции с данными, выполняемой методом, в соответствии с атрибутом <see cref="T:System.ComponentModel.DataObjectMethodAttribute" />, примененным к методу.</summary>
	// Token: 0x02000397 RID: 919
	public enum DataObjectMethodType
	{
		/// <summary>Показывает, что метод используется для операции с данными, заполняющей объект <see cref="T:System.Data.DataSet" />.</summary>
		// Token: 0x04000F11 RID: 3857
		Fill,
		/// <summary>Показывает, что метод используется для операции с данными, возвращающей данные.</summary>
		// Token: 0x04000F12 RID: 3858
		Select,
		/// <summary>Показывает, что метод используется для операции с данными, изменяющей данные.</summary>
		// Token: 0x04000F13 RID: 3859
		Update,
		/// <summary>Показывает, что метод используется для операции с данными, вставляющей данные.</summary>
		// Token: 0x04000F14 RID: 3860
		Insert,
		/// <summary>Показывает, что метод используется для операции с данными, удаляющей данные.</summary>
		// Token: 0x04000F15 RID: 3861
		Delete
	}
}
