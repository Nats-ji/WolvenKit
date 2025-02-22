using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimMorphEvent : CExtAnimDurationEvent
	{
		[Ordinal(1)] [RED("morphComponentId")] 		public CName MorphComponentId { get; set;}

		[Ordinal(2)] [RED("invertWeight")] 		public CBool InvertWeight { get; set;}

		[Ordinal(3)] [RED("useCurve")] 		public CBool UseCurve { get; set;}

		[Ordinal(4)] [RED("curve")] 		public SCurveData Curve { get; set;}

		public CExtAnimMorphEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimMorphEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}