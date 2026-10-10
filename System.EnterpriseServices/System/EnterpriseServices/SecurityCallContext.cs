using System;

namespace System.EnterpriseServices
{
	/// <summary>Описывает цепочку вызывающих объектов, приводящих к вызову текущего метода.</summary>
	// Token: 0x02000042 RID: 66
	public sealed class SecurityCallContext
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x000021E0 File Offset: 0x000003E0
		internal SecurityCallContext()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000021E0 File Offset: 0x000003E0
		internal SecurityCallContext(ISecurityCallContext context)
		{
		}

		/// <summary>Возвращает объект <see cref="T:System.EnterpriseServices.SecurityCallers" />, который описывает вызывающий объект.</summary>
		/// <returns>Объект <see cref="T:System.EnterpriseServices.SecurityCallers" />, описывающий вызывающий объект.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Контекст безопасности отсутствует.</exception>
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002085 File Offset: 0x00000285
		public SecurityCallers Callers
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.EnterpriseServices.SecurityCallContext" />, описывающий контекст вызова безопасности.</summary>
		/// <returns>Объект <see cref="T:System.EnterpriseServices.SecurityCallContext" />, описывающий контекст вызова безопасности.</returns>
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002085 File Offset: 0x00000285
		public static SecurityCallContext CurrentCall
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.EnterpriseServices.SecurityIdentity" />, описывающий непосредственный вызывающий объект для этого метода.</summary>
		/// <returns>Значение <see cref="T:System.EnterpriseServices.SecurityIdentity" />.</returns>
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002085 File Offset: 0x00000285
		public SecurityIdentity DirectCaller
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Определяет, включена ли в текущем контексте проверка безопасности.</summary>
		/// <returns>Значение <see langword="true" />, если проверка безопасности в текущем контексте включена; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002085 File Offset: 0x00000285
		public bool IsSecurityEnabled
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение <see langword="MinAuthenticationLevel" /> из коллекции <see langword="ISecurityCallContext" /> в COM+.</summary>
		/// <returns>Значение <see langword="MinAuthenticationLevel" /> из коллекции <see langword="ISecurityCallContext" /> в COM+.</returns>
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002085 File Offset: 0x00000285
		public int MinAuthenticationLevel
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение <see langword="NumCallers" /> из коллекции <see langword="ISecurityCallContext" /> в COM+.</summary>
		/// <returns>Значение <see langword="NumCallers" /> из коллекции <see langword="ISecurityCallContext" /> в COM+.</returns>
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002085 File Offset: 0x00000285
		public int NumCallers
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.EnterpriseServices.SecurityIdentity" />, который описывает исходный вызывающий объект.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.EnterpriseServices.SecurityIdentity" />.</returns>
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002085 File Offset: 0x00000285
		public SecurityIdentity OriginalCaller
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Проверяет, является ли непосредственный вызывающий объект членом указанной роли.</summary>
		/// <param name="role">Указанная роль.</param>
		/// <returns>Значение <see langword="true" />, если непосредственный вызывающий оператор является членом указанной роли; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000EC RID: 236 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool IsCallerInRole(string role)
		{
			throw new NotImplementedException();
		}

		/// <summary>Проверяет, принадлежит ли заданный пользователь указанной роли.</summary>
		/// <param name="user">Заданный пользователь.</param>
		/// <param name="role">Указанная роль.</param>
		/// <returns>Значение <see langword="true" />, если заданный пользователь является членом указанной роли; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000ED RID: 237 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool IsUserInRole(string user, string role)
		{
			throw new NotImplementedException();
		}
	}
}
