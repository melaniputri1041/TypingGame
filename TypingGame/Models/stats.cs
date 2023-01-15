namespace TypingGame.Models
{
	public class stats
	{
		public int Correct { get; set; }
		public int Missed { get; set; }
		public int Total { get; set; }
		//private set berungsi agar total tidak membuat tipe data yang ber isi 0
		public int Accuracy { get; set; }

		public void CountTotal()
		{
			Total = Correct + Missed;
			// berfungsi unutk menjumlahkan tota dari correct dan missed
		}

		public void CountAccuracy() // berfungsi untuk membuat akurasi berapa persen dari correct atau missed
		{
			Accuracy = Correct * 100 / (Correct + Missed);
		}
	}
}
