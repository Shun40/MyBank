using DxLibDLL;

namespace MyBank.src {
	class CoinView {
		private CoinState state;
		private Coin parent;
		public CoinView(Coin parent) {
			this.state = new CoinOffState(this);
			this.parent = parent;
		}
		// 硬貨の描画
		public void drawCoin(int coinType) {
			this.state.drawImage(coinType);
			this.state.checkMouseOver(coinType);
		}
		// 硬貨の枚数描画
		public void drawCount(int coinType, int count) {
			int countLength = count.ToString().Length;
			ImageData img = (ImageData)Resource.COIN_OFF_IMAGE[coinType];
			int coinWidth = img.Width;
			int coinX = img.X;
			int coinY = img.Y;
			int charWidth = Resource.CHAR_YEN_IMAGE.Width;
			int charXOffset = (coinWidth - charWidth * countLength) / 2;
			int charYOffset = img.Height + 10;
			for(int i = countLength - 1; i >= 0; i--) {
				int charX = coinX + charXOffset + charWidth * i;
				int charY = coinY + charYOffset;
				int index = int.Parse(count.ToString().Substring(i, 1));
				int charHandle = Resource.CHAR_NUM_IMAGE[index].Handle;
				DX.DrawGraph(charX, charY, charHandle, DX.TRUE);
			}
		}
		// アクセッサ
		public CoinState State {
			get { return this.state; }
			set { this.state = value; }
		}
	}
}
