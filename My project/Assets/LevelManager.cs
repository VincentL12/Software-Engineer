using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform Start;
    public Transform[] Check;

    private void Awake()
    {
        main = this;
    }

}
