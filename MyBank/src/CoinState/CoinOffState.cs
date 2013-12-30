using DxLibDLL;

namespace MyBank.src {
	class CoinOffState : CoinState {
		private CoinView parent;
		public CoinOffState(CoinView parent) {
			this.parent = parent;
		}
		// 硬貨の画像描画
		public void drawImage(int coinType) {
			ImageData img = (ImageData)Resource.COIN_OFF_IMAGE[coinType];
			int x = img.X;
			int y = img.Y;
			int handle = img.Handle;
			DX.DrawGraph(x, y, handle, DX.TRUE);
		}
		// 硬貨のマウスオーバー監視
		public void checkMouseOver(int coinType) {
			int x, y;
			ImageData img = (ImageData)Resource.COIN_OFF_IMAGE[coinType];
			int left = img.X;
			int right = img.X + img.Width;
			int top = img.Y;
			int bottom = img.Y + img.Height;
			int handle = img.Handle;
			DX.GetMousePoint(out x, out y);
			if(left <= x && x <= right) {
				if(top <= y && y <= bottom) {
					this.parent.State = new CoinOnState(this.parent);
				}
			}
		}
	}
}
