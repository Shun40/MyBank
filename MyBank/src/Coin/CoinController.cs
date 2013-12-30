using DxLibDLL;

namespace MyBank.src {
	class CoinController {
		private Coin parent;
		public CoinController(Coin parent) {
			this.parent = parent;
		}
		// 画像クリック入力
		public void clickImage(int coinType, int count, bool canLeftClick, bool canRightClick) {
			if(this.parent.View.State.GetType() == typeof(CoinOnState)) {
				if(canLeftClick) {
					if((DX.GetMouseInput() & DX.MOUSE_INPUT_LEFT) != 0) {
						if(count == Constants.COIN_MAX) {
							return;
						}
						this.parent.addCount();
						this.parent.addMoney(coinType);
						this.playCoinDrop(coinType);
					}
				}
				if(canRightClick) {
					if((DX.GetMouseInput() & DX.MOUSE_INPUT_RIGHT) != 0) {
						if(count == 0) {
							return;
						}
						this.parent.subCount();
						this.parent.subMoney(coinType);
						this.playCoinDrop(coinType);
					}
				}
			}
		}
		// コイン投下音再生
		private void playCoinDrop(int coinType) {
			switch(coinType) {
				case 1:
				case 5:
					DX.PlaySoundMem(Resource.COINDROP_MINI_SE.Handle, Resource.COINDROP_MINI_SE.PlayType);
					break;
				case 10:
				case 50:
					DX.PlaySoundMem(Resource.COINDROP_MIDDLE_SE.Handle, Resource.COINDROP_MIDDLE_SE.PlayType);
					break;
				case 100:
				case 500:
					DX.PlaySoundMem(Resource.COINDROP_BIG_SE.Handle, Resource.COINDROP_BIG_SE.PlayType);
					break;
			}
		}
	}
}
