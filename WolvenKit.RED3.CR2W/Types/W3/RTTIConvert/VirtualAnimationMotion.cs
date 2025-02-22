using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VirtualAnimationMotion : CVariable
	{
		[Ordinal(1)] [RED("startTime")] 		public CFloat StartTime { get; set;}

		[Ordinal(2)] [RED("endTime")] 		public CFloat EndTime { get; set;}

		[Ordinal(3)] [RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[Ordinal(4)] [RED("blendOut")] 		public CFloat BlendOut { get; set;}

		public VirtualAnimationMotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new VirtualAnimationMotion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}