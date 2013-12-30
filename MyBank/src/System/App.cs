using DxLibDLL;
using System;

namespace MyBank.src {
	class App {
		public static int refreshTime;
		[STAThread]
		public static void Main() {
			// 画面設定
			DX.ChangeWindowMode(DX.TRUE);
			DX.SetGraphMode(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT, 32);
			DX.SetMainWindowText(Constants.APP_NAME);
			DX.SetBackgroundColor(255, 255, 255);
			// DXライブラリ使用開始
			DX.DxLib_Init();
			// 裏描画設定
			DX.SetDrawScreen(DX.DX_SCREEN_BACK);
			// Paramクラスの初期化
			new Resource();
			// Fpsクラスのインスタンス生成
			Fps fps = new Fps();
			// Sceneクラスのインスタンス生成
			Scene scene = new Scene();
			// 画面描画開始
			while(DX.ScreenFlip() == 0 && DX.ProcessMessage() == 0 && DX.ClearDrawScreen() == 0) {
				// fps計測
				App.refreshTime = DX.GetNowCount();
				// シーン描写
				scene.drawScene();
				// fpsを60に統一するための記述
				fps.waitFps();
			}
			// DXライブラリ使用終了
			DX.DxLib_End();
		}
	}
}
