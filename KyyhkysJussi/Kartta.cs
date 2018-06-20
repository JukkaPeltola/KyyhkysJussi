﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    public class Kartta //Anni, Henni
    {
        // Tehdään lista huoneista

        internal List<Huone> Huoneet = new List<Huone>();
        string[] HuoneenKuvaus =
            {
            "0 Astuit liekkimereen. Olet tulessa ja kuolet.",
            "1 Näet edessäsi luurangon, joka on naapurin mökin isäntä. Hänellä on kädessään mattopiiska ja hän piiskaa mattoja." 
                + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. Idässä näet naapurin mökin länsiseinän."
                + " Ikkunan takana kimaltelee kultakello ja timanttisormus. Kahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.",
            "2 Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                + " näet mattoja hakkaavan naapurin. Talon sisällä näyttää olevan arvokkaita tavaroita, kuten kultakello ja timanttisormus.",
            "3 Olet niityllä joka on täynnä lehmiä. Ne näyttävät olevan rotulehmiä. Pohjoisessa näkyy loimuava liekkimeri. Etelässä näet lisää"
                + " lehmiä. Idässä näkyy aukio ja sen keskellä kumpare, jonka päällä kasvaa iso puu. Lännessä näet aidan ja sen takana luuranko-"
                + "naapurin talon.",
            "4 Olet aukiolla olevan kumpareen luona ja edessäsi näet puun, jonka oksalla istuu Kyyhkys-Jussi. Pohjoisessa liekehtii liekkimeri."
                + "Etelässä näet lehmälauman, jonka yksilöt tuijottavat sinua lehmänsilmillään. Idässä loimuaa liekkimeri. Lännessä näet"
                + " lehmälauman märehtivän.",
            "5 Olet aukiolla, jossa lojuu kasa mattoja, joista kaksi on raidallisia ja kaksi yksivärisiä. Yhden maton kulmaa nykii. Pohjoisessa"
                + " näet omituisesti heiluvan hahmon. Etelässä näet korkean lauta-aidan, jonka raoista sinua kuikuilee fasaani. Idässä näet"
                + " ruohikkoisen aukean, jonka keskellä kiemurtelee pieni polku. Idässä kipinöi liekkimeri.",
            "6 Olet ruohikkoisella aukiolla, jonka läpi kiemurtelee pieni polku. Pohjoisessa häämöttää savupiippu. Polku jatkuu etelään. Idässä" 
                + "näkyy ruohoa ja kumpareita. Lännessä näet myös epämääräisiä kumpareita ruohon keskellä.",
            "7 Olet niityllä joka on täynnä lehmiä. Lehmät näyttävät olevan rotulehmiä, ehkä Ayshire-rotuisia. Lihakarjaa ehdottomasti. Lauman"
                + " johtajalehmä tuijottaa sinua, etkä tiedä onko se vihainen vai ei. Pohjoisessa näet lisää lehmiä. Etelässä näet oman mökkisi"
                + " pohjoisseinän, jonka ikkunasta näet palamaan jättämäsi kynttilän. Toivot, että se ei sytytä tulipaloa. Idässä näet lisää"
                + " lehmiä. Lännessä näet ruohikkoisen aukean, jonka keskellä kiemurtelee pieni polku.",
            "8 Olet niityllä joka on täynnä lehmiä. Nämä ovat maatiaislehmiä, valko-ruskea-läikkäisiä. Et tunnista rotua. Pohjoisessa näet niityn"
                + ", kumpareen ja kumpareella seisovan ison puun. Puun oksalla näkyy liikettä. Etelässä näet kiviaidan, jonka takana vilahtaa"
                + " sateenkaari. Idässä loimuaa liekkimeri. Lännessä näet lehmänhäntien huisketta.",
            "9 Olet niityllä ja näet ison fasaanin, joka tuijottaa sinua isoilla silmillään. Pohjoisessa näet korkean lauta-aidan. Etelässä"
                + " näet leipurin talon, jonka ikkunassa leipuri naputtaa kauhalla kämmeneensä. Idässä näet ruohikkoisen aukean, jonka keskellä"
                + " kiemurtelee polku. Lännessä loimuaa liekkimeri.",
            "10 Olet ruohikkoisella niityllä, jonka keskellä kiemurtelee pieni polku. Polku jatkuu pohjoiseen ja etelään. Idässä näet talosi. Lännessä on komia niitty. Niityllä näyttäisi olevan jonkinlaista liikettä, mutta et oikein erota mikä siellä oikein mäyryää.",
            "11 Olet huoneessa, jossa on pöytä jolla on silinterihattu. Pohjoisella, läntisellä ja itäisellä seinällä on ikkunoita. Etelään päin on ovi, jossa on komea koirajuliste.",
            "12 Kiviaitojen välissä sijaitsee sopivankokoinen laitumen, jolla tepastelee kaunis pinkin- ja sateenkaarenkirjava yksisarvinen. Pohjoiseen päin näet kiviaidan. Lännessä on mökkisi seinä. Idässä oikein kaunis ranta, josta pääsee helposti pulahtamaan liekkimereen halutessaan. Etelään päin näet kulahtaneen kiviaiden ja taivaalla synkkiä pilviä parkkeerattuna taivahalle.",
            "13 Sieraimiisi sulloutuvat suunnattomat sulotuoksut. Mökissä leipuriörkki Okssu vääntää torttua virne naamallaan. Okssu toteaa tomerasti, \"Terve!\" Pullaa paistuu uunissa. Pohjoisseinän ikkunasta avautuu komia niitty, jossa näkyy jonkunlaista liikettä. Itä- ja eteläikkunoista näkyy liekkimeren roihu.",
            "14 Polun risteyksessä on kookkaita kiviä ja pari mäntyä. Polku haarautuu, lännessäpäin on leipurin mökki. Sen piipusta puksuu vienoa sauhua tasaisena virtauksena. Itäänpäin polulla näyttäisi kököttelevän lohikäärme haistelemassa tuulia. Pohjoiseen päin polku jatkuu niitylle ja siitä eteenpäin näkymättömiin. Etelän suunnalla liekkimeri.",
            "15 Etupihallasi on lohikäärme. Se katselee mitä puuhaat. Kevyt pakokauhu paukahtelee pakaroissasi lohikäärmeen katseen alla. Toivot sisimmässäsi, että muistaisit loitsun, jolla lohikäärmeen saisi muutettua mukavammaksi elukaksi. Pohjoiseen päin katsahtaessasi havaitset tutunnäköisen mökin seinän ja kotiovesi. Länteenpäin vie polku mukavahkon näköiselle niitylle. Idässä häämöttävät synkät pilvet ja kivimuuri, jossa on portti. Etelässäpäin liehuu liekkimeri, et tunne suurta vetoa sinne.",
            "16 Taivaalla juuri tällä kohdalla on varsin synkkiä pilviä. Karut koivut muodostavat käytävän, jonka reunoilla on hautakiviä. Edessäsi maassa töröttää puolittain esillä oleva reisiluu. Pohjoisessa näet kiviaidan, jonka taa ei nää kovin hyvin. Lännessä on hautausmaan portti, jonka takaa erotat lohikäärmeisiä muotoja. Idässä näet kiviaidan, jonka takana loimottelee lämmin liekkimeri. Etelässäkin näet kiviaidan, jonka takana loimottelee lämmin liekkimeri.",
            "17 Saavut kääpiöin salatulle saarelle. Selkäpiissäsi tunnet sellaista kutinaa, että kohta lähtee sokka irti. Olet päässyt kääpiöiden Shangri-La:han - Kuppakivelle! Nyt voit rauhassa mainaroida sielusi kyllyydestä seurassa, joka ei tuomitse tauhkaamistasi."};
        
        public Kartta()
        {
            return;
        }
        public void TeeHuoneLista()
        {
            foreach (var k in HuoneenKuvaus)
            {
                Huone huone = new Huone(k);
                Huoneet.Add(huone);
            }
        }
    }
}
