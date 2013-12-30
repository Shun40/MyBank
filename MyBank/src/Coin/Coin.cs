namespace MyBank.src {
	class Coin {
		private CoinModel model;
		private CoinView view;
		private CoinController controller;
		private PigBank pigBank;
		private Scene parent;
		public Coin(int coinType, PigBank pigBank, Scene parent) {
			this.model = new CoinModel(coinType, this);
			this.view = new CoinView(this);
			this.controller = new CoinController(this);
			this.pigBank = pigBank;
			this.parent = parent;
		}
		// 硬貨の描画
		public void drawCoin(bool canLeftClick, bool canRightClick) {
			int coinType = this.model.CoinType;
			int count = this.model.Count;
			this.drawCoin(coinType);
			this.drawCount(coinType, count);
			this.clickImage(coinType, count, canLeftClick, canRightClick);
		}
		// Modelの仕事
		public void addCount() {
			this.model.addCount();
		}
		public void subCount() {
			this.model.subCount();
		}
		// Viewの仕事
		private void drawCoin(int coinType) {
			this.view.drawCoin(coinType);
		}
		private void drawCount(int coin, int count) {
			this.view.drawCount(coin, count);
		}
		// Controllerの仕事
		private void clickImage(int coinType, int count, bool canLeftClick, bool canRightClick) {
			this.controller.clickImage(coinType, count, canLeftClick, canRightClick);
		}
		// ブタ貯金箱の仕事
		public void addMoney(int money) {
			this.pigBank.addMoney(money);
		}
		public void subMoney(int money) {
			this.pigBank.subMoney(money);
		}
		// アクセッサ
		public CoinModel Model {
			get { return this.model; }
		}
		public CoinView View {
			get { return this.view; }
		}
		public CoinController Controller {
			get { return this.controller; }
		}
	}
}
