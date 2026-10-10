using System;
using System.Security;
using System.Security.Permissions;

namespace System.Drawing.Printing
{
	/// <summary>Управляет доступом к принтерам. Этот класс не наследуется.</summary>
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public sealed class PrintingPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrintingPermission" /> с указанным уровнем доступа к печати.</summary>
		/// <param name="printingLevel">Одно из значений <see cref="T:System.Drawing.Printing.PrintingPermissionLevel" />.</param>
		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001876C File Offset: 0x0001696C
		public PrintingPermission(PrintingPermissionLevel printingLevel)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrintingPermission" /> указанным состоянием доступа: полностью ограниченный или неограниченный.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="state" /> не является допустимым <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001876C File Offset: 0x0001696C
		public PrintingPermission(PermissionState state)
		{
		}

		/// <summary>Получает или задает уровень кода доступа к печати.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Printing.PrintingPermissionLevel" />.</returns>
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00018774 File Offset: 0x00016974
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x0001877C File Offset: 0x0001697C
		public PrintingPermissionLevel Level { get; set; }

		/// <summary>Создает и возвращает идентичную копию текущего объекта разрешения.</summary>
		/// <returns>Копия текущего объекта разрешения.</returns>
		// Token: 0x06000AC8 RID: 2760 RVA: 0x00018785 File Offset: 0x00016985
		public override IPermission Copy()
		{
			return null;
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		// Token: 0x06000AC9 RID: 2761 RVA: 0x000049FE File Offset: 0x00002BFE
		public override void FromXml(SecurityElement element)
		{
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и целевого объектов разрешения.</summary>
		/// <param name="target">Разрешение относится к тому же типу, что и текущее разрешение.</param>
		/// <returns>Новый объект разрешения, представляющий собой пересечение текущего и заданного целевого объектов. Этот объект является <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> является объектом, тип которого отличается от текущего объекта разрешения.</exception>
		// Token: 0x06000ACA RID: 2762 RVA: 0x00018785 File Offset: 0x00016985
		public override IPermission Intersect(IPermission target)
		{
			return null;
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством заданного разрешения.</summary>
		/// <param name="target">Объект разрешения, для которого требуется проверить соотношение подмножеств. Этот объект должен относиться к тому же типу, что и текущий объект разрешения.</param>
		/// <returns>Значение равно <see langword="true" />, если текущий объект разрешения является подмножеством <paramref name="target" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> является объектом, тип которого отличается от текущего объекта разрешения.</exception>
		// Token: 0x06000ACB RID: 2763 RVA: 0x0000C228 File Offset: 0x0000A428
		public override bool IsSubsetOf(IPermission target)
		{
			return false;
		}

		/// <summary>Получает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>
		///   <see langword="true" />, если текущее разрешение является неограниченным; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000ACC RID: 2764 RVA: 0x0000C228 File Offset: 0x0000A428
		public bool IsUnrestricted()
		{
			return false;
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06000ACD RID: 2765 RVA: 0x00018785 File Offset: 0x00016985
		public override SecurityElement ToXml()
		{
			return null;
		}

		/// <summary>Создает разрешение, объединяющее объект разрешения и целевой объект разрешения.</summary>
		/// <param name="target">Разрешение относится к тому же типу, что и текущее разрешение.</param>
		/// <returns>Новый объект разрешения, представляющий собой объединение текущего и заданного объектов разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> является объектом, тип которого отличается от текущего объекта разрешения.</exception>
		// Token: 0x06000ACE RID: 2766 RVA: 0x00018785 File Offset: 0x00016985
		public override IPermission Union(IPermission target)
		{
			return null;
		}
	}
}
