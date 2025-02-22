using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleMessage : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("_bDuringDisplay")] 		public CBool _bDuringDisplay { get; set;}

		[Ordinal(2)] [RED("_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> _flashValueStorage { get; set;}

		public CR4HudModuleMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleMessage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}