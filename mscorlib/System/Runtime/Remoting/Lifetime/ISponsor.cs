using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	/// <summary>Указывает, что средству реализации необходимо стать спонсором времени жизни аренды.</summary>
	// Token: 0x02000584 RID: 1412
	[ComVisible(true)]
	public interface ISponsor
	{
		/// <summary>Запрашивает клиент-спонсор для обновления аренды выбранного объекта.</summary>
		/// <param name="lease">Аренда жизненного цикла объекта, для которого требуется продление срока аренды.</param>
		/// <returns>Дополнительное время аренды для заданного объекта.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x0600375C RID: 14172
		TimeSpan Renewal(ILease lease);
	}
}
