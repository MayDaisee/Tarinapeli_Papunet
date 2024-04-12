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
}
