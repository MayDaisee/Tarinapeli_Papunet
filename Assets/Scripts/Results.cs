using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements.Experimental;


public enum Tarina
{
    ranta, keskiy�, syksy, leipuri
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

        if (tarina == Tarina.keskiy�)
        {
            Keskiy�();
        }
    }

    public void Syksy()
    {
        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
                "Mets� on jo syksyinen, \nviile� ja " + choices[0] + ". \n\n" +
                "Vaan sienet kasvavat sateessa, \nm�ntymets�n " + choices[1] + ". \n\n" +
                "Ker��n koriini sieni�, \nkauniita, suuria, " + choices[2] + ". \n\n" +
                "Tatti helppo ja herkullinen, \noloni rauhaisa, " + choices[3] + ". \n\n" +
                "Suppilovahvero sammaleella seisoo, \nsade ropisee ja tuuli " + choices[4] + ". \n" +
                "Kantarelli piilossa pysyy, \nniiden l�yt�minen onnea " + choices[5] + ". \n\n" +
                "Jo p��ttyy retki sienien mailla, \nv�sy� alan mets�n el�inten " + choices[6] + ". \n\n" +
                "Mets�� katson ja hiljaa kiit�n, \nretken mieleni muistoihin " + choices[7] + ". \n\n" +
                "Muistan mets�n, sen tarinan syv�n, \nrauhan tunteen ja oloni " + choices[8] + ".";

        }
    }

    public void Ranta()
    {
        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
                "Her��n " + choices[0] + " aamuun, ja p��t�n l�hte� uimarannalle.\n" +
                "Ensin minun t�ytyy kuitenkin " + choices[1] + ". \n" +
                "Sen j�lkeen pakkaan reppuni. Tarvitsen mukaani ainakin uimapuvun, " + choices[2] + " ja v�lipalaa.\n\n" +
                "V�lipalaksi otan " + choices[3] + ".\n" +
                "Rannalle on lyhyt matka. P��t�n menn� sinne " + choices[4] + ".\n" +
                "Ennen l�ht�� kysyn viel�, l�htisik� " + choices[5] + " mukaani.\n\n" +
                "Saavumme rannalle. Huomaamme heti, ett� siell� on paljon " + choices[6] + ".\n" +
                "L�yd�mme kuitenkin paikan " + choices[7] + ".\n" +
                "J�t�mme tavaramme paikallemme ja l�hdemme " + choices[8] + ".\n\n" +
                "V�lill� " + choices[9] + " ja sy�mme v�lipalaa.\n" +
                "Meill� on hauskaa! Aika kuluu nopeasti, ja yht�kki� olemme olleet rannalla " + choices[10] + ".\n" +
                "P��t�n kysy�: �Olisiko jo aika l�hte� " + choices[11] + "?";

        }
    }

    public void Keskiy�()
    {
        List<string> choices = Choices.instance.choices;

        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
                "Olipa kerran hyl�tty talo " + choices[0] + ".\n" +
                "Talo oli vanha ja r�nsistynyt. Sen seinist� " + choices[1] + ".\n" +
                "Huhujen mukaan talossa oli asunut " + choices[2] + "sata vuotta sitten.\n\n" +
                "Sen j�lkeen siell� oli asunut er�s " + choices[3] + ", mutta talo oli ollut tyhjill��n jo vuosia.\n" +
                "Vaikka talo oli tyhj�, se ei ollut hiljainen. Aina keskiy�ll� talosta kuului " + choices[4] + ".\n\n" +
                "Keskiy�n kauheudet vetiv�t ihmisi� puoleensa, ja er��n� y�n� joukko nuoria kokoontui hyl�tyll� talolla.\n" +
                "Nuoret olivat " + choices[5] + ", kun he odottivat keskiy�t�." + ".\n\n" +
                "Viimein kello l�i kaksitoista. ��net alkoivat kuulua, ja " + choices[6] + ".\n" +
                "Yksi nuorista kurkisti sis��n ja sanoi kavereilleen: �Ette ikin� usko, mutta talossa on " + choices[7] + ".\n";

        }
    }
}
