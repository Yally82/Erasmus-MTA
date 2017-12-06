using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Erasmus_MTA.Models;


//Robert: Detalii Mobilitate Trebuie completat. Nu stiu ce inseamna
namespace Erasmus_MTA.Utilities
{
    public static class JsonExtentionMethods
    {
        public static dynamic ToJSON(this ProiecteMobilitati x)
        {
            //Posibilitatea schimbarii denumirilor pentru a fi compatibile
           
            return new
            {
                x.ID,
               x.Descriere
            };
        }

        public static dynamic ToJSONID(this MobilitateOutgoing x)
        {
            //Posibilitatea schimbarii denumirilor pentru a fi compatibile

            return new
            {
                x.ID,
                x.ProiectMobilitate,
                x.ParticipantATM,
                x.DepartamentATM,
                x.PersoanaResponsabilaATM,
                x.InstitutiePartenera,
                x.DepartamentPartener,
                x.PersoanaStrainaContact,
                x.TipMobilitati,
                x.DomeniuMobilitate,
                x.DataInceputMobilitate,
                x.DataFinalMobilitate,
                x.GrantErasmusUtilizat,
                x.NrZileMobilitate,
                x.NrLuniMobilitate,
                x.Descriere
            };
        }

        public static dynamic ToJSONID(this MobilitateIncoming x)
        {
            return new
            {
                x.ID,
                x.ProiectMobilitate,
                x.ParticipantStrain,
                x.InstitutiePartenera,
                x.DepartamentPartener,
                x.PersoanaStrainaContact,
                x.DepartamentATM,
                x.PersoanaResponsabilaATM,
                x.TipMobilitati,
                x.DomeniuMobilitate,
                x.DataInceputMobilitate,
                x.DataFinalMobilitate,
                x.NrZileMobilitate,
                x.NrLuniMobilitate,
                x.Descriere
            };
        }

        public static dynamic ToJSON(this MobilitateOutgoing x)
        {
            //Posibilitatea schimbarii denumirilor pentru a fi compatibile
            string NumeSiPrenume = x.PersonalATM.Nume +" "+x.PersonalATM.Prenume;
            string TipMobilitate = x.Mobilitate.CategorieMobilitate.Categorie;
            double nrZile = (x.DataFinalMobilitate - x.DataInceputMobilitate).TotalDays;
            int nrLuni = (x.DataFinalMobilitate.Year - x.DataInceputMobilitate.Year) * 12 + x.DataFinalMobilitate.Month - x.DataInceputMobilitate.Month;
            string institutiePartenera = x.InstitutiiPartenere.Nume;
            string Nivel = x.Mobilitate.NivelStudii.Nivel;
            return new
            {
                x.ID,
                x.DataInceputMobilitate.Year,
                TipMobilitate,
                Nivel,
                NumeSiPrenume,
                x.DataInceputMobilitate,
                x.DataFinalMobilitate,
                institutiePartenera,
                x.GrantErasmusUtilizat,
                x.PersonalATM.Nume,
                x.PersonalATM.Prenume,
                nrLuni,
                nrZile
            };
        }

        public static dynamic ToJSON(this MobilitateIncoming x)
        {
            //Posibilitatea schimbarii denumirilor pentru a fi compatibile
            string NumeSiPrenume = x.PersonalATM.Nume + " " + x.PersonalATM.Prenume;
            string TipMobilitate = x.Mobilitate.CategorieMobilitate.Categorie;
            double nrZile = (x.DataFinalMobilitate - x.DataInceputMobilitate).TotalDays;
            int nrLuni = (x.DataFinalMobilitate.Year - x.DataInceputMobilitate.Year) * 12 + x.DataFinalMobilitate.Month - x.DataInceputMobilitate.Month;
            string institutiePartenera = x.InstitutiiPartenere.Nume;
            string Nivel = x.Mobilitate.NivelStudii.Nivel;
            string dummy = "NULL";
            return new
            {
                x.ID,
                x.DataInceputMobilitate.Year,
                TipMobilitate,
                Nivel,
                NumeSiPrenume,
                x.DataInceputMobilitate,
                x.DataFinalMobilitate,
                institutiePartenera,
                dummy,
                x.PersonalATM.Nume,
                x.PersonalATM.Prenume,
                nrLuni,
                nrZile
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
    }
}