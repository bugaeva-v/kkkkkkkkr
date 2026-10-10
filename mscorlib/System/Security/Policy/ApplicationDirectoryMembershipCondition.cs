using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Mono.Security;

namespace System.Security.Policy
{
	/// <summary>Определяет принадлежность сборки к группе кода путем проверки ее каталога приложения. Этот класс не наследуется.</summary>
	// Token: 0x02000400 RID: 1024
	[ComVisible(true)]
	[Serializable]
	public sealed class ApplicationDirectoryMembershipCondition : IConstantMembershipCondition, IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable
	{
		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Набор свидетельств, в отношении которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060029DB RID: 10715 RVA: 0x00097FF8 File Offset: 0x000961F8
		public bool Check(Evidence evidence)
		{
			if (evidence == null)
			{
				return false;
			}
			string codeBase = Assembly.GetCallingAssembly().CodeBase;
			Uri uri = new Uri(codeBase);
			Url url = new Url(codeBase);
			bool flag = false;
			bool flag2 = false;
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				object obj = hostEnumerator.Current;
				if (!flag && obj is ApplicationDirectory)
				{
					string directory = (obj as ApplicationDirectory).Directory;
					flag = (string.Compare(directory, 0, uri.ToString(), 0, directory.Length, true, CultureInfo.InvariantCulture) == 0);
				}
				else if (!flag2 && obj is Url)
				{
					flag2 = url.Equals(obj);
				}
				if (flag && flag2)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новая, идентичная копия текущего условия членства.</returns>
		// Token: 0x060029DC RID: 10716 RVA: 0x0009809A File Offset: 0x0009629A
		public IMembershipCondition Copy()
		{
			return new ApplicationDirectoryMembershipCondition();
		}

		/// <summary>Определяет, является ли указанное условие членства экземпляром класса <see cref="T:System.Security.Policy.ApplicationDirectoryMembershipCondition" />.</summary>
		/// <param name="o">Объект, который необходимо сравнить с объектом <see cref="T:System.Security.Policy.ApplicationDirectoryMembershipCondition" />.</param>
		/// <returns>Значение <see langword="true" />, если указанное условие членства является экземпляром <see cref="T:System.Security.Policy.ApplicationDirectoryMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060029DD RID: 10717 RVA: 0x000980A1 File Offset: 0x000962A1
		public override bool Equals(object o)
		{
			return o is ApplicationDirectoryMembershipCondition;
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства каталога приложения.</exception>
		// Token: 0x060029DE RID: 10718 RVA: 0x000980AC File Offset: 0x000962AC
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст уровня политики, используемый для разрешения ссылок на именованные наборы разрешений.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства каталога приложения.</exception>
		// Token: 0x060029DF RID: 10719 RVA: 0x000980B6 File Offset: 0x000962B6
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			MembershipConditionHelper.CheckSecurityElement(e, "e", this.version, this.version);
		}

		/// <summary>Получает хэш-код для текущего условия членства.</summary>
		/// <returns>Хэш-код для текущего условия членства.</returns>
		// Token: 0x060029E0 RID: 10720 RVA: 0x000980D0 File Offset: 0x000962D0
		public override int GetHashCode()
		{
			return typeof(ApplicationDirectoryMembershipCondition).GetHashCode();
		}

		/// <summary>Создает и возвращает строковое представление условия членства.</summary>
		/// <returns>Строковое представление состояния условия членства.</returns>
		// Token: 0x060029E1 RID: 10721 RVA: 0x000980E1 File Offset: 0x000962E1
		public override string ToString()
		{
			return "ApplicationDirectory";
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x060029E2 RID: 10722 RVA: 0x000980E8 File Offset: 0x000962E8
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния с заданным <see cref="T:System.Security.Policy.PolicyLevel" />.</summary>
		/// <param name="level">Контекст уровня политики для разрешения ссылок на именованные наборы разрешений.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x060029E3 RID: 10723 RVA: 0x000980F1 File Offset: 0x000962F1
		public SecurityElement ToXml(PolicyLevel level)
		{
			return MembershipConditionHelper.Element(typeof(ApplicationDirectoryMembershipCondition), this.version);
		}

		// Token: 0x04001F54 RID: 8020
		private readonly int version = 1;
	}
}
