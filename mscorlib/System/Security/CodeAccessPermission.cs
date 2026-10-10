using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security
{
	/// <summary>Определяет базовую структуру всех разрешений доступа к коду.</summary>
	// Token: 0x020003DD RID: 989
	[MonoTODO("CAS support is experimental (and unsupported).")]
	[ComVisible(true)]
	[SecurityPermission(SecurityAction.InheritanceDemand, ControlEvidence = true, ControlPolicy = true)]
	[Serializable]
	public abstract class CodeAccessPermission : IPermission, ISecurityEncodable, IStackWalk
	{
		/// <summary>Объявляет, что вызывающий код может получить доступ к ресурсу, защищенному требованием разрешения, через код, вызывающий этот метод, даже если вызывающим объектам выше в стеке вызовов не предоставлено разрешение на доступ к ресурсу. <see cref="M:System.Security.CodeAccessPermission.Assert" /> может вызвать проблемы системы безопасности.</summary>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего кода отсутствует <see cref="F:System.Security.Permissions.SecurityPermissionFlag.Assertion" />.  
		///
		/// или - 
		/// Уже имеется активное утверждение <see cref="M:System.Security.CodeAccessPermission.Assert" /> для текущего кадра.</exception>
		// Token: 0x0600288C RID: 10380 RVA: 0x00093078 File Offset: 0x00091278
		[SecuritySafeCritical]
		[MonoTODO("CAS support is experimental (and unsupported). Imperative mode is not implemented.")]
		public void Assert()
		{
			new PermissionSet(this).Assert();
		}

		/// <summary>При реализации производным классом создает и возвращает идентичную копию текущего объекта разрешения.</summary>
		/// <returns>Копия текущего объекта разрешения.</returns>
		// Token: 0x0600288D RID: 10381
		public abstract IPermission Copy();

		/// <summary>Принудительно создает <see cref="T:System.Security.SecurityException" /> во время выполнения, если все вызывающие методы, расположенные выше в стеке вызовов, не получили разрешения, указанного текущим экземпляром.</summary>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий метод, расположенный выше в стеке вызовов, не имеет разрешения, указанного текущим экземпляром.  
		/// -или- 
		/// Вызывающий метод, расположенный выше в стеке вызовов, вызвал <see cref="M:System.Security.CodeAccessPermission.Deny" /> в текущем объекте разрешений.</exception>
		// Token: 0x0600288E RID: 10382 RVA: 0x00093085 File Offset: 0x00091285
		[SecuritySafeCritical]
		public void Demand()
		{
			if (!SecurityManager.SecurityEnabled)
			{
				return;
			}
			new PermissionSet(this).CasOnlyDemand(3);
		}

		/// <summary>Запрещает вызывающим объектам выше в стеке вызовов использовать код, который вызывает этот метод для доступа к ресурсу, указанному текущим экземпляром.</summary>
		/// <exception cref="T:System.Security.SecurityException">Уже имеется активное утверждение <see cref="M:System.Security.CodeAccessPermission.Deny" /> для текущего кадра.</exception>
		// Token: 0x0600288F RID: 10383 RVA: 0x0009309B File Offset: 0x0009129B
		[Obsolete("Deny is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
		[MonoTODO("CAS support is experimental (and unsupported). Imperative mode is not implemented.")]
		[SecuritySafeCritical]
		public void Deny()
		{
			new PermissionSet(this).Deny();
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Security.CodeAccessPermission" /> текущему объекту <see cref="T:System.Security.CodeAccessPermission" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Security.CodeAccessPermission" />, который требуется сравнить с текущим объектом <see cref="T:System.Security.CodeAccessPermission" />.</param>
		/// <returns>Значение <see langword="true" />, если заданный объект <see cref="T:System.Security.CodeAccessPermission" /> равен текущему объекту <see cref="T:System.Security.CodeAccessPermission" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002890 RID: 10384 RVA: 0x000930A8 File Offset: 0x000912A8
		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != base.GetType())
			{
				return false;
			}
			CodeAccessPermission codeAccessPermission = obj as CodeAccessPermission;
			return this.IsSubsetOf(codeAccessPermission) && codeAccessPermission.IsSubsetOf(this);
		}

		/// <summary>Если переопределено в производном классе, восстанавливает объект безопасности с заданным состоянием из данных в формате XML.</summary>
		/// <param name="elem">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="elem" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="elem" /> не содержит кодировку XML для экземпляра того же типа, что и текущий экземпляр.  
		/// -или- 
		/// Номер версии параметра <paramref name="elem" /> не поддерживается.</exception>
		// Token: 0x06002891 RID: 10385
		public abstract void FromXml(SecurityElement elem);

		/// <summary>Возвращает хэш-код для объекта <see cref="T:System.Security.CodeAccessPermission" />, который можно использовать в алгоритмах хэширования и структурах данных, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Security.CodeAccessPermission" />.</returns>
		// Token: 0x06002892 RID: 10386 RVA: 0x000930E8 File Offset: 0x000912E8
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>При реализации производным классом создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и не является экземпляром того же класса, что и текущее разрешение.</exception>
		// Token: 0x06002893 RID: 10387
		public abstract IPermission Intersect(IPermission target);

		/// <summary>Когда реализован производным классом, определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002894 RID: 10388
		public abstract bool IsSubsetOf(IPermission target);

		/// <summary>Создает и возвращает строковое представление текущего объекта разрешения.</summary>
		/// <returns>Строковое представление текущего объекта разрешения.</returns>
		// Token: 0x06002895 RID: 10389 RVA: 0x000930F0 File Offset: 0x000912F0
		public override string ToString()
		{
			return this.ToXml().ToString();
		}

		/// <summary>При переопределении в производном классе создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002896 RID: 10390
		public abstract SecurityElement ToXml();

		/// <summary>При переопределении в производном классе создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="other">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="other" /> не является <see langword="null" />. Метод поддерживается на этом уровне только при передаче <see langword="null" />.</exception>
		// Token: 0x06002897 RID: 10391 RVA: 0x000930FD File Offset: 0x000912FD
		public virtual IPermission Union(IPermission other)
		{
			if (other != null)
			{
				throw new NotSupportedException();
			}
			return null;
		}

		/// <summary>Запрещает вызывающим объектам выше в стеке вызовов использовать код, который вызывает этот метод для доступа ко всем ресурсам, за исключением ресурса, указанного текущим экземпляром.</summary>
		/// <exception cref="T:System.Security.SecurityException">Уже имеется активное утверждение <see cref="M:System.Security.CodeAccessPermission.PermitOnly" /> для текущего кадра.</exception>
		// Token: 0x06002898 RID: 10392 RVA: 0x00093109 File Offset: 0x00091309
		[SecuritySafeCritical]
		[MonoTODO("CAS support is experimental (and unsupported). Imperative mode is not implemented.")]
		public void PermitOnly()
		{
			new PermissionSet(this).PermitOnly();
		}

		/// <summary>Приводит к удалению и выводу из действия всех предыдущих переопределений для текущего кадра.</summary>
		/// <exception cref="T:System.InvalidOperationException">Предыдущие значения <see cref="M:System.Security.CodeAccessPermission.Assert" />, <see cref="M:System.Security.CodeAccessPermission.Deny" /> или <see cref="M:System.Security.CodeAccessPermission.PermitOnly" /> для текущего кадра отсутствуют.</exception>
		// Token: 0x06002899 RID: 10393 RVA: 0x00093116 File Offset: 0x00091316
		[MonoTODO("CAS support is experimental (and unsupported). Imperative mode is not implemented.")]
		public static void RevertAll()
		{
			if (!SecurityManager.SecurityEnabled)
			{
				return;
			}
			throw new NotImplementedException();
		}

		/// <summary>Приводит к удалению и выводу из действия всех предыдущих значений <see cref="M:System.Security.CodeAccessPermission.Assert" /> для текущего кадра.</summary>
		/// <exception cref="T:System.InvalidOperationException">Предыдущие значения <see cref="M:System.Security.CodeAccessPermission.Assert" /> для текущего кадра отсутствуют.</exception>
		// Token: 0x0600289A RID: 10394 RVA: 0x00093116 File Offset: 0x00091316
		[MonoTODO("CAS support is experimental (and unsupported). Imperative mode is not implemented.")]
		public static void RevertAssert()
		{
			if (!SecurityManager.SecurityEnabled)
			{
				return;
			}
			throw new NotImplementedException();
		}

		/// <summary>Приводит к удалению и выводу из действия всех предыдущих значений <see cref="M:System.Security.CodeAccessPermission.Deny" /> для текущего кадра.</summary>
		/// <exception cref="T:System.InvalidOperationException">Предыдущие значения <see cref="M:System.Security.CodeAccessPermission.Deny" /> для текущего кадра отсутствуют.</exception>
		// Token: 0x0600289B RID: 10395 RVA: 0x00093116 File Offset: 0x00091316
		[MonoTODO("CAS support is experimental (and unsupported). Imperative mode is not implemented.")]
		public static void RevertDeny()
		{
			if (!SecurityManager.SecurityEnabled)
			{
				return;
			}
			throw new NotImplementedException();
		}

		/// <summary>Приводит к удалению и выводу из действия всех предыдущих значений <see cref="M:System.Security.CodeAccessPermission.PermitOnly" /> для текущего кадра.</summary>
		/// <exception cref="T:System.InvalidOperationException">Предыдущие значения <see cref="M:System.Security.CodeAccessPermission.PermitOnly" /> для текущего кадра отсутствуют.</exception>
		// Token: 0x0600289C RID: 10396 RVA: 0x00093116 File Offset: 0x00091316
		[MonoTODO("CAS support is experimental (and unsupported). Imperative mode is not implemented.")]
		public static void RevertPermitOnly()
		{
			if (!SecurityManager.SecurityEnabled)
			{
				return;
			}
			throw new NotImplementedException();
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x00093128 File Offset: 0x00091328
		internal SecurityElement Element(int version)
		{
			SecurityElement securityElement = new SecurityElement("IPermission");
			Type type = base.GetType();
			securityElement.AddAttribute("class", type.FullName + ", " + type.Assembly.ToString().Replace('"', '\''));
			securityElement.AddAttribute("version", version.ToString());
			return securityElement;
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00093187 File Offset: 0x00091387
		internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted)
		{
			if (state != PermissionState.None && state != PermissionState.Unrestricted)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), state), "state");
			}
			return state;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x000931B4 File Offset: 0x000913B4
		internal static int CheckSecurityElement(SecurityElement se, string parameterName, int minimumVersion, int maximumVersion)
		{
			if (se == null)
			{
				throw new ArgumentNullException(parameterName);
			}
			if (se.Tag != "IPermission")
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid tag {0}"), se.Tag), parameterName);
			}
			int num = minimumVersion;
			string text = se.Attribute("version");
			if (text != null)
			{
				try
				{
					num = int.Parse(text);
				}
				catch (Exception innerException)
				{
					throw new ArgumentException(string.Format(Locale.GetText("Couldn't parse version from '{0}'."), text), parameterName, innerException);
				}
			}
			if (num < minimumVersion || num > maximumVersion)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Unknown version '{0}', expected versions between ['{1}','{2}']."), num, minimumVersion, maximumVersion), parameterName);
			}
			return num;
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00093270 File Offset: 0x00091470
		internal static bool IsUnrestricted(SecurityElement se)
		{
			string text = se.Attribute("Unrestricted");
			return text != null && string.Compare(text, bool.TrueString, true, CultureInfo.InvariantCulture) == 0;
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000932A2 File Offset: 0x000914A2
		internal static void ThrowInvalidPermission(IPermission target, Type expected)
		{
			throw new ArgumentException(string.Format(Locale.GetText("Invalid permission type '{0}', expected type '{1}'."), target.GetType(), expected), "target");
		}
	}
}
