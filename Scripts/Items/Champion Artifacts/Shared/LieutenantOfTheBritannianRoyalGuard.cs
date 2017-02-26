namespace Server.Items
{
    public class LieutenantOfTheBritannianRoyalGuard : BodySash
	{
		public override int LabelNumber{ get{ return 1094910; } } // Lieutenant of the Britannian Royal Guard [Replica]

		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }

		public override bool CanFortify{ get{ return false; } }

		[Constructable]
		public LieutenantOfTheBritannianRoyalGuard()
		{
			Hue = 0xe8;
		}

		public LieutenantOfTheBritannianRoyalGuard( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
