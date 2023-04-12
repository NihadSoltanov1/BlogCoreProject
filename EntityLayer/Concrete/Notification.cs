using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification 
    {


        [Key]
        public int ID { get; set; }

        public string NotificationTitle { get; set; }

        public string NotificationContent { get; set; }
        public string NotificationCategory { get; set; }

        public string NotificationColor { get; set; }
        public string NotificationIcon { get; set; }
        public DateTime NotificationCreateDatetime { get; set; }

        public bool NotificationStatus { get; set; }



    }
}
