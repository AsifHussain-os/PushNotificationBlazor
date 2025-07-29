using Plugin.Firebase.CloudMessaging;

namespace PushNotificationBlazor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          //  FirebaseInitlized();
        }
        //private async void FirebaseInitlized()
        //{
        //    await Permissions.RequestAsync<Permissions.PostNotifications>();
        //    PermissionStatus notificationPermission = await Permissions.CheckStatusAsync<Permissions.PostNotifications>();

        //    await Task.Delay(500);

        //    await CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();
        //    var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();
        //    Console.WriteLine($"FCM token: {token}");
        //}
    }
}
