using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAnimalSetIsScared : IBehTreeTask
	{
		[Ordinal(1)] [RED("value")] 		public CBool Value { get; set;}

		[Ordinal(2)] [RED("setOnDeactivate")] 		public CBool SetOnDeactivate { get; set;}

		[Ordinal(3)] [RED("animalData")] 		public CHandle<CAIStorageAnimalData> AnimalData { get; set;}

		public CBTTaskAnimalSetIsScared(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskAnimalSetIsScared(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}