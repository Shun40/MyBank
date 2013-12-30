using DxLibDLL;
using System.Collections;

namespace MyBank.src {
	class Resource {
		// 画像リソース
		public static ImageData BACKGROUND_CORK_IMAGE = new ImageData(@"..\..\image\background\cork.png", 800, 600, 0, 0);
		public static ImageData PIGBANK_IMAGE = new ImageData(@"..\..\image\bank\bank.png", 320, 260, 50, 220);
		public static ImageData TALKING1_IMAGE = new ImageData(@"..\..\image\bank\talking1.png", 280, 200, 100, 40);
		public static ImageData TALKING2_IMAGE = new ImageData(@"..\..\image\bank\talking2.png", 280, 200, 100, 40);
		public static ImageData TALKING3_IMAGE = new ImageData(@"..\..\image\bank\talking3.png", 280, 200, 100, 40);
		public static ImageData TALKING4_IMAGE = new ImageData(@"..\..\image\bank\talking4.png", 280, 200, 100, 40);
		public static ImageData TALKING5_IMAGE = new ImageData(@"..\..\image\bank\talking5.png", 280, 200, 100, 40);
		public static Hashtable COIN_OFF_IMAGE = new Hashtable();
		public static Hashtable COIN_ON_IMAGE = new Hashtable();
		public static ImageData CHAR_YEN_IMAGE = new ImageData(@"..\..\image\char\yen.png", 38, 44, -1, -1);
		public static ImageData CHAR_COMMA_IMAGE = new ImageData(@"..\..\image\char\comma.png", 38, 44, -1, -1);
		public static ImageData[] CHAR_NUM_IMAGE = new ImageData[10];
		// 音声リソース
		public static SoundData PIGVOICE_SE = new SoundData(@"..\..\sound\pigVoice.mp3", DX.DX_PLAYTYPE_BACK, 100);
		public static SoundData COINDROP_MINI_SE = new SoundData(@"..\..\sound\coinDropMini.mp3", DX.DX_PLAYTYPE_BACK, 100);
		public static SoundData COINDROP_MIDDLE_SE = new SoundData(@"..\..\sound\coinDropMiddle.mp3", DX.DX_PLAYTYPE_BACK, 100);
		public static SoundData COINDROP_BIG_SE = new SoundData(@"..\..\sound\coinDropBig.mp3", DX.DX_PLAYTYPE_BACK, 100);
		// ファイルリソース
		public static Hashtable FILE_PATH = new Hashtable();

		public Resource() {
			COIN_OFF_IMAGE[1] = new ImageData(@"..\..\image\money\1yenOff.png", 100, 100, 450, 40);
			COIN_ON_IMAGE[1] = new ImageData(@"..\..\image\money\1yenOn.png", 100, 100, 450, 40);
			COIN_OFF_IMAGE[5] = new ImageData(@"..\..\image\money\5yenOff.png", 100, 100, 650, 40);
			COIN_ON_IMAGE[5] = new ImageData(@"..\..\image\money\5yenOn.png", 100, 100, 650, 40);
			COIN_OFF_IMAGE[10] = new ImageData(@"..\..\image\money\10yenOff.png", 100, 100, 450, 220);
			COIN_ON_IMAGE[10] = new ImageData(@"..\..\image\money\10yenOn.png", 100, 100, 450, 220);
			COIN_OFF_IMAGE[50] = new ImageData(@"..\..\image\money\50yenOff.png", 100, 100, 650, 220);
			COIN_ON_IMAGE[50] = new ImageData(@"..\..\image\money\50yenOn.png", 100, 100, 650, 220);
			COIN_OFF_IMAGE[100] = new ImageData(@"..\..\image\money\100yenOff.png", 100, 100, 450, 400);
			COIN_ON_IMAGE[100] = new ImageData(@"..\..\image\money\100yenOn.png", 100, 100, 450, 400);
			COIN_OFF_IMAGE[500] = new ImageData(@"..\..\image\money\500yenOff.png", 100, 100, 650, 400);
			COIN_ON_IMAGE[500] = new ImageData(@"..\..\image\money\500yenOn.png", 100, 100, 650, 400);
			CHAR_NUM_IMAGE[0] = new ImageData(@"..\..\image\char\0.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[1] = new ImageData(@"..\..\image\char\1.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[2] = new ImageData(@"..\..\image\char\2.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[3] = new ImageData(@"..\..\image\char\3.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[4] = new ImageData(@"..\..\image\char\4.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[5] = new ImageData(@"..\..\image\char\5.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[6] = new ImageData(@"..\..\image\char\6.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[7] = new ImageData(@"..\..\image\char\7.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[8] = new ImageData(@"..\..\image\char\8.png", 38, 44, -1, -1);
			CHAR_NUM_IMAGE[9] = new ImageData(@"..\..\image\char\9.png", 38, 44, -1, -1);
			FILE_PATH["balance"] = Constants.BALANCE_FILE_PATH;
			FILE_PATH[1] = Constants.COIN1_FILE_PATH;
			FILE_PATH[5] = Constants.COIN5_FILE_PATH;
			FILE_PATH[10] = Constants.COIN10_FILE_PATH;
			FILE_PATH[50] = Constants.COIN50_FILE_PATH;
			FILE_PATH[100] = Constants.COIN100_FILE_PATH;
			FILE_PATH[500] = Constants.COIN500_FILE_PATH;
		}
	}
}
