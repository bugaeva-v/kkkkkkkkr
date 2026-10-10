using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Permissions;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Reflection
{
	/// <summary>Инкапсулирует доступ к паре открытого и закрытого ключей, используемых для подписи сборок со строгим именем.</summary>
	// Token: 0x02000905 RID: 2309
	[ComVisible(true)]
	[Serializable]
	public class StrongNameKeyPair : ISerializable, IDeserializationCallback
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.StrongNameKeyPair" />, который создает пару ключей из байтового <see langword="byte" /> массива.</summary>
		/// <param name="keyPairArray">Массив типа <see langword="byte" />, содержащий пару ключей.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyPairArray" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004E44 RID: 20036 RVA: 0x000F5DF6 File Offset: 0x000F3FF6
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public StrongNameKeyPair(byte[] keyPairArray)
		{
			if (keyPairArray == null)
			{
				throw new ArgumentNullException("keyPairArray");
			}
			this.LoadKey(keyPairArray);
			this.GetRSA();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.StrongNameKeyPair" />, который строит пару ключей из объекта типа <see langword="FileStream" />.</summary>
		/// <param name="keyPairFile">Объект <see langword="FileStream" />, содержащий пару ключей.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyPairFile" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004E45 RID: 20037 RVA: 0x000F5E1C File Offset: 0x000F401C
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public StrongNameKeyPair(FileStream keyPairFile)
		{
			if (keyPairFile == null)
			{
				throw new ArgumentNullException("keyPairFile");
			}
			byte[] array = new byte[keyPairFile.Length];
			keyPairFile.Read(array, 0, array.Length);
			this.LoadKey(array);
			this.GetRSA();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.StrongNameKeyPair" />, который строит пару ключей из объекта типа <see langword="String" />.</summary>
		/// <param name="keyPairContainer">Строка, содержащая пару ключей.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyPairContainer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004E46 RID: 20038 RVA: 0x000F5E64 File Offset: 0x000F4064
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public StrongNameKeyPair(string keyPairContainer)
		{
			if (keyPairContainer == null)
			{
				throw new ArgumentNullException("keyPairContainer");
			}
			this._keyPairContainer = keyPairContainer;
			this.GetRSA();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.StrongNameKeyPair" />, который создает пару ключей из сериализованных данных.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий данные сериализованных объектов.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06004E47 RID: 20039 RVA: 0x000F5E88 File Offset: 0x000F4088
		protected StrongNameKeyPair(SerializationInfo info, StreamingContext context)
		{
			this._publicKey = (byte[])info.GetValue("_publicKey", typeof(byte[]));
			this._keyPairContainer = info.GetString("_keyPairContainer");
			this._keyPairExported = info.GetBoolean("_keyPairExported");
			this._keyPairArray = (byte[])info.GetValue("_keyPairArray", typeof(byte[]));
		}

		/// <summary>Задает для объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" /> все данные, необходимые для повторного создания экземпляра текущего объекта <see cref="T:System.Reflection.StrongNameKeyPair" />.</summary>
		/// <param name="info">Объект, для которого будут заполнены сведения о сериализации.</param>
		/// <param name="context">Контекст назначения сериализации.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="info" /> — <see langword="null" />.</exception>
		// Token: 0x06004E48 RID: 20040 RVA: 0x000F5F00 File Offset: 0x000F4100
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_publicKey", this._publicKey, typeof(byte[]));
			info.AddValue("_keyPairContainer", this._keyPairContainer);
			info.AddValue("_keyPairExported", this._keyPairExported);
			info.AddValue("_keyPairArray", this._keyPairArray, typeof(byte[]));
		}

		/// <summary>Выполняется, когда полностью десериализован граф объектов.</summary>
		/// <param name="sender">Объект, который инициализирует обратный вызов.</param>
		// Token: 0x06004E49 RID: 20041 RVA: 0x00004BF9 File Offset: 0x00002DF9
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x000F5F68 File Offset: 0x000F4168
		private RSA GetRSA()
		{
			if (this._rsa != null)
			{
				return this._rsa;
			}
			if (this._keyPairArray != null)
			{
				try
				{
					this._rsa = CryptoConvert.FromCapiKeyBlob(this._keyPairArray);
					goto IL_5A;
				}
				catch
				{
					this._keyPairArray = null;
					goto IL_5A;
				}
			}
			if (this._keyPairContainer != null)
			{
				this._rsa = new RSACryptoServiceProvider(new CspParameters
				{
					KeyContainerName = this._keyPairContainer
				});
			}
			IL_5A:
			return this._rsa;
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x000F5FE8 File Offset: 0x000F41E8
		private void LoadKey(byte[] key)
		{
			try
			{
				if (key.Length == 16)
				{
					int i = 0;
					int num = 0;
					while (i < key.Length)
					{
						num += (int)key[i++];
					}
					if (num == 4)
					{
						this._publicKey = (byte[])key.Clone();
					}
				}
				else
				{
					this._keyPairArray = key;
				}
			}
			catch
			{
			}
		}

		/// <summary>Получает открытую часть открытого ключа или лексему открытого ключа пары ключей.</summary>
		/// <returns>Массив типа <see langword="byte" />, содержащий открытый ключ или лексему открытого ключа пары ключей.</returns>
		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x000F6048 File Offset: 0x000F4248
		public byte[] PublicKey
		{
			get
			{
				if (this._publicKey == null)
				{
					RSA rsa = this.GetRSA();
					if (rsa == null)
					{
						throw new ArgumentException("invalid keypair");
					}
					byte[] array = CryptoConvert.ToCapiKeyBlob(rsa, false);
					this._publicKey = new byte[array.Length + 12];
					this._publicKey[0] = 0;
					this._publicKey[1] = 36;
					this._publicKey[2] = 0;
					this._publicKey[3] = 0;
					this._publicKey[4] = 4;
					this._publicKey[5] = 128;
					this._publicKey[6] = 0;
					this._publicKey[7] = 0;
					int num = array.Length;
					this._publicKey[8] = (byte)(num % 256);
					this._publicKey[9] = (byte)(num / 256);
					this._publicKey[10] = 0;
					this._publicKey[11] = 0;
					Buffer.BlockCopy(array, 0, this._publicKey, 12, array.Length);
				}
				return this._publicKey;
			}
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x000F612C File Offset: 0x000F432C
		internal StrongName StrongName()
		{
			RSA rsa = this.GetRSA();
			if (rsa != null)
			{
				return new StrongName(rsa);
			}
			if (this._publicKey != null)
			{
				return new StrongName(this._publicKey);
			}
			return null;
		}

		// Token: 0x0400307E RID: 12414
		private byte[] _publicKey;

		// Token: 0x0400307F RID: 12415
		private string _keyPairContainer;

		// Token: 0x04003080 RID: 12416
		private bool _keyPairExported;

		// Token: 0x04003081 RID: 12417
		private byte[] _keyPairArray;

		// Token: 0x04003082 RID: 12418
		[NonSerialized]
		private RSA _rsa;
	}
}
