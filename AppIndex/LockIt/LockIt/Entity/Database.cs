using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockIt.Entity
{
    public class Database
    {
        private BindingList<Entry> entries;
        public BindingList<Entry> Entries
        {
            get => entries; 
            set => entries = value;
        }

        public Database() 
        {
            entries = new BindingList<Entry>();
        }
    }
}
