using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CLineMotionExtraction : IMotionExtraction
	{
		[Ordinal(1)] [RED("frames", 2,0)] 		public CArray<Vector> Frames { get; set;}

		[Ordinal(2)] [RED("times", 2,0)] 		public CArray<CFloat> Times { get; set;}

		public CLineMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLineMotionExtraction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}