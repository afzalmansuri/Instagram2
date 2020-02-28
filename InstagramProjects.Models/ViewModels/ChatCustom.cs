using InstagramProjects.Models.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramProjects.Models.ViewModels
{
    public class ChatCustom
    {
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public string messageContent { get; set; }
    }
}
