using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class StaticClass {
    public static string CrossSceneInformation { get; set; }
    public static int ID { get; set; }
    public static int MinWords { get; set; }
    public static int MaxWords { get; set; }
    public static int Lives { get; set; }
    public static int Mod { get; set; }
    public static int Time { get; set; }
    public static GameObject[] Chars { get; set; }

    public static bool walknow { get; set; }

    }
