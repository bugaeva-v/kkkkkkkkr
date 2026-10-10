using System;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	/// <summary>Определяет набор часто используемых идентификаторов безопасности (SID).</summary>
	// Token: 0x020004E9 RID: 1257
	[ComVisible(false)]
	public enum WellKnownSidType
	{
		/// <summary>Пустой идентификатор безопасности.</summary>
		// Token: 0x040022CD RID: 8909
		NullSid,
		/// <summary>Идентификатор безопасности, соответствующий любому объекту.</summary>
		// Token: 0x040022CE RID: 8910
		WorldSid,
		/// <summary>Локальный идентификатор безопасности.</summary>
		// Token: 0x040022CF RID: 8911
		LocalSid,
		/// <summary>Идентификатор безопасности, соответствующий владельцу или создателю объекта.</summary>
		// Token: 0x040022D0 RID: 8912
		CreatorOwnerSid,
		/// <summary>Идентификатор безопасности, соответствующий группе-создателю объекта.</summary>
		// Token: 0x040022D1 RID: 8913
		CreatorGroupSid,
		/// <summary>Идентификатор безопасности владельца-создателя "сервер".</summary>
		// Token: 0x040022D2 RID: 8914
		CreatorOwnerServerSid,
		/// <summary>Идентификатор безопасности группы-создателя "сервер".</summary>
		// Token: 0x040022D3 RID: 8915
		CreatorGroupServerSid,
		/// <summary>Идентификатор безопасности для центра Windows NT.</summary>
		// Token: 0x040022D4 RID: 8916
		NTAuthoritySid,
		/// <summary>Идентификатор безопасности для учетной записи удаленного подключения.</summary>
		// Token: 0x040022D5 RID: 8917
		DialupSid,
		/// <summary>Идентификатор безопасности для сетевой учетной записи. Этот идентификатор добавляется в процесс маркера, когда он входит в систему по сети.</summary>
		// Token: 0x040022D6 RID: 8918
		NetworkSid,
		/// <summary>Идентификатор безопасности для процесса пакетной обработки. Этот идентификатор добавляется в процесс маркера, когда он входит в систему в качестве пакетного задания.</summary>
		// Token: 0x040022D7 RID: 8919
		BatchSid,
		/// <summary>Идентификатор безопасности для интерактивной учетной записи. Этот идентификатор добавляется в процесс маркера, когда он входит в систему интерактивно.</summary>
		// Token: 0x040022D8 RID: 8920
		InteractiveSid,
		/// <summary>Идентификатор безопасности для службы. Этот идентификатор добавляется в процесс маркера, когда он входит в систему в качестве службы.</summary>
		// Token: 0x040022D9 RID: 8921
		ServiceSid,
		/// <summary>Идентификатор безопасности для анонимной учетной записи.</summary>
		// Token: 0x040022DA RID: 8922
		AnonymousSid,
		/// <summary>Идентификатор безопасности прокси-сервера.</summary>
		// Token: 0x040022DB RID: 8923
		ProxySid,
		/// <summary>Идентификатор безопасности для контроллера предприятия.</summary>
		// Token: 0x040022DC RID: 8924
		EnterpriseControllersSid,
		/// <summary>Идентификатор безопасности для самообслуживания.</summary>
		// Token: 0x040022DD RID: 8925
		SelfSid,
		/// <summary>Идентификатор безопасности для прошедшего проверку пользователя.</summary>
		// Token: 0x040022DE RID: 8926
		AuthenticatedUserSid,
		/// <summary>Идентификатор безопасности для запрещенного кода.</summary>
		// Token: 0x040022DF RID: 8927
		RestrictedCodeSid,
		/// <summary>Идентификатор безопасности, соответствующий учетной записи сервера терминалов.</summary>
		// Token: 0x040022E0 RID: 8928
		TerminalServerSid,
		/// <summary>Идентификатор безопасности, соответствующий удаленным входам в систему.</summary>
		// Token: 0x040022E1 RID: 8929
		RemoteLogonIdSid,
		/// <summary>Идентификатор безопасности, соответствующий идентификаторам входа.</summary>
		// Token: 0x040022E2 RID: 8930
		LogonIdsSid,
		/// <summary>Идентификатор безопасности, соответствующий локальной системе.</summary>
		// Token: 0x040022E3 RID: 8931
		LocalSystemSid,
		/// <summary>Идентификатор безопасности, соответствующий локальной службе.</summary>
		// Token: 0x040022E4 RID: 8932
		LocalServiceSid,
		/// <summary>Идентификатор безопасности, соответствующий сетевой службе.</summary>
		// Token: 0x040022E5 RID: 8933
		NetworkServiceSid,
		/// <summary>Идентификатор безопасности, соответствующий учетной записи домена.</summary>
		// Token: 0x040022E6 RID: 8934
		BuiltinDomainSid,
		/// <summary>Идентификатор безопасности, соответствующий учетной записи администратора.</summary>
		// Token: 0x040022E7 RID: 8935
		BuiltinAdministratorsSid,
		/// <summary>Идентификатор безопасности, соответствующий встроенным учетным записям пользователей.</summary>
		// Token: 0x040022E8 RID: 8936
		BuiltinUsersSid,
		/// <summary>Идентификатор безопасности, соответствующий учетной записи "Гость".</summary>
		// Token: 0x040022E9 RID: 8937
		BuiltinGuestsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе опытных пользователей.</summary>
		// Token: 0x040022EA RID: 8938
		BuiltinPowerUsersSid,
		/// <summary>Идентификатор безопасности, соответствующий учетной записи операторов учета.</summary>
		// Token: 0x040022EB RID: 8939
		BuiltinAccountOperatorsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе системных операторов.</summary>
		// Token: 0x040022EC RID: 8940
		BuiltinSystemOperatorsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе операторов печати.</summary>
		// Token: 0x040022ED RID: 8941
		BuiltinPrintOperatorsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе операторов архива.</summary>
		// Token: 0x040022EE RID: 8942
		BuiltinBackupOperatorsSid,
		/// <summary>Идентификатор безопасности, соответствующий учетной записи "Репликатор".</summary>
		// Token: 0x040022EF RID: 8943
		BuiltinReplicatorSid,
		/// <summary>Идентификатор безопасности, соответствующий учетным записям, совместимым с пред-Windows 2000.</summary>
		// Token: 0x040022F0 RID: 8944
		BuiltinPreWindows2000CompatibleAccessSid,
		/// <summary>Идентификатор безопасности, соответствующий пользователям удаленного рабочего стола.</summary>
		// Token: 0x040022F1 RID: 8945
		BuiltinRemoteDesktopUsersSid,
		/// <summary>Идентификатор безопасности, соответствующий группе операторов сети.</summary>
		// Token: 0x040022F2 RID: 8946
		BuiltinNetworkConfigurationOperatorsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе учетных записей администраторов.</summary>
		// Token: 0x040022F3 RID: 8947
		AccountAdministratorSid,
		/// <summary>Идентификатор безопасности, соответствующий группе учетных записей гостей.</summary>
		// Token: 0x040022F4 RID: 8948
		AccountGuestSid,
		/// <summary>Идентификатор безопасности, соответствующий группе учетных записей целевых объектов Kerberos.</summary>
		// Token: 0x040022F5 RID: 8949
		AccountKrbtgtSid,
		/// <summary>Идентификатор безопасности, соответствующий группе учетных записей администраторов домена.</summary>
		// Token: 0x040022F6 RID: 8950
		AccountDomainAdminsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе учетных записей пользователей домена.</summary>
		// Token: 0x040022F7 RID: 8951
		AccountDomainUsersSid,
		/// <summary>Идентификатор безопасности, соответствующий группе учетных записей гостей домена.</summary>
		// Token: 0x040022F8 RID: 8952
		AccountDomainGuestsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе учетных записей компьютеров.</summary>
		// Token: 0x040022F9 RID: 8953
		AccountComputersSid,
		/// <summary>Идентификатор безопасности, соответствующий группе учетных записей контроллеров.</summary>
		// Token: 0x040022FA RID: 8954
		AccountControllersSid,
		/// <summary>Идентификатор безопасности, соответствующий группе администраторов сертификатов.</summary>
		// Token: 0x040022FB RID: 8955
		AccountCertAdminsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе администраторов схемы.</summary>
		// Token: 0x040022FC RID: 8956
		AccountSchemaAdminsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе администраторов предприятия.</summary>
		// Token: 0x040022FD RID: 8957
		AccountEnterpriseAdminsSid,
		/// <summary>Идентификатор безопасности, соответствующий группе администраторов политик.</summary>
		// Token: 0x040022FE RID: 8958
		AccountPolicyAdminsSid,
		/// <summary>Идентификатор безопасности, соответствующий учетной записи серверов RAS и IAS.</summary>
		// Token: 0x040022FF RID: 8959
		AccountRasAndIasServersSid,
		/// <summary>Идентификатор безопасности, присутствующий после проверки подлинности клиента пакетом проверки подлинности Microsoft NTLM.</summary>
		// Token: 0x04002300 RID: 8960
		NtlmAuthenticationSid,
		/// <summary>Идентификатор безопасности, присутствующий после проверки подлинности клиента пакетом дайджест-проверки подлинности Microsoft.</summary>
		// Token: 0x04002301 RID: 8961
		DigestAuthenticationSid,
		/// <summary>Идентификатор безопасности, присутствующий после проверки подлинности клиента пакетом проверки подлинности по безопасному каналу (SSL/TLS).</summary>
		// Token: 0x04002302 RID: 8962
		SChannelAuthenticationSid,
		/// <summary>Идентификатор безопасности, присутствующий после прохождения пользователем проверки подлинности изнутри леса или через уровень доверия, не имеющий включенной функции выборочной проверки подлинности. При наличии идентификатора безопасности идентификатор <see cref="F:System.Security.Principal.WellKnownSidType.OtherOrganizationSid" /> присутствовать не может.</summary>
		// Token: 0x04002303 RID: 8963
		ThisOrganizationSid,
		/// <summary>Идентификатор безопасности, присутствующий после прохождения пользователем проверки подлинности через лес с включенной функцией выборочной проверки подлинности. При наличии идентификатора безопасности идентификатор <see cref="F:System.Security.Principal.WellKnownSidType.ThisOrganizationSid" /> присутствовать не может.</summary>
		// Token: 0x04002304 RID: 8964
		OtherOrganizationSid,
		/// <summary>Идентификатор безопасности, позволяющий пользователю создавать входящие доверия лесов. Этот идентификатор добавляется в маркер пользователей, являющихся членами встроенной группы "Создатели входящего доверия леса" в корневом домене леса.</summary>
		// Token: 0x04002305 RID: 8965
		BuiltinIncomingForestTrustBuildersSid,
		/// <summary>Указывает идентификатор безопасности, соответствующий группе пользователей, которые имеют доступ к планированию записи в журнал счетчиков производительности на данном компьютере.</summary>
		// Token: 0x04002306 RID: 8966
		BuiltinPerformanceMonitoringUsersSid,
		/// <summary>Указывает идентификатор безопасности, соответствующий группе пользователей, которые имеют доступ к мониторингу компьютера.</summary>
		// Token: 0x04002307 RID: 8967
		BuiltinPerformanceLoggingUsersSid,
		/// <summary>Идентификатор безопасности, соответствующий группе авторизации доступа Windows.</summary>
		// Token: 0x04002308 RID: 8968
		BuiltinAuthorizationAccessSid,
		/// <summary>Идентификатор безопасности, присутствующий на сервере, который может выдавать лицензии для сервера терминалов.</summary>
		// Token: 0x04002309 RID: 8969
		WinBuiltinTerminalServerLicenseServersSid,
		/// <summary>Максимальный определенный идентификатор безопасности в перечислении <see cref="T:System.Security.Principal.WellKnownSidType" />.</summary>
		// Token: 0x0400230A RID: 8970
		MaxDefined = 60,
		// Token: 0x0400230B RID: 8971
		WinBuiltinDCOMUsersSid,
		// Token: 0x0400230C RID: 8972
		WinBuiltinIUsersSid,
		// Token: 0x0400230D RID: 8973
		WinIUserSid,
		// Token: 0x0400230E RID: 8974
		WinBuiltinCryptoOperatorsSid,
		// Token: 0x0400230F RID: 8975
		WinUntrustedLabelSid,
		// Token: 0x04002310 RID: 8976
		WinLowLabelSid,
		// Token: 0x04002311 RID: 8977
		WinMediumLabelSid,
		// Token: 0x04002312 RID: 8978
		WinHighLabelSid,
		// Token: 0x04002313 RID: 8979
		WinSystemLabelSid,
		// Token: 0x04002314 RID: 8980
		WinWriteRestrictedCodeSid,
		// Token: 0x04002315 RID: 8981
		WinCreatorOwnerRightsSid,
		// Token: 0x04002316 RID: 8982
		WinCacheablePrincipalsGroupSid,
		// Token: 0x04002317 RID: 8983
		WinNonCacheablePrincipalsGroupSid,
		// Token: 0x04002318 RID: 8984
		WinEnterpriseReadonlyControllersSid,
		// Token: 0x04002319 RID: 8985
		WinAccountReadonlyControllersSid,
		// Token: 0x0400231A RID: 8986
		WinBuiltinEventLogReadersGroup,
		// Token: 0x0400231B RID: 8987
		WinNewEnterpriseReadonlyControllersSid,
		// Token: 0x0400231C RID: 8988
		WinBuiltinCertSvcDComAccessGroup,
		// Token: 0x0400231D RID: 8989
		WinMediumPlusLabelSid,
		// Token: 0x0400231E RID: 8990
		WinLocalLogonSid,
		// Token: 0x0400231F RID: 8991
		WinConsoleLogonSid,
		// Token: 0x04002320 RID: 8992
		WinThisOrganizationCertificateSid,
		// Token: 0x04002321 RID: 8993
		WinApplicationPackageAuthoritySid,
		// Token: 0x04002322 RID: 8994
		WinBuiltinAnyPackageSid,
		// Token: 0x04002323 RID: 8995
		WinCapabilityInternetClientSid,
		// Token: 0x04002324 RID: 8996
		WinCapabilityInternetClientServerSid,
		// Token: 0x04002325 RID: 8997
		WinCapabilityPrivateNetworkClientServerSid,
		// Token: 0x04002326 RID: 8998
		WinCapabilityPicturesLibrarySid,
		// Token: 0x04002327 RID: 8999
		WinCapabilityVideosLibrarySid,
		// Token: 0x04002328 RID: 9000
		WinCapabilityMusicLibrarySid,
		// Token: 0x04002329 RID: 9001
		WinCapabilityDocumentsLibrarySid,
		// Token: 0x0400232A RID: 9002
		WinCapabilitySharedUserCertificatesSid,
		// Token: 0x0400232B RID: 9003
		WinCapabilityEnterpriseAuthenticationSid,
		// Token: 0x0400232C RID: 9004
		WinCapabilityRemovableStorageSid
	}
}
