using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie.src
{
    public class ClientClass
    {
        private int id;
        private string firstName;
        private string lastName;
        
        public void setDataFromValues(int id,string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public string GetId()
        {
            return this.id.ToString();
        }

        public string GetFirstName() {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }
    }
}
