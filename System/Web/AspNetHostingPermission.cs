using System;
using System.Security;
using System.Security.Permissions;

namespace System.Web
{
	/// <summary>Управляет разрешениями на доступ в средах с ASP.NET. Этот класс не наследуется.</summary>
	// Token: 0x020001E1 RID: 481
	[Serializable]
	public sealed class AspNetHostingPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Web.AspNetHostingPermission" /> с заданным уровнем разрешения.</summary>
		/// <param name="level">Значение перечисления <see cref="T:System.Web.AspNetHostingPermissionLevel" />.</param>
		// Token: 0x06000C8B RID: 3211 RVA: 0x00033404 File Offset: 0x00031604
		public AspNetHostingPermission(AspNetHostingPermissionLevel level)
		{
			this.Level = level;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Web.AspNetHostingPermission" /> с заданным значением перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Значение перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не задан ни одному из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06000C8C RID: 3212 RVA: 0x00033413 File Offset: 0x00031613
		public AspNetHostingPermission(PermissionState state)
		{
			if (PermissionHelper.CheckPermissionState(state, true) == PermissionState.Unrestricted)
			{
				this._level = AspNetHostingPermissionLevel.Unrestricted;
				return;
			}
			this._level = AspNetHostingPermissionLevel.None;
		}

		/// <summary>Получает или задает уровень разрешения текущего размещения для приложения ASP.NET.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Web.AspNetHostingPermissionLevel" />.</returns>
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00033439 File Offset: 0x00031639
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00033441 File Offset: 0x00031641
		public AspNetHostingPermissionLevel Level
		{
			get
			{
				return this._level;
			}
			set
			{
				if (value < AspNetHostingPermissionLevel.None || value > AspNetHostingPermissionLevel.Unrestricted)
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}."), value), "Level");
				}
				this._level = value;
			}
		}

		/// <summary>Возвращает значение, определяющее, позволен ли неограниченный доступ к ресурсу, защищенному текущим разрешением.</summary>
		/// <returns>Значение <see langword="true" />, если разрешено неограниченное использование ресурса, защищенного разрешением. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000C8F RID: 3215 RVA: 0x00033477 File Offset: 0x00031677
		public bool IsUnrestricted()
		{
			return this._level == AspNetHostingPermissionLevel.Unrestricted;
		}

		/// <summary>При реализации производным классом создает и возвращает идентичную копию текущего объекта разрешения.</summary>
		/// <returns>Копия текущего объекта разрешения.</returns>
		// Token: 0x06000C90 RID: 3216 RVA: 0x00033486 File Offset: 0x00031686
		public override IPermission Copy()
		{
			return new AspNetHostingPermission(this._level);
		}

		/// <summary>Восстанавливает объект разрешения с определенным состоянием из XML-кодирования.</summary>
		/// <param name="securityElement">
		///   <see cref="T:System.Security.SecurityElement" />, содержащий XML-кодирование, которое используется для восстановления объекта разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="securityElement" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.SecurityElement.Tag" /> параметра <paramref name="securityElement" /> не равно IPermission.  
		/// -или- 
		/// Класс <see cref="M:System.Security.SecurityElement.Attribute(System.String)" /> параметра <paramref name="securityElement" /> имеет значение <see langword="null" /> или равен пустой строке ("").</exception>
		// Token: 0x06000C91 RID: 3217 RVA: 0x00033494 File Offset: 0x00031694
		public override void FromXml(SecurityElement securityElement)
		{
			PermissionHelper.CheckSecurityElement(securityElement, "securityElement", 1, 1);
			if (securityElement.Tag != "IPermission")
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid tag '{0}' for permission."), securityElement.Tag), "securityElement");
			}
			if (securityElement.Attribute("version") == null)
			{
				throw new ArgumentException(Locale.GetText("Missing version attribute."), "securityElement");
			}
			if (PermissionHelper.IsUnrestricted(securityElement))
			{
				this._level = AspNetHostingPermissionLevel.Unrestricted;
				return;
			}
			string text = securityElement.Attribute("Level");
			if (text != null)
			{
				this._level = (AspNetHostingPermissionLevel)Enum.Parse(typeof(AspNetHostingPermissionLevel), text);
				return;
			}
			this._level = AspNetHostingPermissionLevel.None;
		}

		/// <summary>Создает XML-кодирование для объекта разрешения и его текущего состояния.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, который содержит XML-кодировку объекта разрешения, включающую любые сведения о состоянии.</returns>
		// Token: 0x06000C92 RID: 3218 RVA: 0x0003354C File Offset: 0x0003174C
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = PermissionHelper.Element(typeof(AspNetHostingPermission), 1);
			if (this.IsUnrestricted())
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			securityElement.AddAttribute("Level", this._level.ToString());
			return securityElement;
		}

		/// <summary>При реализации производным классом создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>
		///   <see cref="T:System.Security.IPermission" />, которое представляет пересечение текущего и заданного разрешений; в противном случае — <see langword="null" />, если пересечение пусто.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является классом <see cref="T:System.Web.AspNetHostingPermission" />.</exception>
		// Token: 0x06000C93 RID: 3219 RVA: 0x000335A0 File Offset: 0x000317A0
		public override IPermission Intersect(IPermission target)
		{
			AspNetHostingPermission aspNetHostingPermission = this.Cast(target);
			if (aspNetHostingPermission == null)
			{
				return null;
			}
			return new AspNetHostingPermission((this._level <= aspNetHostingPermission.Level) ? this._level : aspNetHostingPermission.Level);
		}

		/// <summary>Возвращает значение, определяющее, является ли текущее разрешение подмножеством заданного разрешения.</summary>
		/// <param name="target">Разрешение <see cref="T:System.Security.IPermission" />, используемое в сочетании с текущим разрешением. Оно должно быть того же типа, что и текущее разрешение <see cref="T:System.Security.IPermission" />.</param>
		/// <returns>
		///   <see langword="true" />, если текущее разрешение <see cref="T:System.Security.IPermission" /> является подмножеством заданного разрешения <see cref="T:System.Security.IPermission" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является классом <see cref="T:System.Web.AspNetHostingPermission" />.</exception>
		// Token: 0x06000C94 RID: 3220 RVA: 0x000335DC File Offset: 0x000317DC
		public override bool IsSubsetOf(IPermission target)
		{
			AspNetHostingPermission aspNetHostingPermission = this.Cast(target);
			if (aspNetHostingPermission == null)
			{
				return this.IsEmpty();
			}
			return this._level <= aspNetHostingPermission._level;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Разрешение <see cref="T:System.Security.IPermission" />, представляющее собой объединение текущего и заданного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является классом <see cref="T:System.Web.AspNetHostingPermission" />.</exception>
		// Token: 0x06000C95 RID: 3221 RVA: 0x0003360C File Offset: 0x0003180C
		public override IPermission Union(IPermission target)
		{
			AspNetHostingPermission aspNetHostingPermission = this.Cast(target);
			if (aspNetHostingPermission == null)
			{
				return this.Copy();
			}
			return new AspNetHostingPermission((this._level > aspNetHostingPermission.Level) ? this._level : aspNetHostingPermission.Level);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0003364C File Offset: 0x0003184C
		private bool IsEmpty()
		{
			return this._level == AspNetHostingPermissionLevel.None;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00033658 File Offset: 0x00031858
		private AspNetHostingPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			AspNetHostingPermission aspNetHostingPermission = target as AspNetHostingPermission;
			if (aspNetHostingPermission == null)
			{
				PermissionHelper.ThrowInvalidPermission(target, typeof(AspNetHostingPermission));
			}
			return aspNetHostingPermission;
		}

		// Token: 0x040007C0 RID: 1984
		private const int version = 1;

		// Token: 0x040007C1 RID: 1985
		private AspNetHostingPermissionLevel _level;
	}
}
