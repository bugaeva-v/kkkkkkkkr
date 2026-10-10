using System;
using System.Globalization;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Управляет доступом к объектам служб каталогов. Этот класс представляет элемент управления доступом (ACE), связанный с объектом каталога.</summary>
	// Token: 0x0200053E RID: 1342
	public sealed class ObjectAce : QualifiedAce
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.ObjectAce" />.</summary>
		/// <param name="aceFlags">Наследование, распространение наследования и условия аудита для нового элемента управления доступом (ACE).</param>
		/// <param name="qualifier">Функция нового элемента управления доступом.</param>
		/// <param name="accessMask">Маска доступа элемента управления доступом.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, связанный с новым элементом управления доступом.</param>
		/// <param name="flags">Содержат ли параметры <paramref name="type" /> и <paramref name="inheritedType" /> допустимые идентификаторы GUID объектов.</param>
		/// <param name="type">Идентификатор GUID, определяющий тип объекта, к которому применяется новый элемент управления доступом.</param>
		/// <param name="inheritedType">Идентификатор GUID, определяющий тип объекта, который может наследовать новый элемент управления доступом.</param>
		/// <param name="isCallback">Значение <see langword="true" />, если новый элемент управления доступом является элементом управления доступом обратного вызова.</param>
		/// <param name="opaque">Непрозрачные данные, связанные с новым элементом управления доступом. Непрозрачные данные разрешены только для элементов управления доступом обратного вызова. Длина этого массива не должна превышать значение, возвращаемое методом <see cref="M:System.Security.AccessControl.ObjectAce.MaxOpaqueLength(System.Boolean)" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр квалификатора содержит недопустимое значение или длина значения непрозрачного параметра больше значения, возвращаемого методом <see cref="M:System.Security.AccessControl.ObjectAce.MaxOpaqueLength(System.Boolean)" />.</exception>
		// Token: 0x060034F3 RID: 13555 RVA: 0x000C00D0 File Offset: 0x000BE2D0
		public ObjectAce(AceFlags aceFlags, AceQualifier qualifier, int accessMask, SecurityIdentifier sid, ObjectAceFlags flags, Guid type, Guid inheritedType, bool isCallback, byte[] opaque) : base(ObjectAce.ConvertType(qualifier, isCallback), aceFlags, opaque)
		{
			base.AccessMask = accessMask;
			base.SecurityIdentifier = sid;
			this.ObjectAceFlags = flags;
			this.ObjectAceType = type;
			this.InheritedObjectAceType = inheritedType;
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x000C010A File Offset: 0x000BE30A
		internal ObjectAce(AceType type, AceFlags flags, int accessMask, SecurityIdentifier sid, ObjectAceFlags objFlags, Guid objType, Guid inheritedType, byte[] opaque) : base(type, flags, opaque)
		{
			base.AccessMask = accessMask;
			base.SecurityIdentifier = sid;
			this.ObjectAceFlags = objFlags;
			this.ObjectAceType = objType;
			this.InheritedObjectAceType = inheritedType;
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000C0140 File Offset: 0x000BE340
		internal ObjectAce(byte[] binaryForm, int offset) : base(binaryForm, offset)
		{
			int num = (int)GenericAce.ReadUShort(binaryForm, offset + 2);
			int num2 = 12 + SecurityIdentifier.MinBinaryLength;
			if (offset > binaryForm.Length - num)
			{
				throw new ArgumentException("Invalid ACE - truncated", "binaryForm");
			}
			if (num < num2)
			{
				throw new ArgumentException("Invalid ACE", "binaryForm");
			}
			base.AccessMask = GenericAce.ReadInt(binaryForm, offset + 4);
			this.ObjectAceFlags = (ObjectAceFlags)GenericAce.ReadInt(binaryForm, offset + 8);
			if (this.ObjectAceTypePresent)
			{
				num2 += 16;
			}
			if (this.InheritedObjectAceTypePresent)
			{
				num2 += 16;
			}
			if (num < num2)
			{
				throw new ArgumentException("Invalid ACE", "binaryForm");
			}
			int num3 = 12;
			if (this.ObjectAceTypePresent)
			{
				this.ObjectAceType = this.ReadGuid(binaryForm, offset + num3);
				num3 += 16;
			}
			if (this.InheritedObjectAceTypePresent)
			{
				this.InheritedObjectAceType = this.ReadGuid(binaryForm, offset + num3);
				num3 += 16;
			}
			base.SecurityIdentifier = new SecurityIdentifier(binaryForm, offset + num3);
			num3 += base.SecurityIdentifier.BinaryLength;
			int num4 = num - num3;
			if (num4 > 0)
			{
				byte[] array = new byte[num4];
				Array.Copy(binaryForm, offset + num3, array, 0, num4);
				base.SetOpaque(array);
			}
		}

		/// <summary>Возвращает длину в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.ObjectAce" />. Эту длину необходимо использовать перед маршалингом списка управления доступом в двоичный массив с помощью метода <see cref="M:System.Security.AccessControl.ObjectAce.GetBinaryForm(System.Byte[],System.Int32)" />.</summary>
		/// <returns>Длина в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.ObjectAce" />.</returns>
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x000C0260 File Offset: 0x000BE460
		public override int BinaryLength
		{
			get
			{
				int num = 12 + base.SecurityIdentifier.BinaryLength + base.OpaqueLength;
				if (this.ObjectAceTypePresent)
				{
					num += 16;
				}
				if (this.InheritedObjectAceTypePresent)
				{
					num += 16;
				}
				return num;
			}
		}

		/// <summary>Возвращает или задает идентификатор GUID типа объекта, который может наследовать элемент управления доступом (ACE), представляемый данным объектом <see cref="T:System.Security.AccessControl.ObjectAce" />.</summary>
		/// <returns>GUID типа объекта, который может наследовать элемент управления доступом (ACE), представляемый данным объектом <see cref="T:System.Security.AccessControl.ObjectAce" />.</returns>
		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x000C029E File Offset: 0x000BE49E
		// (set) Token: 0x060034F8 RID: 13560 RVA: 0x000C02A6 File Offset: 0x000BE4A6
		public Guid InheritedObjectAceType
		{
			get
			{
				return this.inherited_object_type;
			}
			set
			{
				this.inherited_object_type = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x000C02AF File Offset: 0x000BE4AF
		private bool InheritedObjectAceTypePresent
		{
			get
			{
				return (this.ObjectAceFlags & ObjectAceFlags.InheritedObjectAceTypePresent) > ObjectAceFlags.None;
			}
		}

		/// <summary>Возвращает или задает флаги, которые указывают, содержат ли свойства <see cref="P:System.Security.AccessControl.ObjectAce.ObjectAceType" /> и <see cref="P:System.Security.AccessControl.ObjectAce.InheritedObjectAceType" /> значения, идентифицирующие допустимые типы объектов.</summary>
		/// <returns>Один или несколько членов перечисления <see cref="T:System.Security.AccessControl.ObjectAceFlags" />, сочетаемые с помощью логической операции ИЛИ.</returns>
		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x000C02BC File Offset: 0x000BE4BC
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x000C02C4 File Offset: 0x000BE4C4
		public ObjectAceFlags ObjectAceFlags
		{
			get
			{
				return this.object_ace_flags;
			}
			set
			{
				this.object_ace_flags = value;
			}
		}

		/// <summary>Возвращает или задает идентификатор GUID типа объекта, связанный с данным объектом <see cref="T:System.Security.AccessControl.ObjectAce" />.</summary>
		/// <returns>Идентификатор GUID типа объекта, связанный с данным объектом <see cref="T:System.Security.AccessControl.ObjectAce" />.</returns>
		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x000C02CD File Offset: 0x000BE4CD
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x000C02D5 File Offset: 0x000BE4D5
		public Guid ObjectAceType
		{
			get
			{
				return this.object_ace_type;
			}
			set
			{
				this.object_ace_type = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x000C02DE File Offset: 0x000BE4DE
		private bool ObjectAceTypePresent
		{
			get
			{
				return (this.ObjectAceFlags & ObjectAceFlags.ObjectAceTypePresent) > ObjectAceFlags.None;
			}
		}

		/// <summary>Маршалирует содержимое объекта <see cref="T:System.Security.AccessControl.ObjectAce" /> в указанный массив байтов, начиная с указанной позиции.</summary>
		/// <param name="binaryForm">Массив байтов, в который маршалируется содержимое объекта <see cref="T:System.Security.AccessControl.ObjectAce" />.</param>
		/// <param name="offset">Позиция, с которой начинается маршалинг.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> является отрицательным или слишком велико, чтобы разрешить копирование всего <see cref="T:System.Security.AccessControl.ObjectAce" /> в <paramref name="array" />.</exception>
		// Token: 0x060034FF RID: 13567 RVA: 0x000C02EC File Offset: 0x000BE4EC
		public override void GetBinaryForm(byte[] binaryForm, int offset)
		{
			ushort binaryLength = (ushort)this.BinaryLength;
			binaryForm[offset++] = (byte)base.AceType;
			binaryForm[offset++] = (byte)base.AceFlags;
			GenericAce.WriteUShort(binaryLength, binaryForm, offset);
			offset += 2;
			GenericAce.WriteInt(base.AccessMask, binaryForm, offset);
			offset += 4;
			GenericAce.WriteInt((int)this.ObjectAceFlags, binaryForm, offset);
			offset += 4;
			if ((this.ObjectAceFlags & ObjectAceFlags.ObjectAceTypePresent) != ObjectAceFlags.None)
			{
				this.WriteGuid(this.ObjectAceType, binaryForm, offset);
				offset += 16;
			}
			if ((this.ObjectAceFlags & ObjectAceFlags.InheritedObjectAceTypePresent) != ObjectAceFlags.None)
			{
				this.WriteGuid(this.InheritedObjectAceType, binaryForm, offset);
				offset += 16;
			}
			base.SecurityIdentifier.GetBinaryForm(binaryForm, offset);
			offset += base.SecurityIdentifier.BinaryLength;
			byte[] opaque = base.GetOpaque();
			if (opaque != null)
			{
				Array.Copy(opaque, 0, binaryForm, offset, opaque.Length);
				offset += opaque.Length;
			}
		}

		/// <summary>Возвращает максимально допустимую длину (в байтах) большого двоичного объекта непрозрачных данных для элементов управления доступом (ACE) обратного вызова.</summary>
		/// <param name="isCallback">Значение true, если <see cref="T:System.Security.AccessControl.ObjectAce" /> является типом ACE обратного вызова.</param>
		/// <returns>Максимально допустимая длина (в байтах) большого двоичного объекта непрозрачных данных для элементов управления доступом (ACE) обратного вызова.</returns>
		// Token: 0x06003500 RID: 13568 RVA: 0x000C03C1 File Offset: 0x000BE5C1
		public static int MaxOpaqueLength(bool isCallback)
		{
			return 65423;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000C03C8 File Offset: 0x000BE5C8
		internal override string GetSddlForm()
		{
			if (base.OpaqueLength != 0)
			{
				throw new NotImplementedException("Unable to convert conditional ACEs to SDDL");
			}
			string text = "";
			if ((this.ObjectAceFlags & ObjectAceFlags.ObjectAceTypePresent) != ObjectAceFlags.None)
			{
				text = this.object_ace_type.ToString("D");
			}
			string text2 = "";
			if ((this.ObjectAceFlags & ObjectAceFlags.InheritedObjectAceTypePresent) != ObjectAceFlags.None)
			{
				text2 = this.inherited_object_type.ToString("D");
			}
			return string.Format(CultureInfo.InvariantCulture, "({0};{1};{2};{3};{4};{5})", new object[]
			{
				GenericAce.GetSddlAceType(base.AceType),
				GenericAce.GetSddlAceFlags(base.AceFlags),
				KnownAce.GetSddlAccessRights(base.AccessMask),
				text,
				text2,
				base.SecurityIdentifier.GetSddlForm()
			});
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000C0480 File Offset: 0x000BE680
		private static AceType ConvertType(AceQualifier qualifier, bool isCallback)
		{
			switch (qualifier)
			{
			case AceQualifier.AccessAllowed:
				if (isCallback)
				{
					return AceType.AccessAllowedCallbackObject;
				}
				return AceType.AccessAllowedObject;
			case AceQualifier.AccessDenied:
				if (isCallback)
				{
					return AceType.AccessDeniedCallbackObject;
				}
				return AceType.AccessDeniedObject;
			case AceQualifier.SystemAudit:
				if (isCallback)
				{
					return AceType.SystemAuditCallbackObject;
				}
				return AceType.SystemAuditObject;
			case AceQualifier.SystemAlarm:
				if (isCallback)
				{
					return AceType.SystemAlarmCallbackObject;
				}
				return AceType.SystemAlarmObject;
			default:
				throw new ArgumentException("Unrecognized ACE qualifier: " + qualifier.ToString(), "qualifier");
			}
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000C04E6 File Offset: 0x000BE6E6
		private void WriteGuid(Guid val, byte[] buffer, int offset)
		{
			Array.Copy(val.ToByteArray(), 0, buffer, offset, 16);
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000C04FC File Offset: 0x000BE6FC
		private Guid ReadGuid(byte[] buffer, int offset)
		{
			byte[] array = new byte[16];
			Array.Copy(buffer, offset, array, 0, 16);
			return new Guid(array);
		}

		// Token: 0x040024C4 RID: 9412
		private Guid object_ace_type;

		// Token: 0x040024C5 RID: 9413
		private Guid inherited_object_type;

		// Token: 0x040024C6 RID: 9414
		private ObjectAceFlags object_ace_flags;
	}
}
