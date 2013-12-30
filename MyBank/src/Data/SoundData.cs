using DxLibDLL;

namespace MyBank.src {
	class SoundData {
		private int handle;
		private int playType;
		private int volume;
		public SoundData(string path, int playType, int volume) {
			this.handle = DX.LoadSoundMem(path);
			this.playType = playType;
			this.volume = volume;
			DX.ChangeVolumeSoundMem(255 * this.volume / 100, this.handle);
		}
		// アクセッサ
		public int Handle {
			get { return this.handle; }
		}
		public int PlayType {
			get { return this.playType; }
		}
		public int Volume {
			get { return this.volume; }
		}
	}
}
