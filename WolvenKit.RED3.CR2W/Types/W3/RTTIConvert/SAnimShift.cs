using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimShift : CVariable
	{
		[Ordinal(1)] [RED("originalTransform")] 		public CMatrix OriginalTransform { get; set;}

		[Ordinal(2)] [RED("transform")] 		public CMatrix Transform { get; set;}

		[Ordinal(3)] [RED("time")] 		public CFloat Time { get; set;}

		public SAnimShift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimShift(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}