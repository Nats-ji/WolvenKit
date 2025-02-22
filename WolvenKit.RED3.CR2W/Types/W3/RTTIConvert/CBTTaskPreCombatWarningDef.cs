using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPreCombatWarningDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("setFlagOnActivate")] 		public CBool SetFlagOnActivate { get; set;}

		[Ordinal(2)] [RED("setFlagOnDectivate")] 		public CBool SetFlagOnDectivate { get; set;}

		[Ordinal(3)] [RED("flag")] 		public CBool Flag { get; set;}

		public CBTTaskPreCombatWarningDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPreCombatWarningDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}