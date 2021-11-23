using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cryptic_Stresser.Properties
{
	// Token: 0x02000014 RID: 20
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00002320 File Offset: 0x00000520
		internal Resources()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Cryptic_Stresser.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000EC94 File Offset: 0x0000CE94
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000232A File Offset: 0x0000052A
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040000BB RID: 187
		private static ResourceManager resourceMan;

		// Token: 0x040000BC RID: 188
		private static CultureInfo resourceCulture;
	}
}
