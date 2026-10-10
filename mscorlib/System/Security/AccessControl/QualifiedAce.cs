using System;
using Unity;

namespace System.Security.AccessControl
{
	/// <summary>Представляет элемент управления доступом, содержащий квалификатор. Квалификатор, представляемый объектом <see cref="T:System.Security.AccessControl.AceQualifier" />, определяет функцию элемента управления доступом — разрешение доступа, запрет доступа, вызов системного аудита или системного оповещения. Класс <see cref="T:System.Security.AccessControl.QualifiedAce" /> является абстрактным базовым классом для классов <see cref="T:System.Security.AccessControl.CommonAce" /> и <see cref="T:System.Security.AccessControl.ObjectAce" />.</summary>
	// Token: 0x02000544 RID: 1348
	public abstract class QualifiedAce : KnownAce
	{
		// Token: 0x0600355D RID: 13661 RVA: 0x000C0F40 File Offset: 0x000BF140
		internal QualifiedAce(AceType type, AceFlags flags, byte[] opaque) : base(type, flags)
		{
			this.SetOpaque(opaque);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x000C0F51 File Offset: 0x000BF151
		internal QualifiedAce(byte[] binaryForm, int offset) : base(binaryForm, offset)
		{
		}

		/// <summary>Получает значение, определяющее функцию элемента управления доступом — разрешение доступа, запрет доступа, вызов системного аудита или системного оповещения.</summary>
		/// <returns>Значение, определяющее функцию элемента управления доступом — разрешение доступа, запрет доступа, вызов системного аудита или системного оповещения.</returns>
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x000C0F5C File Offset: 0x000BF15C
		public AceQualifier AceQualifier
		{
			get
			{
				switch (base.AceType)
				{
				case AceType.AccessAllowed:
				case AceType.AccessAllowedCompound:
				case AceType.AccessAllowedObject:
				case AceType.AccessAllowedCallback:
				case AceType.AccessAllowedCallbackObject:
					return AceQualifier.AccessAllowed;
				case AceType.AccessDenied:
				case AceType.AccessDeniedObject:
				case AceType.AccessDeniedCallback:
				case AceType.AccessDeniedCallbackObject:
					return AceQualifier.AccessDenied;
				case AceType.SystemAudit:
				case AceType.SystemAuditObject:
				case AceType.SystemAuditCallback:
				case AceType.SystemAuditCallbackObject:
					return AceQualifier.SystemAudit;
				case AceType.SystemAlarm:
				case AceType.SystemAlarmObject:
				case AceType.SystemAlarmCallback:
				case AceType.SystemAlarmCallbackObject:
					return AceQualifier.SystemAlarm;
				default:
					throw new ArgumentException("Unrecognised ACE type: " + base.AceType.ToString());
				}
			}
		}

		/// <summary>Определяет, содержит ли этот объект <see cref="T:System.Security.AccessControl.QualifiedAce" /> данные обратного вызова.</summary>
		/// <returns>Значение <see langword="true" />, если этот объект <see cref="T:System.Security.AccessControl.QualifiedAce" /> содержит данные обратного вызова; в противном случае — значение false.</returns>
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x000C0FE8 File Offset: 0x000BF1E8
		public bool IsCallback
		{
			get
			{
				return base.AceType == AceType.AccessAllowedCallback || base.AceType == AceType.AccessAllowedCallbackObject || base.AceType == AceType.AccessDeniedCallback || base.AceType == AceType.AccessDeniedCallbackObject || base.AceType == AceType.SystemAlarmCallback || base.AceType == AceType.SystemAlarmCallbackObject || base.AceType == AceType.SystemAuditCallback || base.AceType == AceType.SystemAuditCallbackObject;
			}
		}

		/// <summary>Получает длину непрозрачных данных обратного вызова, связанных с этим объектом <see cref="T:System.Security.AccessControl.QualifiedAce" />. Это свойство применимо только к элементам управления доступом обратного вызова.</summary>
		/// <returns>Длина непрозрачных данных обратного вызова в байтах.</returns>
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x000C1047 File Offset: 0x000BF247
		public int OpaqueLength
		{
			get
			{
				if (this.opaque == null)
				{
					return 0;
				}
				return this.opaque.Length;
			}
		}

		/// <summary>Возвращает длину непрозрачных данных обратного вызова, связанных с этим объектом <see cref="T:System.Security.AccessControl.QualifiedAce" />.</summary>
		/// <returns>Массив байтов, представляющий непрозрачные данные обратного вызова, связанные с данным объектом <see cref="T:System.Security.AccessControl.QualifiedAce" />.</returns>
		// Token: 0x06003562 RID: 13666 RVA: 0x000C105B File Offset: 0x000BF25B
		public byte[] GetOpaque()
		{
			if (this.opaque == null)
			{
				return null;
			}
			return (byte[])this.opaque.Clone();
		}

		/// <summary>Задает непрозрачные данные обратного вызова, связанные с этим объектом <see cref="T:System.Security.AccessControl.QualifiedAce" />.</summary>
		/// <param name="opaque">Массив байтов, представляющий непрозрачные данные обратного вызова для данного объекта <see cref="T:System.Security.AccessControl.QualifiedAce" />.</param>
		// Token: 0x06003563 RID: 13667 RVA: 0x000C1077 File Offset: 0x000BF277
		public void SetOpaque(byte[] opaque)
		{
			if (opaque == null)
			{
				this.opaque = null;
				return;
			}
			this.opaque = (byte[])opaque.Clone();
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x000173AD File Offset: 0x000155AD
		internal QualifiedAce()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040024D4 RID: 9428
		private byte[] opaque;
	}
}
