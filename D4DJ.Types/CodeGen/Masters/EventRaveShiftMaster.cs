using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveShiftMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public DateTime StartDate { get; set; }
		[Key(4)]
		public DateTime EndDate { get; set; }
		[Key(5)]
		public int ClubId { get; set; }
		[Key(6)]
		public int RankingRewardGroupId { get; set; }
	}
}

