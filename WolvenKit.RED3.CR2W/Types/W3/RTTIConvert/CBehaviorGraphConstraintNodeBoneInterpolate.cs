using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeBoneInterpolate : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("boneInputA")] 		public CString BoneInputA { get; set;}

		[Ordinal(2)] [RED("boneInputB")] 		public CString BoneInputB { get; set;}

		[Ordinal(3)] [RED("boneOutput")] 		public CString BoneOutput { get; set;}

		[Ordinal(4)] [RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		public CBehaviorGraphConstraintNodeBoneInterpolate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNodeBoneInterpolate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}