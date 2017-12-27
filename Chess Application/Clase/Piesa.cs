﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;


namespace Chess_Application
{
    public class Piesa
    {
        public PictureBox imaginePiesa;
        public PictureBox imagineMicaPiesa;
        public Piesa()
        {

        }
        public Piesa(int c, int t, PictureBox pct)//constructor cu initializare tip si culoare piesa
        {
            culoare = c;
            tipPiesa = t;
            imaginePiesa = pct;
        }
        public Piesa(int t, PictureBox pct)//constructor cu initializare tip piesa(in cazul in care piesele sunt albe, nefiind necesara initializarii valorii culoare)
        {
            tipPiesa = t;
            imaginePiesa = pct;
        }
        public int culoare = 1;//1-alb, 2-negru;
        public int tipPiesa = 0;//0-nici una, 1-pion, 2-tura, 3-cal, 4-nebun, 5-regina, 6-rege;
        public virtual void VerificaPosibilitati(int i, int j, LocatieTabla[,] loc)//self-explanatory -  verifica posibilitatile de miscare a piesei: tipul ofera comportamentul miscarii, iar culoarea directia in cazul pioniilor...
        {

        }

        public bool SahAlb()
        {
            return true;
        }
        public bool SahAlb(LocatieTabla[,] loc, int orig1, int orig2, int curent1, int curent2)
        {
            int i = Form1.pozitieRegeAlb[0];//linia rege
            int j = Form1.pozitieRegeAlb[1];//coloana rege
            Console.WriteLine("Pozititie rege: " + i + " " + j);
            int tempCuloareOrig = loc[orig1, orig2].culoare;
            int tempCuloareCurent = loc[curent1, curent2].culoare;
            loc[orig1, orig2].culoare = 0;
            loc[curent1, curent2].culoare = 1;
            if (loc[i + 1, j - 1].culoare == 2 && loc[i + 1, j - 1].tipPiesa == 1)  
            {
                loc[orig1, orig2].culoare = tempCuloareOrig;
                loc[curent1, curent2].culoare = tempCuloareCurent;
                return true;
            }
            if (loc[i + 1, j + 1].culoare == 2 && loc[i + 1, j + 1].tipPiesa == 1) 
            {
                loc[orig1, orig2].culoare = tempCuloareOrig;
                loc[curent1, curent2].culoare = tempCuloareCurent;
                return true;
            }
            int ct1 = 0;
            int ct2 = 0;
            int ct3 = 0;
            int ct4 = 0;
            Console.WriteLine("----------------------------------------------------");
            for (int k = j; k >= 1; k--)
            {
                ct1++;
                Console.WriteLine("Pe linia " + i + ", coloana" + k + " se afla tipPiesa = " + loc[i, k].tipPiesa + " de culoare " + loc[i, k].culoare);
                if (loc[i, k].culoare != loc[i, j].culoare)
                {
                    if ((loc[i, k].tipPiesa == 2 || loc[i, k].tipPiesa == 5) && loc[i, k].culoare == 2)
                    {
                        loc[orig1, orig2].culoare = tempCuloareOrig;
                        loc[curent1, curent2].culoare = tempCuloareCurent;
                        Console.WriteLine("sah la verificare in stanga");
                        return true;
                    }
                }
                if (loc[i, k].culoare == loc[i, j].culoare && loc[i, k] != loc[i, j]) break;
                if ((loc[i, k].culoare == 2) && loc[i, k].tipPiesa != 2 && loc[i, k].tipPiesa != 5) break;
            }
            Console.WriteLine("----------------------------------------------------");
            for (int k = j; k <= 8; k++)
            {
                ct2++;
                Console.WriteLine("Pe linia " + i + ", coloana" + k + " se afla tipPiesa = " + loc[i, k].tipPiesa + " de culoare " + loc[i, k].culoare);
                if (loc[i, k].culoare != loc[i, j].culoare)
                {
                    if ((loc[i, k].tipPiesa == 2 || loc[i, k].tipPiesa == 5) && loc[i, k].culoare == 2)
                    {
                        loc[orig1, orig2].culoare = tempCuloareOrig;
                        loc[curent1, curent2].culoare = tempCuloareCurent;
                        Console.WriteLine("sah la verificare in dreapta");
                        return true;
                    }
                }
                if (loc[i, k].culoare == loc[i, j].culoare && loc[i, k] != loc[i, j]) break;
                if ((loc[i, k].culoare == 2) && loc[i, k].tipPiesa != 2 && loc[i, k].tipPiesa != 5) break;

            }
            Console.WriteLine("----------------------------------------------------");
            for (int k = i; k >= 1; k--)
            {
                ct3++;
                Console.WriteLine("Pe linia " + k + ", coloana" +j + " se afla tipPiesa = " + loc[k, j].tipPiesa + " de culoare " + loc[k, j].culoare);
                if (loc[k, j].culoare != loc[i, j].culoare)
                {
                    if ((loc[k, j].tipPiesa == 2 || loc[k, j].tipPiesa == 5) && loc[k, j].culoare == 2)
                    {
                        loc[orig1, orig2].culoare = tempCuloareOrig;
                        loc[curent1, curent2].culoare = tempCuloareCurent;
                        Console.WriteLine("sah la verificare in jos");
                        return true;
                    }
                }
                if (loc[k, j].culoare == loc[i, j].culoare && loc[k, j] != loc[i, j]) break;
                if ((loc[k, j].culoare == 2) && loc[k, j].tipPiesa != 2 && loc[k, j].tipPiesa != 5) break;
            }
            Console.WriteLine("----------------------------------------------------");
            for (int k = i; k <= 8; k++)
            {
                ct4++;
                Console.WriteLine("Pe linia " + k + ", coloana" + j + " se afla tipPiesa = " + loc[k, j].tipPiesa + " de culoare " + loc[k, j].culoare);
                if (loc[k, j].culoare != loc[i, j].culoare)
                {
                    if ((loc[k, j].tipPiesa == 2 || loc[k, j].tipPiesa == 5) && loc[k, j].culoare == 2)
                    {
                        loc[orig1, orig2].culoare = tempCuloareOrig;
                        loc[curent1, curent2].culoare = tempCuloareCurent;
                        Console.WriteLine("sah la verificare in sus");
                        return true;
                    }
                }
                if (loc[k, j].culoare == loc[i, j].culoare && loc[k, j] != loc[i, j]) break;
                if ((loc[k, j].culoare == 2) && loc[k, j].tipPiesa != 2 && loc[k, j].tipPiesa != 5) break;
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ct1: " + ct1 + ", ct2: " + ct2 + ", ct3: " + ct3 + ", ct4: " + ct4);
            //=====
            /*for (int l = i, c = j; l >= 1 && c >= 1; l--, c--)
            {
                if (loc[i, j].culoare != loc[l, c].culoare)
                {
                    loc[l, c].Marcheaza();
                    loc[i, j].poateFaceMiscari = true;
                }
                if (culoare == 1)
                {
                    if (loc[l - 1, c - 1] != null && (loc[l - 1, c - 1].culoare == 1 || loc[l, c].culoare == 2)) break;
                }
                if (culoare == 2)
                {
                    if (loc[l - 1, c - 1] != null && (loc[l - 1, c - 1].culoare == 2 || loc[l, c].culoare == 1)) break;
                }
            }
            for (int l = i, c = j; l <= 8 && c <= 8; l++, c++)
            {
                if (loc[i, j].culoare != loc[l, c].culoare)
                {
                    loc[l, c].Marcheaza();
                    loc[i, j].poateFaceMiscari = true;
                }
                if (culoare == 1)
                {
                    if (loc[l + 1, c + 1] != null && (loc[l + 1, c + 1].culoare == 1 || loc[l, c].culoare == 2)) break;
                }
                if (culoare == 2)
                {
                    if (loc[l + 1, c + 1] != null && (loc[l + 1, c + 1].culoare == 2 || loc[l, c].culoare == 1)) break;
                }
            }
            for (int l = i, c = j; l <= 8 && c >= 1; l++, c--)
            {
                if (loc[i, j].culoare != loc[l, c].culoare)
                {
                    loc[l, c].Marcheaza();
                    loc[i, j].poateFaceMiscari = true;
                }
                if (culoare == 1)
                {
                    if (loc[l + 1, c - 1] != null && (loc[l + 1, c - 1].culoare == 1 || loc[l, c].culoare == 2)) break;
                }
                if (culoare == 2)
                {
                    if (loc[l + 1, c - 1] != null && (loc[l + 1, c - 1].culoare == 2 || loc[l, c].culoare == 1)) break;
                }
            }
            for (int l = i, c = j; l >= 1 && c <= 8; l--, c++)
            {
                if (loc[i, j].culoare != loc[l, c].culoare)
                {
                    loc[l, c].Marcheaza();
                    loc[i, j].poateFaceMiscari = true;
                }
                if (culoare == 1)
                {
                    if (loc[l - 1, c + 1] != null && (loc[l - 1, c + 1].culoare == 1 || loc[l, c].culoare == 2)) break;
                }
                if (culoare == 2)
                {
                    if (loc[l - 1, c + 1] != null && (loc[l - 1, c + 1].culoare == 2 || loc[l, c].culoare == 1)) break;
                }
            }*/
            Console.WriteLine("pe pozitia 3,5 se exista: " + loc[3, 5].tipPiesa + " de culoarea: " + loc[3, 5].culoare);
            loc[orig1, orig2].culoare = tempCuloareOrig;
            loc[curent1, curent2].culoare = tempCuloareCurent;
            return false;
        }
    }
}
