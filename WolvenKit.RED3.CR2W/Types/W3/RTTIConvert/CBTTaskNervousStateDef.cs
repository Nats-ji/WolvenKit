using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskNervousStateDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("callFromQuestOnly")] 		public CBool CallFromQuestOnly { get; set;}

		[Ordinal(2)] [RED("dangerRadius")] 		public CFloat DangerRadius { get; set;}

		[Ordinal(3)] [RED("rearingChance")] 		public CFloat RearingChance { get; set;}

		[Ordinal(4)] [RED("kickChance")] 		public CFloat KickChance { get; set;}

		public CBTTaskNervousStateDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskNervousStateDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}