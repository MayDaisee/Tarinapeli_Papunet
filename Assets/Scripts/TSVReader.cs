using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class TSVReader : MonoBehaviour
{
    public static TSVReader instance;         //T‰ll‰ toiset scriptit p‰‰see k‰siksi t‰h‰n koodiin     

    TextMeshProUGUI tmpComponent;             //TextMeshPro on se varsinainen tekstikomponentti, johon t‰ll‰ scriptill‰ vaikutetaan

    public TextAsset dynamicText;             //Editorista voidaan asettaa tekstitiedosto, josta varsinaiset tekstinp‰tk‰t haetaan tekstikomponenttiin
    public GameObject results;

    readonly List<string> ids = new();        //Tallennustila listalle, readonly koska emme halua tehd‰ varsinaiseen listaan muutoksia koodissa, vaan ainoastaan tekstitiedostossa

    private void Awake()
    {
        instance = this;                      
    }

    private void Start()
    {
        tmpComponent = GetComponentInChildren<TextMeshProUGUI>();       //Hakee TextMeshPro-komponentin sen objektin lapsista, johon koodi asetettu.

        ReadTSV();                                                      //Suoritetaan kyseinen funktio
        UpdateText();                                                   //-"-
    }

    void ReadTSV()
    {
        string[] lines = dynamicText.text.Split(";");                   //T‰ll‰ jaetaan tekstitiedoston string riveihin hakemalla textasset ja ilmoittamalla, mik‰ merkki jakaa seuraavalle riville (.csv-tiedostoissa default pilkku)

 
        foreach (string line in lines)                                  //ja niin monta rivi‰ teksti‰ mit‰ t‰m‰n ohjeen mukaan lˆytyy
        {
            ids.Add(line);                                              //lis‰t‰‰n koodiin tallennetulle listatilalle yksi list item per rivi
        }
    }

    void UpdateText()
    {

        if (tmpComponent != null && ids.Count > 0)                      //Jos TMP-komponentti lˆytyy, ja listassa on m‰‰ritelty enemm‰n kuin yksi rivi
        {

            tmpComponent.text = ids[0];                                 //Komponenttiin kirjoittuu listalla ensimm‰isen‰ oleva rivi

        }

        else
        {
            Debug.LogError("Text component not assigned or list not configd"); 
        }
    }

    public void ChangeText()                                            //Funktio, jonka kutsumme klikkaamalla (Choices-scriptist‰)
    {

        if (ids.Count > 1)                                              //Jos listassa on enemm‰n kuin yksi item
        {
            ids.RemoveAt(0);                                            //Poistamme 0-kohdassa, eli t‰m‰nhetkisen rivin listasta

            UpdateText();                                               //tilalle p‰ivittyy uusi 0-kohta, eri j‰rjestyksess‰ seuraava rivi
        }


        else                                                                             //muussa tapauksessa 
        {
            GameObject[] readers = GameObject.FindGameObjectsWithTag("Reader");          //Tehd‰‰n array nimelt‰ readers, joka ottaa itseens‰ kaikki objektit jotka ovat t‰g‰tty vastaavalla tavalla

            foreach (GameObject reader in readers)                                       //Jotta vaikutetaan jokaiseen instanssiin niist‰
            {

                reader.SetActive(false);                                                 //T‰m‰ tapahtuu

            }

            if (results != null)                                                          //Mik‰li nappi josta t‰m‰ kutsutaan sis‰lt‰‰ m‰‰rittelem‰mme gameobjectin "results"
            {
                results.SetActive(true);                                                 //Se aktivoituu
            }

        }
    }

}
