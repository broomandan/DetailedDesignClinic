using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Clinic.Essentials.Exercise.Exercise3.Canine;

namespace Clinic.Essentials.Exercise.Exercise3
{
    class Pet
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string OwnerName { get; set; }

        [DataMember]
        public ulong LicenseId { get; set; }

        [DataMember]
        public ushort Age { get; set; }

        private IEnumerable<VetrenarianVisit> HealthRecord { get; set; }
    }

    [DataContract]
    internal class VetrenarianVisit
    {
        [DataMember]
        public Veterinarian Veterinarian { get; set; }

        [DataMember]
        public IEnumerable<Appointment> Appointments { get; set; }

        [DataMember]
        public IEnumerable<Vaccination> Vaccinations { get; set; }
    }

    [DataContract]
    class Veterinarian
    {
        [DataMember]
        public int ClinicNumber { get; set; }
    }



    [DataContract]
    class Appointment
    {
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string ReasonforVisit { get; set; }
    }

    [DataContract]
    class Vaccination
    {
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string Description { get; set; }
    }

    internal enum HealthIssue
    {
        KennelCough
    }

    interface IDog
    {
        void Fetch(Dog dog);
        void Bark(Dog dog);

    }

    interface IPet
    {
        void ScheduleAppointment(Pet pet);
        void Vaccinate(Pet pet);
    }
}