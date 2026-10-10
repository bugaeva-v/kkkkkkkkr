using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Указывает разрешенное использование закрытой виртуальной файловой системы. Этот класс не наследуется.</summary>
	// Token: 0x02000441 RID: 1089
	[ComVisible(true)]
	[Serializable]
	public sealed class IsolatedStorageFilePermission : IsolatedStoragePermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.IsolatedStorageFilePermission" /> указанным состоянием разрешения: полностью ограниченное или неограниченное.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002C32 RID: 11314 RVA: 0x0009F0F0 File Offset: 0x0009D2F0
		public IsolatedStorageFilePermission(PermissionState state) : base(state)
		{
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002C33 RID: 11315 RVA: 0x0009F0FC File Offset: 0x0009D2FC
		public override IPermission Copy()
		{
			return new IsolatedStorageFilePermission(PermissionState.None)
			{
				m_userQuota = this.m_userQuota,
				m_machineQuota = this.m_machineQuota,
				m_expirationDays = this.m_expirationDays,
				m_permanentData = this.m_permanentData,
				m_allowed = this.m_allowed
			};
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002C34 RID: 11316 RVA: 0x0009F14C File Offset: 0x0009D34C
		public override IPermission Intersect(IPermission target)
		{
			IsolatedStorageFilePermission isolatedStorageFilePermission = this.Cast(target);
			if (isolatedStorageFilePermission == null)
			{
				return null;
			}
			if (base.IsEmpty() && isolatedStorageFilePermission.IsEmpty())
			{
				return null;
			}
			return new IsolatedStorageFilePermission(PermissionState.None)
			{
				m_userQuota = ((this.m_userQuota < isolatedStorageFilePermission.m_userQuota) ? this.m_userQuota : isolatedStorageFilePermission.m_userQuota),
				m_machineQuota = ((this.m_machineQuota < isolatedStorageFilePermission.m_machineQuota) ? this.m_machineQuota : isolatedStorageFilePermission.m_machineQuota),
				m_expirationDays = ((this.m_expirationDays < isolatedStorageFilePermission.m_expirationDays) ? this.m_expirationDays : isolatedStorageFilePermission.m_expirationDays),
				m_permanentData = (this.m_permanentData && isolatedStorageFilePermission.m_permanentData),
				UsageAllowed = ((this.m_allowed < isolatedStorageFilePermission.m_allowed) ? this.m_allowed : isolatedStorageFilePermission.m_allowed)
			};
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002C35 RID: 11317 RVA: 0x0009F220 File Offset: 0x0009D420
		public override bool IsSubsetOf(IPermission target)
		{
			IsolatedStorageFilePermission isolatedStorageFilePermission = this.Cast(target);
			if (isolatedStorageFilePermission == null)
			{
				return base.IsEmpty();
			}
			return isolatedStorageFilePermission.IsUnrestricted() || (this.m_userQuota <= isolatedStorageFilePermission.m_userQuota && this.m_machineQuota <= isolatedStorageFilePermission.m_machineQuota && this.m_expirationDays <= isolatedStorageFilePermission.m_expirationDays && this.m_permanentData == isolatedStorageFilePermission.m_permanentData && this.m_allowed <= isolatedStorageFilePermission.m_allowed);
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002C36 RID: 11318 RVA: 0x0009F29C File Offset: 0x0009D49C
		public override IPermission Union(IPermission target)
		{
			IsolatedStorageFilePermission isolatedStorageFilePermission = this.Cast(target);
			if (isolatedStorageFilePermission == null)
			{
				return this.Copy();
			}
			return new IsolatedStorageFilePermission(PermissionState.None)
			{
				m_userQuota = ((this.m_userQuota > isolatedStorageFilePermission.m_userQuota) ? this.m_userQuota : isolatedStorageFilePermission.m_userQuota),
				m_machineQuota = ((this.m_machineQuota > isolatedStorageFilePermission.m_machineQuota) ? this.m_machineQuota : isolatedStorageFilePermission.m_machineQuota),
				m_expirationDays = ((this.m_expirationDays > isolatedStorageFilePermission.m_expirationDays) ? this.m_expirationDays : isolatedStorageFilePermission.m_expirationDays),
				m_permanentData = (this.m_permanentData || isolatedStorageFilePermission.m_permanentData),
				UsageAllowed = ((this.m_allowed > isolatedStorageFilePermission.m_allowed) ? this.m_allowed : isolatedStorageFilePermission.m_allowed)
			};
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002C37 RID: 11319 RVA: 0x0009F360 File Offset: 0x0009D560
		[MonoTODO("(2.0) new override - something must have been added ???")]
		[ComVisible(false)]
		public override SecurityElement ToXml()
		{
			return base.ToXml();
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000221D2 File Offset: 0x000203D2
		int IBuiltInPermission.GetTokenIndex()
		{
			return 3;
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x0009F368 File Offset: 0x0009D568
		private IsolatedStorageFilePermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			IsolatedStorageFilePermission isolatedStorageFilePermission = target as IsolatedStorageFilePermission;
			if (isolatedStorageFilePermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(IsolatedStorageFilePermission));
			}
			return isolatedStorageFilePermission;
		}
	}
}
