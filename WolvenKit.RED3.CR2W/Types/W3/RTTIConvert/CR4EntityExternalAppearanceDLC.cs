using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4EntityExternalAppearanceDLC : CObject
	{
		[Ordinal(1)] [RED("appearanceToRepleace")] 		public CName AppearanceToRepleace { get; set;}

		[Ordinal(2)] [RED("entityExternalAppearance")] 		public CHandle<CEntityExternalAppearance> EntityExternalAppearance { get; set;}

		public CR4EntityExternalAppearanceDLC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4EntityExternalAppearanceDLC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}