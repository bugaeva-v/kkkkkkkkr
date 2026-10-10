using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using Unity;

namespace System.Security.Policy
{
	/// <summary>Предоставляет свидетельство относительно хэш-значения для сборки. Этот класс не наследуется.</summary>
	// Token: 0x02000412 RID: 1042
	[ComVisible(true)]
	[Serializable]
	public sealed class Hash : EvidenceBase, ISerializable, IBuiltInEvidence
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.Hash" />.</summary>
		/// <param name="assembly">Сборка, для которой вычисляется хэш-значение.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assembly" /> не является <see cref="T:System.Reflection.Assembly" /> среды выполнения.</exception>
		// Token: 0x06002A9C RID: 10908 RVA: 0x0009A175 File Offset: 0x00098375
		public Hash(Assembly assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			this.assembly = assembly;
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00097E22 File Offset: 0x00096022
		internal Hash()
		{
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0009A198 File Offset: 0x00098398
		internal Hash(SerializationInfo info, StreamingContext context)
		{
			this.data = (byte[])info.GetValue("RawData", typeof(byte[]));
		}

		/// <summary>Получает хэш-значение <see cref="T:System.Security.Cryptography.MD5" /> для сборки.</summary>
		/// <returns>Массив байтов, представляющий хэш-значение <see cref="T:System.Security.Cryptography.MD5" /> для сборки.</returns>
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x0009A1C0 File Offset: 0x000983C0
		public byte[] MD5
		{
			get
			{
				if (this._md5 != null)
				{
					return this._md5;
				}
				if (this.assembly == null && this._sha1 != null)
				{
					throw new SecurityException(Locale.GetText("No assembly data. This instance was initialized with an MSHA1 digest value."));
				}
				HashAlgorithm hashAlg = System.Security.Cryptography.MD5.Create();
				this._md5 = this.GenerateHash(hashAlg);
				return this._md5;
			}
		}

		/// <summary>Получает хэш-значение <see cref="T:System.Security.Cryptography.SHA1" /> для сборки.</summary>
		/// <returns>Массив байтов, представляющий хэш-значение <see cref="T:System.Security.Cryptography.SHA1" /> для сборки.</returns>
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x0009A21C File Offset: 0x0009841C
		public byte[] SHA1
		{
			get
			{
				if (this._sha1 != null)
				{
					return this._sha1;
				}
				if (this.assembly == null && this._md5 != null)
				{
					throw new SecurityException(Locale.GetText("No assembly data. This instance was initialized with an MD5 digest value."));
				}
				HashAlgorithm hashAlg = System.Security.Cryptography.SHA1.Create();
				this._sha1 = this.GenerateHash(hashAlg);
				return this._sha1;
			}
		}

		/// <summary>Вычисляет хэш-значение для сборки с использованием указанного алгоритма хэша.</summary>
		/// <param name="hashAlg">Алгоритм хэша, используемый при вычислении хэш-значений для сборки.</param>
		/// <returns>Массив байтов, представляющий хэш-значение для сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hashAlg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Хэш-значение для сборки не может быть создано.</exception>
		// Token: 0x06002AA1 RID: 10913 RVA: 0x0009A277 File Offset: 0x00098477
		public byte[] GenerateHash(HashAlgorithm hashAlg)
		{
			if (hashAlg == null)
			{
				throw new ArgumentNullException("hashAlg");
			}
			return hashAlg.ComputeHash(this.GetData());
		}

		/// <summary>Получает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с именем параметра и дополнительными сведениями об исключении.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06002AA2 RID: 10914 RVA: 0x0009A293 File Offset: 0x00098493
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("RawData", this.GetData());
		}

		/// <summary>Возвращает строковое представление текущего объекта <see cref="T:System.Security.Policy.Hash" />.</summary>
		/// <returns>Представление текущего объекта <see cref="T:System.Security.Policy.Hash" />.</returns>
		// Token: 0x06002AA3 RID: 10915 RVA: 0x0009A2B4 File Offset: 0x000984B4
		public override string ToString()
		{
			SecurityElement securityElement = new SecurityElement(base.GetType().FullName);
			securityElement.AddAttribute("version", "1");
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = this.GetData();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X2"));
			}
			securityElement.AddChild(new SecurityElement("RawData", stringBuilder.ToString()));
			return securityElement.ToString();
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0009A334 File Offset: 0x00098534
		[FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
		private byte[] GetData()
		{
			if (this.assembly == null && this.data == null)
			{
				throw new SecurityException(Locale.GetText("No assembly data."));
			}
			if (this.data == null)
			{
				FileStream fileStream = new FileStream(this.assembly.Location, FileMode.Open, FileAccess.Read);
				this.data = new byte[fileStream.Length];
				fileStream.Read(this.data, 0, (int)fileStream.Length);
			}
			return this.data;
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x0009A3AF File Offset: 0x000985AF
		int IBuiltInEvidence.GetRequiredSize(bool verbose)
		{
			if (!verbose)
			{
				return 0;
			}
			return 5;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.InitFromBuffer(char[] buffer, int position)
		{
			return 0;
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.OutputToBuffer(char[] buffer, int position, bool verbose)
		{
			return 0;
		}

		/// <summary>Создает объект <see cref="T:System.Security.Policy.Hash" />, содержащий хэш-значение <see cref="T:System.Security.Cryptography.MD5" />.</summary>
		/// <param name="md5">Массив байтов, содержащий хэш-значение <see cref="T:System.Security.Cryptography.MD5" />.</param>
		/// <returns>Объект, содержащий хэш-значение, предоставленное параметром <paramref name="md5" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="md5" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002AA8 RID: 10920 RVA: 0x0009A3B7 File Offset: 0x000985B7
		public static Hash CreateMD5(byte[] md5)
		{
			if (md5 == null)
			{
				throw new ArgumentNullException("md5");
			}
			return new Hash
			{
				_md5 = md5
			};
		}

		/// <summary>Создает объект <see cref="T:System.Security.Policy.Hash" />, содержащий хэш-значение <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
		/// <param name="sha1">Массив байтов, содержащий хэш-значение <see cref="T:System.Security.Cryptography.SHA1" />.</param>
		/// <returns>Объект, содержащий хэш-значение, предоставленное параметром <paramref name="sha1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sha1" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002AA9 RID: 10921 RVA: 0x0009A3D3 File Offset: 0x000985D3
		public static Hash CreateSHA1(byte[] sha1)
		{
			if (sha1 == null)
			{
				throw new ArgumentNullException("sha1");
			}
			return new Hash
			{
				_sha1 = sha1
			};
		}

		/// <summary>Получает хэш-значение <see cref="T:System.Security.Cryptography.SHA256" /> для сборки.</summary>
		/// <returns>Массив байтов, представляющий хэш-значение <see cref="T:System.Security.Cryptography.SHA256" /> для сборки.</returns>
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x00052955 File Offset: 0x00050B55
		public byte[] SHA256
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Создает объект <see cref="T:System.Security.Policy.Hash" />, содержащий хэш-значение <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
		/// <param name="sha256">Массив байтов, содержащий хэш-значение <see cref="T:System.Security.Cryptography.SHA256" />.</param>
		/// <returns>Хэш-объект, содержащий хэш-значение, предоставленное параметром <paramref name="sha256" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sha256" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002AAB RID: 10923 RVA: 0x00052955 File Offset: 0x00050B55
		public static Hash CreateSHA256(byte[] sha256)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		// Token: 0x04001F98 RID: 8088
		private Assembly assembly;

		// Token: 0x04001F99 RID: 8089
		private byte[] data;

		// Token: 0x04001F9A RID: 8090
		internal byte[] _md5;

		// Token: 0x04001F9B RID: 8091
		internal byte[] _sha1;
	}
}
