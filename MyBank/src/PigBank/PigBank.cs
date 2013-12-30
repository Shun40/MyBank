namespace MyBank.src {
	class PigBank {
		private PigBankModel model;
		private PigBankView view;
		private PigBankController controller;
		private Scene parent;
		public PigBank(Scene parent) {
			this.model = new PigBankModel(this);
			this.view = new PigBankView(this);
			this.controller = new PigBankController(this);
			this.parent = parent;
		}
		// ブタ貯金箱の描画
		public void drawPigBank(bool canLeftClick) {
			int money = this.model.Money;
			this.view.changeState(money);
			this.drawPigBank();
			this.drawMoney(this.model.Money);
			this.clickImage(canLeftClick);
		}
		// Modelの仕事
		public void addMoney(int money) {
			this.model.addMoney(money);
		}
		public void subMoney(int money) {
			this.model.subMoney(money);
		}
		// Viewの仕事
		private void drawPigBank() {
			this.view.drawPigBank();
		}
		private void drawMoney(int money) {
			this.view.drawMoney(money);
		}
		// Controllerの仕事
		private void clickImage(bool canLeftClick) {
			this.controller.clickImage(canLeftClick);
		}
		// データ書き込み
		public void writeData() {
			this.parent.writeData();
		}
		// アクセッサ
		public PigBankModel Model {
			get { return this.model; }
		}
		public PigBankView View {
			get { return this.view; }
		}
		public PigBankController Controller {
			get { return this.controller; }
		}
	}
}
