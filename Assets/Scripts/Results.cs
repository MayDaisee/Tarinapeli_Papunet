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
                "Metsä on jo syksyinen, viileä ja " + choices[0] + ". \n" +
                "Vaan sienet kasvavat sateessa mäntymetsän " + choices[1] + ". \n" +
                "Kerään koriini sieniä, kauniita, suuria, " + choices[2] + ". \n" +
                "Tatti helppo ja herkullinen, oloni rauhaisa, " + choices[3] + ". \n" +
                "Suppilovahvero sammaleella seisoo, sade ropisee ja tuuli " + choices[4] + ". \n" +
                "Kantarelli piilossa pysyy, niiden löytäminen onnea " + choices[5] + ". \n" +
                "Jo päättyy retki sienien mailla, väsyä alan metsän eläinten " + choices[6] + ". \n" +
                "Metsää katson ja hiljaa kiitän, retken mieleni muistoihin " + choices[7] + ". \n" +
                "Muistan metsän, sen tarinan syvän, rauhan tunteen ja oloni " + choices[8] + ".";


        }


    }
}
