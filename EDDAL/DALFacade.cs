using EDDAL.Model;
using EDDAL.Repository;
using EDDAL.Repository.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDAL
{
    public class DALFacade
    {
        private ISortingRepository _sortingRepository;
        private ITrackingRepository _trackingRepository;
        private IParcelRepository _parcelRepository;

        public DALFacade()
        {
            _sortingRepository = new SortingRepository();
            _trackingRepository = new TrackingRepository();
            _parcelRepository = new ParcelRepository();
        }
        #region  Sorting function
        public IEnumerable<Sorting> getAllSortings(IEnumerable<Sorting> s)
        {
            return s;
        }
        public IEnumerable<Sorting> getAllSortings()
        {
            return _sortingRepository.GetAll();
        }

        public Sorting addSorting(Sorting sorting)
        {
            return _sortingRepository.Add(sorting);
        }
        public Sorting getSingleSorting(int id)
        {
            return _sortingRepository.Get(id);
        }
        public void updateSorting(Sorting sorting)
        {
             _sortingRepository.Update(sorting);
        }
        public void removeSorting(int id)
        {
            _sortingRepository.Remove(id);
        }
        public IEnumerable<Sorting> GetParcelByIdFromSorting(int parcleId)
        {
           return _sortingRepository.getParcelByIdFromSorting(parcleId);
        }
        #endregion

        #region Tracking function
        public IEnumerable<Tracking> getAllTrackings()
        {
            return _trackingRepository.GetAll();
        }

        public Tracking addTracking(Tracking tracking)
        {
            return _trackingRepository.Add(tracking);
        }
        public Tracking getSingleTracking(int id)
        {
            return _trackingRepository.Get(id);
        }
        public void updateTracking(Tracking  tracking)
        {
            _trackingRepository.Update(tracking);
        }
        public void removeTracking(int id)
        {
            _trackingRepository.Remove(id);
        }
        #endregion

        #region Parcel funtion
        public Parcel getSingleParcel(int id)
        {
            return _parcelRepository.Get(id);
        }

        public IEnumerable<Parcel> getAllParcels()
        {
            return _parcelRepository.GetAll();
        }
        #endregion

        #region Delivery function
     
        #endregion
    }
}
