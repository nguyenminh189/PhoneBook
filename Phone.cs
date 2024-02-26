using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public abstract class Phone
    {
        public abstract void insertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newPhone);
        public abstract void searchPhone(string name);
        public abstract void Sort();
        public abstract void Enter();
    }
}
