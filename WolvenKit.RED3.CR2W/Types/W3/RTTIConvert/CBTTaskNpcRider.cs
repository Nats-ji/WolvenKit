using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskNpcRider : IBehTreeTask
	{
		[Ordinal(1)] [RED("activate")] 		public CBool Activate { get; set;}

		[Ordinal(2)] [RED("horseComponent")] 		public CHandle<W3HorseComponent> HorseComponent { get; set;}

		[Ordinal(3)] [RED("riderEntity")] 		public CHandle<CActor> RiderEntity { get; set;}

		public CBTTaskNpcRider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskNpcRider(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}