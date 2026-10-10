using System;
using System.Runtime.CompilerServices;
using Mono;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет сведения об установке среды выполнения .NET.</summary>
	// Token: 0x02000737 RID: 1847
	public static class RuntimeInformation
	{
		// Token: 0x06004114 RID: 16660 RVA: 0x000E1A28 File Offset: 0x000DFC28
		static RuntimeInformation()
		{
			string runtimeArchitecture = RuntimeInformation.GetRuntimeArchitecture();
			string osname = RuntimeInformation.GetOSName();
			if (!(runtimeArchitecture == "arm"))
			{
				if (!(runtimeArchitecture == "armv8"))
				{
					if (!(runtimeArchitecture == "x86"))
					{
						if (!(runtimeArchitecture == "x86-64"))
						{
							if (!(runtimeArchitecture == "wasm"))
							{
							}
							RuntimeInformation._osArchitecture = (Environment.Is64BitOperatingSystem ? Architecture.X64 : Architecture.X86);
							RuntimeInformation._processArchitecture = (Environment.Is64BitProcess ? Architecture.X64 : Architecture.X86);
						}
						else
						{
							RuntimeInformation._osArchitecture = (Environment.Is64BitOperatingSystem ? Architecture.X64 : Architecture.X86);
							RuntimeInformation._processArchitecture = Architecture.X64;
						}
					}
					else
					{
						RuntimeInformation._osArchitecture = (Environment.Is64BitOperatingSystem ? Architecture.X64 : Architecture.X86);
						RuntimeInformation._processArchitecture = Architecture.X86;
					}
				}
				else
				{
					RuntimeInformation._osArchitecture = (Environment.Is64BitOperatingSystem ? Architecture.Arm64 : Architecture.Arm);
					RuntimeInformation._processArchitecture = Architecture.Arm64;
				}
			}
			else
			{
				RuntimeInformation._osArchitecture = (Environment.Is64BitOperatingSystem ? Architecture.Arm64 : Architecture.Arm);
				RuntimeInformation._processArchitecture = Architecture.Arm;
			}
			uint num = <PrivateImplementationDetails>.ComputeStringHash(osname);
			if (num <= 2784415053U)
			{
				if (num <= 758268069U)
				{
					if (num != 311744602U)
					{
						if (num == 758268069U)
						{
							if (osname == "aix")
							{
								RuntimeInformation._osPlatform = OSPlatform.Create("AIX");
								return;
							}
						}
					}
					else if (osname == "solaris")
					{
						RuntimeInformation._osPlatform = OSPlatform.Create("SOLARIS");
						return;
					}
				}
				else if (num != 1846719142U)
				{
					if (num != 1968959064U)
					{
						if (num == 2784415053U)
						{
							if (osname == "wasm")
							{
								RuntimeInformation._osPlatform = OSPlatform.Create("BROWSER");
								return;
							}
						}
					}
					else if (osname == "hpux")
					{
						RuntimeInformation._osPlatform = OSPlatform.Create("HPUX");
						return;
					}
				}
				else if (osname == "openbsd")
				{
					RuntimeInformation._osPlatform = OSPlatform.Create("OPENBSD");
					return;
				}
			}
			else if (num <= 3229321689U)
			{
				if (num != 2876596737U)
				{
					if (num != 3139461053U)
					{
						if (num == 3229321689U)
						{
							if (osname == "netbsd")
							{
								RuntimeInformation._osPlatform = OSPlatform.Create("NETBSD");
								return;
							}
						}
					}
					else if (osname == "osx")
					{
						RuntimeInformation._osPlatform = OSPlatform.OSX;
						return;
					}
				}
				else if (osname == "haiku")
				{
					RuntimeInformation._osPlatform = OSPlatform.Create("HAIKU");
					return;
				}
			}
			else if (num != 3583452906U)
			{
				if (num != 3971716381U)
				{
					if (num == 4059584116U)
					{
						if (osname == "freebsd")
						{
							RuntimeInformation._osPlatform = OSPlatform.Create("FREEBSD");
							return;
						}
					}
				}
				else if (osname == "linux")
				{
					RuntimeInformation._osPlatform = OSPlatform.Linux;
					return;
				}
			}
			else if (osname == "windows")
			{
				RuntimeInformation._osPlatform = OSPlatform.Windows;
				return;
			}
			RuntimeInformation._osPlatform = OSPlatform.Create("UNKNOWN");
		}

		// Token: 0x06004115 RID: 16661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetRuntimeArchitecture();

		// Token: 0x06004116 RID: 16662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetOSName();

		/// <summary>Возвращает строку, указывающую имя установки .NET, в которой выполняется приложение.</summary>
		/// <returns>Имя установки .NET, в которой выполняется приложение.</returns>
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x000E1D3B File Offset: 0x000DFF3B
		public static string FrameworkDescription
		{
			get
			{
				return "Mono " + Runtime.GetDisplayName();
			}
		}

		/// <summary>Указывает, выполняется ли текущее приложение на указанной платформе.</summary>
		/// <param name="osPlatform">Платформа.</param>
		/// <returns>Значение <see langword="true" />, если текущее приложение выполняется на указанной платформе; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004118 RID: 16664 RVA: 0x000E1D4C File Offset: 0x000DFF4C
		public static bool IsOSPlatform(OSPlatform osPlatform)
		{
			return RuntimeInformation._osPlatform == osPlatform;
		}

		/// <summary>Возвращает строку, описывающую операционную систему, в которой выполняется приложение.</summary>
		/// <returns>Описание операционной системы, на котором выполняется приложение.</returns>
		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x000E1D59 File Offset: 0x000DFF59
		public static string OSDescription
		{
			get
			{
				return Environment.OSVersion.VersionString;
			}
		}

		/// <summary>Получает архитектуру платформы, в которой выполняется текущее приложение.</summary>
		/// <returns>Архитектура платформы, в которой выполняется текущее приложение.</returns>
		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x0600411A RID: 16666 RVA: 0x000E1D65 File Offset: 0x000DFF65
		public static Architecture OSArchitecture
		{
			get
			{
				return RuntimeInformation._osArchitecture;
			}
		}

		/// <summary>Получает архитектуру процесса выполняющегося приложения.</summary>
		/// <returns>Архитектура процесса выполняющегося приложения.</returns>
		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x000E1D6C File Offset: 0x000DFF6C
		public static Architecture ProcessArchitecture
		{
			get
			{
				return RuntimeInformation._processArchitecture;
			}
		}

		// Token: 0x04002BA9 RID: 11177
		private static readonly Architecture _osArchitecture;

		// Token: 0x04002BAA RID: 11178
		private static readonly Architecture _processArchitecture;

		// Token: 0x04002BAB RID: 11179
		private static readonly OSPlatform _osPlatform;
	}
}
