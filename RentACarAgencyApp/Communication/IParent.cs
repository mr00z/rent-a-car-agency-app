using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAgency.Communication
{
    public interface IParent
    {
        void NewClientCreated(CLIENTS newClient);
        void EditedClient(string name, string surname, int phone_nr, string address);
    }
}
