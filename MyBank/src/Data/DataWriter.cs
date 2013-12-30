using System.IO;

namespace MyBank.src {
	class DataWriter {
		public DataWriter() {
		}
		// データ書き込み
		public void write(string filePath, int data) {
			StreamWriter writer = new StreamWriter(filePath);
			writer.WriteLine(data.ToString());
			writer.Dispose();
		}
	}
}
