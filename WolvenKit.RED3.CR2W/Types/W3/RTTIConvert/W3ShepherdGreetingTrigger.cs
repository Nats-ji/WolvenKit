using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ShepherdGreetingTrigger : CGameplayEntity
	{
		[Ordinal(1)] [RED("greeted")] 		public CBool Greeted { get; set;}

		[Ordinal(2)] [RED("actors", 2,0)] 		public CArray<CHandle<CActor>> Actors { get; set;}

		public W3ShepherdGreetingTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ShepherdGreetingTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}