using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Helpers
{
    public static class PopupHelper
    {
        public static PopupWindow GetPopupWindowSettings(int index)
        {
            PopupWindow popupWindow = new PopupWindow
            {
                Name = $"popupWindow{index}",
                Title = $"Popup Window{index}",
                Action = $"Index{index}",
                Controller = "Home",
                OnClose = "onClosePopupWindow",
                Top = 200 + index * 25,
                Left = 600 + index * 25,
                Width = 600,
                Height = 300,
                MaxWidth = 700,
                MaxHeight = 700
            };

            return popupWindow;
        }
    }
}
