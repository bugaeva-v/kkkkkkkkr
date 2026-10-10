using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using Mono.Security.Cryptography;
using Mono.Xml;

namespace System.Security.Permissions
{
	/// <summary>Позволяет применять действия по обеспечению безопасности для объекта <see cref="T:System.Security.PermissionSet" /> к коду, использующему декларативную безопасность. Этот класс не наследуется.</summary>
	// Token: 0x0200044B RID: 1099
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class PermissionSetAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Security.Permissions.PermissionSetAttribute" /> с заданным действием по обеспечению безопасности.</summary>
		/// <param name="action">Одно из значений перечисления, задающее действие безопасности.</param>
		// Token: 0x06002C8D RID: 11405 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public PermissionSetAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает файл, содержащий XML-представление пользовательского набора разрешений для объявления.</summary>
		/// <returns>Физический путь к файлу, содержащему XML-представление набора разрешений.</returns>
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x0009FD38 File Offset: 0x0009DF38
		// (set) Token: 0x06002C8F RID: 11407 RVA: 0x0009FD40 File Offset: 0x0009DF40
		public string File
		{
			get
			{
				return this.file;
			}
			set
			{
				this.file = value;
			}
		}

		/// <summary>Получает или задает шестнадцатеричное представление набора разрешений в XML-кодировке.</summary>
		/// <returns>Шестнадцатеричное представление набора разрешений в XML-кодировке.</returns>
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x0009FD49 File Offset: 0x0009DF49
		// (set) Token: 0x06002C91 RID: 11409 RVA: 0x0009FD51 File Offset: 0x0009DF51
		public string Hex
		{
			get
			{
				return this.hex;
			}
			set
			{
				this.hex = value;
			}
		}

		/// <summary>Получает или задает имя набора разрешений.</summary>
		/// <returns>Имя неизменяемого объекта <see cref="T:System.Security.NamedPermissionSet" /> (один из нескольких наборов разрешений, которые содержатся в политике по умолчанию и не могут быть изменены).</returns>
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x0009FD5A File Offset: 0x0009DF5A
		// (set) Token: 0x06002C93 RID: 11411 RVA: 0x0009FD62 File Offset: 0x0009DF62
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Получает или задает значение, позволяющее определить кодировку файла, указанного с помощью <see cref="P:System.Security.Permissions.PermissionSetAttribute.File" />, — Юникод или ASCII.</summary>
		/// <returns>Значение <see langword="true" />, если файл закодирован с использованием Юникода; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x0009FD6B File Offset: 0x0009DF6B
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x0009FD73 File Offset: 0x0009DF73
		public bool UnicodeEncoded
		{
			get
			{
				return this.isUnicodeEncoded;
			}
			set
			{
				this.isUnicodeEncoded = value;
			}
		}

		/// <summary>Получает или задает XML-представление набора разрешений.</summary>
		/// <returns>XML-представление набора разрешений.</returns>
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x0009FD7C File Offset: 0x0009DF7C
		// (set) Token: 0x06002C97 RID: 11415 RVA: 0x0009FD84 File Offset: 0x0009DF84
		public string XML
		{
			get
			{
				return this.xml;
			}
			set
			{
				this.xml = value;
			}
		}

		/// <summary>Этот метод не используется.</summary>
		/// <returns>Пустая ссылка (<see langword="nothing" /> в Visual Basic) во всех случаях.</returns>
		// Token: 0x06002C98 RID: 11416 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override IPermission CreatePermission()
		{
			return null;
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x0009FD90 File Offset: 0x0009DF90
		private PermissionSet CreateFromXml(string xml)
		{
			SecurityParser securityParser = new SecurityParser();
			try
			{
				securityParser.LoadXml(xml);
			}
			catch (SmallXmlParserException ex)
			{
				throw new XmlSyntaxException(ex.Line, ex.ToString());
			}
			SecurityElement securityElement = securityParser.ToXml();
			string text = securityElement.Attribute("class");
			if (text == null)
			{
				return null;
			}
			PermissionState state = PermissionState.None;
			if (CodeAccessPermission.IsUnrestricted(securityElement))
			{
				state = PermissionState.Unrestricted;
			}
			if (text.EndsWith("NamedPermissionSet"))
			{
				NamedPermissionSet namedPermissionSet = new NamedPermissionSet(securityElement.Attribute("Name"), state);
				namedPermissionSet.FromXml(securityElement);
				return namedPermissionSet;
			}
			if (text.EndsWith("PermissionSet"))
			{
				PermissionSet permissionSet = new PermissionSet(state);
				permissionSet.FromXml(securityElement);
				return permissionSet;
			}
			return null;
		}

		/// <summary>Создает и возвращает новый набор разрешений на основе данного объекта атрибута набора разрешений.</summary>
		/// <returns>Новый набор разрешений</returns>
		// Token: 0x06002C9A RID: 11418 RVA: 0x0009FE38 File Offset: 0x0009E038
		public PermissionSet CreatePermissionSet()
		{
			PermissionSet result = null;
			if (base.Unrestricted)
			{
				result = new PermissionSet(PermissionState.Unrestricted);
			}
			else
			{
				result = new PermissionSet(PermissionState.None);
				if (this.name != null)
				{
					return PolicyLevel.CreateAppDomainLevel().GetNamedPermissionSet(this.name);
				}
				if (this.file != null)
				{
					Encoding encoding = this.isUnicodeEncoded ? Encoding.Unicode : Encoding.ASCII;
					using (StreamReader streamReader = new StreamReader(this.file, encoding))
					{
						return this.CreateFromXml(streamReader.ReadToEnd());
					}
				}
				if (this.xml != null)
				{
					result = this.CreateFromXml(this.xml);
				}
				else if (this.hex != null)
				{
					Encoding ascii = Encoding.ASCII;
					byte[] array = CryptoConvert.FromHex(this.hex);
					result = this.CreateFromXml(ascii.GetString(array, 0, array.Length));
				}
			}
			return result;
		}

		// Token: 0x04002067 RID: 8295
		private string file;

		// Token: 0x04002068 RID: 8296
		private string name;

		// Token: 0x04002069 RID: 8297
		private bool isUnicodeEncoded;

		// Token: 0x0400206A RID: 8298
		private string xml;

		// Token: 0x0400206B RID: 8299
		private string hex;
	}
}
