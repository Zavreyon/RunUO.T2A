namespace Server.Items
{
    public class NoxRangersHeavyCrossbow : HeavyCrossbow
	{
		public override int LabelNumber{ get{ return 1063485; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public NoxRangersHeavyCrossbow()
		{
			Hue = 0x58C;
		}

		public NoxRangersHeavyCrossbow( Serial serial ) : base( serial )
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