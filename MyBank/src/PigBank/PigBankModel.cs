namespace MyBank.src {
	class PigBankModel {
		private int money;
		private PigBank parent;
		public PigBankModel(PigBank parent) {
			this.money = this.readBalance();
			this.parent = parent;
		}
		// 貯金
		public void addMoney(int money) {
			this.money += money;
		}
		// 引き出し
		public void subMoney(int money) {
			this.money -= money;
		}
		// 残高読み込み
		private int readBalance() {
			string filePath = (string)Resource.FILE_PATH["balance"];
			DataReader reader = new DataReader();
			return reader.read(filePath);
		}
		// 残高書き込み
		public void writeBalance() {
			string filePath = (string)Resource.FILE_PATH["balance"];
			int data = this.money;
			DataWriter writer = new DataWriter();
			writer.write(filePath, data);
		}
		// アクセッサ
		public int Money {
			get { return this.money; }
		}
	}
}
