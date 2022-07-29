using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public List<string> Translated = new();

    public static int GetUnixTime()
    {
        return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
    }

    readonly int start = 0;
    public int time = 5;
    public int MinWords = 0;
    public int MaxWords = 2;
    

    void Start() 
    { 
        StaticClass.MaxWords = MaxWords;
        StaticClass.MinWords = MinWords;
        if (StaticClass.CrossSceneInformation == "Yugara") {
            string[] Animals = { "Juwanbin", "Kabul", "Wawal","Mirri","Juwehrr","Ngurun","Jawan",
            "Yarraman","Barrar","Dumbirrbi","Bulualum","Kubbi","Powai","Bui","Chibur","Garril" };
            foreach (string anim in Animals) {
                Translated.Add(anim); } }

        if (StaticClass.CrossSceneInformation == "Yugarabul") {
            string[] Animals = { "Juwahnduwan", "Kabul", "Wagan","Mirri","Juwehrr","Ngurun","Guyurr",
            "Yarraman","Barrar","Marrambi","Bulualum","Kubbi","Powai","Bui","Chibur","Garril" };
            foreach (string anim in Animals) {
                Translated.Add(anim); } }

        if (StaticClass.CrossSceneInformation == "Yugambeh") {
            string[] Animals = {"Noangbil","Kabul","Wagahn","Ngurun","Mibunn","Murun","Jalumm","Yarraman",
            "Muni","Borobi","Chungarra","Guran","Bowai","Jomgwong","Jiburr","Karil"};
            foreach (string anim in Animals) {
                Translated.Add(anim); } }

        if (StaticClass.CrossSceneInformation == "Turubul") {
            string[] Animals = {"Juwahnduwan","Kabul","Wowa","Mirri","Dibbil","Nguyi","Kuyur",
            "Yarraman","Gurooman","Dumbirrbi","Bulualum","Kubbi","Powai","Tumgu","Chibur","Garril"};
            foreach (string anim in Animals) {
                Translated.Add(anim);
            }
        }

    }
    void Update(){
    DisplayNew(start);
    }
    void DisplayNew(int start)
    {
        int timeStamp2 = GetUnixTime();

        var timeDiff = timeStamp2 - start;
        StaticClass.Time = time;
        StaticClass.Mod = timeDiff % StaticClass.Time;
        
        if (StaticClass.walknow == true)
        {
            scoreText.text = "Walk Forward";
        }
        else
        {
        if (StaticClass.Mod == 0
            && timeDiff != 0)
            {        
            StaticClass.ID = UnityEngine.Random.Range(0, StaticClass.MaxWords+1);
            string word = Translated[StaticClass.ID];
            scoreText.text = word.ToString();
        }

        else if (timeDiff < StaticClass.Time)
        {
            scoreText.text = "Wait for the word!";
        }
        }

    }








}