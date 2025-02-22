using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class PriceConfirmationPopupData : ConfirmationPopupData
	{
		[Ordinal(1)] [RED("m_Price")] 		public CFloat M_Price { get; set;}

		[Ordinal(2)] [RED("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[Ordinal(3)] [RED("isStandaloneDismantle")] 		public CBool IsStandaloneDismantle { get; set;}

		[Ordinal(4)] [RED("menuRef")] 		public CHandle<CR4BlacksmithMenu> MenuRef { get; set;}

		public PriceConfirmationPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new PriceConfirmationPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}