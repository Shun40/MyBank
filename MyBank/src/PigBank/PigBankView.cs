using DxLibDLL;

namespace MyBank.src {
	class PigBankView {
		private PigBankState state;
		private PigBank parent;
		public PigBankView(PigBank parent) {
			this.state = new PigBankHungryState(this);
			this.parent = parent;
		}
		// ブタ貯金箱の描画
		public void drawPigBank() {
			this.state.drawImage();
			this.state.drawTalking();
			this.state.checkMouseOver();
		}
		// 貯金総額の描画
		public void drawMoney(int money) {
			int moneyLength = money.ToString().Length;
			int maxLength = Constants.VALUE_MAX.ToString().Length;
			int bankX = Resource.PIGBANK_IMAGE.X;
			int bankY = Resource.PIGBANK_IMAGE.Y;
			int charWidth = Resource.CHAR_YEN_IMAGE.Width;
			int charXOffset = charWidth * 2;
			int charYOffset = Resource.PIGBANK_IMAGE.Height + 10;
			DX.DrawGraph(bankX, bankY + charYOffset, Resource.CHAR_YEN_IMAGE.Handle, DX.TRUE);
			int charCount = 0;
			int numCount = 0;
			int commaCount = 0;
			while(numCount != moneyLength) {
				int charX = bankX + charXOffset + charWidth * (maxLength - charCount);
				int charY = bankY + charYOffset;
				if(charCount != 0 && (charCount - commaCount) % 3 == 0 && numCount == charCount + commaCount) {
					int charHandle = Resource.CHAR_COMMA_IMAGE.Handle;
					DX.DrawGraph(charX, charY, charHandle, DX.TRUE);
					commaCount++;
				} else {
					int index = int.Parse(money.ToString().Substring(moneyLength - numCount - 1, 1));
					int charHandle = Resource.CHAR_NUM_IMAGE[index].Handle;
					DX.DrawGraph(charX, charY, charHandle, DX.TRUE);
					numCount++;
				}
				charCount++;
			}
		}
		// 貯金額に応じてブタ貯金箱の挙動を変化
		public void changeState(int money) {
			if(this.state.GetType() == typeof(PigBankOnState) || this.state.GetType() == typeof(PigBankSavedState)) {
				return;
			}
			if(money == Constants.VALUE_MAX) {
				if(this.state.GetType() != typeof(PigBankFullState)) {
					this.state = new PigBankFullState(this);
				}
			} else if(money >= Constants.VALUE_MAX / 3) {
				if(this.state.GetType() != typeof(PigBankModerateState)) {
					this.state = new PigBankModerateState(this);
				}
			} else {
				if(this.state.GetType() != typeof(PigBankHungryState)) {
					this.state = new PigBankHungryState(this);
				}
			}
		}
		// アクセッサ
		public PigBankState State {
			get { return this.state; }
			set { this.state = value; }
		}
	}
}
