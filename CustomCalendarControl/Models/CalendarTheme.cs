using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomCalendarControl.Models
{
    public class CalendarTheme
    {
        public Color HeaderBackgroundColor { get; set; } = Color.Orange;
        public Color HeaderTextColor { get; set; } = Color.White;

        public Color LeftRightArrowColor { get; set; } = Color.Black;
        public Color MonthColor { get; set; } = Color.Black;
        public Color SelectedDateBackGroundColor { get; set; } = Color.Orange;
        public Color SelectedDateTextColor { get; set; } = Color.White;

        public Color OkayButtonTextColor { get; set; } = Color.Orange;
        public Color CancelButtonTextColor { get; set; } = Color.Orange;
    }
}
