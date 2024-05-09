using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements.Experimental;


public enum Tarina
{
    ranta, keskiyö, syksy, leipuri, ranta2, keskiyö2
}

public class Results : MonoBehaviour
{
    public Tarina tarina;

    public static Results instance;

    TextMeshProUGUI resultTXT;


    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        resultTXT = GetComponentInChildren<TextMeshProUGUI>();
        resultTXT.text = "";

        if (tarina == Tarina.syksy)
        {
            Syksy();
        }

        if (tarina == Tarina.ranta)
        {
            Ranta();
        }

        if (tarina == Tarina.keskiyö)
        {
            Keskiyö();
        }

        if (tarina == Tarina.leipuri)
        {
            Leipuri();
        }

        if (tarina == Tarina.ranta2)
        {
            Ranta2();
        }

        if (tarina == Tarina.keskiyö2)
        {
            Keskiyö2();
        }
    }

    public void Syksy()
    {
        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
                "Metsä on jo syksyinen, \nviileä ja " + choices[0] + ". \n\n" +
                "Vaan sienet kasvavat sateessa, \nmäntymetsän " + choices[1] + ". \n\n" +
                "Kerään koriini sieniä, \nkauniita, suuria, " + choices[2] + ". \n\n" +
                "Tatti helppo ja herkullinen, \noloni rauhaisa, " + choices[3] + ". \n\n" +
                "Suppilovahvero sammaleella seisoo, \nsade ropisee ja tuuli " + choices[4] + ". \n" +
                "Kantarelli piilossa pysyy, \nniiden löytäminen onnea " + choices[5] + ". \n\n" +
                "Jo päättyy retki sienien mailla, \nväsyä alan metsän eläinten " + choices[6] + ". \n\n" +
                "Metsää katson ja hiljaa kiitän, \nretken mieleni muistoihin " + choices[7] + ". \n\n" +
                "Muistan metsän, sen tarinan syvän, \nrauhan tunteen ja oloni " + choices[8] + ".";

        }
    }

    public void Ranta()
    {
        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
                "Herään " + choices[0] + " aamuun,\nja päätän lähteä uimarannalle.\n" +
                "Ensin minun täytyy kuitenkin " + choices[1] + ". \n\n" +
                "Sen jälkeen pakkaan reppuni.\nTarvitsen mukaani ainakin uimapuvun, " + choices[2] + " ja välipalaa.\n" +
                "Välipalaksi otan " + choices[3] + ".\n\n" +
                "Rannalle on lyhyt matka.\nPäätän mennä sinne " + choices[4] + ".\n" +
                "Ennen lähtöä kysyn vielä,\nlähtisikö " + choices[5] + " mukaani.\n\n" +
                "Saavumme rannalle.\nHuomaamme heti, että siellä on paljon " + choices[6] + ".\n" +
                "Löydämme kuitenkin paikan " + choices[7] + ".\n\n" +
                "Jätämme tavaramme paikallemme\nja lähdemme " + choices[8] + ".\n" +
                "Välillä " + choices[9] + " ja syömme välipalaa.\n\n" +
                "Meillä on hauskaa!\nAika kuluu nopeasti,\nja yhtäkkiä olemme olleet rannalla " + choices[10] + ".\n" +
                "Päätän kysyä:\n”Olisiko jo aika lähteä " + choices[11] + "?";

        }
    }

    public void Keskiyö()
    {
        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
                "Olipa kerran hylätty talo " + choices[0] + ".\n" +
                "Talo oli vanha ja ränsistynyt. Sen seinistä " + choices[1] + ".\n" +
                "Huhujen mukaan talossa oli asunut " + choices[2] + "sata vuotta sitten.\n\n" +
                "Sen jälkeen siellä oli asunut eräs " + choices[3] + ", mutta talo oli ollut tyhjillään jo vuosia.\n" +
                "Vaikka talo oli tyhjä, se ei ollut hiljainen. Aina keskiyöllä talosta kuului " + choices[4] + ".\n\n" +
                "Keskiyön kauheudet vetivät ihmisiä puoleensa, ja eräänä yönä joukko nuoria kokoontui hylätyllä talolla.\n" +
                "Nuoret olivat " + choices[5] + ", kun he odottivat keskiyötä." + ".\n\n" +
                "Viimein kello löi kaksitoista. Äänet alkoivat kuulua, ja " + choices[6] + ".\n" +
                "Yksi nuorista kurkisti sisään ja sanoi kavereilleen: ”Ette ikinä usko, mutta talossa on " + choices[7] + ".";

        }
    }

    public void Leipuri()
    {
        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
            "Keittiössä kököttää kekseliäs leipuri,\nmaailman makeimpien herkkujen " + choices[0] + ".\n\n" +
            "Mitä seuraavaksi leipoisin?\nMistä herkkusuille " + choices[1] + ".\n\n" +
            "Leipoisinko keksin suklaisen\nvai kuppikakun " + choices[2] + ".\n\n\n" +
            "Leipuri keksii idean:\n”Teen kakun oikein " + choices[3] + "\".\n\n" +
            "Sokeria, munia, jauhoja,\nvoita, marenkia, " + choices[4] + ".\n\n" +
            "Oikein paljon kerroksia,\nripaus rakkautta ja " + choices[5] + ".\n\n" +
            "Syntyy resepti ainutkertainen,\ntäytekakku " + choices[6] + ".\n\n" +
            "Nyt leipurin unelma todelta näyttää,\nse mahat ja mielet ilolla " + choices[7] + ".";

        }

    }

    public void Ranta2()
    {

        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
            "Herään aurinkoiseen aamuun,\nja päätän lähteä " + choices[0] + ".\nEnsin minun täytyy kuitenkin syödä aamupala.\n\n" +
            "Sen jälkeen pakkaan reppuni.\nTarvitsen mukaani ainakin " + choices[1] + ", pyyhkeen ja välipalaa.\n" +
            "Välipalaksi otan " + choices[2] + ".\n\n" +
            choices[3] + " on lyhyt matka. Päätän mennä sinne kävellen.\n" +
            "Ennen " + choices[4] + " kysyn vielä, lähtisikö ystäväni mukaani.\n" +
            "Saavumme rannalle.\nHuomaamme heti, että siellä on paljon " + choices[5] + ".\n" +
            "Löydämme kuitenkin paikan suuren puun " + choices[6] + ".\n\n" +
            "Jätämme tavaramme paikallemme ja lähdemme " + choices[7] + ".\n" +
            "Välillä lepäämme ja syömme " + choices[8] + ".\n\n" +
            "Meillä on hauskaa!\nAika kuluu nopeasti,ja yhtäkkiä olemme olleet " + choices[9] + " neljä tuntia." +
            "Päätän kysyä: ”Olisiko jo aika lähteä " + choices[10] + "?”";

        }
    }

    public void Keskiyö2()
    {

        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
            "Olipa kerran hylätty talo " + choices[0] + " syrjäisessä kylässä.\n" +
            "Talo oli vanha ja ränsistynyt.\nSen seinistä kasvoi " + choices[1] + ".\n\n" +
            "Huhujen mukaan " + choices[2] + " oli asunut noitia sata vuotta sitten.\n" +
            "Sen jälkeen siellä oli asunut eräs " + choices[3] + "\nmutta talo oli ollut tyhjillään jo vuosia.\n\n" +
            "Vaikka talo oli tyhjä, se ei ollut hiljainen.\nAina keskiyöllä talosta kuului " + choices[4] + " kolinaa.\n\n" +
            "Keskiyön kauheudet vetivät ihmisiä puoleensa,\nja eräänä yönä joukko nuoria kokoontui hylätyllä talolla.\n" + choices[5] + " olivat peloissaan, kun he odottivat keskiyötä.\n\n" +
            "Viimein kello löi kaksitoista.\nÄänet alkoivat kuulua, ja " + choices[6] + " nousi savua.\n\n" +
            "Yksi " + choices[7] + " kurkisti sisään ja sanoi kavereilleen:\n”Ette ikinä usko, mutta talossa on kummitus.”";

        }
    }
}
