using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text skorKiri;
    public Text skorKanan;
    public Text skorAtas;
    public Text skorBawah;

    public ScoreManager manager;

    private void Update()
    {
        skorKiri.text = manager.scoreL.ToString();
        skorKanan.text = manager.scoreR.ToString();
        skorAtas.text = manager.scoreT.ToString();
        skorBawah.text = manager.scoreB.ToString();
    }
}
