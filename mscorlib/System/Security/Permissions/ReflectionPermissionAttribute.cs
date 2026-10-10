using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.ReflectionPermission" /> к коду с помощью декларативной безопасности.</summary>
	// Token: 0x02000452 RID: 1106
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class ReflectionPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.ReflectionPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002CDB RID: 11483 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public ReflectionPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает текущие допустимые варианты использования отражения.</summary>
		/// <returns>Одно или несколько значений <see cref="T:System.Security.Permissions.ReflectionPermissionFlag" />, объединенных с помощью битового оператора ИЛИ.</returns>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка задать этому свойству недопустимое значение. Допустимые значения см. в разделе <see cref="T:System.Security.Permissions.ReflectionPermissionFlag" />.</exception>
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x000A0F7C File Offset: 0x0009F17C
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x000A0F84 File Offset: 0x0009F184
		public ReflectionPermissionFlag Flags
		{
			get
			{
				return this.flags;
			}
			set
			{
				this.flags = value;
				this.memberAccess = ((this.flags & ReflectionPermissionFlag.MemberAccess) == ReflectionPermissionFlag.MemberAccess);
				this.reflectionEmit = ((this.flags & ReflectionPermissionFlag.ReflectionEmit) == ReflectionPermissionFlag.ReflectionEmit);
				this.typeInfo = ((this.flags & ReflectionPermissionFlag.TypeInformation) == ReflectionPermissionFlag.TypeInformation);
			}
		}

		/// <summary>Получает или задает значение, которое указывает, допускается ли вызов операций для элементов, не являющихся открытыми.</summary>
		/// <returns>Значение <see langword="true" />, если вызов операций для элементов, не являющихся открытыми, разрешен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x000A0FC0 File Offset: 0x0009F1C0
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x000A0FC8 File Offset: 0x0009F1C8
		public bool MemberAccess
		{
			get
			{
				return this.memberAccess;
			}
			set
			{
				if (value)
				{
					this.flags |= ReflectionPermissionFlag.MemberAccess;
				}
				else
				{
					this.flags -= 2;
				}
				this.memberAccess = value;
			}
		}

		/// <summary>Получает или задает значение, которое указывает, разрешено ли в <see cref="N:System.Reflection.Emit" /> использование определенных функций, таких как выпуск символов отладки.</summary>
		/// <returns>Значение <see langword="true" />, если использование соответствующих функций разрешено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000A0FF2 File Offset: 0x0009F1F2
		// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x000A0FFA File Offset: 0x0009F1FA
		[Obsolete]
		public bool ReflectionEmit
		{
			get
			{
				return this.reflectionEmit;
			}
			set
			{
				if (value)
				{
					this.flags |= ReflectionPermissionFlag.ReflectionEmit;
				}
				else
				{
					this.flags -= 4;
				}
				this.reflectionEmit = value;
			}
		}

		/// <summary>Получает или задает значение, которое указывает, допускается ли вызов с ограничениями элементов, не являющихся открытыми. Вызов с ограничениями означает, что набор разрешений сборки, содержащей вызываемый элемент, не являющийся открытым, должен быть равен набору разрешений вызывающей сборки или должен являться его подмножеством.</summary>
		/// <returns>Значение <see langword="true" />, если вызов с ограничениями элементов, не являющихся открытыми, разрешен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000A1024 File Offset: 0x0009F224
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x000A1031 File Offset: 0x0009F231
		public bool RestrictedMemberAccess
		{
			get
			{
				return (this.flags & ReflectionPermissionFlag.RestrictedMemberAccess) == ReflectionPermissionFlag.RestrictedMemberAccess;
			}
			set
			{
				if (value)
				{
					this.flags |= ReflectionPermissionFlag.RestrictedMemberAccess;
					return;
				}
				this.flags -= 8;
			}
		}

		/// <summary>Получает или задает значение, указывающее, допустимо ли отражение на невидимые элементы.</summary>
		/// <returns>Значение <see langword="true" />, если отражение на невидимые элементы допустимо; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000A1053 File Offset: 0x0009F253
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x000A105B File Offset: 0x0009F25B
		[Obsolete("not enforced in 2.0+")]
		public bool TypeInformation
		{
			get
			{
				return this.typeInfo;
			}
			set
			{
				if (value)
				{
					this.flags |= ReflectionPermissionFlag.TypeInformation;
				}
				else
				{
					this.flags--;
				}
				this.typeInfo = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.ReflectionPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.ReflectionPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002CE6 RID: 11494 RVA: 0x000A1088 File Offset: 0x0009F288
		public override IPermission CreatePermission()
		{
			ReflectionPermission result;
			if (base.Unrestricted)
			{
				result = new ReflectionPermission(PermissionState.Unrestricted);
			}
			else
			{
				result = new ReflectionPermission(this.flags);
			}
			return result;
		}

		// Token: 0x0400207B RID: 8315
		private ReflectionPermissionFlag flags;

		// Token: 0x0400207C RID: 8316
		private bool memberAccess;

		// Token: 0x0400207D RID: 8317
		private bool reflectionEmit;

		// Token: 0x0400207E RID: 8318
		private bool typeInfo;
	}
}
