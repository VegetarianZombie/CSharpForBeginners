namespace Beginning.CSharp {

	public interface IPersitable {
		void Save();
	}

	public struct Player : IPersitable {

		private int lives;

		public Player(int lives, string name, int score) : this() {
			this.lives = lives;
			this.Name = name;
			this.Score = score;
		}

		public Player(int score) : this(3, "Unknown", score) {

		}

		public void Save() {
			// Save
		}

		public int Lives {
			get { return lives; }
			set { lives = value + 1; }
		}
		public string Name {
			get;set;
		}
		public int Score {
			get;set;
		}

	}
}

