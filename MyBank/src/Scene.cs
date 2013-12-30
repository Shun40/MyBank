using DxLibDLL;

namespace MyBank.src {
	class Scene {
		private PigBank pigBank;
		private Coin coin1;
		private Coin coin5;
		private Coin coin10;
		private Coin coin50;
		private Coin coin100;
		private Coin coin500;
		private bool canLeftClick;
		private bool canRightClick;
		public Scene() {
			this.pigBank = new PigBank(this);
			this.coin1 = new Coin(1, pigBank, this);
			this.coin5 = new Coin(5, pigBank, this);
			this.coin10 = new Coin(10, pigBank, this);
			this.coin50 = new Coin(50, pigBank, this);
			this.coin100 = new Coin(100, pigBank, this);
			this.coin500 = new Coin(500, pigBank, this);
			this.canLeftClick = false;
			this.canRightClick = false;
		}
		// シーン描画
		public void drawScene() {
			this.drawBackGround();
			this.pigBank.drawPigBank(this.canLeftClick);
			this.coin1.drawCoin(this.canLeftClick, this.canRightClick);
			this.coin5.drawCoin(this.canLeftClick, this.canRightClick);
			this.coin10.drawCoin(this.canLeftClick, this.canRightClick);
			this.coin50.drawCoin(this.canLeftClick, this.canRightClick);
			this.coin100.drawCoin(this.canLeftClick, this.canRightClick);
			this.coin500.drawCoin(this.canLeftClick, this.canRightClick);
			this.leftClick();
			this.rightClick();
		}
		// 背景画像描画
		private void drawBackGround() {
			DX.DrawGraph(Resource.BACKGROUND_CORK_IMAGE.X, Resource.BACKGROUND_CORK_IMAGE.Y, Resource.BACKGROUND_CORK_IMAGE.Handle, DX.TRUE);
		}
		// 左クリック受付
		private void leftClick() {
			if((DX.GetMouseInput() & DX.MOUSE_INPUT_LEFT) != 0) {
				this.canLeftClick = false;
			} else {
				this.canLeftClick = true;
			}
		}
		// 右クリック受付
		private void rightClick() {
			if((DX.GetMouseInput() & DX.MOUSE_INPUT_RIGHT) != 0) {
				this.canRightClick = false;
			} else {
				this.canRightClick = true;
			}
		}
		// データ書き込み
		public void writeData() {
			this.pigBank.Model.writeBalance();
			this.coin1.Model.writeCount();
			this.coin5.Model.writeCount();
			this.coin10.Model.writeCount();
			this.coin50.Model.writeCount();
			this.coin100.Model.writeCount();
			this.coin500.Model.writeCount();
		}
	}
}
