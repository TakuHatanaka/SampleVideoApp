using System.Windows.Input;
using Octane.Xam.VideoPlayer;
using Prism.Mvvm;
using Xamarin.Forms;

namespace SampleVideoApp.ViewModels
{
    /// <summary>
    /// 動画再生サンプルページのViewModelクラス
    /// </summary>
    public class MainPageViewModel : BindableBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainPageViewModel()
        {

        }

        /// <summary>
        /// 再生ボタンクリックイベントコマンド
        /// </summary>
        private ICommand _BtnPlayClickedCommand = null;
        /// <summary>
        /// 再生ボタンクリックイベントコマンド
        /// </summary>
        public ICommand BtnPlayClickedCommand => _BtnPlayClickedCommand ?? (
            _BtnPlayClickedCommand = new Command(
                () => ExecuteBtnPlayClicked()));

        /// <summary>
        /// 再生ボタンクリック処理
        /// </summary>
        private void ExecuteBtnPlayClicked()
        {
        }
    }
}
