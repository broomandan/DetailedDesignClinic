using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Clinic.Essentials.Exercise.Exercise3.Canine
{
    enum BarkStyle
    {
        Growl,
        Bark,
        Yelp
    }

    enum Volume
    {
        Low,
        Normal,
        High
    }


    [DataContract]
    class Dog : Mammal
    {
        [DataMember]
        public string ThingToFetch { get; set; }

        [DataMember]
        public int InterestLevel { get; set; }

        [DataMember]
        public ushort FetchTimeout { get; set; }

        [DataMember]
        public BarkStyle BarkType { get; set; }

        [DataMember]
        public Volume BarkVolume { get; set; }

        [DataMember]
        public ushort BarkLength { get; set; }

        public int AggressionLevel { get; set; }
        public bool RequiresMuzzle { get; set; }
    }

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
    }

    internal class Mammal
    {
    }

    interface IDog
    {
        void Fetch(Dog dog);
        void Bark(Dog dog);
    }
}