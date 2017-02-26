namespace Server.Items
{
    public class CaptainJohnsHat : TricorneHat
	{
		public override int LabelNumber{ get{ return 1094911; } } // Captain John's Hat [Replica]

		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }

		public override bool CanFortify{ get{ return false; } }

		[Constructable]
		public CaptainJohnsHat()
		{
			Hue = 0x455;
		}

		public CaptainJohnsHat( Serial serial ) : base( serial )
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
