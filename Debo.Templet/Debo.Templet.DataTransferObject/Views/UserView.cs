using System;

namespace Debo.Templet.DataTransferObject.Views
{
    public class UserView
    {
        public Guid Id { set; get; }
        public String Account { set; get; }
        public String Password { set; get; }
        public Nullable<DateTime> DateTime { set; get; }
    }
}
