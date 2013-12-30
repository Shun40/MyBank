using DxLibDLL;

namespace MyBank.src {
	class ImageData {
		private int handle;
		private int width;
		private int height;
		private int x;
		private int y;
		public ImageData(string path, int width, int height, int x, int y) {
			this.handle = DX.LoadGraph(path);
			this.width = width;
			this.height = height;
			this.x = x;
			this.y = y;
		}
		// アクセッサ
		public int Handle {
			get { return this.handle; }
		}
		public int Width {
			get { return this.width; }
		}
		public int Height {
			get { return this.height; }
		}
		public int X {
			get { return this.x; }
		}
		public int Y {
			get { return this.y; }
		}
	}
}
