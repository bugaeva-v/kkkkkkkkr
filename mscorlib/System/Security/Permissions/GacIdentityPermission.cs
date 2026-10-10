using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Определяет разрешение идентификации для файлов из глобального кэша сборок. Этот класс не наследуется.</summary>
	// Token: 0x0200043B RID: 1083
	[ComVisible(true)]
	[Serializable]
	public sealed class GacIdentityPermission : CodeAccessPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.GacIdentityPermission" />.</summary>
		// Token: 0x06002C01 RID: 11265 RVA: 0x0009E0E2 File Offset: 0x0009C2E2
		public GacIdentityPermission()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.GacIdentityPermission" /> с полностью ограниченным <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="state" /> не является допустимым значением <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002C02 RID: 11266 RVA: 0x0009EC4C File Offset: 0x0009CE4C
		public GacIdentityPermission(PermissionState state)
		{
			CodeAccessPermission.CheckPermissionState(state, false);
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002C03 RID: 11267 RVA: 0x0009A086 File Offset: 0x00098286
		public override IPermission Copy()
		{
			return new GacIdentityPermission();
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Если пересечение пусто, новое разрешение имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002C04 RID: 11268 RVA: 0x0009EC5C File Offset: 0x0009CE5C
		public override IPermission Intersect(IPermission target)
		{
			if (this.Cast(target) == null)
			{
				return null;
			}
			return this.Copy();
		}

		/// <summary>Указывает, является ли текущее разрешение подмножеством заданного разрешения.</summary>
		/// <param name="target">Объект разрешений для проверки соотношения подмножеств. Это разрешение должно относиться к тому же типу, что и текущее разрешение.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002C05 RID: 11269 RVA: 0x0009EC6F File Offset: 0x0009CE6F
		public override bool IsSubsetOf(IPermission target)
		{
			return this.Cast(target) != null;
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой объединение текущего и заданного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002C06 RID: 11270 RVA: 0x0009EC7B File Offset: 0x0009CE7B
		public override IPermission Union(IPermission target)
		{
			this.Cast(target);
			return this.Copy();
		}

		/// <summary>Создает разрешение из кодировки XML.</summary>
		/// <param name="securityElement">Объект <see cref="T:System.Security.SecurityElement" />, который содержит кодировку XML, используемую для создания разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="securityElement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="securityElement" /> не является допустимым элементом разрешения.  
		///
		/// или - 
		/// Недопустимый номер версии <paramref name="securityElement" />.</exception>
		// Token: 0x06002C07 RID: 11271 RVA: 0x0009EC8B File Offset: 0x0009CE8B
		public override void FromXml(SecurityElement securityElement)
		{
			CodeAccessPermission.CheckSecurityElement(securityElement, "securityElement", 1, 1);
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, который представляет кодировку XML разрешения, включающую любые сведения о состоянии.</returns>
		// Token: 0x06002C08 RID: 11272 RVA: 0x0009EC9B File Offset: 0x0009CE9B
		public override SecurityElement ToXml()
		{
			return base.Element(1);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0006AFCE File Offset: 0x000691CE
		int IBuiltInPermission.GetTokenIndex()
		{
			return 15;
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x0009ECA4 File Offset: 0x0009CEA4
		private GacIdentityPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			GacIdentityPermission gacIdentityPermission = target as GacIdentityPermission;
			if (gacIdentityPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(GacIdentityPermission));
			}
			return gacIdentityPermission;
		}

		// Token: 0x0400202C RID: 8236
		private const int version = 1;
	}
}
