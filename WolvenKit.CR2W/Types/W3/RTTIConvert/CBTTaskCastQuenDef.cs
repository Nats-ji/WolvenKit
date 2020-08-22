using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCastQuenDef : CBTTaskCastSignDef
	{
		[RED("completeAfterHit")] 		public CBool CompleteAfterHit { get; set;}

		[RED("alternateFireMode")] 		public CBool AlternateFireMode { get; set;}

		[RED("processQuenOnCounterActivation")] 		public CBool ProcessQuenOnCounterActivation { get; set;}

		public CBTTaskCastQuenDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCastQuenDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}