using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeRoll : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(2)] [RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		public CBehaviorGraphConstraintNodeRoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNodeRoll(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}