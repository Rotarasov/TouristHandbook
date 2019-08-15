using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public static class Synchronizer
    {
        public static void SynchronizeAdding(this IAgencyCollection agencyList, Tour tour)
        {
            if (tour.AgenciesId == null)
                return;
            foreach(TravelAgency agency in agencyList.TravelAgencies)
            {
                TravelAgency newAgency = agency;
                if (tour.AgenciesId.Contains(agency.Id))
                {
                    newAgency.ToursId.Add(tour.Id);
                    agencyList.Update(newAgency);
                }
            }
        }

        public static void SynchronizeAdding(this IExcursionCollection excursionList, Tour tour)
        {
            if (tour.AgenciesId == null)
                return;
            foreach (Excursion excursion in excursionList.Excursions)
            {
                Excursion newExcursion = excursion;
                if (tour.ExcursionsId.Contains(excursion.Id))
                {
                    newExcursion.ToursId.Add(tour.Id);
                    excursionList.Update(newExcursion);
                }
            }
        }

        public static void SynchronizeAdding(this ITourCollection tourList, Excursion excursion)
        {
            if (excursion.ToursId == null)
                return;
            foreach (Tour tour in tourList.Tours)
            {
                Tour newTour = tour;
                if (excursion.ToursId.Contains(tour.Id))
                {
                    newTour.ExcursionsId.Add(excursion.Id);
                    tourList.Update(newTour);
                }
            }
        }

        public static void SynchronizeAdding(this ITourCollection tourList, TravelAgency agency)
        {
            if (agency.ToursId == null)
                return;
            foreach (Tour tour in tourList.Tours)
            {
                Tour newTour = tour;
                if (agency.ToursId.Contains(tour.Id))
                {
                    newTour.AgenciesId.Add(agency.Id);
                    tourList.Update(newTour);
                }
            }
        }

        public static void SynchronizeUpdating(this IExcursionCollection excursionList, Tour tour)
        {
            if (tour.AgenciesId == null)
                return;
            foreach (Excursion excursion in excursionList.Excursions)
            {
                Excursion newExcursion = excursion;
                if (tour.ExcursionsId.Contains(excursion.Id) && !excursion.ToursId.Contains(tour.Id))
                    newExcursion.ToursId.Add(tour.Id);
                else if (!tour.ExcursionsId.Contains(excursion.Id) && excursion.ToursId.Contains(tour.Id))
                    newExcursion.ToursId.Remove(tour.Id);
                excursionList.Update(newExcursion);
            }
        }

        public static void SynchronizeUpdating(this IAgencyCollection agencyList, Tour tour)
        {
            if (tour.AgenciesId == null)
                return;
            foreach (TravelAgency agency in agencyList.TravelAgencies)
            {
                TravelAgency newAgency = agency;
                if (tour.AgenciesId.Contains(agency.Id) && !agency.ToursId.Contains(tour.Id))
                    newAgency.ToursId.Add(tour.Id);
                else if (!tour.AgenciesId.Contains(agency.Id) && agency.ToursId.Contains(tour.Id))
                    newAgency.ToursId.Remove(tour.Id);
                agencyList.Update(newAgency);
            }
        }

        public static void SynchronizeUpdating(this ITourCollection tourList, Excursion excursion)
        {
            if (excursion.ToursId == null)
                return;
            foreach (Tour tour in tourList.Tours)
            {
                Tour newTour = tour;
                if (excursion.ToursId.Contains(tour.Id) && !tour.ExcursionsId.Contains(excursion.Id))
                {
                    newTour.ExcursionsId.Add(excursion.Id);
                    tourList.Update(newTour);
                }
                else if (!excursion.ToursId.Contains(tour.Id) && tour.ExcursionsId.Contains(excursion.Id))
                {
                    newTour.ExcursionsId.Remove(excursion.Id);
                    tourList.Update(newTour);
                }
            }
        }

        public static void SynchronizeUpdating(this ITourCollection tourList, TravelAgency agency)
        {
            if (agency.ToursId == null)
                return;
            foreach (Tour tour in tourList.Tours)
            {
                Tour newTour = tour;
                if (agency.ToursId.Contains(tour.Id) && !tour.AgenciesId.Contains(agency.Id))
                {
                    newTour.AgenciesId.Add(agency.Id);
                    tourList.Update(newTour);
                }
                else if (!agency.ToursId.Contains(tour.Id) && tour.AgenciesId.Contains(agency.Id))
                {
                    newTour.AgenciesId.Remove(agency.Id);
                    tourList.Update(newTour);
                }
            }
        }

        public static void SynchronizeDeleting(this IAgencyCollection agencyList, Tour tour)
        {
            if (tour.AgenciesId == null)
                return;
            foreach (TravelAgency agency in agencyList.TravelAgencies)
            {
                TravelAgency newAgency = agency;
                if (newAgency.ToursId.Contains(tour.Id))
                {
                    newAgency.ToursId.Remove(tour.Id);
                    agencyList.Update(newAgency);
                }
            }
        }

        public static void SynchronizeDeleting(this IExcursionCollection excursionList, Tour tour)
        {
            if (tour.ExcursionsId == null)
                return;
            foreach (Excursion excursion in excursionList.Excursions)
            {
                Excursion newExcursion = excursion;
                if (excursion.ToursId.Contains(tour.Id))
                {
                    newExcursion.ToursId.Remove(tour.Id);
                    excursionList.Update(newExcursion);
                }
            }
        }

        public static void SynchronizeDeleting(this ITourCollection tourList, Excursion excursion)
        {
            if (excursion.ToursId == null)
                return;
            foreach (Tour tour in tourList.Tours)
            {
                Tour newTour = tour;
                if (excursion.ToursId.Contains(tour.Id))
                {
                    newTour.ExcursionsId.Remove(excursion.Id);
                    tourList.Update(newTour);
                }
            }
        }

        public static void SynchronizeDeleting(this ITourCollection tourList, TravelAgency agency)
        {
            if (agency.ToursId == null)
                return;
            foreach (Tour tour in tourList.Tours)
            {
                Tour newTour = tour;
                if (agency.ToursId.Contains(tour.Id))
                {
                    newTour.AgenciesId.Remove(agency.Id);
                    tourList.Update(newTour);
                }
            }
        }
    }
}
