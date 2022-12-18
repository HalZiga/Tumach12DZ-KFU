using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12DZ_KFU
{
    [InfoAttrib("Halil Zigan", Date = "18.12.2022")] // 14.2 
    internal class Building
    {

        protected uint visota;
        public uint Visota
        {
            get { return visota; }
            set { visota = value; }
        }

        private uint etazhnost;
        protected uint Etazhnost
        {
            get { return etazhnost; }
            set { etazhnost = value; }
        }
        private uint lenKvartir;
        private uint LenKvartir
        {
            get { return lenKvartir; }
            set { lenKvartir = value; }
        }
        private uint lenPodezd;
        private uint LenPodezd
        {
            get { return lenPodezd; }
            set { lenPodezd = value; }
        }
        private uint id;
        public uint Id 
        { get { return id; }
            set
            {
                id = value;
            }}
        private HashSet<uint> tut_ID = new HashSet<uint>();//HashSet чтобы закидывать туда и знать был ли такой индивидуум

        public void Set_Paramet(uint Id, uint height, uint floors, uint rooms_count, uint podezd_count)
        {
            this.Id = Id;
            Visota = height;
            Etazhnost = floors;
            LenKvartir = rooms_count;
            LenPodezd = podezd_count;
        }
        public Building(uint height, uint floors, uint rooms_count, uint podezd_count)
        {
            Random rand = new Random();//Типо сами создём ID
            Id = (uint)rand.Next(0, 999);
            if (!tut_ID.Add(id))//закидываем в HashSet и проверяем был или нет
            {
                id += 1;
            }
            Visota = height;
            Etazhnost = floors;
            LenKvartir = rooms_count;
            LenPodezd = podezd_count;
        }
        public void Print()
        {
            Console.WriteLine($"Id дома: {id}" + $"\nВысота дома: {visota}" + $"\nКоличество квартир: {lenKvartir}" +
                $"\nЭтажность: {etazhnost}" + $"\nКоличество подъездов: {lenPodezd}");
        }

        public void visot_etazh()
        {
            Console.WriteLine($"Высота этажа: {(double)visota / (double)etazhnost}");
        }
        public void kol_kvar_pod()
        {
            Console.WriteLine($"Количество квартир в одном подъезде: {lenKvartir / lenPodezd}");
        }
        public void kol_kvar_etazh() => Console.WriteLine($"Количество квартир на этаже: {(lenKvartir / lenPodezd) / etazhnost}");

    }
    internal class Buildingindex
    {
        internal Building[] buildings = new Building[10];
        public Building this[int index]
        {
            get
            {
                return buildings[index];
            }
            set
            {
                buildings[index] = value;
            }
        }

        internal Buildingindex(Building[] buildings)
        {
            this.buildings = buildings;
        }
    }
}
