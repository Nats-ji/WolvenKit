using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondCheckStatValueDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("checkedActor")] 		public CEnum<EStatOwner> CheckedActor { get; set;}

		[Ordinal(2)] [RED("baseStatType")] 		public CEnum<EBaseCharacterStats> BaseStatType { get; set;}

		[Ordinal(3)] [RED("autoCheckHPType")] 		public CBool AutoCheckHPType { get; set;}

		[Ordinal(4)] [RED("statValue")] 		public CFloat StatValue { get; set;}

		[Ordinal(5)] [RED("percentage")] 		public CBool Percentage { get; set;}

		[Ordinal(6)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		public BTCondCheckStatValueDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondCheckStatValueDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}