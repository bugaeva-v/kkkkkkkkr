using System;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Transactions
{
	/// <summary>Разрешение, которое требуется пространством имен <see cref="N:System.Transactions" /> при эскалации управления транзакцией MSDTC. Этот класс не наследуется.</summary>
	// Token: 0x02000030 RID: 48
	[Serializable]
	public sealed class DistributedTransactionPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.DistributedTransactionPermission" />.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		// Token: 0x060000E9 RID: 233 RVA: 0x000021C9 File Offset: 0x000003C9
		public DistributedTransactionPermission(PermissionState state)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x060000EA RID: 234 RVA: 0x00003476 File Offset: 0x00001676
		public override IPermission Copy()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="securityElement">Кодировка XML, используемая для восстановления разрешения.</param>
		// Token: 0x060000EB RID: 235 RVA: 0x000021C9 File Offset: 0x000003C9
		public override void FromXml(SecurityElement securityElement)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		// Token: 0x060000EC RID: 236 RVA: 0x00003476 File Offset: 0x00001676
		public override IPermission Intersect(IPermission target)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение подмножеством заданного разрешения.</summary>
		/// <param name="target">Разрешение на проверку наличия связи подмножеств. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>
		///   <see langword="true" />, если текущее разрешение <see cref="T:System.Security.IPermission" /> является подмножеством заданного разрешения <see cref="T:System.Security.IPermission" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060000ED RID: 237 RVA: 0x00003480 File Offset: 0x00001680
		public override bool IsSubsetOf(IPermission target)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>Возвращает значение, указывающее, допустим ли неограниченный доступ к ресурсу, защищенному текущим разрешением.</summary>
		/// <returns>Значение <see langword="true" />, если разрешено неограниченное использование ресурса, защищенного разрешением. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000EE RID: 238 RVA: 0x0000349C File Offset: 0x0000169C
		public bool IsUnrestricted()
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, который содержит XML-кодирование объекта безопасности, включающее любые данные состояния.</returns>
		// Token: 0x060000EF RID: 239 RVA: 0x00003476 File Offset: 0x00001676
		public override SecurityElement ToXml()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
