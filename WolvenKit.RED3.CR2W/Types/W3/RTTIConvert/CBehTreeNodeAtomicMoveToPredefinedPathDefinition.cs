using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeAtomicMoveToPredefinedPathDefinition : CBehTreeNodeAtomicMoveToDefinition
	{
		[Ordinal(1)] [RED("pathName")] 		public CBehTreeValCName PathName { get; set;}

		[Ordinal(2)] [RED("upThePath")] 		public CBehTreeValBool UpThePath { get; set;}

		[Ordinal(3)] [RED("startFromBeginning")] 		public CBehTreeValBool StartFromBeginning { get; set;}

		public CBehTreeNodeAtomicMoveToPredefinedPathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeAtomicMoveToPredefinedPathDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}