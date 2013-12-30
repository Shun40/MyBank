using DxLibDLL;

namespace MyBank.src {
	class PigBankModerateState : PigBankState {
		private int tick;
		private bool isSkip;
		private PigBankView parent;
		public PigBankModerateState(PigBankView parent) {
			this.tick = 0;
			this.isSkip = false;
			this.parent = parent;
		}
		// ブタ貯金箱の画像描画
		public void drawImage() {
			switch(this.tick) {
				case 0:
					this.isSkip = false;
					break;
				case 15:
					this.isSkip = true;
					break;
				case 30:
					this.tick = -1;
					break;
			}
			if(this.isSkip) {
				DX.DrawGraph(Resource.PIGBANK_IMAGE.X + 2, Resource.PIGBANK_IMAGE.Y, Resource.PIGBANK_IMAGE.Handle, DX.TRUE);
			} else {
				DX.DrawGraph(Resource.PIGBANK_IMAGE.X, Resource.PIGBANK_IMAGE.Y, Resource.PIGBANK_IMAGE.Handle, DX.TRUE);
			}
			this.tick++;
		}
		// ブタ貯金箱のセリフ描画
		public void drawTalking() {
			DX.DrawGraph(Resource.TALKING2_IMAGE.X, Resource.TALKING2_IMAGE.Y, Resource.TALKING2_IMAGE.Handle, DX.TRUE);
		}
		// ブタ貯金箱のマウスオーバー監視
		public void checkMouseOver() {
			int x, y;
			int left = Resource.PIGBANK_IMAGE.X;
			int right = Resource.PIGBANK_IMAGE.X + Resource.PIGBANK_IMAGE.Width;
			int top = Resource.PIGBANK_IMAGE.Y;
			int bottom = Resource.PIGBANK_IMAGE.Y + Resource.PIGBANK_IMAGE.Height;
			DX.GetMousePoint(out x, out y);
			if(left <= x && x <= right) {
				if(top <= y && y <= bottom) {
					this.parent.State = new PigBankOnState(this.parent);
				}
			}
		}
	}
}
