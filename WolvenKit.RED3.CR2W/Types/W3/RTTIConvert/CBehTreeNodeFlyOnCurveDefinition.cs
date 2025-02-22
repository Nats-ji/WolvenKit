using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeFlyOnCurveDefinition : CBehTreeNodeAttachToCurveDefinition
	{
		[Ordinal(1)] [RED("animValPitch")] 		public CBehTreeValCName AnimValPitch { get; set;}

		[Ordinal(2)] [RED("animValYaw")] 		public CBehTreeValCName AnimValYaw { get; set;}

		[Ordinal(3)] [RED("maxPitchInput")] 		public CBehTreeValFloat MaxPitchInput { get; set;}

		[Ordinal(4)] [RED("maxPitchOutput")] 		public CBehTreeValFloat MaxPitchOutput { get; set;}

		[Ordinal(5)] [RED("maxYawInput")] 		public CBehTreeValFloat MaxYawInput { get; set;}

		[Ordinal(6)] [RED("maxYawOutput")] 		public CBehTreeValFloat MaxYawOutput { get; set;}

		public CBehTreeNodeFlyOnCurveDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeFlyOnCurveDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}