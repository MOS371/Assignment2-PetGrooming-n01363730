using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetGrooming.Models.ViewModels
{
    public class UpdatePet
    {
        //Info needed for updatng the pet work
        //Info about one pet
        //Info About many species
        public Pet pet { get; set; }
        public List<Species> species { get; set; }
    }
}