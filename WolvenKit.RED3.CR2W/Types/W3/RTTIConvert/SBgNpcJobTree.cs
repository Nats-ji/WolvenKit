using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBgNpcJobTree : CVariable
	{
		[Ordinal(1)] [RED("jobTree")] 		public CSoft<CJobTree> JobTree { get; set;}

		[Ordinal(2)] [RED("category")] 		public CName Category { get; set;}

		[Ordinal(3)] [RED("fireTime")] 		public GameTime FireTime { get; set;}

		public SBgNpcJobTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBgNpcJobTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}