using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAddBuffsDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(2)] [RED("buffs", 2,0)] 		public CArray<CEnum<EEffectType>> Buffs { get; set;}

		[Ordinal(3)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(4)] [RED("customValue")] 		public SAbilityAttributeValue CustomValue { get; set;}

		public BTTaskAddBuffsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskAddBuffsDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}