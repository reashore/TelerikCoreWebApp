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
                // bug here
                Action = $"Index{index}",
                Controller = "Work1",
                OnClose = "onClosePopupWindow",
                Top = 0 + index * 25,
                Left = 400 + index * 25,
                Width = 800,
                Height = 800,
                MaxWidth = 800,
                MaxHeight = 800
            };

            return popupWindow;
        }
    }
}
