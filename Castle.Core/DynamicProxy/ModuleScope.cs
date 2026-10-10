using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using Castle.Core.Internal;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Serialization;

namespace Castle.DynamicProxy
{
	// Token: 0x02000015 RID: 21
	public class ModuleScope
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00003343 File Offset: 0x00001543
		public ModuleScope() : this(false, false)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000334D File Offset: 0x0000154D
		public ModuleScope(bool savePhysicalAssembly) : this(savePhysicalAssembly, false)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003357 File Offset: 0x00001557
		public ModuleScope(bool savePhysicalAssembly, bool disableSignedModule) : this(savePhysicalAssembly, disableSignedModule, ModuleScope.DEFAULT_ASSEMBLY_NAME, ModuleScope.DEFAULT_FILE_NAME, ModuleScope.DEFAULT_ASSEMBLY_NAME, ModuleScope.DEFAULT_FILE_NAME)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003375 File Offset: 0x00001575
		public ModuleScope(bool savePhysicalAssembly, bool disableSignedModule, string strongAssemblyName, string strongModulePath, string weakAssemblyName, string weakModulePath) : this(savePhysicalAssembly, disableSignedModule, new NamingScope(), strongAssemblyName, strongModulePath, weakAssemblyName, weakModulePath)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000338C File Offset: 0x0000158C
		public ModuleScope(bool savePhysicalAssembly, bool disableSignedModule, INamingScope namingScope, string strongAssemblyName, string strongModulePath, string weakAssemblyName, string weakModulePath)
		{
			this.savePhysicalAssembly = savePhysicalAssembly;
			this.disableSignedModule = disableSignedModule;
			this.namingScope = namingScope;
			this.strongAssemblyName = strongAssemblyName;
			this.strongModulePath = strongModulePath;
			this.weakAssemblyName = weakAssemblyName;
			this.weakModulePath = weakModulePath;
			this.cacheLock = Lock.CreateFor(this.typeCache.Lock);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003400 File Offset: 0x00001600
		public INamingScope NamingScope
		{
			get
			{
				return this.namingScope;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003408 File Offset: 0x00001608
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lock Lock
		{
			get
			{
				return this.cacheLock;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00003410 File Offset: 0x00001610
		internal SynchronizedDictionary<CacheKey, Type> TypeCache
		{
			get
			{
				return this.typeCache;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003418 File Offset: 0x00001618
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Type GetFromCache(CacheKey key)
		{
			Type result;
			this.typeCache.TryGetValueWithoutTakingLock(key, out result);
			return result;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003435 File Offset: 0x00001635
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void RegisterInCache(CacheKey key, Type type)
		{
			this.typeCache.AddOrUpdateWithoutTakingLock(key, type);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003444 File Offset: 0x00001644
		public static byte[] GetKeyPair()
		{
			byte[] result;
			using (Stream manifestResourceStream = typeof(ModuleScope).GetTypeInfo().Assembly.GetManifestResourceStream("Castle.DynamicProxy.DynProxy.snk"))
			{
				if (manifestResourceStream == null)
				{
					throw new MissingManifestResourceException("Should have a Castle.DynamicProxy.DynProxy.snk as an embedded resource, so Dynamic Proxy could sign generated assembly");
				}
				int num = (int)manifestResourceStream.Length;
				byte[] array = new byte[num];
				manifestResourceStream.Read(array, 0, num);
				result = array;
			}
			return result;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000034B8 File Offset: 0x000016B8
		public ModuleBuilder StrongNamedModule
		{
			get
			{
				return this.moduleBuilderWithStrongName;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000034C0 File Offset: 0x000016C0
		public string StrongNamedModuleName
		{
			get
			{
				return Path.GetFileName(this.strongModulePath);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000034D0 File Offset: 0x000016D0
		public string StrongNamedModuleDirectory
		{
			get
			{
				string directoryName = Path.GetDirectoryName(this.strongModulePath);
				if (string.IsNullOrEmpty(directoryName))
				{
					return null;
				}
				return directoryName;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000034F4 File Offset: 0x000016F4
		public ModuleBuilder WeakNamedModule
		{
			get
			{
				return this.moduleBuilder;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000034FC File Offset: 0x000016FC
		public string WeakNamedModuleName
		{
			get
			{
				return Path.GetFileName(this.weakModulePath);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000350C File Offset: 0x0000170C
		public string WeakNamedModuleDirectory
		{
			get
			{
				string directoryName = Path.GetDirectoryName(this.weakModulePath);
				if (directoryName == string.Empty)
				{
					return null;
				}
				return directoryName;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003535 File Offset: 0x00001735
		public ModuleBuilder ObtainDynamicModule(bool isStrongNamed)
		{
			if (isStrongNamed)
			{
				return this.ObtainDynamicModuleWithStrongName();
			}
			return this.ObtainDynamicModuleWithWeakName();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003548 File Offset: 0x00001748
		public ModuleBuilder ObtainDynamicModuleWithStrongName()
		{
			if (this.disableSignedModule)
			{
				throw new InvalidOperationException("Usage of signed module has been disabled. Use unsigned module or enable signed module.");
			}
			object obj = this.moduleLocker;
			ModuleBuilder result;
			lock (obj)
			{
				if (this.moduleBuilderWithStrongName == null)
				{
					this.moduleBuilderWithStrongName = this.CreateModule(true);
				}
				result = this.moduleBuilderWithStrongName;
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000035B8 File Offset: 0x000017B8
		public ModuleBuilder ObtainDynamicModuleWithWeakName()
		{
			object obj = this.moduleLocker;
			ModuleBuilder result;
			lock (obj)
			{
				if (this.moduleBuilder == null)
				{
					this.moduleBuilder = this.CreateModule(false);
				}
				result = this.moduleBuilder;
			}
			return result;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003618 File Offset: 0x00001818
		private ModuleBuilder CreateModule(bool signStrongName)
		{
			AssemblyName assemblyName = this.GetAssemblyName(signStrongName);
			string text = signStrongName ? this.StrongNamedModuleName : this.WeakNamedModuleName;
			if (this.savePhysicalAssembly)
			{
				AssemblyBuilder assemblyBuilder;
				try
				{
					assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave, signStrongName ? this.StrongNamedModuleDirectory : this.WeakNamedModuleDirectory);
				}
				catch (ArgumentException ex)
				{
					if (!signStrongName && !ex.StackTrace.Contains("ComputePublicKey"))
					{
						throw;
					}
					throw new ArgumentException(string.Format("There was an error creating dynamic assembly for your proxies - you don't have permissions required to sign the assembly. To workaround it you can enforce generating non-signed assembly only when creating {0}. Alternatively ensure that your account has all the required permissions.", base.GetType()), ex);
				}
				return assemblyBuilder.DefineDynamicModule(text, text, false);
			}
			return AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run).DefineDynamicModule(text);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000036C4 File Offset: 0x000018C4
		private AssemblyName GetAssemblyName(bool signStrongName)
		{
			AssemblyName assemblyName = new AssemblyName
			{
				Name = (signStrongName ? this.strongAssemblyName : this.weakAssemblyName)
			};
			if (signStrongName)
			{
				assemblyName.KeyPair = new StrongNameKeyPair(ModuleScope.GetKeyPair());
			}
			return assemblyName;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003704 File Offset: 0x00001904
		public string SaveAssembly()
		{
			if (!this.savePhysicalAssembly)
			{
				return null;
			}
			if (this.StrongNamedModule != null && this.WeakNamedModule != null)
			{
				throw new InvalidOperationException("Both a strong-named and a weak-named assembly have been generated.");
			}
			if (this.StrongNamedModule != null)
			{
				return this.SaveAssembly(true);
			}
			if (this.WeakNamedModule != null)
			{
				return this.SaveAssembly(false);
			}
			return null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003770 File Offset: 0x00001970
		public string SaveAssembly(bool strongNamed)
		{
			if (!this.savePhysicalAssembly)
			{
				return null;
			}
			AssemblyBuilder assemblyBuilder;
			string assemblyFileName;
			string fullyQualifiedName;
			if (strongNamed)
			{
				if (this.StrongNamedModule == null)
				{
					throw new InvalidOperationException("No strong-named assembly has been generated.");
				}
				assemblyBuilder = (AssemblyBuilder)this.StrongNamedModule.Assembly;
				assemblyFileName = this.StrongNamedModuleName;
				fullyQualifiedName = this.StrongNamedModule.FullyQualifiedName;
			}
			else
			{
				if (this.WeakNamedModule == null)
				{
					throw new InvalidOperationException("No weak-named assembly has been generated.");
				}
				assemblyBuilder = (AssemblyBuilder)this.WeakNamedModule.Assembly;
				assemblyFileName = this.WeakNamedModuleName;
				fullyQualifiedName = this.WeakNamedModule.FullyQualifiedName;
			}
			if (File.Exists(fullyQualifiedName))
			{
				File.Delete(fullyQualifiedName);
			}
			this.AddCacheMappings(assemblyBuilder);
			assemblyBuilder.Save(assemblyFileName);
			return fullyQualifiedName;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003824 File Offset: 0x00001A24
		private void AddCacheMappings(AssemblyBuilder builder)
		{
			Dictionary<CacheKey, string> mappings = new Dictionary<CacheKey, string>();
			this.typeCache.ForEach(delegate(CacheKey key, Type value)
			{
				if (builder.Equals(value.Assembly))
				{
					mappings.Add(key, value.FullName);
				}
			});
			CacheMappingsAttribute.ApplyTo(builder, mappings);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003874 File Offset: 0x00001A74
		public void LoadAssemblyIntoCache(Assembly assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			CacheMappingsAttribute[] array = (CacheMappingsAttribute[])assembly.GetCustomAttributes(typeof(CacheMappingsAttribute), false);
			if (array.Length == 0)
			{
				throw new ArgumentException(string.Format("The given assembly '{0}' does not contain any cache information for generated types.", assembly.FullName), "assembly");
			}
			foreach (KeyValuePair<CacheKey, string> keyValuePair in array[0].GetDeserializedMappings())
			{
				Type type = assembly.GetType(keyValuePair.Value);
				if (type != null)
				{
					this.typeCache.AddOrUpdateWithoutTakingLock(keyValuePair.Key, type);
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003934 File Offset: 0x00001B34
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TypeBuilder DefineType(bool inSignedModulePreferably, string name, TypeAttributes flags)
		{
			return this.ObtainDynamicModule(!this.disableSignedModule && inSignedModulePreferably).DefineType(name, flags);
		}

		// Token: 0x0400001D RID: 29
		public static readonly string DEFAULT_FILE_NAME = "CastleDynProxy2.dll";

		// Token: 0x0400001E RID: 30
		public static readonly string DEFAULT_ASSEMBLY_NAME = "DynamicProxyGenAssembly2";

		// Token: 0x0400001F RID: 31
		private ModuleBuilder moduleBuilderWithStrongName;

		// Token: 0x04000020 RID: 32
		private ModuleBuilder moduleBuilder;

		// Token: 0x04000021 RID: 33
		private readonly string strongAssemblyName;

		// Token: 0x04000022 RID: 34
		private readonly string weakAssemblyName;

		// Token: 0x04000023 RID: 35
		private readonly string strongModulePath;

		// Token: 0x04000024 RID: 36
		private readonly string weakModulePath;

		// Token: 0x04000025 RID: 37
		private readonly SynchronizedDictionary<CacheKey, Type> typeCache = new SynchronizedDictionary<CacheKey, Type>();

		// Token: 0x04000026 RID: 38
		[Obsolete]
		private readonly Lock cacheLock;

		// Token: 0x04000027 RID: 39
		private readonly object moduleLocker = new object();

		// Token: 0x04000028 RID: 40
		private readonly bool savePhysicalAssembly;

		// Token: 0x04000029 RID: 41
		private readonly bool disableSignedModule;

		// Token: 0x0400002A RID: 42
		private readonly INamingScope namingScope;
	}
}
