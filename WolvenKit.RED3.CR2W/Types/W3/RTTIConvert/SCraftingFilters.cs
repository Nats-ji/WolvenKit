using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCraftingFilters : CVariable
	{
		[Ordinal(1)] [RED("showCraftable")] 		public CBool ShowCraftable { get; set;}

		[Ordinal(2)] [RED("showMissingIngre")] 		public CBool ShowMissingIngre { get; set;}

		[Ordinal(3)] [RED("showAlreadyCrafted")] 		public CBool ShowAlreadyCrafted { get; set;}

		public SCraftingFilters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCraftingFilters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}