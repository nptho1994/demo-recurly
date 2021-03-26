using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    public class Animal
    {
        public string id { get; set; }
        public string active { get; set; }
        public string created_at { get; set; }
        public string modified_at { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string sex_id { get; set; }
        public string is_dead { get; set; }
        public string is_hostile { get; set; }
        public string animalcolour_id { get; set; }
        public string species_id { get; set; }
        public string breed_id { get; set; }
        public string rabies_number { get; set; }
        public string date_of_rabies_vaccination { get; set; }
        public string microchip_number { get; set; }
        public string contact_id { get; set; }
        public string date_of_birth { get; set; }
        public string is_estimated_date_of_birth { get; set; }
        public string date_of_death { get; set; }
        public string death_reason { get; set; }
        public string date_of_desex { get; set; }
        public string referring_clinic_id { get; set; }
        public string referring_vet_id { get; set; }
        public string residence_contact_id { get; set; }
        public string weight { get; set; }
        public string weight_unit { get; set; }
        public string resuscitate { get; set; }
        public string notes { get; set; }
        public string notes_important { get; set; }
        public string guid { get; set; }
    }
}
