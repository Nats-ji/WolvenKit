using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleContainerLockEvent : redEvent
	{
		[Ordinal(0)] [RED("isLocked")] public CBool IsLocked { get; set; }

		public ToggleContainerLockEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}