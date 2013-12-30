using System.IO;

namespace MyBank.src {
	class DataReader {
		public DataReader() {
		}
		// データ読み込み
		public int read(string filePath) {
			StreamReader reader = new StreamReader(filePath);
			int data = int.Parse(reader.ReadLine());
			reader.Dispose();
			return data;
		}
	}
}
