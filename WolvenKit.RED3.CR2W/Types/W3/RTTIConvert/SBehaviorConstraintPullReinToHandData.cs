using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintPullReinToHandData : CVariable
	{
		[Ordinal(1)] [RED("reinBoneName")] 		public CName ReinBoneName { get; set;}

		[Ordinal(2)] [RED("reinContactPoint")] 		public Vector ReinContactPoint { get; set;}

		[Ordinal(3)] [RED("handBoneName")] 		public CName HandBoneName { get; set;}

		[Ordinal(4)] [RED("handContactPoint")] 		public Vector HandContactPoint { get; set;}

		public SBehaviorConstraintPullReinToHandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorConstraintPullReinToHandData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}