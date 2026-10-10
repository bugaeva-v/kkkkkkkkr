using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Подтверждает, что сборка кода принадлежит к глобальному кэшу сборок, используемому в качестве свидетельства для оценки политики. Этот класс не наследуется.</summary>
	// Token: 0x02000410 RID: 1040
	[ComVisible(true)]
	[Serializable]
	public sealed class GacInstalled : EvidenceBase, IIdentityPermissionFactory, IBuiltInEvidence
	{
		/// <summary>Создает эквивалентную копию текущего объекта.</summary>
		/// <returns>Эквивалентная копия <see cref="T:System.Security.Policy.GacInstalled" />.</returns>
		// Token: 0x06002A8A RID: 10890 RVA: 0x0009A07F File Offset: 0x0009827F
		public object Copy()
		{
			return new GacInstalled();
		}

		/// <summary>Создает новое разрешение идентификации, соответствующее текущему объекту.</summary>
		/// <param name="evidence">Объект <see cref="T:System.Security.Policy.Evidence" />, из которого создается разрешение идентификации.</param>
		/// <returns>новое разрешение идентификации, соответствующее текущему объекту.</returns>
		// Token: 0x06002A8B RID: 10891 RVA: 0x0009A086 File Offset: 0x00098286
		public IPermission CreateIdentityPermission(Evidence evidence)
		{
			return new GacIdentityPermission();
		}

		/// <summary>Указывает, эквивалентен ли текущий объект заданному объекту.</summary>
		/// <param name="o">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="o" /> является объектом <see cref="T:System.Security.Policy.GacInstalled" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002A8C RID: 10892 RVA: 0x0009A08D File Offset: 0x0009828D
		public override bool Equals(object o)
		{
			return o != null && o is GacInstalled;
		}

		/// <summary>Возвращает хэш-код для текущего объекта.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x06002A8D RID: 10893 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Возвращает строковое представление текущего объекта.</summary>
		/// <returns>Строковое представление текущего объекта.</returns>
		// Token: 0x06002A8E RID: 10894 RVA: 0x0009A09D File Offset: 0x0009829D
		public override string ToString()
		{
			SecurityElement securityElement = new SecurityElement(base.GetType().FullName);
			securityElement.AddAttribute("version", "1");
			return securityElement.ToString();
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000040F7 File Offset: 0x000022F7
		int IBuiltInEvidence.GetRequiredSize(bool verbose)
		{
			return 1;
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x0008868F File Offset: 0x0008688F
		int IBuiltInEvidence.InitFromBuffer(char[] buffer, int position)
		{
			return position;
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0009A0C4 File Offset: 0x000982C4
		int IBuiltInEvidence.OutputToBuffer(char[] buffer, int position, bool verbose)
		{
			buffer[position] = '\t';
			return position + 1;
		}
	}
}
