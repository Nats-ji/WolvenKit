using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeCameraFocus : CBehaviorGraphConstraintNode
	{
		[Ordinal(1)] [RED("bone")] 		public CString Bone { get; set;}

		[Ordinal(2)] [RED("bone2")] 		public CString Bone2 { get; set;}

		public CBehaviorGraphConstraintNodeCameraFocus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNodeCameraFocus(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}