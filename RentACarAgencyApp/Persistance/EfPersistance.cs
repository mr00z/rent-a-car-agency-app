using RentACarAgency.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAgency.Persistance
{
    public class EfPersistance : IDb, IDisposable
    {
        private readonly RentACarEntities _context;

        public EfPersistance()
        {
            _context = new RentACarEntities();
        }

        //destructor
        ~EfPersistance()
        {
            Dispose();
        }

        public void AddClient(string name, string surname, int phone_nr, string address)
        {
            _context.ADD_CLIENT(name, surname, phone_nr, address);
        }

        public void EditCLient(CLIENTS clientToEdit, string name, string surname, int phone_nr, string address)
        {
            _context.EDIT_CLIENT(clientToEdit.ID_CLIENT, name, surname, phone_nr, address);
        }

        public IEnumerable<CAR> GetCars(string mark)
        {
            return _context.CAR.Where(c => c.MARK.Equals(mark)).ToList<CAR>();
        }

        public IEnumerable<CLIENTS> GetClients()
        {
            return _context.CLIENTS.ToList<CLIENTS>();
        }

        public IEnumerable<ORDERS> GetOrders(DateTime date)
        {
            return _context.ORDERS.Where(o => o.RENT_START_DATE == date).ToList<ORDERS>();
        }

        public void RemoveClient(CLIENTS clientToRemove)
        {
            _context.REMOVE_CLIENT(clientToRemove.ID_CLIENT);
        }

        public void Dispose()
        {
            _context?.Dispose(); //if (_context != null) _context.Dispose();
        }
    }
}
