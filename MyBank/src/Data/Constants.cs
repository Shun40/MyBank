namespace MyBank.src {
	class Constants {
		public const string APP_NAME = "MyBank";
		public const int WINDOW_WIDTH = 800;
		public const int WINDOW_HEIGHT = 600;
		public const int FPS = 60;
		public const string BALANCE_FILE_PATH = @"..\..\archive\balance.dat";
		public const string COIN1_FILE_PATH = @"..\..\archive\coin1.dat";
		public const string COIN5_FILE_PATH = @"..\..\archive\coin5.dat";
		public const string COIN10_FILE_PATH = @"..\..\archive\coin10.dat";
		public const string COIN50_FILE_PATH = @"..\..\archive\coin50.dat";
		public const string COIN100_FILE_PATH = @"..\..\archive\coin100.dat";
		public const string COIN500_FILE_PATH = @"..\..\archive\coin500.dat";
		public const int COIN_MAX = 999;
		public const int VALUE_MAX = 1 * COIN_MAX + 5 * COIN_MAX + 10 * COIN_MAX + 50 * COIN_MAX + 100 * COIN_MAX + 500 * COIN_MAX;
	}
}
