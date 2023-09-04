using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFTD1Main10 : MonoBehaviour
{
    public static int NFt10D1Amount;

    private void Awake()
    {
        NFt10D1Amount = PlayerPrefs.GetInt("NFt10D1Amount", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
