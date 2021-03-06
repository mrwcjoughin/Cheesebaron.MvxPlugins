using System.Threading.Tasks;
using Cheesebaron.MvxPlugins.FormsPresenters.Core;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;
using UIKit;
using Xamarin.Forms;

namespace Cheesebaron.MvxPlugins.FormsPresenters.Touch
{
    public class MvxFormsTouchPagePresenter
        : MvxFormsPagePresenter
        , IMvxTouchViewPresenter
    {
        private readonly UIWindow _window;

        public MvxFormsTouchPagePresenter(UIWindow window, Application mvxFormsApp)
            : base(mvxFormsApp)
        {
            _window = window;
        }

        public virtual bool PresentModalViewController(UIViewController controller, bool animated)
        {
            return false;
        }

        public virtual void NativeModalViewControllerDisappearedOnItsOwn()
        {
        }

        protected override void CustomPlatformInitialization(NavigationPage mainPage)
        {
            _window.RootViewController = mainPage.CreateViewController();
        }
    }
}