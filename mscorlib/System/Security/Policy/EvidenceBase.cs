using System;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Предоставляет базовый класс. Все объекты, используемые как свидетельство, должны быть производными от него.</summary>
	// Token: 0x0200040D RID: 1037
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	[Serializable]
	public abstract class EvidenceBase
	{
		/// <summary>Создает новый объект, являющийся полной копией текущего экземпляра.</summary>
		/// <returns>Копия данного объекта свидетельства.</returns>
		// Token: 0x06002A74 RID: 10868 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecurityPermission(SecurityAction.Assert, SerializationFormatter = true)]
		public virtual EvidenceBase Clone()
		{
			throw new NotImplementedException();
		}
	}
}
