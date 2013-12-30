namespace MyBank.src {
	class CoinModel {
		private int coinType;
		private int count;
		private Coin parent;
		public CoinModel(int coinType, Coin parent) {
			this.coinType = coinType;
			this.count = this.readCount();
			this.parent = parent;
		}
		// 1枚貯金
		public void addCount() {
			this.count++;
		}
		// 1枚引き出し
		public void subCount() {
			this.count--;
		}
		// 枚数読み込み
		private int readCount() {
			string filePath = (string)Resource.FILE_PATH[this.coinType];
			DataReader reader = new DataReader();
			return reader.read(filePath);
		}
		// 枚数書き込み
		public void writeCount() {
			string filePath = (string)Resource.FILE_PATH[this.coinType];
			int data = this.count;
			DataWriter writer = new DataWriter();
			writer.write(filePath, data);
		}
		// アクセッサ
		public int CoinType {
			get { return this.coinType; }
		}
		public int Count {
			get { return this.count; }
		}
	}
}
