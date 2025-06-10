using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockIt
{
    internal class Entry
    {
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private List<Entry> passwordList = new();

        public void AddPassword(string website, string username, string password)
        {
            passwordList.Add(new Entry
            {
                Title = website,
                Username = username,
                Password = password,
            });
        }

    }
}
