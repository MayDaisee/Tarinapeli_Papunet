using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements.Experimental;


public enum Tarina
{
    ranta, keskiyö, syksy, leipuri
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
                "Herään " + choices[0] + " aamuun, ja päätän lähteä uimarannalle.\n" +
                "Ensin minun täytyy kuitenkin " + choices[1] + ". \n" +
                "Sen jälkeen pakkaan reppuni. Tarvitsen mukaani ainakin uimapuvun, " + choices[2] + " ja välipalaa.\n" +
                "Välipalaksi otan " + choices[3] + ".\n" +
                "Rannalle on lyhyt matka. Päätän mennä sinne " + choices[4] + ".\n" +
                "Ennen lähtöä kysyn vielä, lähtisikö " + choices[5] + " mukaani.\n\n" +
                "Saavumme rannalle. Huomaamme heti, että siellä on paljon " + choices[6] + ".\n" +
                "Löydämme kuitenkin paikan " + choices[7] + ".\n" +
                "Jätämme tavaramme paikallemme ja lähdemme " + choices[8] + ".\n" +
                "Välillä " + choices[9] + " ja syömme välipalaa.\n" +
                "Meillä on hauskaa! Aika kuluu nopeasti, ja yhtäkkiä olemme olleet rannalla " + choices[10] + ".\n" +
                "Päätän kysyä: ”Olisiko jo aika lähteä " + choices[11] + "?";

        }
    }
}
