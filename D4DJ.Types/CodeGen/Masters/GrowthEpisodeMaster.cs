using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthEpisodeMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public GrowthBlockCategory MapBlockCatgory { get; set; }
		[Key(2)]
		public int __CharacterPrimaryKey__ { get; set; }
	}
}

