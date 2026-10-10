using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine.Device
{
	// Token: 0x02000454 RID: 1108
	public static class SystemInfo
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x0004153D File Offset: 0x0003F73D
		public static float batteryLevel
		{
			get
			{
				return SystemInfo.batteryLevel;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x00041544 File Offset: 0x0003F744
		public static BatteryStatus batteryStatus
		{
			get
			{
				return SystemInfo.batteryStatus;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x0004154B File Offset: 0x0003F74B
		public static string operatingSystem
		{
			get
			{
				return SystemInfo.operatingSystem;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x00041552 File Offset: 0x0003F752
		public static OperatingSystemFamily operatingSystemFamily
		{
			get
			{
				return SystemInfo.operatingSystemFamily;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x00041559 File Offset: 0x0003F759
		public static string processorType
		{
			get
			{
				return SystemInfo.processorType;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x00041560 File Offset: 0x0003F760
		public static int processorFrequency
		{
			get
			{
				return SystemInfo.processorFrequency;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x00041567 File Offset: 0x0003F767
		public static int processorCount
		{
			get
			{
				return SystemInfo.processorCount;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x0004156E File Offset: 0x0003F76E
		public static int systemMemorySize
		{
			get
			{
				return SystemInfo.systemMemorySize;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x00041575 File Offset: 0x0003F775
		public static string deviceUniqueIdentifier
		{
			get
			{
				return SystemInfo.deviceUniqueIdentifier;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x0004157C File Offset: 0x0003F77C
		public static string deviceName
		{
			get
			{
				return SystemInfo.deviceName;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x00041583 File Offset: 0x0003F783
		public static string deviceModel
		{
			get
			{
				return SystemInfo.deviceModel;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x0004158A File Offset: 0x0003F78A
		public static bool supportsAccelerometer
		{
			get
			{
				return SystemInfo.supportsAccelerometer;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x00041591 File Offset: 0x0003F791
		public static bool supportsGyroscope
		{
			get
			{
				return SystemInfo.supportsGyroscope;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x00041598 File Offset: 0x0003F798
		public static bool supportsLocationService
		{
			get
			{
				return SystemInfo.supportsLocationService;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x0004159F File Offset: 0x0003F79F
		public static bool supportsVibration
		{
			get
			{
				return SystemInfo.supportsVibration;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000415A6 File Offset: 0x0003F7A6
		public static bool supportsAudio
		{
			get
			{
				return SystemInfo.supportsAudio;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000415AD File Offset: 0x0003F7AD
		public static DeviceType deviceType
		{
			get
			{
				return SystemInfo.deviceType;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000415B4 File Offset: 0x0003F7B4
		public static int graphicsMemorySize
		{
			get
			{
				return SystemInfo.graphicsMemorySize;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x000415BB File Offset: 0x0003F7BB
		public static string graphicsDeviceName
		{
			get
			{
				return SystemInfo.graphicsDeviceName;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000415C2 File Offset: 0x0003F7C2
		public static string graphicsDeviceVendor
		{
			get
			{
				return SystemInfo.graphicsDeviceVendor;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000415C9 File Offset: 0x0003F7C9
		public static int graphicsDeviceID
		{
			get
			{
				return SystemInfo.graphicsDeviceID;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000415D0 File Offset: 0x0003F7D0
		public static int graphicsDeviceVendorID
		{
			get
			{
				return SystemInfo.graphicsDeviceVendorID;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x000415D7 File Offset: 0x0003F7D7
		public static GraphicsDeviceType graphicsDeviceType
		{
			get
			{
				return SystemInfo.graphicsDeviceType;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000415DE File Offset: 0x0003F7DE
		public static bool graphicsUVStartsAtTop
		{
			get
			{
				return SystemInfo.graphicsUVStartsAtTop;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x000415E5 File Offset: 0x0003F7E5
		public static string graphicsDeviceVersion
		{
			get
			{
				return SystemInfo.graphicsDeviceVersion;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000415EC File Offset: 0x0003F7EC
		public static int graphicsShaderLevel
		{
			get
			{
				return SystemInfo.graphicsShaderLevel;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000415F3 File Offset: 0x0003F7F3
		public static bool graphicsMultiThreaded
		{
			get
			{
				return SystemInfo.graphicsMultiThreaded;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000415FA File Offset: 0x0003F7FA
		public static RenderingThreadingMode renderingThreadingMode
		{
			get
			{
				return SystemInfo.renderingThreadingMode;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x00041601 File Offset: 0x0003F801
		public static bool hasHiddenSurfaceRemovalOnGPU
		{
			get
			{
				return SystemInfo.hasHiddenSurfaceRemovalOnGPU;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x00041608 File Offset: 0x0003F808
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders
		{
			get
			{
				return SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x0004160F File Offset: 0x0003F80F
		public static bool supportsShadows
		{
			get
			{
				return SystemInfo.supportsShadows;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x00041616 File Offset: 0x0003F816
		public static bool supportsRawShadowDepthSampling
		{
			get
			{
				return SystemInfo.supportsRawShadowDepthSampling;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x0004161D File Offset: 0x0003F81D
		public static bool supportsMotionVectors
		{
			get
			{
				return SystemInfo.supportsMotionVectors;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x00041624 File Offset: 0x0003F824
		public static bool supports3DTextures
		{
			get
			{
				return SystemInfo.supports3DTextures;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x0004162B File Offset: 0x0003F82B
		public static bool supportsCompressed3DTextures
		{
			get
			{
				return SystemInfo.supportsCompressed3DTextures;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x00041632 File Offset: 0x0003F832
		public static bool supports2DArrayTextures
		{
			get
			{
				return SystemInfo.supports2DArrayTextures;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x00041639 File Offset: 0x0003F839
		public static bool supports3DRenderTextures
		{
			get
			{
				return SystemInfo.supports3DRenderTextures;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x00041640 File Offset: 0x0003F840
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				return SystemInfo.supportsCubemapArrayTextures;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x00041647 File Offset: 0x0003F847
		public static bool supportsAnisotropicFilter
		{
			get
			{
				return SystemInfo.supportsAnisotropicFilter;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x0004164E File Offset: 0x0003F84E
		public static CopyTextureSupport copyTextureSupport
		{
			get
			{
				return SystemInfo.copyTextureSupport;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x00041655 File Offset: 0x0003F855
		public static bool supportsComputeShaders
		{
			get
			{
				return SystemInfo.supportsComputeShaders;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x0004165C File Offset: 0x0003F85C
		public static bool supportsGeometryShaders
		{
			get
			{
				return SystemInfo.supportsGeometryShaders;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x00041663 File Offset: 0x0003F863
		public static bool supportsTessellationShaders
		{
			get
			{
				return SystemInfo.supportsTessellationShaders;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x0004166A File Offset: 0x0003F86A
		public static bool supportsRenderTargetArrayIndexFromVertexShader
		{
			get
			{
				return SystemInfo.supportsRenderTargetArrayIndexFromVertexShader;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x00041671 File Offset: 0x0003F871
		public static bool supportsInstancing
		{
			get
			{
				return SystemInfo.supportsInstancing;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x00041678 File Offset: 0x0003F878
		public static bool supportsHardwareQuadTopology
		{
			get
			{
				return SystemInfo.supportsHardwareQuadTopology;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x0004167F File Offset: 0x0003F87F
		public static bool supports32bitsIndexBuffer
		{
			get
			{
				return SystemInfo.supports32bitsIndexBuffer;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x00041686 File Offset: 0x0003F886
		public static bool supportsSparseTextures
		{
			get
			{
				return SystemInfo.supportsSparseTextures;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x0004168D File Offset: 0x0003F88D
		public static int supportedRenderTargetCount
		{
			get
			{
				return SystemInfo.supportedRenderTargetCount;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x00041694 File Offset: 0x0003F894
		public static bool supportsSeparatedRenderTargetsBlend
		{
			get
			{
				return SystemInfo.supportsSeparatedRenderTargetsBlend;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x0004169B File Offset: 0x0003F89B
		public static int supportedRandomWriteTargetCount
		{
			get
			{
				return SystemInfo.supportedRandomWriteTargetCount;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000416A2 File Offset: 0x0003F8A2
		public static int supportsMultisampledTextures
		{
			get
			{
				return SystemInfo.supportsMultisampledTextures;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x000416A9 File Offset: 0x0003F8A9
		public static bool supportsMultisampled2DArrayTextures
		{
			get
			{
				return SystemInfo.supportsMultisampled2DArrayTextures;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000416B0 File Offset: 0x0003F8B0
		public static bool supportsMultisampleAutoResolve
		{
			get
			{
				return SystemInfo.supportsMultisampleAutoResolve;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000416B7 File Offset: 0x0003F8B7
		public static int supportsTextureWrapMirrorOnce
		{
			get
			{
				return SystemInfo.supportsTextureWrapMirrorOnce;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000416BE File Offset: 0x0003F8BE
		public static bool usesReversedZBuffer
		{
			get
			{
				return SystemInfo.usesReversedZBuffer;
			}
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000416C8 File Offset: 0x0003F8C8
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRenderTextureFormat(format);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000416E0 File Offset: 0x0003F8E0
		public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsBlendingOnRenderTextureFormat(format);
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000416F8 File Offset: 0x0003F8F8
		public static bool SupportsTextureFormat(TextureFormat format)
		{
			return SystemInfo.SupportsTextureFormat(format);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00041710 File Offset: 0x0003F910
		public static bool SupportsVertexAttributeFormat(VertexAttributeFormat format, int dimension)
		{
			return SystemInfo.SupportsVertexAttributeFormat(format, dimension);
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x00041729 File Offset: 0x0003F929
		public static NPOTSupport npotSupport
		{
			get
			{
				return SystemInfo.npotSupport;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x00041730 File Offset: 0x0003F930
		public static int maxTextureSize
		{
			get
			{
				return SystemInfo.maxTextureSize;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x00041737 File Offset: 0x0003F937
		public static int maxTexture3DSize
		{
			get
			{
				return SystemInfo.maxTexture3DSize;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x0004173E File Offset: 0x0003F93E
		public static int maxTextureArraySlices
		{
			get
			{
				return SystemInfo.maxTextureArraySlices;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x00041745 File Offset: 0x0003F945
		public static int maxCubemapSize
		{
			get
			{
				return SystemInfo.maxCubemapSize;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x0004174C File Offset: 0x0003F94C
		public static int maxAnisotropyLevel
		{
			get
			{
				return SystemInfo.maxAnisotropyLevel;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x00041753 File Offset: 0x0003F953
		public static int maxComputeBufferInputsVertex
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsVertex;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x0004175A File Offset: 0x0003F95A
		public static int maxComputeBufferInputsFragment
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsFragment;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x00041761 File Offset: 0x0003F961
		public static int maxComputeBufferInputsGeometry
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsGeometry;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x00041768 File Offset: 0x0003F968
		public static int maxComputeBufferInputsDomain
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsDomain;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x0004176F File Offset: 0x0003F96F
		public static int maxComputeBufferInputsHull
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsHull;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x00041776 File Offset: 0x0003F976
		public static int maxComputeBufferInputsCompute
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsCompute;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x0004177D File Offset: 0x0003F97D
		public static int maxComputeWorkGroupSize
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSize;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x00041784 File Offset: 0x0003F984
		public static int maxComputeWorkGroupSizeX
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeX;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x0004178B File Offset: 0x0003F98B
		public static int maxComputeWorkGroupSizeY
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeY;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x00041792 File Offset: 0x0003F992
		public static int maxComputeWorkGroupSizeZ
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeZ;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x00041799 File Offset: 0x0003F999
		public static int computeSubGroupSize
		{
			get
			{
				return SystemInfo.computeSubGroupSize;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x000417A0 File Offset: 0x0003F9A0
		public static bool supportsAsyncCompute
		{
			get
			{
				return SystemInfo.supportsAsyncCompute;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x000417A7 File Offset: 0x0003F9A7
		public static bool supportsGpuRecorder
		{
			get
			{
				return SystemInfo.supportsGpuRecorder;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000417AE File Offset: 0x0003F9AE
		public static bool supportsGraphicsFence
		{
			get
			{
				return SystemInfo.supportsGraphicsFence;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x000417B5 File Offset: 0x0003F9B5
		public static bool supportsAsyncGPUReadback
		{
			get
			{
				return SystemInfo.supportsAsyncGPUReadback;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x000417BC File Offset: 0x0003F9BC
		public static bool supportsRayTracing
		{
			get
			{
				return SystemInfo.supportsRayTracing;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x000417C3 File Offset: 0x0003F9C3
		public static bool supportsSetConstantBuffer
		{
			get
			{
				return SystemInfo.supportsSetConstantBuffer;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x000417CA File Offset: 0x0003F9CA
		public static int constantBufferOffsetAlignment
		{
			get
			{
				return SystemInfo.constantBufferOffsetAlignment;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x000417D1 File Offset: 0x0003F9D1
		public static long maxGraphicsBufferSize
		{
			get
			{
				return SystemInfo.maxGraphicsBufferSize;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000417D8 File Offset: 0x0003F9D8
		public static bool hasMipMaxLevel
		{
			get
			{
				return SystemInfo.hasMipMaxLevel;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000417DF File Offset: 0x0003F9DF
		public static bool supportsMipStreaming
		{
			get
			{
				return SystemInfo.supportsMipStreaming;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000417E6 File Offset: 0x0003F9E6
		public static bool usesLoadStoreActions
		{
			get
			{
				return SystemInfo.usesLoadStoreActions;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x000417ED File Offset: 0x0003F9ED
		public static HDRDisplaySupportFlags hdrDisplaySupportFlags
		{
			get
			{
				return SystemInfo.hdrDisplaySupportFlags;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x000417F4 File Offset: 0x0003F9F4
		public static bool supportsConservativeRaster
		{
			get
			{
				return SystemInfo.supportsConservativeRaster;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x000417FB File Offset: 0x0003F9FB
		public static bool supportsMultiview
		{
			get
			{
				return SystemInfo.supportsMultiview;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x00041802 File Offset: 0x0003FA02
		public static bool supportsStoreAndResolveAction
		{
			get
			{
				return SystemInfo.supportsStoreAndResolveAction;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x00041809 File Offset: 0x0003FA09
		public static bool supportsMultisampleResolveDepth
		{
			get
			{
				return SystemInfo.supportsMultisampleResolveDepth;
			}
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00041810 File Offset: 0x0003FA10
		public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
		{
			return SystemInfo.IsFormatSupported(format, usage);
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0004182C File Offset: 0x0003FA2C
		public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
		{
			return SystemInfo.GetCompatibleFormat(format, usage);
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00041848 File Offset: 0x0003FA48
		public static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
		{
			return SystemInfo.GetGraphicsFormat(format);
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00041860 File Offset: 0x0003FA60
		public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			return SystemInfo.GetRenderTextureSupportedMSAASampleCount(desc);
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00041878 File Offset: 0x0003FA78
		public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormat(format);
		}

		// Token: 0x04000E3D RID: 3645
		public const string unsupportedIdentifier = "n/a";
	}
}
