using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Results : MonoBehaviour
{
    TextMeshProUGUI resultTXT;

    private void Start()
    {
        resultTXT = GetComponentInChildren<TextMeshProUGUI>();

        resultTXT.text = "";

        List<string> choices = Choices.instance.choices;


        for (int i = 0; i < choices.Count; i++)
        {

            resultTXT.text =
                "Mets� on jo syksyinen, viile� ja " + choices[0] + ". \n" +
                "Vaan sienet kasvavat sateessa m�ntymets�n " + choices[1] + ". \n" +
                "Ker��n koriini sieni�, kauniita, suuria, " + choices[2] + ". \n" +
                "Tatti helppo ja herkullinen, oloni rauhaisa, " + choices[3] + ". \n" +
                "Suppilovahvero sammaleella seisoo, sade ropisee ja tuuli " + choices[4] + ". \n" +
                "Kantarelli piilossa pysyy, niiden l�yt�minen onnea " + choices[5] + ". \n" +
                "Jo p��ttyy retki sienien mailla, v�sy� alan mets�n el�inten " + choices[6] + ". \n" +
                "Mets�� katson ja hiljaa kiit�n, retken mieleni muistoihin " + choices[7] + ". \n" +
                "Muistan mets�n, sen tarinan syv�n, rauhan tunteen ja oloni " + choices[8] + ".";


        }


    }
}
