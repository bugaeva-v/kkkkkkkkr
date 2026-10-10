using System;

namespace System.Security.Claims
{
	/// <summary>Определяет константы для хорошо известных типов утверждений, которые могут быть назначены субъекту. Этот класс не наследуется.</summary>
	// Token: 0x020004EF RID: 1263
	public static class ClaimTypes
	{
		// Token: 0x04002348 RID: 9032
		internal const string ClaimTypeNamespace = "http://schemas.microsoft.com/ws/2008/06/identity/claims";

		/// <summary>URI для утверждения, указывающего момент, когда сущность прошла проверку подлинности; http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.</summary>
		// Token: 0x04002349 RID: 9033
		public const string AuthenticationInstant = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant";

		/// <summary>URI для утверждения, указывающего метод, с помощью которого сущность прошла проверку подлинности; http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.</summary>
		// Token: 0x0400234A RID: 9034
		public const string AuthenticationMethod = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod";

		/// <summary>URI для утверждения, указывающего путь к файлу cookie; http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath.</summary>
		// Token: 0x0400234B RID: 9035
		public const string CookiePath = "http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath";

		/// <summary>URI для утверждения, указывающего основной идентификатор безопасности "только запрет"; http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid. SID "только запрет" запрещает указанному утверждению доступ к защищаемому объекту.</summary>
		// Token: 0x0400234C RID: 9036
		public const string DenyOnlyPrimarySid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid";

		/// <summary>URI для утверждения, указывающего основной групповой идентификатор безопасности "только запрет"; http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid. SID "только запрет" запрещает указанному утверждению доступ к защищаемому объекту.</summary>
		// Token: 0x0400234D RID: 9037
		public const string DenyOnlyPrimaryGroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup.</summary>
		// Token: 0x0400234E RID: 9038
		public const string DenyOnlyWindowsDeviceGroup = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.</summary>
		// Token: 0x0400234F RID: 9039
		public const string Dsa = "http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.</summary>
		// Token: 0x04002350 RID: 9040
		public const string Expiration = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.</summary>
		// Token: 0x04002351 RID: 9041
		public const string Expired = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expired";

		/// <summary>URI для утверждения, указывающего идентификатор безопасности для группы сущности, http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid.</summary>
		// Token: 0x04002352 RID: 9042
		public const string GroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.</summary>
		// Token: 0x04002353 RID: 9043
		public const string IsPersistent = "http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent";

		/// <summary>URI для утверждения, указывающего основной групповой идентификатор безопасности для сущности, http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid.</summary>
		// Token: 0x04002354 RID: 9044
		public const string PrimaryGroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid";

		/// <summary>URI для утверждения, указывающего основной идентификатор безопасности для сущности, http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid.</summary>
		// Token: 0x04002355 RID: 9045
		public const string PrimarySid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid";

		/// <summary>URI для утверждения, указывающего роль сущности, http://schemas.microsoft.com/ws/2008/06/identity/claims/role.</summary>
		// Token: 0x04002356 RID: 9046
		public const string Role = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";

		/// <summary>URI для утверждения, указывающего серийный номер, http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber.</summary>
		// Token: 0x04002357 RID: 9047
		public const string SerialNumber = "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata.</summary>
		// Token: 0x04002358 RID: 9048
		public const string UserData = "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/version.</summary>
		// Token: 0x04002359 RID: 9049
		public const string Version = "http://schemas.microsoft.com/ws/2008/06/identity/claims/version";

		/// <summary>URI для утверждения, указывающего имя учетной записи домена Windows, http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname.</summary>
		// Token: 0x0400235A RID: 9050
		public const string WindowsAccountName = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.</summary>
		// Token: 0x0400235B RID: 9051
		public const string WindowsDeviceClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup.</summary>
		// Token: 0x0400235C RID: 9052
		public const string WindowsDeviceGroup = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.</summary>
		// Token: 0x0400235D RID: 9053
		public const string WindowsUserClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.</summary>
		// Token: 0x0400235E RID: 9054
		public const string WindowsFqbnVersion = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion";

		/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.</summary>
		// Token: 0x0400235F RID: 9055
		public const string WindowsSubAuthority = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority";

		// Token: 0x04002360 RID: 9056
		internal const string ClaimType2005Namespace = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims";

		/// <summary>URI для утверждения, указывающего анонимного пользователя; http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous.</summary>
		// Token: 0x04002361 RID: 9057
		public const string Anonymous = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous";

		/// <summary>URI для утверждения, указывающего, прошло ли удостоверение проверку подлинности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated.</summary>
		// Token: 0x04002362 RID: 9058
		public const string Authentication = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authentication";

		/// <summary>URI для утверждения, указывающего решение об авторизации сущности; http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision.</summary>
		// Token: 0x04002363 RID: 9059
		public const string AuthorizationDecision = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision";

		/// <summary>URI для утверждения, указывающего страну или регион, где находится сущность, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.</summary>
		// Token: 0x04002364 RID: 9060
		public const string Country = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country";

		/// <summary>URI для утверждения, указывающего дату рождения сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.</summary>
		// Token: 0x04002365 RID: 9061
		public const string DateOfBirth = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth";

		/// <summary>URI для утверждения, которое указывает DNS-имя, связанное с именем компьютера или с альтернативным именем субъекта или издателя сертификата X.509, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns.</summary>
		// Token: 0x04002366 RID: 9062
		public const string Dns = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns";

		/// <summary>URI для утверждения, указывающего идентификатор безопасности (SID) "только запрет" для сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid. SID "только запрет" запрещает указанному утверждению доступ к защищаемому объекту.</summary>
		// Token: 0x04002367 RID: 9063
		public const string DenyOnlySid = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid";

		/// <summary>URI для утверждения, указывающего адреса электронной почты сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress.</summary>
		// Token: 0x04002368 RID: 9064
		public const string Email = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";

		/// <summary>URI для утверждения, указывающего пол сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender.</summary>
		// Token: 0x04002369 RID: 9065
		public const string Gender = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender";

		/// <summary>URI для утверждения, указывающего заданное имя сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.</summary>
		// Token: 0x0400236A RID: 9066
		public const string GivenName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname";

		/// <summary>URI для утверждения, указывающего значение хэша, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash.</summary>
		// Token: 0x0400236B RID: 9067
		public const string Hash = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash";

		/// <summary>URI для утверждения, указывающего номер домашнего телефона сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.</summary>
		// Token: 0x0400236C RID: 9068
		public const string HomePhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone";

		/// <summary>URI для утверждения, указывающего языковой стандарт по месту нахождения сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.</summary>
		// Token: 0x0400236D RID: 9069
		public const string Locality = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality";

		/// <summary>URI для утверждения, указывающего номер мобильного телефона сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone.</summary>
		// Token: 0x0400236E RID: 9070
		public const string MobilePhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone";

		/// <summary>URI для утверждения, указывающего имя сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.</summary>
		// Token: 0x0400236F RID: 9071
		public const string Name = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";

		/// <summary>URI для утверждения, указывающего имя сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.</summary>
		// Token: 0x04002370 RID: 9072
		public const string NameIdentifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";

		/// <summary>URI для утверждения, указывающего альтернативный номера телефона сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.</summary>
		// Token: 0x04002371 RID: 9073
		public const string OtherPhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone";

		/// <summary>URI для утверждения, указывающего почтовый индекс сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.</summary>
		// Token: 0x04002372 RID: 9074
		public const string PostalCode = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode";

		/// <summary>URI для утверждения, указывающего ключ RSA, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa.</summary>
		// Token: 0x04002373 RID: 9075
		public const string Rsa = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa";

		/// <summary>URI для утверждения, указывающего идентификатор безопасности (SID), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.</summary>
		// Token: 0x04002374 RID: 9076
		public const string Sid = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid";

		/// <summary>URI для утверждения, указывающего утверждение имени субъекта-службы (SPN), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.</summary>
		// Token: 0x04002375 RID: 9077
		public const string Spn = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn";

		/// <summary>URI для утверждения, указывающего штат или провинцию, где находится сущность, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.</summary>
		// Token: 0x04002376 RID: 9078
		public const string StateOrProvince = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince";

		/// <summary>URI для утверждения, указывающего почтовый адрес сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.</summary>
		// Token: 0x04002377 RID: 9079
		public const string StreetAddress = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress";

		/// <summary>URI для утверждения, указывающего фамилию сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.</summary>
		// Token: 0x04002378 RID: 9080
		public const string Surname = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname";

		/// <summary>URI для утверждения, указывающего системную сущность, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system.</summary>
		// Token: 0x04002379 RID: 9081
		public const string System = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system";

		/// <summary>URI для утверждения, указывающего отпечаток, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. Отпечаток — это глобальный уникальный хэш SHA-1 сертификата X.509.</summary>
		// Token: 0x0400237A RID: 9082
		public const string Thumbprint = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint";

		/// <summary>URI для утверждения, указывающего имя субъекта-пользователя (UPN), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn.</summary>
		// Token: 0x0400237B RID: 9083
		public const string Upn = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn";

		/// <summary>URI для утверждения, указывающего URI, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.</summary>
		// Token: 0x0400237C RID: 9084
		public const string Uri = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri";

		/// <summary>URI для утверждения, указывающего веб-страницу сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.</summary>
		// Token: 0x0400237D RID: 9085
		public const string Webpage = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage";

		/// <summary>URI для утверждения с различающимся именем для сертификата X.509, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname. В стандарте X.500 определена методика определения различающихся имен, используемая в сертификатах X.509.</summary>
		// Token: 0x0400237E RID: 9086
		public const string X500DistinguishedName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname";

		// Token: 0x0400237F RID: 9087
		internal const string ClaimType2009Namespace = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims";

		/// <summary>http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor.</summary>
		// Token: 0x04002380 RID: 9088
		public const string Actor = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor";
	}
}
