using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockIt.Entity
{
    public class Entry
    {
        private string uuid;
        public string UUID
        {
            get => uuid; 
            set => uuid = value;
        }
        private string title;
        public string Title
        {
            get => title;
            set => title = value;
        }

        private string username;
        public string Username
        {
            get => username;
            set => username = value;
        }

        private string password;
        public string Password
        {
            get => password;
            set => password = value;
        }

        private string link;
        public string Link
        {
            get => link;
            set => link = value;
        }

        private DateTime createdAt;
        public DateTime CreatedAt
        {
            get => createdAt;
            set => createdAt = value;
        }
    }
}
