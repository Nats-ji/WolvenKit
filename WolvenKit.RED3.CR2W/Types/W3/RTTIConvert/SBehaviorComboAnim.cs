using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorComboAnim : CVariable
	{
		[Ordinal(1)] [RED("animationAttack")] 		public CName AnimationAttack { get; set;}

		[Ordinal(2)] [RED("animationParry")] 		public CName AnimationParry { get; set;}

		[Ordinal(3)] [RED("id")] 		public CInt32 Id { get; set;}

		public SBehaviorComboAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorComboAnim(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}