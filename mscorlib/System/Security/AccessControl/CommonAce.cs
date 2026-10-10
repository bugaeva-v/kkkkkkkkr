using System;
using System.Globalization;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет элемент управления доступом.</summary>
	// Token: 0x0200050E RID: 1294
	public sealed class CommonAce : QualifiedAce
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CommonAce" />.</summary>
		/// <param name="flags">Флаги, определяющие параметры наследования и распространения наследования, а также условия аудита нового элемента управления доступом.</param>
		/// <param name="qualifier">Функция нового элемента управления доступом.</param>
		/// <param name="accessMask">Маска доступа элемента управления доступом.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, связанный с новым элементом управления доступом.</param>
		/// <param name="isCallback">Значение <see langword="true" />, если новый элемент управления доступом является элементом управления доступом обратного вызова.</param>
		/// <param name="opaque">Непрозрачные данные, связанные с новым элементом управления доступом. Непрозрачные данные разрешены только для элементов управления доступом обратного вызова. Длина этого массива не должна превышать значение, возвращаемое методом <see cref="M:System.Security.AccessControl.CommonAce.MaxOpaqueLength(System.Boolean)" />.</param>
		// Token: 0x0600335D RID: 13149 RVA: 0x000BCA80 File Offset: 0x000BAC80
		public CommonAce(AceFlags flags, AceQualifier qualifier, int accessMask, SecurityIdentifier sid, bool isCallback, byte[] opaque) : base(CommonAce.ConvertType(qualifier, isCallback), flags, opaque)
		{
			base.AccessMask = accessMask;
			base.SecurityIdentifier = sid;
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x000BCAA2 File Offset: 0x000BACA2
		internal CommonAce(AceType type, AceFlags flags, int accessMask, SecurityIdentifier sid, byte[] opaque) : base(type, flags, opaque)
		{
			base.AccessMask = accessMask;
			base.SecurityIdentifier = sid;
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000BCAC0 File Offset: 0x000BACC0
		internal CommonAce(byte[] binaryForm, int offset) : base(binaryForm, offset)
		{
			int num = (int)GenericAce.ReadUShort(binaryForm, offset + 2);
			if (offset > binaryForm.Length - num)
			{
				throw new ArgumentException("Invalid ACE - truncated", "binaryForm");
			}
			if (num < 8 + SecurityIdentifier.MinBinaryLength)
			{
				throw new ArgumentException("Invalid ACE", "binaryForm");
			}
			base.AccessMask = GenericAce.ReadInt(binaryForm, offset + 4);
			base.SecurityIdentifier = new SecurityIdentifier(binaryForm, offset + 8);
			int num2 = num - (8 + base.SecurityIdentifier.BinaryLength);
			if (num2 > 0)
			{
				byte[] array = new byte[num2];
				Array.Copy(binaryForm, offset + 8 + base.SecurityIdentifier.BinaryLength, array, 0, num2);
				base.SetOpaque(array);
			}
		}

		/// <summary>Возвращает длину в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.CommonAce" />. Это длину необходимо передать методу <see cref="M:System.Security.AccessControl.CommonAce.GetBinaryForm(System.Byte[],System.Int32)" /> перед маршалингом списка управления доступом в двоичный массив.</summary>
		/// <returns>Длина в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.CommonAce" />.</returns>
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06003360 RID: 13152 RVA: 0x000BCB69 File Offset: 0x000BAD69
		public override int BinaryLength
		{
			get
			{
				return 8 + base.SecurityIdentifier.BinaryLength + base.OpaqueLength;
			}
		}

		/// <summary>Маршалирует содержимое объекта <see cref="T:System.Security.AccessControl.CommonAce" /> в указанный массив байтов, начиная с указанной позиции.</summary>
		/// <param name="binaryForm">Массив байтов, в который маршалируется содержимое объекта <see cref="T:System.Security.AccessControl.CommonAce" />.</param>
		/// <param name="offset">Позиция, с которой начинается маршалинг.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> отрицательно или слишком велико, чтобы можно было скопировать весь объект <see cref="T:System.Security.AccessControl.CommonAce" /> в массив <paramref name="binaryForm" />.</exception>
		// Token: 0x06003361 RID: 13153 RVA: 0x000BCB80 File Offset: 0x000BAD80
		public override void GetBinaryForm(byte[] binaryForm, int offset)
		{
			ushort binaryLength = (ushort)this.BinaryLength;
			binaryForm[offset] = (byte)base.AceType;
			binaryForm[offset + 1] = (byte)base.AceFlags;
			GenericAce.WriteUShort(binaryLength, binaryForm, offset + 2);
			GenericAce.WriteInt(base.AccessMask, binaryForm, offset + 4);
			base.SecurityIdentifier.GetBinaryForm(binaryForm, offset + 8);
			byte[] opaque = base.GetOpaque();
			if (opaque != null)
			{
				Array.Copy(opaque, 0, binaryForm, offset + 8 + base.SecurityIdentifier.BinaryLength, opaque.Length);
			}
		}

		/// <summary>Возвращает максимально допустимую длину большого двоичного объекта непрозрачных данных для элементов управления доступом обратного вызова.</summary>
		/// <param name="isCallback">Значение <see langword="true" />, если объект <see cref="T:System.Security.AccessControl.CommonAce" /> является элементом управления доступом обратного вызова.</param>
		/// <returns>Допустимая длина большого двоичного объекта непрозрачных данных.</returns>
		// Token: 0x06003362 RID: 13154 RVA: 0x000BCBF3 File Offset: 0x000BADF3
		public static int MaxOpaqueLength(bool isCallback)
		{
			return 65459;
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x000BCBFC File Offset: 0x000BADFC
		internal override string GetSddlForm()
		{
			if (base.OpaqueLength != 0)
			{
				throw new NotImplementedException("Unable to convert conditional ACEs to SDDL");
			}
			return string.Format(CultureInfo.InvariantCulture, "({0};{1};{2};;;{3})", new object[]
			{
				GenericAce.GetSddlAceType(base.AceType),
				GenericAce.GetSddlAceFlags(base.AceFlags),
				KnownAce.GetSddlAccessRights(base.AccessMask),
				base.SecurityIdentifier.GetSddlForm()
			});
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x000BCC6C File Offset: 0x000BAE6C
		private static AceType ConvertType(AceQualifier qualifier, bool isCallback)
		{
			switch (qualifier)
			{
			case AceQualifier.AccessAllowed:
				if (isCallback)
				{
					return AceType.AccessAllowedCallback;
				}
				return AceType.AccessAllowed;
			case AceQualifier.AccessDenied:
				if (isCallback)
				{
					return AceType.AccessDeniedCallback;
				}
				return AceType.AccessDenied;
			case AceQualifier.SystemAudit:
				if (isCallback)
				{
					return AceType.SystemAuditCallback;
				}
				return AceType.SystemAudit;
			case AceQualifier.SystemAlarm:
				if (isCallback)
				{
					return AceType.SystemAlarmCallback;
				}
				return AceType.SystemAlarm;
			default:
				throw new ArgumentException("Unrecognized ACE qualifier: " + qualifier.ToString(), "qualifier");
			}
		}
	}
}
