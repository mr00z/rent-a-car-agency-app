using System;
using System.Collections.Generic;

namespace RentACarAgency.DAL
{
    public interface IDb
    {
        IEnumerable<CLIENTS> GetClients();
        IEnumerable<CAR> GetCars(string mark);
        IEnumerable<ORDERS> GetOrders(DateTime date);
        void AddClient(string name, string surname, int phone_nr, string address);
        void EditCLient(CLIENTS clientToEdit, string name, string surname, int phone_nr, string address);
        void RemoveClient(CLIENTS clientToRemove);
    }
}
