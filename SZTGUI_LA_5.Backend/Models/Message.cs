using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTGUI_LA_5.Backend.Models
{
    public class Message : ObservableObject
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }


        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { SetProperty(ref date, value); }
        }

        private string senderName;

        public string SenderName
        {
            get { return senderName; }
            set { SetProperty(ref senderName, value); }
        }
        

        public Message GetCopy()
        {
            return new Message()
            {
                Text = Text,
                Date = Date,
                SenderName = SenderName,
            };
        }
    }
}
