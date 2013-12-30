using DxLibDLL;

namespace MyBank.src {
	class Fps {
		private int fpsCount;
		private int count0Time;
		private int[] frame;
		private double fpsAve;
		private int t;
		public Fps() {
			this.fpsCount = 0;
			this.count0Time = 0;
			this.frame = new int[Constants.FPS];
			this.fpsAve = 0.0;
			this.t = 0;
		}
		public void waitFps() {
			int term;
			if(this.fpsCount == 0) {
				if(t == 0) {
					term = 0;
				} else {
					term = this.count0Time + 1000 - DX.GetNowCount();
				}
			} else {
				term = (int)(this.count0Time + this.fpsCount * (1000.0 / Constants.FPS)) - DX.GetNowCount();
			}
			if(term > 0) {
				DX.WaitTimer(term);
			}
			int gnt = DX.GetNowCount();
			if(this.fpsCount == 0) {
				this.count0Time = gnt;
			}
			this.frame[this.fpsCount] = gnt - this.t;
			this.t = gnt;
			if(this.fpsCount == Constants.FPS - 1) {
				this.fpsAve = 0.0;
				for(int i = 0; i < Constants.FPS; i++) {
					this.fpsAve += this.frame[i];
				}
				this.fpsAve /= Constants.FPS;
			}
			this.fpsCount = (++this.fpsCount) % Constants.FPS;
		}
	}
}
