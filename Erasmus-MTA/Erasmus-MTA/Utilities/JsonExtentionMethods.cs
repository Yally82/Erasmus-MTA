﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Erasmus_MTA.Models;


//Robert: Detalii Mobilitate Trebuie completat. Nu stiu ce inseamna
namespace Erasmus_MTA.Utilities
{
    public static class JsonExtentionMethods
    {
        public static dynamic ToJSON(this MobilitateOutgoing x)
        {
            //Posibilitatea schimbarii denumirilor pentru a fi compatibile
            string NumeSiPrenume = x.PersonalATM.Nume +" "+x.PersonalATM.Prenume;
            string TipMobilitate = x.Mobilitate.CategorieMobilitate.Categorie;
            return new
            {
                x.ID,
                x.DataInceputMobilitate.Year,
                TipMobilitate,
                x.Mobilitate.NivelStudii.Nivel,
                NumeSiPrenume,
            };
        }

        public static dynamic ToJSON(this Tara x)
        {
            return new
            {
                x.ID,
                x.Nume,
                x.NumeRomana,
                x.NumeEngleza
            };
        }
        public static dynamic ToJSON(this Oras x)
        {
            return new
            {
                x.ID,
                x.Nume,
                x.NumeRomana,
                x.NumeEngleza
            };
        }
        public static dynamic ToJSON(this NivelStudii x)
        {
            return new
            {
                x.ID,
                x.Nivel
            };
        }
        public static dynamic ToJSON(this Institutie inst)
        {
            return new
            {
                inst.ID,
                inst.Nume,
                inst.NumeEngleza,
                inst.Acronim,
                inst.AdresaPostala,
                inst.AdresaWeb,
                inst.CodErasmus,
                inst.CodPIC,
                inst.Descriere
            };
        }
        public static dynamic ToJSON(this InstitutiiPartenere x)
        {
            string Oras = x.Oras1.Nume;
            string TipPartener = x.TipPartener1.Denumire;
            return new
            {
                x.ID,
                x.Nume,
                x.NumeRomana,
                x.NumeEngleza,
                Oras,
                TipPartener,
                x.Acronim,
                x.AdresaPostala,
                x.AdresaWeb,
                x.CodErasmus,
                x.CodPIC,
                x.CartaErasmus,
                x.AcordErasmus,
                x.Descriere
            };
        }
        public static dynamic ToJSON(this DepartamenteATM x)
        {
            string Institutie = x.Institutie1.Nume;
            return new
            {
                x.ID,
                x.Nume,
                x.NumeEngleza,
                Institutie,
                x.Acronim,
                x.AdresaPostala,
                x.AdresaWeb,
                x.Descriere
            };
        }
        public static dynamic ToJSON(this DepartamentePartenere x)
        {
            string InstitutiePartenera = x.InstitutiiPartenere.Nume;
            return new
            {
                x.ID,
                x.Nume,
                x.NumeRomana,
                x.NumeEngleza,
                InstitutiePartenera,
                x.Acronim,
                x.AdresaPostala,
                x.AdresaWeb,
                x.Descriere
            };
        }
        public static dynamic ToJSON(this PersonalATM x)
        {
            string Departament = x.DepartamenteATM.Nume;
            string SituatieActuala = x.SituatieActuala1.Denumire;
            string SituatieErasmus = x.SituatieErasmus1.Denumire;
            return new
            {
                x.ID,
                x.Nume,
                x.Prenume,
                x.DataNasterii,
                Departament,
                SituatieActuala,
                SituatieErasmus,
                x.Functie,
                x.Email,
                x.Telefon,
                x.Descriere
            };
        }
        public static dynamic ToJSON(this ParticipantiStraini x)
        {
            string Departament = x.DepartamentePartenere.Nume;
            string SituatieActuala = x.SituatieActuala1.Denumire;
            string SituatieErasmus = x.SituatieErasmus1.Denumire;
            return new
            {
                x.ID,
                x.Nume,
                x.Prenume,
                Departament,
                SituatieActuala,
                SituatieErasmus,
                x.Functie,
                x.Email,
                x.Telefon,
                x.Descriere
            };
        }
        public static dynamic ToJSON(this DetaliiMobilitatiProiect x)
        {
            return new
            {
                //x.ID,
                //x.Nume,
                //x.Prenume,
                //x.Functie,
                //x.Email,
                //x.Telefon,
                //x.Descriere
            };
        }
    }
}