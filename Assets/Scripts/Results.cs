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
}
