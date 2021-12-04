# CalendarControl
Calendar Control - is cross platform plugin for Xamairn Forms which allows you to display customized calendar in your app.

![calendar](https://user-images.githubusercontent.com/47309472/144710164-e47f98fa-650d-49c4-82f3-aff5e55fcb3a.png)


<h2> How To Use </h2> 

Available on Nuget : https://www.nuget.org/packages/CustomCalendarControl/1.0.4  
Install this Plugin in your Xamarin Form Project.
 
Write following code on button click event.
```
var calendarPage = new CalendarPage(DateTime.Now, null);
calendarPage.SelectedDateCommand = new Command<DateTime>((item) =>
{
    //Perform operation on selected Date
});
await PopupNavigation.Instance.PushAsync(calendarPage);
```
This control is using Rg Popup plugin to display calendar so you need
to Initialize the Rg Popup Plugin in platform specific.

Android MainActivity.cs
```
   Rg.Plugins.Popup.Popup.Init(this);
```
iOS AppDelegate.cs
```
   Rg.Plugins.Popup.Popup.Init();
```

<h2> Calendar UI Customization </h2> 

![Customize Calendar](https://user-images.githubusercontent.com/47309472/144711151-1027449f-60d6-445f-990e-1cefcdabfa0f.png)


Following Propery you can use for customizing calendar UI

```
var calendarPage = new CalendarPage(DateTime.Now, 
                new CustomCalendarControl.Models.CalendarTheme
{
        //Header UI Property
        HeaderBackgroundColor = Color.LightBlue,
        HeaderTextColor = Color.Yellow,
 
        //Left & Right Arrow Color and Month Color Property
        LeftRightArrowColor = Color.Red,
        MonthColor = Color.Gray,
 
         //Selected Date Background & Selected Text Color
         SelectedDateBackGroundColor = Color.LightGreen,
         SelectedDateTextColor = Color.Red,
 
         //Okay Cancel Button Text Color
         OkayButtonTextColor = Color.Blue,
         CancelButtonTextColor= Color.Black
}) ;
calendarPage.SelectedDateCommand = new Command<DateTime>((item) =>
{
         //Perform operation on selected Date
});
await PopupNavigation.Instance.PushAsync(calendarPage);
```


