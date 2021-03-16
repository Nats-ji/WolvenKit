using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netEntityAttachmentInterface : CVariable
	{
		[Ordinal(0)] [RED("time")] public netTime Time { get; set; }

		public netEntityAttachmentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}