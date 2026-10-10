using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Содержит сведения о версии физического файла на диске.</summary>
	// Token: 0x02000267 RID: 615
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	public sealed class FileVersionInfo
	{
		// Token: 0x06001349 RID: 4937 RVA: 0x000513D8 File Offset: 0x0004F5D8
		private FileVersionInfo()
		{
			this.comments = null;
			this.companyname = null;
			this.filedescription = null;
			this.filename = null;
			this.fileversion = null;
			this.internalname = null;
			this.language = null;
			this.legalcopyright = null;
			this.legaltrademarks = null;
			this.originalfilename = null;
			this.privatebuild = null;
			this.productname = null;
			this.productversion = null;
			this.specialbuild = null;
			this.isdebug = false;
			this.ispatched = false;
			this.isprerelease = false;
			this.isprivatebuild = false;
			this.isspecialbuild = false;
			this.filemajorpart = 0;
			this.fileminorpart = 0;
			this.filebuildpart = 0;
			this.fileprivatepart = 0;
			this.productmajorpart = 0;
			this.productminorpart = 0;
			this.productbuildpart = 0;
			this.productprivatepart = 0;
		}

		/// <summary>Получает комментарии к файлу.</summary>
		/// <returns>Комментарии к файлу или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x000514A8 File Offset: 0x0004F6A8
		public string Comments
		{
			get
			{
				return this.comments;
			}
		}

		/// <summary>Получает название организации, которая является создателем файла.</summary>
		/// <returns>Название организации, которая является создателем файла или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x000514B0 File Offset: 0x0004F6B0
		public string CompanyName
		{
			get
			{
				return this.companyname;
			}
		}

		/// <summary>Получает номер сборки файла.</summary>
		/// <returns>Значение, представляющее номер сборки файла, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x000514B8 File Offset: 0x0004F6B8
		public int FileBuildPart
		{
			get
			{
				return this.filebuildpart;
			}
		}

		/// <summary>Получает описание файла.</summary>
		/// <returns>Описание файла или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x000514C0 File Offset: 0x0004F6C0
		public string FileDescription
		{
			get
			{
				return this.filedescription;
			}
		}

		/// <summary>Получает основную часть номера версии.</summary>
		/// <returns>Значение, представляющее основную часть номера версии, или значение 0 (ноль), если файл не содержал сведений о версии.</returns>
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x000514C8 File Offset: 0x0004F6C8
		public int FileMajorPart
		{
			get
			{
				return this.filemajorpart;
			}
		}

		/// <summary>Получает вспомогательную часть номера версии файла.</summary>
		/// <returns>Значение, представляющее вспомогательную часть номера версии файла, или значение 0 (ноль), если файл не содержал сведений о версии.</returns>
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x000514D0 File Offset: 0x0004F6D0
		public int FileMinorPart
		{
			get
			{
				return this.fileminorpart;
			}
		}

		/// <summary>Получает имя файла, который описывается данным экземпляром класса <see cref="T:System.Diagnostics.FileVersionInfo" />.</summary>
		/// <returns>Имя файла, который описывается данным экземпляром класса <see cref="T:System.Diagnostics.FileVersionInfo" />.</returns>
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x000514D8 File Offset: 0x0004F6D8
		public string FileName
		{
			get
			{
				return this.filename;
			}
		}

		/// <summary>Получает номер закрытой части файла.</summary>
		/// <returns>Значение, представляющее номер закрытой части файла, или значение <see langword="null" />, если файл не содержал сведений о версии.</returns>
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x000514E0 File Offset: 0x0004F6E0
		public int FilePrivatePart
		{
			get
			{
				return this.fileprivatepart;
			}
		}

		/// <summary>Получает номер версии файла.</summary>
		/// <returns>Номер версии файла или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x000514E8 File Offset: 0x0004F6E8
		public string FileVersion
		{
			get
			{
				return this.fileversion;
			}
		}

		/// <summary>Получает внутреннее имя файла (если оно существует).</summary>
		/// <returns>Внутреннее имя файла. Если оно отсутствует, это свойство будет содержать исходное имя файла без расширения.</returns>
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x000514F0 File Offset: 0x0004F6F0
		public string InternalName
		{
			get
			{
				return this.internalname;
			}
		}

		/// <summary>Получает значение, показывающее, содержит ли файл данные отладки или производится ли его компиляция с помощью доступных средств отладки.</summary>
		/// <returns>Значение <see langword="true" />, если файл содержит данные отладки или его компиляция производится с помощью доступных средств отладки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x000514F8 File Offset: 0x0004F6F8
		public bool IsDebug
		{
			get
			{
				return this.isdebug;
			}
		}

		/// <summary>Получает значение, указывающее, был ли файл изменен и не совпадает ли он с исходным файлом той же версии.</summary>
		/// <returns>Значение <see langword="true" />, если файл исправлен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00051500 File Offset: 0x0004F700
		public bool IsPatched
		{
			get
			{
				return this.ispatched;
			}
		}

		/// <summary>Получает значение, указывающее, является ли версия файла версией разработчика, или коммерческой версией продукта.</summary>
		/// <returns>Значение <see langword="true" />, если файл является предварительной версией; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00051508 File Offset: 0x0004F708
		public bool IsPreRelease
		{
			get
			{
				return this.isprerelease;
			}
		}

		/// <summary>Получает значение, указывающее, создан ли файл с помощью стандартных процедур.</summary>
		/// <returns>Значение <see langword="true" />, если файл является закрытой сборкой; значение <see langword="false" />, если файл был создан с помощью стандартных процедур или не содержал сведения о версии.</returns>
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00051510 File Offset: 0x0004F710
		public bool IsPrivateBuild
		{
			get
			{
				return this.isprivatebuild;
			}
		}

		/// <summary>Получает значение, указывающее, является ли файл особой сборкой.</summary>
		/// <returns>Значение <see langword="true" />, если файл является особой сборкой; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00051518 File Offset: 0x0004F718
		public bool IsSpecialBuild
		{
			get
			{
				return this.isspecialbuild;
			}
		}

		/// <summary>Получает языковую строку по умолчанию для блока сведений о версии.</summary>
		/// <returns>Строка описания для идентификатора языка Майкрософт в ресурсе версии или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00051520 File Offset: 0x0004F720
		public string Language
		{
			get
			{
				return this.language;
			}
		}

		/// <summary>Получает все уведомления об авторских правах, применимые к указанному файлу.</summary>
		/// <returns>Уведомления об авторских правах, примененные к указанному файлу.</returns>
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x00051528 File Offset: 0x0004F728
		public string LegalCopyright
		{
			get
			{
				return this.legalcopyright;
			}
		}

		/// <summary>Получает товарные знаки и охраняемые товарные знаки, применимые к файлу.</summary>
		/// <returns>Товарные знаки и охраняемые товарные знаки, применимые к файлу, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00051530 File Offset: 0x0004F730
		public string LegalTrademarks
		{
			get
			{
				return this.legaltrademarks;
			}
		}

		/// <summary>Получает имя, под которым создавался файл.</summary>
		/// <returns>Имя, под которым создавался файл, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00051538 File Offset: 0x0004F738
		public string OriginalFilename
		{
			get
			{
				return this.originalfilename;
			}
		}

		/// <summary>Получает сведения о закрытой версии файла.</summary>
		/// <returns>Сведения о закрытой версии файла или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00051540 File Offset: 0x0004F740
		public string PrivateBuild
		{
			get
			{
				return this.privatebuild;
			}
		}

		/// <summary>Получает номер сборки продукта, с которым связан файл.</summary>
		/// <returns>Значение, представляющее номер сборки продукта, с которым связан этот файл, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00051548 File Offset: 0x0004F748
		public int ProductBuildPart
		{
			get
			{
				return this.productbuildpart;
			}
		}

		/// <summary>Получает основную часть номера версии продукта, с которым связан файл.</summary>
		/// <returns>Значение, представляющее основную часть номера версии продукта, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00051550 File Offset: 0x0004F750
		public int ProductMajorPart
		{
			get
			{
				return this.productmajorpart;
			}
		}

		/// <summary>Получает вспомогательную часть номера версии продукта, с которым связан файл.</summary>
		/// <returns>Значение, представляющее вспомогательную часть номера версии продукта, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00051558 File Offset: 0x0004F758
		public int ProductMinorPart
		{
			get
			{
				return this.productminorpart;
			}
		}

		/// <summary>Получает название продукта, с которым распространяется файл.</summary>
		/// <returns>Название продукта, с которым распространяется этот файл, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00051560 File Offset: 0x0004F760
		public string ProductName
		{
			get
			{
				return this.productname;
			}
		}

		/// <summary>Получает закрытую часть номера продукта, с которым связан файл.</summary>
		/// <returns>Значение, представляющее закрытую часть номера сборки продукта, с которым связан этот файл, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00051568 File Offset: 0x0004F768
		public int ProductPrivatePart
		{
			get
			{
				return this.productprivatepart;
			}
		}

		/// <summary>Получает версию продукта, с которым распространяется этот файл.</summary>
		/// <returns>Версия продукта, с которым распространяется этот файл, или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00051570 File Offset: 0x0004F770
		public string ProductVersion
		{
			get
			{
				return this.productversion;
			}
		}

		/// <summary>Получает сведения об особой сборке файла.</summary>
		/// <returns>Сведения об особой сборке файла или значение <see langword="null" />, если файл не содержал сведения о версии.</returns>
		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x00051578 File Offset: 0x0004F778
		public string SpecialBuild
		{
			get
			{
				return this.specialbuild;
			}
		}

		// Token: 0x06001365 RID: 4965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe extern void GetVersionInfo_icall(char* fileName, int fileName_length);

		// Token: 0x06001366 RID: 4966 RVA: 0x00051580 File Offset: 0x0004F780
		private unsafe void GetVersionInfo_internal(string fileName)
		{
			fixed (string text = fileName)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				this.GetVersionInfo_icall(ptr, (fileName != null) ? fileName.Length : 0);
			}
		}

		/// <summary>Возвращает класс <see cref="T:System.Diagnostics.FileVersionInfo" />, предоставляющий сведения о версии указанного файла.</summary>
		/// <param name="fileName">Имя и полный путь к файлу, сведения о версии которого необходимо получить.</param>
		/// <returns>Класс <see cref="T:System.Diagnostics.FileVersionInfo" />, содержащий сведения о файле. Если поле не содержало сведений о версии, <see cref="T:System.Diagnostics.FileVersionInfo" /> содержит только имя запрашиваемого файла.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти указанный файл.</exception>
		// Token: 0x06001367 RID: 4967 RVA: 0x000515B2 File Offset: 0x0004F7B2
		public static FileVersionInfo GetVersionInfo(string fileName)
		{
			if (!File.Exists(Path.GetFullPath(fileName)))
			{
				throw new FileNotFoundException(fileName);
			}
			FileVersionInfo fileVersionInfo = new FileVersionInfo();
			fileVersionInfo.GetVersionInfo_internal(fileName);
			return fileVersionInfo;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x000515D4 File Offset: 0x0004F7D4
		private static void AppendFormat(StringBuilder sb, string format, params object[] args)
		{
			sb.AppendFormat(format, args);
		}

		/// <summary>Возвращает неполный список свойств класса <see cref="T:System.Diagnostics.FileVersionInfo" /> с их значениями.</summary>
		/// <returns>Список свойств класса со значениями: 
		///  <see cref="P:System.Diagnostics.FileVersionInfo.FileName" />, <see cref="P:System.Diagnostics.FileVersionInfo.InternalName" />, <see cref="P:System.Diagnostics.FileVersionInfo.OriginalFilename" />, <see cref="P:System.Diagnostics.FileVersionInfo.FileVersion" />, <see cref="P:System.Diagnostics.FileVersionInfo.FileDescription" />, <see cref="P:System.Diagnostics.FileVersionInfo.ProductName" />, <see cref="P:System.Diagnostics.FileVersionInfo.ProductVersion" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsDebug" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPatched" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPreRelease" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPrivateBuild" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsSpecialBuild" />, 
		///  <see cref="P:System.Diagnostics.FileVersionInfo.Language" />.  
		/// Если файл не содержал сведений о версии, этот список будет содержать только имя запрашиваемого файла. Логические значения будут иметь значение <see langword="false" />, а все другие элементы — значение<see langword="null" />.</returns>
		// Token: 0x06001369 RID: 4969 RVA: 0x000515E0 File Offset: 0x0004F7E0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			FileVersionInfo.AppendFormat(stringBuilder, "File:             {0}{1}", new object[]
			{
				this.FileName,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "InternalName:     {0}{1}", new object[]
			{
				this.internalname,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "OriginalFilename: {0}{1}", new object[]
			{
				this.originalfilename,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "FileVersion:      {0}{1}", new object[]
			{
				this.fileversion,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "FileDescription:  {0}{1}", new object[]
			{
				this.filedescription,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "Product:          {0}{1}", new object[]
			{
				this.productname,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "ProductVersion:   {0}{1}", new object[]
			{
				this.productversion,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "Debug:            {0}{1}", new object[]
			{
				this.isdebug,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "Patched:          {0}{1}", new object[]
			{
				this.ispatched,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "PreRelease:       {0}{1}", new object[]
			{
				this.isprerelease,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "PrivateBuild:     {0}{1}", new object[]
			{
				this.isprivatebuild,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "SpecialBuild:     {0}{1}", new object[]
			{
				this.isspecialbuild,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "Language          {0}{1}", new object[]
			{
				this.language,
				Environment.NewLine
			});
			return stringBuilder.ToString();
		}

		// Token: 0x04000AE5 RID: 2789
		private string comments;

		// Token: 0x04000AE6 RID: 2790
		private string companyname;

		// Token: 0x04000AE7 RID: 2791
		private string filedescription;

		// Token: 0x04000AE8 RID: 2792
		private string filename;

		// Token: 0x04000AE9 RID: 2793
		private string fileversion;

		// Token: 0x04000AEA RID: 2794
		private string internalname;

		// Token: 0x04000AEB RID: 2795
		private string language;

		// Token: 0x04000AEC RID: 2796
		private string legalcopyright;

		// Token: 0x04000AED RID: 2797
		private string legaltrademarks;

		// Token: 0x04000AEE RID: 2798
		private string originalfilename;

		// Token: 0x04000AEF RID: 2799
		private string privatebuild;

		// Token: 0x04000AF0 RID: 2800
		private string productname;

		// Token: 0x04000AF1 RID: 2801
		private string productversion;

		// Token: 0x04000AF2 RID: 2802
		private string specialbuild;

		// Token: 0x04000AF3 RID: 2803
		private bool isdebug;

		// Token: 0x04000AF4 RID: 2804
		private bool ispatched;

		// Token: 0x04000AF5 RID: 2805
		private bool isprerelease;

		// Token: 0x04000AF6 RID: 2806
		private bool isprivatebuild;

		// Token: 0x04000AF7 RID: 2807
		private bool isspecialbuild;

		// Token: 0x04000AF8 RID: 2808
		private int filemajorpart;

		// Token: 0x04000AF9 RID: 2809
		private int fileminorpart;

		// Token: 0x04000AFA RID: 2810
		private int filebuildpart;

		// Token: 0x04000AFB RID: 2811
		private int fileprivatepart;

		// Token: 0x04000AFC RID: 2812
		private int productmajorpart;

		// Token: 0x04000AFD RID: 2813
		private int productminorpart;

		// Token: 0x04000AFE RID: 2814
		private int productbuildpart;

		// Token: 0x04000AFF RID: 2815
		private int productprivatepart;
	}
}
