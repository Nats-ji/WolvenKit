using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimEvent : CVariable
	{
		[Ordinal(1)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(2)] [RED("startTime")] 		public CFloat StartTime { get; set;}

		[Ordinal(3)] [RED("reportToScript")] 		public CBool ReportToScript { get; set;}

		[Ordinal(4)] [RED("reportToScriptMinWeight")] 		public CFloat ReportToScriptMinWeight { get; set;}

		[Ordinal(5)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(6)] [RED("trackName")] 		public CString TrackName { get; set;}

		public CExtAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}