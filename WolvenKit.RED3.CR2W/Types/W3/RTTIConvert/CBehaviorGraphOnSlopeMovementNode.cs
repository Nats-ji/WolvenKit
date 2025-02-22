using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphOnSlopeMovementNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("angles", 2,0)] 		public CArray<CFloat> Angles { get; set;}

		[Ordinal(2)] [RED("slopeBlendTime")] 		public CFloat SlopeBlendTime { get; set;}

		[Ordinal(3)] [RED("slopeMaxBlendSpeed")] 		public CFloat SlopeMaxBlendSpeed { get; set;}

		[Ordinal(4)] [RED("neverReachBorderValues")] 		public CBool NeverReachBorderValues { get; set;}

		public CBehaviorGraphOnSlopeMovementNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphOnSlopeMovementNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}