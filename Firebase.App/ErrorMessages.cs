using System;
using Firebase.Platform;

namespace Firebase
{
	// Token: 0x02000006 RID: 6
	internal class ErrorMessages
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000230C File Offset: 0x0000050C
		internal static string DependencyNotFoundErrorMessage
		{
			get
			{
				bool isAndroid = PlatformInformation.IsAndroid;
				string result;
				if (isAndroid)
				{
					result = ErrorMessages.DEPENDENCY_NOT_FOUND_ERROR_ANDROID;
				}
				else
				{
					bool isIOS = PlatformInformation.IsIOS;
					if (isIOS)
					{
						result = ErrorMessages.DEPENDENCY_NOT_FOUND_ERROR_IOS;
					}
					else
					{
						result = ErrorMessages.DEPENDENCY_NOT_FOUND_ERROR_GENERIC;
					}
				}
				return result;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002348 File Offset: 0x00000548
		internal static string DllNotFoundExceptionErrorMessage
		{
			get
			{
				bool isAndroid = PlatformInformation.IsAndroid;
				string str;
				if (isAndroid)
				{
					str = ErrorMessages.DLL_NOT_FOUND_ERROR_ANDROID;
				}
				else
				{
					bool isIOS = PlatformInformation.IsIOS;
					if (isIOS)
					{
						str = ErrorMessages.DLL_NOT_FOUND_ERROR_IOS;
					}
					else
					{
						str = ErrorMessages.DLL_NOT_FOUND_ERROR_GENERIC;
					}
				}
				return str + ErrorMessages.DependencyNotFoundErrorMessage;
			}
		}

		// Token: 0x04000013 RID: 19
		private static string DEPENDENCY_NOT_FOUND_ERROR_ANDROID = "On Android, Firebase requires C/C++ and Java components\nthat are distributed with the Firebase and Android SDKs.\n\nIt's likely the required dependencies for Firebase were not included\nin your Unity project.\nAssets/Plugins/Android/ in your Unity project should contain\nAAR files in the form firebase-*.aar\nYou may have disabled the Android Resolver which would\nhave added the AAR dependencies for you.\n\nDo the following to enable the Android Resolver in Unity:\n* Select the menu option 'Assets -> Play Services Resolver -> \n  Android Resolver -> Settings'\n* In the Android Resolver settings check\n  'Enable Background Resolution'\n* Select the menu option 'Assets -> Play Services Resolver ->\n  Android Resolver -> Resolve Client Jars' to force Android\n  dependency resolution.\n* Rebuild your APK and deploy.\n";

		// Token: 0x04000014 RID: 20
		private static string DEPENDENCY_NOT_FOUND_ERROR_IOS = "On iOS and tvOS Firebase requires native (C/C++) and Cocoapod\ncomponents that are distributed with the Firebase SDK and via\nCocoapods.\n\nIt's likely that you did not include the require Cocoapod\ndependencies for Firebase in your Unity project.\nYou may have disabled the iOS Resolver which would have added\nthe Cocoapod dependencies for you.\n\nDo the following to enable the iOS Resolver in Unity:\n* Select the menu option 'Assets -> Play Services Resolver ->\n  iOS Resolver -> Settings'\n* In the iOS Resolver settings check 'Podfile Generation' and\n  'Add Cocoapods to Generated Xcode Project'.\n* Build your iOS or tvOS project and check the Unity console for\n  any errors associated with Cocoapod tool execution.\n  You will need to correctly install Cocoapods tools to generate\n  a working build.\n";

		// Token: 0x04000015 RID: 21
		private static string DEPENDENCY_NOT_FOUND_ERROR_GENERIC = "Firebase is distributed with native (C/C++) dependencies\nthat are required by the SDK.\n\nIt's possible that parts of Firebase SDK have been removed from\nyour Unity project.\n\nTo resolve the problem, try re-importing your Firebase plugins and\nbuilding again.\n\nAlternatively, you may be trying to use Firebase on an unsupported\nplatform.  See the Firebase website for the list of supported\nplatforms.\n";

		// Token: 0x04000016 RID: 22
		private static string DLL_NOT_FOUND_ERROR_ANDROID = "Firebase's libApp.so was not found for this device's architecture\nin your APK.\n";

		// Token: 0x04000017 RID: 23
		private static string DLL_NOT_FOUND_ERROR_IOS = "A Firebase static library (e.g libApp.a) was not linked with your\niOS or tvOS application.\n";

		// Token: 0x04000018 RID: 24
		private static string DLL_NOT_FOUND_ERROR_GENERIC = "A Firebase shared library (.dll / .so) could not be loaded.\n";
	}
}
