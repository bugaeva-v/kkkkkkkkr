using System;
using Unity;

namespace System.Security.Permissions
{
	/// <summary>Определяет флаги разрешения, применяющиеся к объекту <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x0200087C RID: 2172
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class TypeDescriptorPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.TypeDescriptorPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x060044C3 RID: 17603 RVA: 0x00003917 File Offset: 0x00001B17
		public TypeDescriptorPermissionAttribute(SecurityAction action)
		{
		}

		/// <summary>Возвращает или задает <see cref="T:System.Security.Permissions.TypeDescriptorPermissionFlags" /> для объекта <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.TypeDescriptorPermissionFlags" /> для <see cref="T:System.ComponentModel.TypeDescriptor" />.</returns>
		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x000ED20C File Offset: 0x000EB40C
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x00003917 File Offset: 0x00001B17
		public TypeDescriptorPermissionFlags Flags
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return TypeDescriptorPermissionFlags.NoFlags;
			}
			set
			{
			}
		}

		/// <summary>Получает или задает значение, указывающее, может ли дескриптор типа вызываться из частично доверенного кода.</summary>
		/// <returns>Значение <see langword="true" />, если к дескриптору типа может быть осуществлен доступ из частично доверенного кода; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x000ED228 File Offset: 0x000EB428
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x00003917 File Offset: 0x00001B17
		public bool RestrictedRegistrationAccess
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
			set
			{
			}
		}

		/// <summary>При переопределении в производном классе создает объект разрешения, который затем можно сериализовать в двоичную форму и постоянно хранить вместе с <see cref="T:System.Security.Permissions.SecurityAction" /> в метаданных сборки.</summary>
		/// <returns>Сериализуемый объект разрешения.</returns>
		// Token: 0x060044C8 RID: 17608 RVA: 0x00032884 File Offset: 0x00030A84
		public override IPermission CreatePermission()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
