using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHelpTextComponent : CComponent
	{
		[Ordinal(1)] [RED("text")] 		public CString Text { get; set;}

		[Ordinal(2)] [RED("textColor")] 		public CColor TextColor { get; set;}

		[Ordinal(3)] [RED("backgroundColor")] 		public CColor BackgroundColor { get; set;}

		[Ordinal(4)] [RED("drawBackground")] 		public CBool DrawBackground { get; set;}

		public CHelpTextComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHelpTextComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}