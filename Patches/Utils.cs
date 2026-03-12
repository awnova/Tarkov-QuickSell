using EFT.Communications;

namespace QuickSell.Patches
{
    public class Utils
    {
        public static void SendNotification(string text)
        {
            NotificationManagerClass.DisplayMessageNotification(text, ENotificationDurationType.Long);
        }

        public static void SendError(string text)
        {
            NotificationManagerClass.DisplayWarningNotification(text, ENotificationDurationType.Long);
        }
    }
}
