using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFactsDBChoiceMemo : ISceneChoiceMemo
	{
		[Ordinal(1)] [RED("factID")] 		public CString FactID { get; set;}

		[Ordinal(2)] [RED("value")] 		public CInt32 Value { get; set;}

		public CFactsDBChoiceMemo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFactsDBChoiceMemo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}