using DxLibDLL;

namespace MyBank.src {
	class PigBankController {
		private PigBank parent;
		public PigBankController(PigBank parent) {
			this.parent = parent;
		}
		// 画像クリック入力
		public void clickImage(bool canLeftClick) {
			if(this.parent.View.State.GetType() == typeof(PigBankOnState)) {
				if(canLeftClick) {
					if((DX.GetMouseInput() & DX.MOUSE_INPUT_LEFT) != 0) {
						this.parent.writeData();
						this.parent.View.State = new PigBankSavedState(this.parent.View);
						this.playPigVoice();
					}
				}
			}
		}
		// ブタの鳴き声再生
		private void playPigVoice() {
			DX.PlaySoundMem(Resource.PIGVOICE_SE.Handle, Resource.PIGVOICE_SE.PlayType);
		}
	}
}
